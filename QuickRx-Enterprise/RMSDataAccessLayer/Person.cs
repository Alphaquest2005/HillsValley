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
    
    public partial class Person : BaseEntity<Person>
    {
        
        public Person()
        {
            this.InActive = false;
            this.Transaction = new ObservableCollection<TransactionBase>();
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
    
            ChangeTrackingCollection<Person> _changeTracker;
    
            [NotMapped]
            [IgnoreDataMember]
            public ChangeTrackingCollection<Person> ChangeTracker
            {
                get
                {
                    return _changeTracker;
                }
            }
            
            public new void StartTracking()
            {
                _changeTracker = new ChangeTrackingCollection<Person>(this);
            }
        [DataMember]
                    [Required(ErrorMessage="Id is required")]
    	public int Id
    	{ 
    		get { return _Id; }
    		set
    		{
    			if (Equals(value, _Id)) return;
    			_Id = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private int _Id;
        [DataMember]
                    [Required(ErrorMessage="FirstName is required")]
    	public string FirstName
    	{ 
    		get { return _FirstName; }
    		set
    		{
    			if (Equals(value, _FirstName)) return;
    			_FirstName = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private string _FirstName;
        [DataMember]
                    [Required(ErrorMessage="LastName is required")]
    	public string LastName
    	{ 
    		get { return _LastName; }
    		set
    		{
    			if (Equals(value, _LastName)) return;
    			_LastName = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private string _LastName;
        [DataMember]
        	public string CompanyName
    	{ 
    		get { return _CompanyName; }
    		set
    		{
    			if (Equals(value, _CompanyName)) return;
    			_CompanyName = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private string _CompanyName;
        [DataMember]
        	public string Salutation
    	{ 
    		get { return _Salutation; }
    		set
    		{
    			if (Equals(value, _Salutation)) return;
    			_Salutation = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private string _Salutation;
        [DataMember]
        	public string Address
    	{ 
    		get { return _Address; }
    		set
    		{
    			if (Equals(value, _Address)) return;
    			_Address = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private string _Address;
        [DataMember]
        	public string PhoneNumber
    	{ 
    		get { return _PhoneNumber; }
    		set
    		{
    			if (Equals(value, _PhoneNumber)) return;
    			_PhoneNumber = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private string _PhoneNumber;
        [DataMember]
        	public Nullable<bool> InActive
    	{ 
    		get { return _InActive; }
    		set
    		{
    			if (Equals(value, _InActive)) return;
    			_InActive = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private Nullable<bool> _InActive;
        [DataMember]
        	public Nullable<bool> Sex
    	{ 
    		get { return _Sex; }
    		set
    		{
    			if (Equals(value, _Sex)) return;
    			_Sex = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private Nullable<bool> _Sex;
        [DataMember]
        	public Nullable<System.DateTime> DOB
    	{ 
    		get { return _DOB; }
    		set
    		{
    			if (Equals(value, _DOB)) return;
    			_DOB = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private Nullable<System.DateTime> _DOB;
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
    	public ObservableCollection<TransactionBase> Transaction
    	{
    		get { return _Transaction; }
    		set
    		{
    			if (Equals(value, _Transaction)) return;
    			_Transaction = value;
    			NotifyPropertyChanged();
    		}
    	}
    	private ObservableCollection<TransactionBase> _Transaction;
    }
}
