using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void AddReaderButton_Click(object sender, EventArgs e)
        {
            ManageReader form = new ManageReader(1, null);
            form.Show();
        }

        private void ModifyReaderButton_Click(object sender, EventArgs e)
        {
            ManageReader form = new ManageReader(2, null);
            form.Show();
        }

        private void DeleteReaderButton_Click(object sender, EventArgs e)
        {
            ManageReader form = new ManageReader(3, null);
            form.Show();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            ManageBook form = new ManageBook(1);
            form.Show();
        }

        private void ModifyBookButton_Click(object sender, EventArgs e)
        {
            ManageBook form = new ManageBook(2);
            form.Show();
        }

        private void DeleteBookButton_Click(object sender, EventArgs e)
        {
            ManageBook form = new ManageBook(3);
            form.Show();
        }

        private void ReaderQueryButton_Click(object sender, EventArgs e)
        {
            ReaderQuery form = new ReaderQuery();
            form.Show();
        }

        private void BookQueryButton_Click(object sender, EventArgs e)
        {
            BookQuery form = new BookQuery();
            form.Show();
        }

        private void NRQueryButton_Click(object sender, EventArgs e)
        {
            NRInfo form = new NRInfo();
            form.Show();
        }

        private void FineButton_Click(object sender, EventArgs e)
        {
            Fine form = new Fine();
            form.Show();
        }
    }
}
