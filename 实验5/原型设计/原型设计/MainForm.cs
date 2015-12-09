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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsmiFilms_Click(object sender, EventArgs e)
        {
            SelectForm f1 = new SelectForm();
            f1.Show();
        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            AddForm f1 = new AddForm();
            f1.Show();
        }

        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            UpdateFilmForm f1 = new UpdateFilmForm();
            f1.Show();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            UpdateFilmForm f1 = new UpdateFilmForm();
            f1.Show();
        }

        private void tsmiOrder_Click(object sender, EventArgs e)
        {
            SelectForm f1 = new SelectForm();
            f1.Show();
        }

        private void tsmiSearch_Click(object sender, EventArgs e)
        {
            SearchTicketForm f1 = new SearchTicketForm();
            f1.Show();
        }

        private void tsmiMoney_Click(object sender, EventArgs e)
        {
            MoneyForm f1 = new MoneyForm();
            f1.Show();
        }

        private void tsmiMemberInfor_Click(object sender, EventArgs e)
        {
            MemberForm f1 = new MemberForm();
            f1.Show();
        }

        private void tsmiRegister_Click(object sender, EventArgs e)
        {
            RegistForm f1 = new RegistForm();
            f1.Show();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            ExitForm f1 = new ExitForm();
            f1.Show();
        }
    }
}
