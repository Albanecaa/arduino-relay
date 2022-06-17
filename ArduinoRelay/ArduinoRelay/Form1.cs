using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace ArduinoRelay
{
    public partial class Form1 : Form
    {
        SerialPort myPort;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            myPort = new SerialPort();
            myPort.PortName = "COM4";
            myPort.BaudRate = 9600;
            myPort.Open();
        }
        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("1");
            label6.Hide();
            label7.Show();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("0");
            label7.Hide();
            label6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("3");
            label9.Hide();
            label8.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("2");
            label8.Hide();
            label9.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("4");
            label11.Hide();
            label10.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("5");
            label10.Hide();
            label11.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("7");
            label13.Hide();
            label12.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("6");
            label12.Hide();
            label13.Show();
        }
    }
}
