using System;
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

        private void infostxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            inputFile = File.OpenText("Contact Tracing Informations.txt");
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
