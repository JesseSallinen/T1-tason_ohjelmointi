using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lukujenjarjestys
{
    public partial class Form1 : Form
    {
        List<int> jono = new list<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void UusilukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (UusilukuTB.Text == "-999")
                {
                    VastausLB.Text = "";
                     int[] jonot = jono.ToArray();
                    Array.Sort(jonot);
                    foreach
                        (var item in jonot)
                    {
                        VastausLB.Text += item + " ";
                    }
                    VastausLB.Visible = true;
                }
                else
                {
                    jono.Add(Int32.Parse(UusilukuTB.Text));
                    UusilukuTB.Text = "";
                }
            }
            if
                (e.KeyChar == (char)Keys.Escape)
            {
                TyhjaaLomake();
            }
        }
        private void
            TyhjaaLomake()
        {
            UusilukuTB.Text = "";
        }

        private class list<T> : List<int>
        {
        }
    }
}
