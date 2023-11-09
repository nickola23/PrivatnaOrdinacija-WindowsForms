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
    public partial class DodajPosetu : Form
    {
        public DodajPosetu()
        {
            InitializeComponent();
            deklarisiLekare();
        }
        public void deklarisiLekare()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("Doktori.txt");
                string linija = "";
                int brojDoktora = 0, i = 0;

                while (sr.ReadLine() != null)
                {
                    brojDoktora++;
                }

                Doktor<string>[] doktori = new Doktor<string>[brojDoktora];
                sr = new StreamReader("Doktori.txt");
                linija = sr.ReadLine();

                while (linija != null)
                {
                    doktori[i] = new Doktor<string>();
                    doktori[i].citaj(linija);
                    comboBoxLekar.Items.Add(doktori[i].Ime + " " + doktori[i].Prezime);
                    linija = sr.ReadLine();
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska");
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
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
                string izabraniLekar;
                if (comboBoxLekar.SelectedItem == null)
                {
                    throw new Exception("Morate izabrati Lekara");
                }
                else
                {
                    izabraniLekar = comboBoxLekar.SelectedItem.ToString();
                }

                Poseta<string> poseta = new Poseta<string>(ime, prezime, BrojKnjizice, DatumPosete, DatumSledecePosete, izabraniLekar, RazlogPosete, Beleske, PropisaniLekovi);
                poseta.upis(sw);

                textBoxIme.Text = string.Empty;
                textBoxPrezime.Text = string.Empty;
                textBoxBrojKnjizice.Text = string.Empty;
                textBoxDatumPosete.Text = string.Empty;
                textBoxDatumSledecePosete.Text = string.Empty;
                textBoxBrojKnjizice.Text = string.Empty;
                textBoxRazlogPosete.Text = string.Empty;
                textBoxBeleske.Text = string.Empty;
                textBoxPropisaniLekovi.Text = string.Empty;
                comboBoxLekar.SelectedIndex = -1;

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
            comboBoxLekar.SelectedIndex = -1;
        }
    }
}
