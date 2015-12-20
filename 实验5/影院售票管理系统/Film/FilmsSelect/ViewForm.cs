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
    public partial class ViewForm : Form
    {
        UpdateFilmForm update;
        public ViewForm(UpdateFilmForm update)
        {
            InitializeComponent();
            this.update = update;
        }
        private void ViewForm_Load(object sender, EventArgs e)
        {
            if (PathHelper.relPath.Trim() != "")
            {
                picFace.Image = Image.FromFile(PathHelper.relPath);

                
            }
            else
            {
               // picFace.Image = Image.FromFile("Images\\空.gif");
               
            }
        }

        //修改海报单击事件
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(PathHelper.currentDirectory);
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                String sourcePath = open.FileName; //源路径
                Image img = Image.FromFile(sourcePath);//得到选中的图片
                String name = Path.GetFileName(open.FileName); //文件名称
                String relPath = PathHelper.defaultDirectory + "\\" + name; //相对目标路径
                String destPath = PathHelper.currentDirectory + "\\" + relPath; //绝对目标路径
                try
                {
                    File.Copy(sourcePath, destPath, true); //拷贝文件
                    //在图片框控件中显示出来
                    picFace.Image = img;
                    AddPath(relPath, UserHelper.ID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //更新数据库相对路径
        private void AddPath(String relPath, int ID)
        {
            try
            {
                DBHelper.conn.Open();
                String sql = String.Format("UPDATE Film SET FPhoto='{0}' WHERE FID={1}", relPath, ID);
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                int row = comm.ExecuteNonQuery();
                if (row == 1)
                {
                    DialogResult result = MessageBox.Show("更新成功！");
                    update.UpdateNew();
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("更新数据失败！");
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

        //鼠标单击按钮事件
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}