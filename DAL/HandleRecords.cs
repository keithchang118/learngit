using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:HandleRecords
	/// </summary>
	public partial class HandleRecords
	{
		public HandleRecords()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("HandleRecord_Id", "HandleRecords"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int HandleRecord_Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from HandleRecords");
			strSql.Append(" where HandleRecord_Id=@HandleRecord_Id");
			SqlParameter[] parameters = {
					new SqlParameter("@HandleRecord_Id", SqlDbType.Int,4)
			};
			parameters[0].Value = HandleRecord_Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.HandleRecords model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into HandleRecords(");
			strSql.Append("AlarmLevel,RecordContent,EmployeeName,DeptName,RecordTime,HandleItemsId,IsCompleted)");
			strSql.Append(" values (");
			strSql.Append("@AlarmLevel,@RecordContent,@EmployeeName,@DeptName,@RecordTime,@HandleItemsId,@IsCompleted)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@AlarmLevel", SqlDbType.Int,4),
					new SqlParameter("@RecordContent", SqlDbType.NVarChar,-1),
					new SqlParameter("@EmployeeName", SqlDbType.NVarChar,50),
					new SqlParameter("@DeptName", SqlDbType.NVarChar,50),
					new SqlParameter("@RecordTime", SqlDbType.DateTime),
					new SqlParameter("@HandleItemsId", SqlDbType.Int,4),
					new SqlParameter("@IsCompleted", SqlDbType.Bit,1)};
			parameters[0].Value = model.AlarmLevel;
			parameters[1].Value = model.RecordContent;
			parameters[2].Value = model.EmployeeName;
			parameters[3].Value = model.DeptName;
			parameters[4].Value = model.RecordTime;
			parameters[5].Value = model.HandleItemsId;
			parameters[6].Value = model.IsCompleted;

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
		public bool Update(Maticsoft.Model.HandleRecords model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update HandleRecords set ");
			strSql.Append("AlarmLevel=@AlarmLevel,");
			strSql.Append("RecordContent=@RecordContent,");
			strSql.Append("EmployeeName=@EmployeeName,");
			strSql.Append("DeptName=@DeptName,");
			strSql.Append("RecordTime=@RecordTime,");
			strSql.Append("HandleItemsId=@HandleItemsId,");
			strSql.Append("IsCompleted=@IsCompleted");
			strSql.Append(" where HandleRecord_Id=@HandleRecord_Id");
			SqlParameter[] parameters = {
					new SqlParameter("@AlarmLevel", SqlDbType.Int,4),
					new SqlParameter("@RecordContent", SqlDbType.NVarChar,-1),
					new SqlParameter("@EmployeeName", SqlDbType.NVarChar,50),
					new SqlParameter("@DeptName", SqlDbType.NVarChar,50),
					new SqlParameter("@RecordTime", SqlDbType.DateTime),
					new SqlParameter("@HandleItemsId", SqlDbType.Int,4),
					new SqlParameter("@IsCompleted", SqlDbType.Bit,1),
					new SqlParameter("@HandleRecord_Id", SqlDbType.Int,4)};
			parameters[0].Value = model.AlarmLevel;
			parameters[1].Value = model.RecordContent;
			parameters[2].Value = model.EmployeeName;
			parameters[3].Value = model.DeptName;
			parameters[4].Value = model.RecordTime;
			parameters[5].Value = model.HandleItemsId;
			parameters[6].Value = model.IsCompleted;
			parameters[7].Value = model.HandleRecord_Id;

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
		public bool Delete(int HandleRecord_Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from HandleRecords ");
			strSql.Append(" where HandleRecord_Id=@HandleRecord_Id");
			SqlParameter[] parameters = {
					new SqlParameter("@HandleRecord_Id", SqlDbType.Int,4)
			};
			parameters[0].Value = HandleRecord_Id;

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
		public bool DeleteList(string HandleRecord_Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from HandleRecords ");
			strSql.Append(" where HandleRecord_Id in ("+HandleRecord_Idlist + ")  ");
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
		public Maticsoft.Model.HandleRecords GetModel(int HandleRecord_Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 HandleRecord_Id,AlarmLevel,RecordContent,EmployeeName,DeptName,RecordTime,HandleItemsId,IsCompleted from HandleRecords ");
			strSql.Append(" where HandleRecord_Id=@HandleRecord_Id");
			SqlParameter[] parameters = {
					new SqlParameter("@HandleRecord_Id", SqlDbType.Int,4)
			};
			parameters[0].Value = HandleRecord_Id;

			Maticsoft.Model.HandleRecords model=new Maticsoft.Model.HandleRecords();
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
		public Maticsoft.Model.HandleRecords DataRowToModel(DataRow row)
		{
			Maticsoft.Model.HandleRecords model=new Maticsoft.Model.HandleRecords();
			if (row != null)
			{
				if(row["HandleRecord_Id"]!=null && row["HandleRecord_Id"].ToString()!="")
				{
					model.HandleRecord_Id=int.Parse(row["HandleRecord_Id"].ToString());
				}
				if(row["AlarmLevel"]!=null && row["AlarmLevel"].ToString()!="")
				{
					model.AlarmLevel=int.Parse(row["AlarmLevel"].ToString());
				}
				if(row["RecordContent"]!=null)
				{
					model.RecordContent=row["RecordContent"].ToString();
				}
				if(row["EmployeeName"]!=null)
				{
					model.EmployeeName=row["EmployeeName"].ToString();
				}
				if(row["DeptName"]!=null)
				{
					model.DeptName=row["DeptName"].ToString();
				}
				if(row["RecordTime"]!=null && row["RecordTime"].ToString()!="")
				{
					model.RecordTime=DateTime.Parse(row["RecordTime"].ToString());
				}
				if(row["HandleItemsId"]!=null && row["HandleItemsId"].ToString()!="")
				{
					model.HandleItemsId=int.Parse(row["HandleItemsId"].ToString());
				}
				if(row["IsCompleted"]!=null && row["IsCompleted"].ToString()!="")
				{
					if((row["IsCompleted"].ToString()=="1")||(row["IsCompleted"].ToString().ToLower()=="true"))
					{
						model.IsCompleted=true;
					}
					else
					{
						model.IsCompleted=false;
					}
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
			strSql.Append("select HandleRecord_Id,AlarmLevel,RecordContent,EmployeeName,DeptName,RecordTime,HandleItemsId,IsCompleted ");
			strSql.Append(" FROM HandleRecords ");
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
			strSql.Append(" HandleRecord_Id,AlarmLevel,RecordContent,EmployeeName,DeptName,RecordTime,HandleItemsId,IsCompleted ");
			strSql.Append(" FROM HandleRecords ");
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
			strSql.Append("select count(1) FROM HandleRecords ");
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
				strSql.Append("order by T.HandleRecord_Id desc");
			}
			strSql.Append(")AS Row, T.*  from HandleRecords T ");
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
			parameters[0].Value = "HandleRecords";
			parameters[1].Value = "HandleRecord_Id";
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

