//####################################### begin 郭林东 ##############################################
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class AppSettings
    {
        DAL.AppSettings dalAs;

        //判断数据库是否可以连接
        public bool checkConnection()
        {
            dalAs = new DAL.AppSettings();
            return dalAs.checkConnection();
        }
    }
}
//####################################### end 郭林东 ##############################################