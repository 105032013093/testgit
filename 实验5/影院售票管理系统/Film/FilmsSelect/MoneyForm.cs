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
    public partial class MoneyForm : Form
    {
        private DataSet dataset = new DataSet();         //��������ʼ������
        private SqlDataAdapter dataAdapter;              //����������
        public MoneyForm()
        {
            InitializeComponent();
        }

        //��MnyForm_Load �¼��У���������Ǯ����������Ϣ
        private void MnyForm_Load(object sender, EventArgs e)
        {
            string sql = (@"select M.MMoney as 'Ǯ��' ,F.FFilmName as 'Ƭ��',H.HHall as '����',
                                                F.FDate as '��ӳ����', T.TTime as '��ӳʱ��'              
                                                from Money as M,Film as F,Time as T ,Hall as H   
                                                where M.MFilmID=F.FID and F.FTimeID =T.TID and H.HID=T.THallID "); //���������õ�Ǯ��
            dataAdapter = new SqlDataAdapter(sql, DBHelper.conn); //��������������
            dataAdapter.Fill(dataset, "Money");                   //��Money���������Ϣ
            dgvMoney.DataSource = dataset.Tables["Money"];        // ��
        }


        #region(����ƶ�ʱ��ɫ)
        private void dgvMoney_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            //��֤������
            if (e.RowIndex >= 0)
            {
                //�б�������Ϊ��ɫ
                dgvMoney.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                //����������Ϊ��ɫ
                dgvMoney.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
        }
        private void dgvMoney_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            //��֤������
            if (e.RowIndex >= 0)
            {   //�б�������Ϊ��ɫ
                dgvMoney.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                //����������Ϊ��ɫ
                dgvMoney.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }
        #endregion

        //���������Ť�õ���ѯ��ı��ڵ���Ϣ
        private void btnMoney_Click(object sender, EventArgs e)
        {

            String dateTime = (dateTimePicker.Value).ToString();          //���������ڵ�����ת��ΪString 
            String date = dateTime.Substring(0, dateTime.Length - 8).Trim();//Substringͨ����ȡ�õ�����
            string sql = string.Format(@"select M.MMoney as 'Ǯ��' ,F.FFilmName as 'Ƭ��',H.HHall as '����',
                                                F.FDate as '��ӳ����', T.TTime as '��ӳʱ��'
                                                from Money as M,Film as F,Time as T ,Hall as H
                                                where M.MFilmID=F.FID and F.FTimeID =T.TID and H.HID=T.THallID and FDate='{0}'", date); //����ʱ���
            dataset.Tables["Money"].Clear();    //���
            dataAdapter.SelectCommand.CommandText = sql;  //����ִ��
            dataAdapter.Fill(dataset, "Money");           //�������

        }
        //������뿪ӰƬ��Ϣʱ
        private void dgvMoney_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                txtMoney1.Text = dgvMoney.Rows[e.RowIndex].Cells["Ǯ��"].Value.ToString();   // ��Ǯ����ӵ��ı�����
        }

        //�˳�
        private void btnColse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}