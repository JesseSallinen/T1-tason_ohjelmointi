<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Paivakirja
{
    public partial class DiaryForm : Form
    {
        public DiaryForm()
        {
            InitializeComponent();
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = File.ReadAllText(@"C:\\Users\\Tarja\\source\\repos\\T1-tason_ohjelmointi\\Paivakirja\\paivakirja.txt");
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter txt = new StreamWriter("C:\\Users\\Tarja\\source\\repos\\T1-tason_ohjelmointi\\Paivakirja\\paivakirja.txt");
            txt.Write(teksti);
            txt.Close();
            Application.Exit();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Paivakirja
{
    public partial class DiaryForm : Form
    {
        public DiaryForm()
        {
            InitializeComponent();
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = File.ReadAllText(@"C:\\Users\\Tarja\\source\\repos\\T1-tason_ohjelmointi\\Paivakirja\\paivakirja.txt");
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter txt = new StreamWriter("C:\\Users\\Tarja\\source\\repos\\T1-tason_ohjelmointi\\Paivakirja\\paivakirja.txt");
            txt.Write(teksti);
            txt.Close();
            Application.Exit();
        }
    }
}
>>>>>>> cf4a7331201bba4497bca652cdcc74bf07e966b8
