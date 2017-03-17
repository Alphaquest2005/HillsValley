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
    
    public partial class TransactionEntryItem : BaseEntity<TransactionEntryItem>
    {
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
                    [Required(ErrorMessage="QBItemListID is required")]
                [StringLength(50)]
    	public string QBItemListID
    	{ 
    		get { return _QBItemListID; }
    		set
    		{
    			if (Equals(value, _QBItemListID)) return;
    			_QBItemListID = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private string _QBItemListID;
        [DataMember]
                    [Required(ErrorMessage="ItemNumber is required")]
                [StringLength(50)]
    	public string ItemNumber
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
    	private string _ItemNumber;
        [DataMember]
                    [Required(ErrorMessage="ItemName is required")]
                [StringLength(50)]
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
        	public Nullable<int> ItemId
    	{ 
    		get { return _ItemId; }
    		set
    		{
    			if (Equals(value, _ItemId)) return;
    			_ItemId = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private Nullable<int> _ItemId;
        [DataMember]
    	public Item Item
    	{
    		get { return _Item; }
    		set
    		{
    			if (Equals(value, _Item)) return;
    			_Item = value;
    			ItemChangeTracker = _Item == null ? null
    				: new ChangeTrackingCollection<Item> { _Item };
    			NotifyPropertyChanged();
    		}
    	}
    	private Item _Item;
    	private ChangeTrackingCollection<Item> ItemChangeTracker { get; set; }
        [DataMember]
    	public TransactionEntryBase TransactionEntryBase
    	{
    		get { return _TransactionEntryBase; }
    		set
    		{
    			if (Equals(value, _TransactionEntryBase)) return;
    			_TransactionEntryBase = value;
    			TransactionEntryBaseChangeTracker = _TransactionEntryBase == null ? null
    				: new ChangeTrackingCollection<TransactionEntryBase> { _TransactionEntryBase };
    			NotifyPropertyChanged();
    		}
    	}
    	private TransactionEntryBase _TransactionEntryBase;
    	private ChangeTrackingCollection<TransactionEntryBase> TransactionEntryBaseChangeTracker { get; set; }
    }
}