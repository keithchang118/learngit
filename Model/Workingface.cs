using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Workingface:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Workingface
	{
		public Workingface()
		{}
		#region Model
		private int _workingface_id;
		private string _name;
		private string _number;
		private string _memo;
		/// <summary>
		/// 
		/// </summary>
		public int Workingface_Id
		{
			set{ _workingface_id=value;}
			get{return _workingface_id;}
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
		public string Number
		{
			set{ _number=value;}
			get{return _number;}
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

