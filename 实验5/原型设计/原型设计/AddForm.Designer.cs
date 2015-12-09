namespace 原型设计
{
    partial class AddForm
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
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHall = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtHall = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblCue = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblName = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.lbllanguage = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtDirect = new System.Windows.Forms.TextBox();
            this.lblDirect = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.grpPicture = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.grpPicture.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboTime
            // 
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Location = new System.Drawing.Point(106, 138);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(100, 20);
            this.cboTime.TabIndex = 4;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(106, 97);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(100, 21);
            this.txtNumber.TabIndex = 3;
            this.txtNumber.Text = "1~300";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(225, 263);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(77, 12);
            this.lblMinute.TabIndex = 7;
            this.lblMinute.Text = "(单位：分钟)";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(27, 98);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(53, 12);
            this.lblNumber.TabIndex = 12;
            this.lblNumber.Text = "座位编号";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 0;
            // 
            // lblHall
            // 
            this.lblHall.AutoSize = true;
            this.lblHall.Location = new System.Drawing.Point(27, 218);
            this.lblHall.Name = "lblHall";
            this.lblHall.Size = new System.Drawing.Size(53, 12);
            this.lblHall.TabIndex = 6;
            this.lblHall.Text = "放映大厅";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(27, 58);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(53, 12);
            this.lblAmount.TabIndex = 11;
            this.lblAmount.Text = "票的数量";
            // 
            // txtHall
            // 
            this.txtHall.Location = new System.Drawing.Point(106, 219);
            this.txtHall.Name = "txtHall";
            this.txtHall.ReadOnly = true;
            this.txtHall.Size = new System.Drawing.Size(100, 21);
            this.txtHall.TabIndex = 6;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(42, 190);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(29, 12);
            this.lblContent.TabIndex = 13;
            this.lblContent.Text = "简介";
            // 
            // lblCue
            // 
            this.lblCue.AutoSize = true;
            this.lblCue.Font = new System.Drawing.Font("华文楷体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCue.ForeColor = System.Drawing.Color.Red;
            this.lblCue.Location = new System.Drawing.Point(224, 20);
            this.lblCue.Name = "lblCue";
            this.lblCue.Size = new System.Drawing.Size(92, 16);
            this.lblCue.TabIndex = 6;
            this.lblCue.Text = "只能填写数字";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(51, 18);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(29, 12);
            this.lblMoney.TabIndex = 3;
            this.lblMoney.Text = "价格";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(27, 258);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(53, 12);
            this.lblHour.TabIndex = 5;
            this.lblHour.Text = "电影片长";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(106, 15);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(100, 21);
            this.txtMoney.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(106, 56);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(100, 21);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.Text = "300";
            // 
            // btnCorrect
            // 
            this.btnCorrect.Location = new System.Drawing.Point(212, 370);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(75, 23);
            this.btnCorrect.TabIndex = 5;
            this.btnCorrect.Text = "增加";
            this.btnCorrect.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(20, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(358, 348);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Controls.Add(this.txtContent);
            this.tabPage1.Controls.Add(this.lbllanguage);
            this.tabPage1.Controls.Add(this.lblMain);
            this.tabPage1.Controls.Add(this.lblType);
            this.tabPage1.Controls.Add(this.txtDirect);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.lblDirect);
            this.tabPage1.Controls.Add(this.lblContent);
            this.tabPage1.Controls.Add(this.cboType);
            this.tabPage1.Controls.Add(this.txtLanguage);
            this.tabPage1.Controls.Add(this.txtMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(350, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "电影内容";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "电影名称";
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtContent.Location = new System.Drawing.Point(109, 188);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(210, 118);
            this.txtContent.TabIndex = 5;
            // 
            // lbllanguage
            // 
            this.lbllanguage.AutoSize = true;
            this.lbllanguage.Location = new System.Drawing.Point(42, 156);
            this.lbllanguage.Name = "lbllanguage";
            this.lbllanguage.Size = new System.Drawing.Size(29, 12);
            this.lbllanguage.TabIndex = 2;
            this.lbllanguage.Text = "语言";
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(42, 88);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(29, 12);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = "主演";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(18, 54);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(53, 12);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "电影类型";
            // 
            // txtDirect
            // 
            this.txtDirect.Location = new System.Drawing.Point(109, 115);
            this.txtDirect.Name = "txtDirect";
            this.txtDirect.Size = new System.Drawing.Size(154, 21);
            this.txtDirect.TabIndex = 3;
            // 
            // lblDirect
            // 
            this.lblDirect.AutoSize = true;
            this.lblDirect.Location = new System.Drawing.Point(42, 122);
            this.lblDirect.Name = "lblDirect";
            this.lblDirect.Size = new System.Drawing.Size(29, 12);
            this.lblDirect.TabIndex = 15;
            this.lblDirect.Text = "导演";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(109, 49);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(100, 20);
            this.cboType.TabIndex = 1;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(109, 148);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(100, 21);
            this.txtLanguage.TabIndex = 4;
            // 
            // txtMain
            // 
            this.txtMain.Location = new System.Drawing.Point(109, 82);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(154, 21);
            this.txtMain.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtHall);
            this.tabPage2.Controls.Add(this.lblCue);
            this.tabPage2.Controls.Add(this.lblMoney);
            this.tabPage2.Controls.Add(this.cboTime);
            this.tabPage2.Controls.Add(this.txtNumber);
            this.tabPage2.Controls.Add(this.lblMinute);
            this.tabPage2.Controls.Add(this.lblHour);
            this.tabPage2.Controls.Add(this.txtMoney);
            this.tabPage2.Controls.Add(this.txtAmount);
            this.tabPage2.Controls.Add(this.lblNumber);
            this.tabPage2.Controls.Add(this.lblHall);
            this.tabPage2.Controls.Add(this.lblAmount);
            this.tabPage2.Controls.Add(this.lblTime);
            this.tabPage2.Controls.Add(this.txtHour);
            this.tabPage2.Controls.Add(this.dateTimePicker);
            this.tabPage2.Controls.Add(this.lblDate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(350, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "电影特殊信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(27, 138);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 12);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "放映时间";
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(106, 260);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(100, 21);
            this.txtHour.TabIndex = 7;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(106, 178);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(139, 21);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.Value = new System.DateTime(2008, 12, 11, 0, 0, 0, 0);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(27, 178);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 12);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "放映日期";
            // 
            // btnAddPic
            // 
            this.btnAddPic.Location = new System.Drawing.Point(438, 344);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(163, 23);
            this.btnAddPic.TabIndex = 8;
            this.btnAddPic.Text = "插入海报";
            this.btnAddPic.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(350, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picFace
            // 
            this.picFace.Location = new System.Drawing.Point(19, 20);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(231, 272);
            this.picFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFace.TabIndex = 17;
            this.picFace.TabStop = false;
            // 
            // grpPicture
            // 
            this.grpPicture.Controls.Add(this.picFace);
            this.grpPicture.Location = new System.Drawing.Point(395, 26);
            this.grpPicture.Name = "grpPicture";
            this.grpPicture.Size = new System.Drawing.Size(265, 312);
            this.grpPicture.TabIndex = 7;
            this.grpPicture.TabStop = false;
            this.grpPicture.Text = "电影海报";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 399);
            this.Controls.Add(this.btnCorrect);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAddPic);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpPicture);
            this.Name = "AddForm";
            this.Text = "增加电影";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.grpPicture.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHall;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtHall;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblCue;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label lbllanguage;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtDirect;
        private System.Windows.Forms.Label lblDirect;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.GroupBox grpPicture;
    }
}

