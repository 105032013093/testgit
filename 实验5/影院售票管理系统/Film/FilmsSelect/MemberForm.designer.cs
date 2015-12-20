namespace FilmsSelect
{
    partial class MemberForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberForm));
            this.labChoice = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboStyle = new System.Windows.Forms.ComboBox();
            this.dgvMemberInformation = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lalNname = new System.Windows.Forms.Label();
            this.btnDistill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberInformation)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labChoice
            // 
            this.labChoice.AutoSize = true;
            this.labChoice.Location = new System.Drawing.Point(21, 23);
            this.labChoice.Name = "labChoice";
            this.labChoice.Size = new System.Drawing.Size(77, 12);
            this.labChoice.TabIndex = 0;
            this.labChoice.Text = "请选择类型：";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(249, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboStyle
            // 
            this.cboStyle.FormattingEnabled = true;
            this.cboStyle.Location = new System.Drawing.Point(104, 20);
            this.cboStyle.Name = "cboStyle";
            this.cboStyle.Size = new System.Drawing.Size(116, 20);
            this.cboStyle.TabIndex = 4;
            // 
            // dgvMemberInformation
            // 
            this.dgvMemberInformation.AllowUserToAddRows = false;
            this.dgvMemberInformation.AllowUserToResizeColumns = false;
            this.dgvMemberInformation.AllowUserToResizeRows = false;
            this.dgvMemberInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMemberInformation.BackgroundColor = System.Drawing.Color.White;
            this.dgvMemberInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberInformation.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvMemberInformation.Location = new System.Drawing.Point(12, 76);
            this.dgvMemberInformation.Name = "dgvMemberInformation";
            this.dgvMemberInformation.ReadOnly = true;
            this.dgvMemberInformation.RowHeadersVisible = false;
            this.dgvMemberInformation.RowTemplate.Height = 23;
            this.dgvMemberInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberInformation.Size = new System.Drawing.Size(406, 157);
            this.dgvMemberInformation.TabIndex = 6;
            this.dgvMemberInformation.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberInformation_CellMouseLeave);
            this.dgvMemberInformation.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMemberInformation_CellMouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(100, 22);
            this.tsmiDelete.Text = "删除";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(330, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(236, 239);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(317, 239);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(68, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(60, 21);
            this.txtName.TabIndex = 13;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "尊敬的";
            // 
            // lalNname
            // 
            this.lalNname.AutoSize = true;
            this.lalNname.Location = new System.Drawing.Point(134, 52);
            this.lalNname.Name = "lalNname";
            this.lalNname.Size = new System.Drawing.Size(113, 12);
            this.lalNname.TabIndex = 15;
            this.lalNname.Text = "获得本周幸运会员！";
            // 
            // btnDistill
            // 
            this.btnDistill.Location = new System.Drawing.Point(329, 49);
            this.btnDistill.Name = "btnDistill";
            this.btnDistill.Size = new System.Drawing.Size(75, 23);
            this.btnDistill.TabIndex = 16;
            this.btnDistill.Text = "抽奖";
            this.btnDistill.UseVisualStyleBackColor = true;
            this.btnDistill.Click += new System.EventHandler(this.btnDistill_Click);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 274);
            this.Controls.Add(this.btnDistill);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lalNname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvMemberInformation);
            this.Controls.Add(this.labChoice);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cboStyle);
            this.Controls.Add(this.btnRegister);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员信息";
            this.Load += new System.EventHandler(this.MemberInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberInformation)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labChoice;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboStyle;
        private System.Windows.Forms.DataGridView dgvMemberInformation;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lalNname;
        private System.Windows.Forms.Button btnDistill;
    }
}