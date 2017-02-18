//####################################### begin 郭林东 ##############################################
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class BookNotify
    {
        private DAL.BookNotify bn;


        //得到提醒库存量少于10的书本的数目
        public int getWarningNumber()
        {

            bn = new DAL.BookNotify();
            return bn.getWarningNumber();

        }


        //返回提醒库存量少于10的书本的DataTable
        public DataTable getWarningRecords()
        {

            bn = new DAL.BookNotify();

            return bn.getWarningRecords();

        }

        //返回总库存
        public int getTotalInventory()
        {

            bn = new DAL.BookNotify();
            return bn.getTotalInventory();

        }

        //返回总资产
        public double getTotalAsset()
        {

            bn = new DAL.BookNotify();
            return bn.getTotalAsset();

        }



    }
}
//####################################### end 郭林东 ##############################################