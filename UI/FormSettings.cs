//####################################### begin 郭林东 ##############################################
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace UI
{
    //本类主要用于通过界面修改App.config
    public partial class FormSettings : Form
    {
        private bool isWindowsAuth=true;
        public FormSettings()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                isWindowsAuth = true;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
            else
            {
                isWindowsAuth = false;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text.Trim();
            string str1 = textBox2.Text.Trim();
            string str2 = textBox3.Text.Trim();

            

            if (isWindowsAuth)
            {
                if (str == "" || str == null)
                {
                    MessageBox.Show("服务器名称未填写");
                    return;
                }
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                config.AppSettings.Settings["connectionString"].Value = "Server="+str+";Database=bookstore;Integrated Security=true";

                //记得保存
                config.Save(ConfigurationSaveMode.Modified);
                //刷新，否则程序读取的还是之前的值（可能已装入内存）
                System.Configuration.ConfigurationManager.RefreshSection("appSettings");

                string str3 = ConfigurationManager.AppSettings["connectionString"];
                Console.WriteLine(str3);

                MessageBox.Show("保存成功");
            }
            else
            {
                if (str == "" || str == null || str1 == "" || str1 == null || str2 == "" || str2 == null)
                {
                    MessageBox.Show("未填写完整");
                    return;
                }

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                config.AppSettings.Settings["connectionString"].Value = "Server=" + str + ";Database=bookstore;Integrated Security=false;Uid="+str1+";Pwd="+str2;

                //记得保存
                config.Save(ConfigurationSaveMode.Modified);
                //刷新，否则程序读取的还是之前的值（可能已装入内存）
                System.Configuration.ConfigurationManager.RefreshSection("appSettings");

                string str3 = ConfigurationManager.AppSettings["connectionString"];
                Console.WriteLine(str3);

                MessageBox.Show("保存成功，");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.AppSettings bllAs = new BLL.AppSettings();
            if (bllAs.checkConnection())
            {
                MessageBox.Show("当前数据库可以成功连接");
            }
            else
            {
                MessageBox.Show("连接失败");
            }
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
//####################################### end 郭林东 ##############################################