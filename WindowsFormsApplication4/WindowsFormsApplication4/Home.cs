using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;
using System.Globalization;

namespace WindowsFormsApplication4 
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }


        private void btn_L1_Click(object sender, EventArgs e)
        {
            First first = new First();
            first.Show();

            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "../Home.Jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
