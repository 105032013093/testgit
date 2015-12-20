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
    public partial class MemberForm : Form
    {
        //���ݼ����� 
        DataSet da = new DataSet();
        //������
        SqlDataAdapter adapter;
        public MemberForm()
        {
            InitializeComponent();
        }

        private void MemberInformationForm_Load(object sender, EventArgs e) //�����¼�
        {
            if (UserHelper.loginType == "��ƱԱ")
                tsmiDelete.Enabled = false;
            
           
            cboStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStyle.Items.Add("��ʯ��Ա");
            cboStyle.Items.Add("�𿨻�Ա");
            cboStyle.Items.Add("������Ա");

            String sql = ("SELECT MID,MName,MIDcard,MPhone,MDiscount,MType FROM Member");
            adapter = new SqlDataAdapter(sql, DBHelper.conn);
            adapter.Fill(da, "Member");
            dgvMemberInformation.DataSource = da.Tables["Member"];
            //��������
            dgvMemberInformation.Columns["MName"].HeaderText = "����";
            dgvMemberInformation.Columns["MIDcard"].HeaderText = "֤����";
            dgvMemberInformation.Columns["MPhone"].HeaderText = "�绰����";
            dgvMemberInformation.Columns["MDiscount"].HeaderText = "�ۿ�����";
            dgvMemberInformation.Columns["MType"].HeaderText = "��Ա����";


            //����"MID"��
            dgvMemberInformation.Columns["MID"].Visible = false;

            //����"MType"�� ֻ��
            dgvMemberInformation.Columns["MType"].ReadOnly = true;
        }

        private void btnSearch_Click(object sender, EventArgs e) //����"btnSearch"�¼�
        {

            String sql = (@"SELECT MID, MName,MIDcard,MPhone,MDiscount,MType FROM Member");
            //����
            switch (cboStyle.Text)
            {
                case "��ʯ��Ա":
                    sql += " WHERE MType='��ʯ��Ա'";
                    break;
                case "�𿨻�Ա":
                    sql += " WHERE MType='�𿨻�Ա'";
                    break;
                case "������Ա":
                    sql += " WHERE MType='������Ա'";
                    break;
                default:
                    break;
            }
            da.Tables["Member"].Clear();
            adapter.SelectCommand.CommandText = sql;
            adapter.Fill(da, "Member");
        }

        private void dgvMemberInformation_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e) //"dgvMemberInformation"����ƶ��¼�
        {
            //��֤������
            if (e.RowIndex >= 0)
            {
                //�б�������
                dgvMemberInformation.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.SkyBlue;
                //����������
                dgvMemberInformation.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.SeaShell;
            }
        }

        private void dgvMemberInformation_CellMouseLeave(object sender, DataGridViewCellEventArgs e) //"dgvMemberInformation"����뿪�¼�
        {
            //��֤������
            if (e.RowIndex >= 0)
            {
                //�б�������
                dgvMemberInformation.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                //����������
                dgvMemberInformation.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void btnExit_Click(object sender, EventArgs e) // ����"btnCancel"��ѯ�¼�
        {
            //���"ȡ��"�رմ���
            this.Close();
        }


        private void tsmiDelete_Click(object sender, EventArgs e) //�һ�"ɾ��"�¼�
        {
            string id = dgvMemberInformation.SelectedRows[0].Cells["MID"].Value.ToString(); //�õ���Ա������ID
            try
            {
                DBHelper.conn.Open(); //�����ݿ�
                string sql = string.Format("DELETE FROM Member WHERE MID={0} ", Convert.ToInt32(id));
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);

                if (comm.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("ɾ���ɹ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("ɾ��ʧ�ܣ�");
                }
                da.Tables["Member"].Clear();
                adapter.Fill(da, "Member");


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

        private void btnRefresh_Click(object sender, EventArgs e) //����"btnRefurbish"ˢ���¼�
        {
            String sql = ("SELECT MID,MName,MIDcard,MPhone,MDiscount,MType FROM Member");
            adapter = new SqlDataAdapter(sql, DBHelper.conn);
            da.Tables["Member"].Clear();
            adapter.Fill(da, "Member");
            dgvMemberInformation.DataSource = da.Tables["Member"];
        }

        private void btnRegister_Click(object sender, EventArgs e)   //���"���"�¼�
        {
            this.Close();
            RegistForm re = new RegistForm();
            re.ShowDialog();

        }

        //�õ���Ա������
        private int GetNum()
        {
            int num = 0; //������ܻ�Ա������
            String sql = @"SELECT count(*) FROM Member";
            try
            {
                DBHelper.conn.Open();
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                num = Convert.ToInt32(comm.ExecuteScalar());  //�õ���Ա������
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
            return num;
        }
        //�齱����
        private void GetName()
        {
            String sql = @"SELECT MName FROM Member";
            try
            {
                String[] number = new String[GetNum()];   //����������ܻ�Ա���� 
                DBHelper.conn.Open();
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                SqlDataReader reader = comm.ExecuteReader();
                int i = 0;
                while (reader.Read())  //       ѭ��������Ա�������� number ������
                {
                    number[i] = reader["MName"].ToString(); 
                    i++;
                }
                reader.Close();
                Random random = new Random();
                int MemberIndex = random.Next(number.Length);  //����õ�  number ���������ֵ
                txtName.Text = number[MemberIndex];    //�ڿؼ�����ʾ�������Ӧ����
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
        }

        //�����齱��ť�¼�
        private void btnDistill_Click(object sender, EventArgs e)
        {
            GetName();   //����"SetSelectedMemberIds"����
        }
    }
}
