using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace CRUD_tehtava
{
    public partial class Form1 : Form
    {
        OPISKELIJA opiskelija = new OPISKELIJA();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            idTB.Text = "";
            EtunimiTB.Text = "";
            SukunimiTB.Text = "";
            PuhelinTB.Text = "";
            PostiTB.Text = "";
            NumeroTB.Text = "";
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            String enimi = EtunimiTB.Text;
            String snimi = SukunimiTB.Text;
            String puhelin = PuhelinTB.Text;
            String email = PostiTB.Text;
            int oNro = Int32.Parse(NumeroTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.lisaaOpiskelija(enimi, snimi, puhelin, email, oNro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void PaivitaBT_Click(object sender, EventArgs e)
        {
            String enimi = EtunimiTB.Text;
            String snimi = SukunimiTB.Text;
            String puhelin = PuhelinTB.Text;
            String email = PostiTB.Text;
            int oNro = Int32.Parse(NumeroTB.Text);
            int oid = Int32.Parse(idTB.Text);

            if (oid.Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - ID, Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.muokkaaOpiskelijaa(oid, enimi, snimi, puhelin, email, oNro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Opiskelija päivitetty onnistuneesti", " Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opiskelijaa ei pystytty päivittämään", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void TietotauluDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idTB.Text = TietotauluDG.CurrentRow.Cells[0].Value.ToString();
            EtunimiTB.Text = TietotauluDG.CurrentRow.Cells[1].Value.ToString();
            SukunimiTB.Text = TietotauluDG.CurrentRow.Cells[2].Value.ToString();
            PuhelinTB.Text = TietotauluDG.CurrentRow.Cells[3].Value.ToString();
            PostiTB.Text = TietotauluDG.CurrentRow.Cells[4].Value.ToString();
            NumeroTB.Text = TietotauluDG.CurrentRow.Cells[5].Value.ToString();
        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            int ktunnus = Int32.Parse(idTB.Text);
            if (opiskelija.poistaOpiskelija(ktunnus))
            {
                TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opiskelijaa ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TyhjennaBT.PerformClick();
        }
    }
}
