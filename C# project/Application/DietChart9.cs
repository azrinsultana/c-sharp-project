﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class DietChart9 : Form
    {
        public DietChart9()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CheckHealthStatus chk = new CheckHealthStatus();
            this.Close();
            //chk.Show();
        }
    }
}
