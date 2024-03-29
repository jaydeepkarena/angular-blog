﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication5.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="NerdDinner")]
	public partial class NerdDinnerDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDinner(Dinner instance);
    partial void UpdateDinner(Dinner instance);
    partial void DeleteDinner(Dinner instance);
    partial void InsertRSVP(RSVP instance);
    partial void UpdateRSVP(RSVP instance);
    partial void DeleteRSVP(RSVP instance);
    #endregion
		
		public NerdDinnerDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["NerdDinnerConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public NerdDinnerDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NerdDinnerDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NerdDinnerDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NerdDinnerDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Dinner> Dinners
		{
			get
			{
				return this.GetTable<Dinner>();
			}
		}
		
		public System.Data.Linq.Table<RSVP> RSVPs
		{
			get
			{
				return this.GetTable<RSVP>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.NearestDinners", IsComposable=true)]
		public IQueryable<NearestDinnersResult> NearestDinners([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Real")] System.Nullable<float> lat, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="long", DbType="Real")] System.Nullable<float> @long)
		{
			return this.CreateMethodCallQuery<NearestDinnersResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), lat, @long);
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DistanceBetween", IsComposable=true)]
		public System.Nullable<float> DistanceBetween([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Lat1", DbType="Real")] System.Nullable<float> lat1, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Long1", DbType="Real")] System.Nullable<float> long1, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Lat2", DbType="Real")] System.Nullable<float> lat2, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Long2", DbType="Real")] System.Nullable<float> long2)
		{
			return ((System.Nullable<float>)(this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), lat1, long1, lat2, long2).ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Dinners")]
	public partial class Dinner : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DinnerID;
		
		private string _Title;
		
		private System.DateTime _EventDate;
		
		private string _Description;
		
		private string _HostedBy;
		
		private string _ContactPhone;
		
		private string _Address;
		
		private string _Country;
		
		private double _Latitude;
		
		private double _Longitude;
		
		private EntitySet<RSVP> _RSVPs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDinnerIDChanging(int value);
    partial void OnDinnerIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnEventDateChanging(System.DateTime value);
    partial void OnEventDateChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnHostedByChanging(string value);
    partial void OnHostedByChanged();
    partial void OnContactPhoneChanging(string value);
    partial void OnContactPhoneChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCountryChanging(string value);
    partial void OnCountryChanged();
    partial void OnLatitudeChanging(double value);
    partial void OnLatitudeChanged();
    partial void OnLongitudeChanging(double value);
    partial void OnLongitudeChanged();
    #endregion
		
		public Dinner()
		{
			this._RSVPs = new EntitySet<RSVP>(new Action<RSVP>(this.attach_RSVPs), new Action<RSVP>(this.detach_RSVPs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DinnerID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int DinnerID
		{
			get
			{
				return this._DinnerID;
			}
			set
			{
				if ((this._DinnerID != value))
				{
					this.OnDinnerIDChanging(value);
					this.SendPropertyChanging();
					this._DinnerID = value;
					this.SendPropertyChanged("DinnerID");
					this.OnDinnerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventDate", DbType="DateTime NOT NULL")]
		public System.DateTime EventDate
		{
			get
			{
				return this._EventDate;
			}
			set
			{
				if ((this._EventDate != value))
				{
					this.OnEventDateChanging(value);
					this.SendPropertyChanging();
					this._EventDate = value;
					this.SendPropertyChanged("EventDate");
					this.OnEventDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(256)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HostedBy", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HostedBy
		{
			get
			{
				return this._HostedBy;
			}
			set
			{
				if ((this._HostedBy != value))
				{
					this.OnHostedByChanging(value);
					this.SendPropertyChanging();
					this._HostedBy = value;
					this.SendPropertyChanged("HostedBy");
					this.OnHostedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactPhone", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ContactPhone
		{
			get
			{
				return this._ContactPhone;
			}
			set
			{
				if ((this._ContactPhone != value))
				{
					this.OnContactPhoneChanging(value);
					this.SendPropertyChanging();
					this._ContactPhone = value;
					this.SendPropertyChanged("ContactPhone");
					this.OnContactPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(50)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="NVarChar(30)")]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this.OnCountryChanging(value);
					this.SendPropertyChanging();
					this._Country = value;
					this.SendPropertyChanged("Country");
					this.OnCountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Latitude", DbType="Float NOT NULL")]
		public double Latitude
		{
			get
			{
				return this._Latitude;
			}
			set
			{
				if ((this._Latitude != value))
				{
					this.OnLatitudeChanging(value);
					this.SendPropertyChanging();
					this._Latitude = value;
					this.SendPropertyChanged("Latitude");
					this.OnLatitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Longitude", DbType="Float NOT NULL")]
		public double Longitude
		{
			get
			{
				return this._Longitude;
			}
			set
			{
				if ((this._Longitude != value))
				{
					this.OnLongitudeChanging(value);
					this.SendPropertyChanging();
					this._Longitude = value;
					this.SendPropertyChanged("Longitude");
					this.OnLongitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Dinner_RSVP", Storage="_RSVPs", ThisKey="DinnerID", OtherKey="DinnerID")]
		public EntitySet<RSVP> RSVPs
		{
			get
			{
				return this._RSVPs;
			}
			set
			{
				this._RSVPs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_RSVPs(RSVP entity)
		{
			this.SendPropertyChanging();
			entity.Dinner = this;
		}
		
		private void detach_RSVPs(RSVP entity)
		{
			this.SendPropertyChanging();
			entity.Dinner = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RSVP")]
	public partial class RSVP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RsvpID;
		
		private int _DinnerID;
		
		private string _AttendeeName;
		
		private EntityRef<Dinner> _Dinner;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRsvpIDChanging(int value);
    partial void OnRsvpIDChanged();
    partial void OnDinnerIDChanging(int value);
    partial void OnDinnerIDChanged();
    partial void OnAttendeeNameChanging(string value);
    partial void OnAttendeeNameChanged();
    #endregion
		
		public RSVP()
		{
			this._Dinner = default(EntityRef<Dinner>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RsvpID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RsvpID
		{
			get
			{
				return this._RsvpID;
			}
			set
			{
				if ((this._RsvpID != value))
				{
					this.OnRsvpIDChanging(value);
					this.SendPropertyChanging();
					this._RsvpID = value;
					this.SendPropertyChanged("RsvpID");
					this.OnRsvpIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DinnerID", DbType="Int NOT NULL")]
		public int DinnerID
		{
			get
			{
				return this._DinnerID;
			}
			set
			{
				if ((this._DinnerID != value))
				{
					if (this._Dinner.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDinnerIDChanging(value);
					this.SendPropertyChanging();
					this._DinnerID = value;
					this.SendPropertyChanged("DinnerID");
					this.OnDinnerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AttendeeName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string AttendeeName
		{
			get
			{
				return this._AttendeeName;
			}
			set
			{
				if ((this._AttendeeName != value))
				{
					this.OnAttendeeNameChanging(value);
					this.SendPropertyChanging();
					this._AttendeeName = value;
					this.SendPropertyChanged("AttendeeName");
					this.OnAttendeeNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Dinner_RSVP", Storage="_Dinner", ThisKey="DinnerID", OtherKey="DinnerID", IsForeignKey=true)]
		public Dinner Dinner
		{
			get
			{
				return this._Dinner.Entity;
			}
			set
			{
				Dinner previousValue = this._Dinner.Entity;
				if (((previousValue != value) 
							|| (this._Dinner.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Dinner.Entity = null;
						previousValue.RSVPs.Remove(this);
					}
					this._Dinner.Entity = value;
					if ((value != null))
					{
						value.RSVPs.Add(this);
						this._DinnerID = value.DinnerID;
					}
					else
					{
						this._DinnerID = default(int);
					}
					this.SendPropertyChanged("Dinner");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	public partial class NearestDinnersResult
	{
		
		private int _DinnerID;
		
		public NearestDinnersResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DinnerID", DbType="Int NOT NULL")]
		public int DinnerID
		{
			get
			{
				return this._DinnerID;
			}
			set
			{
				if ((this._DinnerID != value))
				{
					this._DinnerID = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
