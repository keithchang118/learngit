using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// HandleRecords:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class HandleRecords
	{
		public HandleRecords()
		{}
		#region Model
		private int _handlerecord_id;
		private int _alarmlevel;
		private string _recordcontent;
		private string _employeename;
		private string _deptname;
		private DateTime _recordtime;
		private int _handleitemsid;
		private bool _iscompleted;
		/// <summary>
		/// 
		/// </summary>
		public int HandleRecord_Id
		{
			set{ _handlerecord_id=value;}
			get{return _handlerecord_id;}
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
		public string RecordContent
		{
			set{ _recordcontent=value;}
			get{return _recordcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EmployeeName
		{
			set{ _employeename=value;}
			get{return _employeename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeptName
		{
			set{ _deptname=value;}
			get{return _deptname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime RecordTime
		{
			set{ _recordtime=value;}
			get{return _recordtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int HandleItemsId
		{
			set{ _handleitemsid=value;}
			get{return _handleitemsid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsCompleted
		{
			set{ _iscompleted=value;}
			get{return _iscompleted;}
		}
		#endregion Model

	}
}

