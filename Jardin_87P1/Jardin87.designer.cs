﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jardin_87P1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Jardin87_beta2")]
	public partial class Jardin87DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertAdministracion(Administracion instance);
    partial void UpdateAdministracion(Administracion instance);
    partial void DeleteAdministracion(Administracion instance);
    partial void InsertApoderado(Apoderado instance);
    partial void UpdateApoderado(Apoderado instance);
    partial void DeleteApoderado(Apoderado instance);
    partial void InsertDocente(Docente instance);
    partial void UpdateDocente(Docente instance);
    partial void DeleteDocente(Docente instance);
    partial void InsertEstudiantes(Estudiantes instance);
    partial void UpdateEstudiantes(Estudiantes instance);
    partial void DeleteEstudiantes(Estudiantes instance);
    partial void InsertSalon(Salon instance);
    partial void UpdateSalon(Salon instance);
    partial void DeleteSalon(Salon instance);
    #endregion
		
		public Jardin87DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Jardin87_beta2ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public Jardin87DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Jardin87DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Jardin87DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Jardin87DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Administracion> Administracion
		{
			get
			{
				return this.GetTable<Administracion>();
			}
		}
		
		public System.Data.Linq.Table<Apoderado> Apoderado
		{
			get
			{
				return this.GetTable<Apoderado>();
			}
		}
		
		public System.Data.Linq.Table<Docente> Docente
		{
			get
			{
				return this.GetTable<Docente>();
			}
		}
		
		public System.Data.Linq.Table<Estudiantes> Estudiantes
		{
			get
			{
				return this.GetTable<Estudiantes>();
			}
		}
		
		public System.Data.Linq.Table<Salon> Salon
		{
			get
			{
				return this.GetTable<Salon>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Administracion")]
	public partial class Administracion : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IdAdministrador;
		
		private string _Usuario;
		
		private string _Contrasenia;
		
		private string _IdSalon;
		
		private EntityRef<Salon> _Salon;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdAdministradorChanging(string value);
    partial void OnIdAdministradorChanged();
    partial void OnUsuarioChanging(string value);
    partial void OnUsuarioChanged();
    partial void OnContraseniaChanging(string value);
    partial void OnContraseniaChanged();
    partial void OnIdSalonChanging(string value);
    partial void OnIdSalonChanged();
    #endregion
		
		public Administracion()
		{
			this._Salon = default(EntityRef<Salon>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdAdministrador", DbType="Char(8) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IdAdministrador
		{
			get
			{
				return this._IdAdministrador;
			}
			set
			{
				if ((this._IdAdministrador != value))
				{
					this.OnIdAdministradorChanging(value);
					this.SendPropertyChanging();
					this._IdAdministrador = value;
					this.SendPropertyChanged("IdAdministrador");
					this.OnIdAdministradorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Usuario", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Usuario
		{
			get
			{
				return this._Usuario;
			}
			set
			{
				if ((this._Usuario != value))
				{
					this.OnUsuarioChanging(value);
					this.SendPropertyChanging();
					this._Usuario = value;
					this.SendPropertyChanged("Usuario");
					this.OnUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contrasenia", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Contrasenia
		{
			get
			{
				return this._Contrasenia;
			}
			set
			{
				if ((this._Contrasenia != value))
				{
					this.OnContraseniaChanging(value);
					this.SendPropertyChanging();
					this._Contrasenia = value;
					this.SendPropertyChanged("Contrasenia");
					this.OnContraseniaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdSalon", DbType="Char(8) NOT NULL", CanBeNull=false)]
		public string IdSalon
		{
			get
			{
				return this._IdSalon;
			}
			set
			{
				if ((this._IdSalon != value))
				{
					if (this._Salon.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdSalonChanging(value);
					this.SendPropertyChanging();
					this._IdSalon = value;
					this.SendPropertyChanged("IdSalon");
					this.OnIdSalonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Salon_Administracion", Storage="_Salon", ThisKey="IdSalon", OtherKey="IdSalon", IsForeignKey=true)]
		public Salon Salon
		{
			get
			{
				return this._Salon.Entity;
			}
			set
			{
				Salon previousValue = this._Salon.Entity;
				if (((previousValue != value) 
							|| (this._Salon.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Salon.Entity = null;
						previousValue.Administracion.Remove(this);
					}
					this._Salon.Entity = value;
					if ((value != null))
					{
						value.Administracion.Add(this);
						this._IdSalon = value.IdSalon;
					}
					else
					{
						this._IdSalon = default(string);
					}
					this.SendPropertyChanged("Salon");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Apoderado")]
	public partial class Apoderado : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IdApoderado;
		
		private string _Nombre;
		
		private string _Apellido;
		
		private string _Direccion;
		
		private string _Telefono;
		
		private string _DNI;
		
		private string _CorreoElectronico;
		
		private EntitySet<Estudiantes> _Estudiantes;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdApoderadoChanging(string value);
    partial void OnIdApoderadoChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnApellidoChanging(string value);
    partial void OnApellidoChanged();
    partial void OnDireccionChanging(string value);
    partial void OnDireccionChanged();
    partial void OnTelefonoChanging(string value);
    partial void OnTelefonoChanged();
    partial void OnDNIChanging(string value);
    partial void OnDNIChanged();
    partial void OnCorreoElectronicoChanging(string value);
    partial void OnCorreoElectronicoChanged();
    #endregion
		
		public Apoderado()
		{
			this._Estudiantes = new EntitySet<Estudiantes>(new Action<Estudiantes>(this.attach_Estudiantes), new Action<Estudiantes>(this.detach_Estudiantes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdApoderado", DbType="Char(8) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IdApoderado
		{
			get
			{
				return this._IdApoderado;
			}
			set
			{
				if ((this._IdApoderado != value))
				{
					this.OnIdApoderadoChanging(value);
					this.SendPropertyChanging();
					this._IdApoderado = value;
					this.SendPropertyChanged("IdApoderado");
					this.OnIdApoderadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Apellido
		{
			get
			{
				return this._Apellido;
			}
			set
			{
				if ((this._Apellido != value))
				{
					this.OnApellidoChanging(value);
					this.SendPropertyChanging();
					this._Apellido = value;
					this.SendPropertyChanged("Apellido");
					this.OnApellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="VarChar(50)")]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this.OnDireccionChanging(value);
					this.SendPropertyChanging();
					this._Direccion = value;
					this.SendPropertyChanged("Direccion");
					this.OnDireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="VarChar(9)")]
		public string Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this.OnTelefonoChanging(value);
					this.SendPropertyChanging();
					this._Telefono = value;
					this.SendPropertyChanged("Telefono");
					this.OnTelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNI", DbType="VarChar(8)")]
		public string DNI
		{
			get
			{
				return this._DNI;
			}
			set
			{
				if ((this._DNI != value))
				{
					this.OnDNIChanging(value);
					this.SendPropertyChanging();
					this._DNI = value;
					this.SendPropertyChanged("DNI");
					this.OnDNIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CorreoElectronico", DbType="VarChar(50)")]
		public string CorreoElectronico
		{
			get
			{
				return this._CorreoElectronico;
			}
			set
			{
				if ((this._CorreoElectronico != value))
				{
					this.OnCorreoElectronicoChanging(value);
					this.SendPropertyChanging();
					this._CorreoElectronico = value;
					this.SendPropertyChanged("CorreoElectronico");
					this.OnCorreoElectronicoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Apoderado_Estudiantes", Storage="_Estudiantes", ThisKey="IdApoderado", OtherKey="IdApoderado")]
		public EntitySet<Estudiantes> Estudiantes
		{
			get
			{
				return this._Estudiantes;
			}
			set
			{
				this._Estudiantes.Assign(value);
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
		
		private void attach_Estudiantes(Estudiantes entity)
		{
			this.SendPropertyChanging();
			entity.Apoderado = this;
		}
		
		private void detach_Estudiantes(Estudiantes entity)
		{
			this.SendPropertyChanging();
			entity.Apoderado = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Docente")]
	public partial class Docente : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IdDocente;
		
		private string _Nombre;
		
		private string _Apellido;
		
		private string _CorreoElectronico;
		
		private string _Direccion;
		
		private string _Usuario;
		
		private string _Contrasenia;
		
		private EntitySet<Estudiantes> _Estudiantes;
		
		private EntitySet<Salon> _Salon;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdDocenteChanging(string value);
    partial void OnIdDocenteChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnApellidoChanging(string value);
    partial void OnApellidoChanged();
    partial void OnCorreoElectronicoChanging(string value);
    partial void OnCorreoElectronicoChanged();
    partial void OnDireccionChanging(string value);
    partial void OnDireccionChanged();
    partial void OnUsuarioChanging(string value);
    partial void OnUsuarioChanged();
    partial void OnContraseniaChanging(string value);
    partial void OnContraseniaChanged();
    #endregion
		
		public Docente()
		{
			this._Estudiantes = new EntitySet<Estudiantes>(new Action<Estudiantes>(this.attach_Estudiantes), new Action<Estudiantes>(this.detach_Estudiantes));
			this._Salon = new EntitySet<Salon>(new Action<Salon>(this.attach_Salon), new Action<Salon>(this.detach_Salon));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdDocente", DbType="Char(8) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IdDocente
		{
			get
			{
				return this._IdDocente;
			}
			set
			{
				if ((this._IdDocente != value))
				{
					this.OnIdDocenteChanging(value);
					this.SendPropertyChanging();
					this._IdDocente = value;
					this.SendPropertyChanged("IdDocente");
					this.OnIdDocenteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Apellido
		{
			get
			{
				return this._Apellido;
			}
			set
			{
				if ((this._Apellido != value))
				{
					this.OnApellidoChanging(value);
					this.SendPropertyChanging();
					this._Apellido = value;
					this.SendPropertyChanged("Apellido");
					this.OnApellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CorreoElectronico", DbType="VarChar(50)")]
		public string CorreoElectronico
		{
			get
			{
				return this._CorreoElectronico;
			}
			set
			{
				if ((this._CorreoElectronico != value))
				{
					this.OnCorreoElectronicoChanging(value);
					this.SendPropertyChanging();
					this._CorreoElectronico = value;
					this.SendPropertyChanged("CorreoElectronico");
					this.OnCorreoElectronicoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="VarChar(50)")]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this.OnDireccionChanging(value);
					this.SendPropertyChanging();
					this._Direccion = value;
					this.SendPropertyChanged("Direccion");
					this.OnDireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Usuario", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Usuario
		{
			get
			{
				return this._Usuario;
			}
			set
			{
				if ((this._Usuario != value))
				{
					this.OnUsuarioChanging(value);
					this.SendPropertyChanging();
					this._Usuario = value;
					this.SendPropertyChanged("Usuario");
					this.OnUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contrasenia", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Contrasenia
		{
			get
			{
				return this._Contrasenia;
			}
			set
			{
				if ((this._Contrasenia != value))
				{
					this.OnContraseniaChanging(value);
					this.SendPropertyChanging();
					this._Contrasenia = value;
					this.SendPropertyChanged("Contrasenia");
					this.OnContraseniaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Docente_Estudiantes", Storage="_Estudiantes", ThisKey="IdDocente", OtherKey="IdDocente")]
		public EntitySet<Estudiantes> Estudiantes
		{
			get
			{
				return this._Estudiantes;
			}
			set
			{
				this._Estudiantes.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Docente_Salon", Storage="_Salon", ThisKey="IdDocente", OtherKey="IdDocente")]
		public EntitySet<Salon> Salon
		{
			get
			{
				return this._Salon;
			}
			set
			{
				this._Salon.Assign(value);
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
		
		private void attach_Estudiantes(Estudiantes entity)
		{
			this.SendPropertyChanging();
			entity.Docente = this;
		}
		
		private void detach_Estudiantes(Estudiantes entity)
		{
			this.SendPropertyChanging();
			entity.Docente = null;
		}
		
		private void attach_Salon(Salon entity)
		{
			this.SendPropertyChanging();
			entity.Docente = this;
		}
		
		private void detach_Salon(Salon entity)
		{
			this.SendPropertyChanging();
			entity.Docente = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Estudiantes")]
	public partial class Estudiantes : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IdEstudiante;
		
		private string _Nombre;
		
		private string _Apellido;
		
		private string _DNI;
		
		private string _Edad;
		
		private System.Nullable<System.DateTime> _Fecha_nacimiento;
		
		private string _IdApoderado;
		
		private string _IdDocente;
		
		private EntityRef<Apoderado> _Apoderado;
		
		private EntityRef<Docente> _Docente;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdEstudianteChanging(string value);
    partial void OnIdEstudianteChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnApellidoChanging(string value);
    partial void OnApellidoChanged();
    partial void OnDNIChanging(string value);
    partial void OnDNIChanged();
    partial void OnEdadChanging(string value);
    partial void OnEdadChanged();
    partial void OnFecha_nacimientoChanging(System.Nullable<System.DateTime> value);
    partial void OnFecha_nacimientoChanged();
    partial void OnIdApoderadoChanging(string value);
    partial void OnIdApoderadoChanged();
    partial void OnIdDocenteChanging(string value);
    partial void OnIdDocenteChanged();
    #endregion
		
		public Estudiantes()
		{
			this._Apoderado = default(EntityRef<Apoderado>);
			this._Docente = default(EntityRef<Docente>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdEstudiante", DbType="Char(8) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IdEstudiante
		{
			get
			{
				return this._IdEstudiante;
			}
			set
			{
				if ((this._IdEstudiante != value))
				{
					this.OnIdEstudianteChanging(value);
					this.SendPropertyChanging();
					this._IdEstudiante = value;
					this.SendPropertyChanged("IdEstudiante");
					this.OnIdEstudianteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Apellido
		{
			get
			{
				return this._Apellido;
			}
			set
			{
				if ((this._Apellido != value))
				{
					this.OnApellidoChanging(value);
					this.SendPropertyChanging();
					this._Apellido = value;
					this.SendPropertyChanged("Apellido");
					this.OnApellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNI", DbType="VarChar(8)")]
		public string DNI
		{
			get
			{
				return this._DNI;
			}
			set
			{
				if ((this._DNI != value))
				{
					this.OnDNIChanging(value);
					this.SendPropertyChanging();
					this._DNI = value;
					this.SendPropertyChanged("DNI");
					this.OnDNIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Edad", DbType="VarChar(3)")]
		public string Edad
		{
			get
			{
				return this._Edad;
			}
			set
			{
				if ((this._Edad != value))
				{
					this.OnEdadChanging(value);
					this.SendPropertyChanging();
					this._Edad = value;
					this.SendPropertyChanged("Edad");
					this.OnEdadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha_nacimiento", DbType="Date")]
		public System.Nullable<System.DateTime> Fecha_nacimiento
		{
			get
			{
				return this._Fecha_nacimiento;
			}
			set
			{
				if ((this._Fecha_nacimiento != value))
				{
					this.OnFecha_nacimientoChanging(value);
					this.SendPropertyChanging();
					this._Fecha_nacimiento = value;
					this.SendPropertyChanged("Fecha_nacimiento");
					this.OnFecha_nacimientoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdApoderado", DbType="Char(8) NOT NULL", CanBeNull=false)]
		public string IdApoderado
		{
			get
			{
				return this._IdApoderado;
			}
			set
			{
				if ((this._IdApoderado != value))
				{
					if (this._Apoderado.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdApoderadoChanging(value);
					this.SendPropertyChanging();
					this._IdApoderado = value;
					this.SendPropertyChanged("IdApoderado");
					this.OnIdApoderadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdDocente", DbType="Char(8) NOT NULL", CanBeNull=false)]
		public string IdDocente
		{
			get
			{
				return this._IdDocente;
			}
			set
			{
				if ((this._IdDocente != value))
				{
					if (this._Docente.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdDocenteChanging(value);
					this.SendPropertyChanging();
					this._IdDocente = value;
					this.SendPropertyChanged("IdDocente");
					this.OnIdDocenteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Apoderado_Estudiantes", Storage="_Apoderado", ThisKey="IdApoderado", OtherKey="IdApoderado", IsForeignKey=true)]
		public Apoderado Apoderado
		{
			get
			{
				return this._Apoderado.Entity;
			}
			set
			{
				Apoderado previousValue = this._Apoderado.Entity;
				if (((previousValue != value) 
							|| (this._Apoderado.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Apoderado.Entity = null;
						previousValue.Estudiantes.Remove(this);
					}
					this._Apoderado.Entity = value;
					if ((value != null))
					{
						value.Estudiantes.Add(this);
						this._IdApoderado = value.IdApoderado;
					}
					else
					{
						this._IdApoderado = default(string);
					}
					this.SendPropertyChanged("Apoderado");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Docente_Estudiantes", Storage="_Docente", ThisKey="IdDocente", OtherKey="IdDocente", IsForeignKey=true)]
		public Docente Docente
		{
			get
			{
				return this._Docente.Entity;
			}
			set
			{
				Docente previousValue = this._Docente.Entity;
				if (((previousValue != value) 
							|| (this._Docente.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Docente.Entity = null;
						previousValue.Estudiantes.Remove(this);
					}
					this._Docente.Entity = value;
					if ((value != null))
					{
						value.Estudiantes.Add(this);
						this._IdDocente = value.IdDocente;
					}
					else
					{
						this._IdDocente = default(string);
					}
					this.SendPropertyChanged("Docente");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Salon")]
	public partial class Salon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IdSalon;
		
		private string _NombreSalon;
		
		private string _IdDocente;
		
		private EntitySet<Administracion> _Administracion;
		
		private EntityRef<Docente> _Docente;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdSalonChanging(string value);
    partial void OnIdSalonChanged();
    partial void OnNombreSalonChanging(string value);
    partial void OnNombreSalonChanged();
    partial void OnIdDocenteChanging(string value);
    partial void OnIdDocenteChanged();
    #endregion
		
		public Salon()
		{
			this._Administracion = new EntitySet<Administracion>(new Action<Administracion>(this.attach_Administracion), new Action<Administracion>(this.detach_Administracion));
			this._Docente = default(EntityRef<Docente>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdSalon", DbType="Char(8) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IdSalon
		{
			get
			{
				return this._IdSalon;
			}
			set
			{
				if ((this._IdSalon != value))
				{
					this.OnIdSalonChanging(value);
					this.SendPropertyChanging();
					this._IdSalon = value;
					this.SendPropertyChanged("IdSalon");
					this.OnIdSalonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreSalon", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string NombreSalon
		{
			get
			{
				return this._NombreSalon;
			}
			set
			{
				if ((this._NombreSalon != value))
				{
					this.OnNombreSalonChanging(value);
					this.SendPropertyChanging();
					this._NombreSalon = value;
					this.SendPropertyChanged("NombreSalon");
					this.OnNombreSalonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdDocente", DbType="Char(8) NOT NULL", CanBeNull=false)]
		public string IdDocente
		{
			get
			{
				return this._IdDocente;
			}
			set
			{
				if ((this._IdDocente != value))
				{
					if (this._Docente.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdDocenteChanging(value);
					this.SendPropertyChanging();
					this._IdDocente = value;
					this.SendPropertyChanged("IdDocente");
					this.OnIdDocenteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Salon_Administracion", Storage="_Administracion", ThisKey="IdSalon", OtherKey="IdSalon")]
		public EntitySet<Administracion> Administracion
		{
			get
			{
				return this._Administracion;
			}
			set
			{
				this._Administracion.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Docente_Salon", Storage="_Docente", ThisKey="IdDocente", OtherKey="IdDocente", IsForeignKey=true)]
		public Docente Docente
		{
			get
			{
				return this._Docente.Entity;
			}
			set
			{
				Docente previousValue = this._Docente.Entity;
				if (((previousValue != value) 
							|| (this._Docente.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Docente.Entity = null;
						previousValue.Salon.Remove(this);
					}
					this._Docente.Entity = value;
					if ((value != null))
					{
						value.Salon.Add(this);
						this._IdDocente = value.IdDocente;
					}
					else
					{
						this._IdDocente = default(string);
					}
					this.SendPropertyChanged("Docente");
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
		
		private void attach_Administracion(Administracion entity)
		{
			this.SendPropertyChanging();
			entity.Salon = this;
		}
		
		private void detach_Administracion(Administracion entity)
		{
			this.SendPropertyChanging();
			entity.Salon = null;
		}
	}
}
#pragma warning restore 1591
