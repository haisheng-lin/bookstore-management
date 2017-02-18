//####################################### begin 郭林东 ##############################################
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAL
{
    public class BookManipulation
    {

        public BookManipulation()
        {

        }

        //增加一本书

        //0：增加失败
        //1：增加成功
        //2：连接出错，增加失败
        //3：图片为空，增加失败
        public int insert(Model.Book book)
        {

         string name=book.Name;
         string author=book.Author;
         string publisher=book.Publisher;
             

         string pubtime=book.Pubtime;
         string pritime=book.Pritime;

         string edition=book.Edition;
         string impression=book.Impression;

         string pages=book.Pages;
         string words=book.Words;
         
         string format=book.Format;
         string paper=book.Paper;
         string packaging=book.Packaging;

         string isbn=book.Isbn;
         byte[] picture=book.Picture;
         string price=book.Price;
         string sort=book.Sort;
         string inventory = book.Inventory;


        //判断连接
         if (DbHelper.checkConnection()==false)
         {
             return 2;
         }

         //判断图片
         if (picture == null)
         {
             return 3;
         }

            string cmdText = "insert into book(b_name,b_author,b_publisher,b_pubtime,b_pritime,b_edition,b_impression,b_pages,b_words,b_format,b_paper,b_packaging,b_isbn,b_picture,b_price,b_sort,b_inventory)values('" + name + "','" + author + "','" + publisher + "','" + pubtime + "','" + pritime + "','" + edition + "','" + impression + "','" + pages + "','" + words + "','" + format + "','" + paper + "','" + packaging + "','" + isbn + "',@picture,'" + price + "','"+sort+"','"+inventory+"')";
            SqlParameter[] parameters ={ new SqlParameter ("@picture",SqlDbType.Binary)};
            parameters[0].Value = picture;

            int i = DbHelper.ExecuteNonQuery(cmdText, parameters);

            if (i == 1)
            {
                return 1;
            }
            else
            {
                Console.WriteLine("增加失败");
                return 0;
            }
           
        }

        //删除一本书

        //0：删除失败
        //1：删除成功
        //2：连接出错，删除失败
        //3：书本不存在，删除失败

        public int delete(string id)
        {
            //判断连接
            if (DbHelper.checkConnection() == false)
            {
                return 2;
            }

            string cmdQueryText = "select * from book where b_id='" + id + "'";
            Object obj = DbHelper.ExecuteScalar(cmdQueryText);
            if (obj == null)
            {
                Console.WriteLine("书本不存在");
                return 3;
            }
            else
            {


                string cmdText = "delete from book where b_id=" + id;

                int i = DbHelper.ExecuteNonQuery(cmdText);
                if (i == 1)
                {
                    return 1;
                }
                else
                {
                    Console.WriteLine("删除失败");
                    return 0;
                }
            }
        }


        //更新一本书

        //0：更新失败
        //1：更新成功
        //2：连接出错，更新失败
        //3：图片为空，更新失败
        //4：ID为空，更新失败
        //
        public int update(Model.Book book)
        {
            string id = book.Id;
            string name = book.Name;
            string author = book.Author;
            string publisher = book.Publisher;


            string pubtime = book.Pubtime;
            string pritime = book.Pritime;

            string edition = book.Edition;
            string impression = book.Impression;

            string pages = book.Pages;
            string words = book.Words;

            string format = book.Format;
            string paper = book.Paper;
            string packaging = book.Packaging;

            string isbn = book.Isbn;
            byte[] picture = book.Picture;
            string price = book.Price;
            string sort = book.Sort;
            string inventory = book.Inventory;


            //判断连接
            if (DbHelper.checkConnection() == false)
            {
                return 2;
            }

            if (picture == null)
            {
                return 3;
            }

            if (id == null || id == "")
            {
                return 4;
            }

            string cmdText = "update book set b_name='"+name+"',b_author='"+author+"',b_publisher='"+publisher+"',b_pubtime='"+pubtime+"',b_pritime='"+pritime+"',b_edition='"+edition+"',b_impression='"+impression+"',b_pages='"+pages+"',b_words='"+words+"',b_format='"+format+"',b_paper='"+paper+"',b_packaging='"+packaging+"',b_isbn='"+isbn+"',b_picture=@picture,b_price='"+price+"',b_sort='"+sort+"',b_inventory='"+inventory+"' where b_id='"+id+"'";

            SqlParameter[] parameters = { new SqlParameter("@picture", SqlDbType.Binary) };
            parameters[0].Value = picture;

            int i = DbHelper.ExecuteNonQuery(cmdText,parameters);
            if (i == 1)
            {
                return 1;

            }
            else
            {
                Console.WriteLine("更新失败");
                return 0;
            }
        }


        //根据id查询，以下多个函数均类似
        public SqlDataReader queryById(string id)
        {
            string cmdText = "select * from book where b_id='"+id+"'";

            return DbHelper.ExecuteReader(cmdText);

        }

        public SqlDataReader queryByName(string name)
        {
            string cmdText = "select * from book where b_name='" + name + "'";
            return DbHelper.ExecuteReader(cmdText);

        }

        public SqlDataReader queryByAuthor(string author)
        {
            string cmdText = "select * from book where b_author='" + author + "'";
            return DbHelper.ExecuteReader(cmdText);

        }


        public SqlDataReader queryByPublisher(string publisher)
        {
            string cmdText = "select * from book where b_publisher='" + publisher + "'";
            return DbHelper.ExecuteReader(cmdText);

        }

        public SqlDataReader queryByPubtime(string pubtime)
        {
            string cmdText = "select * from book where b_pubtime='" + pubtime + "'";
            return DbHelper.ExecuteReader(cmdText);

        }

        public SqlDataReader queryByPritime(string pritime)
        {
            string cmdText = "select * from book where b_pritime='" + pritime + "'";
            return DbHelper.ExecuteReader(cmdText);

        }

        public SqlDataReader queryByEdition(string edition)
        {
            string cmdText = "select * from book where b_edition='" + edition + "'";
            return DbHelper.ExecuteReader(cmdText);

        }


        public SqlDataReader queryByImpression(string impression)
        {
            string cmdText = "select * from book where b_impression='" + impression + "'";
            return DbHelper.ExecuteReader(cmdText);

        }


        public SqlDataReader queryByPages(string pages)
        {
            string cmdText = "select * from book where b_pages='" + pages + "'";
            return DbHelper.ExecuteReader(cmdText);

        }

        public SqlDataReader queryByWords(string words)
        {
            string cmdText = "select * from book where b_words='" + words + "'";
            return DbHelper.ExecuteReader(cmdText);

        }


        public SqlDataReader queryByFormat(string format)
        {
            string cmdText = "select * from book where b_format='" + format + "'";
            return DbHelper.ExecuteReader(cmdText);
        }

        public SqlDataReader querybyPager(string paper)
        {
            string cmdText = "select * from book where b_paper='" + paper + "'";
            return DbHelper.ExecuteReader(cmdText);

        }


        public SqlDataReader queryByPackaging(string packaging)
        {
            string cmdText = "select * from book where b_packaging='" + packaging + "'";
            return DbHelper.ExecuteReader(cmdText);

        }


        public SqlDataReader queryByIsbn(string isbn)
        {
            string cmdText = "select * from book where b_isbn='" + isbn + "'";
            return DbHelper.ExecuteReader(cmdText);

        }

        public SqlDataReader queryByPrice(string price)
        {
            string cmdText = "select * from book where b_price='" + price + "'";
            return DbHelper.ExecuteReader(cmdText);

        }

        public SqlDataReader queryBySort(string sort)
        {
            string cmdText = "select * from book where b_sort='" + sort + "'";
            return DbHelper.ExecuteReader(cmdText);

        }

        public SqlDataReader queryByInventory(string inventory)
        {
            string cmdText = "select * from book where b_inventory='" + inventory + "'";
            return DbHelper.ExecuteReader(cmdText);

        }


        //根据关键字查询，所有字段都进行匹配
        public DataTable queryByAll(string all)
        {
            string cmdText = "select * from book where b_id like '%" + all + "%' or b_name like '%" + all + "%' or b_author like '%" + all + "%' or b_publisher like '%" + all + "%' or b_pubtime like '%" + all + "%' or b_pritime like '%" + all + "%' or b_edition like '%" + all + "%' or b_impression like '%" + all + "%' or b_pages like '%" + all + "%' or b_words like '%" + all + "%' or b_format like '%" + all + "%' or b_paper like '%" + all + "%' or b_packaging like '%" + all + "%' or b_isbn like '%" + all + "%' or b_price like '%" + all + "%' or b_sort like '%" + all + "%' or b_inventory like '%" + all + "%'";
            return DbHelper.ExecuteDataTable(cmdText);
        }

        //得到最新添加的10条记录
        public DataTable getLast10Records()
        {
            string str = "select top 10 * from book order by b_id desc";
            return DbHelper.ExecuteDataTable(str);
        }


        //根据条件查询
        public DataTable getRecordsByCondition(string str)
        {


            StringBuilder sb = new StringBuilder();

            sb.Append("select * from book");
            if (str.Trim() != "")
                sb.Append(" where " + str);

            return DbHelper.ExecuteDataTable(sb.ToString());
        }

    }
}
//####################################### end 郭林东 ##############################################