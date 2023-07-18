using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Book : Form
    {
        string Account;
        public Book(int type, string account)
        {
            this.Account = account;
            InitializeComponent();
            if (type == 0)
            {
                this.Text = BookButton.Text = "借阅";
                BookButton.Click += BorrowBookButton_Click;
            }
            else
            {
                label2.Visible = false;
                DaysTextBox.Visible = false;
                this.Text = BookButton.Text = "归还";
                BookButton.Click += ReturnBookButton_Click;
            }
        }

        private void BorrowBookButton_Click(object sender, EventArgs e)
        {
            string val1 = ISBNTextBox.Text;
            string val2 = DaysTextBox.Text;
            if (val1 == "" || val2 == "")
                MessageBox.Show("请将信息填写完整");
            else
            {
                string sql1 = "select * from borrowInfo where account = '" + Account + "' and fine> 0";
                DataSet ds = Login.Query(sql1);
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                    MessageBox.Show("暂无借书权限，请先缴纳罚款");
                else
                {
                    string sql2 = "select * from bookInfo where ISBN = '" + val1 + "'";
                    dt = Login.Query(sql2).Tables[0];
                    if (dt.Rows.Count == 0)
                        MessageBox.Show("图书不存在");
                    else if (dt.Rows[0][6].ToString() == "不可借")
                        MessageBox.Show("该书暂不可借");
                    else
                    {
                        DateTime time1 = DateTime.Now;
                        DateTime time2 = time1.AddDays(int.Parse(val2));
                        string sql4 = "insert into borrowInfo values('" + Account + "','" + val1 + "','"
                            + time1.ToString() + "','" + time2.ToString() + "',null,0)";
                        if (Login.ExecuteSql(sql4) != 0)
                            MessageBox.Show("借阅成功");
                        else
                            MessageBox.Show("借阅失败");
                    }
                }
            }
        }

        private void ReturnBookButton_Click(object sender, EventArgs e)
        {
            string val1 = ISBNTextBox.Text;
            if (val1 == "")
                MessageBox.Show("请填写ISBN书号");
            else
            {
                string sql1 = "select * from bookInfo where ISBN = '" + val1 + "'";
                DataTable dt = Login.Query(sql1).Tables[0];
                if (dt.Rows.Count == 0)
                    MessageBox.Show("图书不存在");
                else
                {
                    string sql2 = "select * from borrowInfo where account = '" + Account + "' and ISBN= '" + val1 + "'";
                    dt = Login.Query(sql2).Tables[0];
                    if (dt.Rows.Count == 0)
                        MessageBox.Show("不存在此书的借阅记录");
                    else
                    {
                        DateTime time = DateTime.Now;
                        string sql3;
                        if (time > Convert.ToDateTime(dt.Rows[0][3]))
                        {
                            MessageBox.Show("还书超时，罚款100元");
                            sql3 = "update borrowInfo set rdate = '" + time.ToString() + "',fine = 0 where account = '" + Account + "' and ISBN= '" + val1 + "'";
                        }
                        else
                            sql3 = "update borrowInfo set rdate = '" + time.ToString() + "' where account = '" + Account + "' and ISBN= '" + val1 + "'";
                        if (Login.ExecuteSql(sql3) != 0)
                            MessageBox.Show("还书成功");
                        else
                            MessageBox.Show("还书失败");
                    }
                }
            }
        }
    }
}
