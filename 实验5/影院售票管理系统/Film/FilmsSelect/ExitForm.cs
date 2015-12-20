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





        private void rdoExit_Click(object sender, EventArgs e)//当用户选中某个退出事件
        {
            string Exit = ((RadioButton)sender).Text;//选择的按钮

        }

        private void btnNO_Click(object sender, EventArgs e)//点击取消按钮
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();//关闭此退出窗口
        }

        private void btnOK_Click(object sender, EventArgs e)//点击确定按钮发生的事件
        {
            if (rdoExit1.Checked)
            {
                Application.Exit();//如果选择直接退出，关闭整个程序
            }

            else
            {
                this.Close();
                LoginForm logionForm = new LoginForm();//选择换班退出，打开登陆窗口
                logionForm.Show();
            }
        }


    }
}