﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestDataContext test = new TestDataContext();
            var data = (from rows in test.Streaming_IPs
                        select rows).Count();
            MessageBox.Show(data.ToString());
        }
    }
}