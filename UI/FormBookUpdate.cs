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
    public partial class FormBookUpdate : Form
    {

        private byte[] picture;
        public FormBookUpdate()
        {
            InitializeComponent();
        }

        private bool isIdFilled()
        {
            if (textBox1.Text.Trim() == null || textBox1.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isIdFilled())
            {
                MessageBox.Show("您还没有填写ID");
                return;
            }


            Model.Book book = new Model.Book();
            book.Id = textBox1.Text.Trim();
            book.Name = textBox2.Text.Trim();
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

            if (MessageBox.Show("确定要修改吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            BLL.Book bllBook = new BLL.Book();
            if (bllBook.update(book)==1)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isIdFilled())
            {
                MessageBox.Show("您还没有填写ID");
                return;
            }

            string id = textBox1.Text.Trim();
            BLL.Book book = new BLL.Book();
            SqlDataReader reader = book.queryById(id);

            //先清空所有内容
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is GroupBox)
                {

                    foreach (Control c in ctrl.Controls)
                    {
                        if (c is TextBox)
                        {
                            TextBox tb = (TextBox)c;
                            tb.Text = "";
                            Console.WriteLine("gld");
                        }
                    }
                }
            }
            pictureBox1.Image = null;


            while (reader.Read())
            {
                textBox1.Text = reader[0].ToString();
                textBox2.Text = reader[1].ToString();
                textBox3.Text = reader[2].ToString();
                textBox4.Text = reader[3].ToString();
                textBox5.Text = reader[4].ToString();
                textBox6.Text = reader[5].ToString();
                textBox7.Text = reader[6].ToString();
                textBox8.Text = reader[7].ToString();
                textBox9.Text = reader[8].ToString();
                textBox10.Text = reader[9].ToString();
                textBox11.Text = reader[10].ToString();
                textBox12.Text = reader[11].ToString();
                textBox13.Text = reader[12].ToString();
                textBox14.Text = reader[13].ToString();

                int bufferSize = 1024 * 100;
                picture = new byte[bufferSize];
                reader.GetBytes(14, 0, picture, 0, bufferSize);

                MemoryStream ms = new MemoryStream(picture);

                try
                {
                    Bitmap bmp = new Bitmap(ms);
                    pictureBox1.Image = bmp;
                }
                catch (Exception)
                {
                }


                textBox15.Text = reader[15].ToString();
                textBox16.Text = reader[16].ToString();
                textBox17.Text = reader[17].ToString();
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

                Bitmap bmp = new Bitmap(ms);
                pictureBox1.Image = bmp;

            }
            else
            {
                MessageBox.Show("图片选择失败");
            }
        }

        private void FormBookUpdate_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

    }
}
//####################################### end 林海晟 ##############################################