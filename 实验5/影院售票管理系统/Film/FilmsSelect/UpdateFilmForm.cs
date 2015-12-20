using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Data.SqlClient;
namespace FilmsSelect
{
    public partial class UpdateFilmForm : Form
    {
        private SqlDataAdapter adapter; //����������
        private DataSet dataSet;        //���ݼ�
        public UpdateFilmForm()
        {
            InitializeComponent();
        }
        //����ļ����¼�
        private void UpdateFilmForm_Load(object sender, EventArgs e)
        {
            PathHelper.relPath = "";
            txtName.Focus();
            //���Ƥ������
            //skinLogin.SkinFile = "skin\\Vista1\\vista1_green.ssk";
            TypeGet();//��Ӱ����
            TimeGet();//��ӳʱ��ʹ���
            Get();    //������ݼ�����ӡ����
        }

        //��֤ѡ��ķ�ӳʱ��͵�Ӱ�Ƿ��ظ�trueΪ���Բ���
        private bool IfRepeat1(String data, String Time, int ID)
        {
            bool isbool = false;//�ж��Ƿ�Ϊ�ظ�
            String sql = String.Format(@"SELECT count(*)
                                         FROM Film AS F,Time AS T
                                         WHERE F.FTimeID=T.TID AND F.FDate='{0}' AND T.TTime='{1}' AND F.FID={2}", data, Time, ID);
            try
            {
                //�����ݿ�����
                DBHelper.conn.Open();
                //���� Command ����
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);

                //��֤��ӳʱ���Ƿ��ظ�
                int count = Convert.ToInt32(comm.ExecuteScalar());
                if (count == 1)             //�ö��е�Ӱ
                {
                    isbool = true;
                }
                else
                {
                    DBHelper.conn.Close();
                    if (IfRepeat2(data, Time))//ΪTrueʱ˵���ö�û�е�Ӱ
                    {
                        isbool = true;
                    }
                    else
                    {
                        MessageBox.Show("��ʱ������е�Ӱ��");
                        isbool = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                isbool = false;
            }
            finally
            {
                DBHelper.conn.Close();//�ر����ݿ�
            }
            return isbool;
        }
        //��֤ѡ��ķ�ӳʱ���Ƿ��ظ�trueΪ��ʱ���û��ӰƬ
        private bool IfRepeat2(String data, String Time)
        {
            bool isbool = false;//�ж��Ƿ�Ϊ�ظ�
            String sql = String.Format(@"SELECT count(*)
                                         FROM Film AS F,Time AS T
                                         WHERE F.FTimeID=T.TID AND F.FDate='{0}' AND T.TTime='{1}'", data, Time);
            try
            {
                //�����ݿ�����
                DBHelper.conn.Open();
                //���� Command ����
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                //��֤��ӳʱ���Ƿ��ظ�
                int count = Convert.ToInt32(comm.ExecuteScalar());
                if (count == 1)//�ö��е�Ӱ
                {
                    isbool = false;
                }
                else
                {
                    isbool = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                isbool = false;
            }
            finally
            {
                DBHelper.conn.Close();//�ر����ݿ�
            }
            return isbool;
        }
        #region �����������ʽ
        //-----------------------------------------------------------------------------------------//

        //�����ݿ��е�����Ӱ����
        private void TypeGet()
        {
            String sql = "SELECT SSort FROM Sort";
            try
            {
                //����Command����
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                DBHelper.conn.Open();
                //ִ�в�ѯ���
                SqlDataReader reader = comm.ExecuteReader();
                //ѭ����ȡ��¼
                while (reader.Read())
                {
                    cboType.Items.Add(reader["SSort"].ToString());
                }
                reader.Close();
            }//try����
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
        }

        //�õ�ѡ��ĵ�Ӱ���͵�������ʶ�� SOID
        private int Type(String type)
        {
            int SOID = 0;
            String sql = String.Format(@"SELECT SOID
                                        FROM Sort
                                        WHERE SSort='{0}'", type);
            try
            {
                //����Command����
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                DBHelper.conn.Open();
                //ִ�в�ѯ���
                SqlDataReader reader = comm.ExecuteReader();
                //ѭ����ȡ��¼
                while (reader.Read())
                {
                    SOID = Convert.ToInt32(reader["SOID"]);
                }
                reader.Close();
            }//try����
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
            return SOID;
        }

        //�����ݿ��е�����ӳʱ��
        private void TimeGet()
        {
            String sql = "SELECT TTime FROM Time";
            try
            {
                //����Command����
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                DBHelper.conn.Open();
                //ִ�в�ѯ���
                SqlDataReader reader = comm.ExecuteReader();
                //ѭ����ȡ��¼
                while (reader.Read())
                {
                    cboTime.Items.Add(reader["TTime"].ToString());
                }
                reader.Close();
            }//try����
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
        }

        //�õ�ѡ��ʱ��ı�ʶ�� TID
        private int Time(String time)
        {
            int TID = 0;
            String sql = String.Format(@"SELECT TID
                                        FROM Time
                                        WHERE TTime='{0}'", time);
            try
            {
                //����Command����
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                DBHelper.conn.Open();
                //ִ�в�ѯ���
                SqlDataReader reader = comm.ExecuteReader();
                //ѭ����ȡ��¼
                while (reader.Read())
                {
                    TID = Convert.ToInt32(reader["TID"]);//����ʶ�и���TID
                }
                reader.Close();
            }//try����
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
            return TID;
        }

        //����ѡ���ʱ����������ӳ����
        private String HallGet(String cboTime)
        {
            String sql = String.Format(@"SELECT H.HHall
                                         FROM Time AS T,Hall AS H
                                         WHERE T.THallID=H.HID AND T.TTime='{0}'", cboTime);
            String hall = "";
            try
            {
                //����Command����
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                DBHelper.conn.Open();
                //ִ�в�ѯ���
                SqlDataReader reader = comm.ExecuteReader();
                //ѭ����ȡ��¼
                while (reader.Read())
                {
                    hall = reader["HHall"].ToString();
                }
                reader.Close();
            }//try����
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
            return hall;
        }

        //�Զ�������ӳ����-----------  ����뿪�¼�
        private void cboTime_Leave(object sender, EventArgs e)
        {
            txtHall.Text = HallGet(cboTime.Text);
        }

        //�ж������Ƿ�Ϊ��
        private bool ValidateInput()
        {
            if (txtName.Text == "")//�жϵ�Ӱ�����Ƿ�����
            {
                MessageBox.Show("�������Ӱ���ƣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtName.Focus();
                return false;
            }
            else if (cboType.Text == "")//�ж������Ƿ�ѡ��������
            {
                MessageBox.Show("��ѡ�����ͣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cboType.Focus();
                return false;
            }
            else if (txtMain.Text == "")//�ж������Ƿ�����
            {
                MessageBox.Show("���������ݣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtMain.Focus();
                return false;
            }

            else if (txtDirect.Text == "")//�жϵ����Ƿ�����
            {
                MessageBox.Show("�����뵼�ݣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtDirect.Focus();
                return false;
            }
            else if (txtLanguage.Text == "")//�ж������Ƿ�����
            {
                MessageBox.Show("���������ԣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtLanguage.Focus();
                return false;
            }
            else if (txtContent.Text == "")//�жϵ�Ӱ����Ƿ�����
            {
                MessageBox.Show("�������Ӱ��飡", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtContent.Focus();
                return false;
            }
            else if (txtMoney.Text == "")//�жϼ۸��Ƿ�����
            {
                MessageBox.Show("������۸�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtMoney.Focus();
                return false;
            }
            else if (cboTime.Text == "")
            {
                MessageBox.Show("��ѡ���ӳʱ�䣡", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cboTime.Focus();
                return false;
            }
            else if (txtHour.Text == "")//�ж�Ƭ���Ƿ�����
            {
                MessageBox.Show("������Ƭ����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtHour.Focus();
                return false;
            }
            else if (Convert.ToInt32(txtHour.Text) > 240)//�ж���ȷ��Ƭ��
            {
                MessageBox.Show("��������ȷ��Ƭ����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtHour.Focus();
                return false;
            }
            return true;
        }

        //�۸�ֻ����д 0~9 ����
        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ֻ�ܹ�����0~9(ASC:48~57)֮����ַ��������˸�� ASC:8)
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                if (e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        //��ӰƬ��ֻ���� 0~9 ������
        private void txtHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ֻ�ܹ�����0~9(ASC:48~57)֮����ַ��������˸�� ASC:8)
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                if (e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        //���Ʒ�ӳ��Ƭ��Ϊ 1~180 (����)------------- ����뿪�¼�
        private void txtHour_Leave(object sender, EventArgs e)
        {
            if (txtHour.Text != "")
            {
                String strContent = txtHour.Text.Trim(); //�õ�txtNum1����
                int num = int.Parse(strContent); //ת��������
                if (num > 180 || num < 1) //�ж�
                {
                    MessageBox.Show("��ֵӦ��1~180֮��"); //����
                    txtHour.Focus(); //�������л�
                }
            }
            //else
            //{
            //    MessageBox.Show("�����������ݺ����뿪��");
            //    txtHour.Focus(); //�лؽ���
            //}
        }

        //�������
        private void Clear()
        {
            txtName.Text = "";          //��յ�Ӱ����
            txtMain.Text = "";          //�������
            cboType.Text = "";            //Ĭ��Ϊ��
            txtDirect.Text = "";        //������Ϣ
            txtLanguage.Text = "";      //�������
            txtContent.Text = "";       //��ռ��
            txtMoney.Text = "";         //��ռ۸�
            cboTime.Text = "";            //Ĭ��Ϊ��
            txtHour.Text = "";          //���Ƭ��
        }

        //------------------------------------------------------------------------------------------//
        #endregion

        #region DataGirdView���¼�
        //�������ݵ� DataGirdView ��
        private void Get()
        {
            //��д sql ���
            String sql = @"SELECT F.FID AS ID,F.FFilmName AS '��Ӱ����',F.FDirector AS '����',F.FPlay AS '��Ա',F.FIntro AS '���',F.FLanguage AS '����',F.FLong AS 'Ƭ��',F.FDate AS '��ӳ����',T.TTime AS '��ӳʱ��',F.FMoney AS '�۸�',S.SSort AS '����',H.HHall AS '��ӳ����',F.FPhoto AS '����·��'
                            FROM Film AS F,Sort AS S,Time AS T,Hall AS H
                            WHERE F.FTimeID=T.TID AND F.FSortID=S.SOID AND H.HID=T.THallID";

            //�������ݼ�������
            adapter = new SqlDataAdapter(sql, DBHelper.conn);
            //�������ݼ�����
            dataSet = new DataSet("Film");

            //������ݼ�
            adapter.Fill(dataSet, "Film");

            //�󶨵� DataGirdView ��
            dgvFilm.DataSource = dataSet.Tables["Film"];

            //����ID�е�����
            dgvFilm.Columns["ID"].Visible = false;

            //���غ�������
            dgvFilm.Columns["����·��"].Visible = false;
        }

        //����ƶ��¼�
        private void dgvFilm_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            //��֤������
            if (e.RowIndex >= 0)
            {
                //�б�������Ϊ��ɫ
                dgvFilm.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                //����������Ϊ��ɫ
                dgvFilm.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
        }

        //�������뿪�¼�
        private void dgvFilm_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            //��֤������
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex % 2 == 0)
                {
                    //�б�������Ϊ��ɫ
                    dgvFilm.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    //����������Ϊ��ɫ
                    dgvFilm.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    //�б�������Ϊ��ɫ
                    dgvFilm.Rows[e.RowIndex].DefaultCellStyle.BackColor = dgvFilm.AlternatingRowsDefaultCellStyle.BackColor;
                    //����������Ϊ��ɫ
                    dgvFilm.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        /// <summary>
        /// ��굥����Ԫ�����⴦�����¼����õ���Ӱ������,���������·��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFilm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ʹ���·���Ϸ�
            Directory.SetCurrentDirectory(PathHelper.currentDirectory);

            //dataSet.Tables["Film"].Clear();
            //adapter.Fill(dataSet, "Film");
            //��֤���������
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                //�õ���Ӱ������FID
                UserHelper.ID = Convert.ToInt32(dgvFilm.Rows[e.RowIndex].Cells["ID"].Value);
                GetInfo(UserHelper.ID);
                PathHelper.relPath = dgvFilm.Rows[e.RowIndex].Cells["����·��"].Value.ToString().Trim();
            }
        }

        //��������������洰������
        private void GetInfo(int ID)
        {
            String sql = String.Format(@"SELECT F.FID AS ID,F.FFilmName AS '��Ӱ����',F.FDirector AS '����',F.FPlay AS '��Ա',F.FIntro AS '���',F.FLanguage AS '����',F.FLong AS 'Ƭ��',F.FDate AS '��ӳ����',F.FMoney AS '�۸�',T.TTime AS '��ӳʱ��',S.SSort AS '����',T.TTime AS 'ʱ��',H.HHall AS '��ӳ����'
                           FROM Film AS F,Sort AS S,Time AS T,Hall AS H
                           WHERE F.FTimeID=T.TID AND F.FSortID=S.SOID AND H.HID=T.THallID AND F.FID={0}", ID);
            try
            {
                //�����ݿ������
                DBHelper.conn.Open();
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    txtName.Text = reader["��Ӱ����"].ToString();
                    txtDirect.Text = reader["����"].ToString();
                    cboType.Text = reader["����"].ToString();
                    txtLanguage.Text = reader["����"].ToString();
                    txtMain.Text = reader["��Ա"].ToString();
                    txtMoney.Text = reader["�۸�"].ToString();
                    txtHour.Text = reader["Ƭ��"].ToString();
                    cboTime.Text = reader["ʱ��"].ToString();
                    txtHall.Text = reader["��ӳ����"].ToString();
                    dateTimePicker.Text = reader["��ӳ����"].ToString();
                    txtContent.Text = reader["���"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //�ر����ݿ�����
                DBHelper.conn.Close();
            }
        }
        #endregion

        /// <summary>
        /// ������Ӱ�ı����޸��¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String dateTime = (dateTimePicker.Value).ToString().Trim();
            String date = dateTime.Substring(0, dateTime.Length - 8).Trim();

            try
            {
                //�����ݿ�����
                if (ValidateInput() && IfRepeat1(date, cboTime.Text.Trim(), UserHelper.ID))
                {
                    String sql = String.Format(@"UPDATE Film SET FFilmName='{0}',FDirector='{1}',FPlay='{2}',FIntro='{3}',FLanguage='{4}',
                                        FLong={5},FDate='{6}',FMoney={7},FSortID={8},FTimeID={9}
                                        WHERE FID={10}", txtName.Text.Trim(), txtDirect.Text.Trim(), txtMain.Text.Trim(),
                                        txtContent.Text.Trim(), txtLanguage.Text.Trim(), Convert.ToInt32(txtHour.Text.Trim()),
                                        date, Convert.ToInt32(txtMoney.Text.Trim()), Convert.ToInt32(Type(cboType.Text)),
                                        Convert.ToInt32(Time(cboTime.Text)), UserHelper.ID);
                    DialogResult result = MessageBox.Show("�Ƿ񱣴��޸ģ�", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        DBHelper.conn.Open();
                        //���� Command ����
                        SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                        int count = Convert.ToInt32(comm.ExecuteNonQuery());
                        if (count == 1)
                        {
                            MessageBox.Show("�޸ĳɹ���");
                            Clear();//���
                            UpdateNew();//ˢ��
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();//�ر����ݿ�
            }
        }

        //ˢ�·���
        public void UpdateNew()
        {
            //��д sql ���
            String sql = @"SELECT F.FID AS ID,F.FFilmName AS '��Ӱ����',F.FDirector AS '����',F.FPlay AS '��Ա',F.FIntro AS '���',F.FLanguage AS '����',F.FLong AS 'Ƭ��',F.FDate AS '��ӳ����',T.TTime AS '��ӳʱ��',F.FMoney AS '�۸�',S.SSort AS '����',H.HHall AS '��ӳ����',F.FPhoto AS '����·��'
                            FROM Film AS F,Sort AS S,Time AS T,Hall AS H
                            WHERE F.FTimeID=T.TID AND F.FSortID=S.SOID AND H.HID=T.THallID";
            //�������ݼ�������
            adapter = new SqlDataAdapter(sql, DBHelper.conn);
            dataSet.Tables["Film"].Clear();//��ձ� Film ������
            adapter.Fill(dataSet, "Film");//�����������
        }

        //����ˢ���¼�
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateNew();//ˢ��
        }

        //����ȡ���¼�
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();   //�رյ�ǰ����
        }

        #region �������һ�ɾ����ť�¼�
        //����ɾ����ť�¼�
        private void btnDelect_Click(object sender, EventArgs e)
        {
            //��д SQL ���
            String sqlFilm = String.Format(@"DELETE FROM Film
                                         WHERE FID={0}", UserHelper.ID);
            String sqlMoney = String.Format(@"DELETE FROM Money
                                         WHERE MFilmID={0}", UserHelper.ID);
            DialogResult result = MessageBox.Show("�Ƿ�ɾ����", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                if (Delete(sqlMoney) && Delete(sqlFilm))
                {
                    MessageBox.Show("ɾ���ɹ���");
                    Clear();//���
                    UpdateNew();//ˢ��
                }
            }
        }

        //�һ�ɾ����ť�¼�
        private void tmsiDelect_Click(object sender, EventArgs e)
        {
            //��д SQL ���
            String sqlFilm = String.Format(@"DELETE FROM Film
                                         WHERE FID={0}", UserHelper.ID);
            String sqlMoney = String.Format(@"DELETE FROM Money
                                         WHERE MFilmID={0}", UserHelper.ID);
            DialogResult result = MessageBox.Show("�Ƿ�ɾ����", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                if (Delete(sqlMoney) && Delete(sqlFilm))
                {
                    MessageBox.Show("ɾ���ɹ���");
                    Clear();//���
                    UpdateNew();//ˢ��
                }
            }
        }
        #endregion

        //ɾ�����
        private bool Delete(String sql)
        {
            try
            {
                DBHelper.conn.Open();
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                if (comm.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
            return false;
        }

        //�����޸ĺ�����ť
        private void TsmiSelect_Click(object sender, EventArgs e)
        {
            ViewForm view = new ViewForm(this);
            view.ShowDialog();
        }

        //��ѯ����
        private void SelectFilm()
        {
            //�õ���ȷ�����ڸ�ʽ
            String dateTime = (dateTimePicker1.Value).ToString();
            String date = dateTime.Substring(0, dateTime.Length - 8).Trim();
            String sql = String.Format(@"SELECT F.FID AS ID,F.FFilmName AS '��Ӱ����',F.FDirector AS '����',F.FPlay AS '��Ա',F.FIntro AS '���',F.FLanguage AS '����',F.FLong AS 'Ƭ��',F.FDate AS '��ӳ����',T.TTime AS '��ӳʱ��',F.FMoney AS '�۸�',S.SSort AS '����',H.HHall AS '��ӳ����',F.FPhoto AS '����·��'
                                        FROM Film AS F,Sort AS S,Time AS T,Hall AS H
                                        WHERE F.FTimeID=T.TID AND F.FSortID=S.SOID AND H.HID=T.THallID AND FDate='{0}'", date);
            //�������ݼ�������
            adapter = new SqlDataAdapter(sql, DBHelper.conn);
            dataSet.Tables["Film"].Clear();//��ձ� Film ������
            adapter.Fill(dataSet, "Film");//�����������
        }

        //������ѯ��ť�¼�
        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectFilm();
        }

    }
}