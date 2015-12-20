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

        //����¼����ť�ĵ����¼�
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isValidUser = false;   //��ʶ�Ƿ�Ϊ�Ϸ��û�

            string message = "";

            if (ValidateInput())           //�����ж��û��������Ƿ���������
            {
                //��֤�û��Ƿ�Ϸ��ķ���
                isValidUser = ValidateUser(txtID.Text, txtPwd.Text, cboType.Text, ref message);

                //����ǺϷ����û��ʹ�����Ӧ�Ĵ���
                if (isValidUser)
                {
                    UserHelper.loginId = txtID.Text;        //��������û����浽��̬������
                    UserHelper.loginType = cboType.Text;    //��ѡ��ĵ�¼���ͱ��浽��̬������



                    if (cboType.Text == "����Ա")
                    {
                        //����ǹ���Ա��ת����Ӧ��������
                        MainForm main = new MainForm();
                        main.ShowDialog();
                        this.Visible = false;//���ش���
                    }
                    else if (cboType.Text == "��ƱԱ")
                    {
                        //����ǹ���Ա��ת����Ӧ��������
                        MainForm main = new MainForm();
                        main.ShowDialog();
                        this.Visible = false;//���ش���
                    }
                }
                else     //ʧ�ܸ�����ʾ
                {
                    MessageBox.Show(message, "������ʾ",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        //===========================================================�ж��û��������Ƿ�����[����]=========================================================
        /// <summary>
        /// �ж��û��������Ƿ���������ȷ����true , ʧ�ܷ���false
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
                MessageBox.Show("�������û���", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();    //����û�û�������������ͻ�ͣ���Ǹ��ط�
                isValidate = false;
            }
            else if (Pwd == "")
            {
                MessageBox.Show("����������", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwd.Focus();    //����û�û�������������ͻ�ͣ���Ǹ��ط�
                isValidate = false;
            }
            else if (Type == "")
            {
                MessageBox.Show("�������û�����", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboType.Focus();    //����û�û�������������ͻ�ͣ���Ǹ��ط�
                isValidate = false;
            }
            else
            {
                isValidate = true;
            }
            return isValidate;
        }
        //==========================================================�ж��û��������Ƿ�Ϸ�[����]=========================================================
        /// <summary>
        /// �ж��û��������Ƿ�Ϸ�����ȷ����true , ʧ�ܷ���false
        /// message����������¼��֤ʧ�ܵ�ԭ��
        /// </summary>
        private bool ValidateUser(string LoginId, string LoginPwd, string LoginType, ref string message)
        {
            bool isCorrect = false;  //��һ��bool����

            if (LoginType == "����Ա")
            {
                //��ѯsql���
                string sql = string.Format(@"select count(*) from Types where TLgionId='{0}' 
                                            and TLgionPwd='{1}'and TLgoinType='����Ա'", LoginId, LoginPwd);

                //�������ݿ�����
                try
                {
                    //����Command����
                    SqlCommand comm = new SqlCommand(sql, DBHelper.conn);

                    //�����ݿ�����
                    DBHelper.conn.Open();

                    //ִ������ж��û��Ƿ�Ϸ���
                    int count = (int)comm.ExecuteScalar();
                    if (count != 1)
                    {
                        message = "�û��������벻����";
                        isCorrect = false;
                    }
                    else
                    {
                        isCorrect = true;
                    }
                }
                catch (Exception ex)
                {
                    message = "�������ݿ����";
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    //�ر����ݿ�����
                    DBHelper.conn.Close();
                }
            }
            else if (LoginType == "��ƱԱ")
            {
                string sql = string.Format(@"select count(*) from Types where TLgionId='{0}' 
                                            and TLgionPwd='{1}'and TLgoinType='��ƱԱ'", LoginId, LoginPwd);


                //�������ݿ�����
                try
                {
                    //����Command����
                    SqlCommand comm = new SqlCommand(sql, DBHelper.conn);

                    //�����ݿ�����
                    DBHelper.conn.Open();

                    //ִ������ж��û��Ƿ�Ϸ���
                    int count = (int)comm.ExecuteScalar();
                    if (count != 1)
                    {
                        message = "�û��������벻����";
                        isCorrect = false;
                    }
                    else
                    {
                        isCorrect = true;
                    }
                }
                catch (Exception ex)
                {
                    message = "�������ݿ����";
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    //�ر����ݿ�����
                    DBHelper.conn.Close();
                }
            }
            return isCorrect;
        }

        //��������û�����
        private void LoginForm_Load(object sender, EventArgs e)
        {
            cboType.Items.Add("����Ա");
            cboType.Items.Add("��ƱԱ");
        }

        //�˳�
        private void btnColse_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}