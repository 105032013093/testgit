using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FilmsSelect
{
    public partial class MemberForm1 : Form
    {
        public MemberForm1()
        {
            InitializeComponent();
        }


        private void MemberForm1_Load(object sender, EventArgs e) //窗体事件
        {
            labClew.Visible = false; //设置"labClew"隐藏属性
            labNumber.Visible = false; //设置"labPhone"隐藏属性
            cboType.Items.Add("钻石会员");
            cboType.Items.Add("金卡会员");
            cboType.Items.Add("银卡会员");
        }



        private void btnAdd_Click(object sender, EventArgs e) //"btnCorrect"鼠标点击事件
        {
            int agio = 0;
            if (cboType.Text == "钻石会员")
            {
                agio = 60;
            }
            else if (cboType.Text == "金卡会员")
            {
                agio = 65;
            }
            else if (cboType.Text == "银卡会员")
            {
                agio = 70;
            }

            try
            {

                if (ValidateInput())
                {
                    DBHelper.conn.Open(); //打开数据库
                    string sql = string.Format(@"insert into Member( MName,MIDcard,Mphone,MDiscount,MType)
                                               values ('{0}','{1}','{2}',{3},'{4}')", txtName.Text, txtPeopleId.Text, txtPhone.Text, agio, cboType.Text);  //插入数据
                    SqlCommand command = new SqlCommand(sql, DBHelper.conn);
                    int row = command.ExecuteNonQuery();
                    if (row == 1)
                    {
                        UserHelper.MemberID = txtPeopleId.Text.Trim();//存储输入的身份证
                        UserHelper.type = cboType.Text.Trim();        //存储输入的会员类型
                        DialogResult results = MessageBox.Show("注册成功！继续订票....", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("注册失败！");
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();  //关闭数据库
            }


        }



        private void txtPeopleId_TextChanged_1(object sender, EventArgs e)//"Text"更改时触发事件
        {

            if (txtPeopleId.Text.Length == 18) // 证件长度必须等于18位
            {
                labClew.Visible = false;
            }
            else
            {
                labClew.Visible = true;
            }
        }


        private void txtPeopleId_KeyPress_1(object sender, KeyPressEventArgs e) //证件栏只能输入数字
        {
            //只能够输入0~9(ASC:48~57)之间的字符（包括退格键 ASC:8)
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                if (e.KeyChar != 8)
                    e.Handled = true;
            }
        }


        private bool ValidateInput()
        {
            return Input();
        }//方法判断

        private bool Input() //方法判断
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();  //焦点返回
                return false;
            }
            else if (cboType.Text.Trim() == "")
            {
                MessageBox.Show("请选择会员类型", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboType.Focus();  //焦点返回
                return false;
            }
            else if (txtPeopleId.Text.Trim() == "")
            {
                MessageBox.Show("请输有效证件", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPeopleId.Focus();  //焦点返回
                return false;
            }
            else if (txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("请输入联系方式", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhone.Focus();  //焦点返回
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtPhone_KeyPress_1(object sender, KeyPressEventArgs e) //联系方式栏只能输入数字
        {
            //只能够输入0~9(ASC:48~57)之间的字符（包括退格键 ASC:8)
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                if (e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        private void txtPhone_TextChanged_1(object sender, EventArgs e) //"Text"更改时触发事件
        {

            if (txtPhone.Text.Length == 11) // 号码长度必须等于11位
            {
                labNumber.Visible = false;
            }
            else
            {
                labNumber.Visible = true;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtPeopleId_Leave_1(object sender, EventArgs e) //鼠标离开txtPeopleId触发事件
        {
            if (txtPeopleId.Text.Length != 18)   //如果证件长度不是18位就弹出提示窗口
            {
                MessageBox.Show("您输入的证件不合法，请重新输入！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPeopleId.Clear();   //清除txtPeopleId内容
                txtPeopleId.Focus();   //焦点返回
            }
        }

        private void txtPhone_Leave_1(object sender, EventArgs e) //鼠标离开txtPhone触发事件
        {
            if (txtPhone.Text.Length != 11)  //如果联系号码不是11位就弹出提示窗口
            {
                MessageBox.Show("您输入的联系方式不合法，请重新输入！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhone.Clear();  //清除txtPhone内容
                txtPhone.Focus(); //焦点返回
            }



        }





















    }
}