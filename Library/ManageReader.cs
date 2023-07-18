using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class ManageReader : Form
    {
        bool flag1 = false;
        string Account;
        public ManageReader(int type, string account)
        {
            InitializeComponent();
            if (type == 1)
            {
                ManageReaderButton.Text = "添加";
                ManageReaderButton.Click += AddReaderButton_Click;
            }
            else if (type == 2)
            {
                ManageReaderButton.Text = "修改";
                ManageReaderButton.Click += ModifyReaderButton_Click;
            }
            else if (type == 3)
            {
                label1.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                NameTextBox.Visible = false;
                SexTextBox.Visible = false;
                JobTextBox.Visible = false;
                TotalnumTextBox.Visible = false;
                BorrownumTextBox.Visible = false;
                DepartmentTextBox.Visible = false;
                PhoneTextBox.Visible = false;
                ManageReaderButton.Text = "删除";
                label3.Location = new System.Drawing.Point(191, 169);
                AccountTextBox.Location = new System.Drawing.Point(291, 165);
                ManageReaderButton.Location = new System.Drawing.Point(329, 255);
                ManageReaderButton.Click += DeleteReaderButton_Click;
            }
            else
            {
                flag1 = true;
                Account = account;
                this.Text = "修改个人信息";
                label3.Visible = false;
                AccountTextBox.Visible = false;
                ManageReaderButton.Text = "修改";
                ManageReaderButton.Click += ModifyReaderButton_Click;
            }
        }

        private void AddReaderButton_Click(object sender, EventArgs e)
        {
            string val1 = AccountTextBox.Text;
            string val2 = NameTextBox.Text;
            string val3 = SexTextBox.Text;
            string val4 = JobTextBox.Text;
            string val5 = TotalnumTextBox.Text;
            string val6 = BorrownumTextBox.Text;
            string val7 = DepartmentTextBox.Text;
            string val8 = PhoneTextBox.Text;
            if (val1 == "" || val2 == "" || val3 == "" || val4 == "" || val5 == "" || val6 == "" || val7 == "" || val8 == "")
                MessageBox.Show("请将信息填写完整");
            else
            {
                string sql1 = "insert into readerInfo values('" + val1 + "','" + val2 + "','" + val3 + "','" + val4 + "'," +
                val5 + "," + val6 + ",'" + val7 + "','" + val8 + "')";
                string sql2 = "insert into login values('" + val1 + "','123456',0)";
                if (Login.ExecuteSql(sql1) != 0)
                {
                    Login.ExecuteSql(sql2);
                    MessageBox.Show("添加成功");
                }
                else
                    MessageBox.Show("读者已存在");
            }
        }

        private void ModifyReaderButton_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string sql = "update readerInfo set ";
            string val1 = AccountTextBox.Text;
            if (val1 == "" && !flag1)
                MessageBox.Show("请填写借书账号");
            if (flag1)
                val1 = Account;
            string val2 = NameTextBox.Text;
            if (val2 != "")
            {
                if (flag)
                    sql += ",";
                sql += "name = '" + val2 + "'";
                flag = true;
            }
            string val3 = SexTextBox.Text;
            if (val3 != "")
            {
                if (flag)
                    sql += ",";
                sql += "sex = '" + val3 + "'";
                flag = true;
            }
            string val4 = JobTextBox.Text;
            if (val4 != "")
            {
                if (flag)
                    sql += ",";
                sql += "job = '" + val4 + "'";
                flag = true;
            }
            string val5 = TotalnumTextBox.Text;
            if (val5 != "")
            {
                if (flag)
                    sql += ",";
                sql += "totalnum = " + val5;
                flag = true;
            }
            string val6 = BorrownumTextBox.Text;
            if (val6 != "")
            {
                if (flag)
                    sql += ",";
                sql += "borrownum = " + val6;
                flag = true;
            }
            string val7 = DepartmentTextBox.Text;
            if (val7 != "")
            {
                if (flag)
                    sql += ",";
                sql += "department = '" + val7 + "'";
                flag = true;
            }
            string val8 = PhoneTextBox.Text;
            if (val8 != "")
            {
                if (flag)
                    sql += ",";
                sql += "phone = '" + val8 + "'";
                flag = true;
            }

            if (flag == false)
            {
                MessageBox.Show("请输入修改信息");
            }
            else
            {
                sql += " where account = '" + val1 + "'";
                if (Login.ExecuteSql(sql) != 0)
                    MessageBox.Show("修改成功");
                else
                    MessageBox.Show("读者不存在");
            }
        }

        private void DeleteReaderButton_Click(object sender, EventArgs e)
        {
            string val1 = AccountTextBox.Text;
            if (val1 == "")
                MessageBox.Show("请填写借书证号");
            else
            {
                string sql1 = "select * from borrowInfo where account = '" + val1 + "' and rdate is null";
                if (Login.Query(sql1).Tables[0].Rows.Count != 0)
                {
                    MessageBox.Show("删除失败，该读者有未归还的图书");
                }
                else
                {
                    string sql2 = "delete from readerInfo where account = '" + val1 + "'";
                    string sql3 = "delete from login where account = '" + val1 + "'";
                    if (Login.ExecuteSql(sql2) != 0)
                    {
                        Login.ExecuteSql(sql3);
                        MessageBox.Show("删除成功");
                    }
                    else
                        MessageBox.Show("读者不存在");
                }
            }
        }
    }
}