//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RMSDataAccessLayer
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel;
    using TrackableEntities;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;
    using System.Collections.ObjectModel;

    using System;
    using System.Collections.Generic;
    using TrackableEntities.Client;
    
    public partial class Cashier : Person
    {
        
        public Cashier()
        {
            this.TransactionBase = new ObservableCollection<TransactionBase>();
            this.CashierLog = new ObservableCollection<CashierLog>();
            this.Batch = new ObservableCollection<Batch>();
            this.Batch1 = new ObservableCollection<Batch>();
            this.TransactionBases1 = new ObservableCollection<TransactionBase>();
            CustomStartup();
            this.PropertyChanged += UpdatePropertyChanged;
            
        }
        partial void CustomStartup();
    
            private void UpdatePropertyChanged(object sender, PropertyChangedEventArgs e)
            {
                if (!string.IsNullOrEmpty(e.PropertyName) && (!Environment.StackTrace.Contains("Internal.Materialization")) && TrackingState == TrackingState.Unchanged)
                {
                    TrackingState = TrackingState.Modified;
                }
            }
    
            ChangeTrackingCollection<Cashier> _changeTracker;
    
            [NotMapped]
            [IgnoreDataMember]
            public ChangeTrackingCollection<Cashier> ChangeTracker
            {
                get
                {
                    return _changeTracker;
                }
            }
            
            public void StartTracking()
            {
                _changeTracker = new ChangeTrackingCollection<Cashier>(this);
            }
        [DataMember]
        	public string SPassword
    	{ 
    		get { return _SPassword; }
    		set
    		{
    			if (Equals(value, _SPassword)) return;
    			_SPassword = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private string _SPassword;
        [DataMember]
        	public string LoginName
    	{ 
    		get { return _LoginName; }
    		set
    		{
    			if (Equals(value, _LoginName)) return;
    			_LoginName = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private string _LoginName;
        [DataMember]
                    [StringLength(50)]
    	public string Role
    	{ 
    		get { return _Role; }
    		set
    		{
    			if (Equals(value, _Role)) return;
    			_Role = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private string _Role;
        [DataMember]
                    [StringLength(3)]
    	public string Initials
    	{ 
    		get { return _Initials; }
    		set
    		{
    			if (Equals(value, _Initials)) return;
    			_Initials = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private string _Initials;
        [DataMember]
    	public ObservableCollection<TransactionBase> TransactionBase
    	{
    		get { return _TransactionBase; }
    		set
    		{
    			if (Equals(value, _TransactionBase)) return;
    			_TransactionBase = value;
    			NotifyPropertyChanged();
    		}
    	}
    	private ObservableCollection<TransactionBase> _TransactionBase;
        [DataMember]
    	public ObservableCollection<CashierLog> CashierLog
    	{
    		get { return _CashierLog; }
    		set
    		{
    			if (Equals(value, _CashierLog)) return;
    			_CashierLog = value;
    			NotifyPropertyChanged();
    		}
    	}
    	private ObservableCollection<CashierLog> _CashierLog;
        [DataMember]
    	public ObservableCollection<Batch> Batch
    	{
    		get { return _Batch; }
    		set
    		{
    			if (Equals(value, _Batch)) return;
    			_Batch = value;
    			NotifyPropertyChanged();
    		}
    	}
    	private ObservableCollection<Batch> _Batch;
        [DataMember]
    	public ObservableCollection<Batch> Batch1
    	{
    		get { return _Batch1; }
    		set
    		{
    			if (Equals(value, _Batch1)) return;
    			_Batch1 = value;
    			NotifyPropertyChanged();
    		}
    	}
    	private ObservableCollection<Batch> _Batch1;
        [DataMember]
    	public ObservableCollection<TransactionBase> TransactionBases1
    	{
    		get { return _TransactionBases1; }
    		set
    		{
    			if (Equals(value, _TransactionBases1)) return;
    			_TransactionBases1 = value;
    			NotifyPropertyChanged();
    		}
    	}
    	private ObservableCollection<TransactionBase> _TransactionBases1;
    }
}
