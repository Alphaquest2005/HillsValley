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
    
    public partial class QBInventoryItem : BaseEntity<QBInventoryItem>
    {
        
        public QBInventoryItem()
        {
            this.Items = new ObservableCollection<Item>();
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
    
            ChangeTrackingCollection<QBInventoryItem> _changeTracker;
    
            [NotMapped]
            [IgnoreDataMember]
            public ChangeTrackingCollection<QBInventoryItem> ChangeTracker
            {
                get
                {
                    return _changeTracker;
                }
            }
            
            public void StartTracking()
            {
                _changeTracker = new ChangeTrackingCollection<QBInventoryItem>(this);
            }
        [DataMember]
                    [Required(ErrorMessage="ListID is required")]
                [StringLength(50)]
    	public string ListID
    	{ 
    		get { return _ListID; }
    		set
    		{
    			if (Equals(value, _ListID)) return;
    			_ListID = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private string _ListID;
        [DataMember]
        	public string ItemDesc2
    	{ 
    		get { return _ItemDesc2; }
    		set
    		{
    			if (Equals(value, _ItemDesc2)) return;
    			_ItemDesc2 = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private string _ItemDesc2;
        [DataMember]
        	public string ItemName
    	{ 
    		get { return _ItemName; }
    		set
    		{
    			if (Equals(value, _ItemName)) return;
    			_ItemName = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private string _ItemName;
        [DataMember]
        	public string Size
    	{ 
    		get { return _Size; }
    		set
    		{
    			if (Equals(value, _Size)) return;
    			_Size = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private string _Size;
        [DataMember]
        	public string DepartmentCode
    	{ 
    		get { return _DepartmentCode; }
    		set
    		{
    			if (Equals(value, _DepartmentCode)) return;
    			_DepartmentCode = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private string _DepartmentCode;
        [DataMember]
                    [Required(ErrorMessage="ItemNumber is required")]
    	public int ItemNumber
    	{ 
    		get { return _ItemNumber; }
    		set
    		{
    			if (Equals(value, _ItemNumber)) return;
    			_ItemNumber = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private int _ItemNumber;
        [DataMember]
        	public string TaxCode
    	{ 
    		get { return _TaxCode; }
    		set
    		{
    			if (Equals(value, _TaxCode)) return;
    			_TaxCode = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private string _TaxCode;
        [DataMember]
        	public Nullable<double> Price
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
    	private Nullable<double> _Price;
        [DataMember]
        	public Nullable<double> Quantity
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
    	private Nullable<double> _Quantity;
        [DataMember]
                    [StringLength(50)]
    	public string UnitOfMeasure
    	{ 
    		get { return _UnitOfMeasure; }
    		set
    		{
    			if (Equals(value, _UnitOfMeasure)) return;
    			_UnitOfMeasure = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private string _UnitOfMeasure;
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
    	public ObservableCollection<Item> Items
    	{
    		get { return _Items; }
    		set
    		{
    			if (Equals(value, _Items)) return;
    			_Items = value;
    			NotifyPropertyChanged();
    		}
    	}
    	private ObservableCollection<Item> _Items;
    }
}
