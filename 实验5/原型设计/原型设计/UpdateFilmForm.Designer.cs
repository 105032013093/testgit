namespace 原型设计
{
    partial class UpdateFilmForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtHall = new System.Windows.Forms.TextBox();
            this.dgvFilm = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TsmiSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiDelect = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblContent = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblName = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.lbllanguage = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDirect = new System.Windows.Forms.TextBox();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblDirect = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.lblHall = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilm)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHall
            // 
            this.txtHall.Location = new System.Drawing.Point(242, 46);
            this.txtHall.Name = "txtHall";
            this.txtHall.ReadOnly = true;
            this.txtHall.Size = new System.Drawing.Size(100, 21);
            this.txtHall.TabIndex = 23;
            // 
            // dgvFilm
            // 
            this.dgvFilm.AllowUserToAddRows = false;
            this.dgvFilm.AllowUserToResizeColumns = false;
            this.dgvFilm.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFilm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFilm.BackgroundColor = System.Drawing.Color.White;
            this.dgvFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilm.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvFilm.Location = new System.Drawing.Point(-5, -3);
            this.dgvFilm.MultiSelect = false;
            this.dgvFilm.Name = "dgvFilm";
            this.dgvFilm.ReadOnly = true;
            this.dgvFilm.RowHeadersVisible = false;
            this.dgvFilm.RowTemplate.Height = 23;
            this.dgvFilm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilm.Size = new System.Drawing.Size(753, 208);
            this.dgvFilm.TabIndex = 32;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiSelect,
            this.tmsiDelect});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 48);
            // 
            // TsmiSelect
            // 
            this.TsmiSelect.Name = "TsmiSelect";
            this.TsmiSelect.Size = new System.Drawing.Size(122, 22);
            this.TsmiSelect.Text = "查看海报";
            // 
            // tmsiDelect
            // 
            this.tmsiDelect.Name = "tmsiDelect";
            this.tmsiDelect.Size = new System.Drawing.Size(122, 22);
            this.tmsiDelect.Text = "删除";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(77, 16);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(100, 21);
            this.txtMoney.TabIndex = 14;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(14, 49);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 12);
            this.lblTime.TabIndex = 24;
            this.lblTime.Text = "放映时间";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(38, 19);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(29, 12);
            this.lblMoney.TabIndex = 17;
            this.lblMoney.Text = "价格";
            // 
            // cboTime
            // 
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Location = new System.Drawing.Point(77, 46);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(100, 20);
            this.cboTime.TabIndex = 18;
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(242, 16);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(100, 21);
            this.txtHour.TabIndex = 25;
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(183, 19);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(53, 12);
            this.lblHour.TabIndex = 20;
            this.lblHour.Text = "电影片长";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(14, 81);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 12);
            this.lblDate.TabIndex = 29;
            this.lblDate.Text = "放映日期";
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Location = new System.Drawing.Point(9, 363);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(53, 12);
            this.lblSelectDate.TabIndex = 41;
            this.lblSelectDate.Text = "日期查询";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(240, 81);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(77, 12);
            this.lblMinute.TabIndex = 26;
            this.lblMinute.Text = "(单位：分钟)";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 359);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 21);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(477, 359);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 40;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(384, 214);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(29, 12);
            this.lblContent.TabIndex = 39;
            this.lblContent.Text = "简介";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(77, 77);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(139, 21);
            this.dateTimePicker.TabIndex = 19;
            this.dateTimePicker.Value = new System.DateTime(2008, 12, 11, 0, 0, 0, 0);
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtContent.Location = new System.Drawing.Point(386, 235);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(349, 117);
            this.txtContent.TabIndex = 38;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Controls.Add(this.txtLanguage);
            this.tabPage1.Controls.Add(this.lbllanguage);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.txtDirect);
            this.tabPage1.Controls.Add(this.lblMain);
            this.tabPage1.Controls.Add(this.lblDirect);
            this.tabPage1.Controls.Add(this.lblType);
            this.tabPage1.Controls.Add(this.cboType);
            this.tabPage1.Controls.Add(this.txtMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(348, 112);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "电影内容";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "电影名称";
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(227, 46);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(100, 21);
            this.txtLanguage.TabIndex = 22;
            // 
            // lbllanguage
            // 
            this.lbllanguage.AutoSize = true;
            this.lbllanguage.Location = new System.Drawing.Point(192, 49);
            this.lbllanguage.Name = "lbllanguage";
            this.lbllanguage.Size = new System.Drawing.Size(29, 12);
            this.lbllanguage.TabIndex = 20;
            this.lbllanguage.Text = "语言";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(76, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 16;
            // 
            // txtDirect
            // 
            this.txtDirect.Location = new System.Drawing.Point(227, 11);
            this.txtDirect.Name = "txtDirect";
            this.txtDirect.Size = new System.Drawing.Size(100, 21);
            this.txtDirect.TabIndex = 21;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(17, 84);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(29, 12);
            this.lblMain.TabIndex = 18;
            this.lblMain.Text = "主演";
            // 
            // lblDirect
            // 
            this.lblDirect.AutoSize = true;
            this.lblDirect.Location = new System.Drawing.Point(192, 14);
            this.lblDirect.Name = "lblDirect";
            this.lblDirect.Size = new System.Drawing.Size(29, 12);
            this.lblDirect.TabIndex = 25;
            this.lblDirect.Text = "导演";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(17, 49);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(53, 12);
            this.lblType.TabIndex = 23;
            this.lblType.Text = "电影类型";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(76, 46);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(100, 20);
            this.cboType.TabIndex = 17;
            // 
            // txtMain
            // 
            this.txtMain.Location = new System.Drawing.Point(76, 81);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(251, 21);
            this.txtMain.TabIndex = 19;
            // 
            // lblHall
            // 
            this.lblHall.AutoSize = true;
            this.lblHall.Location = new System.Drawing.Point(183, 49);
            this.lblHall.Name = "lblHall";
            this.lblHall.Size = new System.Drawing.Size(53, 12);
            this.lblHall.TabIndex = 21;
            this.lblHall.Text = "放映大厅";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 214);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(356, 138);
            this.tabControl1.TabIndex = 36;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtHall);
            this.tabPage2.Controls.Add(this.txtMoney);
            this.tabPage2.Controls.Add(this.lblTime);
            this.tabPage2.Controls.Add(this.lblMoney);
            this.tabPage2.Controls.Add(this.cboTime);
            this.tabPage2.Controls.Add(this.txtHour);
            this.tabPage2.Controls.Add(this.lblHour);
            this.tabPage2.Controls.Add(this.lblDate);
            this.tabPage2.Controls.Add(this.lblMinute);
            this.tabPage2.Controls.Add(this.dateTimePicker);
            this.tabPage2.Controls.Add(this.lblHall);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(348, 112);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "特殊信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDelect
            // 
            this.btnDelect.Location = new System.Drawing.Point(558, 359);
            this.btnDelect.Name = "btnDelect";
            this.btnDelect.Size = new System.Drawing.Size(75, 23);
            this.btnDelect.TabIndex = 34;
            this.btnDelect.Text = "删除";
            this.btnDelect.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(639, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(396, 359);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "保存修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(238, 359);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 42;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // UpdateFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 397);
            this.Controls.Add(this.dgvFilm);
            this.Controls.Add(this.lblSelectDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnDelect);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSelect);
            this.Name = "UpdateFilmForm";
            this.Text = "电影修改";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilm)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHall;
        private System.Windows.Forms.DataGridView dgvFilm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsmiSelect;
        private System.Windows.Forms.ToolStripMenuItem tmsiDelect;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Label lbllanguage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDirect;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblDirect;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.Label lblHall;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDelect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSelect;
    }
}