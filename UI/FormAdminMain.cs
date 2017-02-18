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
    public partial class FormAdminMain : Form
    {
        public FormAdminMain()
        {
            InitializeComponent();
        }
        BLL.Admin bll = new BLL.Admin();

        public void Fill()
        {
            dataGridView1.DataSource = bll.getAllAdmin();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        //增加按钮事件
        private void Admin_add_Click(object sender, EventArgs e)
        {
            FormAdminAdd f = new FormAdminAdd();
            f.ShowDialog();
            Fill();
        }

        private void FormAdminMain_Load(object sender, EventArgs e)
        {
            Fill();
        }

        //删除按钮事件
        private void Admin_del_Click(object sender, EventArgs e)
        {
            int id =0;
            try
            {
                id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            }
            catch
            {
                MessageBox.Show("请选择有效数据行！");
                return;
            }
            if (id == 8)
            {
                MessageBox.Show("不允许删除管理员账号","提示");
                return;
            }
            else if
                (MessageBox.Show("确定要删除吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
          
            if (bll.delete(id.ToString()))
            {
                MessageBox.Show("删除成功！");
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
            Fill();
        }

        private void Admin_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //修改按钮事件
        private void Admin_Update_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            }
            catch
            {
                MessageBox.Show("请选择有效数据行！");
                return;
            }

            FormAdminUpdate f = new FormAdminUpdate(id);
            f.ShowDialog();
            Fill();
        }
    }
}
//####################################### end 郭展光 ##############################################