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
    public partial class FormBookInquiry : Form
    {


        private string strWhere;

        //isAllField 是否全部字段都进行匹配
        //index 下拉列表的index
        private bool isAllField=true;
        private int index;


        public FormBookInquiry()
        {
            InitializeComponent();
        }

        //查询按钮
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == null || textBox1.Text.Trim() == "")
            {
                MessageBox.Show("您还没有填写关键字");
                return;
            }
            BLL.Book bll = new BLL.Book();
            if (isAllField)
            {
                dataGridView1.DataSource = bll.queryByAll(textBox1.Text);
            }
            else
            {
                if (index == 0)
                {
                    strWhere = "b_id like '%" + textBox1.Text.Trim() + "%'";
                }
                else if (index == 1)
                {
                    strWhere = "b_name like '%" + textBox1.Text.Trim() + "%'";
                }
                else if (index == 2)
                {
                    strWhere = "b_author like '%" + textBox1.Text.Trim() + "%'";
                }
                else if (index == 3)
                {
                    strWhere = "b_publisher like '%" + textBox1.Text.Trim() + "%'";
                }

                dataGridView1.DataSource = bll.getRecordsByCondition(strWhere);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void FormBookInquiry_Load(object sender, EventArgs e)
        {

        }


        //下拉列表
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                isAllField = false;
                index = 0;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                isAllField = false;
                index = 1;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                isAllField = false;
                index = 2;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                isAllField = false;
                index = 3;
            }
            else
            {
                isAllField = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
//####################################### end 林海晟 ##############################################