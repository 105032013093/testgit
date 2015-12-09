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
    public partial class ExitForm : Form
    {
        public ExitForm()
        {
            InitializeComponent();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }
    }
}
