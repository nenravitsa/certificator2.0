﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto.Tls;
using sertificator;

namespace certificator
{
    public partial class CreateDB : Form
    {
        public CreateDB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            servName.Text = CreatePDF.service.NameServ;
            descript.Text = CreatePDF.service.Description;
        }
    }
}
