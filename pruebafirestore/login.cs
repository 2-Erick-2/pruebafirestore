﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebafirestore
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            if (txtlogin.Text == "1234")
            {
                Form1 F1 = new Form1();
                F1.Show();

            }
                
        }

        private void txtlogin_TextChanged(object sender, EventArgs e)
        {
            if (txtlogin.Text == "1234")
            {
                Form1 F1 = new Form1();
                F1.Show();
                this.Hide();

            }
        }
    }
}
