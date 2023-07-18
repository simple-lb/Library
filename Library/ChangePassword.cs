using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class ChangePassword : Form
    {
        string Account;
        public ChangePassword(string account)
        {
            this.Account = account;
            InitializeComponent();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            string sql1 = "select password from login where account = '" + Account + "'";
            DataSet ds = Login.Query(sql1);
            DataTable dt = ds.Tables[0];
            if (dt.Rows[0][0].ToString() != OldTextBox.Text)
                MessageBox.Show("原密码错误");
            else
            {
                string val = NewTextBox.Text;
                if (val.Length > 0)
                {
                    string sql2 = "update login set password = '" + val + "' where account = '" + Account + "'";
                    if (Login.ExecuteSql(sql2) != 0)
                        MessageBox.Show("修改成功");
                    else
                        MessageBox.Show("修改失败");
                }
                else
                    MessageBox.Show("请输入新密码");
            }
        }
    }
}
