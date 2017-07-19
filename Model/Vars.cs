using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Vars:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Vars
	{
		public Vars()
		{}
		#region Model
		private int _var_id;
		private string _name;
		private string _type;
		private string _var1;
		private string _var2;
		private string _var3;
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
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string var1
		{
			set{ _var1=value;}
			get{return _var1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string var2
		{
			set{ _var2=value;}
			get{return _var2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string var3
		{
			set{ _var3=value;}
			get{return _var3;}
		}
		#endregion Model

	}
}

