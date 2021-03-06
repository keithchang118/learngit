﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Vars
	/// </summary>
	public partial class Vars
	{
		public Vars()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Var_Id", "Vars"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Var_Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Vars");
			strSql.Append(" where Var_Id=@Var_Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Var_Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Var_Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Vars model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Vars(");
			strSql.Append("Name,Type,var1,var2,var3)");
			strSql.Append(" values (");
			strSql.Append("@Name,@Type,@var1,@var2,@var3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@var1", SqlDbType.NVarChar,50),
					new SqlParameter("@var2", SqlDbType.NVarChar,50),
					new SqlParameter("@var3", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Name;
			parameters[1].Value = model.Type;
			parameters[2].Value = model.var1;
			parameters[3].Value = model.var2;
			parameters[4].Value = model.var3;

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
		public bool Update(Maticsoft.Model.Vars model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Vars set ");
			strSql.Append("Name=@Name,");
			strSql.Append("Type=@Type,");
			strSql.Append("var1=@var1,");
			strSql.Append("var2=@var2,");
			strSql.Append("var3=@var3");
			strSql.Append(" where Var_Id=@Var_Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@var1", SqlDbType.NVarChar,50),
					new SqlParameter("@var2", SqlDbType.NVarChar,50),
					new SqlParameter("@var3", SqlDbType.NVarChar,50),
					new SqlParameter("@Var_Id", SqlDbType.Int,4)};
			parameters[0].Value = model.Name;
			parameters[1].Value = model.Type;
			parameters[2].Value = model.var1;
			parameters[3].Value = model.var2;
			parameters[4].Value = model.var3;
			parameters[5].Value = model.Var_Id;

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
		public bool Delete(int Var_Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Vars ");
			strSql.Append(" where Var_Id=@Var_Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Var_Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Var_Id;

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
		public bool DeleteList(string Var_Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Vars ");
			strSql.Append(" where Var_Id in ("+Var_Idlist + ")  ");
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
		public Maticsoft.Model.Vars GetModel(int Var_Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Var_Id,Name,Type,var1,var2,var3 from Vars ");
			strSql.Append(" where Var_Id=@Var_Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Var_Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Var_Id;

			Maticsoft.Model.Vars model=new Maticsoft.Model.Vars();
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
		public Maticsoft.Model.Vars DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Vars model=new Maticsoft.Model.Vars();
			if (row != null)
			{
				if(row["Var_Id"]!=null && row["Var_Id"].ToString()!="")
				{
					model.Var_Id=int.Parse(row["Var_Id"].ToString());
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Type"]!=null)
				{
					model.Type=row["Type"].ToString();
				}
				if(row["var1"]!=null)
				{
					model.var1=row["var1"].ToString();
				}
				if(row["var2"]!=null)
				{
					model.var2=row["var2"].ToString();
				}
				if(row["var3"]!=null)
				{
					model.var3=row["var3"].ToString();
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
			strSql.Append("select Var_Id,Name,Type,var1,var2,var3 ");
			strSql.Append(" FROM Vars ");
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
			strSql.Append(" Var_Id,Name,Type,var1,var2,var3 ");
			strSql.Append(" FROM Vars ");
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
			strSql.Append("select count(1) FROM Vars ");
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
				strSql.Append("order by T.Var_Id desc");
			}
			strSql.Append(")AS Row, T.*  from Vars T ");
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
			parameters[0].Value = "Vars";
			parameters[1].Value = "Var_Id";
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

