namespace My_app1
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改口令ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改用户名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.远程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.连接管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gPRS告警ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.GPRS告警ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.参数管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基本设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.烟雾设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.气流设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.输入输出设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.时间设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.当前数据查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.历史数据查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统操作记录查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据备份ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工程项目导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.清除记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.恢复出厂设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.主机信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.license管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于公司ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统升级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.软件版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.frmMaintime = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStripStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理ToolStripMenuItem,
            this.用户管理ToolStripMenuItem,
            this.远程管理ToolStripMenuItem,
            this.参数管理ToolStripMenuItem,
            this.数据查询ToolStripMenuItem,
            this.工程管理ToolStripMenuItem,
            this.系统管理ToolStripMenuItem1,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1313, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注销ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.退出系统ToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.系统管理ToolStripMenuItem.Text = "开始";
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.注销ToolStripMenuItem.Text = "注销";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(121, 6);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改口令ToolStripMenuItem,
            this.修改用户名ToolStripMenuItem});
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // 修改口令ToolStripMenuItem
            // 
            this.修改口令ToolStripMenuItem.Name = "修改口令ToolStripMenuItem";
            this.修改口令ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.修改口令ToolStripMenuItem.Text = "修改口令";
            this.修改口令ToolStripMenuItem.Click += new System.EventHandler(this.修改口令ToolStripMenuItem_Click);
            // 
            // 修改用户名ToolStripMenuItem
            // 
            this.修改用户名ToolStripMenuItem.Name = "修改用户名ToolStripMenuItem";
            this.修改用户名ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.修改用户名ToolStripMenuItem.Text = "修改用户名";
            this.修改用户名ToolStripMenuItem.Click += new System.EventHandler(this.修改用户名ToolStripMenuItem_Click);
            // 
            // 远程管理ToolStripMenuItem
            // 
            this.远程管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.连接管理ToolStripMenuItem,
            this.gPRS告警ToolStripMenuItem1,
            this.GPRS告警ToolStripMenuItem2});
            this.远程管理ToolStripMenuItem.Name = "远程管理ToolStripMenuItem";
            this.远程管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.远程管理ToolStripMenuItem.Text = "远程管理";
            this.远程管理ToolStripMenuItem.Click += new System.EventHandler(this.远程管理ToolStripMenuItem_Click);
            // 
            // 连接管理ToolStripMenuItem
            // 
            this.连接管理ToolStripMenuItem.Name = "连接管理ToolStripMenuItem";
            this.连接管理ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.连接管理ToolStripMenuItem.Text = "连接管理";
            this.连接管理ToolStripMenuItem.Click += new System.EventHandler(this.连接管理ToolStripMenuItem_Click);
            // 
            // gPRS告警ToolStripMenuItem1
            // 
            this.gPRS告警ToolStripMenuItem1.Name = "gPRS告警ToolStripMenuItem1";
            this.gPRS告警ToolStripMenuItem1.Size = new System.Drawing.Size(128, 6);
            // 
            // GPRS告警ToolStripMenuItem2
            // 
            this.GPRS告警ToolStripMenuItem2.Name = "GPRS告警ToolStripMenuItem2";
            this.GPRS告警ToolStripMenuItem2.Size = new System.Drawing.Size(131, 22);
            this.GPRS告警ToolStripMenuItem2.Text = "GPRS告警";
            // 
            // 参数管理ToolStripMenuItem
            // 
            this.参数管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本设置ToolStripMenuItem,
            this.烟雾设置ToolStripMenuItem,
            this.气流设置ToolStripMenuItem,
            this.输入输出设置ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.时间设置ToolStripMenuItem});
            this.参数管理ToolStripMenuItem.Name = "参数管理ToolStripMenuItem";
            this.参数管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.参数管理ToolStripMenuItem.Text = "参数管理";
            // 
            // 基本设置ToolStripMenuItem
            // 
            this.基本设置ToolStripMenuItem.Name = "基本设置ToolStripMenuItem";
            this.基本设置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.基本设置ToolStripMenuItem.Text = "基本设置";
            // 
            // 烟雾设置ToolStripMenuItem
            // 
            this.烟雾设置ToolStripMenuItem.Name = "烟雾设置ToolStripMenuItem";
            this.烟雾设置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.烟雾设置ToolStripMenuItem.Text = "烟雾设置";
            // 
            // 气流设置ToolStripMenuItem
            // 
            this.气流设置ToolStripMenuItem.Name = "气流设置ToolStripMenuItem";
            this.气流设置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.气流设置ToolStripMenuItem.Text = "气流设置";
            // 
            // 输入输出设置ToolStripMenuItem
            // 
            this.输入输出设置ToolStripMenuItem.Name = "输入输出设置ToolStripMenuItem";
            this.输入输出设置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.输入输出设置ToolStripMenuItem.Text = "输入输出设置";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(145, 6);
            // 
            // 时间设置ToolStripMenuItem
            // 
            this.时间设置ToolStripMenuItem.Name = "时间设置ToolStripMenuItem";
            this.时间设置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.时间设置ToolStripMenuItem.Text = "时间设置";
            // 
            // 数据查询ToolStripMenuItem
            // 
            this.数据查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.当前数据查询ToolStripMenuItem,
            this.历史数据查询ToolStripMenuItem,
            this.系统操作记录查询ToolStripMenuItem});
            this.数据查询ToolStripMenuItem.Name = "数据查询ToolStripMenuItem";
            this.数据查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.数据查询ToolStripMenuItem.Text = "数据查询";
            // 
            // 当前数据查询ToolStripMenuItem
            // 
            this.当前数据查询ToolStripMenuItem.Name = "当前数据查询ToolStripMenuItem";
            this.当前数据查询ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.当前数据查询ToolStripMenuItem.Text = "当前数据查询";
            // 
            // 历史数据查询ToolStripMenuItem
            // 
            this.历史数据查询ToolStripMenuItem.Name = "历史数据查询ToolStripMenuItem";
            this.历史数据查询ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.历史数据查询ToolStripMenuItem.Text = "历史数据查询";
            this.历史数据查询ToolStripMenuItem.Click += new System.EventHandler(this.历史数据查询ToolStripMenuItem_Click);
            // 
            // 系统操作记录查询ToolStripMenuItem
            // 
            this.系统操作记录查询ToolStripMenuItem.Name = "系统操作记录查询ToolStripMenuItem";
            this.系统操作记录查询ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.系统操作记录查询ToolStripMenuItem.Text = "系统操作记录查询";
            this.系统操作记录查询ToolStripMenuItem.Click += new System.EventHandler(this.系统操作记录查询ToolStripMenuItem_Click);
            // 
            // 工程管理ToolStripMenuItem
            // 
            this.工程管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据备份ToolStripMenuItem,
            this.工程项目导入ToolStripMenuItem});
            this.工程管理ToolStripMenuItem.Name = "工程管理ToolStripMenuItem";
            this.工程管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.工程管理ToolStripMenuItem.Text = "工程管理";
            // 
            // 数据备份ToolStripMenuItem
            // 
            this.数据备份ToolStripMenuItem.Name = "数据备份ToolStripMenuItem";
            this.数据备份ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.数据备份ToolStripMenuItem.Text = "数据备份";
            // 
            // 工程项目导入ToolStripMenuItem
            // 
            this.工程项目导入ToolStripMenuItem.Name = "工程项目导入ToolStripMenuItem";
            this.工程项目导入ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.工程项目导入ToolStripMenuItem.Text = "工程项目导入";
            // 
            // 系统管理ToolStripMenuItem1
            // 
            this.系统管理ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清除记录ToolStripMenuItem,
            this.恢复出厂设置ToolStripMenuItem});
            this.系统管理ToolStripMenuItem1.Name = "系统管理ToolStripMenuItem1";
            this.系统管理ToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.系统管理ToolStripMenuItem1.Text = "系统管理";
            // 
            // 清除记录ToolStripMenuItem
            // 
            this.清除记录ToolStripMenuItem.Name = "清除记录ToolStripMenuItem";
            this.清除记录ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.清除记录ToolStripMenuItem.Text = "清除记录";
            // 
            // 恢复出厂设置ToolStripMenuItem
            // 
            this.恢复出厂设置ToolStripMenuItem.Name = "恢复出厂设置ToolStripMenuItem";
            this.恢复出厂设置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.恢复出厂设置ToolStripMenuItem.Text = "恢复出厂设置";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主机信息ToolStripMenuItem,
            this.license管理ToolStripMenuItem,
            this.关于公司ToolStripMenuItem,
            this.系统升级ToolStripMenuItem,
            this.软件版本ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 主机信息ToolStripMenuItem
            // 
            this.主机信息ToolStripMenuItem.Name = "主机信息ToolStripMenuItem";
            this.主机信息ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.主机信息ToolStripMenuItem.Text = "主机信息";
            // 
            // license管理ToolStripMenuItem
            // 
            this.license管理ToolStripMenuItem.Name = "license管理ToolStripMenuItem";
            this.license管理ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.license管理ToolStripMenuItem.Text = "License管理";
            // 
            // 关于公司ToolStripMenuItem
            // 
            this.关于公司ToolStripMenuItem.Name = "关于公司ToolStripMenuItem";
            this.关于公司ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.关于公司ToolStripMenuItem.Text = "关于公司";
            // 
            // 系统升级ToolStripMenuItem
            // 
            this.系统升级ToolStripMenuItem.Name = "系统升级ToolStripMenuItem";
            this.系统升级ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.系统升级ToolStripMenuItem.Text = "系统升级";
            // 
            // 软件版本ToolStripMenuItem
            // 
            this.软件版本ToolStripMenuItem.Name = "软件版本ToolStripMenuItem";
            this.软件版本ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.软件版本ToolStripMenuItem.Text = "软件版本";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8});
            this.toolStripStatus.Location = new System.Drawing.Point(0, 609);
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(1313, 22);
            this.toolStripStatus.TabIndex = 1;
            this.toolStripStatus.Text = "statusStrip1";
            this.toolStripStatus.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked_1);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel5.Text = "toolStripStatusLabel5";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel6.Text = "toolStripStatusLabel6";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(381, 17);
            this.toolStripStatusLabel7.Spring = true;
            this.toolStripStatusLabel7.Text = "toolStripStatusLabel7";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel8.Text = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMaintime
            // 
            this.frmMaintime.Enabled = true;
            this.frmMaintime.Interval = 5;
            this.frmMaintime.Tick += new System.EventHandler(this.frmMaintime_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1313, 631);
            this.Controls.Add(this.toolStripStatus);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ccdsnet";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripStatus.ResumeLayout(false);
            this.toolStripStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip toolStripStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripMenuItem 修改口令ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 远程管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 连接管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改用户名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 参数管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工程管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 基本设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 烟雾设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 气流设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 输入输出设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 时间设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 当前数据查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 历史数据查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统操作记录查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据备份ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工程项目导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 恢复出厂设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 主机信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem license管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于公司ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统升级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 软件版本ToolStripMenuItem;
        private System.Windows.Forms.Timer frmMaintime;
        private System.Windows.Forms.ToolStripSeparator gPRS告警ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem GPRS告警ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
    }
}