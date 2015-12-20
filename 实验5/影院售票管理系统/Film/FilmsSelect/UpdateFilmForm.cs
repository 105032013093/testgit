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
        private SqlDataAdapter adapter; //数据适配器
        private DataSet dataSet;        //数据集
        public UpdateFilmForm()
        {
            InitializeComponent();
        }
        //窗体的加载事件
        private void UpdateFilmForm_Load(object sender, EventArgs e)
        {
            PathHelper.relPath = "";
            txtName.Focus();
            //添加皮肤代码
            //skinLogin.SkinFile = "skin\\Vista1\\vista1_green.ssk";
            TypeGet();//电影类型
            TimeGet();//放映时间和大厅
            Get();    //填充数据集，打印内容
        }

        //验证选择的放映时间和电影是否重复true为可以插入
        private bool IfRepeat1(String data, String Time, int ID)
        {
            bool isbool = false;//判断是否为重复
            String sql = String.Format(@"SELECT count(*)
                                         FROM Film AS F,Time AS T
                                         WHERE F.FTimeID=T.TID AND F.FDate='{0}' AND T.TTime='{1}' AND F.FID={2}", data, Time, ID);
            try
            {
                //打开数据库连接
                DBHelper.conn.Open();
                //创建 Command 对象
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);

                //验证放映时间是否重复
                int count = Convert.ToInt32(comm.ExecuteScalar());
                if (count == 1)             //该段有电影
                {
                    isbool = true;
                }
                else
                {
                    DBHelper.conn.Close();
                    if (IfRepeat2(data, Time))//为True时说明该段没有电影
                    {
                        isbool = true;
                    }
                    else
                    {
                        MessageBox.Show("该时间段已有电影！");
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
                DBHelper.conn.Close();//关闭数据库
            }
            return isbool;
        }
        //验证选择的放映时间是否重复true为该时间段没有影片
        private bool IfRepeat2(String data, String Time)
        {
            bool isbool = false;//判断是否为重复
            String sql = String.Format(@"SELECT count(*)
                                         FROM Film AS F,Time AS T
                                         WHERE F.FTimeID=T.TID AND F.FDate='{0}' AND T.TTime='{1}'", data, Time);
            try
            {
                //打开数据库连接
                DBHelper.conn.Open();
                //创建 Command 对象
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                //验证放映时间是否重复
                int count = Convert.ToInt32(comm.ExecuteScalar());
                if (count == 1)//该段有电影
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
                DBHelper.conn.Close();//关闭数据库
            }
            return isbool;
        }
        #region 控制输入的形式
        //-----------------------------------------------------------------------------------------//

        //从数据库中调出电影类型
        private void TypeGet()
        {
            String sql = "SELECT SSort FROM Sort";
            try
            {
                //创建Command对象
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                DBHelper.conn.Open();
                //执行查询语句
                SqlDataReader reader = comm.ExecuteReader();
                //循环读取记录
                while (reader.Read())
                {
                    cboType.Items.Add(reader["SSort"].ToString());
                }
                reader.Close();
            }//try结束
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
        }

        //得到选择的电影类型的主键标识列 SOID
        private int Type(String type)
        {
            int SOID = 0;
            String sql = String.Format(@"SELECT SOID
                                        FROM Sort
                                        WHERE SSort='{0}'", type);
            try
            {
                //创建Command对象
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                DBHelper.conn.Open();
                //执行查询语句
                SqlDataReader reader = comm.ExecuteReader();
                //循环读取记录
                while (reader.Read())
                {
                    SOID = Convert.ToInt32(reader["SOID"]);
                }
                reader.Close();
            }//try结束
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

        //从数据库中调出放映时间
        private void TimeGet()
        {
            String sql = "SELECT TTime FROM Time";
            try
            {
                //创建Command对象
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                DBHelper.conn.Open();
                //执行查询语句
                SqlDataReader reader = comm.ExecuteReader();
                //循环读取记录
                while (reader.Read())
                {
                    cboTime.Items.Add(reader["TTime"].ToString());
                }
                reader.Close();
            }//try结束
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
        }

        //得到选择时间的标识列 TID
        private int Time(String time)
        {
            int TID = 0;
            String sql = String.Format(@"SELECT TID
                                        FROM Time
                                        WHERE TTime='{0}'", time);
            try
            {
                //创建Command对象
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                DBHelper.conn.Open();
                //执行查询语句
                SqlDataReader reader = comm.ExecuteReader();
                //循环读取记录
                while (reader.Read())
                {
                    TID = Convert.ToInt32(reader["TID"]);//将标识列赋予TID
                }
                reader.Close();
            }//try结束
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

        //根据选择的时间来调出放映大厅
        private String HallGet(String cboTime)
        {
            String sql = String.Format(@"SELECT H.HHall
                                         FROM Time AS T,Hall AS H
                                         WHERE T.THallID=H.HID AND T.TTime='{0}'", cboTime);
            String hall = "";
            try
            {
                //创建Command对象
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                DBHelper.conn.Open();
                //执行查询语句
                SqlDataReader reader = comm.ExecuteReader();
                //循环读取记录
                while (reader.Read())
                {
                    hall = reader["HHall"].ToString();
                }
                reader.Close();
            }//try结束
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

        //自动弹出放映大厅-----------  鼠标离开事件
        private void cboTime_Leave(object sender, EventArgs e)
        {
            txtHall.Text = HallGet(cboTime.Text);
        }

        //判断输入是否为空
        private bool ValidateInput()
        {
            if (txtName.Text == "")//判断电影名称是否输入
            {
                MessageBox.Show("请输入电影名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtName.Focus();
                return false;
            }
            else if (cboType.Text == "")//判断类型是否选择了类型
            {
                MessageBox.Show("请选择类型！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cboType.Focus();
                return false;
            }
            else if (txtMain.Text == "")//判断主演是否输入
            {
                MessageBox.Show("请输入主演！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtMain.Focus();
                return false;
            }

            else if (txtDirect.Text == "")//判断导演是否输入
            {
                MessageBox.Show("请输入导演！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtDirect.Focus();
                return false;
            }
            else if (txtLanguage.Text == "")//判断语言是否输入
            {
                MessageBox.Show("请输入语言！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtLanguage.Focus();
                return false;
            }
            else if (txtContent.Text == "")//判断电影简介是否输入
            {
                MessageBox.Show("请输入电影简介！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtContent.Focus();
                return false;
            }
            else if (txtMoney.Text == "")//判断价格是否输入
            {
                MessageBox.Show("请输入价格！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtMoney.Focus();
                return false;
            }
            else if (cboTime.Text == "")
            {
                MessageBox.Show("请选择放映时间！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cboTime.Focus();
                return false;
            }
            else if (txtHour.Text == "")//判断片长是否输入
            {
                MessageBox.Show("请输入片长！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtHour.Focus();
                return false;
            }
            else if (Convert.ToInt32(txtHour.Text) > 240)//判断正确的片长
            {
                MessageBox.Show("请输入正确的片长！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtHour.Focus();
                return false;
            }
            return true;
        }

        //价格只能填写 0~9 数字
        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能够输入0~9(ASC:48~57)之间的字符（包括退格键 ASC:8)
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                if (e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        //电影片长只能填 0~9 的数字
        private void txtHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能够输入0~9(ASC:48~57)之间的字符（包括退格键 ASC:8)
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                if (e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        //控制放映的片长为 1~180 (分钟)------------- 鼠标离开事件
        private void txtHour_Leave(object sender, EventArgs e)
        {
            if (txtHour.Text != "")
            {
                String strContent = txtHour.Text.Trim(); //得到txtNum1内容
                int num = int.Parse(strContent); //转换成整数
                if (num > 180 || num < 1) //判断
                {
                    MessageBox.Show("该值应在1~180之间"); //警告
                    txtHour.Focus(); //将焦点切回
                }
            }
            //else
            //{
            //    MessageBox.Show("请输入完内容后再离开！");
            //    txtHour.Focus(); //切回焦点
            //}
        }

        //清空内容
        private void Clear()
        {
            txtName.Text = "";          //清空电影名称
            txtMain.Text = "";          //清空主演
            cboType.Text = "";            //默认为空
            txtDirect.Text = "";        //导演信息
            txtLanguage.Text = "";      //清空语言
            txtContent.Text = "";       //清空简介
            txtMoney.Text = "";         //清空价格
            cboTime.Text = "";            //默认为空
            txtHour.Text = "";          //清空片长
        }

        //------------------------------------------------------------------------------------------//
        #endregion

        #region DataGirdView的事件
        //加载数据到 DataGirdView 中
        private void Get()
        {
            //编写 sql 语句
            String sql = @"SELECT F.FID AS ID,F.FFilmName AS '电影名称',F.FDirector AS '导演',F.FPlay AS '演员',F.FIntro AS '简介',F.FLanguage AS '语言',F.FLong AS '片长',F.FDate AS '放映日期',T.TTime AS '放映时间',F.FMoney AS '价格',S.SSort AS '类型',H.HHall AS '放映大厅',F.FPhoto AS '海报路径'
                            FROM Film AS F,Sort AS S,Time AS T,Hall AS H
                            WHERE F.FTimeID=T.TID AND F.FSortID=S.SOID AND H.HID=T.THallID";

            //创建数据集适配器
            adapter = new SqlDataAdapter(sql, DBHelper.conn);
            //创建数据集对象
            dataSet = new DataSet("Film");

            //填充数据集
            adapter.Fill(dataSet, "Film");

            //绑定到 DataGirdView 中
            dgvFilm.DataSource = dataSet.Tables["Film"];

            //隐藏ID列的内容
            dgvFilm.Columns["ID"].Visible = false;

            //隐藏海报内容
            dgvFilm.Columns["海报路径"].Visible = false;
        }

        //鼠标移动事件
        private void dgvFilm_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            //保证在行内
            if (e.RowIndex >= 0)
            {
                //行背景设置为灰色
                dgvFilm.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                //行文字设置为白色
                dgvFilm.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
        }

        //鼠标鼠标离开事件
        private void dgvFilm_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            //保证在行内
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex % 2 == 0)
                {
                    //行背景设置为灰色
                    dgvFilm.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    //行文字设置为白色
                    dgvFilm.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    //行背景设置为黄色
                    dgvFilm.Rows[e.RowIndex].DefaultCellStyle.BackColor = dgvFilm.AlternatingRowsDefaultCellStyle.BackColor;
                    //行文字设置为黑色
                    dgvFilm.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        /// <summary>
        /// 鼠标单击单元格任意处发生事件，得到电影的主键,海报的相对路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFilm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //使相对路径合法
            Directory.SetCurrentDirectory(PathHelper.currentDirectory);

            //dataSet.Tables["Film"].Clear();
            //adapter.Fill(dataSet, "Film");
            //保证点击在行内
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                //得到电影的主键FID
                UserHelper.ID = Convert.ToInt32(dgvFilm.Rows[e.RowIndex].Cells["ID"].Value);
                GetInfo(UserHelper.ID);
                PathHelper.relPath = dgvFilm.Rows[e.RowIndex].Cells["海报路径"].Value.ToString().Trim();
            }
        }

        //读出数据填充下面窗体数据
        private void GetInfo(int ID)
        {
            String sql = String.Format(@"SELECT F.FID AS ID,F.FFilmName AS '电影名称',F.FDirector AS '导演',F.FPlay AS '演员',F.FIntro AS '简介',F.FLanguage AS '语言',F.FLong AS '片长',F.FDate AS '放映日期',F.FMoney AS '价格',T.TTime AS '放映时间',S.SSort AS '类型',T.TTime AS '时间',H.HHall AS '放映大厅'
                           FROM Film AS F,Sort AS S,Time AS T,Hall AS H
                           WHERE F.FTimeID=T.TID AND F.FSortID=S.SOID AND H.HID=T.THallID AND F.FID={0}", ID);
            try
            {
                //打开数据库库连接
                DBHelper.conn.Open();
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    txtName.Text = reader["电影名称"].ToString();
                    txtDirect.Text = reader["导演"].ToString();
                    cboType.Text = reader["类型"].ToString();
                    txtLanguage.Text = reader["语言"].ToString();
                    txtMain.Text = reader["演员"].ToString();
                    txtMoney.Text = reader["价格"].ToString();
                    txtHour.Text = reader["片长"].ToString();
                    cboTime.Text = reader["时间"].ToString();
                    txtHall.Text = reader["放映大厅"].ToString();
                    dateTimePicker.Text = reader["放映日期"].ToString();
                    txtContent.Text = reader["简介"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //关闭数据库连接
                DBHelper.conn.Close();
            }
        }
        #endregion

        /// <summary>
        /// 单击电影的保存修改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String dateTime = (dateTimePicker.Value).ToString().Trim();
            String date = dateTime.Substring(0, dateTime.Length - 8).Trim();

            try
            {
                //打开数据库连接
                if (ValidateInput() && IfRepeat1(date, cboTime.Text.Trim(), UserHelper.ID))
                {
                    String sql = String.Format(@"UPDATE Film SET FFilmName='{0}',FDirector='{1}',FPlay='{2}',FIntro='{3}',FLanguage='{4}',
                                        FLong={5},FDate='{6}',FMoney={7},FSortID={8},FTimeID={9}
                                        WHERE FID={10}", txtName.Text.Trim(), txtDirect.Text.Trim(), txtMain.Text.Trim(),
                                        txtContent.Text.Trim(), txtLanguage.Text.Trim(), Convert.ToInt32(txtHour.Text.Trim()),
                                        date, Convert.ToInt32(txtMoney.Text.Trim()), Convert.ToInt32(Type(cboType.Text)),
                                        Convert.ToInt32(Time(cboTime.Text)), UserHelper.ID);
                    DialogResult result = MessageBox.Show("是否保存修改！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        DBHelper.conn.Open();
                        //创建 Command 对象
                        SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                        int count = Convert.ToInt32(comm.ExecuteNonQuery());
                        if (count == 1)
                        {
                            MessageBox.Show("修改成功！");
                            Clear();//清空
                            UpdateNew();//刷新
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
                DBHelper.conn.Close();//关闭数据库
            }
        }

        //刷新方法
        public void UpdateNew()
        {
            //编写 sql 语句
            String sql = @"SELECT F.FID AS ID,F.FFilmName AS '电影名称',F.FDirector AS '导演',F.FPlay AS '演员',F.FIntro AS '简介',F.FLanguage AS '语言',F.FLong AS '片长',F.FDate AS '放映日期',T.TTime AS '放映时间',F.FMoney AS '价格',S.SSort AS '类型',H.HHall AS '放映大厅',F.FPhoto AS '海报路径'
                            FROM Film AS F,Sort AS S,Time AS T,Hall AS H
                            WHERE F.FTimeID=T.TID AND F.FSortID=S.SOID AND H.HID=T.THallID";
            //创建数据集适配器
            adapter = new SqlDataAdapter(sql, DBHelper.conn);
            dataSet.Tables["Film"].Clear();//清空表 Film 的内容
            adapter.Fill(dataSet, "Film");//重新填充数据
        }

        //单击刷新事件
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateNew();//刷新
        }

        //单击取消事件
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();   //关闭当前窗体
        }

        #region 单击和右击删除按钮事件
        //单击删除按钮事件
        private void btnDelect_Click(object sender, EventArgs e)
        {
            //编写 SQL 语句
            String sqlFilm = String.Format(@"DELETE FROM Film
                                         WHERE FID={0}", UserHelper.ID);
            String sqlMoney = String.Format(@"DELETE FROM Money
                                         WHERE MFilmID={0}", UserHelper.ID);
            DialogResult result = MessageBox.Show("是否删除！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                if (Delete(sqlMoney) && Delete(sqlFilm))
                {
                    MessageBox.Show("删除成功！");
                    Clear();//清空
                    UpdateNew();//刷新
                }
            }
        }

        //右击删除按钮事件
        private void tmsiDelect_Click(object sender, EventArgs e)
        {
            //编写 SQL 语句
            String sqlFilm = String.Format(@"DELETE FROM Film
                                         WHERE FID={0}", UserHelper.ID);
            String sqlMoney = String.Format(@"DELETE FROM Money
                                         WHERE MFilmID={0}", UserHelper.ID);
            DialogResult result = MessageBox.Show("是否删除！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                if (Delete(sqlMoney) && Delete(sqlFilm))
                {
                    MessageBox.Show("删除成功！");
                    Clear();//清空
                    UpdateNew();//刷新
                }
            }
        }
        #endregion

        //删除语句
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

        //单击修改海报按钮
        private void TsmiSelect_Click(object sender, EventArgs e)
        {
            ViewForm view = new ViewForm(this);
            view.ShowDialog();
        }

        //查询方法
        private void SelectFilm()
        {
            //得到正确的日期格式
            String dateTime = (dateTimePicker1.Value).ToString();
            String date = dateTime.Substring(0, dateTime.Length - 8).Trim();
            String sql = String.Format(@"SELECT F.FID AS ID,F.FFilmName AS '电影名称',F.FDirector AS '导演',F.FPlay AS '演员',F.FIntro AS '简介',F.FLanguage AS '语言',F.FLong AS '片长',F.FDate AS '放映日期',T.TTime AS '放映时间',F.FMoney AS '价格',S.SSort AS '类型',H.HHall AS '放映大厅',F.FPhoto AS '海报路径'
                                        FROM Film AS F,Sort AS S,Time AS T,Hall AS H
                                        WHERE F.FTimeID=T.TID AND F.FSortID=S.SOID AND H.HID=T.THallID AND FDate='{0}'", date);
            //创建数据集适配器
            adapter = new SqlDataAdapter(sql, DBHelper.conn);
            dataSet.Tables["Film"].Clear();//清空表 Film 的内容
            adapter.Fill(dataSet, "Film");//重新填充数据
        }

        //单击查询按钮事件
        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectFilm();
        }

    }
}