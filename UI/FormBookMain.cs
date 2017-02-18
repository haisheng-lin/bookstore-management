//####################################### begin 郭林东 ##############################################
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
    public partial class FormBookMain : Form
    {
        public FormBookMain()
        {
            InitializeComponent();
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FormBookInquiry form4 = new FormBookInquiry();
            form4.MdiParent = this;
            form4.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormBookAdd form1 = new FormBookAdd();
            form1.MdiParent = this;
            form1.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormBookDelete form2 = new FormBookDelete();
            form2.MdiParent = this;
            form2.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FormBookUpdate form3 = new FormBookUpdate();
            form3.MdiParent = this;
            form3.Show();
        }

        private void FormBookMain_Load(object sender, EventArgs e)
        {

        }
    }
}
//####################################### end 郭林东 ##############################################