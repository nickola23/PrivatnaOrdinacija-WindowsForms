using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivatnaOrdinacija_WindowsForms
{
    public partial class Form1 : Form
    {
        private Button[] dugmiciMeni;
        private Button aktivnoDugme;
        private Form aktivnaForma;
        public Form1()
        {
            InitializeComponent();
            DeklarisiDugmiciMeni();
            aktivnoDugme = buttonPocetna;
            aktivnoDugme.BackColor = Color.FromArgb(60, 78, 125);
            otvoriFormu(new Forme.Pocetna());

        }
        public void DeklarisiDugmiciMeni()
        {
            dugmiciMeni = new Button[] { buttonPocetna, buttonDodaj, buttonSpisak, buttonPretrazi, buttonSpisak, buttonIzvestaj, buttonDodajPosetu, buttonDodajDoktora, buttonIzadji };
        }
        public void aktivirajDugme(object sender)
        {
            if(sender != null && aktivnoDugme != (Button)sender)
            {
                aktivnoDugme = (Button)sender;
                aktivnoDugme.BackColor = Color.FromArgb(60, 78, 125);

                foreach (Button dugme in dugmiciMeni)
                {
                    if(dugme != aktivnoDugme)
                    {
                        dugme.BackColor = Color.FromArgb(41, 53, 86);
                    }
                }

                naslov.Text = aktivnoDugme.Text;
            }

        }
        public void otvoriFormu(Form novaForma)
        {
            if(aktivnaForma != null)
            {
                aktivnaForma.Close();
            }
            aktivnaForma = novaForma;
            novaForma.TopLevel = false;
            novaForma.FormBorderStyle = FormBorderStyle.None;
            novaForma.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(novaForma);
            this.panelMain.Tag = novaForma;
            novaForma.BringToFront();
            novaForma.Show();

        }
        private void buttonPocetna_Click(object sender, EventArgs e)
        {
            aktivirajDugme(sender);
            otvoriFormu(new Forme.Pocetna());
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            aktivirajDugme(sender);
            otvoriFormu(new Forme.DodajPacijenta());
        }

        private void buttonSpisak_Click(object sender, EventArgs e)
        {
            aktivirajDugme(sender);
            otvoriFormu(new Forme.SpisakPacijenata());
        }

        private void buttonPretrazi_Click(object sender, EventArgs e)
        {
            aktivirajDugme(sender);
            otvoriFormu(new Forme.PretraziPacijenta());
        }

        private void buttonIzvestaj_Click(object sender, EventArgs e)
        {
            aktivirajDugme(sender);
            otvoriFormu(new Forme.Izvestaji());
        }

        public void buttonDodajPosetu_Click(object sender, EventArgs e)
        {
            aktivirajDugme(sender);
            otvoriFormu(new Forme.DodajPosetu());
        }
        private void buttonDodajDoktora_Click(object sender, EventArgs e)
        {
            aktivirajDugme(sender);
            otvoriFormu(new Forme.DodajDoktora());
        }

        private void buttonIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult opcija = MessageBox.Show("Da li  želite da izađete?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcija == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
