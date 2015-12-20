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


        private void MemberForm1_Load(object sender, EventArgs e) //�����¼�
        {
            labClew.Visible = false; //����"labClew"��������
            labNumber.Visible = false; //����"labPhone"��������
            cboType.Items.Add("��ʯ��Ա");
            cboType.Items.Add("�𿨻�Ա");
            cboType.Items.Add("������Ա");
        }



        private void btnAdd_Click(object sender, EventArgs e) //"btnCorrect"������¼�
        {
            int agio = 0;
            if (cboType.Text == "��ʯ��Ա")
            {
                agio = 60;
            }
            else if (cboType.Text == "�𿨻�Ա")
            {
                agio = 65;
            }
            else if (cboType.Text == "������Ա")
            {
                agio = 70;
            }

            try
            {

                if (ValidateInput())
                {
                    DBHelper.conn.Open(); //�����ݿ�
                    string sql = string.Format(@"insert into Member( MName,MIDcard,Mphone,MDiscount,MType)
                                               values ('{0}','{1}','{2}',{3},'{4}')", txtName.Text, txtPeopleId.Text, txtPhone.Text, agio, cboType.Text);  //��������
                    SqlCommand command = new SqlCommand(sql, DBHelper.conn);
                    int row = command.ExecuteNonQuery();
                    if (row == 1)
                    {
                        UserHelper.MemberID = txtPeopleId.Text.Trim();//�洢��������֤
                        UserHelper.type = cboType.Text.Trim();        //�洢����Ļ�Ա����
                        DialogResult results = MessageBox.Show("ע��ɹ���������Ʊ....", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("ע��ʧ�ܣ�");
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();  //�ر����ݿ�
            }


        }



        private void txtPeopleId_TextChanged_1(object sender, EventArgs e)//"Text"����ʱ�����¼�
        {

            if (txtPeopleId.Text.Length == 18) // ֤�����ȱ������18λ
            {
                labClew.Visible = false;
            }
            else
            {
                labClew.Visible = true;
            }
        }


        private void txtPeopleId_KeyPress_1(object sender, KeyPressEventArgs e) //֤����ֻ����������
        {
            //ֻ�ܹ�����0~9(ASC:48~57)֮����ַ��������˸�� ASC:8)
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                if (e.KeyChar != 8)
                    e.Handled = true;
            }
        }


        private bool ValidateInput()
        {
            return Input();
        }//�����ж�

        private bool Input() //�����ж�
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("�������û���", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();  //���㷵��
                return false;
            }
            else if (cboType.Text.Trim() == "")
            {
                MessageBox.Show("��ѡ���Ա����", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboType.Focus();  //���㷵��
                return false;
            }
            else if (txtPeopleId.Text.Trim() == "")
            {
                MessageBox.Show("������Ч֤��", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPeopleId.Focus();  //���㷵��
                return false;
            }
            else if (txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("��������ϵ��ʽ", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhone.Focus();  //���㷵��
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtPhone_KeyPress_1(object sender, KeyPressEventArgs e) //��ϵ��ʽ��ֻ����������
        {
            //ֻ�ܹ�����0~9(ASC:48~57)֮����ַ��������˸�� ASC:8)
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                if (e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        private void txtPhone_TextChanged_1(object sender, EventArgs e) //"Text"����ʱ�����¼�
        {

            if (txtPhone.Text.Length == 11) // ���볤�ȱ������11λ
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


        private void txtPeopleId_Leave_1(object sender, EventArgs e) //����뿪txtPeopleId�����¼�
        {
            if (txtPeopleId.Text.Length != 18)   //���֤�����Ȳ���18λ�͵�����ʾ����
            {
                MessageBox.Show("�������֤�����Ϸ������������룡", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPeopleId.Clear();   //���txtPeopleId����
                txtPeopleId.Focus();   //���㷵��
            }
        }

        private void txtPhone_Leave_1(object sender, EventArgs e) //����뿪txtPhone�����¼�
        {
            if (txtPhone.Text.Length != 11)  //�����ϵ���벻��11λ�͵�����ʾ����
            {
                MessageBox.Show("���������ϵ��ʽ���Ϸ������������룡", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhone.Clear();  //���txtPhone����
                txtPhone.Focus(); //���㷵��
            }



        }





















    }
}