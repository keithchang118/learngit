using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// AlarmData:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AlarmData
	{
		public AlarmData()
		{}
		#region Model
		private int _alarmdata_id;
		private string _location;
		private string _forecastresults;
		private DateTime _starttime;
		private int _alarmlevel;
		private DateTime? _endtime;
		private string _handleresult;
		/// <summary>
		/// 
		/// </summary>
		public int AlarmData_Id
		{
			set{ _alarmdata_id=value;}
			get{return _alarmdata_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Location
		{
			set{ _location=value;}
			get{return _location;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ForecastResults
		{
			set{ _forecastresults=value;}
			get{return _forecastresults;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime StartTime
		{
			set{ _starttime=value;}
			get{return _starttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AlarmLevel
		{
			set{ _alarmlevel=value;}
			get{return _alarmlevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EndTime
		{
			set{ _endtime=value;}
			get{return _endtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HandleResult
		{
			set{ _handleresult=value;}
			get{return _handleresult;}
		}
		#endregion Model

	}
}

