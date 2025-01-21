using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivatnaOrdinacija_WindowsForms
{
    internal class Pacijent<T> : Osoba<T>
    {
        protected T brojKnjizice, adresa, pol, izabraniLekar, alergije, istorijaBolesti;
        public Pacijent() { }
        public Pacijent(T ime, T prezime, T datumRodjenja, T jmbg, T telefon, T brojKnjizice, T adresa, T pol, T izabraniLekar, T alergije, T istorijaBolesti) : base(ime, prezime, datumRodjenja, jmbg, telefon)
        {
            BrojKnjizice = brojKnjizice;
            Adresa = adresa;
            Pol = pol;
            IzabraniLekar = izabraniLekar;
            Alergije = alergije;
            IstorijaBolesti = istorijaBolesti;
        }
        public T BrojKnjizice
        {
            get { return brojKnjizice; }
            set
            {
                if (value.ToString().Length == 11) brojKnjizice = value;
                else throw new Exception("Broj Knjižice mora imati 11 cifara");
            }
        }
        public T Adresa
        {
            get { return adresa; }
            set 
            {
                if (value.ToString() == "") throw new Exception("Morate uneti Adresu");
                else if(value.ToString().Contains("\n")) throw new Exception("Adresa ne sme imati 2 reda");
                else adresa = value; 
            }
        }
        public T Pol
        {
            get { return pol; }
            set 
            {
                if (value.ToString() == "M" || value.ToString() == "Ž") pol = value;
                else throw new Exception("Uneti pol mora biti M ili Ž");
            }
        }
        public T IzabraniLekar
        {
            get { return izabraniLekar; }
            set 
            {
                if (value.ToString() == "") throw new Exception("Morate uneti Izabranog lekara");
                else izabraniLekar = value; 
            }
        }
        public T Alergije
        {
            get { return alergije; }
            set
            {
                if (value.ToString() == "") throw new Exception("Morate uneti Alergije");
                else if (value.ToString().Contains("\n")) throw new Exception("Tekst o Alergijama ne sme sadržati više od jednog reda");
                else if (value.ToString().Contains(',')) throw new Exception("Tekst o Alergijama ne sme sadržati zareze");
                else alergije = value;
            }

        }
        public T IstorijaBolesti
        {
            get { return istorijaBolesti; }
            set 
            {
                if (value.ToString() == "") throw new Exception("Morate uneti Istoriju bolesti");
                else if (value.ToString().Contains("\n")) throw new Exception("Tekst o Istoriji bolesti ne sme sadržati više od jednog reda");
                else if (value.ToString().Contains(',')) throw new Exception("Tekst o Istoriji bolesti ne sme sadržati zareze");
                else istorijaBolesti = value;
            }
        }
        override public void upis(StreamWriter sw) 
        {
            base.upis(sw);
            sw.Write(BrojKnjizice + ", ");
            sw.Write(Adresa + ", ");
            sw.Write(Pol + ", ");
            sw.Write(IzabraniLekar + ", ");
            sw.Write(Alergije + ", ");
            sw.Write(IstorijaBolesti + "\n");

            sw.Close();
        }
        override public string ispis()
        {
            return base.ispis() + " ,Pol: " + Pol + " ,Broj knjižice: " + BrojKnjizice + " ,Izabrani lekar: " + IzabraniLekar;
        }
        override public void citaj(string linija)
        {
            T[] podaci;
            if (linija != null)
            {
                string[] delovi = linija.Split(',');
                for (int i = 0; i < delovi.Length; i++)
                {
                    delovi[i] = delovi[i].Trim();
                }
                podaci = new T[delovi.Length];
                for (int i = 0; i < delovi.Length; i++)
                {
                    podaci[i] = (T)Convert.ChangeType(delovi[i], typeof(T));
                }
            }
            else throw new Exception("Ne postoje podaci za pacijenta");

            Ime = podaci[0];
            Prezime = podaci[1];
            DatumRodjenja = podaci[2];
            Jmbg = podaci[3];
            Telefon = podaci[4];
            BrojKnjizice = podaci[5];
            Adresa = podaci[6];
            Pol = podaci[7];
            IzabraniLekar = podaci[8];
            Alergije = podaci[9];
            IstorijaBolesti = podaci[10];
        }
    }
}
