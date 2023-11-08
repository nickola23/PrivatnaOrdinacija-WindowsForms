using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivatnaOrdinacija_WindowsForms
{
    internal class Doktor<T> : Osoba<T>
    {
        protected T brojLicence, specijalizacija;
        public Doktor() { }
        public Doktor(T ime, T prezime, T datumRodjenja, T jmbg, T telefon, T brojLicence, T specijalizacija) : base(ime, prezime, datumRodjenja, jmbg, telefon)
        {
            BrojLicence = brojLicence;
            Specijalizacija = specijalizacija;
        }

        public T BrojLicence
        {
            get { return brojLicence; }
            set {
                if (value.ToString() == "") throw new Exception("Morate uneti Broj licence");
                else brojLicence = value; 
            }
        }
        public T Specijalizacija
        {
            get { return specijalizacija; }
            set {
                if (value.ToString() == "") throw new Exception("Morate uneti Specijalizaciju");
                else specijalizacija = value; 
            }
        }
        override public void upis(StreamWriter sw)
        {
            base.upis(sw);
            sw.Write(brojLicence + ", ");
            sw.Write(Specijalizacija + "\n");

            sw.Close();
        }
        override public string ispis()
        {
            return base.ispis() + " ,Broj licence: " + BrojLicence + " ,Specijalizacija: " + Specijalizacija;
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
            else throw new Exception("Ne postoje podaci za Doktora");

            Ime = podaci[0];
            Prezime = podaci[1];
            DatumRodjenja = podaci[2];
            Jmbg = podaci[3];
            Telefon = podaci[4];
            BrojLicence = podaci[5];
            Specijalizacija = podaci[6];
        }
    }
}
