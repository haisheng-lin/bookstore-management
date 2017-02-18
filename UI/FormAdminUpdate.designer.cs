namespace UI
{
    partial class FormAdminUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminUpdate));
            this.lab_OldPwd = new System.Windows.Forms.Label();
            this.lab_NewPwd = new System.Windows.Forms.Label();
            this.lab_AdminName = new System.Windows.Forms.Label();
            this.textOldPwd = new System.Windows.Forms.TextBox();
            this.textNewPwd = new System.Windows.Forms.TextBox();
            this.textAdminname = new System.Windows.Forms.TextBox();
            this.save_admin = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.lab_Id = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lab_OldPwd
            // 
            this.lab_OldPwd.AutoSize = true;
            this.lab_OldPwd.BackColor = System.Drawing.Color.Transparent;
            this.lab_OldPwd.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_OldPwd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lab_OldPwd.Location = new System.Drawing.Point(174, 156);
            this.lab_OldPwd.Name = "lab_OldPwd";
            this.lab_OldPwd.Size = new System.Drawing.Size(114, 19);
            this.lab_OldPwd.TabIndex = 0;
            this.lab_OldPwd.Text = "原始密码：";
            this.lab_OldPwd.Click += new System.EventHandler(this.lab_OldPwd_Click);
            // 
            // lab_NewPwd
            // 
            this.lab_NewPwd.AutoSize = true;
            this.lab_NewPwd.BackColor = System.Drawing.Color.Transparent;
            this.lab_NewPwd.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_NewPwd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lab_NewPwd.Location = new System.Drawing.Point(174, 195);
            this.lab_NewPwd.Name = "lab_NewPwd";
            this.lab_NewPwd.Size = new System.Drawing.Size(114, 19);
            this.lab_NewPwd.TabIndex = 1;
            this.lab_NewPwd.Text = "修改密码：";
            this.lab_NewPwd.Click += new System.EventHandler(this.lab_NewPwd_Click);
            // 
            // lab_AdminName
            // 
            this.lab_AdminName.AutoSize = true;
            this.lab_AdminName.BackColor = System.Drawing.Color.Transparent;
            this.lab_AdminName.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_AdminName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lab_AdminName.Location = new System.Drawing.Point(153, 119);
            this.lab_AdminName.Name = "lab_AdminName";
            this.lab_AdminName.Size = new System.Drawing.Size(135, 19);
            this.lab_AdminName.TabIndex = 2;
            this.lab_AdminName.Text = "管理员账号：";
            this.lab_AdminName.Click += new System.EventHandler(this.lab_AdminName_Click);
            // 
            // textOldPwd
            // 
            this.textOldPwd.Location = new System.Drawing.Point(276, 156);
            this.textOldPwd.Name = "textOldPwd";
            this.textOldPwd.Size = new System.Drawing.Size(186, 21);
            this.textOldPwd.TabIndex = 3;
            this.textOldPwd.TextChanged += new System.EventHandler(this.textOldPwd_TextChanged);
            // 
            // textNewPwd
            // 
            this.textNewPwd.Location = new System.Drawing.Point(277, 195);
            this.textNewPwd.Name = "textNewPwd";
            this.textNewPwd.Size = new System.Drawing.Size(186, 21);
            this.textNewPwd.TabIndex = 4;
            this.textNewPwd.TextChanged += new System.EventHandler(this.textNewPwd_TextChanged);
            // 
            // textAdminname
            // 
            this.textAdminname.Location = new System.Drawing.Point(277, 117);
            this.textAdminname.Name = "textAdminname";
            this.textAdminname.Size = new System.Drawing.Size(186, 21);
            this.textAdminname.TabIndex = 5;
            this.textAdminname.TextChanged += new System.EventHandler(this.textAdminname_TextChanged);
            // 
            // save_admin
            // 
            this.save_admin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save_admin.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save_admin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.save_admin.Image = ((System.Drawing.Image)(resources.GetObject("save_admin.Image")));
            this.save_admin.Location = new System.Drawing.Point(186, 239);
            this.save_admin.Name = "save_admin";
            this.save_admin.Size = new System.Drawing.Size(75, 33);
            this.save_admin.TabIndex = 6;
            this.save_admin.Text = "保 存";
            this.save_admin.UseVisualStyleBackColor = true;
            this.save_admin.Click += new System.EventHandler(this.save_admin_Click);
            // 
            // close
            // 
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(302, 239);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 33);
            this.close.TabIndex = 7;
            this.close.Text = "关 闭";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // lab_Id
            // 
            this.lab_Id.AutoSize = true;
            this.lab_Id.BackColor = System.Drawing.Color.Transparent;
            this.lab_Id.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Id.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lab_Id.Location = new System.Drawing.Point(153, 79);
            this.lab_Id.Name = "lab_Id";
            this.lab_Id.Size = new System.Drawing.Size(135, 19);
            this.lab_Id.TabIndex = 8;
            this.lab_Id.Text = "管理员编号：";
            this.lab_Id.Click += new System.EventHandler(this.lab_Id_Click);
            // 
            // textId
            // 
            this.textId.Enabled = false;
            this.textId.Location = new System.Drawing.Point(276, 77);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(186, 21);
            this.textId.TabIndex = 9;
            this.textId.TextChanged += new System.EventHandler(this.textId_TextChanged);
            // 
            // FormAdminUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(546, 307);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.lab_Id);
            this.Controls.Add(this.close);
            this.Controls.Add(this.save_admin);
            this.Controls.Add(this.textAdminname);
            this.Controls.Add(this.textNewPwd);
            this.Controls.Add(this.textOldPwd);
            this.Controls.Add(this.lab_AdminName);
            this.Controls.Add(this.lab_NewPwd);
            this.Controls.Add(this.lab_OldPwd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdminUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改管理员";
            this.Load += new System.EventHandler(this.FormAdminUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_OldPwd;
        private System.Windows.Forms.Label lab_NewPwd;
        private System.Windows.Forms.Label lab_AdminName;
        private System.Windows.Forms.TextBox textOldPwd;
        private System.Windows.Forms.TextBox textNewPwd;
        private System.Windows.Forms.TextBox textAdminname;
        private System.Windows.Forms.Button save_admin;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label lab_Id;
        private System.Windows.Forms.TextBox textId;
    }
}