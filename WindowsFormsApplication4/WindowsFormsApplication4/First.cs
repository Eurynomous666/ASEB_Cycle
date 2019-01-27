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
    public partial class First : MetroFramework.Forms.MetroForm
    {
        

        public First()
        {
            InitializeComponent();
        }
         
        public DateTime SelectionStart { get; set; }
        string file_name, path;
        string file, getfilename;
        string dateCalc;
        string[] fdata;


        public static double averageSpeed { get; set; }
        public static double maxSpeed { get; set; }
        public static double averageSpeedMiles { get; set; }
        public static double maxSpeedMiles { get; set; }
        public static double averageHeartRate { get; set; }
        public static double maxHeartRate { get; set; }
        public static double minHeartRate { get; set; }
        public static double averagePower { get; set; }
        public static double maxPower { get; set; }
        public static double averageAltitude { get; set; }
        public static double maxAltitude { get; set; }
        public static double averageAltitudeMile { get; set; }
        public static double maxAltitudeMile { get; set; }
        public static double totalDistance { get; set; }
        public static double totalDistanceMiles { get; set; }
        public static string smode { get; set; }

        public static double[] graphHeartRate { get; set; }
        public static double[] graphSpeed { get; set; }
        public static double[] graphCadence { get; set; }
        public static double[] graphAltitude { get; set; }
        public static double[] graphPower { get; set; }

        string fileData, filename;
        string lengthValue, startTimeValue, intervalValue;

        int count = 0;

        

       



        private void graphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (averageSpeed == 0)
                {
                    MessageBox.Show("Please Load data first");
                }
                else
                {
                    Graph g = new Graph();
                    g.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Some errors ocurred \n " + ex);
            }
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (averageSpeed == 0)
                {
                    MessageBox.Show("Please Load data first");
                }
                else
                {
                    Summary sm = new Summary();
                    sm.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Some errors ocurred \n " + ex);
            }
        }

        private void First_Load(object sender, EventArgs e)
        {

        }

        string dateStart = "1/23/2018";
        string dateFinal;

        public void fileReader(String data)
        {
            StreamReader fileReader = new StreamReader(data);

            while (!fileReader.EndOfStream)
            {
                fileData = fileReader.ReadLine();
                if (fileData.Contains("StartTime"))
                {
                    string startTime = fileData;
                    string[] arraStartTime = startTime.Split('=');
                    foreach (String item in arraStartTime)
                    {
                        lblstartdate.Text = "Start time: " + item;
                        startTimeValue = item;
                    }
                }
                if (fileData.Contains("Interval"))
                {
                    string interval = fileData;
                    string[] arrayInterval = interval.Split('=');
                    foreach (String itemInterval in arrayInterval)
                    {
                        interval = itemInterval;
                    }
                }
                if (fileData.Contains("Weight"))
                {
                    string weight = fileData;
                    string[] arrayWeight = weight.Split('=');
                    foreach (String itemWeight in arrayWeight)
                    {
                        //lblWeight.Text = itemWeight;
                    }
                }
                if (fileData.Contains("Length"))
                {
                    string length = fileData;
                    string[] arrayInterval = length.Split('=');
                    foreach (String itemLength in arrayInterval)
                    {
                        lengthValue = itemLength;
                        lbllength.Text = "Length: " + lengthValue;

                    }
                }
                if (fileData.Contains("Interval"))
                {
                    string interval = fileData;
                    string[] arrayInterval = interval.Split('=');
                    foreach (String itemLength in arrayInterval)
                    {
                        intervalValue = itemLength;
                        lblinterval.Text = "Interval: " + itemLength;
                    }
                }
                if (fileData.Contains("Version"))
                {
                    string version = fileData;
                    string[] arrayVersion = version.Split('=');
                    foreach (String itemVersion in arrayVersion)
                    {

                        lblversion.Text = "Version: " + itemVersion.ToString();
                    }
                }
                if (fileData.Contains("Monitor"))
                {
                    string monitor = fileData;
                    string[] arrayMonitor = monitor.Split('=');
                    foreach (String itemMonitor in arrayMonitor)
                    {

                        lblmonitor.Text = "Monitor: " + itemMonitor;
                    }
                }
                if (fileData.Contains("ActiveLimit"))
                {
                    string activeLimit = fileData;
                    string[] arrayActiveLimit = activeLimit.Split('=');
                    foreach (String itemActiveLimit in arrayActiveLimit)
                    {

                    }
                }
                if (fileData.Contains("MaxHR"))
                {
                    string maxHr = fileData;
                    string[] arrayMaxHr = maxHr.Split('=');
                    foreach (String itemMaxHr in arrayMaxHr)
                    {

                        //txtMaxHr.Text = itemMaxHr;
                    }
                }
                if (fileData.Contains("RestHR"))
                {
                    string resetHr = fileData;
                    string[] arrayResetHr = resetHr.Split('=');
                    foreach (String itemResetHr in arrayResetHr)
                    {

                        // txtRestHr.Text = itemResetHr;
                    }
                }
                if (fileData.Contains("StartDelay"))
                {
                    string startDelay = fileData;
                    string[] arrayStartDelay = startDelay.Split('=');
                    foreach (String itemStartDelay in arrayStartDelay)
                    {

                        //txtStartDelay.Text = itemStartDelay;
                    }
                }
                if (fileData.Contains("VO2max"))
                {
                    string VO2max = fileData;
                    string[] arrayVO2max = VO2max.Split('=');
                    foreach (String itemVO2max in arrayVO2max)
                    {

                        //lblVersion.Text = itemVO2max;
                    }
                }
                if (fileData.Contains("Date"))
                {
                    string Date = fileData;
                    string[] arrayDate = Date.Split('=');
                    char[] diff = arrayDate[1].ToCharArray();
                    foreach (String itemDate in arrayDate)
                    {
                        dateFinal = diff[0].ToString() + diff[1].ToString() + diff[2].ToString() + diff[3].ToString() + "/" + diff[4].ToString() + diff[5].ToString() + "/" + diff[6].ToString() + diff[7].ToString();
                        lbldate.Text = "Date: " + dateFinal;
                    }

                }
                if (fileData.Contains("SMode"))
                {
                    string smodeValue = fileData;
                    string[] arraySmode = smodeValue.Split('=');
                    foreach (String itemSmode in arraySmode)
                    {

                        smode = itemSmode;
                        lblsmode.Text = "Smode: " + smode;
                    }
                }
                if (fileData.Contains("SMode"))
                {
                    string smodeValue = fileData;
                    string[] arraySmode = smodeValue.Split('=');
                    foreach (String itemSmode in arraySmode)
                    {
                        smode = itemSmode;
                        lblsmode.Text = "Smode: " + smode;
                    }
                    char[] sm = smode.ToCharArray();
                    if (sm[0] == '1')
                    {
                        lblSpeed.Text = "Speed : ON ";
                    }
                    else lblSpeed.Text = "Speed : OFF ";
                    if (sm[1] == '1')
                    {
                        lblCadence.Text = "Cadence : ON";
                    }
                    else lblCadence.Text = "Cadence : OFF";
                    if (sm[2] == '1')
                    {
                        lblAltitude.Text = "Altitude : ON ";
                    }
                    else lblAltitude.Text = "Altitude : OFF ";
                    if (sm[3] == '1')
                    {
                        lblPower.Text = "Power : ON";
                    }
                    else lblPower.Text = "Power : OFF";
                    if (sm[4] == '1')
                    {
                        lblPowerB.Text = "Power Balance : ON ";
                    }
                    else lblPowerB.Text = "Power Balance : OFF ";
                    if (sm[5] == '1')
                    {
                        lblPowerI.Text = "Power Index : ON";
                    }
                    else lblPowerI.Text = "Power Index : OFF";
                    if (sm[6] == '1')
                    {
                        lblHRdata.Text = "HR data only";
                    }
                    else lblHRdata.Text = "HR + cycling data";
                    if (sm[7] == '1')
                    {
                        lblUS.Text = "Euro (km/h)";
                    }
                    else lblUS.Text = "US (mph)";
                    if (sm[8] == '1')
                    {
                        lblAir.Text = "Air Pressure : ON";
                    }
                    else lblAir.Text = "Air Pressure : OFF";
                }
            }

            List<List<string>> hrData = File.ReadLines(data)
                                       .SkipWhile(line => line != "[HRData]")
                                       .Skip(1)
                                       .Select(line => line.Split().ToList())
                                       .ToList();
            count = hrData.Count();

            double speedTotal = 0;
            double heartRateTotal = 0;
            double powerTotal = 0;
            double altitudeTotal = 0;
            double[] arraySpeed = new double[500000];
            double[] arrayHeartRate = new double[500000];
            double[] arrayPower = new double[500000];
            double[] arrayAltitude = new double[500000];
            double[] arrayCadence = new double[500000];
            string[] arrayLength = new string[500000];
            string[] arrayStartTime = new string[500000];
            double intervalResult = 0;

            // time interval 
            arrayStartTime = startTimeValue.Split(':');
            string hour = arrayStartTime[0];
            string minute = arrayStartTime[1];
            double sec = double.Parse(arrayStartTime[2]);
            double min = double.Parse(arrayStartTime[0]);
            double hrs = double.Parse(arrayStartTime[1]);
            double intervalTwo = 0;
            for (int i = 0; i < count; i++)
            {

                double interval = double.Parse(intervalValue);

                //sec = sec + interval ; 

                intervalTwo = intervalTwo + interval;


                DataTrue.Rows.Add();
                // dataGridView1.Rows[i].Cells[0].Value = dateFinal+"   |   "+ hour + ":" + minute + ":" + sec;
                DateTime timer = DateTime.ParseExact(startTimeValue, "HH:mm:ss.FFF", CultureInfo.InvariantCulture);
                DataTrue.Rows[i].Cells[0].Value = dateFinal + " | " + timer.AddSeconds(intervalTwo).TimeOfDay;

                char[] smodeData = smode.ToCharArray();
                char speed = smodeData[0];
                char cadence = smodeData[1];
                char altitude = smodeData[2];
                char power = smodeData[3];
                char powerLRBalance = smodeData[4];
                char PowerPIndex = smodeData[5];
                char hrcc = smodeData[6];
                char usEuroUnit = smodeData[7];
                char airPressure = smodeData[8];

                if (hrcc == '1')
                {
                    DataTrue.Rows[i].Cells[1].Value = hrData[i][0];
                }
                else if (hrcc == '0')
                {
                    DataTrue.Rows[i].Cells[1].Value = 0;
                }
                if (speed == '1')
                {
                    DataTrue.Rows[i].Cells[2].Value = hrData[i][1];
                }
                else if (speed == '0')
                {
                    DataTrue.Rows[i].Cells[2].Value = 0;
                }
                if (cadence == '1')
                {
                    DataTrue.Rows[i].Cells[3].Value = hrData[i][2];
                }
                else if (cadence == '0')
                {
                    DataTrue.Rows[i].Cells[3].Value = 0;
                }

                if (altitude == '1')
                {
                    DataTrue.Rows[i].Cells[4].Value = hrData[i][3];
                }
                else if (altitude == '0')
                {
                    DataTrue.Rows[i].Cells[4].Value = 0;
                }
                if (power == '1')
                {
                    DataTrue.Rows[i].Cells[5].Value = hrData[i][4];
                    // calculation of moving average 
                    int value = hrData[i][4].Count();
                    for (int x = 0; x < value; x++)
                    {
                        double movingAverage30 = 0;
                        for (int j = 0; j < 30; j++)
                        {
                            int index = x + j;
                            index %= value;
                            movingAverage30 += Convert.ToDouble(hrData[i][index]);

                        }
                        movingAverage30 /= 30;

                        //MessageBox.Show(movingAverage30.ToString());
                        // dgvMovingAverage.Rows.Add(movingAverage30);

                        // normalized power calculation 

                        TimeSpan time = timer.AddSeconds(intervalTwo).TimeOfDay;
                        double timeParse = time.Hours * 60 + time.Minutes + time.Seconds / 60;
                        double powerValue = Math.Pow(movingAverage30, 4);
                        double np = Math.Sqrt(Math.Sqrt(timeParse * powerValue));
                        // dataGridView1.Rows[i].Cells[9].Value = np;


                    }
                }

                else if (power == '0')
                {
                    DataTrue.Rows[i].Cells[5].Value = 0;
                }
                if (powerLRBalance == '1')
                {
                    DataTrue.Rows[i].Cells[6].Value = hrData[i][5];
                    double value = Convert.ToDouble(hrData[i][5]); // calculation of PI and LRB
                    double pi = value / 256;
                    double lrb = value % 256;
                    double rb = 100 - lrb;
                    DataTrue.Rows[i].Cells[7].Value = Math.Round(pi, 0);
                    DataTrue.Rows[i].Cells[8].Value = "L" + lrb + "- R" + rb;
                }
                else if (powerLRBalance == '0')
                {
                    DataTrue.Rows[i].Cells[6].Value = 0;





                }
                if (speed == '1')
                {

                    // cadence 

                    arrayCadence[i] = int.Parse(hrData[i][2]);


                    // average speed 

                    speedTotal = speedTotal + int.Parse(hrData[i][1]);
                    averageSpeed = (speedTotal / count) * 0.1;
                    averageSpeedMiles = averageSpeed / 1.6;



                    // maximum speed  

                    arraySpeed[i] = int.Parse(hrData[i][1]);
                }
                else
                {
                    averageSpeed = 0;
                    averageSpeedMiles = 0;
                    arraySpeed[i] = 0;

                }

                if (hrcc == '1')
                {
                    // average heart rate 
                    heartRateTotal = heartRateTotal + int.Parse(hrData[i][0]);
                    averageHeartRate = heartRateTotal / count;
                    // maximum heart rate
                    arrayHeartRate[i] = int.Parse(hrData[i][0]);
                }
                else
                {
                    averageHeartRate = 0;
                    arrayHeartRate[i] = 0;
                }
                if (power == '1')
                {
                    // average power 
                    powerTotal = powerTotal + int.Parse(hrData[i][4]);
                    averagePower = powerTotal / count;

                    // maximum power 
                    arrayPower[i] = int.Parse(hrData[i][4]);
                }
                else
                {
                    averagePower = 0;
                    arrayPower[i] = 0;
                }
                if (altitude == '1')
                {
                    // average altitude 
                    altitudeTotal = altitudeTotal + int.Parse(hrData[i][3]);
                    averageAltitude = altitudeTotal / count;
                    averageAltitudeMile = averageAltitude / 0.3048;
                    // maximum altitude 
                    arrayAltitude[i] = int.Parse(hrData[i][3]);
                }
                else
                {
                    averageAltitude = 0;
                    averageAltitudeMile = 0;
                    arrayAltitude[i] = 0;
                }
            }
            maxSpeed = arraySpeed.Max() * 0.1;
            maxSpeedMiles = (maxSpeed) / 1.6;

            //max heart rate 
            maxHeartRate = arrayHeartRate.Max();


            // min heart rate 
            // minHeartRate = arrayHeartRate.Min();
            minHeartRate = double.MaxValue;


            foreach (double valueHR in arrayHeartRate)
            {
                double num = valueHR;
                if (num < minHeartRate)
                    minHeartRate = num;
            }
            // max power 
            maxPower = arrayPower.Max();
            // max altitude 
            maxAltitude = arrayAltitude.Max();
            maxAltitudeMile = maxAltitude / 0.3048;

            // total distance covered 
            if (arrayLength != null)
            {
                arrayLength = lengthValue.Split(':');
                double hourDis = double.Parse(arrayLength[0]) * 3600;
                double minDis = double.Parse(arrayLength[1]) * 60;
                double secDis = double.Parse(arrayLength[2]);

                double length = hourDis + minDis + secDis;
                double lengthFinal = length / 3600;
                double totalDistanceProcess = averageSpeed * lengthFinal;
                double totalDistanceProcessMiles = (totalDistanceProcess) / 1.6;
                totalDistance = Math.Round(totalDistanceProcess, 2);
                totalDistanceMiles = Math.Round(totalDistanceProcessMiles, 2); ;

            }
            // graph data fetch to global 
            graphHeartRate = arrayHeartRate;
            graphSpeed = arraySpeed;
            graphPower = arrayPower;
            graphAltitude = arrayAltitude;
            graphCadence = arrayCadence;

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
       
            



            foreach (string itemData in fdata)
            {



                string value = itemData;


                StreamReader fileReaderFolder = new StreamReader(value);


                while (!fileReaderFolder.EndOfStream)
                {
                    fileData = fileReaderFolder.ReadLine();
                    if (fileData.Contains("Date"))
                    {
                        string startTime = fileData;
                        string arraStartTime = startTime.Split('=').Last();
                        string one = "";
                        //var date = "11252017";
                        var date = DateTime.ParseExact(arraStartTime, "yyyyMMdd", CultureInfo.InvariantCulture);

                        if (date == DateTime.Parse(dateCalc))
                        {
                            

                            path = itemData;

                           
                            //MessageBox.Show(one); 
                        }

                        //cldFolderView.AddBoldedDate(date);
                        //cldFolderView.UpdateBoldedDates();

                        //cldFolderView.SelectionStart = DateTime.Parse(startValue);
                    }
                }
            }
        }




        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            try
            {
                open.Filter = "hrm|*.hrm|All|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    filename = open.FileName; // name of the browsed file 
                    string location = open.SafeFileName;  // location of the browsed file
                    string fileData, fileDataTwo;
                    int count = 0;
                    fileReader(filename);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some errors ocurred \n " + ex);
            }
        }
            }
        }


    

    






