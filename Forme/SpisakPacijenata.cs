using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivatnaOrdinacija_WindowsForms.Forme
{
    public partial class SpisakPacijenata : Form
    {
        Pacijent<string>[] pacijenti;
        public SpisakPacijenata()
        {
            InitializeComponent();
            deklarisiSpisakPacijenata();
            ispisiPacijente();
        }
        public void deklarisiSpisakPacijenata()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("Pacijenti.txt");
                string linija = "";
                int brojPacijenata = 0, i = 0;

                while (sr.ReadLine() != null)
                {
                    brojPacijenata++;
                }

                pacijenti = new Pacijent<string>[brojPacijenata];
                sr = new StreamReader("Pacijenti.txt");
                linija = sr.ReadLine();

                while (linija != null)
                {
                    pacijenti[i] = new Pacijent<string>();
                    pacijenti[i].citaj(linija);
                    linija = sr.ReadLine();
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
        public void ispisiPacijente()
        {
            dataGridViewSpisakPacijenata.DataSource = pacijenti;

            dataGridViewSpisakPacijenata.Columns["Ime"].DisplayIndex = 0;
            dataGridViewSpisakPacijenata.Columns["Prezime"].DisplayIndex = 1;
            dataGridViewSpisakPacijenata.Columns["DatumRodjenja"].DisplayIndex = 2;
            dataGridViewSpisakPacijenata.Columns["Jmbg"].DisplayIndex = 3;
            dataGridViewSpisakPacijenata.Columns["Telefon"].DisplayIndex = 4;
            dataGridViewSpisakPacijenata.Columns["BrojKnjizice"].DisplayIndex = 5;
            dataGridViewSpisakPacijenata.Columns["Adresa"].DisplayIndex = 6;
            dataGridViewSpisakPacijenata.Columns["Pol"].DisplayIndex = 7;
            dataGridViewSpisakPacijenata.Columns["IzabraniLekar"].DisplayIndex = 8;
            dataGridViewSpisakPacijenata.Columns["Alergije"].DisplayIndex = 9;
            dataGridViewSpisakPacijenata.Columns["IstorijaBolesti"].DisplayIndex = 10;
        }
    }
}
