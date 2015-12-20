namespace FilmsSelect
{
    partial class ExitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitForm));
            this.rdoExit1 = new System.Windows.Forms.RadioButton();
            this.rdoExit2 = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnNO = new System.Windows.Forms.Button();
            this.lblExit1 = new System.Windows.Forms.Label();
            this.picpicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoExit1
            // 
            this.rdoExit1.AutoSize = true;
            this.rdoExit1.Location = new System.Drawing.Point(120, 56);
            this.rdoExit1.Name = "rdoExit1";
            this.rdoExit1.Size = new System.Drawing.Size(71, 16);
            this.rdoExit1.TabIndex = 1;
            this.rdoExit1.Text = "直接退出";
            this.rdoExit1.UseVisualStyleBackColor = true;
            this.rdoExit1.Click += new System.EventHandler(this.rdoExit_Click);
            // 
            // rdoExit2
            // 
            this.rdoExit2.AutoSize = true;
            this.rdoExit2.Location = new System.Drawing.Point(120, 101);
            this.rdoExit2.Name = "rdoExit2";
            this.rdoExit2.Size = new System.Drawing.Size(71, 16);
            this.rdoExit2.TabIndex = 3;
            this.rdoExit2.Text = "换班退出";
            this.rdoExit2.UseVisualStyleBackColor = true;
            this.rdoExit2.Click += new System.EventHandler(this.rdoExit_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(61, 146);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnNO
            // 
            this.btnNO.Location = new System.Drawing.Point(157, 146);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(75, 23);
            this.btnNO.TabIndex = 5;
            this.btnNO.Text = "取消";
            this.btnNO.UseVisualStyleBackColor = true;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // lblExit1
            // 
            this.lblExit1.AutoSize = true;
            this.lblExit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExit1.Location = new System.Drawing.Point(108, 20);
            this.lblExit1.Name = "lblExit1";
            this.lblExit1.Size = new System.Drawing.Size(114, 20);
            this.lblExit1.TabIndex = 6;
            this.lblExit1.Text = "确定要退出吗?";
            // 
            // picpicture
            // 
            this.picpicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picpicture.BackgroundImage")));
            this.picpicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picpicture.Image = ((System.Drawing.Image)(resources.GetObject("picpicture.Image")));
            this.picpicture.Location = new System.Drawing.Point(-17, 17);
            this.picpicture.Name = "picpicture";
            this.picpicture.Size = new System.Drawing.Size(119, 100);
            this.picpicture.TabIndex = 7;
            this.picpicture.TabStop = false;
            // 
            // ExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(276, 187);
            this.Controls.Add(this.picpicture);
            this.Controls.Add(this.lblExit1);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rdoExit2);
            this.Controls.Add(this.rdoExit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "退出";
            ((System.ComponentModel.ISupportInitialize)(this.picpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoExit1;
        private System.Windows.Forms.RadioButton rdoExit2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnNO;
        private System.Windows.Forms.Label lblExit1;
        private System.Windows.Forms.PictureBox picpicture;
    }
}