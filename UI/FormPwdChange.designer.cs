namespace UI
{
    partial class FormPwdChange
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPwdChange));
            this.labOldPwd = new System.Windows.Forms.Label();
            this.labNewPwd = new System.Windows.Forms.Label();
            this.labNewPwdAgain = new System.Windows.Forms.Label();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtNewPwdAgain = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labOldPwd
            // 
            this.labOldPwd.AutoSize = true;
            this.labOldPwd.BackColor = System.Drawing.Color.Transparent;
            this.labOldPwd.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labOldPwd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labOldPwd.Location = new System.Drawing.Point(153, 83);
            this.labOldPwd.Name = "labOldPwd";
            this.labOldPwd.Size = new System.Drawing.Size(114, 19);
            this.labOldPwd.TabIndex = 0;
            this.labOldPwd.Text = "原始密码：";
            // 
            // labNewPwd
            // 
            this.labNewPwd.AutoSize = true;
            this.labNewPwd.BackColor = System.Drawing.Color.Transparent;
            this.labNewPwd.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labNewPwd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labNewPwd.Location = new System.Drawing.Point(174, 122);
            this.labNewPwd.Name = "labNewPwd";
            this.labNewPwd.Size = new System.Drawing.Size(93, 19);
            this.labNewPwd.TabIndex = 1;
            this.labNewPwd.Text = "新密码：";
            // 
            // labNewPwdAgain
            // 
            this.labNewPwdAgain.AutoSize = true;
            this.labNewPwdAgain.BackColor = System.Drawing.Color.Transparent;
            this.labNewPwdAgain.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labNewPwdAgain.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labNewPwdAgain.Location = new System.Drawing.Point(132, 160);
            this.labNewPwdAgain.Name = "labNewPwdAgain";
            this.labNewPwdAgain.Size = new System.Drawing.Size(135, 19);
            this.labNewPwdAgain.TabIndex = 2;
            this.labNewPwdAgain.Text = "新密码确认：";
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Location = new System.Drawing.Point(257, 81);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.Size = new System.Drawing.Size(167, 21);
            this.txtOldPwd.TabIndex = 3;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(257, 121);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(167, 21);
            this.txtNewPwd.TabIndex = 4;
            // 
            // txtNewPwdAgain
            // 
            this.txtNewPwdAgain.Location = new System.Drawing.Point(257, 160);
            this.txtNewPwdAgain.Name = "txtNewPwdAgain";
            this.txtNewPwdAgain.PasswordChar = '*';
            this.txtNewPwdAgain.Size = new System.Drawing.Size(167, 21);
            this.txtNewPwdAgain.TabIndex = 5;
            // 
            // button_save
            // 
            this.button_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_save.BackgroundImage")));
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_save.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_save.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_save.Location = new System.Drawing.Point(197, 208);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 33);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "保 存";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_close
            // 
            this.button_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_close.BackgroundImage")));
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_close.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_close.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_close.Location = new System.Drawing.Point(314, 208);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 33);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "关 闭";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // FormPwdChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(546, 285);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.txtNewPwdAgain);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.txtOldPwd);
            this.Controls.Add(this.labNewPwdAgain);
            this.Controls.Add(this.labNewPwd);
            this.Controls.Add(this.labOldPwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPwdChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.FormPwdChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labOldPwd;
        private System.Windows.Forms.Label labNewPwd;
        private System.Windows.Forms.Label labNewPwdAgain;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtNewPwdAgain;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_close;
    }
}