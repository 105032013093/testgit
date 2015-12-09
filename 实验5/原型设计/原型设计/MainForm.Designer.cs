namespace 原型设计
{
    partial class MainForm
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
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiManageMent,
            this.tsmiTickets,
            this.tsmiMember,
            this.tsmiExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 1;
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
            this.tsmiManageMent.Size = new System.Drawing.Size(67, 20);
            this.tsmiManageMent.Text = "影片管理";
            // 
            // tsmiFilms
            // 
            this.tsmiFilms.Name = "tsmiFilms";
            this.tsmiFilms.Size = new System.Drawing.Size(152, 22);
            this.tsmiFilms.Text = "影片信息";
            this.tsmiFilms.Click += new System.EventHandler(this.tsmiFilms_Click);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(152, 22);
            this.tsmiAdd.Text = "影片增加";
            this.tsmiAdd.Click += new System.EventHandler(this.tsmiAdd_Click);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(152, 22);
            this.tsmiUpdate.Text = "修改影片";
            this.tsmiUpdate.Click += new System.EventHandler(this.tsmiUpdate_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(152, 22);
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
            this.tsmiTickets.Size = new System.Drawing.Size(67, 20);
            this.tsmiTickets.Text = "售票管理";
            // 
            // tsmiOrder
            // 
            this.tsmiOrder.Name = "tsmiOrder";
            this.tsmiOrder.Size = new System.Drawing.Size(152, 22);
            this.tsmiOrder.Text = "订票";
            this.tsmiOrder.Click += new System.EventHandler(this.tsmiOrder_Click);
            // 
            // tsmiSearch
            // 
            this.tsmiSearch.Name = "tsmiSearch";
            this.tsmiSearch.Size = new System.Drawing.Size(152, 22);
            this.tsmiSearch.Text = "订票查询";
            this.tsmiSearch.Click += new System.EventHandler(this.tsmiSearch_Click);
            // 
            // tsmiMoney
            // 
            this.tsmiMoney.Name = "tsmiMoney";
            this.tsmiMoney.Size = new System.Drawing.Size(152, 22);
            this.tsmiMoney.Text = "钱箱查询";
            this.tsmiMoney.Click += new System.EventHandler(this.tsmiMoney_Click);
            // 
            // tsmiMember
            // 
            this.tsmiMember.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMemberInfor,
            this.tsmiRegister});
            this.tsmiMember.Name = "tsmiMember";
            this.tsmiMember.Size = new System.Drawing.Size(67, 20);
            this.tsmiMember.Text = "会员管理";
            // 
            // tsmiMemberInfor
            // 
            this.tsmiMemberInfor.Name = "tsmiMemberInfor";
            this.tsmiMemberInfor.Size = new System.Drawing.Size(152, 22);
            this.tsmiMemberInfor.Text = "会员信息查询";
            this.tsmiMemberInfor.Click += new System.EventHandler(this.tsmiMemberInfor_Click);
            // 
            // tsmiRegister
            // 
            this.tsmiRegister.Name = "tsmiRegister";
            this.tsmiRegister.Size = new System.Drawing.Size(152, 22);
            this.tsmiRegister.Text = "会员注册";
            this.tsmiRegister.Click += new System.EventHandler(this.tsmiRegister_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(43, 20);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 307);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "影院管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageMent;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilms;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiTickets;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoney;
        private System.Windows.Forms.ToolStripMenuItem tsmiMember;
        private System.Windows.Forms.ToolStripMenuItem tsmiMemberInfor;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegister;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
    }
}