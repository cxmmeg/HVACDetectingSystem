﻿namespace HVACDetectingSystem
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem系统 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem用户切换 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem退出系统 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem设置 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem参数设置 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem型号选择 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem检测 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem自动检测 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem手动检测 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLbl_User = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLbl_Message = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLbl_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem系统,
            this.ToolStripMenuItem设置,
            this.ToolStripMenuItem检测});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1920, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem系统
            // 
            this.ToolStripMenuItem系统.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem用户切换,
            this.ToolStripMenuItem退出系统});
            this.ToolStripMenuItem系统.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToolStripMenuItem系统.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem系统.Image")));
            this.ToolStripMenuItem系统.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.ToolStripMenuItem系统.Name = "ToolStripMenuItem系统";
            this.ToolStripMenuItem系统.Size = new System.Drawing.Size(82, 31);
            this.ToolStripMenuItem系统.Text = "系统";
            // 
            // ToolStripMenuItem用户切换
            // 
            this.ToolStripMenuItem用户切换.Name = "ToolStripMenuItem用户切换";
            this.ToolStripMenuItem用户切换.Size = new System.Drawing.Size(166, 30);
            this.ToolStripMenuItem用户切换.Text = "用户切换";
            this.ToolStripMenuItem用户切换.Click += new System.EventHandler(this.ToolStripMenuItem用户切换_Click);
            // 
            // ToolStripMenuItem退出系统
            // 
            this.ToolStripMenuItem退出系统.Name = "ToolStripMenuItem退出系统";
            this.ToolStripMenuItem退出系统.Size = new System.Drawing.Size(166, 30);
            this.ToolStripMenuItem退出系统.Text = "退出系统";
            this.ToolStripMenuItem退出系统.Click += new System.EventHandler(this.ToolStripMenuItem退出系统_Click);
            // 
            // ToolStripMenuItem设置
            // 
            this.ToolStripMenuItem设置.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem参数设置,
            this.ToolStripMenuItem型号选择});
            this.ToolStripMenuItem设置.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem设置.Image")));
            this.ToolStripMenuItem设置.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.ToolStripMenuItem设置.Name = "ToolStripMenuItem设置";
            this.ToolStripMenuItem设置.Size = new System.Drawing.Size(84, 31);
            this.ToolStripMenuItem设置.Text = "设置";
            // 
            // ToolStripMenuItem参数设置
            // 
            this.ToolStripMenuItem参数设置.Name = "ToolStripMenuItem参数设置";
            this.ToolStripMenuItem参数设置.Size = new System.Drawing.Size(170, 32);
            this.ToolStripMenuItem参数设置.Text = "参数设置";
            this.ToolStripMenuItem参数设置.Click += new System.EventHandler(this.ToolStripMenuItem参数设置_Click);
            // 
            // ToolStripMenuItem型号选择
            // 
            this.ToolStripMenuItem型号选择.Name = "ToolStripMenuItem型号选择";
            this.ToolStripMenuItem型号选择.Size = new System.Drawing.Size(170, 32);
            this.ToolStripMenuItem型号选择.Text = "型号选择";
            this.ToolStripMenuItem型号选择.Click += new System.EventHandler(this.ToolStripMenuItem型号选择_Click);
            // 
            // ToolStripMenuItem检测
            // 
            this.ToolStripMenuItem检测.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem自动检测,
            this.ToolStripMenuItem手动检测});
            this.ToolStripMenuItem检测.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem检测.Image")));
            this.ToolStripMenuItem检测.Name = "ToolStripMenuItem检测";
            this.ToolStripMenuItem检测.Size = new System.Drawing.Size(84, 31);
            this.ToolStripMenuItem检测.Text = "检测";
            // 
            // ToolStripMenuItem自动检测
            // 
            this.ToolStripMenuItem自动检测.Name = "ToolStripMenuItem自动检测";
            this.ToolStripMenuItem自动检测.Size = new System.Drawing.Size(170, 32);
            this.ToolStripMenuItem自动检测.Text = "自动检测";
            this.ToolStripMenuItem自动检测.Click += new System.EventHandler(this.ToolStripMenuItem自动检测_Click);
            // 
            // ToolStripMenuItem手动检测
            // 
            this.ToolStripMenuItem手动检测.Name = "ToolStripMenuItem手动检测";
            this.ToolStripMenuItem手动检测.Size = new System.Drawing.Size(170, 32);
            this.ToolStripMenuItem手动检测.Text = "手动检测";
            this.ToolStripMenuItem手动检测.Click += new System.EventHandler(this.ToolStripMenuItem手动检测_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 35);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1920, 1016);
            this.splitContainer1.SplitterDistance = 946;
            this.splitContainer1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLbl_User,
            this.toolStripStatusLbl_Message,
            this.toolStripStatusLbl_Time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1920, 66);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLbl_User
            // 
            this.toolStripStatusLbl_User.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLbl_User.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLbl_User.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLbl_User.Image")));
            this.toolStripStatusLbl_User.Name = "toolStripStatusLbl_User";
            this.toolStripStatusLbl_User.Size = new System.Drawing.Size(180, 61);
            this.toolStripStatusLbl_User.Text = " 登陆用户:未登陆";
            this.toolStripStatusLbl_User.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // toolStripStatusLbl_Message
            // 
            this.toolStripStatusLbl_Message.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLbl_Message.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLbl_Message.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLbl_Message.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStatusLbl_Message.Name = "toolStripStatusLbl_Message";
            this.toolStripStatusLbl_Message.Size = new System.Drawing.Size(1454, 61);
            this.toolStripStatusLbl_Message.Spring = true;
            this.toolStripStatusLbl_Message.Text = "消息框";
            // 
            // toolStripStatusLbl_Time
            // 
            this.toolStripStatusLbl_Time.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLbl_Time.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLbl_Time.Name = "toolStripStatusLbl_Time";
            this.toolStripStatusLbl_Time.Size = new System.Drawing.Size(232, 61);
            this.toolStripStatusLbl_Time.Text = "时间：2019/06/20 22:31";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "空调检测系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem系统;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem用户切换;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem退出系统;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem设置;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem参数设置;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbl_User;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbl_Message;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbl_Time;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem型号选择;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem检测;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem自动检测;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem手动检测;
    }
}

