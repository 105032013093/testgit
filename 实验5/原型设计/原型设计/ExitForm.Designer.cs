namespace 原型设计
{
    partial class ExitForm
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
            this.lblExit1 = new System.Windows.Forms.Label();
            this.btnNO = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExit1
            // 
            this.lblExit1.AutoSize = true;
            this.lblExit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExit1.Location = new System.Drawing.Point(84, 58);
            this.lblExit1.Name = "lblExit1";
            this.lblExit1.Size = new System.Drawing.Size(114, 20);
            this.lblExit1.TabIndex = 12;
            this.lblExit1.Text = "确定要退出吗?";
            // 
            // btnNO
            // 
            this.btnNO.Location = new System.Drawing.Point(162, 184);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(75, 23);
            this.btnNO.TabIndex = 11;
            this.btnNO.Text = "取消";
            this.btnNO.UseVisualStyleBackColor = true;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(28, 184);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblExit1);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.btnOK);
            this.Name = "ExitForm";
            this.Text = "退出";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExit1;
        private System.Windows.Forms.Button btnNO;
        private System.Windows.Forms.Button btnOK;
    }
}