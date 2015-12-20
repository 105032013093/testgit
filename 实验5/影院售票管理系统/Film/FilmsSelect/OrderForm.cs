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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        } 

        //��Load�¼����������
        private void OrderForm_Load(object sender, EventArgs e)
        {
            lblnum.Visible = false;
            GetAdd();//<��Ӱ�Ļ���Ĭ����Ϣ>��<����> ====================================���÷���
            for (int i = 1; i <= 150; i++) //���150��ӰƱ
            {
                dudnum.Items.Add(i);
            }
        }



        //�����ݿ��ж���<��Ӱ�Ļ���Ĭ����Ϣ>��<����>====================================���<����>
        private void GetAdd()
        {
            //����������ڵ���λ����
            cboSeat.Items.Add("������");
            cboSeat.Items.Add("Ӳ��");
            cboSeat.Items.Add("����");


            //=====================================�����ݿ��ж����ۿ�����==============================

            string sql = "select AType,ARebate from Agio";
            try
            {
                DBHelper.conn.Open();            //�����ݿ�����
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);  //����Command����
                SqlDataReader reader = comm.ExecuteReader();           //ִ������(ExecuteReader������ȡ���ݵ�)
                while (reader.Read())                                  //ѭ��������λ���ͣ���read()������ȡһ�����ݣ�
                {
                    cboAgio.Items.Add(reader["AType"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }

            #region����Ӱ����Ϣ���������ڶ�Ӧ���ı����
            //�����ݿ��еĵ�Ӱ����Ϣ��������������Ӧ���ı�����===============================================������
            sql = string.Format(@"select F.FID as Id, F.FFilmName as 'Ƭ��',F.FDirector as '����',F.FPlay as '����',F.FIntro as '���',
                                F.FLanguage as '����',F.FLong as 'Ƭ��',F.FDate as '��ӳ����',F.FMoney as 'Ʊ��',
                                F.FNumber as 'Ʊ��',F.FNum as '��λ��',S.SSort as '����',T.TTime as '��ӳʱ��',
                                H.HHall as '����'
                                from Film as F ,Sort as S ,Time as T ,Hall as H
                                where F.FSortID=S.SOID and F.FTimeID = T.TID and H.HID=T.THallID and   F.FID ={0}", UserHelper.Id);
            try
            {
                DBHelper.conn.Open();
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    txtName.Text = reader["Ƭ��"].ToString();
                    txtName.ReadOnly = true;
                    txtMain.Text = reader["����"].ToString();
                    txtMain.ReadOnly = true;
                    txtType.Text = reader["����"].ToString();
                    txtType.ReadOnly = true;
                    txtDirect.Text = reader["����"].ToString();
                    txtDirect.ReadOnly = true;
                    txtTime.Text = reader["��ӳ����"].ToString();
                    txtTime.ReadOnly = true;
                    txtlanguage.Text = reader["����"].ToString();
                    txtlanguage.ReadOnly = true;
                    txtDays.Text = reader["��ӳʱ��"].ToString();
                    txtDays.ReadOnly = true;
                    txtPrice.Text = reader["Ʊ��"].ToString();
                    txtPrice.ReadOnly = true;
                    txtHour.Text = reader["Ƭ��"].ToString();
                    txtHour.ReadOnly = true;
                    txtHall.Text = reader["����"].ToString();
                    txtHall.ReadOnly = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
            #endregion

        }



        #region(�ж�ֻ�������� ASC�� �Լ���֤�����Ƿ��ǺϷ���֤����)
        //���û�����ĳ����ʱ����===============================��ASC���ж��û��Ƿ��˲���0-9��Χ֮�ڵ���
        private void txtCert1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ֻ�ܹ�����0~9(ASC:48~57)֮����ַ��������˸�� ASC:8)
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }
        //�绰����ֻ����������
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ֻ�ܹ�����0~9(ASC:48~57)֮����ַ��������˸�� ASC:8)
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                if (e.KeyChar != 8)
                    e.Handled = true;
            }
        }


        //����ĸ���ֻ��������
        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ֻ�ܹ�����0~9(ASC:48~57)֮����ַ��������˸�� ASC:8)
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                if (e.KeyChar != 8)
                    e.Handled = true;
            }
        }
        //����뿪ʱ����=======================================�ж�֤�������ֲ��ܳ���18
        private void txtCert1_Leave(object sender, EventArgs e)
        {

            //�õ��ı�������������ֵĳ���
            int num = txtCert.Text.Trim().Length;

            if (num != 18)           //�жϳ���
            {
                MessageBox.Show("������Ϸ���֤����<18>λ��", "������ʾ");
                txtCert.Focus();          //�������лص�ԭ���ĵط�
            }
        }

        //����Text������ʱ�������¼�
        private void txtCert_TextChanged(object sender, EventArgs e)
        {
            if (txtCert.Text.Trim().Length != 18)
            {
                lblnum.Visible = true;  //������Ȳ���18λ ��ʾ����
            }
            else
            {
                lblnum.Visible = false; //��18λ ����ʾ
            }
        }

        #endregion


        /// <summary>
        ///  �����ݿ��ж�����Ա�û���֤���� �ķ���======================================���� btnCancel_Click���õ���
        /// </summary>
        /// <param name="cert">֤����</param>
        /// <param name="agio">��Ա����</param>
        /// <returns>no</returns>
        private bool GetCardnum(String cert, String agio)
        {
            bool no = false;
            int no1 = 0;
            try
            {
                DBHelper.conn.Open();
                string sql = string.Format(@"select count(*) from Member
                                             where MIDcard='{0}'and MType='{1}'", cert, agio);  //����Ա��Ϣ(Member) �� ��Ա����(MemberTypes)��������
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                no1 = Convert.ToInt32(comm.ExecuteScalar());
                if (no1 != 1)                                                          //�������Ա��Ϣ(Member) �� ��Ա����(MemberTypes)��ƥ��
                {                                                                       //˵�����ǻ�Ա�� 
                    DialogResult result = MessageBox.Show("�Բ����㲻�ǻ�Ա����ע�ᣡ", "��ʾ��",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        DBHelper.conn.Close();
                        MemberForm1 member = new MemberForm1();
                        member.ShowDialog();
                    }
                    no = false;
                }
                else
                {
                    no = true;
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
            return no;
        }


        /// <summary>
        /// ��֤�û��ڶ�Ʊ��������������Ƿ����� �ķ���
        /// </summary>
        /// <returns></returns>
        private bool ValidateInput()
        {
            bool Conect = false;
            if (cboSeat.Text.Trim() == "")
            {
                MessageBox.Show("��������λ����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSeat.Focus();
                Conect = false;
            }
            else if (cboAgio.Text.Trim() == "")
            {


                MessageBox.Show("�������������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboAgio.Focus();

                Conect = false;
            }

            else if (txtNum1.Text.Trim() == "")
            {
                MessageBox.Show("������ܼ۸�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNum1.Focus();
                Conect = false;
            }
            else if (txtNum2.Text.Trim() == "")
            {
                MessageBox.Show("�����븶��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNum2.Focus();
                Conect = false;
            }
            else if (Convert.ToInt32(txtNumber.Text.Trim()) < Convert.ToInt32(dudnum.Text.Trim()))
            {
                txtNum1.Text = "";
                MessageBox.Show("û��ƱƱ����");
            }
            else if (txtSum.Text.Trim() == "")
            {
                MessageBox.Show("�����㣡", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNum2.Focus();

                Conect = false;
            }
            else if (Convert.ToInt32(txtNum1.Text.Trim()) > Convert.ToInt32(txtNum2.Text.Trim()))
            {
                MessageBox.Show("������㣡", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNum2.Focus();
                txtNum2.Text = "";
                Conect = false;
            }
            else if (Convert.ToInt32(txtNum2.Text.Trim()) - Convert.ToInt32(txtNum1.Text.Trim()) != Convert.ToInt32(txtSum.Text.Trim()))
            {
                MessageBox.Show("�����㣡", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSum.Focus();
                Conect = false;
            }
            else if (txtCert.Text.Trim() == "")
            {
                MessageBox.Show("�������Ա֤����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCert.Focus();
                Conect = false;
            }
            else
            {
                Conect = true;
            }
            return Conect;
        }

        #region ���ʣ��������ͣ�

        /// <summary>
        /// ����ѡ���ۿ����͵õ�����
        /// </summary>
        /// <param name="type">��������</param>
        /// <returns>����</returns>
        private int GetDiscountByType(String type)
        {
            int discount = 0;
            try
            {
                DBHelper.conn.Open();
                String sql = String.Format("SELECT ARebate FROM Agio WHERE AType='{0}'", type);
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                discount = Convert.ToInt32(comm.ExecuteScalar());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
            return discount;
        }
        #endregion

        #region ��λ�ļ۸���λ���ͣ�������
        /// <summary>
        /// �õ�ѡ����λ���ͺ����ӵ�Ǯ
        /// </summary>
        /// <param name="seat">��λ����</param>
        /// <returns>Ǯ��</returns>
        private int GetIncreaseMoneyBySeet(String seat)
        {
            int money = 0;
            try
            {
                DBHelper.conn.Open();
                String sql = String.Format("SELECT SMoney FROM Seat WHERE SType='{0}'", seat);
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                money = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
            return money;
        }
        #endregion

        #region �õ�ʣ��Ʊ������������λ���ͣ�<��δ��Ʊʱ��>
        //�����ݿ��еõ�ʣ��Ʊ��========================================================ʣ��Ʊ��<����>
        private void GetNumber(String type)
        {
            string sql = string.Format(@"SELECT FPew AS Ӳ��,FComPew AS ����,FLove AS ������
                                         FROM Film
                                         WHERE FID='{0}'", UserHelper.Id);
            try
            {
                DBHelper.conn.Open();
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    //����ѡ�����λ���͵õ���Ӧ��Ʊ��
                    if (type == "������")
                    {
                        txtNumber.Text = reader["������"].ToString();
                    }
                    else if (type == "Ӳ��")
                    {
                        txtNumber.Text = reader["Ӳ��"].ToString();
                    }
                    else if (type == "����")
                    {
                        txtNumber.Text = reader["����"].ToString();
                    }

                }
                reader.Close();
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
        #endregion

        //����ѡ��Ĵ����õ�ID
        private int GetHall()
        {
            String hallText = txtHall.Text.Trim();
            int hallId = 0;
            //���ݴ����õ���ѡ����λ��============================�ж����ĸ�����
            switch (hallText)
            {
                case "һ�Ŵ���":
                    hallId = 1;
                    break;
                case "���Ŵ���":
                    hallId = 2;
                    break;
                case "���Ŵ���":
                    hallId = 3;
                    break;
                default:
                    break;
            }
            return hallId;
        }


        //����λ���͸���ʱ ����ʣ��Ʊ�� �� �۸�
        private void cboSeat_SelectedIndexChanged(object sender, EventArgs e)
        {

            GetNumber(cboSeat.Text.Trim()); //�õ�ʣ��Ʊ��======================���÷��� 


            if (cboAgio.Text.Trim() == "")//�� ��������  Ϊ��ʱ
            {
                int hallId = GetHall();//�õ�������ID�ķ���

                int money = Convert.ToInt32(GetIncreaseMoneyBySeet(cboSeat.Text.Trim()));  //�õ�ѡ����λ���ͺ����ӵ�Ǯ�� ����
                if (cboSeat.Text.Trim() == "������")
                {
                    txtMoney.Text = (Convert.ToInt32(txtPrice.Text.Trim()) * 2 + money).ToString();
                }
                else
                {
                    txtMoney.Text = (Convert.ToInt32(txtPrice.Text.Trim()) + money).ToString();
                }
            }
            else
            {
                if (cboSeat.Text.Trim() == "������")
                {
                    int hallId = GetHall();//�õ�������ID����

                    int money = Convert.ToInt32(GetIncreaseMoneyBySeet(cboSeat.Text.Trim()));  //�õ�ѡ����λ���ͺ����ӵ�Ǯ�� ����

                    // ����ѡ���ۿ����͵õ����ʵ� ����
                    double discount = Convert.ToDouble(GetDiscountByType(cboAgio.Text)) / 100; //(��������100�õ����ۺ���ۿ�)

                    //�õ�ѡ����λ���ͺʹ������ͺ��==============================�۸����������ţ�
                    txtMoney.Text = Convert.ToString(Convert.ToInt32((Convert.ToDouble(txtPrice.Text) * 2 + Convert.ToDouble(money)) * discount));
                }
                else
                {
                    int hallId = GetHall();//�õ�������ID����

                    int money = Convert.ToInt32(GetIncreaseMoneyBySeet(cboSeat.Text.Trim()));  //�õ�ѡ����λ���ͺ����ӵ�Ǯ�� ����

                    // ����ѡ���ۿ����͵õ����ʵ� ����
                    double discount = Convert.ToDouble(GetDiscountByType(cboAgio.Text)) / 100; //(��������100�õ����ۺ���ۿ�)

                    //�õ�ѡ����λ���ͺʹ������ͺ��==============================�۸�
                    txtMoney.Text = Convert.ToString(Convert.ToInt32((Convert.ToDouble(txtPrice.Text) + Convert.ToDouble(money)) * discount));
                }
            }
        }

        //�û����Ĵ������͵�ʱ ���ļ۸� =================================================����
        private void cboAgio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSeat.Text.Trim() == "")//��λ����Ϊ��
            {
                // ����ѡ���ۿ����͵õ����ʵ� ����
                double discount = Convert.ToDouble(GetDiscountByType(cboAgio.Text)) / 100; //(��������100�õ����ۺ���ۿ�)
                txtMoney.Text = Convert.ToInt32((Convert.ToDouble(txtPrice.Text.Trim()) * discount)).ToString();

            }
            else
            {
                if (cboSeat.Text.Trim() == "������")
                {

                    //�õ�ѡ����λ���ͺ����ӵ�Ǯ�� ����
                    int money = GetIncreaseMoneyBySeet(cboSeat.Text);

                    // ����ѡ���ۿ����͵õ����ʵ� ����
                    double discount = Convert.ToDouble(GetDiscountByType(cboAgio.Text)) / 100; //(��������100�õ����ۺ���ۿ�)
                    //�õ�ѡ����λ���ͺʹ������ͺ��==============================�۸�
                    txtMoney.Text = Convert.ToString(Convert.ToInt32((Convert.ToDouble(txtPrice.Text) * 2 + Convert.ToDouble(money)) * discount));
                }
                else
                {

                    //�õ�ѡ����λ���ͺ����ӵ�Ǯ�� ����
                    int money = GetIncreaseMoneyBySeet(cboSeat.Text);

                    // ����ѡ���ۿ����͵õ����ʵ� ����
                    double discount = Convert.ToDouble(GetDiscountByType(cboAgio.Text)) / 100; //(��������100�õ����ۺ���ۿ�)
                    //�õ�ѡ����λ���ͺʹ������ͺ��==============================�۸�
                    txtMoney.Text = Convert.ToString(Convert.ToInt32((Convert.ToDouble(txtPrice.Text) + Convert.ToDouble(money)) * discount));
                }
            }
        }


        #region ����۸�
        //Ʊ������ʱ�ϼƸ���
        private void dudnum_TextChanged(object sender, EventArgs e)
        {
            //����۸�
            if (txtMoney.Text.Trim() != "")//�۸�Ϊ��ʱ
            {
                txtNum1.Text = Convert.ToString(Convert.ToInt32(txtMoney.Text.Trim()) * Convert.ToInt32(dudnum.Text.Trim()));
            }
        }
        //�����ϼƿ�ʱ�¼�
        private void txtNum1_Click(object sender, EventArgs e)
        {
            if (txtMoney.Text.Trim() != "" && txtNumber.Text.Trim() != "")//�۸�Ϊ��ʱ����Ʊ��Ϊ��ʱ
            {
                if (Convert.ToInt32(txtNumber.Text.Trim()) < Convert.ToInt32(dudnum.Text.Trim()))//ʣ���Ʊ��С�ڶ�����Ʊ��
                {
                    //����ı���
                    txtNum1.Text = "";
                    txtNum2.Text = "";
                    txtSum.Text = "";

                    MessageBox.Show("û��ƱƱ����");
                }
                else
                {
                    txtNum1.Text = Convert.ToString(Convert.ToInt32(txtMoney.Text.Trim()) * Convert.ToInt32(dudnum.Text.Trim()));
                }
            }
        }

        //�����ϼ�����ʱ�¼�
        private void lblNum1_Click(object sender, EventArgs e)
        {
            //����۸�
            if (txtMoney.Text.Trim() != "" && txtNumber.Text.Trim() != "")//�۸�Ϊ��ʱ����Ʊ��Ϊ��ʱ
            {
                if (Convert.ToInt32(txtNumber.Text.Trim()) < Convert.ToInt32(dudnum.Text.Trim()))//ʣ���Ʊ��С�ڶ�����Ʊ��
                {
                    txtNum1.Text = "";
                    MessageBox.Show("û��ƱƱ����");
                }
                else
                {
                    txtNum1.Text = Convert.ToString(Convert.ToInt32(txtMoney.Text.Trim()) * Convert.ToInt32(dudnum.Text.Trim()));
                }
            }
        }

        //������Ǯ��ʱ�¼�
        private void txtSum_Click(object sender, EventArgs e)
        {
            if (txtNum2.Text.Trim() != "" && txtNum1.Text.Trim() != "" && Payment() == true)
            {
                txtSum.Text = Convert.ToString(Convert.ToInt32(txtNum2.Text.Trim()) - Convert.ToInt32(txtNum1.Text.Trim()));
            }
        }

        //������Ǯ����ʱ�¼�
        private void lblSum_Click(object sender, EventArgs e)
        {
            if (txtNum2.Text.Trim() != "" && txtNum1.Text.Trim() != "" && Payment() == true)
            {
                if (txtCert.Text.Trim() == "")//���֤������Ϊ��ʱ��ʾ
                {
                    MessageBox.Show("������֤����");
                    txtCert.Focus();
                }
                else
                {
                    txtSum.Text = Convert.ToString(Convert.ToInt32(txtNum2.Text.Trim()) - Convert.ToInt32(txtNum1.Text.Trim()));
                }
            }
        }

        /// <summary>
        /// �жϸ������Ƿ�С�ںϼƽ��================================����txtSum_Click���õ���
        /// </summary>
        private bool Payment()
        {
            if (Convert.ToInt32(txtNum1.Text.Trim()) > Convert.ToInt32(txtNum2.Text.Trim()))
            {
                MessageBox.Show("������㣡");
                txtNum2.Text = "";
                txtNum2.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion


        //�������  �ķ���==============================================����GetAddTicket()���õ���
        private void Clear()
        {
            cboSeat.Text = "";//�����λ����
            txtMoney.Text = "";//��ռ۸�
            cboAgio.Text = "";//����ۿ�����
            dudnum.Text = "1";//�ָ�Ʊ��
            txtCert.Text = "";//���֤����
            txtPhone.Text = "";
            txtNum1.Text = "";//��պϼ�
            txtNum2.Text = "";//��ո���ֵ
            txtSum.Text = "";//�������
            GetNumber(cboSeat.Text.Trim());//����Ʊ��
        }

        /// <summary>
        ///  ��ȥ��Ӧ��Ʊ��  �õ���ʣ���Ʊ����==========================(��GetAddTicket()���õ�)
        /// </summary>
        /// <param name="type">��λ����</param>
        /// <returns>bool</returns>
        private bool subtract(String type)
        {

            //����Ӧ��λ�ģ���Ʊ������ȥ���û�����Ʊ�����õ���ʣ���Ʊ����
            String sql = "";
            try
            {
                switch (cboSeat.Text.Trim())//��λ����
                {
                    case "Ӳ��":
                        sql = String.Format(@"UPDATE Film SET FPew=FPew-{0}
                                           WHERE FID={1}", Convert.ToInt32(dudnum.Text.Trim()), UserHelper.Id);
                        break;
                    case "����":
                        sql = String.Format(@"UPDATE Film SET FComPew=FComPew-{0}
                                           WHERE FID={1}", Convert.ToInt32(dudnum.Text.Trim()), UserHelper.Id);
                        break;
                    case "������":
                        sql = String.Format(@"UPDATE Film SET FLove=FLove-{0}
                                           WHERE FID={1}", Convert.ToInt32(dudnum.Text.Trim()), UserHelper.Id);
                        break;
                    default:
                        break;
                }
                DBHelper.conn.Open();
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                int rows = comm.ExecuteNonQuery();//���ض���
                if (rows == 1)
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

        /// <summary>
        /// ���û���Ʊ��������Ϣ�ŵ����ݿ� �ķ���======================���� btnCancel_Click���õ���
        /// </summary>
        private void GetAddTicket()
        {
            //����Ʊ��Ϣȫ�����뵽Ticket����
            string sql = string.Format(@"insert into Ticket(TFName,TPhone,TCard,TDate,TTime,THall,TTicketPrice,TPayMoney,TCount,TMoney,TAgio)
                                            values ('{0}','{1}','{2}','{3}','{4} ','{5}',{6},{7},{8},{9},'{10}')",
                                            txtName.Text, txtPhone.Text, txtCert.Text, txtTime.Text, txtDays.Text, txtHall.Text,
                                            txtPrice.Text, txtMoney.Text, dudnum.Text, txtNum1.Text, cboAgio.Text);

            if (subtract(cboSeat.Text.Trim()))
            {
                try
                {

                    DBHelper.conn.Open();
                    SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                    int rows = comm.ExecuteNonQuery();
                    if (rows == 1)
                    {
                        DialogResult result = MessageBox.Show("��Ʊ�ɹ����Ƿ������", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            DBHelper.conn.Close();
                            this.Clear();//�������
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("��Ʊʧ�ܣ�");
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

        //����Ʊ��Ǯ������Ǯ�� �ķ���===================================���� btnCancel_Click���õ���
        private void Money()
        {
            string sql = string.Format("update Money set MMoney=MMoney+{0} where MFilmID={1}",
                                        Convert.ToInt32(txtNum1.Text.Trim()), UserHelper.Id);
            try
            {
                DBHelper.conn.Open();
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                int rows = comm.ExecuteNonQuery();
                if (rows == 1)
                {
                    MessageBox.Show("����Ǯ��ɹ�");
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


        /// <summary>
        /// ������Ʊ��ť�¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ValidateInput())//���÷��� �����벻Ϊ�գ�
            {

                if (cboAgio.Text.Trim() == "��ʯ��Ա" || cboAgio.Text.Trim() == "�𿨻�Ա" || cboAgio.Text.Trim() == "������Ա")
                {

                    if (GetCardnum(txtCert.Text.Trim(), cboAgio.Text.Trim()))   //==����GetNumber()������֤���ţ��ۿ����ͣ�
                    {
                        Money();
                        GetAddTicket();
                    }
                    else
                    {
                        txtCert.Text = UserHelper.MemberID;
                        cboAgio.Text = UserHelper.type;
                    }
                }
                else
                {

                    if (cboAgio.Text.Trim() == "���幺Ʊ" && Convert.ToInt32(dudnum.Text.Trim()) < 20)
                    {
                        MessageBox.Show("����Ʊ������20�ţ������Ź�����", "��ʾ��");
                        dudnum.Focus();

                    }
                    else
                    {
                        Money();
                        GetAddTicket();
                    }
                }
            }
        }

        //�رմ���
        private void btnCorrect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
