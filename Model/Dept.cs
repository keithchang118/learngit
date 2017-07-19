using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Dept:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Dept
	{
		public Dept()
		{}
		#region Model
		private int _dept_id;
		private string _name;
		private string _memo;
		private int _depttypeid;
		/// <summary>
		/// 
		/// </summary>
		public int Dept_Id
		{
			set{ _dept_id=value;}
			get{return _dept_id;}
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
		public string Memo
		{
			set{ _memo=value;}
			get{return _memo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int DeptTypeId
		{
			set{ _depttypeid=value;}
			get{return _depttypeid;}
		}
		#endregion Model

	}
}

