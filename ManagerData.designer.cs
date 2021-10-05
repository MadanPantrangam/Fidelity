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

namespace SampleWebApp
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TrainningDB")]
	public partial class ManagerDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertDept(Dept instance);
    partial void UpdateDept(Dept instance);
    partial void DeleteDept(Dept instance);
    #endregion
		
		public ManagerDataDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TrainningDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ManagerDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ManagerDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ManagerDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ManagerDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<Dept> Depts
		{
			get
			{
				return this.GetTable<Dept>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employee")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EmpId;
		
		private string _EmpName;
		
		private string _EmpAddress;
		
		private System.Nullable<int> _EmpSalary;
		
		private int _DepId;
		
		private EntityRef<Dept> _Dept;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmpIdChanging(int value);
    partial void OnEmpIdChanged();
    partial void OnEmpNameChanging(string value);
    partial void OnEmpNameChanged();
    partial void OnEmpAddressChanging(string value);
    partial void OnEmpAddressChanged();
    partial void OnEmpSalaryChanging(System.Nullable<int> value);
    partial void OnEmpSalaryChanged();
    partial void OnDepIdChanging(int value);
    partial void OnDepIdChanged();
    #endregion
		
		public Employee()
		{
			this._Dept = default(EntityRef<Dept>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int EmpId
		{
			get
			{
				return this._EmpId;
			}
			set
			{
				if ((this._EmpId != value))
				{
					this.OnEmpIdChanging(value);
					this.SendPropertyChanging();
					this._EmpId = value;
					this.SendPropertyChanged("EmpId");
					this.OnEmpIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string EmpName
		{
			get
			{
				return this._EmpName;
			}
			set
			{
				if ((this._EmpName != value))
				{
					this.OnEmpNameChanging(value);
					this.SendPropertyChanging();
					this._EmpName = value;
					this.SendPropertyChanged("EmpName");
					this.OnEmpNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpAddress", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string EmpAddress
		{
			get
			{
				return this._EmpAddress;
			}
			set
			{
				if ((this._EmpAddress != value))
				{
					this.OnEmpAddressChanging(value);
					this.SendPropertyChanging();
					this._EmpAddress = value;
					this.SendPropertyChanged("EmpAddress");
					this.OnEmpAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpSalary", DbType="Int")]
		public System.Nullable<int> EmpSalary
		{
			get
			{
				return this._EmpSalary;
			}
			set
			{
				if ((this._EmpSalary != value))
				{
					this.OnEmpSalaryChanging(value);
					this.SendPropertyChanging();
					this._EmpSalary = value;
					this.SendPropertyChanged("EmpSalary");
					this.OnEmpSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepId", DbType="Int NOT NULL")]
		public int DepId
		{
			get
			{
				return this._DepId;
			}
			set
			{
				if ((this._DepId != value))
				{
					if (this._Dept.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDepIdChanging(value);
					this.SendPropertyChanging();
					this._DepId = value;
					this.SendPropertyChanged("DepId");
					this.OnDepIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Dept_Employee", Storage="_Dept", ThisKey="DepId", OtherKey="DeptId", IsForeignKey=true)]
		public Dept Dept
		{
			get
			{
				return this._Dept.Entity;
			}
			set
			{
				Dept previousValue = this._Dept.Entity;
				if (((previousValue != value) 
							|| (this._Dept.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Dept.Entity = null;
						previousValue.Employees.Remove(this);
					}
					this._Dept.Entity = value;
					if ((value != null))
					{
						value.Employees.Add(this);
						this._DepId = value.DeptId;
					}
					else
					{
						this._DepId = default(int);
					}
					this.SendPropertyChanged("Dept");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Dept")]
	public partial class Dept : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DeptId;
		
		private string _DeptName;
		
		private EntitySet<Employee> _Employees;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDeptIdChanging(int value);
    partial void OnDeptIdChanged();
    partial void OnDeptNameChanging(string value);
    partial void OnDeptNameChanged();
    #endregion
		
		public Dept()
		{
			this._Employees = new EntitySet<Employee>(new Action<Employee>(this.attach_Employees), new Action<Employee>(this.detach_Employees));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int DeptId
		{
			get
			{
				return this._DeptId;
			}
			set
			{
				if ((this._DeptId != value))
				{
					this.OnDeptIdChanging(value);
					this.SendPropertyChanging();
					this._DeptId = value;
					this.SendPropertyChanged("DeptId");
					this.OnDeptIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptName", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string DeptName
		{
			get
			{
				return this._DeptName;
			}
			set
			{
				if ((this._DeptName != value))
				{
					this.OnDeptNameChanging(value);
					this.SendPropertyChanging();
					this._DeptName = value;
					this.SendPropertyChanged("DeptName");
					this.OnDeptNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Dept_Employee", Storage="_Employees", ThisKey="DeptId", OtherKey="DepId")]
		public EntitySet<Employee> Employees
		{
			get
			{
				return this._Employees;
			}
			set
			{
				this._Employees.Assign(value);
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
		
		private void attach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Dept = this;
		}
		
		private void detach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Dept = null;
		}
	}
}
#pragma warning restore 1591
