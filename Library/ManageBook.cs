using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class ManageBook : Form
    {
        public ManageBook(int type)
        {
            InitializeComponent();
            if (type == 1)
            {
                ManageBookButton.Text = "添加";
                ManageBookButton.Click += AddBookButton_Click;
            }
            else if (type == 2)
            {
                ManageBookButton.Text = "修改";
                ManageBookButton.Click += ModifyBookButton_Click;
            }
            else
            {
                label2.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                BnameTextBox.Visible = false;
                PressTextBox.Visible = false;
                AuthorTextBox.Visible = false;
                TotalnumTextBox.Visible = false;
                AvanumTextBox.Visible = false;
                BorrowTextBox.Visible = false;
                label1.Location = new System.Drawing.Point(191, 169);
                ISBNTextBox.Location = new System.Drawing.Point(291, 165);
                ManageBookButton.Location = new System.Drawing.Point(329, 255);
                ManageBookButton.Text = "删除";
                ManageBookButton.Click += DeleteBookButton_Click;
            }
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            string val1 = ISBNTextBox.Text;
            string val2 = BnameTextBox.Text;
            string val3 = PressTextBox.Text;
            string val4 = AuthorTextBox.Text;
            string val5 = TotalnumTextBox.Text;
            string val6 = AvanumTextBox.Text;
            string val7 = BorrowTextBox.Text;
            if (val1 == "" || val2 == "" || val3 == "" || val4 == "" || val5 == "" || val6 == "" || val7 == "")
                MessageBox.Show("请将信息填写完整");
            else
            {
                string sql = "insert into bookInfo values('" + val1 + "','" + val2 + "','" + val3 + "','" + val4 + "'," +
                val5 + "," + val6 + ",'" + val7 + "')";
                if (Login.ExecuteSql(sql) != 0)
                    MessageBox.Show("添加成功");
                else
                    MessageBox.Show("图书已存在");
            }
        }

        private void ModifyBookButton_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string sql = "update BookInfo set ";
            string val1 = ISBNTextBox.Text;
            if (val1 == "")
                MessageBox.Show("请填写ISBN书号");
            string val2 = BnameTextBox.Text;
            if (val2 != "")
            {
                if (flag)
                    sql += ",";
                sql += "bname = '" + val2 + "'";
                flag = true;
            }
            string val3 = PressTextBox.Text;
            if (val3 != "")
            {
                if (flag)
                    sql += ",";
                sql += "press = '" + val3 + "'";
                flag = true;
            }
            string val4 = AuthorTextBox.Text;
            if (val4 != "")
            {
                if (flag)
                    sql += ",";
                sql += "author = '" + val4 + "'";
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
            string val6 = AvanumTextBox.Text;
            if (val6 != "")
            {
                if (flag)
                    sql += ",";
                sql += "avanum = " + val6;
                flag = true;
            }
            string val7 = BorrowTextBox.Text;
            if (val7 != "")
            {
                if (flag)
                    sql += ",";
                sql += "borrow = '" + val7 + "'";
                flag = true;
            }

            if (flag == false)
            {
                MessageBox.Show("请输入修改信息");
            }
            else
            {
                sql += " where ISBN = '" + val1 + "'";
                if (Login.ExecuteSql(sql) != 0)
                    MessageBox.Show("修改成功");
                else
                    MessageBox.Show("图书不存在");
            }
        }
        private void DeleteBookButton_Click(object sender, EventArgs e)
        {
            string val1 = ISBNTextBox.Text;
            if (val1 == "")
                MessageBox.Show("请填写ISBN书号");
            else
            {
                string sql = "delete from bookInfo where ISBN = '" + val1 + "'";
                if (Login.ExecuteSql(sql) != 0)
                    MessageBox.Show("删除成功");
                else
                    MessageBox.Show("图书不存在");
            }
        }
    }
}
