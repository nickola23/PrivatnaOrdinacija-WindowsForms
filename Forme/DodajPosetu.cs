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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrivatnaOrdinacija_WindowsForms.Forme
{
    public partial class DodajPosetu : Form
    {
        public DodajPosetu()
        {
            InitializeComponent();
        }
        
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter("Posete.txt", true);

                string ime = textBoxIme.Text;
                string prezime = textBoxPrezime.Text;
                string BrojKnjizice = textBoxBrojKnjizice.Text;
                string DatumPosete = textBoxDatumPosete.Text;
                string DatumSledecePosete = textBoxDatumSledecePosete.Text;
                string RazlogPosete = textBoxRazlogPosete.Text;
                string Beleske = textBoxBeleske.Text;
                string PropisaniLekovi = textBoxPropisaniLekovi.Text;
                string izabraniLekar = textBoxIzabraniLekar.Text;

                Poseta<string> poseta = new Poseta<string>(ime, prezime, BrojKnjizice, DatumPosete, DatumSledecePosete, izabraniLekar, RazlogPosete, Beleske, PropisaniLekovi);
                poseta.upis(sw);

                textBoxIme.Text = string.Empty;
                textBoxPrezime.Text = string.Empty;
                textBoxDatumPosete.Text = string.Empty;
                textBoxDatumSledecePosete.Text = string.Empty;
                textBoxBrojKnjizice.Text = string.Empty;
                textBoxRazlogPosete.Text = string.Empty;
                textBoxBeleske.Text = string.Empty;
                textBoxPropisaniLekovi.Text = string.Empty;
                textBoxIzabraniLekar.Text = string.Empty;
                textBoxJmbg.Text = string.Empty;

                MessageBox.Show("Uspešno ste dodali Posetu za Pacijenta " + poseta.Ime + " " + poseta.Prezime, "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }

        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            textBoxIme.Text = string.Empty;
            textBoxPrezime.Text = string.Empty;
            textBoxBrojKnjizice.Text = string.Empty;
            textBoxDatumPosete.Text = string.Empty;
            textBoxDatumSledecePosete.Text = string.Empty;
            textBoxRazlogPosete.Text = string.Empty;
            textBoxBeleske.Text = string.Empty;
            textBoxPropisaniLekovi.Text = string.Empty;
            textBoxIzabraniLekar.Text = string.Empty;
            textBoxJmbg.Text = string.Empty;
        }

        private void textBoxBrojKnjizice_TextChanged(object sender, EventArgs e)
        {
            if(textBoxBrojKnjizice.Text.Length == 11)
            {
                Pacijent<string>[] pacijenti;
                Pacijent<string> trazeniPacijent = new Pacijent<string>();
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
                    sr.Close();

                    pacijenti = new Pacijent<string>[brojPacijenata];
                    sr = new StreamReader("Pacijenti.txt");
                    linija = sr.ReadLine();

                    while (linija != null && i == 0)
                    {
                        pacijenti[i] = new Pacijent<string>();
                        pacijenti[i].citaj(linija);
                        if (textBoxBrojKnjizice.Text != "" && pacijenti[i].BrojKnjizice.Contains(textBoxBrojKnjizice.Text))
                        {
                            trazeniPacijent = pacijenti[i];
                            i++;
                        }
                        linija = sr.ReadLine();
                    }
                    sr.Close();

                    if (i != 0)
                    {
                        textBoxIme.Text = trazeniPacijent.Ime;
                        textBoxPrezime.Text = trazeniPacijent.Prezime;
                        textBoxIzabraniLekar.Text = trazeniPacijent.IzabraniLekar;
                        textBoxJmbg.Text = trazeniPacijent.Jmbg;
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
}
