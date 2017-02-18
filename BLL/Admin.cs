//####################################### begin 郭展光 ##############################################
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace BLL
{
    public class Admin
    {
        DAL.AdminManipulation admins = new DAL.AdminManipulation();

        //登陆
        public bool Login(string userName, string userPass)
        {
            return admins.Login(userName, Common.Utils.encrypt(userPass));
        }

        //（超级管理员）获得所有管理员信息
        public DataTable getAllAdmin()
        {
            return admins.getAllAdmin();
        }

        //（超级管理员）根据编号获得管理员信息
        public Model.Admin getModel(string id)
        {
            return admins.GetModel(id);
        }

        //（超级管理员）增加管理员
        public bool insert(Model.Admin admin)
        {
            return admins.insert(admin);
        }

        //（超级管理员)更新管理员信息
        public bool update(Model.Admin admin)
        {
            admin.Pass = Common.Utils.encrypt(admin.Pass);
            return admins.update(admin);
        }

        //(普通管理员)依据用户名更新
        public bool Update(Model.Admin model)
        {
            model.Pass = Common.Utils.encrypt(model.Pass);
            return admins.Update(model);
        }
        //(超级管理员)删除管理员
        public bool delete(string id)
        {
            return admins.delete(id);
        }
    }
}
//####################################### end 郭展光 ##############################################