using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:AlarmData
	/// </summary>
	public partial class AlarmData
	{
		public AlarmData()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("AlarmData_Id", "AlarmData"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AlarmData_Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from AlarmData");
			strSql.Append(" where AlarmData_Id=@AlarmData_Id");
			SqlParameter[] parameters = {
					new SqlParameter("@AlarmData_Id", SqlDbType.Int,4)
			};
			parameters[0].Value = AlarmData_Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.AlarmData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into AlarmData(");
			strSql.Append("Location,ForecastResults,StartTime,AlarmLevel,EndTime,HandleResult)");
			strSql.Append(" values (");
			strSql.Append("@Location,@ForecastResults,@StartTime,@AlarmLevel,@EndTime,@HandleResult)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Location", SqlDbType.NVarChar,50),
					new SqlParameter("@ForecastResults", SqlDbType.NVarChar,50),
					new SqlParameter("@StartTime", SqlDbType.DateTime),
					new SqlParameter("@AlarmLevel", SqlDbType.Int,4),
					new SqlParameter("@EndTime", SqlDbType.DateTime),
					new SqlParameter("@HandleResult", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Location;
			parameters[1].Value = model.ForecastResults;
			parameters[2].Value = model.StartTime;
			parameters[3].Value = model.AlarmLevel;
			parameters[4].Value = model.EndTime;
			parameters[5].Value = model.HandleResult;

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
		public bool Update(Maticsoft.Model.AlarmData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update AlarmData set ");
			strSql.Append("Location=@Location,");
			strSql.Append("ForecastResults=@ForecastResults,");
			strSql.Append("StartTime=@StartTime,");
			strSql.Append("AlarmLevel=@AlarmLevel,");
			strSql.Append("EndTime=@EndTime,");
			strSql.Append("HandleResult=@HandleResult");
			strSql.Append(" where AlarmData_Id=@AlarmData_Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Location", SqlDbType.NVarChar,50),
					new SqlParameter("@ForecastResults", SqlDbType.NVarChar,50),
					new SqlParameter("@StartTime", SqlDbType.DateTime),
					new SqlParameter("@AlarmLevel", SqlDbType.Int,4),
					new SqlParameter("@EndTime", SqlDbType.DateTime),
					new SqlParameter("@HandleResult", SqlDbType.NVarChar,50),
					new SqlParameter("@AlarmData_Id", SqlDbType.Int,4)};
			parameters[0].Value = model.Location;
			parameters[1].Value = model.ForecastResults;
			parameters[2].Value = model.StartTime;
			parameters[3].Value = model.AlarmLevel;
			parameters[4].Value = model.EndTime;
			parameters[5].Value = model.HandleResult;
			parameters[6].Value = model.AlarmData_Id;

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
		public bool Delete(int AlarmData_Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AlarmData ");
			strSql.Append(" where AlarmData_Id=@AlarmData_Id");
			SqlParameter[] parameters = {
					new SqlParameter("@AlarmData_Id", SqlDbType.Int,4)
			};
			parameters[0].Value = AlarmData_Id;

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
		public bool DeleteList(string AlarmData_Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AlarmData ");
			strSql.Append(" where AlarmData_Id in ("+AlarmData_Idlist + ")  ");
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
		public Maticsoft.Model.AlarmData GetModel(int AlarmData_Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 AlarmData_Id,Location,ForecastResults,StartTime,AlarmLevel,EndTime,HandleResult from AlarmData ");
			strSql.Append(" where AlarmData_Id=@AlarmData_Id");
			SqlParameter[] parameters = {
					new SqlParameter("@AlarmData_Id", SqlDbType.Int,4)
			};
			parameters[0].Value = AlarmData_Id;

			Maticsoft.Model.AlarmData model=new Maticsoft.Model.AlarmData();
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
		public Maticsoft.Model.AlarmData DataRowToModel(DataRow row)
		{
			Maticsoft.Model.AlarmData model=new Maticsoft.Model.AlarmData();
			if (row != null)
			{
				if(row["AlarmData_Id"]!=null && row["AlarmData_Id"].ToString()!="")
				{
					model.AlarmData_Id=int.Parse(row["AlarmData_Id"].ToString());
				}
				if(row["Location"]!=null)
				{
					model.Location=row["Location"].ToString();
				}
				if(row["ForecastResults"]!=null)
				{
					model.ForecastResults=row["ForecastResults"].ToString();
				}
				if(row["StartTime"]!=null && row["StartTime"].ToString()!="")
				{
					model.StartTime=DateTime.Parse(row["StartTime"].ToString());
				}
				if(row["AlarmLevel"]!=null && row["AlarmLevel"].ToString()!="")
				{
					model.AlarmLevel=int.Parse(row["AlarmLevel"].ToString());
				}
				if(row["EndTime"]!=null && row["EndTime"].ToString()!="")
				{
					model.EndTime=DateTime.Parse(row["EndTime"].ToString());
				}
				if(row["HandleResult"]!=null)
				{
					model.HandleResult=row["HandleResult"].ToString();
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
			strSql.Append("select AlarmData_Id,Location,ForecastResults,StartTime,AlarmLevel,EndTime,HandleResult ");
			strSql.Append(" FROM AlarmData ");
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
			strSql.Append(" AlarmData_Id,Location,ForecastResults,StartTime,AlarmLevel,EndTime,HandleResult ");
			strSql.Append(" FROM AlarmData ");
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
			strSql.Append("select count(1) FROM AlarmData ");
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
				strSql.Append("order by T.AlarmData_Id desc");
			}
			strSql.Append(")AS Row, T.*  from AlarmData T ");
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
			parameters[0].Value = "AlarmData";
			parameters[1].Value = "AlarmData_Id";
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

