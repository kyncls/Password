﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalPassword
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }
    }
}
