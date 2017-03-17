
using System;
using System.Windows;
using log4netWrapper;
using System.Xml;
using QBPOSXMLRPLib;

namespace QS2QBPost
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var t = QBClass.Instance;
            Logger.Initialize();
            Logger.Log(LoggingLevel.Info, string.Format("Application Started - {0}", DateTime.Now));
        }

       
        private void DownloadQBItemsBtn(object sender, RoutedEventArgs e)
        {
            try
            {
                QBClass.Instance.DownloadQBItems();
                MessageBox.Show("QuickBooks Inventory Downloaded");
            }
            catch (Exception)
            {
                throw;
            }


        }

        private void RefreshInventory(object sender, RoutedEventArgs e)
        {
            try
            {
                QBClass.Instance.DownloadAllQBItems();
                MessageBox.Show("QuickBooks Inventory Downloaded");
            }
            catch (Exception)
            {
                throw;
            }

        }

        
    }
}

   
    

