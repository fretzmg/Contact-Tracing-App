﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class LoadInfo : Form
    {
        public LoadInfo()
        {
            InitializeComponent();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            inputFile = File.OpenText("Informations from Contact Tracing App.txt");
            while (!inputFile.EndOfStream)
            {
                infostxtbx.Text += inputFile.ReadLine() + "\r\n";
            }
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
