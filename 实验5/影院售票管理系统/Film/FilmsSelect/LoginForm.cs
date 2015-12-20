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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //“登录”按钮的单击事件
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isValidUser = false;   //标识是否为合法用户

            string message = "";

            if (ValidateInput())           //调用判断用户的输入是否完整方法
            {
                //验证用户是否合法的方法
                isValidUser = ValidateUser(txtID.Text, txtPwd.Text, cboType.Text, ref message);

                //如果是合法的用户就传到相应的窗体
                if (isValidUser)
                {
                    UserHelper.loginId = txtID.Text;        //将输入的用户保存到静态变量中
                    UserHelper.loginType = cboType.Text;    //将选择的登录类型保存到静态变量中



                    if (cboType.Text == "管理员")
                    {
                        //如果是管理员，转到相应的主窗体
                        MainForm main = new MainForm();
                        main.ShowDialog();
                        this.Visible = false;//隐藏窗体
                    }
                    else if (cboType.Text == "售票员")
                    {
                        //如果是管理员，转到相应的主窗体
                        MainForm main = new MainForm();
                        main.ShowDialog();
                        this.Visible = false;//隐藏窗体
                    }
                }
                else     //失败给出提示
                {
                    MessageBox.Show(message, "操作提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        //===========================================================判断用户的输入是否完整[方法]=========================================================
        /// <summary>
        /// 判断用户的输入是否完整，正确返回true , 失败返回false
        /// </summary>
        /// <returns></returns>
        private bool ValidateInput()
        {
            bool isValidate = false;
            string ID = txtID.Text.Trim();
            string Pwd = txtPwd.Text.Trim();
            string Type = cboType.Text;
            if (ID == "")
            {
                MessageBox.Show("请输入用户名", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();    //如果用户没有填完整，光标就会停在那个地方
                isValidate = false;
            }
            else if (Pwd == "")
            {
                MessageBox.Show("请输入密码", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwd.Focus();    //如果用户没有填完整，光标就会停在那个地方
                isValidate = false;
            }
            else if (Type == "")
            {
                MessageBox.Show("请输入用户类型", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboType.Focus();    //如果用户没有填完整，光标就会停在那个地方
                isValidate = false;
            }
            else
            {
                isValidate = true;
            }
            return isValidate;
        }
        //==========================================================判断用户的输入是否合法[方法]=========================================================
        /// <summary>
        /// 判断用户的输入是否合法，正确返回true , 失败返回false
        /// message参数用来记录验证失败的原因
        /// </summary>
        private bool ValidateUser(string LoginId, string LoginPwd, string LoginType, ref string message)
        {
            bool isCorrect = false;  //定一个bool变量

            if (LoginType == "管理员")
            {
                //查询sql语句
                string sql = string.Format(@"select count(*) from Types where TLgionId='{0}' 
                                            and TLgionPwd='{1}'and TLgoinType='管理员'", LoginId, LoginPwd);

                //测试数据库连接
                try
                {
                    //创建Command对象
                    SqlCommand comm = new SqlCommand(sql, DBHelper.conn);

                    //打开数据库连接
                    DBHelper.conn.Open();

                    //执行命令（判断用户是否合法）
                    int count = (int)comm.ExecuteScalar();
                    if (count != 1)
                    {
                        message = "用户名或密码不存在";
                        isCorrect = false;
                    }
                    else
                    {
                        isCorrect = true;
                    }
                }
                catch (Exception ex)
                {
                    message = "操作数据库出错";
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    //关闭数据库连接
                    DBHelper.conn.Close();
                }
            }
            else if (LoginType == "售票员")
            {
                string sql = string.Format(@"select count(*) from Types where TLgionId='{0}' 
                                            and TLgionPwd='{1}'and TLgoinType='售票员'", LoginId, LoginPwd);


                //测试数据库连接
                try
                {
                    //创建Command对象
                    SqlCommand comm = new SqlCommand(sql, DBHelper.conn);

                    //打开数据库连接
                    DBHelper.conn.Open();

                    //执行命令（判断用户是否合法）
                    int count = (int)comm.ExecuteScalar();
                    if (count != 1)
                    {
                        message = "用户名或密码不存在";
                        isCorrect = false;
                    }
                    else
                    {
                        isCorrect = true;
                    }
                }
                catch (Exception ex)
                {
                    message = "操作数据库出错";
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    //关闭数据库连接
                    DBHelper.conn.Close();
                }
            }
            return isCorrect;
        }

        //代码添加用户类型
        private void LoginForm_Load(object sender, EventArgs e)
        {
            cboType.Items.Add("管理员");
            cboType.Items.Add("售票员");
        }

        //退出
        private void btnColse_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}