using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// DeviceWorkingface:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DeviceWorkingface
	{
		public DeviceWorkingface()
		{}
		#region Model
		private int _id;
		private int _workingface_id;
		private int _device_id;
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
		public int Workingface_Id
		{
			set{ _workingface_id=value;}
			get{return _workingface_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Device_Id
		{
			set{ _device_id=value;}
			get{return _device_id;}
		}
		#endregion Model

	}
}

