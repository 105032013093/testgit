using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FilmsSelect
{
    public partial class ExitForm : Form
    {
        public ExitForm()
        {
            InitializeComponent();
        }





        private void rdoExit_Click(object sender, EventArgs e)//���û�ѡ��ĳ���˳��¼�
        {
            string Exit = ((RadioButton)sender).Text;//ѡ��İ�ť

        }

        private void btnNO_Click(object sender, EventArgs e)//���ȡ����ť
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();//�رմ��˳�����
        }

        private void btnOK_Click(object sender, EventArgs e)//���ȷ����ť�������¼�
        {
            if (rdoExit1.Checked)
            {
                Application.Exit();//���ѡ��ֱ���˳����ر���������
            }

            else
            {
                this.Close();
                LoginForm logionForm = new LoginForm();//ѡ�񻻰��˳����򿪵�½����
                logionForm.Show();
            }
        }


    }
}