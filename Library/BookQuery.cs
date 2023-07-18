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
    public partial class BookQuery : Form
    {
        public BookQuery()
        {
            InitializeComponent();
        }

        private void BookInfoButton_Click(object sender, EventArgs e)
        {
            string val1 = ISBNTextBox.Text;
            string val2 = BnameTextBox.Text;
            string val3 = PressTextBox.Text;
            string val4 = AuthorTextBox.Text;
            string sql = "exec BookInfoQuery @ISBN = '" + val1 + "',@bname = '" + val2 + "',@press = '" + val3 + "',@author = '" + val4 + "'";
            DataSet ds = Login.Query(sql);
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count == 0)
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("图书不存在");
            }
            else
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                dataGridView1.DataSource = dt;
            }
        }
    }
}
