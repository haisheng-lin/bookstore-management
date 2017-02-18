namespace UI
{
    partial class FormAdminAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminAdd));
            this.Admin_Name = new System.Windows.Forms.Label();
            this.Admin_pwd = new System.Windows.Forms.Label();
            this.textAdmin_name = new System.Windows.Forms.TextBox();
            this.textAdmin_pwd = new System.Windows.Forms.TextBox();
            this.Save_admin = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Admin_Name
            // 
            this.Admin_Name.AutoSize = true;
            this.Admin_Name.BackColor = System.Drawing.Color.Transparent;
            this.Admin_Name.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Admin_Name.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Admin_Name.Location = new System.Drawing.Point(176, 127);
            this.Admin_Name.Name = "Admin_Name";
            this.Admin_Name.Size = new System.Drawing.Size(72, 19);
            this.Admin_Name.TabIndex = 1;
            this.Admin_Name.Text = "账号：";
            // 
            // Admin_pwd
            // 
            this.Admin_pwd.AutoSize = true;
            this.Admin_pwd.BackColor = System.Drawing.Color.Transparent;
            this.Admin_pwd.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Admin_pwd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Admin_pwd.Location = new System.Drawing.Point(176, 181);
            this.Admin_pwd.Name = "Admin_pwd";
            this.Admin_pwd.Size = new System.Drawing.Size(72, 19);
            this.Admin_pwd.TabIndex = 2;
            this.Admin_pwd.Text = "密码：";
            // 
            // textAdmin_name
            // 
            this.textAdmin_name.Location = new System.Drawing.Point(254, 125);
            this.textAdmin_name.Name = "textAdmin_name";
            this.textAdmin_name.Size = new System.Drawing.Size(186, 21);
            this.textAdmin_name.TabIndex = 4;
            this.textAdmin_name.TextChanged += new System.EventHandler(this.textAdmin_name_TextChanged);
            // 
            // textAdmin_pwd
            // 
            this.textAdmin_pwd.Location = new System.Drawing.Point(254, 179);
            this.textAdmin_pwd.Name = "textAdmin_pwd";
            this.textAdmin_pwd.Size = new System.Drawing.Size(186, 21);
            this.textAdmin_pwd.TabIndex = 5;
            // 
            // Save_admin
            // 
            this.Save_admin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save_admin.BackgroundImage")));
            this.Save_admin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save_admin.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Save_admin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Save_admin.Location = new System.Drawing.Point(186, 239);
            this.Save_admin.Name = "Save_admin";
            this.Save_admin.Size = new System.Drawing.Size(75, 33);
            this.Save_admin.TabIndex = 6;
            this.Save_admin.Text = "保 存";
            this.Save_admin.UseVisualStyleBackColor = true;
            this.Save_admin.Click += new System.EventHandler(this.Save_admin_Click);
            // 
            // close
            // 
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.close.Location = new System.Drawing.Point(302, 239);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 33);
            this.close.TabIndex = 7;
            this.close.Text = "关 闭";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // FormAdminAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(546, 307);
            this.Controls.Add(this.close);
            this.Controls.Add(this.Save_admin);
            this.Controls.Add(this.textAdmin_pwd);
            this.Controls.Add(this.textAdmin_name);
            this.Controls.Add(this.Admin_pwd);
            this.Controls.Add(this.Admin_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAdminAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 增加管理员";
            this.Load += new System.EventHandler(this.FormAdminAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Admin_Name;
        private System.Windows.Forms.Label Admin_pwd;
        private System.Windows.Forms.TextBox textAdmin_name;
        private System.Windows.Forms.TextBox textAdmin_pwd;
        private System.Windows.Forms.Button Save_admin;
        private System.Windows.Forms.Button close;
    }
}