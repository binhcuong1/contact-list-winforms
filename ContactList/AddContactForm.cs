﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();

            btnLuu.Click += btnLuu_Click;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            AddContactForm frm = new AddContactForm();
            frm.Show();
        }
    }
}
