#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="huynhhuu_food")]
	public partial class MyDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public MyDBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["huynhhuu_foodConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MyDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<vw_Report> vw_Reports
		{
			get
			{
				return this.GetTable<vw_Report>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.vw_Report")]
	public partial class vw_Report
	{
		
		private int _ID_order;
		
		private string _Emp_Name;
		
		private string _Emp_Phone;
		
		private System.Nullable<int> _ID_user;
		
		private string _user_Name;
		
		private string _Address;
		
		private int _ID_foods;
		
		private string _Name_;
		
		private System.Nullable<int> _Price;
		
		private System.Nullable<int> _Quantity;
		
		private System.Nullable<int> _Discount;
		
		private string _Status;
		
		private System.Nullable<System.DateTime> _Date;
		
		public vw_Report()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_order", DbType="Int NOT NULL")]
		public int ID_order
		{
			get
			{
				return this._ID_order;
			}
			set
			{
				if ((this._ID_order != value))
				{
					this._ID_order = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Emp_Name", DbType="NVarChar(50)")]
		public string Emp_Name
		{
			get
			{
				return this._Emp_Name;
			}
			set
			{
				if ((this._Emp_Name != value))
				{
					this._Emp_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Emp_Phone", DbType="NChar(10)")]
		public string Emp_Phone
		{
			get
			{
				return this._Emp_Phone;
			}
			set
			{
				if ((this._Emp_Phone != value))
				{
					this._Emp_Phone = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_user", DbType="Int")]
		public System.Nullable<int> ID_user
		{
			get
			{
				return this._ID_user;
			}
			set
			{
				if ((this._ID_user != value))
				{
					this._ID_user = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_Name", DbType="NVarChar(50)")]
		public string user_Name
		{
			get
			{
				return this._user_Name;
			}
			set
			{
				if ((this._user_Name != value))
				{
					this._user_Name = value;
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
					this._Address = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_foods", DbType="Int NOT NULL")]
		public int ID_foods
		{
			get
			{
				return this._ID_foods;
			}
			set
			{
				if ((this._ID_foods != value))
				{
					this._ID_foods = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name_", DbType="NVarChar(50)")]
		public string Name_
		{
			get
			{
				return this._Name_;
			}
			set
			{
				if ((this._Name_ != value))
				{
					this._Name_ = value;
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
					this._Price = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int")]
		public System.Nullable<int> Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this._Quantity = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Discount", DbType="Int")]
		public System.Nullable<int> Discount
		{
			get
			{
				return this._Discount;
			}
			set
			{
				if ((this._Discount != value))
				{
					this._Discount = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="NVarChar(50)")]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this._Status = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this._Date = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
