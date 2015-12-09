namespace 原型设计
{
    partial class MoneyForm
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
            this.grpMoney1 = new System.Windows.Forms.GroupBox();
            this.txtMoney1 = new System.Windows.Forms.TextBox();
            this.grpMoney = new System.Windows.Forms.GroupBox();
            this.dgvMoney = new System.Windows.Forms.DataGridView();
            this.btnColse = new System.Windows.Forms.Button();
            this.grptime = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnMoney = new System.Windows.Forms.Button();
            this.grpMoney1.SuspendLayout();
            this.grpMoney.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoney)).BeginInit();
            this.grptime.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMoney1
            // 
            this.grpMoney1.Controls.Add(this.txtMoney1);
            this.grpMoney1.Location = new System.Drawing.Point(218, 224);
            this.grpMoney1.Name = "grpMoney1";
            this.grpMoney1.Size = new System.Drawing.Size(167, 64);
            this.grpMoney1.TabIndex = 11;
            this.grpMoney1.TabStop = false;
            this.grpMoney1.Text = "钱箱钱数";
            // 
            // txtMoney1
            // 
            this.txtMoney1.Location = new System.Drawing.Point(33, 27);
            this.txtMoney1.Name = "txtMoney1";
            this.txtMoney1.ReadOnly = true;
            this.txtMoney1.Size = new System.Drawing.Size(100, 21);
            this.txtMoney1.TabIndex = 6;
            // 
            // grpMoney
            // 
            this.grpMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMoney.Controls.Add(this.dgvMoney);
            this.grpMoney.Location = new System.Drawing.Point(10, 13);
            this.grpMoney.Name = "grpMoney";
            this.grpMoney.Size = new System.Drawing.Size(531, 185);
            this.grpMoney.TabIndex = 10;
            this.grpMoney.TabStop = false;
            this.grpMoney.Text = "钱箱";
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
            // 
            // btnColse
            // 
            this.btnColse.Location = new System.Drawing.Point(457, 265);
            this.btnColse.Name = "btnColse";
            this.btnColse.Size = new System.Drawing.Size(68, 23);
            this.btnColse.TabIndex = 12;
            this.btnColse.Text = "退出";
            this.btnColse.UseVisualStyleBackColor = true;
            this.btnColse.Click += new System.EventHandler(this.btnColse_Click);
            // 
            // grptime
            // 
            this.grptime.Controls.Add(this.dateTimePicker);
            this.grptime.Location = new System.Drawing.Point(15, 224);
            this.grptime.Name = "grptime";
            this.grptime.Size = new System.Drawing.Size(167, 64);
            this.grptime.TabIndex = 9;
            this.grptime.TabStop = false;
            this.grptime.Text = "按时间查询钱箱";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(21, 20);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(116, 21);
            this.dateTimePicker.TabIndex = 2;
            // 
            // btnMoney
            // 
            this.btnMoney.Location = new System.Drawing.Point(457, 236);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(68, 23);
            this.btnMoney.TabIndex = 8;
            this.btnMoney.Text = "搜索";
            this.btnMoney.UseVisualStyleBackColor = true;
            // 
            // MoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 301);
            this.Controls.Add(this.grpMoney1);
            this.Controls.Add(this.grpMoney);
            this.Controls.Add(this.btnColse);
            this.Controls.Add(this.grptime);
            this.Controls.Add(this.btnMoney);
            this.Name = "MoneyForm";
            this.Text = "钱箱";
            this.grpMoney1.ResumeLayout(false);
            this.grpMoney1.PerformLayout();
            this.grpMoney.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoney)).EndInit();
            this.grptime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMoney1;
        private System.Windows.Forms.TextBox txtMoney1;
        private System.Windows.Forms.GroupBox grpMoney;
        private System.Windows.Forms.DataGridView dgvMoney;
        private System.Windows.Forms.Button btnColse;
        private System.Windows.Forms.GroupBox grptime;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnMoney;
    }
}