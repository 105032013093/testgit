namespace FilmsSelect
{
    partial class AboutForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("邓思捷");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("组长", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("李翔宇");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("胡壮观");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("林益舟");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("杨梅");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("组员", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("软工第四小组", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(18, 7);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点2";
            treeNode1.Text = "邓思捷";
            treeNode2.Name = "节点1";
            treeNode2.Text = "组长";
            treeNode3.Name = "节点7";
            treeNode3.Text = "李翔宇";
            treeNode4.Name = "节点8";
            treeNode4.Text = "胡壮观";
            treeNode5.Name = "节点9";
            treeNode5.Text = "林益舟";
            treeNode6.Name = "节点10";
            treeNode6.Text = "杨梅";
            treeNode7.Name = "节点6";
            treeNode7.Text = "组员";
            treeNode8.Name = "节点0";
            treeNode8.Text = "软工第四小组";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(239, 176);
            this.treeView1.TabIndex = 4;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 189);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于我们";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}