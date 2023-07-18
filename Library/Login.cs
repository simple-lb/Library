using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
    public partial class Login : Form
    {
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        public Login()
        {
            InitializeComponent();
        }

        public static DataSet Query(String sql)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                sda.Fill(ds, "result");
                return ds;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                sda.Dispose();
                con.Close();
            }
        }
        public static int ExecuteSql(String sql)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows;
            }
            catch (SqlException e)
            {
                return 0;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            string account = AccountTextBox.Text;
            string password = PasswordTextBox.Text;
            if (account == "" && password == "")
            {
                MessageBox.Show("学工号和密码不能为空！");
            }
            else if (account == "")
            {
                MessageBox.Show("学工号不能为空！");
            }
            else if (password == "")
            {
                MessageBox.Show("密码不能为空！");
            }
            else
            {
                string sql = "select authority, password from login where account = '" + account + "';";
                DataSet ds = Query(sql);
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("此用户不存在！");
                }
                else
                {
                    if (password != dt.Rows[0][1].ToString())
                    {
                        MessageBox.Show("密码错误！");
                    }
                    else
                    {
                        if (dt.Rows[0][0].ToString() == "0") // 读者
                        {
                            Reader form = new Reader(account);
                            form.Show();
                            form.FormClosed += form_closed;
                            this.Hide();
                        }
                        else
                        {
                            Admin form = new Admin(); // 管理员
                            form.Show();
                            form.FormClosed += form_closed;
                            this.Hide();
                        }
                    }
                }
            }
        }

        private void form_closed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}