
using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace KiwiCrawler.DAL
{
	/// <summary>
	/// 数据访问类:Extractionconfig_kDal
	/// </summary>
	public partial class Extractionconfig_kDal
	{
		public Extractionconfig_kDal()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KiwiCrawler.Model.Extractionconfig_k model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into extractionconfig_k(");
			strSql.Append("kId,kUrl,kTitle,kPublishDateTime,kContent,kExtracionType,kAddressBusinessType,kKeywords,kPercent)");
			strSql.Append(" values (");
			strSql.Append("@kId,@kUrl,@kTitle,@kPublishDateTime,@kContent,@kExtracionType,@kAddressBusinessType,@kKeywords,@kPercent)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@kId", MySqlDbType.Int32,11),
					new MySqlParameter("@kUrl", MySqlDbType.Text),
					new MySqlParameter("@kTitle", MySqlDbType.Text),
					new MySqlParameter("@kPublishDateTime", MySqlDbType.Text),
					new MySqlParameter("@kContent", MySqlDbType.Text),
					new MySqlParameter("@kExtracionType", MySqlDbType.Text),
					new MySqlParameter("@kAddressBusinessType", MySqlDbType.Text),
					new MySqlParameter("@kKeywords", MySqlDbType.Text),
					new MySqlParameter("@kPercent", MySqlDbType.Float)};
			parameters[0].Value = model.kId;
			parameters[1].Value = model.kUrl;
			parameters[2].Value = model.kTitle;
			parameters[3].Value = model.kPublishDateTime;
			parameters[4].Value = model.kContent;
			parameters[5].Value = model.kExtracionType;
			parameters[6].Value = model.kAddressBusinessType;
			parameters[7].Value = model.kKeywords;
			parameters[8].Value = model.kPercent;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(KiwiCrawler.Model.Extractionconfig_k model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update extractionconfig_k set ");
			strSql.Append("kId=@kId,");
			strSql.Append("kUrl=@kUrl,");
			strSql.Append("kTitle=@kTitle,");
			strSql.Append("kPublishDateTime=@kPublishDateTime,");
			strSql.Append("kContent=@kContent,");
			strSql.Append("kExtracionType=@kExtracionType,");
			strSql.Append("kAddressBusinessType=@kAddressBusinessType,");
			strSql.Append("kKeywords=@kKeywords,");
			strSql.Append("kPercent=@kPercent");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@kId", MySqlDbType.Int32,11),
					new MySqlParameter("@kUrl", MySqlDbType.Text),
					new MySqlParameter("@kTitle", MySqlDbType.Text),
					new MySqlParameter("@kPublishDateTime", MySqlDbType.Text),
					new MySqlParameter("@kContent", MySqlDbType.Text),
					new MySqlParameter("@kExtracionType", MySqlDbType.Text),
					new MySqlParameter("@kAddressBusinessType", MySqlDbType.Text),
					new MySqlParameter("@kKeywords", MySqlDbType.Text),
					new MySqlParameter("@kPercent", MySqlDbType.Float)};
			parameters[0].Value = model.kId;
			parameters[1].Value = model.kUrl;
			parameters[2].Value = model.kTitle;
			parameters[3].Value = model.kPublishDateTime;
			parameters[4].Value = model.kContent;
			parameters[5].Value = model.kExtracionType;
			parameters[6].Value = model.kAddressBusinessType;
			parameters[7].Value = model.kKeywords;
			parameters[8].Value = model.kPercent;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from extractionconfig_k ");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
			};

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public KiwiCrawler.Model.Extractionconfig_k GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select kId,kUrl,kTitle,kPublishDateTime,kContent,kExtracionType,kAddressBusinessType,kKeywords,kPercent from extractionconfig_k ");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
			};

			KiwiCrawler.Model.Extractionconfig_k model=new KiwiCrawler.Model.Extractionconfig_k();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
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
		public KiwiCrawler.Model.Extractionconfig_k DataRowToModel(DataRow row)
		{
			KiwiCrawler.Model.Extractionconfig_k model=new KiwiCrawler.Model.Extractionconfig_k();
			if (row != null)
			{
				if(row["kId"]!=null && row["kId"].ToString()!="")
				{
					model.kId=int.Parse(row["kId"].ToString());
				}
				if(row["kUrl"]!=null)
				{
					model.kUrl=row["kUrl"].ToString();
				}
				if(row["kTitle"]!=null)
				{
					model.kTitle=row["kTitle"].ToString();
				}
				if(row["kPublishDateTime"]!=null)
				{
					model.kPublishDateTime=row["kPublishDateTime"].ToString();
				}
				if(row["kContent"]!=null)
				{
					model.kContent=row["kContent"].ToString();
				}
				if(row["kExtracionType"]!=null)
				{
					model.kExtracionType=row["kExtracionType"].ToString();
				}
				if(row["kAddressBusinessType"]!=null)
				{
					model.kAddressBusinessType=row["kAddressBusinessType"].ToString();
				}
				if(row["kKeywords"]!=null)
				{
					model.kKeywords=row["kKeywords"].ToString();
				}
				if(row["kPercent"]!=null && row["kPercent"].ToString()!="")
				{
					model.kPercent=decimal.Parse(row["kPercent"].ToString());
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
			strSql.Append("select kId,kUrl,kTitle,kPublishDateTime,kContent,kExtracionType,kAddressBusinessType,kKeywords,kPercent ");
			strSql.Append(" FROM extractionconfig_k ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM extractionconfig_k ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperMySQL.GetSingle(strSql.ToString());
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
				strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from extractionconfig_k T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "extractionconfig_k";
			parameters[1].Value = "";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

