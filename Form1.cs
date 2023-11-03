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
        private Button[] buttonsMenu;
        public Form1()
        {
            InitializeComponent();
            InitializeButtonsMenu();
            buttonPocetna.Enabled = false;

        }
        public void InitializeButtonsMenu()
        {
            buttonsMenu = new Button[] { buttonPocetna, buttonDodaj, buttonSpisak, buttonPretrazi, buttonSpisak, buttonIzvestaj, buttonStatistika, buttonIzadji };
        }
        public void aktivnoDugme(object sender, EventArgs e)
        {
            Button aktivnoDugme = (Button)sender;

            foreach (Button dugme in buttonsMenu)
            {
                dugme.Enabled = true;
            }

            aktivnoDugme.Enabled = false; 
            naslov.Text = aktivnoDugme.Text;
        }

        private void buttonPocetna_Click(object sender, EventArgs e)
        {
            aktivnoDugme(sender, e);
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            aktivnoDugme(sender, e);
        }

        private void buttonSpisak_Click(object sender, EventArgs e)
        {
            aktivnoDugme(sender, e);
        }

        private void buttonPretrazi_Click(object sender, EventArgs e)
        {
            aktivnoDugme(sender, e);
        }

        private void buttonIzvestaj_Click(object sender, EventArgs e)
        {
            aktivnoDugme(sender, e);
        }

        private void buttonStatistika_Click(object sender, EventArgs e)
        {
            aktivnoDugme(sender, e);
        }

        private void buttonIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
