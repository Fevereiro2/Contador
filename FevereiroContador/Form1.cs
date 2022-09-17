using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace FevereiroContador
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = stopwatch.Elapsed.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
        }
    }
}