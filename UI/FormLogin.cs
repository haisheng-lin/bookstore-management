//####################################### begin 林海晟 ##############################################
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class FormLogin : Form
    {
        public static FormLogin formLogin;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            formLogin = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textUserName.Text.Trim();
            string pass =textUserPass.Text.Trim(); 
            if (userName == "" || pass == "")
            {
                MessageBox.Show("登录名或密码不能为空！", "错误提示");
                textUserName.Focus();
                return;
            }
            else
            {
                BLL.Admin bll = new BLL.Admin();
                if (bll.Login(userName, pass))//登录成功
                {
                    AdminHelper.name = textUserName.Text.Trim();
                    AdminHelper.pass = textUserPass.Text.Trim();
                    textUserName.Text = "";
                    textUserPass.Text = "";
                    this.Hide();
                    FormMain f = new FormMain();
                    f.Show();


                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请重新输入！", "错误提示");
                    textUserName.Text = "";
                    textUserPass.Text = "";
                    textUserName.Focus();
                }
            }
        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
//####################################### end 林海晟 ##############################################