//####################################### begin 郭展光 ##############################################
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
    public partial class FormAdminUpdate : Form
    {
        public FormAdminUpdate()
        {
            InitializeComponent();
        }

        int id;

        public FormAdminUpdate(int id)
        {
            this.id = id;
            InitializeComponent();
        }
        //初始化
        private void FormAdminUpdate_Load(object sender, EventArgs e)
        {
            textId.Text = id.ToString();
            BLL.Admin bll = new BLL.Admin();
            Model.Admin model = bll.getModel(id.ToString());

            if (model == null)
            {
                MessageBox.Show("数据查询出错");
                return;
            }
            else
            {
                textId.Text = model.Id;
                textAdminname.Text = model.Name;
                textOldPwd.Text = model.Pass;
            }
        }

     
        private void lab_NewPwd_Click(object sender, EventArgs e)
        {

        }

        private void lab_Id_Click(object sender, EventArgs e)
        {

        }
        //修改管理员信息
        private void save_admin_Click(object sender, EventArgs e)
        {
            Model.Admin model = new Model.Admin();
            model.Id = id.ToString();
            model.Name = textAdminname.Text.Trim();
            model.Pass = textNewPwd.Text.Trim();
            BLL.Admin bll = new BLL.Admin();
            if (bll.update(model))
            {
                MessageBox.Show("修改成功！");
            }
            else 
            {
                MessageBox.Show("修改失败！", "错误");
            }
        }
     

        private void textAdminname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textOldPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNewPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void lab_AdminName_Click(object sender, EventArgs e)
        {

        }

        private void lab_OldPwd_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//####################################### end 郭展光 ##############################################