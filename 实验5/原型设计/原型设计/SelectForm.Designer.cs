namespace 原型设计
{
    partial class SelectForm
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
            this.picPic = new System.Windows.Forms.PictureBox();
            this.grpone = new System.Windows.Forms.GroupBox();
            this.dgvSerch = new System.Windows.Forms.DataGridView();
            this.grptwo = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labchoice = new System.Windows.Forms.Label();
            this.btnColse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPic)).BeginInit();
            this.grpone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerch)).BeginInit();
            this.grptwo.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPic
            // 
            this.picPic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picPic.Location = new System.Drawing.Point(8, 19);
            this.picPic.Name = "picPic";
            this.picPic.Size = new System.Drawing.Size(215, 251);
            this.picPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPic.TabIndex = 0;
            this.picPic.TabStop = false;
            // 
            // grpone
            // 
            this.grpone.Controls.Add(this.dgvSerch);
            this.grpone.Location = new System.Drawing.Point(255, 16);
            this.grpone.Name = "grpone";
            this.grpone.Size = new System.Drawing.Size(484, 238);
            this.grpone.TabIndex = 22;
            this.grpone.TabStop = false;
            this.grpone.Text = "查询";
            // 
            // dgvSerch
            // 
            this.dgvSerch.AllowUserToAddRows = false;
            this.dgvSerch.AllowUserToDeleteRows = false;
            this.dgvSerch.AllowUserToResizeColumns = false;
            this.dgvSerch.AllowUserToResizeRows = false;
            this.dgvSerch.BackgroundColor = System.Drawing.Color.White;
            this.dgvSerch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSerch.Location = new System.Drawing.Point(14, 23);
            this.dgvSerch.MultiSelect = false;
            this.dgvSerch.Name = "dgvSerch";
            this.dgvSerch.ReadOnly = true;
            this.dgvSerch.RowHeadersVisible = false;
            this.dgvSerch.RowTemplate.Height = 23;
            this.dgvSerch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSerch.Size = new System.Drawing.Size(460, 195);
            this.dgvSerch.TabIndex = 10;
            // 
            // grptwo
            // 
            this.grptwo.Controls.Add(this.picPic);
            this.grptwo.Location = new System.Drawing.Point(7, 10);
            this.grptwo.Name = "grptwo";
            this.grptwo.Size = new System.Drawing.Size(233, 286);
            this.grptwo.TabIndex = 21;
            this.grptwo.TabStop = false;
            this.grptwo.Text = "海报";
            // 
            // button1
            // 
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(445, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "订票";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSelect.Location = new System.Drawing.Point(445, 289);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 15;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(560, 288);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "刷新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(304, 303);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(124, 21);
            this.dateTimePicker.TabIndex = 18;
            // 
            // labchoice
            // 
            this.labchoice.AutoSize = true;
            this.labchoice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labchoice.Location = new System.Drawing.Point(302, 284);
            this.labchoice.Name = "labchoice";
            this.labchoice.Size = new System.Drawing.Size(77, 12);
            this.labchoice.TabIndex = 17;
            this.labchoice.Text = "按日期查询：";
            // 
            // btnColse
            // 
            this.btnColse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnColse.Location = new System.Drawing.Point(560, 317);
            this.btnColse.Name = "btnColse";
            this.btnColse.Size = new System.Drawing.Size(75, 23);
            this.btnColse.TabIndex = 16;
            this.btnColse.Text = "取消";
            this.btnColse.UseVisualStyleBackColor = true;
            this.btnColse.Click += new System.EventHandler(this.btnColse_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 351);
            this.Controls.Add(this.grpone);
            this.Controls.Add(this.grptwo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labchoice);
            this.Controls.Add(this.btnColse);
            this.Name = "SelectForm";
            this.Text = "影片查询";
            ((System.ComponentModel.ISupportInitialize)(this.picPic)).EndInit();
            this.grpone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerch)).EndInit();
            this.grptwo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPic;
        private System.Windows.Forms.GroupBox grpone;
        private System.Windows.Forms.DataGridView dgvSerch;
        private System.Windows.Forms.GroupBox grptwo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labchoice;
        private System.Windows.Forms.Button btnColse;
    }
}