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
    public partial class SearchTicketForm : Form
    {
        private SqlDataAdapter dataAdapter;
        private DataSet dataset = new DataSet();

        public SearchTicketForm()
        {
            InitializeComponent();
        }

        private void SearchTicketForm_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT TId,TFName AS ��Ӱ���� ,
                          TCard AS ���֤�� ,TDate AS ��ӳ����,TTime AS ��ӳʱ�� ,THall AS ��ӳ����,TCount AS ��Ʊ���� FROM Ticket";
            //����������
            dataAdapter = new SqlDataAdapter(sql, DBHelper.conn);
            //�������ݼ�����
            dataset = new DataSet("Ticket");
            //������ݼ�
            dataAdapter.Fill(dataset, "Ticket");

            //����ʱ�ֿ���Film���е����ݰ���DataGrideView��
            dgvTicket.DataSource = dataset.Tables["Ticket"];

          
            //����FID�е�����
            dgvTicket.Columns["TId"].Visible = false;



        }

      
        //����뿪ʱ����
        private void dgvTicket_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)//��֤����������
            {
                //�����б���Ϊ��ɫ
                dgvTicket.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                //�����ֵ���ɫΪ��ɫ
                dgvTicket.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }
        //�����ʱ����
        private void dgvTicket_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)//��֤����������
            {
                //�����б���Ϊ��ɫ
                dgvTicket.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                //�����ֵ���ɫΪ��ɫ
                dgvTicket.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //MainForm mf = new MainForm();
            //mf.Show();
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            string sql = @"SELECT TId,TFName AS ��Ӱ���� ,
                          TCard AS ���֤�� ,TDate AS ��ӳ����,TTime AS ��ӳʱ�� ,THall AS ��ӳ����,TCount AS ��Ʊ���� FROM Ticket";
            //����������
            dataAdapter = new SqlDataAdapter(sql, DBHelper.conn);
            //�������ݼ�����
            dataset = new DataSet("Ticket");
            //������ݼ�
            dataAdapter.Fill(dataset, "Ticket");

            //����ʱ�ֿ���Film���е����ݰ���DataGrideView��
            dgvTicket.DataSource = dataset.Tables["Ticket"];


            //����FID�е�����
            dgvTicket.Columns["TId"].Visible = false;
        }

        private void btnRearch_Click(object sender, EventArgs e)
        {
            String datatime = (dateTimePicker.Value).ToString();
            String data = datatime.Substring(0, datatime.Length - 8).Trim();

            String sql = string.Format(@"SELECT TId,TFName AS ��Ӱ���� ,
             TCard AS ���֤�� ,TDate AS ��ӳ����,TTime AS ��ӳʱ�� ,THall AS ��ӳ����,TCount AS ��Ʊ���� FROM Ticket 
                        where TDate='{0}'", data);

            dataset.Tables["Ticket"].Clear();//���Ticket�����ݣ��������ڲ�ѯ��������Ticket��
            dataAdapter.SelectCommand.CommandText = sql;   
            dataAdapter.Fill(dataset, "Ticket");

        } //���Ҷ�Ʊ����

       

       

       

      
    }
}