﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Instagram.App_Data
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="tinphuong_com_db")]
	public partial class IGDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertIG_SignString(IG_SignString instance);
    partial void UpdateIG_SignString(IG_SignString instance);
    partial void DeleteIG_SignString(IG_SignString instance);
    partial void InsertIG_Account(IG_Account instance);
    partial void UpdateIG_Account(IG_Account instance);
    partial void DeleteIG_Account(IG_Account instance);
    #endregion
		
		public IGDBDataContext() : 
				base(global::Instagram.Properties.Settings.Default.tinphuong_com_dbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public IGDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IGDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IGDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IGDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<IG_SignString> IG_SignStrings
		{
			get
			{
				return this.GetTable<IG_SignString>();
			}
		}
		
		public System.Data.Linq.Table<IG_Account> IG_Accounts
		{
			get
			{
				return this.GetTable<IG_Account>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="vtt.IG_SignString")]
	public partial class IG_SignString : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Pid;
		
		private string _String;
		
		private string _SignedString;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPidChanging(int value);
    partial void OnPidChanged();
    partial void OnStringChanging(string value);
    partial void OnStringChanged();
    partial void OnSignedStringChanging(string value);
    partial void OnSignedStringChanged();
    #endregion
		
		public IG_SignString()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Pid
		{
			get
			{
				return this._Pid;
			}
			set
			{
				if ((this._Pid != value))
				{
					this.OnPidChanging(value);
					this.SendPropertyChanging();
					this._Pid = value;
					this.SendPropertyChanged("Pid");
					this.OnPidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_String", DbType="VarChar(MAX)")]
		public string String
		{
			get
			{
				return this._String;
			}
			set
			{
				if ((this._String != value))
				{
					this.OnStringChanging(value);
					this.SendPropertyChanging();
					this._String = value;
					this.SendPropertyChanged("String");
					this.OnStringChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SignedString", DbType="VarChar(MAX)")]
		public string SignedString
		{
			get
			{
				return this._SignedString;
			}
			set
			{
				if ((this._SignedString != value))
				{
					this.OnSignedStringChanging(value);
					this.SendPropertyChanging();
					this._SignedString = value;
					this.SendPropertyChanged("SignedString");
					this.OnSignedStringChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="vtt.IG_Account")]
	public partial class IG_Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Pid;
		
		private string _UserName;
		
		private string _Pass;
		
		private string _Email;
		
		private string _RealName;
		
		private string _PhoneInfo;
		
		private string _PhoneNumber;
		
		private System.Data.Linq.Binary _Cookie;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPidChanging(int value);
    partial void OnPidChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPassChanging(string value);
    partial void OnPassChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnRealNameChanging(string value);
    partial void OnRealNameChanged();
    partial void OnPhoneInfoChanging(string value);
    partial void OnPhoneInfoChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    partial void OnCookieChanging(System.Data.Linq.Binary value);
    partial void OnCookieChanged();
    #endregion
		
		public IG_Account()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Pid
		{
			get
			{
				return this._Pid;
			}
			set
			{
				if ((this._Pid != value))
				{
					this.OnPidChanging(value);
					this.SendPropertyChanging();
					this._Pid = value;
					this.SendPropertyChanged("Pid");
					this.OnPidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pass", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Pass
		{
			get
			{
				return this._Pass;
			}
			set
			{
				if ((this._Pass != value))
				{
					this.OnPassChanging(value);
					this.SendPropertyChanging();
					this._Pass = value;
					this.SendPropertyChanged("Pass");
					this.OnPassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(MAX)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RealName", DbType="VarChar(MAX)")]
		public string RealName
		{
			get
			{
				return this._RealName;
			}
			set
			{
				if ((this._RealName != value))
				{
					this.OnRealNameChanging(value);
					this.SendPropertyChanging();
					this._RealName = value;
					this.SendPropertyChanged("RealName");
					this.OnRealNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneInfo", DbType="VarChar(MAX)")]
		public string PhoneInfo
		{
			get
			{
				return this._PhoneInfo;
			}
			set
			{
				if ((this._PhoneInfo != value))
				{
					this.OnPhoneInfoChanging(value);
					this.SendPropertyChanging();
					this._PhoneInfo = value;
					this.SendPropertyChanged("PhoneInfo");
					this.OnPhoneInfoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="VarChar(MAX)")]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cookie", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Cookie
		{
			get
			{
				return this._Cookie;
			}
			set
			{
				if ((this._Cookie != value))
				{
					this.OnCookieChanging(value);
					this.SendPropertyChanging();
					this._Cookie = value;
					this.SendPropertyChanged("Cookie");
					this.OnCookieChanged();
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
}
#pragma warning restore 1591
