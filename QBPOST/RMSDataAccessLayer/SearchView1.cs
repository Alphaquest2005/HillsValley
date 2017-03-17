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
    
    public partial class SearchView1 : BaseEntity<SearchView1>
    {
        [DataMember]
                    [Required(ErrorMessage="Time is required")]
    	public System.DateTime Time
    	{ 
    		get { return _Time; }
    		set
    		{
    			if (Equals(value, _Time)) return;
    			_Time = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private System.DateTime _Time;
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
                    [Required(ErrorMessage="ItemId is required")]
    	public int ItemId
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
    	private int _ItemId;
        [DataMember]
                    [Required(ErrorMessage="ItemInfo is required")]
                [StringLength(1053)]
    	public string ItemInfo
    	{ 
    		get { return _ItemInfo; }
    		set
    		{
    			if (Equals(value, _ItemInfo)) return;
    			_ItemInfo = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private string _ItemInfo;
        [DataMember]
                    [Required(ErrorMessage="PatientId is required")]
    	public int PatientId
    	{ 
    		get { return _PatientId; }
    		set
    		{
    			if (Equals(value, _PatientId)) return;
    			_PatientId = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private int _PatientId;
        [DataMember]
                    [Required(ErrorMessage="PatientInfo is required")]
    	public string PatientInfo
    	{ 
    		get { return _PatientInfo; }
    		set
    		{
    			if (Equals(value, _PatientInfo)) return;
    			_PatientInfo = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private string _PatientInfo;
        [DataMember]
                    [Required(ErrorMessage="DoctorId is required")]
    	public int DoctorId
    	{ 
    		get { return _DoctorId; }
    		set
    		{
    			if (Equals(value, _DoctorId)) return;
    			_DoctorId = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private int _DoctorId;
        [DataMember]
                    [Required(ErrorMessage="DoctorInfo is required")]
    	public string DoctorInfo
    	{ 
    		get { return _DoctorInfo; }
    		set
    		{
    			if (Equals(value, _DoctorInfo)) return;
    			_DoctorInfo = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private string _DoctorInfo;
        [DataMember]
        	public string SearchInfo
    	{ 
    		get { return _SearchInfo; }
    		set
    		{
    			if (Equals(value, _SearchInfo)) return;
    			_SearchInfo = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private string _SearchInfo;
    }
}
