using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Workingface
	/// </summary>
	public partial class Workingface
	{
		public Workingface()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Workingface_Id", "Workingface"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Workingface_Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Workingface");
			strSql.Append(" where Workingface_Id=@Workingface_Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Workingface_Id", SqlDbType.Int,4)			};
			parameters[0].Value = Workingface_Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.Workingface model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Workingface(");
			strSql.Append("Workingface_Id,Name,Number,Memo)");
			strSql.Append(" values (");
			strSql.Append("@Workingface_Id,@Name,@Number,@Memo)");
			SqlParameter[] parameters = {
					new SqlParameter("@Workingface_Id", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Number", SqlDbType.NVarChar,50),
					new SqlParameter("@Memo", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Workingface_Id;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.Number;
			parameters[3].Value = model.Memo;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.Workingface model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Workingface set ");
			strSql.Append("Name=@Name,");
			strSql.Append("Number=@Number,");
			strSql.Append("Memo=@Memo");
			strSql.Append(" where Workingface_Id=@Workingface_Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Number", SqlDbType.NVarChar,50),
					new SqlParameter("@Memo", SqlDbType.NVarChar,50),
					new SqlParameter("@Workingface_Id", SqlDbType.Int,4)};
			parameters[0].Value = model.Name;
			parameters[1].Value = model.Number;
			parameters[2].Value = model.Memo;
			parameters[3].Value = model.Workingface_Id;

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
		public bool Delete(int Workingface_Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Workingface ");
			strSql.Append(" where Workingface_Id=@Workingface_Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Workingface_Id", SqlDbType.Int,4)			};
			parameters[0].Value = Workingface_Id;

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
		public bool DeleteList(string Workingface_Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Workingface ");
			strSql.Append(" where Workingface_Id in ("+Workingface_Idlist + ")  ");
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
		public Maticsoft.Model.Workingface GetModel(int Workingface_Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Workingface_Id,Name,Number,Memo from Workingface ");
			strSql.Append(" where Workingface_Id=@Workingface_Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Workingface_Id", SqlDbType.Int,4)			};
			parameters[0].Value = Workingface_Id;

			Maticsoft.Model.Workingface model=new Maticsoft.Model.Workingface();
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
		public Maticsoft.Model.Workingface DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Workingface model=new Maticsoft.Model.Workingface();
			if (row != null)
			{
				if(row["Workingface_Id"]!=null && row["Workingface_Id"].ToString()!="")
				{
					model.Workingface_Id=int.Parse(row["Workingface_Id"].ToString());
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Number"]!=null)
				{
					model.Number=row["Number"].ToString();
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
			strSql.Append("select Workingface_Id,Name,Number,Memo ");
			strSql.Append(" FROM Workingface ");
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
			strSql.Append(" Workingface_Id,Name,Number,Memo ");
			strSql.Append(" FROM Workingface ");
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
			strSql.Append("select count(1) FROM Workingface ");
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
				strSql.Append("order by T.Workingface_Id desc");
			}
			strSql.Append(")AS Row, T.*  from Workingface T ");
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
			parameters[0].Value = "Workingface";
			parameters[1].Value = "Workingface_Id";
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

