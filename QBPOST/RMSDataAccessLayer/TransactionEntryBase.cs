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
    
    public partial class TransactionEntryBase : BaseEntity<TransactionEntryBase>
    {
        
        public TransactionEntryBase()
        {
            this.Taxable = true;
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
    
            ChangeTrackingCollection<TransactionEntryBase> _changeTracker;
    
            [NotMapped]
            [IgnoreDataMember]
            public ChangeTrackingCollection<TransactionEntryBase> ChangeTracker
            {
                get
                {
                    return _changeTracker;
                }
            }
            
            public void StartTracking()
            {
                _changeTracker = new ChangeTrackingCollection<TransactionEntryBase>(this);
            }
        [DataMember]
                    [Required(ErrorMessage="StoreID is required")]
    	public int StoreID
    	{ 
    		get { return _StoreID; }
    		set
    		{
    			if (Equals(value, _StoreID)) return;
    			_StoreID = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private int _StoreID;
        [DataMember]
                    [Required(ErrorMessage="TransactionEntryId is required")]
    	public int TransactionEntryId
    	{ 
    		get { return _TransactionEntryId; }
    		set
    		{
    			if (Equals(value, _TransactionEntryId)) return;
    			_TransactionEntryId = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private int _TransactionEntryId;
        [DataMember]
                    [Required(ErrorMessage="TransactionId is required")]
    	public int TransactionId
    	{ 
    		get { return _TransactionId; }
    		set
    		{
    			if (Equals(value, _TransactionId)) return;
    			_TransactionId = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private int _TransactionId;
        [DataMember]
                    [Required(ErrorMessage="Quantity is required")]
    	public double Quantity
    	{ 
    		get { return _Quantity; }
    		set
    		{
    			if (Equals(value, _Quantity)) return;
    			_Quantity = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private double _Quantity;
        [DataMember]
                    [Required(ErrorMessage="Taxable is required")]
    	public bool Taxable
    	{ 
    		get { return _Taxable; }
    		set
    		{
    			if (Equals(value, _Taxable)) return;
    			_Taxable = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private bool _Taxable;
        [DataMember]
                    [StringLength(255)]
    	public string Comment
    	{ 
    		get { return _Comment; }
    		set
    		{
    			if (Equals(value, _Comment)) return;
    			_Comment = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private string _Comment;
        [DataMember]
        	public Nullable<System.DateTime> TransactionTime
    	{ 
    		get { return _TransactionTime; }
    		set
    		{
    			if (Equals(value, _TransactionTime)) return;
    			_TransactionTime = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private Nullable<System.DateTime> _TransactionTime;
        [DataMember]
                    [Required(ErrorMessage="SalesTaxPercent is required")]
    	public double SalesTaxPercent
    	{ 
    		get { return _SalesTaxPercent; }
    		set
    		{
    			if (Equals(value, _SalesTaxPercent)) return;
    			_SalesTaxPercent = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private double _SalesTaxPercent;
        [DataMember]
        	public Nullable<double> Discount
    	{ 
    		get { return _Discount; }
    		set
    		{
    			if (Equals(value, _Discount)) return;
    			_Discount = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private Nullable<double> _Discount;
        [DataMember]
        	public Nullable<short> EntryNumber
    	{ 
    		get { return _EntryNumber; }
    		set
    		{
    			if (Equals(value, _EntryNumber)) return;
    			_EntryNumber = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private Nullable<short> _EntryNumber;
        [DataMember]
        	public byte[] EntryTimeStamp
    	{ 
    		get { return _EntryTimeStamp; }
    		set
    		{
    			if (Equals(value, _EntryTimeStamp)) return;
    			_EntryTimeStamp = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private byte[] _EntryTimeStamp;
        [DataMember]
                    [Required(ErrorMessage="Price is required")]
    	public double Price
    	{ 
    		get { return _Price; }
    		set
    		{
    			if (Equals(value, _Price)) return;
    			_Price = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private double _Price;
        [DataMember]
    	public TransactionBase Transaction
    	{
    		get { return _Transaction; }
    		set
    		{
    			if (Equals(value, _Transaction)) return;
    			_Transaction = value;
    			TransactionChangeTracker = _Transaction == null ? null
    				: new ChangeTrackingCollection<TransactionBase> { _Transaction };
    			NotifyPropertyChanged();
    		}
    	}
    	private TransactionBase _Transaction;
    	private ChangeTrackingCollection<TransactionBase> TransactionChangeTracker { get; set; }
        [DataMember]
    	public TransactionEntryItem TransactionEntryItem
    	{
    		get { return _TransactionEntryItem; }
    		set
    		{
    			if (Equals(value, _TransactionEntryItem)) return;
    			_TransactionEntryItem = value;
    			TransactionEntryItemChangeTracker = _TransactionEntryItem == null ? null
    				: new ChangeTrackingCollection<TransactionEntryItem> { _TransactionEntryItem };
    			NotifyPropertyChanged();
    		}
    	}
    	private TransactionEntryItem _TransactionEntryItem;
    	private ChangeTrackingCollection<TransactionEntryItem> TransactionEntryItemChangeTracker { get; set; }
    }
}
