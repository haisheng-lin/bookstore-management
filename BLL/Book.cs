//####################################### begin 郭林东 ##############################################
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    
    public class Book
    {
        private DAL.BookManipulation bm;

        public Book()
        {
            bm = new DAL.BookManipulation();
        }

        //增加
        public int insert(Model.Book book)
        {

            return bm.insert(book);
        }

        //根据id删除
        public int delete(string id)
        {
            return bm.delete(id);
        }

        //根据id修改
        public int update(Model.Book book)
        {

            return bm.update(book);
        }

        //根据id查询
        public SqlDataReader queryById(string id)
        {
            return bm.queryById(id) ;

        }

        //全字段模糊查询
        public DataTable queryByAll(string all)
        {
            return bm.queryByAll(all);
        }

        //返回最新增加的10条记录
        public DataTable getLast10Records()
        {
            return bm.getLast10Records();
        }


        //按查询条件模糊查询
        public DataTable getRecordsByCondition(string condition)
        {
            return bm.getRecordsByCondition(condition);
        }

    }
}
//####################################### end 郭林东 ##############################################