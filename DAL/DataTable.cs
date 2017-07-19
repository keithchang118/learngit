using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:DataTable
	/// </summary>
	public partial class DataTable
	{
		public DataTable()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Data_Id", "DataTable"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Data_Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DataTable");
			strSql.Append(" where Data_Id=@Data_Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Data_Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Data_Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.DataTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DataTable(");
			strSql.Append("Device_Id,Var_Id,Data,Data_Time,Data_Max,Data_Min,Alarm,Memo)");
			strSql.Append(" values (");
			strSql.Append("@Device_Id,@Var_Id,@Data,@Data_Time,@Data_Max,@Data_Min,@Alarm,@Memo)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Device_Id", SqlDbType.Int,4),
					new SqlParameter("@Var_Id", SqlDbType.Int,4),
					new SqlParameter("@Data", SqlDbType.NVarChar,50),
					new SqlParameter("@Data_Time", SqlDbType.DateTime),
					new SqlParameter("@Data_Max", SqlDbType.NVarChar,50),
					new SqlParameter("@Data_Min", SqlDbType.NVarChar,50),
					new SqlParameter("@Alarm", SqlDbType.Bit,1),
					new SqlParameter("@Memo", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Device_Id;
			parameters[1].Value = model.Var_Id;
			parameters[2].Value = model.Data;
			parameters[3].Value = model.Data_Time;
			parameters[4].Value = model.Data_Max;
			parameters[5].Value = model.Data_Min;
			parameters[6].Value = model.Alarm;
			parameters[7].Value = model.Memo;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.DataTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DataTable set ");
			strSql.Append("Device_Id=@Device_Id,");
			strSql.Append("Var_Id=@Var_Id,");
			strSql.Append("Data=@Data,");
			strSql.Append("Data_Time=@Data_Time,");
			strSql.Append("Data_Max=@Data_Max,");
			strSql.Append("Data_Min=@Data_Min,");
			strSql.Append("Alarm=@Alarm,");
			strSql.Append("Memo=@Memo");
			strSql.Append(" where Data_Id=@Data_Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Device_Id", SqlDbType.Int,4),
					new SqlParameter("@Var_Id", SqlDbType.Int,4),
					new SqlParameter("@Data", SqlDbType.NVarChar,50),
					new SqlParameter("@Data_Time", SqlDbType.DateTime),
					new SqlParameter("@Data_Max", SqlDbType.NVarChar,50),
					new SqlParameter("@Data_Min", SqlDbType.NVarChar,50),
					new SqlParameter("@Alarm", SqlDbType.Bit,1),
					new SqlParameter("@Memo", SqlDbType.NVarChar,50),
					new SqlParameter("@Data_Id", SqlDbType.Int,4)};
			parameters[0].Value = model.Device_Id;
			parameters[1].Value = model.Var_Id;
			parameters[2].Value = model.Data;
			parameters[3].Value = model.Data_Time;
			parameters[4].Value = model.Data_Max;
			parameters[5].Value = model.Data_Min;
			parameters[6].Value = model.Alarm;
			parameters[7].Value = model.Memo;
			parameters[8].Value = model.Data_Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Data_Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DataTable ");
			strSql.Append(" where Data_Id=@Data_Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Data_Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Data_Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Data_Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DataTable ");
			strSql.Append(" where Data_Id in ("+Data_Idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.DataTable GetModel(int Data_Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Data_Id,Device_Id,Var_Id,Data,Data_Time,Data_Max,Data_Min,Alarm,Memo from DataTable ");
			strSql.Append(" where Data_Id=@Data_Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Data_Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Data_Id;

			Maticsoft.Model.DataTable model=new Maticsoft.Model.DataTable();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.DataTable DataRowToModel(DataRow row)
		{
			Maticsoft.Model.DataTable model=new Maticsoft.Model.DataTable();
			if (row != null)
			{
				if(row["Data_Id"]!=null && row["Data_Id"].ToString()!="")
				{
					model.Data_Id=int.Parse(row["Data_Id"].ToString());
				}
				if(row["Device_Id"]!=null && row["Device_Id"].ToString()!="")
				{
					model.Device_Id=int.Parse(row["Device_Id"].ToString());
				}
				if(row["Var_Id"]!=null && row["Var_Id"].ToString()!="")
				{
					model.Var_Id=int.Parse(row["Var_Id"].ToString());
				}
				if(row["Data"]!=null)
				{
					model.Data=row["Data"].ToString();
				}
				if(row["Data_Time"]!=null && row["Data_Time"].ToString()!="")
				{
					model.Data_Time=DateTime.Parse(row["Data_Time"].ToString());
				}
				if(row["Data_Max"]!=null)
				{
					model.Data_Max=row["Data_Max"].ToString();
				}
				if(row["Data_Min"]!=null)
				{
					model.Data_Min=row["Data_Min"].ToString();
				}
				if(row["Alarm"]!=null && row["Alarm"].ToString()!="")
				{
					if((row["Alarm"].ToString()=="1")||(row["Alarm"].ToString().ToLower()=="true"))
					{
						model.Alarm=true;
					}
					else
					{
						model.Alarm=false;
					}
				}
				if(row["Memo"]!=null)
				{
					model.Memo=row["Memo"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Data_Id,Device_Id,Var_Id,Data,Data_Time,Data_Max,Data_Min,Alarm,Memo ");
			strSql.Append(" FROM DataTable ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Data_Id,Device_Id,Var_Id,Data,Data_Time,Data_Max,Data_Min,Alarm,Memo ");
			strSql.Append(" FROM DataTable ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM DataTable ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Data_Id desc");
			}
			strSql.Append(")AS Row, T.*  from DataTable T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "DataTable";
			parameters[1].Value = "Data_Id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

