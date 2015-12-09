namespace 原型设计
{
    partial class MemberForm
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
            this.btnDistill = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lalNname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgvMemberInformation = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.labChoice = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboStyle = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberInformation)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDistill
            // 
            this.btnDistill.Location = new System.Drawing.Point(329, 45);
            this.btnDistill.Name = "btnDistill";
            this.btnDistill.Size = new System.Drawing.Size(75, 23);
            this.btnDistill.TabIndex = 27;
            this.btnDistill.Text = "抽奖";
            this.btnDistill.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(317, 235);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lalNname
            // 
            this.lalNname.AutoSize = true;
            this.lalNname.Location = new System.Drawing.Point(134, 48);
            this.lalNname.Name = "lalNname";
            this.lalNname.Size = new System.Drawing.Size(113, 12);
            this.lalNname.TabIndex = 26;
            this.lalNname.Text = "获得本周幸运会员！";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "尊敬的";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(68, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(60, 21);
            this.txtName.TabIndex = 24;
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
            this.dgvMemberInformation.Location = new System.Drawing.Point(12, 72);
            this.dgvMemberInformation.Name = "dgvMemberInformation";
            this.dgvMemberInformation.ReadOnly = true;
            this.dgvMemberInformation.RowHeadersVisible = false;
            this.dgvMemberInformation.RowTemplate.Height = 23;
            this.dgvMemberInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberInformation.Size = new System.Drawing.Size(406, 157);
            this.dgvMemberInformation.TabIndex = 21;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(98, 22);
            this.tsmiDelete.Text = "删除";
            // 
            // labChoice
            // 
            this.labChoice.AutoSize = true;
            this.labChoice.Location = new System.Drawing.Point(21, 19);
            this.labChoice.Name = "labChoice";
            this.labChoice.Size = new System.Drawing.Size(77, 12);
            this.labChoice.TabIndex = 17;
            this.labChoice.Text = "请选择类型：";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(249, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cboStyle
            // 
            this.cboStyle.FormattingEnabled = true;
            this.cboStyle.Location = new System.Drawing.Point(104, 16);
            this.cboStyle.Name = "cboStyle";
            this.cboStyle.Size = new System.Drawing.Size(116, 20);
            this.cboStyle.TabIndex = 20;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(236, 235);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 23;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(330, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.cboStyle);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnRefresh);
            this.Name = "MemberForm";
            this.Text = "会员信息";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberInformation)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDistill;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lalNname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgvMemberInformation;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.Label labChoice;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboStyle;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnRefresh;
    }
}