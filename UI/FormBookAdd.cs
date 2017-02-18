//####################################### begin 林海晟 ##############################################
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace UI
{
    public partial class FormBookAdd : Form
    {

        private byte[] picture;

        public FormBookAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.Book book = new Model.Book();


            book.Name= textBox2.Text.Trim();
            book.Author = textBox3.Text.Trim();
            book.Publisher = textBox4.Text.Trim();
            book.Pubtime = textBox5.Text.Trim();
            book.Pritime = textBox6.Text.Trim();
            book.Edition = textBox7.Text.Trim();
            book.Impression = textBox8.Text.Trim();
            book.Pages = textBox9.Text.Trim();
            book.Words = textBox10.Text.Trim();
            book.Format = textBox11.Text.Trim();
            book.Paper = textBox12.Text.Trim();
            book.Packaging = textBox13.Text.Trim();
            book.Isbn = textBox14.Text.Trim();

            book.Picture = picture;

            book.Price = textBox15.Text.Trim();
            book.Sort = textBox16.Text.Trim();
            book.Inventory = textBox17.Text.Trim();

            if (book.Name == null||book.Name == "")
            {
                MessageBox.Show("书名不允许为空");
                return;
            }
            if (book.Picture == null)
            {
                Bitmap bmp = (Bitmap)pictureBox1.Image;
                MemoryStream memStream = new MemoryStream();
                bmp.Save(memStream, ImageFormat.Png);
                memStream.Seek(0, SeekOrigin.Begin); //及时定位流的开始位置
                book.Picture = new byte[memStream.Length];
                memStream.Read(book.Picture, 0, book.Picture.Length);
                memStream.Close();
            }

            BLL.Book bll = new BLL.Book();

            if (bll.insert(book)==1)
            {
                MessageBox.Show("增加成功");
            }
            else
            {
                MessageBox.Show("增加失败");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(fd.FileName, FileMode.Open, FileAccess.Read);
                int imgLen = (int)fs.Length;

                picture = new byte[imgLen + 1];

                fs.Read(picture, 0, imgLen);
                fs.Dispose();
                MessageBox.Show("图片选择成功");

                MemoryStream ms = new MemoryStream(picture);
                Console.WriteLine(ms.ToString());
                Bitmap bmp = new Bitmap(ms);
                pictureBox1.Image = bmp;

            }
            else
            {
                MessageBox.Show("图片选择失败");
            }
        }


       

        private void FormBookAdd_Activated(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void FormBookAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
//####################################### end 林海晟 ##############################################