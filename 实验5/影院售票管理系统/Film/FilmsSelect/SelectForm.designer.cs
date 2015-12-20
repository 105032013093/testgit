namespace FilmsSelect
{
    partial class SelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectForm));
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnColse = new System.Windows.Forms.Button();
            this.labchoice = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dgvSerch = new System.Windows.Forms.DataGridView();
            this.grptwo = new System.Windows.Forms.GroupBox();
            this.picPic = new System.Windows.Forms.PictureBox();
            this.grpone = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerch)).BeginInit();
            this.grptwo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPic)).BeginInit();
            this.grpone.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            resources.ApplyResources(this.btnSelect, "btnSelect");
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnColse
            // 
            resources.ApplyResources(this.btnColse, "btnColse");
            this.btnColse.Name = "btnColse";
            this.btnColse.UseVisualStyleBackColor = true;
            this.btnColse.Click += new System.EventHandler(this.btnColse_Click);
            // 
            // labchoice
            // 
            resources.ApplyResources(this.labchoice, "labchoice");
            this.labchoice.Name = "labchoice";
            // 
            // dateTimePicker
            // 
            resources.ApplyResources(this.dateTimePicker, "dateTimePicker");
            this.dateTimePicker.Name = "dateTimePicker";
            // 
            // dgvSerch
            // 
            this.dgvSerch.AllowUserToAddRows = false;
            this.dgvSerch.AllowUserToDeleteRows = false;
            this.dgvSerch.AllowUserToResizeColumns = false;
            this.dgvSerch.AllowUserToResizeRows = false;
            this.dgvSerch.BackgroundColor = System.Drawing.Color.White;
            this.dgvSerch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvSerch, "dgvSerch");
            this.dgvSerch.MultiSelect = false;
            this.dgvSerch.Name = "dgvSerch";
            this.dgvSerch.ReadOnly = true;
            this.dgvSerch.RowHeadersVisible = false;
            this.dgvSerch.RowTemplate.Height = 23;
            this.dgvSerch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSerch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSerch_CellClick);
            this.dgvSerch.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSerch_CellMouseLeave);
            this.dgvSerch.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSerch_CellMouseMove);
            // 
            // grptwo
            // 
            this.grptwo.Controls.Add(this.picPic);
            resources.ApplyResources(this.grptwo, "grptwo");
            this.grptwo.Name = "grptwo";
            this.grptwo.TabStop = false;
            // 
            // picPic
            // 
            resources.ApplyResources(this.picPic, "picPic");
            this.picPic.Name = "picPic";
            this.picPic.TabStop = false;
            this.picPic.Click += new System.EventHandler(this.picPic_Click);
            // 
            // grpone
            // 
            this.grpone.Controls.Add(this.dgvSerch);
            resources.ApplyResources(this.grpone, "grpone");
            this.grpone.Name = "grpone";
            this.grpone.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCancel1_Click_1);
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // SelectForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grpone);
            this.Controls.Add(this.grptwo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labchoice);
            this.Controls.Add(this.btnColse);
            this.Controls.Add(this.btnSelect);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectForm";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerch)).EndInit();
            this.grptwo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPic)).EndInit();
            this.grpone.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnColse;
        private System.Windows.Forms.Label labchoice;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridView dgvSerch;
        private System.Windows.Forms.GroupBox grptwo;
        private System.Windows.Forms.PictureBox picPic;
        private System.Windows.Forms.GroupBox grpone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdate;
    }
}

