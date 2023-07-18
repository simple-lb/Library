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
    public partial class NRInfo : Form
    {
        public NRInfo()
        {
            InitializeComponent();
            string sql = "select * from NRInfo";
            DataSet ds = Login.Query(sql);
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count == 0)
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("图书已全部归还");
            }
            else
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = dt;
            }
        }
    }
}
