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
        private DataSet dataset = new DataSet();         //声明并初始化变量
        private SqlDataAdapter dataAdapter;              //声明适配器
        public MoneyForm()
        {
            InitializeComponent();
        }

        //在MnyForm_Load 事件中，读出关于钱箱表的所有信息
        private void MnyForm_Load(object sender, EventArgs e)
        {
            string sql = (@"select M.MMoney as '钱数' ,F.FFilmName as '片名',H.HHall as '大厅',
                                                F.FDate as '放映日期', T.TTime as '放映时间'              
                                                from Money as M,Film as F,Time as T ,Hall as H   
                                                where M.MFilmID=F.FID and F.FTimeID =T.TID and H.HID=T.THallID "); //两表相连得到钱数
            dataAdapter = new SqlDataAdapter(sql, DBHelper.conn); //创建适配器对象
            dataAdapter.Fill(dataset, "Money");                   //在Money表中添加信息
            dgvMoney.DataSource = dataset.Tables["Money"];        // 绑定
        }


        #region(鼠标移动时变色)
        private void dgvMoney_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            //保证在行内
            if (e.RowIndex >= 0)
            {
                //行背景设置为灰色
                dgvMoney.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                //行文字设置为白色
                dgvMoney.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
        }
        private void dgvMoney_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            //保证在行内
            if (e.RowIndex >= 0)
            {   //行背景设置为白色
                dgvMoney.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                //行文字设置为黑色
                dgvMoney.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }
        #endregion

        //点击搜索按扭得到查询后的表内的信息
        private void btnMoney_Click(object sender, EventArgs e)
        {

            String dateTime = (dateTimePicker.Value).ToString();          //将下拉框内的日期转换为String 
            String date = dateTime.Substring(0, dateTime.Length - 8).Trim();//Substring通过截取得到日期
            string sql = string.Format(@"select M.MMoney as '钱数' ,F.FFilmName as '片名',H.HHall as '大厅',
                                                F.FDate as '放映日期', T.TTime as '放映时间'
                                                from Money as M,Film as F,Time as T ,Hall as H
                                                where M.MFilmID=F.FID and F.FTimeID =T.TID and H.HID=T.THallID and FDate='{0}'", date); //根据时间查
            dataset.Tables["Money"].Clear();    //清空
            dataAdapter.SelectCommand.CommandText = sql;  //重新执行
            dataAdapter.Fill(dataset, "Money");           //重新填充

        }
        //当鼠标离开影片信息时
        private void dgvMoney_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                txtMoney1.Text = dgvMoney.Rows[e.RowIndex].Cells["钱数"].Value.ToString();   // 将钱数添加到文本框内
        }

        //退出
        private void btnColse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}