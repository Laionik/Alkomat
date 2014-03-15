using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;

namespace Alkomat
{
    public partial class Form1 : Form
    {
        string port;
        string baudrate;
        string path;
        string value;
        string date;
        string time;
        ArrayList list_value;
        SerialPort Arduino;
        string[] portsName;

        public Form1()
        {
            InitializeComponent();
            button_usb_connect.Enabled = true;
            button_usb_disconnect.Enabled = false;
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AlkomatPC\\" + "data.txt";

            DirectoryInfo dInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AlkomatPC");
            if (!dInfo.Exists)
            {
                dInfo.Create();
            }
            list_value = new ArrayList();
        }

        private void button_usb_connect_Click(object sender, EventArgs e)
        {
            try
            {
                button_usb_connect.Enabled = false;
                button_usb_disconnect.Enabled = true;
                port = port_number_box.Text;
                baudrate = baudrate_box.Text;
                logger.AppendText("Wczytano port " + port + " oraz baudrate " + baudrate + "\n");
                Arduino = new SerialPort();
                Arduino.PortName = port;
                Arduino.BaudRate = int.Parse(baudrate);
                Arduino.Open();
                logger.AppendText("\nOtwarto port " + port + "\n");
                value = Arduino.ReadLine();
                arduino_value.Text = value + " ‰";
                date = DateTime.Now.ToString("dd/MM/yyyy");
                time = DateTime.Now.ToString("HH:mm:ss");
                File.AppendAllText(path, date + " " + time + " " + value + "\n");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void read_ports_Click(object sender, EventArgs e)
        {
            try
            {
                portsName = SerialPort.GetPortNames();
                logger.AppendText("Dostepne porty:\n");
                port_number_box.Text = portsName[0];
                foreach (string x in portsName)
                {
                    port_number_box.Items.Add(x.ToString());
                    logger.AppendText(x + "\n");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Nic nie podlaczone");
            }
        }

        private void button_usb_disconnect_Click(object sender, EventArgs e)
        {
            Arduino.Close();
            logger.AppendText("Zamknieto port " + Arduino.PortName);
            button_usb_connect.Enabled = true;
            button_usb_disconnect.Enabled = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Arduino.IsOpen)
                Arduino.Close();
        }

        private void button_get_data_from_file_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader dataReader = new StreamReader(path);
                string file_data = "";
                while (file_data != null)
                {
                    file_data = dataReader.ReadLine();
                    if (file_data != null)
                        list_value.Add(file_data);
                }
                dataReader.Close();
                logger.AppendText("Wczytano dane:\n");
                foreach (string sOutput in list_value)
                {
                    logger.AppendText(sOutput + "\n");
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void button_draw_graph_Click(object sender, EventArgs e)
        {
            string[] help;
            string date, value;
            int i = 1;

            chart.ChartAreas.Add("draw");
            chart.ChartAreas["draw"].AxisX.Interval = 1;
            chart.ChartAreas["draw"].AxisX.MajorGrid.LineColor = Color.White;
            chart.Series[0].ChartType = SeriesChartType.Point;
            chart.Series[0].Name = "Stezenie alkoholu";
            chart.Series[0].Color = Color.Blue;
            chart.Series[0].BorderWidth = 2;
         
            foreach (string x in list_value)
            {
                help = x.Split(' ');
                date = help[0] + "\n" + help[1];
                value = help[2];
                chart.Series[0].Points.AddXY(i, value);
                chart.Series[0].Points[i - 1].AxisLabel = date;
                i++;
            }
        }

        private void button_erase_graph_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var series in chart.Series)
                {
                    series.Points.Clear();
                }
                chart.ChartAreas.Remove(chart.ChartAreas.FindByName("draw"));
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
