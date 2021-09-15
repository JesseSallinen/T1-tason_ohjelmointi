using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sekuntikello
{
    public partial class Form1 : Form
    {
        private Stopwatch Sekuntikello;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sekuntikello.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", Sekuntikello.Elapsed);
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            Sekuntikello.Stop();
        }

        private void ResetBT_Click(object sender, EventArgs e)
        {
            Sekuntikello.Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sekuntikello = new Stopwatch();
        }
    }
}
