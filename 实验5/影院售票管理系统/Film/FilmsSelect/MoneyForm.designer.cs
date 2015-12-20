namespace FilmsSelect
{ 
    partial class MoneyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoneyForm));
            this.dgvMoney = new System.Windows.Forms.DataGridView();
            this.btnMoney = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.grpMoney = new System.Windows.Forms.GroupBox();
            this.txtMoney1 = new System.Windows.Forms.TextBox();
            this.btnColse = new System.Windows.Forms.Button();
            this.grpMoney1 = new System.Windows.Forms.GroupBox();
            this.grptime = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoney)).BeginInit();
            this.grpMoney.SuspendLayout();
            this.grpMoney1.SuspendLayout();
            this.grptime.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMoney
            // 
            this.dgvMoney.AllowUserToAddRows = false;
            this.dgvMoney.AllowUserToDeleteRows = false;
            this.dgvMoney.AllowUserToResizeColumns = false;
            this.dgvMoney.AllowUserToResizeRows = false;
            this.dgvMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMoney.BackgroundColor = System.Drawing.Color.White;
            this.dgvMoney.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoney.Location = new System.Drawing.Point(12, 19);
            this.dgvMoney.MultiSelect = false;
            this.dgvMoney.Name = "dgvMoney";
            this.dgvMoney.ReadOnly = true;
            this.dgvMoney.RowHeadersVisible = false;
            this.dgvMoney.RowTemplate.Height = 23;
            this.dgvMoney.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMoney.Size = new System.Drawing.Size(503, 153);
            this.dgvMoney.TabIndex = 0;
            this.dgvMoney.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMoney_CellClick);
            this.dgvMoney.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMoney_CellMouseLeave);
            this.dgvMoney.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMoney_CellMouseMove);
            // 
            // btnMoney
            // 
            this.btnMoney.Location = new System.Drawing.Point(454, 225);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(68, 23);
            this.btnMoney.TabIndex = 1;
            this.btnMoney.Text = "搜索";
            this.btnMoney.UseVisualStyleBackColor = true;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(21, 20);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(116, 21);
            this.dateTimePicker.TabIndex = 2;
            // 
            // grpMoney
            // 
            this.grpMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMoney.Controls.Add(this.dgvMoney);
            this.grpMoney.Location = new System.Drawing.Point(7, 2);
            this.grpMoney.Name = "grpMoney";
            this.grpMoney.Size = new System.Drawing.Size(531, 185);
            this.grpMoney.TabIndex = 4;
            this.grpMoney.TabStop = false;
            this.grpMoney.Text = "钱箱";
            // 
            // txtMoney1
            // 
            this.txtMoney1.Location = new System.Drawing.Point(33, 27);
            this.txtMoney1.Name = "txtMoney1";
            this.txtMoney1.ReadOnly = true;
            this.txtMoney1.Size = new System.Drawing.Size(100, 21);
            this.txtMoney1.TabIndex = 6;
            // 
            // btnColse
            // 
            this.btnColse.Location = new System.Drawing.Point(454, 254);
            this.btnColse.Name = "btnColse";
            this.btnColse.Size = new System.Drawing.Size(68, 23);
            this.btnColse.TabIndex = 7;
            this.btnColse.Text = "退出";
            this.btnColse.UseVisualStyleBackColor = true;
            this.btnColse.Click += new System.EventHandler(this.btnColse_Click);
            // 
            // grpMoney1
            // 
            this.grpMoney1.Controls.Add(this.txtMoney1);
            this.grpMoney1.Location = new System.Drawing.Point(215, 213);
            this.grpMoney1.Name = "grpMoney1";
            this.grpMoney1.Size = new System.Drawing.Size(167, 64);
            this.grpMoney1.TabIndex = 5;
            this.grpMoney1.TabStop = false;
            this.grpMoney1.Text = "钱箱钱数";
            // 
            // grptime
            // 
            this.grptime.Controls.Add(this.dateTimePicker);
            this.grptime.Location = new System.Drawing.Point(12, 213);
            this.grptime.Name = "grptime";
            this.grptime.Size = new System.Drawing.Size(167, 64);
            this.grptime.TabIndex = 3;
            this.grptime.TabStop = false;
            this.grptime.Text = "按时间查询钱箱";
            // 
            // MoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 301);
            this.Controls.Add(this.btnColse);
            this.Controls.Add(this.grpMoney1);
            this.Controls.Add(this.grpMoney);
            this.Controls.Add(this.grptime);
            this.Controls.Add(this.btnMoney);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MoneyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "钱箱";
            this.Load += new System.EventHandler(this.MnyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoney)).EndInit();
            this.grpMoney.ResumeLayout(false);
            this.grpMoney1.ResumeLayout(false);
            this.grpMoney1.PerformLayout();
            this.grptime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMoney;
        private System.Windows.Forms.Button btnMoney;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.GroupBox grpMoney;
        private System.Windows.Forms.TextBox txtMoney1;
        private System.Windows.Forms.Button btnColse;
        private System.Windows.Forms.GroupBox grpMoney1;
        private System.Windows.Forms.GroupBox grptime;
    }
}