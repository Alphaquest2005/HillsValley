using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Timers;
using log4netWrapper;

using QBDownload.Properties;
using QS2QBPost.Annotations;
using QuickBooks;
using RMSDataAccessLayer;
using Timer = System.Timers.Timer;

namespace QS2QBPost
{
    public class QBClass : INotifyPropertyChanged
    {
        private static volatile QBClass instance;
        private static volatile QBClass singleton;
        private static object syncRoot = new Object();
        //private static Timer downloadTimer;
        private static int _totalPost;
        private static int _post;
        private static string _status = "Service Started";

        static QBClass()
        {
            //downloadTimer = new System.Timers.Timer(45 * 60 * 1000);
            ////60 minutes * 1000 milliseconds
            //downloadTimer.Elapsed += Instance.OnTimeToDownload;
            //downloadTimer.Enabled = true;

        }

        public static QBClass Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new QBClass();
                    }
                }

                return instance;
            }
        }

        public static QBClass Singleton
        {
            get
            {
                if (singleton == null)
                {
                    lock (syncRoot)
                    {
                        if (singleton == null)
                            singleton = new QBClass();
                    }
                }

                return singleton;
            }
        }

 
        //public static bool IsDownloading => downloadTimer.Enabled;

        //private async void OnTimeToDownload(object sender, ElapsedEventArgs e)
        //{
        //    if (downloadTimer.Enabled == true)
        //    {
        //        downloadTimer.Enabled = false;
        //        await DownloadFromQB().ConfigureAwait(false);
        //        downloadTimer.Enabled = true;
        //    }
        //}

        private async Task DownloadFromQB()
        {
            try
            {
                await Task.Run(() => DownloadQBItems()).ConfigureAwait(false);
            }
            catch (Exception)
            {
                
                throw;
            }
          
        }


        public string Status
        {
            get { return _status; }
            set
            {
                _status = value;
                if (Singleton.downloadingItems) _status += " - Currently Downloading Inventory";
                OnPropertyChanged();
            }
        }
      
        public void DownloadQBItems(int days = 1)
        {
            try
            {
                Singleton.downloadingItems = true;
                List<ItemInventoryRet> itms = QBPOS.GetInventoryItemQuery(Settings.Default.QBCompanyFile,days);
                ProcessQBItems(itms);
                Singleton.downloadingItems = false;
            }
            catch (Exception ex)
            {
                Logger.Log(LoggingLevel.Error, ex.Message + ex.StackTrace);
               // throw ex;
            }

        }

        private void ProcessQBItems(List<ItemInventoryRet> itms)
        {
            try
            {
                if (itms != null)
                {
                    var itmcnt = 0;
                  
                    Parallel.ForEach(itms, (item) => //.Where(x => x.ItemNumber == 6315)
                    {
                        
                        using (var ctx = new RMSModel())
                        {
                            try
                            {

                            QBInventoryItem i = ctx.QBInventoryItems.FirstOrDefault(x => x.ListID == item.ListID );
                            if (i == null)
                            {
                                i = new QBInventoryItem()
                                {
                                    ListID = item.ListID,
                                    ItemName = item.Desc1,
                                    ItemDesc2 = item.Desc2,
                                    Size = item.Size,
                                    DepartmentCode = "MISC",
                                    ItemNumber = System.Convert.ToInt16(item.ItemNumber),
                                    TaxCode = item.TaxCode,
                                    Price = System.Convert.ToDouble(item.Price1),
                                    Quantity = System.Convert.ToDouble(item.QuantityOnHand),
                                    UnitOfMeasure = item.UnitOfMeasure
                                };

                                ctx.QBInventoryItems.Add(i);
                            }

                            i.ItemName = item.Desc1;
                            i.ItemDesc2 = item.Desc2;
                            i.ListID = item.ListID;
                            i.Size = item.Size;
                            i.UnitOfMeasure = item.UnitOfMeasure;
                            i.TaxCode = item.TaxCode;
                            i.ItemNumber = System.Convert.ToInt16(item.ItemNumber);
                            i.Price = System.Convert.ToDouble(item.Price1);
                            i.Quantity = System.Convert.ToDouble(item.QuantityOnHand);

                            ctx.QBInventoryItems.AddOrUpdate(i);

                            Medicine itm = ctx.Item.OfType<Medicine>().FirstOrDefault(x => x.QBItemListID == i.ListID);
                            if (itm == null)
                            {
                                itm = new Medicine()
                                {
                                    DateCreated = DateTime.Now,
                                    SuggestedDosage = "Take as Directed by your Doctor"
                                };

                                ctx.Item.Add(itm);
                            }

                            if (itm != null)
                            {
                                itm.Description = i.ItemDesc2;
                                itm.Price = i.Price.GetValueOrDefault();
                                itm.Quantity = Convert.ToDouble(i.Quantity);
                                itm.SalesTax = (i.TaxCode != null && i.TaxCode.ToUpper() == "VAT"
                                    ?  .15
                                    : 0);
                                itm.QBItemListID = i.ListID;
                                itm.UnitOfMeasure = i.UnitOfMeasure;
                                itm.ItemName = i.ItemName;
                                itm.ItemNumber = i.ItemNumber.ToString();
                                itm.Size = i.Size;
                                itm.QBActive = true;
                                ctx.Item.AddOrUpdate(itm);
                            }
                            ctx.SaveChanges();
                            }
                            catch (Exception)
                            {

                                //throw;
                            }
                        }
                        // itmcnt += 1;
                    });
                    //SaveDatabase();
                }
            }
            catch (Exception ex)
            {
                Logger.Log(LoggingLevel.Error, ex.Message + ex.StackTrace);
                throw ex;
            }
        }

        private bool downloadingItems = false;
        internal void DownloadAllQBItems()
        {
            try
            {
                Singleton.downloadingItems = true;
                
               var t = QBPOS.GetAllInventoryQuery(Settings.Default.QBCompanyFile);
                //set qbactive for all inventory items first
                using (var ctx = new RMSModel())
                {
                    ctx.Database.ExecuteSqlCommand("update item set QBActive = 0");
                }
                    ProcessQBItems(t);
              
                Singleton.downloadingItems = false;
            }
            catch (Exception ex)
            {
                Logger.Log(LoggingLevel.Error, ex.Message + ex.StackTrace);
                throw ex;
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}