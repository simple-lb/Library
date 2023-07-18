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
    public partial class Fine : Form
    {
        public Fine()
        {
            InitializeComponent();
        }

        private void FineButton_Click(object sender, EventArgs e)
        {
            string val1 = AccountTextBox.Text;
            string val2 = ISBNTextBox.Text;
            string sql = "update borrowInfo set fine = 0 where account = '" + val1 + "' and ISBN = '" + val2 + "' and fine > 0";
            if (Login.ExecuteSql(sql) != 0)
                MessageBox.Show("罚款记录已删除");
            else
                MessageBox.Show("无罚款记录");
        }
    }
}
