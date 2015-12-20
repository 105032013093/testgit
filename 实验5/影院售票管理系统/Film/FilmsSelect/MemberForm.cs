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
    public partial class MemberForm : Form
    {
        //数据集对象 
        DataSet da = new DataSet();
        //适配器
        SqlDataAdapter adapter;
        public MemberForm()
        {
            InitializeComponent();
        }

        private void MemberInformationForm_Load(object sender, EventArgs e) //窗体事件
        {
            if (UserHelper.loginType == "售票员")
                tsmiDelete.Enabled = false;
            
           
            cboStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStyle.Items.Add("钻石会员");
            cboStyle.Items.Add("金卡会员");
            cboStyle.Items.Add("银卡会员");

            String sql = ("SELECT MID,MName,MIDcard,MPhone,MDiscount,MType FROM Member");
            adapter = new SqlDataAdapter(sql, DBHelper.conn);
            adapter.Fill(da, "Member");
            dgvMemberInformation.DataSource = da.Tables["Member"];
            //更改列名
            dgvMemberInformation.Columns["MName"].HeaderText = "姓名";
            dgvMemberInformation.Columns["MIDcard"].HeaderText = "证件号";
            dgvMemberInformation.Columns["MPhone"].HeaderText = "电话号码";
            dgvMemberInformation.Columns["MDiscount"].HeaderText = "折扣类型";
            dgvMemberInformation.Columns["MType"].HeaderText = "会员类型";


            //隐藏"MID"列
            dgvMemberInformation.Columns["MID"].Visible = false;

            //设置"MType"列 只读
            dgvMemberInformation.Columns["MType"].ReadOnly = true;
        }

        private void btnSearch_Click(object sender, EventArgs e) //单击"btnSearch"事件
        {

            String sql = (@"SELECT MID, MName,MIDcard,MPhone,MDiscount,MType FROM Member");
            //查找
            switch (cboStyle.Text)
            {
                case "钻石会员":
                    sql += " WHERE MType='钻石会员'";
                    break;
                case "金卡会员":
                    sql += " WHERE MType='金卡会员'";
                    break;
                case "银卡会员":
                    sql += " WHERE MType='银卡会员'";
                    break;
                default:
                    break;
            }
            da.Tables["Member"].Clear();
            adapter.SelectCommand.CommandText = sql;
            adapter.Fill(da, "Member");
        }

        private void dgvMemberInformation_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e) //"dgvMemberInformation"鼠标移动事件
        {
            //保证在行内
            if (e.RowIndex >= 0)
            {
                //行背景设置
                dgvMemberInformation.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.SkyBlue;
                //行文字设置
                dgvMemberInformation.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.SeaShell;
            }
        }

        private void dgvMemberInformation_CellMouseLeave(object sender, DataGridViewCellEventArgs e) //"dgvMemberInformation"鼠标离开事件
        {
            //保证在行内
            if (e.RowIndex >= 0)
            {
                //行背景设置
                dgvMemberInformation.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                //行文字设置
                dgvMemberInformation.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void btnExit_Click(object sender, EventArgs e) // 单击"btnCancel"查询事件
        {
            //点击"取消"关闭窗口
            this.Close();
        }


        private void tsmiDelete_Click(object sender, EventArgs e) //右击"删除"事件
        {
            string id = dgvMemberInformation.SelectedRows[0].Cells["MID"].Value.ToString(); //得到会员的主键ID
            try
            {
                DBHelper.conn.Open(); //打开数据库
                string sql = string.Format("DELETE FROM Member WHERE MID={0} ", Convert.ToInt32(id));
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);

                if (comm.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
                da.Tables["Member"].Clear();
                adapter.Fill(da, "Member");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();  //关闭数据库
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e) //单击"btnRefurbish"刷新事件
        {
            String sql = ("SELECT MID,MName,MIDcard,MPhone,MDiscount,MType FROM Member");
            adapter = new SqlDataAdapter(sql, DBHelper.conn);
            da.Tables["Member"].Clear();
            adapter.Fill(da, "Member");
            dgvMemberInformation.DataSource = da.Tables["Member"];
        }

        private void btnRegister_Click(object sender, EventArgs e)   //点击"添加"事件
        {
            this.Close();
            RegistForm re = new RegistForm();
            re.ShowDialog();

        }

        //得到会员的总数
        private int GetNum()
        {
            int num = 0; //定义接受会员的数量
            String sql = @"SELECT count(*) FROM Member";
            try
            {
                DBHelper.conn.Open();
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                num = Convert.ToInt32(comm.ExecuteScalar());  //得到会员的总数
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
            return num;
        }
        //抽奖方法
        private void GetName()
        {
            String sql = @"SELECT MName FROM Member";
            try
            {
                String[] number = new String[GetNum()];   //定义数组接受会员姓名 
                DBHelper.conn.Open();
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                SqlDataReader reader = comm.ExecuteReader();
                int i = 0;
                while (reader.Read())  //       循环读出会员姓名存入 number 数组中
                {
                    number[i] = reader["MName"].ToString(); 
                    i++;
                }
                reader.Close();
                Random random = new Random();
                int MemberIndex = random.Next(number.Length);  //随机得到  number 数组的索引值
                txtName.Text = number[MemberIndex];    //在控件中显示数组相对应姓名
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

        //单击抽奖按钮事件
        private void btnDistill_Click(object sender, EventArgs e)
        {
            GetName();   //调用"SetSelectedMemberIds"方法
        }
    }
}
