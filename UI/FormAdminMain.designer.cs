namespace UI
{
    partial class FormAdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminMain));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin_add = new System.Windows.Forms.Button();
            this.Admin_Update = new System.Windows.Forms.Button();
            this.Admin_del = new System.Windows.Forms.Button();
            this.Admin_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(349, 177);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "a_id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "a_name";
            this.Column2.HeaderText = "账号";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "a_pass";
            this.Column3.HeaderText = "密码";
            this.Column3.Name = "Column3";
            // 
            // Admin_add
            // 
            this.Admin_add.BackColor = System.Drawing.Color.Transparent;
            this.Admin_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Admin_add.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Admin_add.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Admin_add.Image = ((System.Drawing.Image)(resources.GetObject("Admin_add.Image")));
            this.Admin_add.Location = new System.Drawing.Point(12, 209);
            this.Admin_add.Name = "Admin_add";
            this.Admin_add.Size = new System.Drawing.Size(75, 33);
            this.Admin_add.TabIndex = 1;
            this.Admin_add.Text = "增 加";
            this.Admin_add.UseVisualStyleBackColor = false;
            this.Admin_add.Click += new System.EventHandler(this.Admin_add_Click);
            // 
            // Admin_Update
            // 
            this.Admin_Update.BackColor = System.Drawing.Color.Transparent;
            this.Admin_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Admin_Update.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Admin_Update.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Admin_Update.Image = ((System.Drawing.Image)(resources.GetObject("Admin_Update.Image")));
            this.Admin_Update.Location = new System.Drawing.Point(195, 209);
            this.Admin_Update.Name = "Admin_Update";
            this.Admin_Update.Size = new System.Drawing.Size(75, 33);
            this.Admin_Update.TabIndex = 2;
            this.Admin_Update.Text = "修 改";
            this.Admin_Update.UseVisualStyleBackColor = false;
            this.Admin_Update.Click += new System.EventHandler(this.Admin_Update_Click);
            // 
            // Admin_del
            // 
            this.Admin_del.BackColor = System.Drawing.Color.Transparent;
            this.Admin_del.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Admin_del.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Admin_del.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Admin_del.Image = ((System.Drawing.Image)(resources.GetObject("Admin_del.Image")));
            this.Admin_del.Location = new System.Drawing.Point(104, 209);
            this.Admin_del.Name = "Admin_del";
            this.Admin_del.Size = new System.Drawing.Size(75, 33);
            this.Admin_del.TabIndex = 3;
            this.Admin_del.Text = "删 除";
            this.Admin_del.UseVisualStyleBackColor = false;
            this.Admin_del.Click += new System.EventHandler(this.Admin_del_Click);
            // 
            // Admin_close
            // 
            this.Admin_close.BackColor = System.Drawing.Color.Transparent;
            this.Admin_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Admin_close.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Admin_close.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Admin_close.Image = ((System.Drawing.Image)(resources.GetObject("Admin_close.Image")));
            this.Admin_close.Location = new System.Drawing.Point(286, 209);
            this.Admin_close.Name = "Admin_close";
            this.Admin_close.Size = new System.Drawing.Size(75, 33);
            this.Admin_close.TabIndex = 4;
            this.Admin_close.Text = "关 闭";
            this.Admin_close.UseVisualStyleBackColor = false;
            this.Admin_close.Click += new System.EventHandler(this.Admin_close_Click);
            // 
            // FormAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 262);
            this.Controls.Add(this.Admin_close);
            this.Controls.Add(this.Admin_del);
            this.Controls.Add(this.Admin_Update);
            this.Controls.Add(this.Admin_add);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员账号管理";
            this.Load += new System.EventHandler(this.FormAdminMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Admin_add;
        private System.Windows.Forms.Button Admin_Update;
        private System.Windows.Forms.Button Admin_del;
        private System.Windows.Forms.Button Admin_close;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}