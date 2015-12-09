using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 原型设计
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderForm f1 = new OrderForm();
            f1.Show();
        }

        private void btnColse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
