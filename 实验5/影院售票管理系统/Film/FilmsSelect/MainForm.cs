using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

using System.Diagnostics;

namespace FilmsSelect
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            if (UserHelper.loginType == "售票员")//判断登录类型，显示相关功能
            {

                tsbtnAdd.Enabled = false;//如果是售票员登陆，增加影片功能不能使用
                tsbtnUptade.Enabled = false;//如果是售票员登陆，更新及修改影片功能不能使用
                tsmiAdd.Enabled = false;//如果是售票员登陆，菜单中增加影片功能不能使用
                tsmiUpdate.Enabled = false;//如果是售票员登陆，菜单中修改影片功能不能使用
                tsmiDelete.Enabled = false;//如果是售票员登陆，菜单中删除影片功能不能使用

            }
            this.tsmiLogin.Text = UserHelper.loginId + "  " + UserHelper.loginType + "  欢迎您！";
            //设置状态栏的标签文本，显示当前登录的用户名
        }

        //鼠标点击时设置

        private void tsmiExit_Click(object sender, EventArgs e)//单击退出，显示退出对话框
        {

            ExitForm exit = new ExitForm();
            exit.ShowDialog();//显示模式窗口
            this.Close();
        }
        private void tsmiAdd_Click(object sender, EventArgs e)//单击影片增加，弹出增加影片窗口
        {
            AddForm add = new AddForm();
            add.ShowDialog();//显示窗口
        }
        private void tsmiUpdate_Click(object sender, EventArgs e)//单击影片修改，弹出修改影片窗口
        {
            UpdateFilmForm update = new UpdateFilmForm();
            update.ShowDialog();

        }
        private void tsmiFilms_Click(object sender, EventArgs e) //显示电影信息查询窗口
        {
            SelectForm select = new SelectForm();
            select.ShowDialog();
        }
        private void tsmiDelete_Click(object sender, EventArgs e)//显示更新（修改、删除）电影信息窗口
        {
            UpdateFilmForm update = new UpdateFilmForm();
            update.ShowDialog();

        }
        private void tsbtnAdd_Click(object sender, EventArgs e)//显示增加电影信息窗口
        {

            AddForm add = new AddForm();
            add.ShowDialog();//显示窗口
        }

        private void tsbtnSearch_Click(object sender, EventArgs e)//显示查询影片窗口
        {
            SelectForm select = new SelectForm();
            select.ShowDialog();
        }

        private void tsbtnUptade_Click(object sender, EventArgs e)//显示更新（修改、删除）电影信息窗口
        {
            UpdateFilmForm update = new UpdateFilmForm();
            update.ShowDialog();
        }

        private void tsbtnOder_Click(object sender, EventArgs e)//显示订票窗口
        {
            SearchTicketForm sea = new SearchTicketForm();
            sea.ShowDialog();
        }

        private void tsmiOrder_Click(object sender, EventArgs e)//显示订票窗口
        {
            SelectForm se = new SelectForm();
            se.ShowDialog();
        }


        private void tsmiSearch_Click(object sender, EventArgs e)//显示查询订票信息
        {
            SearchTicketForm sea = new SearchTicketForm();
            sea.ShowDialog();
        }



        private void tsmiMemberInfor_Click(object sender, EventArgs e)//显示会员信息窗口
        {
            MemberForm men = new MemberForm();
            men.ShowDialog();
        }

        private void tsmiRegister_Click(object sender, EventArgs e)//显示会员注册窗口
        {
            RegistForm nfe = new RegistForm();
            nfe.ShowDialog();
        }

        private void tsmiMoney_Click(object sender, EventArgs e)//显示查询钱箱窗口
        {
            MoneyForm mi = new MoneyForm();
            mi.ShowDialog();
        }

        private void picMember_Click(object sender, EventArgs e)//点击会员按钮，弹出会员信息窗口
        {
                MemberForm men = new MemberForm();
                men.ShowDialog();
        }

        private void picAbout_Click(object sender, EventArgs e)//点击关于显示关于窗口
        {
            AboutForm sbi = new AboutForm();
            sbi.ShowDialog();
        }
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            AboutForm ab = new AboutForm();
            ab.ShowDialog();
        }
    }





}
