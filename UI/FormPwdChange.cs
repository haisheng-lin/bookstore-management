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
    public partial class FormPwdChange : Form
    {
        public FormPwdChange()
        {
            InitializeComponent();
        }

        //修改密码
        private void button_save_Click(object sender, EventArgs e)
        {
            if (txtOldPwd.Text.Trim() !=AdminHelper.pass)
            {
                MessageBox.Show("原始密码错误！","错误提示");
                txtOldPwd.Focus();
                return;
            }
            if (txtNewPwd.Text.Trim() == "")
            {
                MessageBox.Show("新密码不能为空，请输入", "错误提示");
                txtNewPwd.Focus();
                return;
            }
            if (txtNewPwdAgain.Text.Trim() != txtNewPwd.Text.Trim())
            {
                MessageBox.Show("俩次输入的密码不一致，请重新输入！","错误提示");
                txtNewPwdAgain.Focus();
                return;
            }
            Model.Admin model = new Model.Admin();
            model.Name =AdminHelper.name;
            model.Pass =txtNewPwd.Text.Trim();//新密码
            BLL.Admin bll = new BLL.Admin();

            if(bll.Update(model))
            {
                AdminHelper.pass = model.Pass;
                MessageBox.Show("密码更新成功！");
            }
            else
            {
                MessageBox.Show("密码修改失败！","错误");
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPwdChange_Load(object sender, EventArgs e)
        {

        }
    }
}
//####################################### end 郭展光 ##############################################