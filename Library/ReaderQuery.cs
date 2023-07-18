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
    public partial class ReaderQuery : Form
    {
        public ReaderQuery()
        {
            InitializeComponent();
        }

        private void ReaderInfoButton_Click(object sender, EventArgs e)
        {
            string val1 = AccountTextBox.Text;
            string sql = "exec ReaderInfoQuery @account = '" + val1 + "'";
            DataSet ds = Login.Query(sql);
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count == 0)
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("读者不存在");
            }
            else
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                dataGridView1.DataSource = dt;
            }
        }

        private void NRBookButton_Click(object sender, EventArgs e)
        {
            string val1 = AccountTextBox.Text;
            string sql = "exec NRBookQuery @account = '" + val1 + "'";
            DataSet ds = Login.Query(sql);
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count == 0)
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("全部图书已归还");
            }
            else
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                dataGridView1.DataSource = dt;
            }
        }
    }
}
