using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Device:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Device
	{
		public Device()
		{}
		#region Model
		private int _device_id;
		private string _name;
		private string _type;
		private string _memo;
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
		public string Memo
		{
			set{ _memo=value;}
			get{return _memo;}
		}
		#endregion Model

	}
}

