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
    public partial class AddForm : Form
    {
        public AddForm() 
        {
            InitializeComponent();
        }
        //������¼�
        private void AddForm_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            //���Ƥ������
            //skinLogin.SkinFile = "skin\\Vista1\\vista1_green.ssk";
            lblCue.Visible = false;//����ʾ��ǩ����
            TypeGet();//��Ӱ����
            TimeGet();//��ӳʱ��ʹ���
        }

        //���ӵ�Ӱ�ĵ����¼�
        private void btnCorrect_Click(object sender, EventArgs e)
        {
            String dateTime = (dateTimePicker.Value).ToString();
            String date = dateTime.Substring(0, dateTime.Length - 8).Trim();
            if (ValidateInput() && IfRepeat(date, cboTime.Text) == true)
            {

                String Sql = String.Format(@"INSERT INTO Film(FFilmName,FDirector,FPlay,FIntro,FLanguage,FLong,FDate,FMoney,FNumber,FNum,FPhoto,FPew,FComPew,FLove,FSortID,FTimeID)
                                            VALUES('{0}','{1}','{2}','{3}','{4}',{5},'{6}',{7},{8},'{9}','{10}',{11},{12},{13},{14},{15})",
                                      txtName.Text.Trim(), txtDirect.Text.Trim(), txtMain.Text.Trim(), txtContent.Text.Trim(), txtLanguage.Text.Trim(),
                                      Convert.ToInt32(txtHour.Text.Trim()), date, Convert.ToInt32(txtMoney.Text.Trim()),
                                      Convert.ToInt32(txtAmount.Text.Trim()), txtNumber.Text.Trim(), PathHelper.relPathDirectory, 150, 100, 50,
                                      Convert.ToInt32(Type(cboType.Text)), Convert.ToInt32(Time(cboTime.Text.Trim())));
                try
                {
                    //�����ݿ�����
                    DBHelper.conn.Open();
                    DialogResult res = MessageBox.Show("ȷ�������Ӱ��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        SqlCommand comm = new SqlCommand(Sql, DBHelper.conn);
                        int num = Convert.ToInt32(comm.ExecuteNonQuery());
                        if (num == 1)
                        {
                            DialogResult result = MessageBox.Show("����ɹ����Ƿ�������룡", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                            if (result == DialogResult.OK)
                            {
                                DBHelper.conn.Close();
                                if (Money(date, Convert.ToInt32(Time(cboTime.Text.Trim()))))//����Ǯ��
                                {
                                    Clear();//�������
                                }
                            }
                            else
                            {
                                DBHelper.conn.Close();
                                if (Money(date, Convert.ToInt32(Time(cboTime.Text.Trim()))))
                                {
                                    this.Close();//�رմ���
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("��Ӱ����ʧ�ܣ�");
                        }
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
            }
        }

        #region ����Ǯ��
        //�������ӵ�Ӱ���FID
        private int GetFID(String date, int timeId)
        {
            int FID = 0;
            //�����ݿ��в�����ӵ�Ӱ���ID
            String sql = String.Format(@"SELECT FID
                                         FROM Film
                                          WHERE FDate='{0}' AND FTimeID={1}", date, timeId);
            try
            {
                DBHelper.conn.Open();
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    FID = Convert.ToInt32(reader["FID"]);
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
            return FID;
        }
        /// <summary>
        /// ���ӵ�Ӱʱ��Ӧ������һ��Ǯ��
        /// </summary>
        /// <param name="date"></param>
        /// <param name="tiem"></param>
        private bool Money(String date, int timeId)
        {
            bool input = false;
            int FID = GetFID(date, timeId);
            String sql = String.Format(@"INSERT INTO Money(MMoney,MFilmID)
                                         VALUES ({0},{1})", 0, FID);
            try
            {
                DBHelper.conn.Open();
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                int row = comm.ExecuteNonQuery();
                if (row == 1)
                {
                    input = true;
                }
                else
                {
                    input = false;
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
            return input;
        }
        #endregion

        //�����رմ˴���
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //��֤ѡ��ķ�ӳʱ���Ƿ��ظ�
        private bool IfRepeat(String data, String Time)
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
                    MessageBox.Show("��ʱ������е�Ӱ��");
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
            else if (txtAmount.Text == "")//�ж�Ʊ���Ƿ�����
            {
                MessageBox.Show("������Ʊ����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtAmount.Focus();
                return false;
            }
            else if (Convert.ToInt32(txtAmount.Text) > 300)//�ж�Ʊ���Ƿ�������ȷ
            {
                MessageBox.Show("Ʊ�����Ϊ300��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtAmount.Focus();
                return false;
            }
            else if (txtNumber.Text == "")//�ж���λ����Ƿ�����
            {
                MessageBox.Show("��������λ��ţ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtNumber.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// ���뺣�������¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                PathHelper.relPathDirectory = "";//������·��
                String sourcePath = open.FileName; //Դ·��
                Image img = Image.FromFile(sourcePath);//�õ�ѡ�е�ͼƬ
                String name = Path.GetFileName(open.FileName); //�ļ�����
                String relPath = PathHelper.defaultDirectory + "\\" + name; //���Ŀ��·��
                String destPath = PathHelper.currentDirectory + "\\" + relPath; //����Ŀ��·��
                try
                {
                    File.Copy(sourcePath, destPath, true); //�����ļ�.
                    PathHelper.relPathDirectory = relPath;
                    //��ͼƬ��ؼ�����ʾ����
                    picFace.Image = img;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        //�۸�ֻ����д 0~9 ����
        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            ////ֻ�ܹ�����0~9(ASC:48~57)֮����ַ��������˸�� ASC:8)
            //if (e.KeyChar < 48 || e.KeyChar > 57)
            //{
            //    if (e.KeyChar != 8)
            //        e.Handled = true;
            //}
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

        //���������ʱ��ʾ�ķ���
        private void Cue(String txtNum)
        {
            lblCue.Visible = false;//����ʾ��ǩ����
            String strContent = txtNum.Trim();//�õ�txtNum1���û����������
            int len = strContent.Length; //�õ�txtNum1���û��������ݵĳ���
            char[] arrContent = strContent.ToCharArray(); //���ַ�������ת�����ַ�����
            bool isNumber = true; //�Ƿ������ֵı��
            foreach (char chr in arrContent)
            {
                if (!char.IsDigit(chr))
                {
                    isNumber = false;
                    break;
                }
            }
            if (!isNumber) //�жϱ��
            {
                lblCue.Visible = true;
                //txtNum = strContent.Substring(0, len - 1); //��ȥ�ո�����Ĵ����ַ�
                //txtNum.SelectionStart = txtNum.Length; //ʹ���ͣ�������
            }
        }

        //����Ƿ�����ʱ����ʾ---------�����ݱ��ʱ����
        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            Cue(txtMoney.Text.Trim());
        }


        //�������
        private void Clear()
        {
            txtName.Text = "";          //��յ�Ӱ����
            txtMain.Text = "";          //�������
            cboType.SelectedIndex = 0;  //Ĭ��Ϊ��
            txtDirect.Text = "";        //������Ϣ
            txtLanguage.Text = "";      //�������
            txtContent.Text = "";       //��ռ��
            txtMoney.Text = "";         //��ռ۸�
            cboTime.SelectedIndex = 0;  //Ĭ��Ϊ��
            txtHour.Text = "";          //���Ƭ��
            PathHelper.relPathDirectory = "";//���·��
        }
        #endregion
    }
}