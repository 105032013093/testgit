namespace FilmsSelect
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiManageMent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilms = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTickets = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoney = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMember = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMemberInfor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTicketSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilmsSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsmiLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnUptade = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnOder = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiManageMent,
            this.tsmiTickets,
            this.tsmiMember,
            this.tsmiAbout,
            this.tsmiExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiManageMent
            // 
            this.tsmiManageMent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFilms,
            this.tsmiAdd,
            this.tsmiUpdate,
            this.tsmiDelete});
            this.tsmiManageMent.Name = "tsmiManageMent";
            this.tsmiManageMent.Size = new System.Drawing.Size(68, 21);
            this.tsmiManageMent.Text = "影片管理";
            // 
            // tsmiFilms
            // 
            this.tsmiFilms.Name = "tsmiFilms";
            this.tsmiFilms.Size = new System.Drawing.Size(124, 22);
            this.tsmiFilms.Text = "影片信息";
            this.tsmiFilms.Click += new System.EventHandler(this.tsmiFilms_Click);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(124, 22);
            this.tsmiAdd.Text = "影片增加";
            this.tsmiAdd.Click += new System.EventHandler(this.tsmiAdd_Click);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(124, 22);
            this.tsmiUpdate.Text = "修改影片";
            this.tsmiUpdate.Click += new System.EventHandler(this.tsmiUpdate_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(124, 22);
            this.tsmiDelete.Text = "删除影片";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tsmiTickets
            // 
            this.tsmiTickets.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOrder,
            this.tsmiSearch,
            this.tsmiMoney});
            this.tsmiTickets.Name = "tsmiTickets";
            this.tsmiTickets.Size = new System.Drawing.Size(68, 21);
            this.tsmiTickets.Text = "售票管理";
            // 
            // tsmiOrder
            // 
            this.tsmiOrder.Name = "tsmiOrder";
            this.tsmiOrder.Size = new System.Drawing.Size(124, 22);
            this.tsmiOrder.Text = "订票";
            this.tsmiOrder.Click += new System.EventHandler(this.tsmiOrder_Click);
            // 
            // tsmiSearch
            // 
            this.tsmiSearch.Name = "tsmiSearch";
            this.tsmiSearch.Size = new System.Drawing.Size(124, 22);
            this.tsmiSearch.Text = "订票查询";
            this.tsmiSearch.Click += new System.EventHandler(this.tsmiSearch_Click);
            // 
            // tsmiMoney
            // 
            this.tsmiMoney.Name = "tsmiMoney";
            this.tsmiMoney.Size = new System.Drawing.Size(124, 22);
            this.tsmiMoney.Text = "钱箱查询";
            this.tsmiMoney.Click += new System.EventHandler(this.tsmiMoney_Click);
            // 
            // tsmiMember
            // 
            this.tsmiMember.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMemberInfor,
            this.tsmiRegister});
            this.tsmiMember.Name = "tsmiMember";
            this.tsmiMember.Size = new System.Drawing.Size(68, 21);
            this.tsmiMember.Text = "会员管理";
            // 
            // tsmiMemberInfor
            // 
            this.tsmiMemberInfor.Name = "tsmiMemberInfor";
            this.tsmiMemberInfor.Size = new System.Drawing.Size(148, 22);
            this.tsmiMemberInfor.Text = "会员信息查询";
            this.tsmiMemberInfor.Click += new System.EventHandler(this.tsmiMemberInfor_Click);
            // 
            // tsmiRegister
            // 
            this.tsmiRegister.Name = "tsmiRegister";
            this.tsmiRegister.Size = new System.Drawing.Size(148, 22);
            this.tsmiRegister.Text = "会员注册";
            this.tsmiRegister.Click += new System.EventHandler(this.tsmiRegister_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(44, 21);
            this.tsmiAbout.Text = "关于";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(44, 21);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiTicketSetup
            // 
            this.tsmiTicketSetup.Name = "tsmiTicketSetup";
            this.tsmiTicketSetup.Size = new System.Drawing.Size(152, 22);
            this.tsmiTicketSetup.Text = "票类设置";
            // 
            // tsmiFilmsSetup
            // 
            this.tsmiFilmsSetup.Name = "tsmiFilmsSetup";
            this.tsmiFilmsSetup.Size = new System.Drawing.Size(152, 22);
            this.tsmiFilmsSetup.Text = "影片设置";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLogin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 617);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(996, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsmiLogin
            // 
            this.tsmiLogin.Name = "tsmiLogin";
            this.tsmiLogin.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.toolStripSeparator1,
            this.tsbtnSearch,
            this.toolStripSeparator2,
            this.tsbtnUptade,
            this.toolStripSeparator3,
            this.tsbtnOder});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(996, 55);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAdd.Image")));
            this.tsbtnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(112, 52);
            this.tsbtnAdd.Text = "增加电影 ";
            this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // tsbtnSearch
            // 
            this.tsbtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSearch.Image")));
            this.tsbtnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearch.Name = "tsbtnSearch";
            this.tsbtnSearch.Size = new System.Drawing.Size(112, 52);
            this.tsbtnSearch.Text = "查询电影 ";
            this.tsbtnSearch.Click += new System.EventHandler(this.tsbtnSearch_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // tsbtnUptade
            // 
            this.tsbtnUptade.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUptade.Image")));
            this.tsbtnUptade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnUptade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUptade.Name = "tsbtnUptade";
            this.tsbtnUptade.Size = new System.Drawing.Size(112, 52);
            this.tsbtnUptade.Text = "修改电影 ";
            this.tsbtnUptade.Click += new System.EventHandler(this.tsbtnUptade_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // tsbtnOder
            // 
            this.tsbtnOder.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnOder.Image")));
            this.tsbtnOder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnOder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOder.Name = "tsbtnOder";
            this.tsbtnOder.Size = new System.Drawing.Size(108, 52);
            this.tsbtnOder.Text = "订票查询";
            this.tsbtnOder.Click += new System.EventHandler(this.tsbtnOder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(996, 639);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "影院管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageMent;
        private System.Windows.Forms.ToolStripMenuItem tsmiTicketSetup;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilmsSetup;
        private System.Windows.Forms.ToolStripMenuItem tsmiTickets;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilms;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoney;
        private System.Windows.Forms.ToolStripMenuItem tsmiMember;
        private System.Windows.Forms.ToolStripMenuItem tsmiMemberInfor;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegister;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnUptade;
        private System.Windows.Forms.ToolStripButton tsbtnOder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrder;
        private System.Windows.Forms.ToolStripStatusLabel tsmiLogin;
    }
}