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

namespace Car_showroom
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="csms")]
	public partial class CarDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCatagory_Table(Catagory_Table instance);
    partial void UpdateCatagory_Table(Catagory_Table instance);
    partial void DeleteCatagory_Table(Catagory_Table instance);
    partial void InsertVehicleInfo(VehicleInfo instance);
    partial void UpdateVehicleInfo(VehicleInfo instance);
    partial void DeleteVehicleInfo(VehicleInfo instance);
    partial void InsertRegistationTable(RegistationTable instance);
    partial void UpdateRegistationTable(RegistationTable instance);
    partial void DeleteRegistationTable(RegistationTable instance);
    partial void InsertCustomerTable(CustomerTable instance);
    partial void UpdateCustomerTable(CustomerTable instance);
    partial void DeleteCustomerTable(CustomerTable instance);
    partial void InsertOrderTable(OrderTable instance);
    partial void UpdateOrderTable(OrderTable instance);
    partial void DeleteOrderTable(OrderTable instance);
    #endregion
		
		public CarDataContext() : 
				base(global::Car_showroom.Properties.Settings.Default.csmsConnectionString2, mappingSource)
		{
			OnCreated();
		}
		
		public CarDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CarDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CarDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CarDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Catagory_Table> Catagory_Tables
		{
			get
			{
				return this.GetTable<Catagory_Table>();
			}
		}
		
		public System.Data.Linq.Table<VehicleInfo> VehicleInfos
		{
			get
			{
				return this.GetTable<VehicleInfo>();
			}
		}
		
		public System.Data.Linq.Table<RegistationTable> RegistationTables
		{
			get
			{
				return this.GetTable<RegistationTable>();
			}
		}
		
		public System.Data.Linq.Table<CustomerTable> CustomerTables
		{
			get
			{
				return this.GetTable<CustomerTable>();
			}
		}
		
		public System.Data.Linq.Table<OrderTable> OrderTables
		{
			get
			{
				return this.GetTable<OrderTable>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Catagory_Table")]
	public partial class Catagory_Table : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Catagory_Id;
		
		private string _Catagory_Name;
		
		private string _model;
		
		private string _color;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCatagory_IdChanging(int value);
    partial void OnCatagory_IdChanged();
    partial void OnCatagory_NameChanging(string value);
    partial void OnCatagory_NameChanged();
    partial void OnmodelChanging(string value);
    partial void OnmodelChanged();
    partial void OncolorChanging(string value);
    partial void OncolorChanged();
    #endregion
		
		public Catagory_Table()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Catagory_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Catagory_Id
		{
			get
			{
				return this._Catagory_Id;
			}
			set
			{
				if ((this._Catagory_Id != value))
				{
					this.OnCatagory_IdChanging(value);
					this.SendPropertyChanging();
					this._Catagory_Id = value;
					this.SendPropertyChanged("Catagory_Id");
					this.OnCatagory_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Catagory_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Catagory_Name
		{
			get
			{
				return this._Catagory_Name;
			}
			set
			{
				if ((this._Catagory_Name != value))
				{
					this.OnCatagory_NameChanging(value);
					this.SendPropertyChanging();
					this._Catagory_Name = value;
					this.SendPropertyChanged("Catagory_Name");
					this.OnCatagory_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_model", DbType="NVarChar(50)")]
		public string model
		{
			get
			{
				return this._model;
			}
			set
			{
				if ((this._model != value))
				{
					this.OnmodelChanging(value);
					this.SendPropertyChanging();
					this._model = value;
					this.SendPropertyChanged("model");
					this.OnmodelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_color", DbType="NVarChar(50)")]
		public string color
		{
			get
			{
				return this._color;
			}
			set
			{
				if ((this._color != value))
				{
					this.OncolorChanging(value);
					this.SendPropertyChanging();
					this._color = value;
					this.SendPropertyChanged("color");
					this.OncolorChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.VehicleInfo")]
	public partial class VehicleInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Car_Brand;
		
		private string _Category;
		
		private string _Car_Model;
		
		private string _Color;
		
		private int _Quantity;
		
		private System.Nullable<double> _Price;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCar_BrandChanging(string value);
    partial void OnCar_BrandChanged();
    partial void OnCategoryChanging(string value);
    partial void OnCategoryChanged();
    partial void OnCar_ModelChanging(string value);
    partial void OnCar_ModelChanged();
    partial void OnColorChanging(string value);
    partial void OnColorChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    partial void OnPriceChanging(System.Nullable<double> value);
    partial void OnPriceChanged();
    #endregion
		
		public VehicleInfo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Car_Brand", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Car_Brand
		{
			get
			{
				return this._Car_Brand;
			}
			set
			{
				if ((this._Car_Brand != value))
				{
					this.OnCar_BrandChanging(value);
					this.SendPropertyChanging();
					this._Car_Brand = value;
					this.SendPropertyChanged("Car_Brand");
					this.OnCar_BrandChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="NVarChar(50)")]
		public string Category
		{
			get
			{
				return this._Category;
			}
			set
			{
				if ((this._Category != value))
				{
					this.OnCategoryChanging(value);
					this.SendPropertyChanging();
					this._Category = value;
					this.SendPropertyChanged("Category");
					this.OnCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Car_Model", DbType="NVarChar(50)")]
		public string Car_Model
		{
			get
			{
				return this._Car_Model;
			}
			set
			{
				if ((this._Car_Model != value))
				{
					this.OnCar_ModelChanging(value);
					this.SendPropertyChanging();
					this._Car_Model = value;
					this.SendPropertyChanged("Car_Model");
					this.OnCar_ModelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Color", DbType="NVarChar(50)")]
		public string Color
		{
			get
			{
				return this._Color;
			}
			set
			{
				if ((this._Color != value))
				{
					this.OnColorChanging(value);
					this.SendPropertyChanging();
					this._Color = value;
					this.SendPropertyChanged("Color");
					this.OnColorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
		public int Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Float")]
		public System.Nullable<double> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RegistationTable")]
	public partial class RegistationTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _First_Name;
		
		private string _Last_Name;
		
		private string _Gender;
		
		private string _phone;
		
		private string _Email;
		
		private string _Address;
		
		private string _Username;
		
		private string _Password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFirst_NameChanging(string value);
    partial void OnFirst_NameChanged();
    partial void OnLast_NameChanging(string value);
    partial void OnLast_NameChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnphoneChanging(string value);
    partial void OnphoneChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public RegistationTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_First_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string First_Name
		{
			get
			{
				return this._First_Name;
			}
			set
			{
				if ((this._First_Name != value))
				{
					this.OnFirst_NameChanging(value);
					this.SendPropertyChanging();
					this._First_Name = value;
					this.SendPropertyChanged("First_Name");
					this.OnFirst_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Last_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Last_Name
		{
			get
			{
				return this._Last_Name;
			}
			set
			{
				if ((this._Last_Name != value))
				{
					this.OnLast_NameChanging(value);
					this.SendPropertyChanging();
					this._Last_Name = value;
					this.SendPropertyChanged("Last_Name");
					this.OnLast_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NVarChar(50)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(MAX)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CustomerTable")]
	public partial class CustomerTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Customer_Id;
		
		private string _First_Name;
		
		private string _Last_Name;
		
		private string _Phone;
		
		private string _Email;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomer_IdChanging(int value);
    partial void OnCustomer_IdChanged();
    partial void OnFirst_NameChanging(string value);
    partial void OnFirst_NameChanged();
    partial void OnLast_NameChanging(string value);
    partial void OnLast_NameChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public CustomerTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Customer_Id
		{
			get
			{
				return this._Customer_Id;
			}
			set
			{
				if ((this._Customer_Id != value))
				{
					this.OnCustomer_IdChanging(value);
					this.SendPropertyChanging();
					this._Customer_Id = value;
					this.SendPropertyChanged("Customer_Id");
					this.OnCustomer_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_First_Name", DbType="NVarChar(50)")]
		public string First_Name
		{
			get
			{
				return this._First_Name;
			}
			set
			{
				if ((this._First_Name != value))
				{
					this.OnFirst_NameChanging(value);
					this.SendPropertyChanging();
					this._First_Name = value;
					this.SendPropertyChanged("First_Name");
					this.OnFirst_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Last_Name", DbType="NVarChar(50)")]
		public string Last_Name
		{
			get
			{
				return this._Last_Name;
			}
			set
			{
				if ((this._Last_Name != value))
				{
					this.OnLast_NameChanging(value);
					this.SendPropertyChanging();
					this._Last_Name = value;
					this.SendPropertyChanged("Last_Name");
					this.OnLast_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(50)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OrderTable")]
	public partial class OrderTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Order_Id;
		
		private System.Nullable<int> _Vehicle_Id;
		
		private string _Customer_Id;
		
		private string _Catagory;
		
		private string _Brand_Name;
		
		private string _Car_Model;
		
		private System.Nullable<int> _Price;
		
		private string _Color;
		
		private int _Order_Quantity;
		
		private string _Order_Date;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrder_IdChanging(int value);
    partial void OnOrder_IdChanged();
    partial void OnVehicle_IdChanging(System.Nullable<int> value);
    partial void OnVehicle_IdChanged();
    partial void OnCustomer_IdChanging(string value);
    partial void OnCustomer_IdChanged();
    partial void OnCatagoryChanging(string value);
    partial void OnCatagoryChanged();
    partial void OnBrand_NameChanging(string value);
    partial void OnBrand_NameChanged();
    partial void OnCar_ModelChanging(string value);
    partial void OnCar_ModelChanged();
    partial void OnPriceChanging(System.Nullable<int> value);
    partial void OnPriceChanged();
    partial void OnColorChanging(string value);
    partial void OnColorChanged();
    partial void OnOrder_QuantityChanging(int value);
    partial void OnOrder_QuantityChanged();
    partial void OnOrder_DateChanging(string value);
    partial void OnOrder_DateChanged();
    #endregion
		
		public OrderTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Order_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Order_Id
		{
			get
			{
				return this._Order_Id;
			}
			set
			{
				if ((this._Order_Id != value))
				{
					this.OnOrder_IdChanging(value);
					this.SendPropertyChanging();
					this._Order_Id = value;
					this.SendPropertyChanged("Order_Id");
					this.OnOrder_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vehicle_Id", DbType="Int")]
		public System.Nullable<int> Vehicle_Id
		{
			get
			{
				return this._Vehicle_Id;
			}
			set
			{
				if ((this._Vehicle_Id != value))
				{
					this.OnVehicle_IdChanging(value);
					this.SendPropertyChanging();
					this._Vehicle_Id = value;
					this.SendPropertyChanged("Vehicle_Id");
					this.OnVehicle_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer_Id", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Customer_Id
		{
			get
			{
				return this._Customer_Id;
			}
			set
			{
				if ((this._Customer_Id != value))
				{
					this.OnCustomer_IdChanging(value);
					this.SendPropertyChanging();
					this._Customer_Id = value;
					this.SendPropertyChanged("Customer_Id");
					this.OnCustomer_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Catagory", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Catagory
		{
			get
			{
				return this._Catagory;
			}
			set
			{
				if ((this._Catagory != value))
				{
					this.OnCatagoryChanging(value);
					this.SendPropertyChanging();
					this._Catagory = value;
					this.SendPropertyChanged("Catagory");
					this.OnCatagoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand_Name", DbType="NVarChar(50)")]
		public string Brand_Name
		{
			get
			{
				return this._Brand_Name;
			}
			set
			{
				if ((this._Brand_Name != value))
				{
					this.OnBrand_NameChanging(value);
					this.SendPropertyChanging();
					this._Brand_Name = value;
					this.SendPropertyChanged("Brand_Name");
					this.OnBrand_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Car_Model", DbType="NVarChar(50)")]
		public string Car_Model
		{
			get
			{
				return this._Car_Model;
			}
			set
			{
				if ((this._Car_Model != value))
				{
					this.OnCar_ModelChanging(value);
					this.SendPropertyChanging();
					this._Car_Model = value;
					this.SendPropertyChanged("Car_Model");
					this.OnCar_ModelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Int")]
		public System.Nullable<int> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Color", DbType="NVarChar(50)")]
		public string Color
		{
			get
			{
				return this._Color;
			}
			set
			{
				if ((this._Color != value))
				{
					this.OnColorChanging(value);
					this.SendPropertyChanging();
					this._Color = value;
					this.SendPropertyChanged("Color");
					this.OnColorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Order_Quantity", DbType="Int NOT NULL")]
		public int Order_Quantity
		{
			get
			{
				return this._Order_Quantity;
			}
			set
			{
				if ((this._Order_Quantity != value))
				{
					this.OnOrder_QuantityChanging(value);
					this.SendPropertyChanging();
					this._Order_Quantity = value;
					this.SendPropertyChanged("Order_Quantity");
					this.OnOrder_QuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Order_Date", DbType="NVarChar(50)")]
		public string Order_Date
		{
			get
			{
				return this._Order_Date;
			}
			set
			{
				if ((this._Order_Date != value))
				{
					this.OnOrder_DateChanging(value);
					this.SendPropertyChanging();
					this._Order_Date = value;
					this.SendPropertyChanged("Order_Date");
					this.OnOrder_DateChanged();
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
