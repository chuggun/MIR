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

namespace Linq2Sql
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="mir")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMETERING(METERING instance);
    partial void UpdateMETERING(METERING instance);
    partial void DeleteMETERING(METERING instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::Linq2Sql.Properties.Settings.Default.mirConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<METERING> METERINGs
		{
			get
			{
				return this.GetTable<METERING>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.METERING_Delete")]
		public int METERING_Delete([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDOBJECT", DbType="Int")] System.Nullable<int> iDOBJECT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDTYPE_OBJECT", DbType="Int")] System.Nullable<int> iDTYPE_OBJECT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TIME_END", DbType="DateTime2")] System.Nullable<System.DateTime> tIME_END, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDOBJECT_AGGREGATE", DbType="Int")] System.Nullable<int> iDOBJECT_AGGREGATE, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDOBJECT_AVERAGE", DbType="Int")] System.Nullable<int> iDOBJECT_AVERAGE)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDOBJECT, iDTYPE_OBJECT, tIME_END, iDOBJECT_AGGREGATE, iDOBJECT_AVERAGE);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.METERING_Insert")]
		public int METERING_Insert([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDOBJECT", DbType="Int")] System.Nullable<int> iDOBJECT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDTYPE_OBJECT", DbType="Int")] System.Nullable<int> iDTYPE_OBJECT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TIME_END", DbType="DateTime2")] System.Nullable<System.DateTime> tIME_END, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDOBJECT_AGGREGATE", DbType="Int")] System.Nullable<int> iDOBJECT_AGGREGATE, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDOBJECT_AVERAGE", DbType="Int")] System.Nullable<int> iDOBJECT_AVERAGE, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TIME_BEGIN", DbType="DateTime2")] System.Nullable<System.DateTime> tIME_BEGIN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="STATUS", DbType="Int")] System.Nullable<int> sTATUS, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="VALUE_METERING", DbType="Float")] System.Nullable<double> vALUE_METERING, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TIME_INSERT", DbType="DateTime2")] System.Nullable<System.DateTime> tIME_INSERT)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDOBJECT, iDTYPE_OBJECT, tIME_END, iDOBJECT_AGGREGATE, iDOBJECT_AVERAGE, tIME_BEGIN, sTATUS, vALUE_METERING, tIME_INSERT);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.METERING_Update")]
		public int METERING_Update([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDOBJECT", DbType="Int")] System.Nullable<int> iDOBJECT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDTYPE_OBJECT", DbType="Int")] System.Nullable<int> iDTYPE_OBJECT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TIME_END", DbType="DateTime2")] System.Nullable<System.DateTime> tIME_END, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDOBJECT_AGGREGATE", DbType="Int")] System.Nullable<int> iDOBJECT_AGGREGATE, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDOBJECT_AVERAGE", DbType="Int")] System.Nullable<int> iDOBJECT_AVERAGE, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TIME_BEGIN", DbType="DateTime2")] System.Nullable<System.DateTime> tIME_BEGIN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="STATUS", DbType="Int")] System.Nullable<int> sTATUS, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="VALUE_METERING", DbType="Float")] System.Nullable<double> vALUE_METERING, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TIME_INSERT", DbType="DateTime2")] System.Nullable<System.DateTime> tIME_INSERT)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDOBJECT, iDTYPE_OBJECT, tIME_END, iDOBJECT_AGGREGATE, iDOBJECT_AVERAGE, tIME_BEGIN, sTATUS, vALUE_METERING, tIME_INSERT);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.METERINGS")]
	public partial class METERING : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDOBJECT;
		
		private int _IDTYPE_OBJECT;
		
		private System.DateTime _TIME_BEGIN;
		
		private System.DateTime _TIME_END;
		
		private int _IDOBJECT_AGGREGATE;
		
		private int _IDOBJECT_AVERAGE;
		
		private System.Nullable<int> _STATUS;
		
		private double _VALUE_METERING;
		
		private System.DateTime _TIME_INSERT;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDOBJECTChanging(int value);
    partial void OnIDOBJECTChanged();
    partial void OnIDTYPE_OBJECTChanging(int value);
    partial void OnIDTYPE_OBJECTChanged();
    partial void OnTIME_BEGINChanging(System.DateTime value);
    partial void OnTIME_BEGINChanged();
    partial void OnTIME_ENDChanging(System.DateTime value);
    partial void OnTIME_ENDChanged();
    partial void OnIDOBJECT_AGGREGATEChanging(int value);
    partial void OnIDOBJECT_AGGREGATEChanged();
    partial void OnIDOBJECT_AVERAGEChanging(int value);
    partial void OnIDOBJECT_AVERAGEChanged();
    partial void OnSTATUSChanging(System.Nullable<int> value);
    partial void OnSTATUSChanged();
    partial void OnVALUE_METERINGChanging(double value);
    partial void OnVALUE_METERINGChanged();
    partial void OnTIME_INSERTChanging(System.DateTime value);
    partial void OnTIME_INSERTChanged();
    #endregion
		
		public METERING()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDOBJECT", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IDOBJECT
		{
			get
			{
				return this._IDOBJECT;
			}
			set
			{
				if ((this._IDOBJECT != value))
				{
					this.OnIDOBJECTChanging(value);
					this.SendPropertyChanging();
					this._IDOBJECT = value;
					this.SendPropertyChanged("IDOBJECT");
					this.OnIDOBJECTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDTYPE_OBJECT", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IDTYPE_OBJECT
		{
			get
			{
				return this._IDTYPE_OBJECT;
			}
			set
			{
				if ((this._IDTYPE_OBJECT != value))
				{
					this.OnIDTYPE_OBJECTChanging(value);
					this.SendPropertyChanging();
					this._IDTYPE_OBJECT = value;
					this.SendPropertyChanged("IDTYPE_OBJECT");
					this.OnIDTYPE_OBJECTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TIME_BEGIN", DbType="DateTime2 NOT NULL")]
		public System.DateTime TIME_BEGIN
		{
			get
			{
				return this._TIME_BEGIN;
			}
			set
			{
				if ((this._TIME_BEGIN != value))
				{
					this.OnTIME_BEGINChanging(value);
					this.SendPropertyChanging();
					this._TIME_BEGIN = value;
					this.SendPropertyChanged("TIME_BEGIN");
					this.OnTIME_BEGINChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TIME_END", DbType="DateTime2 NOT NULL", IsPrimaryKey=true)]
		public System.DateTime TIME_END
		{
			get
			{
				return this._TIME_END;
			}
			set
			{
				if ((this._TIME_END != value))
				{
					this.OnTIME_ENDChanging(value);
					this.SendPropertyChanging();
					this._TIME_END = value;
					this.SendPropertyChanged("TIME_END");
					this.OnTIME_ENDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDOBJECT_AGGREGATE", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IDOBJECT_AGGREGATE
		{
			get
			{
				return this._IDOBJECT_AGGREGATE;
			}
			set
			{
				if ((this._IDOBJECT_AGGREGATE != value))
				{
					this.OnIDOBJECT_AGGREGATEChanging(value);
					this.SendPropertyChanging();
					this._IDOBJECT_AGGREGATE = value;
					this.SendPropertyChanged("IDOBJECT_AGGREGATE");
					this.OnIDOBJECT_AGGREGATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDOBJECT_AVERAGE", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IDOBJECT_AVERAGE
		{
			get
			{
				return this._IDOBJECT_AVERAGE;
			}
			set
			{
				if ((this._IDOBJECT_AVERAGE != value))
				{
					this.OnIDOBJECT_AVERAGEChanging(value);
					this.SendPropertyChanging();
					this._IDOBJECT_AVERAGE = value;
					this.SendPropertyChanged("IDOBJECT_AVERAGE");
					this.OnIDOBJECT_AVERAGEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STATUS", DbType="Int")]
		public System.Nullable<int> STATUS
		{
			get
			{
				return this._STATUS;
			}
			set
			{
				if ((this._STATUS != value))
				{
					this.OnSTATUSChanging(value);
					this.SendPropertyChanging();
					this._STATUS = value;
					this.SendPropertyChanged("STATUS");
					this.OnSTATUSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VALUE_METERING", DbType="Float NOT NULL")]
		public double VALUE_METERING
		{
			get
			{
				return this._VALUE_METERING;
			}
			set
			{
				if ((this._VALUE_METERING != value))
				{
					this.OnVALUE_METERINGChanging(value);
					this.SendPropertyChanging();
					this._VALUE_METERING = value;
					this.SendPropertyChanged("VALUE_METERING");
					this.OnVALUE_METERINGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TIME_INSERT", DbType="DateTime2 NOT NULL")]
		public System.DateTime TIME_INSERT
		{
			get
			{
				return this._TIME_INSERT;
			}
			set
			{
				if ((this._TIME_INSERT != value))
				{
					this.OnTIME_INSERTChanging(value);
					this.SendPropertyChanging();
					this._TIME_INSERT = value;
					this.SendPropertyChanged("TIME_INSERT");
					this.OnTIME_INSERTChanged();
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
