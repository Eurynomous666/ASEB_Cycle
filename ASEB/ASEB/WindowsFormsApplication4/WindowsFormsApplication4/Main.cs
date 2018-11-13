using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication4
{
    public partial class Main : Form
    {
        public string filepath { get; set; }
        public Main()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            bool flag = this.openFile.ShowDialog() != DialogResult.Cancel;
            if (flag)
            {
                OpenFileDialog fd = new OpenFileDialog();
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    string ext = Path.GetExtension(fd.FileName);
                    if (ext == ".hrm")
                    {
                        filepath = fd.FileName;
                        btnLoad.Visible = true;
                        //lblMessage.Text = "";
                    }
                    else
                    {
                        RText1.Text = "Select only HRM file";
                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filePath = filepath;
            if (File.Exists(filePath))
            {
                processFile(filePath);
            }
            else
            {
                RText1.Text = "File not found.";
            }
            btnLoad.Visible = false;
        }
        public void processFile(string filePath)
        {
            // string oneline;
            //int lineNo = 1;
            try
            {
                /* // Reading all the text using ReadAllText Method
                string fileContent = File.ReadAllText(filePath);
                txtDisplay.Text = fileContent;
                */


                //Reading all the text and display in textbox by using ReadAllLines
                string[] filelines = File.ReadAllLines(filePath);
                string data = "";
                int rows = 0;
                int totalRows = 0;
                int y = 0; int z = 0;

                dataView.ColumnCount = 6;
                dataView.Columns[0].Name = "Heart Rates";
                dataView.Columns[1].Name = "Speed";
                dataView.Columns[2].Name = "Cadence";
                dataView.Columns[3].Name = "Altitude";
                dataView.Columns[4].Name = "Power";
                dataView.Columns[5].Name = "Power Balance and Pedaling Index";



                foreach (string line in filelines)
                {
                    totalRows++;
                    if (line.Equals("[HRData]"))
                    {
                        rows = y;
                    }
                    y++;
                }

                int s = totalRows - rows;
                string[] arrayData = new string[s];

                string heart = "";
                string speed = "";
                string cadence = "";
                string altitude = "";
                string power = "";
                string pbpi = "";
                if (rows != 0)
                {
                    foreach (string line in filelines)
                    {
                        if (rows < z)
                        {
                            data += line + "\r\n";
                            string[] words = line.Split('\t');
                            for (int x = 0; x < words.Length; x++)
                            {
                                if (x == 0) heart = words[x];
                                else if (x == 1) speed = words[x];
                                else if (x == 2) cadence = words[x];
                                else if (x == 3) altitude = words[x];
                                else if (x == 4) power = words[x];
                                else pbpi = words[x];
                            }
                            string[] row_val = new string[] { heart, speed, cadence, altitude, power, pbpi };
                            dataView.Rows.Add(row_val);
                            // System.Console.WriteLine(words[x]);
                        }
                        else z++;
                    }
                }
                RText1.Text = data;


                /*
                StreamReader sr = new StreamReader(filePath);
                string data = "";
                while ((oneline = sr.ReadLine()) != null)
                {
                    string[] words = oneline.Split(' ');
                    for(int x = 0; x < words.Length; x++)
                    {
                        data += words[x] + "\r\n";
                    }
                }
                txtDisplay.Text = data;
                */
            }
            catch { RText1.Text = "Exception Raised"; }
        }
    }
    }






