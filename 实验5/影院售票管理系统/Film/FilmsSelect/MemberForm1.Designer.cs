namespace FilmsSelect
{
    partial class MemberForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberForm1));
            this.labNumber = new System.Windows.Forms.Label();
            this.labClew = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPeopleId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labPhone = new System.Windows.Forms.Label();
            this.labPeopleId = new System.Windows.Forms.Label();
            this.labType = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labNumber.ForeColor = System.Drawing.Color.Maroon;
            this.labNumber.Location = new System.Drawing.Point(107, 178);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(148, 12);
            this.labNumber.TabIndex = 19;
            this.labNumber.Text = "请输入有效的联系方式！";
            // 
            // labClew
            // 
            this.labClew.AutoSize = true;
            this.labClew.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labClew.ForeColor = System.Drawing.Color.Maroon;
            this.labClew.Location = new System.Drawing.Point(107, 138);
            this.labClew.Name = "labClew";
            this.labClew.Size = new System.Drawing.Size(109, 12);
            this.labClew.TabIndex = 18;
            this.labClew.Text = "请输入有效证件！";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(109, 76);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(114, 20);
            this.cboType.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(109, 154);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(114, 21);
            this.txtPhone.TabIndex = 13;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged_1);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress_1);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave_1);
            // 
            // txtPeopleId
            // 
            this.txtPeopleId.Location = new System.Drawing.Point(109, 114);
            this.txtPeopleId.Name = "txtPeopleId";
            this.txtPeopleId.Size = new System.Drawing.Size(114, 21);
            this.txtPeopleId.TabIndex = 10;
            this.txtPeopleId.TextChanged += new System.EventHandler(this.txtPeopleId_TextChanged_1);
            this.txtPeopleId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeopleId_KeyPress_1);
            this.txtPeopleId.Leave += new System.EventHandler(this.txtPeopleId_Leave_1);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(114, 21);
            this.txtName.TabIndex = 8;
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPhone.Location = new System.Drawing.Point(38, 157);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(57, 12);
            this.labPhone.TabIndex = 17;
            this.labPhone.Text = "联系电话";
            // 
            // labPeopleId
            // 
            this.labPeopleId.AutoSize = true;
            this.labPeopleId.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPeopleId.Location = new System.Drawing.Point(38, 117);
            this.labPeopleId.Name = "labPeopleId";
            this.labPeopleId.Size = new System.Drawing.Size(44, 12);
            this.labPeopleId.TabIndex = 15;
            this.labPeopleId.Text = "身份证";
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labType.Location = new System.Drawing.Point(38, 79);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(57, 12);
            this.labType.TabIndex = 12;
            this.labType.Text = "会员类型";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labName.Location = new System.Drawing.Point(38, 46);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(31, 12);
            this.labName.TabIndex = 11;
            this.labName.Text = "姓名";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(169, 206);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(51, 206);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MemberForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.labNumber);
            this.Controls.Add(this.labClew);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPeopleId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labPhone);
            this.Controls.Add(this.labPeopleId);
            this.Controls.Add(this.labType);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemberForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员注册";
            this.Load += new System.EventHandler(this.MemberForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNumber;
        private System.Windows.Forms.Label labClew;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPeopleId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.Label labPeopleId;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
    }
}