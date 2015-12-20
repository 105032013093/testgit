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
            string sql = @"SELECT TId,TFName AS 电影名称 ,
                          TCard AS 身份证件 ,TDate AS 放映日期,TTime AS 放映时间 ,THall AS 放映大厅,TCount AS 购票数量 FROM Ticket";
            //创建适配器
            dataAdapter = new SqlDataAdapter(sql, DBHelper.conn);
            //创建数据集对象
            dataset = new DataSet("Ticket");
            //填充数据集
            dataAdapter.Fill(dataset, "Ticket");

            //将临时仓库中Film表中的内容绑定在DataGrideView上
            dgvTicket.DataSource = dataset.Tables["Ticket"];

          
            //隐藏FID列的内容
            dgvTicket.Columns["TId"].Visible = false;



        }

      
        //鼠标离开时设置
        private void dgvTicket_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)//保证设置在行内
            {
                //设置行背景为白色
                dgvTicket.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                //设置字的颜色为黑色
                dgvTicket.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }
        //鼠标点击时设置
        private void dgvTicket_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)//保证设置在行内
            {
                //设置行背景为灰色
                dgvTicket.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                //设置字的颜色为白色
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

            string sql = @"SELECT TId,TFName AS 电影名称 ,
                          TCard AS 身份证件 ,TDate AS 放映日期,TTime AS 放映时间 ,THall AS 放映大厅,TCount AS 购票数量 FROM Ticket";
            //创建适配器
            dataAdapter = new SqlDataAdapter(sql, DBHelper.conn);
            //创建数据集对象
            dataset = new DataSet("Ticket");
            //填充数据集
            dataAdapter.Fill(dataset, "Ticket");

            //将临时仓库中Film表中的内容绑定在DataGrideView上
            dgvTicket.DataSource = dataset.Tables["Ticket"];


            //隐藏FID列的内容
            dgvTicket.Columns["TId"].Visible = false;
        }

        private void btnRearch_Click(object sender, EventArgs e)
        {
            String datatime = (dateTimePicker.Value).ToString();
            String data = datatime.Substring(0, datatime.Length - 8).Trim();

            String sql = string.Format(@"SELECT TId,TFName AS 电影名称 ,
             TCard AS 身份证件 ,TDate AS 放映日期,TTime AS 放映时间 ,THall AS 放映大厅,TCount AS 购票数量 FROM Ticket 
                        where TDate='{0}'", data);

            dataset.Tables["Ticket"].Clear();//清空Ticket表内容，根据日期查询，重新填Ticket表
            dataAdapter.SelectCommand.CommandText = sql;   
            dataAdapter.Fill(dataset, "Ticket");

        } //查找订票内容

       

       

       

      
    }
}