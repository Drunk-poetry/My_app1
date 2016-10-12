namespace My_app1
{
    partial class frmChangeUser
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
            this.NewUserbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Superadministrator = new System.Windows.Forms.Label();
            this.administrator = new System.Windows.Forms.Label();
            this.averageuser = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ChangeUserbutton = new System.Windows.Forms.Button();
            this.ExitChangeUserbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewUserbox
            // 
            this.NewUserbox.Location = new System.Drawing.Point(111, 77);
            this.NewUserbox.Name = "NewUserbox";
            this.NewUserbox.Size = new System.Drawing.Size(100, 21);
            this.NewUserbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "超级管理员：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "管理员：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "一般用户：";
            // 
            // Superadministrator
            // 
            this.Superadministrator.AutoSize = true;
            this.Superadministrator.Location = new System.Drawing.Point(102, 26);
            this.Superadministrator.Name = "Superadministrator";
            this.Superadministrator.Size = new System.Drawing.Size(0, 12);
            this.Superadministrator.TabIndex = 7;
            // 
            // administrator
            // 
            this.administrator.AutoSize = true;
            this.administrator.Location = new System.Drawing.Point(102, 60);
            this.administrator.Name = "administrator";
            this.administrator.Size = new System.Drawing.Size(0, 12);
            this.administrator.TabIndex = 8;
            // 
            // averageuser
            // 
            this.averageuser.AutoSize = true;
            this.averageuser.Location = new System.Drawing.Point(102, 91);
            this.averageuser.Name = "averageuser";
            this.averageuser.Size = new System.Drawing.Size(0, 12);
            this.averageuser.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "输入新用户名：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "超级管理员",
            "管理员",
            "一般用户"});
            this.comboBox1.Location = new System.Drawing.Point(111, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "用户权限选择：";
            // 
            // ChangeUserbutton
            // 
            this.ChangeUserbutton.Location = new System.Drawing.Point(104, 17);
            this.ChangeUserbutton.Name = "ChangeUserbutton";
            this.ChangeUserbutton.Size = new System.Drawing.Size(75, 23);
            this.ChangeUserbutton.TabIndex = 14;
            this.ChangeUserbutton.Text = "确认修改";
            this.ChangeUserbutton.UseVisualStyleBackColor = true;
            this.ChangeUserbutton.Click += new System.EventHandler(this.ChangeUserbutton_Click);
            // 
            // ExitChangeUserbutton
            // 
            this.ExitChangeUserbutton.Location = new System.Drawing.Point(245, 17);
            this.ExitChangeUserbutton.Name = "ExitChangeUserbutton";
            this.ExitChangeUserbutton.Size = new System.Drawing.Size(75, 23);
            this.ExitChangeUserbutton.TabIndex = 15;
            this.ExitChangeUserbutton.Text = "取消";
            this.ExitChangeUserbutton.UseVisualStyleBackColor = true;
            this.ExitChangeUserbutton.Click += new System.EventHandler(this.ExitChangeUserbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Superadministrator);
            this.groupBox1.Controls.Add(this.administrator);
            this.groupBox1.Controls.Add(this.averageuser);
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 132);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.NewUserbox);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(228, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 132);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(463, 207);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ChangeUserbutton);
            this.groupBox4.Controls.Add(this.ExitChangeUserbutton);
            this.groupBox4.Location = new System.Drawing.Point(13, 148);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(436, 46);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // frmChangeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 217);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangeUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改用户名";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmChangeUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox NewUserbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Superadministrator;
        private System.Windows.Forms.Label administrator;
        private System.Windows.Forms.Label averageuser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ChangeUserbutton;
        private System.Windows.Forms.Button ExitChangeUserbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}