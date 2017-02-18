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
    public partial class FormAdminAdd : Form
    {
        public FormAdminAdd()
        {
            InitializeComponent();
        }

        private void Save_admin_Click(object sender, EventArgs e)
        {
            Model.Admin model = new Model.Admin();
            model.Name = textAdmin_name.Text.Trim();
            model.Pass = textAdmin_pwd.Text.Trim();
            BLL.Admin bll = new BLL.Admin();
            if (bll.insert(model))
            {
                MessageBox.Show("增加账号成功！");

            }
            else 
            {
                MessageBox.Show("增加失败");
            }
        }

        private void textAdmin_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAdminAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
//####################################### end 郭展光 ##############################################