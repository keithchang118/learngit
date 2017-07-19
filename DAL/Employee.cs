using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Employee
	/// </summary>
	public partial class Employee
	{
		public Employee()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Employee_Id", "Employee"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Employee_Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Employee");
			strSql.Append(" where Employee_Id=@Employee_Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Employee_Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Employee_Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Employee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Employee(");
			strSql.Append("Name,CardID,CellPhone,DeptId)");
			strSql.Append(" values (");
			strSql.Append("@Name,@CardID,@CellPhone,@DeptId)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@CardID", SqlDbType.NVarChar,50),
					new SqlParameter("@CellPhone", SqlDbType.NVarChar,50),
					new SqlParameter("@DeptId", SqlDbType.Int,4)};
			parameters[0].Value = model.Name;
			parameters[1].Value = model.CardID;
			parameters[2].Value = model.CellPhone;
			parameters[3].Value = model.DeptId;

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
		public bool Update(Maticsoft.Model.Employee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Employee set ");
			strSql.Append("Name=@Name,");
			strSql.Append("CardID=@CardID,");
			strSql.Append("CellPhone=@CellPhone,");
			strSql.Append("DeptId=@DeptId");
			strSql.Append(" where Employee_Id=@Employee_Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@CardID", SqlDbType.NVarChar,50),
					new SqlParameter("@CellPhone", SqlDbType.NVarChar,50),
					new SqlParameter("@DeptId", SqlDbType.Int,4),
					new SqlParameter("@Employee_Id", SqlDbType.Int,4)};
			parameters[0].Value = model.Name;
			parameters[1].Value = model.CardID;
			parameters[2].Value = model.CellPhone;
			parameters[3].Value = model.DeptId;
			parameters[4].Value = model.Employee_Id;

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
		public bool Delete(int Employee_Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Employee ");
			strSql.Append(" where Employee_Id=@Employee_Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Employee_Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Employee_Id;

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
		public bool DeleteList(string Employee_Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Employee ");
			strSql.Append(" where Employee_Id in ("+Employee_Idlist + ")  ");
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
		public Maticsoft.Model.Employee GetModel(int Employee_Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Employee_Id,Name,CardID,CellPhone,DeptId from Employee ");
			strSql.Append(" where Employee_Id=@Employee_Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Employee_Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Employee_Id;

			Maticsoft.Model.Employee model=new Maticsoft.Model.Employee();
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
		public Maticsoft.Model.Employee DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Employee model=new Maticsoft.Model.Employee();
			if (row != null)
			{
				if(row["Employee_Id"]!=null && row["Employee_Id"].ToString()!="")
				{
					model.Employee_Id=int.Parse(row["Employee_Id"].ToString());
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["CardID"]!=null)
				{
					model.CardID=row["CardID"].ToString();
				}
				if(row["CellPhone"]!=null)
				{
					model.CellPhone=row["CellPhone"].ToString();
				}
				if(row["DeptId"]!=null && row["DeptId"].ToString()!="")
				{
					model.DeptId=int.Parse(row["DeptId"].ToString());
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
			strSql.Append("select Employee_Id,Name,CardID,CellPhone,DeptId ");
			strSql.Append(" FROM Employee ");
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
			strSql.Append(" Employee_Id,Name,CardID,CellPhone,DeptId ");
			strSql.Append(" FROM Employee ");
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
			strSql.Append("select count(1) FROM Employee ");
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
				strSql.Append("order by T.Employee_Id desc");
			}
			strSql.Append(")AS Row, T.*  from Employee T ");
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
			parameters[0].Value = "Employee";
			parameters[1].Value = "Employee_Id";
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

