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

        //在Load事件里添加数据
        private void OrderForm_Load(object sender, EventArgs e)
        {
            lblnum.Visible = false;
            GetAdd();//<电影的基本默认信息>和<类型> ====================================调用方法
            for (int i = 1; i <= 150; i++) //添加150张影票
            {
                dudnum.Items.Add(i);
            }
        }



        //从数据库中读出<电影的基本默认信息>和<类型>====================================添加<方法>
        private void GetAdd()
        {
            //添加下拉框内的座位类型
            cboSeat.Items.Add("情侣座");
            cboSeat.Items.Add("硬座");
            cboSeat.Items.Add("软座");


            //=====================================从数据库中读出折扣类型==============================

            string sql = "select AType,ARebate from Agio";
            try
            {
                DBHelper.conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);  //创建Command对象
                SqlDataReader reader = comm.ExecuteReader();           //执行命令(ExecuteReader用来读取数据的)
                while (reader.Read())                                  //循环读出座位类型（用read()方法读取一行数据）
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

            #region（电影的信息读出来放在对应的文本框里）
            //将数据库中的电影的信息读出来放在所对应的文本框里===============================================添数据
            sql = string.Format(@"select F.FID as Id, F.FFilmName as '片名',F.FDirector as '导演',F.FPlay as '主演',F.FIntro as '简介',
                                F.FLanguage as '语言',F.FLong as '片长',F.FDate as '放映日期',F.FMoney as '票价',
                                F.FNumber as '票数',F.FNum as '座位号',S.SSort as '类型',T.TTime as '放映时间',
                                H.HHall as '大厅'
                                from Film as F ,Sort as S ,Time as T ,Hall as H
                                where F.FSortID=S.SOID and F.FTimeID = T.TID and H.HID=T.THallID and   F.FID ={0}", UserHelper.Id);
            try
            {
                DBHelper.conn.Open();
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    txtName.Text = reader["片名"].ToString();
                    txtName.ReadOnly = true;
                    txtMain.Text = reader["主演"].ToString();
                    txtMain.ReadOnly = true;
                    txtType.Text = reader["类型"].ToString();
                    txtType.ReadOnly = true;
                    txtDirect.Text = reader["导演"].ToString();
                    txtDirect.ReadOnly = true;
                    txtTime.Text = reader["放映日期"].ToString();
                    txtTime.ReadOnly = true;
                    txtlanguage.Text = reader["语言"].ToString();
                    txtlanguage.ReadOnly = true;
                    txtDays.Text = reader["放映时间"].ToString();
                    txtDays.ReadOnly = true;
                    txtPrice.Text = reader["票价"].ToString();
                    txtPrice.ReadOnly = true;
                    txtHour.Text = reader["片长"].ToString();
                    txtHour.ReadOnly = true;
                    txtHall.Text = reader["大厅"].ToString();
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



        #region(判断只能填数字 ASC码 以及验证输入是否是合法的证件号)
        //当用户按下某个键时触发===============================用ASC码判断用户是否按了不在0-9范围之内的数
        private void txtCert1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能够输入0~9(ASC:48~57)之间的字符（包括退格键 ASC:8)
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }
        //电话号码只能输入数字
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能够输入0~9(ASC:48~57)之间的字符（包括退格键 ASC:8)
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                if (e.KeyChar != 8)
                    e.Handled = true;
            }
        }


        //输入的付款只能是数字
        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只能够输入0~9(ASC:48~57)之间的字符（包括退格键 ASC:8)
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                if (e.KeyChar != 8)
                    e.Handled = true;
            }
        }
        //鼠标离开时触发=======================================判断证件号数字不能超过18
        private void txtCert1_Leave(object sender, EventArgs e)
        {

            //得到文本框内所填的数字的长度
            int num = txtCert.Text.Trim().Length;

            if (num != 18)           //判断长度
            {
                MessageBox.Show("请输入合法的证件号<18>位！", "操作提示");
                txtCert.Focus();          //将焦点切回到原来的地方
            }
        }

        //更改Text的属性时引发的事件
        private void txtCert_TextChanged(object sender, EventArgs e)
        {
            if (txtCert.Text.Trim().Length != 18)
            {
                lblnum.Visible = true;  //如果长度不是18位 显示文字
            }
            else
            {
                lblnum.Visible = false; //是18位 不显示
            }
        }

        #endregion


        /// <summary>
        ///  从数据库中读出会员用户的证件号 的方法======================================（在 btnCancel_Click里用到）
        /// </summary>
        /// <param name="cert">证件号</param>
        /// <param name="agio">会员类型</param>
        /// <returns>no</returns>
        private bool GetCardnum(String cert, String agio)
        {
            bool no = false;
            int no1 = 0;
            try
            {
                DBHelper.conn.Open();
                string sql = string.Format(@"select count(*) from Member
                                             where MIDcard='{0}'and MType='{1}'", cert, agio);  //将会员信息(Member) 和 会员类型(MemberTypes)两表相连
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                no1 = Convert.ToInt32(comm.ExecuteScalar());
                if (no1 != 1)                                                          //（如果会员信息(Member) 和 会员类型(MemberTypes)不匹配
                {                                                                       //说明不是会员） 
                    DialogResult result = MessageBox.Show("对不起，你不是会员！请注册！", "提示！",
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
        /// 验证用户在订票表内输入的内容是否完整 的方法
        /// </summary>
        /// <returns></returns>
        private bool ValidateInput()
        {
            bool Conect = false;
            if (cboSeat.Text.Trim() == "")
            {
                MessageBox.Show("请输入座位类型", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSeat.Focus();
                Conect = false;
            }
            else if (cboAgio.Text.Trim() == "")
            {


                MessageBox.Show("请输入打折类型", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboAgio.Focus();

                Conect = false;
            }

            else if (txtNum1.Text.Trim() == "")
            {
                MessageBox.Show("请计算总价格", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNum1.Focus();
                Conect = false;
            }
            else if (txtNum2.Text.Trim() == "")
            {
                MessageBox.Show("请输入付款", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNum2.Focus();
                Conect = false;
            }
            else if (Convert.ToInt32(txtNumber.Text.Trim()) < Convert.ToInt32(dudnum.Text.Trim()))
            {
                txtNum1.Text = "";
                MessageBox.Show("没有票票啦！");
            }
            else if (txtSum.Text.Trim() == "")
            {
                MessageBox.Show("请找零！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNum2.Focus();

                Conect = false;
            }
            else if (Convert.ToInt32(txtNum1.Text.Trim()) > Convert.ToInt32(txtNum2.Text.Trim()))
            {
                MessageBox.Show("付款金额不足！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNum2.Focus();
                txtNum2.Text = "";
                Conect = false;
            }
            else if (Convert.ToInt32(txtNum2.Text.Trim()) - Convert.ToInt32(txtNum1.Text.Trim()) != Convert.ToInt32(txtSum.Text.Trim()))
            {
                MessageBox.Show("请找零！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSum.Focus();
                Conect = false;
            }
            else if (txtCert.Text.Trim() == "")
            {
                MessageBox.Show("请输入会员证件号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCert.Focus();
                Conect = false;
            }
            else
            {
                Conect = true;
            }
            return Conect;
        }

        #region 折率（打折类型）

        /// <summary>
        /// 根据选择折扣类型得到折率
        /// </summary>
        /// <param name="type">打折类型</param>
        /// <returns>折率</returns>
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

        #region 座位的价格（座位类型，大厅）
        /// <summary>
        /// 得到选择座位类型后所加的钱
        /// </summary>
        /// <param name="seat">座位类型</param>
        /// <returns>钱数</returns>
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

        #region 得到剩余票数（大厅，座位类型）<（未订票时）>
        //从数据库中得到剩余票数========================================================剩余票数<方法>
        private void GetNumber(String type)
        {
            string sql = string.Format(@"SELECT FPew AS 硬座,FComPew AS 软座,FLove AS 情侣座
                                         FROM Film
                                         WHERE FID='{0}'", UserHelper.Id);
            try
            {
                DBHelper.conn.Open();
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    //根据选择的座位类型得到相应得票数
                    if (type == "情侣座")
                    {
                        txtNumber.Text = reader["情侣座"].ToString();
                    }
                    else if (type == "硬座")
                    {
                        txtNumber.Text = reader["硬座"].ToString();
                    }
                    else if (type == "软座")
                    {
                        txtNumber.Text = reader["软座"].ToString();
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

        //根据选择的大厅得到ID
        private int GetHall()
        {
            String hallText = txtHall.Text.Trim();
            int hallId = 0;
            //根据大厅得到所选的座位类============================判断在哪个大厅
            switch (hallText)
            {
                case "一号大厅":
                    hallId = 1;
                    break;
                case "二号大厅":
                    hallId = 2;
                    break;
                case "三号大厅":
                    hallId = 3;
                    break;
                default:
                    break;
            }
            return hallId;
        }


        //在座位类型更改时 更改剩余票数 及 价格
        private void cboSeat_SelectedIndexChanged(object sender, EventArgs e)
        {

            GetNumber(cboSeat.Text.Trim()); //得到剩余票数======================调用方法 


            if (cboAgio.Text.Trim() == "")//当 打折类型  为空时
            {
                int hallId = GetHall();//得到大厅的ID的方法

                int money = Convert.ToInt32(GetIncreaseMoneyBySeet(cboSeat.Text.Trim()));  //得到选择座位类型后所加的钱的 方法
                if (cboSeat.Text.Trim() == "情侣座")
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
                if (cboSeat.Text.Trim() == "情侣座")
                {
                    int hallId = GetHall();//得到大厅的ID方法

                    int money = Convert.ToInt32(GetIncreaseMoneyBySeet(cboSeat.Text.Trim()));  //得到选择座位类型后所加的钱的 方法

                    // 根据选择折扣类型得到折率的 方法
                    double discount = Convert.ToDouble(GetDiscountByType(cboAgio.Text)) / 100; //(将它除以100得到打折后的折扣)

                    //得到选择座位类型和打折类型后的==============================价格（情侣是两张）
                    txtMoney.Text = Convert.ToString(Convert.ToInt32((Convert.ToDouble(txtPrice.Text) * 2 + Convert.ToDouble(money)) * discount));
                }
                else
                {
                    int hallId = GetHall();//得到大厅的ID方法

                    int money = Convert.ToInt32(GetIncreaseMoneyBySeet(cboSeat.Text.Trim()));  //得到选择座位类型后所加的钱的 方法

                    // 根据选择折扣类型得到折率的 方法
                    double discount = Convert.ToDouble(GetDiscountByType(cboAgio.Text)) / 100; //(将它除以100得到打折后的折扣)

                    //得到选择座位类型和打折类型后的==============================价格
                    txtMoney.Text = Convert.ToString(Convert.ToInt32((Convert.ToDouble(txtPrice.Text) + Convert.ToDouble(money)) * discount));
                }
            }
        }

        //用户更改打折类型的时 更改价格 =================================================计算
        private void cboAgio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSeat.Text.Trim() == "")//座位类型为空
            {
                // 根据选择折扣类型得到折率的 方法
                double discount = Convert.ToDouble(GetDiscountByType(cboAgio.Text)) / 100; //(将它除以100得到打折后的折扣)
                txtMoney.Text = Convert.ToInt32((Convert.ToDouble(txtPrice.Text.Trim()) * discount)).ToString();

            }
            else
            {
                if (cboSeat.Text.Trim() == "情侣座")
                {

                    //得到选择座位类型后所加的钱的 方法
                    int money = GetIncreaseMoneyBySeet(cboSeat.Text);

                    // 根据选择折扣类型得到折率的 方法
                    double discount = Convert.ToDouble(GetDiscountByType(cboAgio.Text)) / 100; //(将它除以100得到打折后的折扣)
                    //得到选择座位类型和打折类型后的==============================价格
                    txtMoney.Text = Convert.ToString(Convert.ToInt32((Convert.ToDouble(txtPrice.Text) * 2 + Convert.ToDouble(money)) * discount));
                }
                else
                {

                    //得到选择座位类型后所加的钱的 方法
                    int money = GetIncreaseMoneyBySeet(cboSeat.Text);

                    // 根据选择折扣类型得到折率的 方法
                    double discount = Convert.ToDouble(GetDiscountByType(cboAgio.Text)) / 100; //(将它除以100得到打折后的折扣)
                    //得到选择座位类型和打折类型后的==============================价格
                    txtMoney.Text = Convert.ToString(Convert.ToInt32((Convert.ToDouble(txtPrice.Text) + Convert.ToDouble(money)) * discount));
                }
            }
        }


        #region 计算价格
        //票数更改时合计更改
        private void dudnum_TextChanged(object sender, EventArgs e)
        {
            //计算价格
            if (txtMoney.Text.Trim() != "")//价格不为空时
            {
                txtNum1.Text = Convert.ToString(Convert.ToInt32(txtMoney.Text.Trim()) * Convert.ToInt32(dudnum.Text.Trim()));
            }
        }
        //单击合计框时事件
        private void txtNum1_Click(object sender, EventArgs e)
        {
            if (txtMoney.Text.Trim() != "" && txtNumber.Text.Trim() != "")//价格不为空时或者票数为空时
            {
                if (Convert.ToInt32(txtNumber.Text.Trim()) < Convert.ToInt32(dudnum.Text.Trim()))//剩余的票数小于订购的票数
                {
                    //清空文本框
                    txtNum1.Text = "";
                    txtNum2.Text = "";
                    txtSum.Text = "";

                    MessageBox.Show("没有票票啦！");
                }
                else
                {
                    txtNum1.Text = Convert.ToString(Convert.ToInt32(txtMoney.Text.Trim()) * Convert.ToInt32(dudnum.Text.Trim()));
                }
            }
        }

        //单击合计文字时事件
        private void lblNum1_Click(object sender, EventArgs e)
        {
            //计算价格
            if (txtMoney.Text.Trim() != "" && txtNumber.Text.Trim() != "")//价格不为空时或者票数为空时
            {
                if (Convert.ToInt32(txtNumber.Text.Trim()) < Convert.ToInt32(dudnum.Text.Trim()))//剩余的票数小于订购的票数
                {
                    txtNum1.Text = "";
                    MessageBox.Show("没有票票啦！");
                }
                else
                {
                    txtNum1.Text = Convert.ToString(Convert.ToInt32(txtMoney.Text.Trim()) * Convert.ToInt32(dudnum.Text.Trim()));
                }
            }
        }

        //单击找钱框时事件
        private void txtSum_Click(object sender, EventArgs e)
        {
            if (txtNum2.Text.Trim() != "" && txtNum1.Text.Trim() != "" && Payment() == true)
            {
                txtSum.Text = Convert.ToString(Convert.ToInt32(txtNum2.Text.Trim()) - Convert.ToInt32(txtNum1.Text.Trim()));
            }
        }

        //单击找钱汉字时事件
        private void lblSum_Click(object sender, EventArgs e)
        {
            if (txtNum2.Text.Trim() != "" && txtNum1.Text.Trim() != "" && Payment() == true)
            {
                if (txtCert.Text.Trim() == "")//如果证件输入为空时提示
                {
                    MessageBox.Show("请输入证件！");
                    txtCert.Focus();
                }
                else
                {
                    txtSum.Text = Convert.ToString(Convert.ToInt32(txtNum2.Text.Trim()) - Convert.ToInt32(txtNum1.Text.Trim()));
                }
            }
        }

        /// <summary>
        /// 判断付款金额是否小于合计金额================================（在txtSum_Click里用到）
        /// </summary>
        private bool Payment()
        {
            if (Convert.ToInt32(txtNum1.Text.Trim()) > Convert.ToInt32(txtNum2.Text.Trim()))
            {
                MessageBox.Show("付款金额不足！");
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


        //清空数据  的方法==============================================（在GetAddTicket()里用到）
        private void Clear()
        {
            cboSeat.Text = "";//清空座位类型
            txtMoney.Text = "";//清空价格
            cboAgio.Text = "";//清空折扣类型
            dudnum.Text = "1";//恢复票数
            txtCert.Text = "";//清空证件号
            txtPhone.Text = "";
            txtNum1.Text = "";//清空合计
            txtNum2.Text = "";//清空付款值
            txtSum.Text = "";//清空找零
            GetNumber(cboSeat.Text.Trim());//更新票数
        }

        /// <summary>
        ///  减去相应得票数  得到（剩余的票数）==========================(在GetAddTicket()里用到)
        /// </summary>
        /// <param name="type">座位类型</param>
        /// <returns>bool</returns>
        private bool subtract(String type)
        {

            //用相应座位的（总票数）减去（用户订的票数）得到（剩余的票数）
            String sql = "";
            try
            {
                switch (cboSeat.Text.Trim())//座位类型
                {
                    case "硬座":
                        sql = String.Format(@"UPDATE Film SET FPew=FPew-{0}
                                           WHERE FID={1}", Convert.ToInt32(dudnum.Text.Trim()), UserHelper.Id);
                        break;
                    case "软座":
                        sql = String.Format(@"UPDATE Film SET FComPew=FComPew-{0}
                                           WHERE FID={1}", Convert.ToInt32(dudnum.Text.Trim()), UserHelper.Id);
                        break;
                    case "情侣座":
                        sql = String.Format(@"UPDATE Film SET FLove=FLove-{0}
                                           WHERE FID={1}", Convert.ToInt32(dudnum.Text.Trim()), UserHelper.Id);
                        break;
                    default:
                        break;
                }
                DBHelper.conn.Open();
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                int rows = comm.ExecuteNonQuery();//返回多行
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
        /// 将用户订票的所有信息放到数据库 的方法======================（在 btnCancel_Click里用到）
        /// </summary>
        private void GetAddTicket()
        {
            //将订票信息全部插入到Ticket表中
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
                        DialogResult result = MessageBox.Show("订票成功！是否继续！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            DBHelper.conn.Close();
                            this.Clear();//清空数据
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("订票失败！");
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

        //将卖票得钱数放入钱箱 的方法===================================（在 btnCancel_Click里用到）
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
                    MessageBox.Show("更新钱箱成功");
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
        /// 单击订票按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ValidateInput())//调用方法 （输入不为空）
            {

                if (cboAgio.Text.Trim() == "钻石会员" || cboAgio.Text.Trim() == "金卡会员" || cboAgio.Text.Trim() == "银卡会员")
                {

                    if (GetCardnum(txtCert.Text.Trim(), cboAgio.Text.Trim()))   //==调用GetNumber()方法（证件号，折扣类型）
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

                    if (cboAgio.Text.Trim() == "团体购票" && Convert.ToInt32(dudnum.Text.Trim()) < 20)
                    {
                        MessageBox.Show("您的票数不足20张，不能团购！！", "提示！");
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

        //关闭窗体
        private void btnCorrect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
