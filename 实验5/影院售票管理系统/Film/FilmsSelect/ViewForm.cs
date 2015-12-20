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
               // picFace.Image = Image.FromFile("Images\\��.gif");
               
            }
        }

        //�޸ĺ��������¼�
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(PathHelper.currentDirectory);
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                String sourcePath = open.FileName; //Դ·��
                Image img = Image.FromFile(sourcePath);//�õ�ѡ�е�ͼƬ
                String name = Path.GetFileName(open.FileName); //�ļ�����
                String relPath = PathHelper.defaultDirectory + "\\" + name; //���Ŀ��·��
                String destPath = PathHelper.currentDirectory + "\\" + relPath; //����Ŀ��·��
                try
                {
                    File.Copy(sourcePath, destPath, true); //�����ļ�
                    //��ͼƬ��ؼ�����ʾ����
                    picFace.Image = img;
                    AddPath(relPath, UserHelper.ID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //�������ݿ����·��
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
                    DialogResult result = MessageBox.Show("���³ɹ���");
                    update.UpdateNew();
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("��������ʧ�ܣ�");
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

        //��굥����ť�¼�
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}