using System;
using System.Collections;
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
    public partial class DodajPacijenta : Form
    {
        public DodajPacijenta()
        {
            InitializeComponent();
            deklarisiLekare();
        }
        public void deklarisiLekare()
        {
            StreamReader sr = null;
            try
            {
                Stack nizDoktora = new Stack();
                sr = new StreamReader("Doktori.txt");
                string linija = "";
                int brojDoktora = 0, i = 0;

                while (sr.ReadLine() != null)
                {
                    brojDoktora++;
                }
                sr.Close();

                Doktor<string>[] doktori = new Doktor<string>[brojDoktora];
                sr = new StreamReader("Doktori.txt");
                linija = sr.ReadLine();

                while (linija != null)
                {
                    doktori[i] = new Doktor<string>();
                    doktori[i].citaj(linija);
                    nizDoktora.Push(doktori[i].Ime + " " + doktori[i].Prezime);
                    linija = sr.ReadLine();
                    i++;
                }
                sr.Close();

                foreach(string doktor in nizDoktora)
                {
                    comboBoxLekar.Items.Add(doktor);
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

        private void buttonDodajPacijenta_Click(object sender, EventArgs e)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter("Pacijenti.txt", true);

                string ime = textBoxIme.Text;
                string prezime = textBoxPrezime.Text;
                string datumRodjenja = textBoxDatumRodjenja.Text;
                string jmbg = textBoxJMBG.Text;
                string telefon = textBoxTelefon.Text;
                string brojKnjizice = textBoxBrojKnjizice.Text;
                string adresa = textBoxAdresa.Text;
                string pol;
                if (comboBoxPol.SelectedItem == null)
                {
                    throw new Exception("Morate izabrati Pol");
                }
                else
                {
                    pol = comboBoxPol.SelectedItem.ToString();
                }
                string izabraniLekar;
                if (comboBoxLekar.SelectedItem == null)
                {
                    throw new Exception("Morate izabrati Lekara");
                }
                else
                {
                    izabraniLekar = comboBoxLekar.SelectedItem.ToString();
                }
                string alergije = textBoxAlergije.Text;
                string istorijaBolesti = textBoxIstorijaBolesti.Text;

                Pacijent<string> pacijent = new Pacijent<string>(ime, prezime, datumRodjenja, jmbg, telefon, brojKnjizice, adresa, pol, izabraniLekar, alergije, istorijaBolesti);
                pacijent.upis(sw);

                textBoxIme.Text = string.Empty;
                textBoxPrezime.Text = string.Empty;
                textBoxDatumRodjenja.Text = string.Empty;
                textBoxJMBG.Text = string.Empty;
                textBoxTelefon.Text = string.Empty;
                textBoxBrojKnjizice.Text = string.Empty;
                textBoxAdresa.Text = string.Empty;
                comboBoxPol.SelectedIndex = -1;
                comboBoxLekar.SelectedIndex = -1;
                textBoxAlergije.Text = string.Empty;
                textBoxIstorijaBolesti.Text = string.Empty;

                MessageBox.Show("Uspešno ste dodali Pacijenta " + pacijent.Ime + " " + pacijent.Prezime, "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
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
            textBoxDatumRodjenja.Text = string.Empty;
            textBoxJMBG.Text = string.Empty;
            textBoxTelefon.Text = string.Empty;
            textBoxBrojKnjizice.Text = string.Empty;
            textBoxAdresa.Text = string.Empty;
            comboBoxPol.SelectedIndex = -1;
            comboBoxLekar.SelectedIndex = -1;
            textBoxAlergije.Text = string.Empty;
            textBoxIstorijaBolesti.Text = string.Empty;
        }
    }
}
