//####################################### begin 郭林东 ##############################################
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class BookNotify
    {

        //得到提醒库存量少于10的书本的数目
        public int getWarningNumber()
        {
            string str = "select count(b_id) from book where b_inventory < 10";
            object obj=DbHelper.ExecuteScalar(str);
            return System.Convert.ToInt32(obj.ToString());

        }


        //返回提醒库存量少于10的书本的DataTable
        public DataTable getWarningRecords()
        {
            string str = "select * from book where b_inventory < 10";
            return DbHelper.ExecuteDataTable(str);

        }


        //返回总库存
        public int getTotalInventory()
        {
            string str = "select sum(b_inventory) from book";

            object obj = DbHelper.ExecuteScalar(str);
            return System.Convert.ToInt32(obj.ToString());
        }


        //返回总资产
        public double getTotalAsset()
        {
            string str = "select sum(b_inventory * b_price) from book";

            object obj = DbHelper.ExecuteScalar(str);
            return System.Convert.ToDouble(obj.ToString());
        }

    }
}
//####################################### end 郭林东 ##############################################