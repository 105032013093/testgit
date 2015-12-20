using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

using System.Diagnostics;

namespace FilmsSelect
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            if (UserHelper.loginType == "��ƱԱ")//�жϵ�¼���ͣ���ʾ��ع���
            {

                tsbtnAdd.Enabled = false;//�������ƱԱ��½������ӰƬ���ܲ���ʹ��
                tsbtnUptade.Enabled = false;//�������ƱԱ��½�����¼��޸�ӰƬ���ܲ���ʹ��
                tsmiAdd.Enabled = false;//�������ƱԱ��½���˵�������ӰƬ���ܲ���ʹ��
                tsmiUpdate.Enabled = false;//�������ƱԱ��½���˵����޸�ӰƬ���ܲ���ʹ��
                tsmiDelete.Enabled = false;//�������ƱԱ��½���˵���ɾ��ӰƬ���ܲ���ʹ��

            }
            this.tsmiLogin.Text = UserHelper.loginId + "  " + UserHelper.loginType + "  ��ӭ����";
            //����״̬���ı�ǩ�ı�����ʾ��ǰ��¼���û���
        }

        //�����ʱ����

        private void tsmiExit_Click(object sender, EventArgs e)//�����˳�����ʾ�˳��Ի���
        {

            ExitForm exit = new ExitForm();
            exit.ShowDialog();//��ʾģʽ����
            this.Close();
        }
        private void tsmiAdd_Click(object sender, EventArgs e)//����ӰƬ���ӣ���������ӰƬ����
        {
            AddForm add = new AddForm();
            add.ShowDialog();//��ʾ����
        }
        private void tsmiUpdate_Click(object sender, EventArgs e)//����ӰƬ�޸ģ������޸�ӰƬ����
        {
            UpdateFilmForm update = new UpdateFilmForm();
            update.ShowDialog();

        }
        private void tsmiFilms_Click(object sender, EventArgs e) //��ʾ��Ӱ��Ϣ��ѯ����
        {
            SelectForm select = new SelectForm();
            select.ShowDialog();
        }
        private void tsmiDelete_Click(object sender, EventArgs e)//��ʾ���£��޸ġ�ɾ������Ӱ��Ϣ����
        {
            UpdateFilmForm update = new UpdateFilmForm();
            update.ShowDialog();

        }
        private void tsbtnAdd_Click(object sender, EventArgs e)//��ʾ���ӵ�Ӱ��Ϣ����
        {

            AddForm add = new AddForm();
            add.ShowDialog();//��ʾ����
        }

        private void tsbtnSearch_Click(object sender, EventArgs e)//��ʾ��ѯӰƬ����
        {
            SelectForm select = new SelectForm();
            select.ShowDialog();
        }

        private void tsbtnUptade_Click(object sender, EventArgs e)//��ʾ���£��޸ġ�ɾ������Ӱ��Ϣ����
        {
            UpdateFilmForm update = new UpdateFilmForm();
            update.ShowDialog();
        }

        private void tsbtnOder_Click(object sender, EventArgs e)//��ʾ��Ʊ����
        {
            SearchTicketForm sea = new SearchTicketForm();
            sea.ShowDialog();
        }

        private void tsmiOrder_Click(object sender, EventArgs e)//��ʾ��Ʊ����
        {
            SelectForm se = new SelectForm();
            se.ShowDialog();
        }


        private void tsmiSearch_Click(object sender, EventArgs e)//��ʾ��ѯ��Ʊ��Ϣ
        {
            SearchTicketForm sea = new SearchTicketForm();
            sea.ShowDialog();
        }



        private void tsmiMemberInfor_Click(object sender, EventArgs e)//��ʾ��Ա��Ϣ����
        {
            MemberForm men = new MemberForm();
            men.ShowDialog();
        }

        private void tsmiRegister_Click(object sender, EventArgs e)//��ʾ��Աע�ᴰ��
        {
            RegistForm nfe = new RegistForm();
            nfe.ShowDialog();
        }

        private void tsmiMoney_Click(object sender, EventArgs e)//��ʾ��ѯǮ�䴰��
        {
            MoneyForm mi = new MoneyForm();
            mi.ShowDialog();
        }

        private void picMember_Click(object sender, EventArgs e)//�����Ա��ť��������Ա��Ϣ����
        {
                MemberForm men = new MemberForm();
                men.ShowDialog();
        }

        private void picAbout_Click(object sender, EventArgs e)//���������ʾ���ڴ���
        {
            AboutForm sbi = new AboutForm();
            sbi.ShowDialog();
        }
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            AboutForm ab = new AboutForm();
            ab.ShowDialog();
        }
    }





}
