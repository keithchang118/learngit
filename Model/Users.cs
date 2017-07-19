using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Users:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Users
	{
		public Users()
		{}
		#region Model
		private int _user_id;
		private string _name;
		private string _password;
		private string _priority;
		private string _memo;
		/// <summary>
		/// 
		/// </summary>
		public int User_Id
		{
			set{ _user_id=value;}
			get{return _user_id;}
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
		public string Password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Priority
		{
			set{ _priority=value;}
			get{return _priority;}
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

