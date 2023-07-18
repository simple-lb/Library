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
    public partial class Reader : Form
    {
        string Account;
        public Reader(string account)
        {
            InitializeComponent();
            Account = account;
        }

        private void SearchBookButton_Click(object sender, EventArgs e)
        {
            BookQuery form = new BookQuery();
            form.Show();
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            ManageReader form = new ManageReader(4, Account);
            form.Show();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePassword form = new ChangePassword(Account);
            form.Show();
        }

        private void BorrowButton_Click(object sender, EventArgs e)
        {
            Book form = new Book(0, Account);
            form.Show();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Book form = new Book(1, Account);
            form.Show();
        }

        private void Reader_Load(object sender, EventArgs e)
        {

        }
    }
}
