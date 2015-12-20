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
    public partial class SelectForm : Form
    {

        private DataSet dataset = new DataSet();         //声明并初始化变量
        private SqlDataAdapter dataAdapter;              //声明适配器
        public SelectForm()
        {
            InitializeComponent();
        }


        //窗体加载时填充（影片查询）数据  ================================填充数据
        private void SelectForm_Load(object sender, EventArgs e)
        {

            GetSelect();//调用填充的方法
            //picPic.Image = Image.FromFile("Images\\空.gif");

        }



        //窗体加载时填充数据的方法========================================填充数据方法
        public void GetSelect()
        {
            try
            {
                //查询SQL语句
                string sql = @"select F.FID as Id, F.FFilmName as '片名',F.FDirector as '导演',F.FPlay as '主演',F.FIntro as '简介',
                                            F.FLanguage as '语言',F.FLong as '片长',F.FDate as '放映日期',F.FMoney as '票价',
                                            F.FNumber as '票数',F.FNum as '座位号',F.FPhoto as 图片路径 ,S.SSort as '类型',T.TTime as '放映时间',
                                            H.HHall as '大厅'
                                            from Film as F ,Sort as S ,Time as T ,Hall as H
                                            where F.FSortID=S.SOID and F.FTimeID = T.TID and H.HID=T.THallID";

                //执行DataAdapter语句（填充数据）
                dataAdapter = new SqlDataAdapter(sql, DBHelper.conn);

                //用fill方法将数据库里的数据填充数据集
                dataAdapter.Fill(dataset, "Films");

                //指定 DataGridView 数据源 [实现数据的绑定]
                dgvSerch.DataSource = dataset.Tables["Films"];

                //隐藏Id的内容
                dgvSerch.Columns["Id"].Visible = false;

                //隐藏‘图片路径’
                dgvSerch.Columns["图片路径"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //实现查询功能（当点击查询时）=====================================查询数据
        private void btnSelect_Click(object sender, EventArgs e)
        {
            String dateTime = (dateTimePicker.Value).ToString();          //将下拉框内的日期转换为String 
            String date = dateTime.Substring(0, dateTime.Length - 8).Trim();//Substring通过截取得到日期
            //查询SQL语句
            string sql = string.Format(@"select F.FID as Id, F.FFilmName as '片名',F.FDirector as '导演',F.FPlay as '主演',F.FIntro as '简介',
                                F.FLanguage as '语言',F.FLong as '片长',F.FDate as '放映日期',F.FMoney as '票价',
                                F.FNumber as '票数',F.FNum as '座位号',S.SSort as '类型',T.TTime as '放映时间',
                                H.HHall as '大厅',F.FPhoto as 图片路径
                                from Film as F ,Sort as S ,Time as T ,Hall as H
                                where F.FSortID=S.SOID and F.FTimeID = T.TID and H.HID=T.THallID and F.FDate='{0}'", date);
            //将表中的内容清空
            dataset.Tables["Films"].Clear();
            //重新指定DataAdapter对象的查询语句
            dataAdapter.SelectCommand.CommandText = sql;
            //重新填充数据
            dataAdapter.Fill(dataset, "Films");

            //隐藏‘图片路径’
            dgvSerch.Columns["图片路径"].Visible = false;
        }

        //点击刷新 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = @"select F.FID as Id, F.FFilmName as '片名',F.FDirector as '导演',F.FPlay as '主演',F.FIntro as '简介',
                                            F.FLanguage as '语言',F.FLong as '片长',F.FDate as '放映日期',F.FMoney as '票价',
                                            F.FNumber as '票数',F.FNum as '座位号',F.FPhoto as 图片路径 ,S.SSort as '类型',T.TTime as '放映时间',
                                            H.HHall as '大厅'
                                            from Film as F ,Sort as S ,Time as T ,Hall as H
                                            where F.FSortID=S.SOID and F.FTimeID = T.TID and H.HID=T.THallID";
            try
            {
                dataset.Tables["Films"].Clear();
                dataAdapter.SelectCommand.CommandText = sql;
                dataAdapter.Fill(dataset, "Films");
                dgvSerch.Columns["图片路径"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //当点击查询表中的（订票）时，跳到定票窗体=========================窗体跳转
        private void btnCancel1_Click_1(object sender, EventArgs e)
        {
            
            OrderForm order = new OrderForm();
            order.Show();

        }

        //在DataGridView中（单击单元格的任意键发生）=======================鼠标单击
        private void dgvSerch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //得到所选择得当行得Id得值，并赋予UserHelper中的Id变量（当鼠标点击某个单元格时得到里面的内容）
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                UserHelper.Id = Convert.ToInt32(dgvSerch.Rows[e.RowIndex].Cells["Id"].Value);
                //使相对路径合法
                Directory.SetCurrentDirectory(PathHelper.currentDirectory);
                //得到图片的相对路径
                String path = Convert.ToString(dgvSerch.Rows[e.RowIndex].Cells["图片路径"].Value);
                if (path != "")
                {   //使相对路径合法
                    Directory.SetCurrentDirectory(PathHelper.currentDirectory);
                    //在数据库和查询表绑定时已经将路径读出 现将路径拿到这边作为相对路径
                 //   path = "D:\\1.jpg";
                    picPic.Image = Image.FromFile(path);
                }
                else
                {
                    //使相对路径合法
                    Directory.SetCurrentDirectory(PathHelper.currentDirectory);
                    //picPic.Image = Image.FromFile("Images\\空.bmp");
                }
            }
        }
        #region(鼠标移动时变色)
        //鼠标移动事件(鼠标移过单元格)
        private void dgvSerch_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            //保证在行内
            if (e.RowIndex >= 0)
            {
                //行背景设置为灰色
                dgvSerch.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Firebrick;
                //行文字设置为白色
                dgvSerch.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
        }

        //鼠标移动事件(鼠标离开单元格)
        private void dgvSerch_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            //保证在行内
            if (e.RowIndex >= 0)
            {
                //行背景设置为白色
                dgvSerch.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                //行文字设置为黑色
                dgvSerch.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }
        #endregion

        private void btnColse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picPic_Click(object sender, EventArgs e)
        {

        }

    }
}