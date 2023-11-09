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
    public partial class PretraziPacijenta : Form
    {
        Pacijent<string>[] pacijenti;
        Pacijent<string>[] trazeniPacijenti;
        public PretraziPacijenta()
        {
            InitializeComponent();
        }
        public void ispisiPacijente()
        {
            dataGridViewPretrazi.DataSource = trazeniPacijenti;

            dataGridViewPretrazi.Columns["Ime"].DisplayIndex = 0;
            dataGridViewPretrazi.Columns["Prezime"].DisplayIndex = 1;
            dataGridViewPretrazi.Columns["DatumRodjenja"].DisplayIndex = 2;
            dataGridViewPretrazi.Columns["Jmbg"].DisplayIndex = 3;
            dataGridViewPretrazi.Columns["Telefon"].DisplayIndex = 4;
            dataGridViewPretrazi.Columns["BrojKnjizice"].DisplayIndex = 5;
            dataGridViewPretrazi.Columns["Adresa"].DisplayIndex = 6;
            dataGridViewPretrazi.Columns["Pol"].DisplayIndex = 7;
            dataGridViewPretrazi.Columns["IzabraniLekar"].DisplayIndex = 8;
            dataGridViewPretrazi.Columns["Alergije"].DisplayIndex = 9;
            dataGridViewPretrazi.Columns["IstorijaBolesti"].DisplayIndex = 10;
        }
        private void buttonPretrazi_Click(object sender, EventArgs e)
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
                    bool pacijentPostoji = false;
                    pacijenti[i].citaj(linija);
                    if (textBoxIme.Text != "" && pacijenti[i].Ime.ToLower().Contains(textBoxIme.Text.ToLower()))
                    {
                        pacijentPostoji = true;
                    }
                    else if (textBoxPrezime.Text != "" && pacijenti[i].Prezime.ToLower().Contains(textBoxPrezime.Text.ToLower()))
                    {
                        pacijentPostoji = true;
                    }
                    else if(textBoxJmbg.Text != "" && pacijenti[i].Jmbg.Contains(textBoxJmbg.Text))
                    {
                        pacijentPostoji = true;
                    }
                    else if(textBoxBrojKnjizice.Text != "" && pacijenti[i].BrojKnjizice.Contains(textBoxBrojKnjizice.Text))
                    {
                        pacijentPostoji = true;
                    }
                    if (pacijentPostoji) i++;
                    linija = sr.ReadLine();
                }
                
                if(i != 0)
                {
                    trazeniPacijenti = new Pacijent<string>[i];
                    for (int j = 0; j < i; j++)
                    {
                        trazeniPacijenti[j] = pacijenti[j];
                    }
                    ispisiPacijente();
                }
                else
                {
                    throw new Exception("Trazeni Pacijent ne postoji");
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
    }
}
