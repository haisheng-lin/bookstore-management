//####################################### begin 郭林东 ##############################################
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class AppSettings
    {

        //判断数据库是否可以连接
        public bool checkConnection()
        {
            return DbHelper.checkConnection();
        }
    }
}
//####################################### end 郭林东 ##############################################