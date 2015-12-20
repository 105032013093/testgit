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
        //窗体的事件
        private void AddForm_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            //添加皮肤代码
            //skinLogin.SkinFile = "skin\\Vista1\\vista1_green.ssk";
            lblCue.Visible = false;//将提示标签隐藏
            TypeGet();//电影类型
            TimeGet();//放映时间和大厅
        }

        //增加电影的单击事件
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
                    //打开数据库连接
                    DBHelper.conn.Open();
                    DialogResult res = MessageBox.Show("确定插入电影！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        SqlCommand comm = new SqlCommand(Sql, DBHelper.conn);
                        int num = Convert.ToInt32(comm.ExecuteNonQuery());
                        if (num == 1)
                        {
                            DialogResult result = MessageBox.Show("插入成功！是否继续插入！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                            if (result == DialogResult.OK)
                            {
                                DBHelper.conn.Close();
                                if (Money(date, Convert.ToInt32(Time(cboTime.Text.Trim()))))//增加钱箱
                                {
                                    Clear();//清空数据
                                }
                            }
                            else
                            {
                                DBHelper.conn.Close();
                                if (Money(date, Convert.ToInt32(Time(cboTime.Text.Trim()))))
                                {
                                    this.Close();//关闭窗口
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("电影插入失败！");
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

        #region 增加钱箱
        //读出增加电影后的FID
        private int GetFID(String date, int timeId)
        {
            int FID = 0;
            //从数据库中查出增加电影后的ID
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
        /// 增加电影时相应的生成一个钱箱
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

        //单击关闭此窗体
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //验证选择的放映时间是否重复
        private bool IfRepeat(String data, String Time)
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
                    MessageBox.Show("该时间段已有电影！");
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
            else if (txtAmount.Text == "")//判断票数是否输入
            {
                MessageBox.Show("请输入票数！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtAmount.Focus();
                return false;
            }
            else if (Convert.ToInt32(txtAmount.Text) > 300)//判断票数是否输入正确
            {
                MessageBox.Show("票数最大为300！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtAmount.Focus();
                return false;
            }
            else if (txtNumber.Text == "")//判断座位编号是否输入
            {
                MessageBox.Show("请输入座位编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtNumber.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// 插入海报单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                PathHelper.relPathDirectory = "";//清空相对路径
                String sourcePath = open.FileName; //源路径
                Image img = Image.FromFile(sourcePath);//得到选中的图片
                String name = Path.GetFileName(open.FileName); //文件名称
                String relPath = PathHelper.defaultDirectory + "\\" + name; //相对目标路径
                String destPath = PathHelper.currentDirectory + "\\" + relPath; //绝对目标路径
                try
                {
                    File.Copy(sourcePath, destPath, true); //拷贝文件.
                    PathHelper.relPathDirectory = relPath;
                    //在图片框控件中显示出来
                    picFace.Image = img;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        //价格只能填写 0~9 数字
        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            ////只能够输入0~9(ASC:48~57)之间的字符（包括退格键 ASC:8)
            //if (e.KeyChar < 48 || e.KeyChar > 57)
            //{
            //    if (e.KeyChar != 8)
            //        e.Handled = true;
            //}
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

        //输入非数字时提示的方法
        private void Cue(String txtNum)
        {
            lblCue.Visible = false;//将提示标签隐藏
            String strContent = txtNum.Trim();//得到txtNum1中用户输入的内容
            int len = strContent.Length; //得到txtNum1中用户输入内容的长度
            char[] arrContent = strContent.ToCharArray(); //将字符串内容转换成字符数组
            bool isNumber = true; //是否是数字的标记
            foreach (char chr in arrContent)
            {
                if (!char.IsDigit(chr))
                {
                    isNumber = false;
                    break;
                }
            }
            if (!isNumber) //判断标记
            {
                lblCue.Visible = true;
                //txtNum = strContent.Substring(0, len - 1); //截去刚刚输入的错误字符
                //txtNum.SelectionStart = txtNum.Length; //使光标停留在最后
            }
        }

        //输入非法数字时的提示---------在内容变更时触发
        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            Cue(txtMoney.Text.Trim());
        }


        //清空内容
        private void Clear()
        {
            txtName.Text = "";          //清空电影名称
            txtMain.Text = "";          //清空主演
            cboType.SelectedIndex = 0;  //默认为空
            txtDirect.Text = "";        //导演信息
            txtLanguage.Text = "";      //清空语言
            txtContent.Text = "";       //清空简介
            txtMoney.Text = "";         //清空价格
            cboTime.SelectedIndex = 0;  //默认为空
            txtHour.Text = "";          //清空片长
            PathHelper.relPathDirectory = "";//清空路径
        }
        #endregion
    }
}