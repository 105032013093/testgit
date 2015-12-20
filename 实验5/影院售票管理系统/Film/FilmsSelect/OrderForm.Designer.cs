namespace FilmsSelect
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblSeat1 = new System.Windows.Forms.Label();
            this.lblAgio1 = new System.Windows.Forms.Label();
            this.grpFilm = new System.Windows.Forms.GroupBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtHall = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblHall = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.txtlanguage = new System.Windows.Forms.TextBox();
            this.txtDirect = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.lblDirect = new System.Windows.Forms.Label();
            this.lbllanguage = new System.Windows.Forms.Label();
            this.lblDate1 = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblMoney1 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.dudnum = new System.Windows.Forms.DomainUpDown();
            this.lblAmount1 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.txtCert = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.cboAgio = new System.Windows.Forms.ComboBox();
            this.cboSeat = new System.Windows.Forms.ComboBox();
            this.lblCert1 = new System.Windows.Forms.Label();
            this.grbTicket = new System.Windows.Forms.GroupBox();
            this.lblnum = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.grpFilm.SuspendLayout();
            this.grbTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(381, 414);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "订票";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCorrect
            // 
            this.btnCorrect.Location = new System.Drawing.Point(462, 414);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(75, 23);
            this.btnCorrect.TabIndex = 3;
            this.btnCorrect.Text = "取消";
            this.btnCorrect.UseVisualStyleBackColor = true;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "电影名称";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(41, 57);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(29, 12);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "类型";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(17, 153);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(53, 12);
            this.lblHour.TabIndex = 5;
            this.lblHour.Text = "电影片长";
            // 
            // lblSeat1
            // 
            this.lblSeat1.AutoSize = true;
            this.lblSeat1.Location = new System.Drawing.Point(17, 42);
            this.lblSeat1.Name = "lblSeat1";
            this.lblSeat1.Size = new System.Drawing.Size(53, 12);
            this.lblSeat1.TabIndex = 6;
            this.lblSeat1.Text = "座位类型";
            // 
            // lblAgio1
            // 
            this.lblAgio1.AutoSize = true;
            this.lblAgio1.Location = new System.Drawing.Point(17, 74);
            this.lblAgio1.Name = "lblAgio1";
            this.lblAgio1.Size = new System.Drawing.Size(53, 12);
            this.lblAgio1.TabIndex = 7;
            this.lblAgio1.Text = "折扣类型";
            // 
            // grpFilm
            // 
            this.grpFilm.Controls.Add(this.txtType);
            this.grpFilm.Controls.Add(this.txtDays);
            this.grpFilm.Controls.Add(this.txtTime);
            this.grpFilm.Controls.Add(this.lblTime);
            this.grpFilm.Controls.Add(this.txtHall);
            this.grpFilm.Controls.Add(this.txtPrice);
            this.grpFilm.Controls.Add(this.lblHall);
            this.grpFilm.Controls.Add(this.lblPrice);
            this.grpFilm.Controls.Add(this.lblMinute);
            this.grpFilm.Controls.Add(this.txtlanguage);
            this.grpFilm.Controls.Add(this.txtDirect);
            this.grpFilm.Controls.Add(this.txtName);
            this.grpFilm.Controls.Add(this.txtHour);
            this.grpFilm.Controls.Add(this.txtMain);
            this.grpFilm.Controls.Add(this.lblDirect);
            this.grpFilm.Controls.Add(this.lbllanguage);
            this.grpFilm.Controls.Add(this.lblDate1);
            this.grpFilm.Controls.Add(this.lblMain);
            this.grpFilm.Controls.Add(this.lblName);
            this.grpFilm.Controls.Add(this.lblType);
            this.grpFilm.Controls.Add(this.lblHour);
            this.grpFilm.Location = new System.Drawing.Point(12, 12);
            this.grpFilm.Name = "grpFilm";
            this.grpFilm.Size = new System.Drawing.Size(600, 185);
            this.grpFilm.TabIndex = 1;
            this.grpFilm.TabStop = false;
            this.grpFilm.Text = "电影信息";
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtType.Location = new System.Drawing.Point(112, 51);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 21);
            this.txtType.TabIndex = 23;
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(112, 112);
            this.txtDays.Name = "txtDays";
            this.txtDays.ReadOnly = true;
            this.txtDays.Size = new System.Drawing.Size(100, 21);
            this.txtDays.TabIndex = 20;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(112, 82);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(100, 21);
            this.txtTime.TabIndex = 20;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(17, 121);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 12);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "放映时间";
            // 
            // txtHall
            // 
            this.txtHall.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtHall.Location = new System.Drawing.Point(421, 150);
            this.txtHall.Name = "txtHall";
            this.txtHall.Size = new System.Drawing.Size(100, 21);
            this.txtHall.TabIndex = 18;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtPrice.Location = new System.Drawing.Point(421, 119);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 21);
            this.txtPrice.TabIndex = 18;
            // 
            // lblHall
            // 
            this.lblHall.AutoSize = true;
            this.lblHall.Location = new System.Drawing.Point(341, 153);
            this.lblHall.Name = "lblHall";
            this.lblHall.Size = new System.Drawing.Size(53, 12);
            this.lblHall.TabIndex = 17;
            this.lblHall.Text = "放映大厅";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(365, 122);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 12);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "票价";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(235, 153);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(77, 12);
            this.lblMinute.TabIndex = 15;
            this.lblMinute.Text = "(单位：分钟)";
            // 
            // txtlanguage
            // 
            this.txtlanguage.Location = new System.Drawing.Point(421, 89);
            this.txtlanguage.Name = "txtlanguage";
            this.txtlanguage.ReadOnly = true;
            this.txtlanguage.Size = new System.Drawing.Size(100, 21);
            this.txtlanguage.TabIndex = 14;
            // 
            // txtDirect
            // 
            this.txtDirect.Location = new System.Drawing.Point(421, 57);
            this.txtDirect.Name = "txtDirect";
            this.txtDirect.ReadOnly = true;
            this.txtDirect.Size = new System.Drawing.Size(100, 21);
            this.txtDirect.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 22);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 0;
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(112, 142);
            this.txtHour.Name = "txtHour";
            this.txtHour.ReadOnly = true;
            this.txtHour.Size = new System.Drawing.Size(100, 21);
            this.txtHour.TabIndex = 10;
            // 
            // txtMain
            // 
            this.txtMain.Location = new System.Drawing.Point(421, 23);
            this.txtMain.Name = "txtMain";
            this.txtMain.ReadOnly = true;
            this.txtMain.Size = new System.Drawing.Size(100, 21);
            this.txtMain.TabIndex = 9;
            // 
            // lblDirect
            // 
            this.lblDirect.AutoSize = true;
            this.lblDirect.Location = new System.Drawing.Point(365, 60);
            this.lblDirect.Name = "lblDirect";
            this.lblDirect.Size = new System.Drawing.Size(29, 12);
            this.lblDirect.TabIndex = 8;
            this.lblDirect.Text = "导演";
            // 
            // lbllanguage
            // 
            this.lbllanguage.AutoSize = true;
            this.lbllanguage.Location = new System.Drawing.Point(365, 90);
            this.lbllanguage.Name = "lbllanguage";
            this.lbllanguage.Size = new System.Drawing.Size(29, 12);
            this.lbllanguage.TabIndex = 7;
            this.lbllanguage.Text = "语言";
            // 
            // lblDate1
            // 
            this.lblDate1.AutoSize = true;
            this.lblDate1.Location = new System.Drawing.Point(17, 89);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Size = new System.Drawing.Size(53, 12);
            this.lblDate1.TabIndex = 10;
            this.lblDate1.Text = "放映日期";
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(365, 25);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(29, 12);
            this.lblMain.TabIndex = 6;
            this.lblMain.Text = "主演";
            // 
            // lblMoney1
            // 
            this.lblMoney1.Location = new System.Drawing.Point(241, 42);
            this.lblMoney1.Name = "lblMoney1";
            this.lblMoney1.Size = new System.Drawing.Size(29, 12);
            this.lblMoney1.TabIndex = 8;
            this.lblMoney1.Text = "价格";
            // 
            // txtSum
            // 
            this.txtSum.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSum.ForeColor = System.Drawing.Color.Red;
            this.txtSum.Location = new System.Drawing.Point(432, 142);
            this.txtSum.Multiline = true;
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(89, 32);
            this.txtSum.TabIndex = 10;
            this.txtSum.Click += new System.EventHandler(this.txtSum_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNum1.ForeColor = System.Drawing.Color.DeepPink;
            this.txtNum1.Location = new System.Drawing.Point(111, 142);
            this.txtNum1.Multiline = true;
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.ReadOnly = true;
            this.txtNum1.Size = new System.Drawing.Size(89, 32);
            this.txtNum1.TabIndex = 10;
            this.txtNum1.Click += new System.EventHandler(this.txtNum1_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSum.ForeColor = System.Drawing.Color.Brown;
            this.lblSum.Location = new System.Drawing.Point(368, 142);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(58, 24);
            this.lblSum.TabIndex = 10;
            this.lblSum.Text = "找零";
            this.lblSum.Click += new System.EventHandler(this.lblSum_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNum2.ForeColor = System.Drawing.Color.Red;
            this.txtNum2.Location = new System.Drawing.Point(264, 142);
            this.txtNum2.Multiline = true;
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(89, 32);
            this.txtNum2.TabIndex = 4;
            this.txtNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum2_KeyPress);
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNum2.ForeColor = System.Drawing.Color.Brown;
            this.lblNum2.Location = new System.Drawing.Point(200, 142);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(58, 24);
            this.lblNum2.TabIndex = 10;
            this.lblNum2.Text = "付款";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNum1.ForeColor = System.Drawing.Color.Brown;
            this.lblNum1.Location = new System.Drawing.Point(28, 142);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(58, 24);
            this.lblNum1.TabIndex = 10;
            this.lblNum1.Text = "合计";
            this.lblNum1.Click += new System.EventHandler(this.lblNum1_Click);
            // 
            // dudnum
            // 
            this.dudnum.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dudnum.Location = new System.Drawing.Point(286, 68);
            this.dudnum.Name = "dudnum";
            this.dudnum.Size = new System.Drawing.Size(72, 23);
            this.dudnum.TabIndex = 16;
            this.dudnum.Text = "1";
            this.dudnum.Wrap = true;
            this.dudnum.TextChanged += new System.EventHandler(this.dudnum_TextChanged);
            // 
            // lblAmount1
            // 
            this.lblAmount1.AutoSize = true;
            this.lblAmount1.Location = new System.Drawing.Point(217, 74);
            this.lblAmount1.Name = "lblAmount1";
            this.lblAmount1.Size = new System.Drawing.Size(53, 12);
            this.lblAmount1.TabIndex = 10;
            this.lblAmount1.Text = "订购票数";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(450, 33);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(63, 21);
            this.txtNumber.TabIndex = 15;
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Location = new System.Drawing.Point(382, 39);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(53, 12);
            this.lblNumber1.TabIndex = 10;
            this.lblNumber1.Text = "剩余票数";
            // 
            // txtCert
            // 
            this.txtCert.Location = new System.Drawing.Point(111, 103);
            this.txtCert.Name = "txtCert";
            this.txtCert.Size = new System.Drawing.Size(100, 21);
            this.txtCert.TabIndex = 2;
            this.txtCert.TextChanged += new System.EventHandler(this.txtCert_TextChanged);
            this.txtCert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCert1_KeyPress);
            this.txtCert.Leave += new System.EventHandler(this.txtCert1_Leave);
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(286, 39);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(72, 21);
            this.txtMoney.TabIndex = 14;
            // 
            // cboAgio
            // 
            this.cboAgio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAgio.FormattingEnabled = true;
            this.cboAgio.Location = new System.Drawing.Point(111, 71);
            this.cboAgio.Name = "cboAgio";
            this.cboAgio.Size = new System.Drawing.Size(100, 20);
            this.cboAgio.TabIndex = 1;
            this.cboAgio.SelectedIndexChanged += new System.EventHandler(this.cboAgio_SelectedIndexChanged);
            // 
            // cboSeat
            // 
            this.cboSeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeat.FormattingEnabled = true;
            this.cboSeat.Location = new System.Drawing.Point(111, 39);
            this.cboSeat.Name = "cboSeat";
            this.cboSeat.Size = new System.Drawing.Size(100, 20);
            this.cboSeat.TabIndex = 0;
            this.cboSeat.SelectedIndexChanged += new System.EventHandler(this.cboSeat_SelectedIndexChanged);
            // 
            // lblCert1
            // 
            this.lblCert1.AutoSize = true;
            this.lblCert1.Location = new System.Drawing.Point(41, 112);
            this.lblCert1.Name = "lblCert1";
            this.lblCert1.Size = new System.Drawing.Size(29, 12);
            this.lblCert1.TabIndex = 11;
            this.lblCert1.Text = "证件";
            // 
            // grbTicket
            // 
            this.grbTicket.Controls.Add(this.lblnum);
            this.grbTicket.Controls.Add(this.lblPhone);
            this.grbTicket.Controls.Add(this.txtPhone);
            this.grbTicket.Controls.Add(this.lblSeat1);
            this.grbTicket.Controls.Add(this.txtSum);
            this.grbTicket.Controls.Add(this.txtCert);
            this.grbTicket.Controls.Add(this.lblNumber1);
            this.grbTicket.Controls.Add(this.txtMoney);
            this.grbTicket.Controls.Add(this.txtNumber);
            this.grbTicket.Controls.Add(this.cboAgio);
            this.grbTicket.Controls.Add(this.lblAmount1);
            this.grbTicket.Controls.Add(this.txtNum1);
            this.grbTicket.Controls.Add(this.cboSeat);
            this.grbTicket.Controls.Add(this.dudnum);
            this.grbTicket.Controls.Add(this.lblCert1);
            this.grbTicket.Controls.Add(this.lblSum);
            this.grbTicket.Controls.Add(this.lblNum1);
            this.grbTicket.Controls.Add(this.lblMoney1);
            this.grbTicket.Controls.Add(this.lblNum2);
            this.grbTicket.Controls.Add(this.txtNum2);
            this.grbTicket.Controls.Add(this.lblAgio1);
            this.grbTicket.Location = new System.Drawing.Point(12, 203);
            this.grbTicket.Name = "grbTicket";
            this.grbTicket.Size = new System.Drawing.Size(600, 196);
            this.grbTicket.TabIndex = 23;
            this.grbTicket.TabStop = false;
            this.grbTicket.Text = "订票";
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.ForeColor = System.Drawing.Color.Maroon;
            this.lblnum.Location = new System.Drawing.Point(221, 106);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(137, 12);
            this.lblnum.TabIndex = 24;
            this.lblnum.Text = "请输入有效的证件名！！";
            this.lblnum.Visible = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(382, 74);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 12);
            this.lblPhone.TabIndex = 24;
            this.lblPhone.Text = "联系电话";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(450, 68);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 21);
            this.txtPhone.TabIndex = 25;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(624, 449);
            this.Controls.Add(this.grpFilm);
            this.Controls.Add(this.grbTicket);
            this.Controls.Add(this.btnCorrect);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "订票";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.grpFilm.ResumeLayout(false);
            this.grpFilm.PerformLayout();
            this.grbTicket.ResumeLayout(false);
            this.grbTicket.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblSeat1;
        private System.Windows.Forms.Label lblAgio1;
        private System.Windows.Forms.GroupBox grpFilm;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lbllanguage;
        private System.Windows.Forms.Label lblDirect;
        private System.Windows.Forms.TextBox txtlanguage;
        private System.Windows.Forms.TextBox txtDirect;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblMoney1;
        private System.Windows.Forms.Label lblDate1;
        private System.Windows.Forms.Label lblCert1;
        private System.Windows.Forms.ComboBox cboSeat;
        private System.Windows.Forms.ComboBox cboAgio;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtCert;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblAmount1;
        private System.Windows.Forms.DomainUpDown dudnum;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtHall;
        private System.Windows.Forms.Label lblHall;
        private System.Windows.Forms.GroupBox grbTicket;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblnum;
    }
}