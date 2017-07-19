using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Employee:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Employee
	{
		public Employee()
		{}
		#region Model
		private int _employee_id;
		private string _name;
		private string _cardid;
		private string _cellphone;
		private int _deptid;
		/// <summary>
		/// 
		/// </summary>
		public int Employee_Id
		{
			set{ _employee_id=value;}
			get{return _employee_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CardID
		{
			set{ _cardid=value;}
			get{return _cardid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CellPhone
		{
			set{ _cellphone=value;}
			get{return _cellphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int DeptId
		{
			set{ _deptid=value;}
			get{return _deptid;}
		}
		#endregion Model

	}
}

