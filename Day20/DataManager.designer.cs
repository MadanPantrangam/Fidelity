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

namespace Day01.Day20
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
	public partial class DataManagerDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertDept(Dept instance);
    partial void UpdateDept(Dept instance);
    partial void DeleteDept(Dept instance);
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertDoctor(Doctor instance);
    partial void UpdateDoctor(Doctor instance);
    partial void DeleteDoctor(Doctor instance);
    partial void InsertPatient(Patient instance);
    partial void UpdatePatient(Patient instance);
    partial void DeletePatient(Patient instance);
    #endregion
		
		public DataManagerDataContext() : 
				base(global::Day01.Properties.Settings.Default.TrainningDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataManagerDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataManagerDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataManagerDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataManagerDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<Dept> Depts
		{
			get
			{
				return this.GetTable<Dept>();
			}
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<Doctor> Doctors
		{
			get
			{
				return this.GetTable<Doctor>();
			}
		}
		
		public System.Data.Linq.Table<Patient> Patients
		{
			get
			{
				return this.GetTable<Patient>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CustomerID;
		
		private string _CustomerName;
		
		private System.Nullable<System.DateTime> _VisitTime;
		
		private long _ContactNo;
		
		private string _City;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIDChanging(int value);
    partial void OnCustomerIDChanged();
    partial void OnCustomerNameChanging(string value);
    partial void OnCustomerNameChanged();
    partial void OnVisitTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnVisitTimeChanged();
    partial void OnContactNoChanging(long value);
    partial void OnContactNoChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    #endregion
		
		public Customer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string CustomerName
		{
			get
			{
				return this._CustomerName;
			}
			set
			{
				if ((this._CustomerName != value))
				{
					this.OnCustomerNameChanging(value);
					this.SendPropertyChanging();
					this._CustomerName = value;
					this.SendPropertyChanged("CustomerName");
					this.OnCustomerNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VisitTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> VisitTime
		{
			get
			{
				return this._VisitTime;
			}
			set
			{
				if ((this._VisitTime != value))
				{
					this.OnVisitTimeChanging(value);
					this.SendPropertyChanging();
					this._VisitTime = value;
					this.SendPropertyChanged("VisitTime");
					this.OnVisitTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactNo", DbType="BigInt NOT NULL")]
		public long ContactNo
		{
			get
			{
				return this._ContactNo;
			}
			set
			{
				if ((this._ContactNo != value))
				{
					this.OnContactNoChanging(value);
					this.SendPropertyChanging();
					this._ContactNo = value;
					this.SendPropertyChanged("ContactNo");
					this.OnContactNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(50)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Doctor")]
	public partial class Doctor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DocId;
		
		private string _Name;
		
		private string _Specilization;
		
		private System.Nullable<int> _Fee;
		
		private EntitySet<Patient> _Patients;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDocIdChanging(int value);
    partial void OnDocIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSpecilizationChanging(string value);
    partial void OnSpecilizationChanged();
    partial void OnFeeChanging(System.Nullable<int> value);
    partial void OnFeeChanged();
    #endregion
		
		public Doctor()
		{
			this._Patients = new EntitySet<Patient>(new Action<Patient>(this.attach_Patients), new Action<Patient>(this.detach_Patients));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DocId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int DocId
		{
			get
			{
				return this._DocId;
			}
			set
			{
				if ((this._DocId != value))
				{
					this.OnDocIdChanging(value);
					this.SendPropertyChanging();
					this._DocId = value;
					this.SendPropertyChanged("DocId");
					this.OnDocIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Specilization", DbType="VarChar(50)")]
		public string Specilization
		{
			get
			{
				return this._Specilization;
			}
			set
			{
				if ((this._Specilization != value))
				{
					this.OnSpecilizationChanging(value);
					this.SendPropertyChanging();
					this._Specilization = value;
					this.SendPropertyChanged("Specilization");
					this.OnSpecilizationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fee", DbType="Int")]
		public System.Nullable<int> Fee
		{
			get
			{
				return this._Fee;
			}
			set
			{
				if ((this._Fee != value))
				{
					this.OnFeeChanging(value);
					this.SendPropertyChanging();
					this._Fee = value;
					this.SendPropertyChanged("Fee");
					this.OnFeeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Doctor_Patient", Storage="_Patients", ThisKey="DocId", OtherKey="DocId")]
		public EntitySet<Patient> Patients
		{
			get
			{
				return this._Patients;
			}
			set
			{
				this._Patients.Assign(value);
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
		
		private void attach_Patients(Patient entity)
		{
			this.SendPropertyChanging();
			entity.Doctor = this;
		}
		
		private void detach_Patients(Patient entity)
		{
			this.SendPropertyChanging();
			entity.Doctor = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Patient")]
	public partial class Patient : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private System.Nullable<long> _ContactNo;
		
		private System.Nullable<System.DateTime> _VisitDate;
		
		private System.Nullable<int> _DocId;
		
		private EntityRef<Doctor> _Doctor;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnContactNoChanging(System.Nullable<long> value);
    partial void OnContactNoChanged();
    partial void OnVisitDateChanging(System.Nullable<System.DateTime> value);
    partial void OnVisitDateChanged();
    partial void OnDocIdChanging(System.Nullable<int> value);
    partial void OnDocIdChanged();
    #endregion
		
		public Patient()
		{
			this._Doctor = default(EntityRef<Doctor>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactNo", DbType="BigInt")]
		public System.Nullable<long> ContactNo
		{
			get
			{
				return this._ContactNo;
			}
			set
			{
				if ((this._ContactNo != value))
				{
					this.OnContactNoChanging(value);
					this.SendPropertyChanging();
					this._ContactNo = value;
					this.SendPropertyChanged("ContactNo");
					this.OnContactNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VisitDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> VisitDate
		{
			get
			{
				return this._VisitDate;
			}
			set
			{
				if ((this._VisitDate != value))
				{
					this.OnVisitDateChanging(value);
					this.SendPropertyChanging();
					this._VisitDate = value;
					this.SendPropertyChanged("VisitDate");
					this.OnVisitDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DocId", DbType="Int")]
		public System.Nullable<int> DocId
		{
			get
			{
				return this._DocId;
			}
			set
			{
				if ((this._DocId != value))
				{
					if (this._Doctor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDocIdChanging(value);
					this.SendPropertyChanging();
					this._DocId = value;
					this.SendPropertyChanged("DocId");
					this.OnDocIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Doctor_Patient", Storage="_Doctor", ThisKey="DocId", OtherKey="DocId", IsForeignKey=true)]
		public Doctor Doctor
		{
			get
			{
				return this._Doctor.Entity;
			}
			set
			{
				Doctor previousValue = this._Doctor.Entity;
				if (((previousValue != value) 
							|| (this._Doctor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Doctor.Entity = null;
						previousValue.Patients.Remove(this);
					}
					this._Doctor.Entity = value;
					if ((value != null))
					{
						value.Patients.Add(this);
						this._DocId = value.DocId;
					}
					else
					{
						this._DocId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Doctor");
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
