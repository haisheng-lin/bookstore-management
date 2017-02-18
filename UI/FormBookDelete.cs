//####################################### begin 林海晟 ##############################################
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace UI
{
    public partial class FormBookDelete : Form
    {
        private byte[] picture;



        public FormBookDelete()
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
            string id = textBox1.Text.Trim();
            if (!isIdFilled())
            {
                MessageBox.Show("您还没有填写ID");
                return;
            }
            if (MessageBox.Show("确定要删除吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            BLL.Book book = new BLL.Book();
            if (book.delete(id)==1)
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败，请确认ID是否正确");
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isIdFilled()){
                MessageBox.Show("您还没有填写ID");
                return;
            }

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



                string id = textBox1.Text.Trim();
                BLL.Book book = new BLL.Book();
                SqlDataReader reader = book.queryById(id);
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

        private void FormBookDelete_Load(object sender, EventArgs e)
        {

        }

        }
    }
//####################################### end 林海晟 ##############################################