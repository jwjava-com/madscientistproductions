﻿using System;
using System.Windows.Forms;

namespace PatternBrowserTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PatternBrowser.PatternBrowser pBrowser = new PatternBrowser.PatternBrowser();
        private void button1_Click(object sender, EventArgs e)
        {
            pBrowser.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
