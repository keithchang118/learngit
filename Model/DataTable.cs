using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// DataTable:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DataTable
	{
		public DataTable()
		{}
		#region Model
		private int _data_id;
		private int _device_id;
		private int _var_id;
		private string _data;
		private DateTime _data_time;
		private string _data_max;
		private string _data_min;
		private bool _alarm;
		private string _memo;
		/// <summary>
		/// 
		/// </summary>
		public int Data_Id
		{
			set{ _data_id=value;}
			get{return _data_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Device_Id
		{
			set{ _device_id=value;}
			get{return _device_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Var_Id
		{
			set{ _var_id=value;}
			get{return _var_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Data
		{
			set{ _data=value;}
			get{return _data;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime Data_Time
		{
			set{ _data_time=value;}
			get{return _data_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Data_Max
		{
			set{ _data_max=value;}
			get{return _data_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Data_Min
		{
			set{ _data_min=value;}
			get{return _data_min;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool Alarm
		{
			set{ _alarm=value;}
			get{return _alarm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Memo
		{
			set{ _memo=value;}
			get{return _memo;}
		}
		#endregion Model

	}
}

