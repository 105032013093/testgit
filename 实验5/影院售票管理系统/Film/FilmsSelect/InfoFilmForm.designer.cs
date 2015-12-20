namespace FilmsSelect
{
    partial class InfoFilmForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.labMain = new System.Windows.Forms.Label();
            this.lablanguage = new System.Windows.Forms.Label();
            this.labMoney = new System.Windows.Forms.Label();
            this.labType = new System.Windows.Forms.Label();
            this.labHour = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.grbFilm = new System.Windows.Forms.GroupBox();
            this.labTime = new System.Windows.Forms.Label();
            this.txtDirect = new System.Windows.Forms.TextBox();
            this.labDirect = new System.Windows.Forms.Label();
            this.txtlanguage = new System.Windows.Forms.TextBox();
            this.labMinute = new System.Windows.Forms.Label();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.grpMoney = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labAmount = new System.Windows.Forms.Label();
            this.labNumber = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.grpPicture = new System.Windows.Forms.GroupBox();
            this.picName = new System.Windows.Forms.PictureBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.labPoster = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnLook = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.grbFilm.SuspendLayout();
            this.grpMoney.SuspendLayout();
            this.grpPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picName)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 23);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 0;
            // 
            // labMain
            // 
            this.labMain.AutoSize = true;
            this.labMain.Location = new System.Drawing.Point(237, 26);
            this.labMain.Name = "labMain";
            this.labMain.Size = new System.Drawing.Size(29, 12);
            this.labMain.TabIndex = 1;
            this.labMain.Text = "主演";
            // 
            // lablanguage
            // 
            this.lablanguage.AutoSize = true;
            this.lablanguage.Location = new System.Drawing.Point(237, 86);
            this.lablanguage.Name = "lablanguage";
            this.lablanguage.Size = new System.Drawing.Size(29, 12);
            this.lablanguage.TabIndex = 2;
            this.lablanguage.Text = "语言";
            // 
            // labMoney
            // 
            this.labMoney.AutoSize = true;
            this.labMoney.Location = new System.Drawing.Point(32, 33);
            this.labMoney.Name = "labMoney";
            this.labMoney.Size = new System.Drawing.Size(29, 12);
            this.labMoney.TabIndex = 3;
            this.labMoney.Text = "价格";
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Location = new System.Drawing.Point(21, 58);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(53, 12);
            this.labType.TabIndex = 4;
            this.labType.Text = "电影类别";
            // 
            // labHour
            // 
            this.labHour.AutoSize = true;
            this.labHour.Location = new System.Drawing.Point(21, 91);
            this.labHour.Name = "labHour";
            this.labHour.Size = new System.Drawing.Size(53, 12);
            this.labHour.TabIndex = 5;
            this.labHour.Text = "电影片长";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(21, 26);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(53, 12);
            this.labName.TabIndex = 6;
            this.labName.Text = "电影名称";
            // 
            // grbFilm
            // 
            this.grbFilm.BackColor = System.Drawing.SystemColors.Control;
            this.grbFilm.Controls.Add(this.txtTime);
            this.grbFilm.Controls.Add(this.txtType);
            this.grbFilm.Controls.Add(this.labTime);
            this.grbFilm.Controls.Add(this.txtDirect);
            this.grbFilm.Controls.Add(this.labDirect);
            this.grbFilm.Controls.Add(this.txtlanguage);
            this.grbFilm.Controls.Add(this.labMinute);
            this.grbFilm.Controls.Add(this.txtHour);
            this.grbFilm.Controls.Add(this.txtMain);
            this.grbFilm.Controls.Add(this.txtName);
            this.grbFilm.Controls.Add(this.labType);
            this.grbFilm.Controls.Add(this.labName);
            this.grbFilm.Controls.Add(this.labMain);
            this.grbFilm.Controls.Add(this.labHour);
            this.grbFilm.Controls.Add(this.lablanguage);
            this.grbFilm.Location = new System.Drawing.Point(12, 12);
            this.grbFilm.Name = "grbFilm";
            this.grbFilm.Size = new System.Drawing.Size(473, 142);
            this.grbFilm.TabIndex = 7;
            this.grbFilm.TabStop = false;
            this.grbFilm.Text = "电影基本信息";
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Location = new System.Drawing.Point(237, 116);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(53, 12);
            this.labTime.TabIndex = 13;
            this.labTime.Text = "放映时间";
            // 
            // txtDirect
            // 
            this.txtDirect.Location = new System.Drawing.Point(301, 52);
            this.txtDirect.Name = "txtDirect";
            this.txtDirect.ReadOnly = true;
            this.txtDirect.Size = new System.Drawing.Size(100, 21);
            this.txtDirect.TabIndex = 16;
            // 
            // labDirect
            // 
            this.labDirect.AutoSize = true;
            this.labDirect.Location = new System.Drawing.Point(237, 56);
            this.labDirect.Name = "labDirect";
            this.labDirect.Size = new System.Drawing.Size(29, 12);
            this.labDirect.TabIndex = 15;
            this.labDirect.Text = "导演";
            // 
            // txtlanguage
            // 
            this.txtlanguage.Location = new System.Drawing.Point(301, 84);
            this.txtlanguage.Name = "txtlanguage";
            this.txtlanguage.ReadOnly = true;
            this.txtlanguage.Size = new System.Drawing.Size(100, 21);
            this.txtlanguage.TabIndex = 14;
            // 
            // labMinute
            // 
            this.labMinute.AutoSize = true;
            this.labMinute.Location = new System.Drawing.Point(93, 119);
            this.labMinute.Name = "labMinute";
            this.labMinute.Size = new System.Drawing.Size(77, 12);
            this.labMinute.TabIndex = 13;
            this.labMinute.Text = "(单位：分钟)";
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(95, 87);
            this.txtHour.Name = "txtHour";
            this.txtHour.ReadOnly = true;
            this.txtHour.Size = new System.Drawing.Size(100, 21);
            this.txtHour.TabIndex = 11;
            // 
            // txtMain
            // 
            this.txtMain.Location = new System.Drawing.Point(301, 20);
            this.txtMain.Name = "txtMain";
            this.txtMain.ReadOnly = true;
            this.txtMain.Size = new System.Drawing.Size(100, 21);
            this.txtMain.TabIndex = 12;
            // 
            // grpMoney
            // 
            this.grpMoney.Controls.Add(this.textBox4);
            this.grpMoney.Controls.Add(this.txtNumber);
            this.grpMoney.Controls.Add(this.txtAmount);
            this.grpMoney.Controls.Add(this.label3);
            this.grpMoney.Controls.Add(this.labAmount);
            this.grpMoney.Controls.Add(this.labNumber);
            this.grpMoney.Controls.Add(this.txtMoney);
            this.grpMoney.Controls.Add(this.labMoney);
            this.grpMoney.Location = new System.Drawing.Point(12, 173);
            this.grpMoney.Name = "grpMoney";
            this.grpMoney.Size = new System.Drawing.Size(473, 161);
            this.grpMoney.TabIndex = 8;
            this.grpMoney.TabStop = false;
            this.grpMoney.Text = "电影特殊信息";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(279, 33);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(161, 99);
            this.textBox4.TabIndex = 16;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(95, 108);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(100, 21);
            this.txtNumber.TabIndex = 15;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(95, 71);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(100, 21);
            this.txtAmount.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "简介";
            // 
            // labAmount
            // 
            this.labAmount.AutoSize = true;
            this.labAmount.Location = new System.Drawing.Point(32, 74);
            this.labAmount.Name = "labAmount";
            this.labAmount.Size = new System.Drawing.Size(53, 12);
            this.labAmount.TabIndex = 11;
            this.labAmount.Text = "票的数量";
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Location = new System.Drawing.Point(32, 111);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(53, 12);
            this.labNumber.TabIndex = 12;
            this.labNumber.Text = "座位编号";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(95, 33);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(100, 21);
            this.txtMoney.TabIndex = 4;
            // 
            // grpPicture
            // 
            this.grpPicture.Controls.Add(this.picName);
            this.grpPicture.Location = new System.Drawing.Point(514, 22);
            this.grpPicture.Name = "grpPicture";
            this.grpPicture.Size = new System.Drawing.Size(265, 312);
            this.grpPicture.TabIndex = 11;
            this.grpPicture.TabStop = false;
            this.grpPicture.Text = "电影海报";
            // 
            // picName
            // 
            this.picName.Location = new System.Drawing.Point(19, 20);
            this.picName.Name = "picName";
            this.picName.Size = new System.Drawing.Size(231, 272);
            this.picName.TabIndex = 17;
            this.picName.TabStop = false;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(95, 55);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(100, 21);
            this.txtType.TabIndex = 18;
            // 
            // labPoster
            // 
            this.labPoster.AutoSize = true;
            this.labPoster.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPoster.ForeColor = System.Drawing.Color.DarkOrchid;
            this.labPoster.Location = new System.Drawing.Point(609, 346);
            this.labPoster.Name = "labPoster";
            this.labPoster.Size = new System.Drawing.Size(66, 27);
            this.labPoster.TabIndex = 18;
            this.labPoster.Text = "海报";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(301, 113);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(100, 21);
            this.txtTime.TabIndex = 19;
            // 
            // btnLook
            // 
            this.btnLook.Location = new System.Drawing.Point(251, 346);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(75, 23);
            this.btnLook.TabIndex = 19;
            this.btnLook.Text = "视频观看";
            this.btnLook.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(377, 346);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 20;
            this.btnInfo.Text = "订票";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // InfoFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(791, 385);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.labPoster);
            this.Controls.Add(this.grpPicture);
            this.Controls.Add(this.grpMoney);
            this.Controls.Add(this.grbFilm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoFilmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电影信息";
            this.grbFilm.ResumeLayout(false);
            this.grbFilm.PerformLayout();
            this.grpMoney.ResumeLayout(false);
            this.grpMoney.PerformLayout();
            this.grpPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labMain;
        private System.Windows.Forms.Label lablanguage;
        private System.Windows.Forms.Label labMoney;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.Label labHour;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.GroupBox grbFilm;
        private System.Windows.Forms.GroupBox grpMoney;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.TextBox txtlanguage;
        private System.Windows.Forms.Label labMinute;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label labAmount;
        private System.Windows.Forms.Label labNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox grpPicture;
        private System.Windows.Forms.PictureBox picName;
        private System.Windows.Forms.Label labDirect;
        private System.Windows.Forms.TextBox txtDirect;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label labPoster;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.Button btnInfo;
    }
}