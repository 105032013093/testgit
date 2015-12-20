namespace FilmsSelect
{
    partial class SearchTicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchTicketForm));
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRearch = new System.Windows.Forms.Button();
            this.grpFilms = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.grpFilms.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTicket
            // 
            this.dgvTicket.AllowUserToAddRows = false;
            this.dgvTicket.AllowUserToDeleteRows = false;
            this.dgvTicket.AllowUserToResizeColumns = false;
            this.dgvTicket.AllowUserToResizeRows = false;
            this.dgvTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTicket.BackgroundColor = System.Drawing.Color.White;
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Location = new System.Drawing.Point(1, 12);
            this.dgvTicket.MultiSelect = false;
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.ReadOnly = true;
            this.dgvTicket.RowHeadersVisible = false;
            this.dgvTicket.RowTemplate.Height = 23;
            this.dgvTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTicket.Size = new System.Drawing.Size(619, 196);
            this.dgvTicket.TabIndex = 0;
            this.dgvTicket.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicket_CellMouseLeave);
            this.dgvTicket.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTicket_CellMouseMove);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(410, 35);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRearch
            // 
            this.btnRearch.Location = new System.Drawing.Point(183, 35);
            this.btnRearch.Name = "btnRearch";
            this.btnRearch.Size = new System.Drawing.Size(75, 23);
            this.btnRearch.TabIndex = 5;
            this.btnRearch.Text = "查找";
            this.btnRearch.UseVisualStyleBackColor = true;
            this.btnRearch.Click += new System.EventHandler(this.btnRearch_Click);
            // 
            // grpFilms
            // 
            this.grpFilms.Controls.Add(this.dateTimePicker);
            this.grpFilms.Controls.Add(this.btnReturn);
            this.grpFilms.Controls.Add(this.btnRefresh);
            this.grpFilms.Controls.Add(this.btnRearch);
            this.grpFilms.Location = new System.Drawing.Point(12, 214);
            this.grpFilms.Name = "grpFilms";
            this.grpFilms.Size = new System.Drawing.Size(601, 78);
            this.grpFilms.TabIndex = 6;
            this.grpFilms.TabStop = false;
            this.grpFilms.Text = "按时间查询订票信息";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(36, 35);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(115, 21);
            this.dateTimePicker.TabIndex = 7;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(508, 35);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // SearchTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(620, 303);
            this.Controls.Add(this.dgvTicket);
            this.Controls.Add(this.grpFilms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchTicketForm";
            this.Text = "查询订票";
            this.Load += new System.EventHandler(this.SearchTicketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.grpFilms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTicket;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRearch;
        private System.Windows.Forms.GroupBox grpFilms;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}