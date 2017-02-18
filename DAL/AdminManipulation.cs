//####################################### begin 郭展光 ##############################################
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class AdminManipulation
    {


        public AdminManipulation()
        {

        }

        //判断用户名，密码是否正确
        public bool Login(string userName, string userPass)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [admin]");
            strSql.Append(" where a_name=@UserName and a_pass=@UserPass");
            SqlParameter[] parameters ={ 
                                           new SqlParameter ("@UserName",SqlDbType.VarChar,10), 
                                           new SqlParameter ("@UserPass",SqlDbType.VarChar ,50)
                                       };
            parameters[0].Value = userName;
            parameters[1].Value = userPass;

            int n = Convert.ToInt32(DbHelper.ExecuteScalar(strSql.ToString(), CommandType.Text, parameters));
            if (n == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //查询所有用户
        public DataTable getAllAdmin()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("select * from admin");
            Console.WriteLine(sb.ToString());
            return DbHelper.ExecuteDataTable(sb.ToString());
        }
        //根据管理员编号，获取管理员信息
        public Model.Admin GetModel(string Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 a_id,a_name,a_pass ");
            strSql.Append("from admin where a_id=@Id ");
            SqlParameter[] parameters = { new SqlParameter("@Id", SqlDbType.Int, 4) };
            parameters[0].Value = Id;
            Model.Admin model = new Model.Admin();
            DataTable dt = DbHelper.ExecuteDataTable(strSql.ToString(), CommandType.Text, parameters);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["a_id"] != null && dt.Rows[0]["a_id"].ToString() != "")
                {
                    model.Id = dt.Rows[0]["a_id"].ToString();
                }
                if (dt.Rows[0]["a_name"] != null && dt.Rows[0]["a_name"].ToString() != "")
                {
                    model.Name = dt.Rows[0]["a_name"].ToString();
                }
                if (dt.Rows[0]["a_pass"] != null && dt.Rows[0]["a_pass"].ToString() != "")
                {
                    model.Pass = dt.Rows[0]["a_pass"].ToString();
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        //（普通管理员）根据用户名更新
        public bool Update(Model.Admin model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [admin] set");
            strSql.Append(" a_pass=@Password");
            strSql.Append(" where a_name=@UserName ");
            SqlParameter[] parameters ={ 
                                           new SqlParameter ("@Password",SqlDbType .VarChar,50), 
                                           new SqlParameter ("@UserName",SqlDbType .VarChar ,50)
                                       };
            parameters[0].Value = model.Pass;
            parameters[1].Value = model.Name;
            int rows = DbHelper.ExecuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
            if (rows == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //增加账号
        public bool insert(Model.Admin admin)
        {

            if (admin.Name == null || admin.Name == "" || admin.Pass == null || admin.Pass == "")
            {
                Console.WriteLine("用户名或密码为空");
                return false;
            }

            string name = admin.Name;
            string pass = Common.Utils.encrypt(admin.Pass);

            string cmdQueryText = "select * from admin where a_name='" + name + "'";



            Object obj = DbHelper.ExecuteScalar(cmdQueryText);
            if (obj != null)
            {
                Console.WriteLine("用户名已存在");
                return false;
            }
            else
            {
               string  cmdText = "insert into admin(a_name,a_pass) values('" + name + "','" + pass + "')";

               int i = DbHelper.ExecuteNonQuery(cmdText);
                if (i == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //删除账号
        public bool delete(string id)
        {

            string cmdQueryText = "select * from admin where a_id='" + id + "'";

            Object obj = DbHelper.ExecuteScalar(cmdQueryText);
            if (obj == null)
            {
                Console.WriteLine("用户不存在");
                return false;
            }
            else
            {
               string cmdText = "delete from admin where a_id='" + id + "'";

               int i = DbHelper.ExecuteNonQuery(cmdText);
                if (i == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        //(超级管理员)更新账号
        public bool update(Model.Admin admin)
        {
            if (admin.Id == null || admin.Id == "" || admin.Name == null || admin.Name == "" || admin.Pass == null || admin.Pass == "")
            {
                Console.WriteLine("ID或用户名或密码为空");
                return false;
            }

            string id = admin.Id;
            string name = admin.Name;
            string pass = admin.Pass;
            string cmdQueryText = "select * from admin where a_id='" + id + "'";

            Object obj = DbHelper.ExecuteScalar(cmdQueryText);
            if (obj == null)
            {
                Console.WriteLine("用户不存在");
                return false;
            }
            else
            {
                string cmdText = "update admin set a_name='" + name + "',a_pass='" + pass + "' where a_id='" + id + "'";

                int i = DbHelper.ExecuteNonQuery(cmdText);
                if (i == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

    }
}
//####################################### end 郭展光 ##############################################