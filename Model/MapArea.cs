using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// MapArea:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MapArea
	{
		public MapArea()
		{}
		#region Model
		private int _id;
		private string _name;
		private int _type;
		private string _memo;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
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
		public int Type
		{
			set{ _type=value;}
			get{return _type;}
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

