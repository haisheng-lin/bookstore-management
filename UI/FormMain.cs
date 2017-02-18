//####################################### begin 林海晟 ##############################################
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace UI
{
    public partial class FormMain : Form
    {
        private BLL.BookNotify bn;
        public FormMain()
        {
            
            InitializeComponent();
        }
        //####################################### begin 郭林东 ##############################################

        //开始新“提醒”后台进程
        private void startBookNotify()
        {
            Thread thread = new Thread(new ThreadStart(bookNotify));
            thread.IsBackground = true;
            thread.Start();
            progressBar1.Value = 50;
            
        }

        //后台执行的方法，用于从数据库查询数据
        private void bookNotify()
        {
            //提醒
            bn = new BLL.BookNotify();
            int num = bn.getWarningNumber();

            int inventory = bn.getTotalInventory();

            double asset = bn.getTotalAsset();

            string [] args= new string[3];
            args[0]=num.ToString();
            args[1]=inventory.ToString();
            args[2]=asset.ToString();


            Invoke(new bookNotifyDelegate(updateNotification),new object[]{args});

        }


        //委托
        public delegate void bookNotifyDelegate(string [] args);


        //更新主界面
        private void updateNotification(string [] args)
        {
            progressBar1.Value = 70;
           linkLabel3.Text = "有" + args[0] + "本书库存量少于10";
           linkLabel4.Text = args[1].ToString();
           linkLabel5.Text = "￥"+args[2].ToString();
           progressBar1.Value = 100;
           progressBar1.Visible = false;


        }
        //####################################### end 郭林东 ##############################################

        private void button1_Click(object sender, EventArgs e)
        {
            (new FormBookMain()).Show();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
            //今天是XXXX年XX月XX日星期X
            string str1=DateTime.Now.ToLongDateString().ToString();
            string str2 = DateTime.Now.ToString("dddd", new System.Globalization.CultureInfo("zh-cn"));
            label7.Text = str1 + " "+str2;
            linkLabel1.Text = AdminHelper.name;
            if (AdminHelper.name == "Admin")
                labRole.Text = "超级管理员";
            else
                labRole.Text = "普通管理员";
            //更新提醒
            startBookNotify();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new FormAbout()).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormLogin.formLogin.Show();
            //(new FormLogin()).Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }


        // 刷新提醒
        private void button6_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Value = 10; 
            startBookNotify();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new FormSettings()).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (AdminHelper.name == "Admin")
            {
                (new FormAdminMain()).Show();
            }
            else
            {
                (new FormPwdChange()).Show();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void labRole_Click(object sender, EventArgs e)
        {

        }
    }
}
//####################################### end 林海晟 ##############################################