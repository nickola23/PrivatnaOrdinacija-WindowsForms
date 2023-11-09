using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivatnaOrdinacija_WindowsForms
{
    internal class Osoba<T>
    {
        protected T ime, prezime, datumRodjenja, jmbg, telefon;
        public Osoba() { }
        public Osoba(T ime, T prezime, T datumRodjenja, T jmbg, T telefon)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            Jmbg = jmbg;
            Telefon = telefon;
        }

        public T Ime
        {
            get { return ime; }
            set {
                if (value.ToString() == "") throw new Exception("Morate uneti ime");
                else ime = value; 
            }
        }
        public T Prezime
        {
            get { return prezime; }
            set {
                if (value.ToString() == "") throw new Exception("Morate uneti prezime");
                else prezime = value; 
            }
        }
        public T DatumRodjenja
        {
            get { return datumRodjenja; }
            set {
                if (value.ToString() == "") throw new Exception("Morate uneti Datum rodjenja");
                else datumRodjenja = value; 
            }
        }
        public T Jmbg
        {
            get { return jmbg; }
            set {
                if (value.ToString().Length == 13) jmbg = value;
                else throw new Exception("JMBG mora imati 13 cifara");
            }
        }
        public T Telefon
        {
            get { return telefon; }
            set {
                if (value.ToString() == "") throw new Exception("Morate uneti Broj telefona");
                else telefon = value; 
            }
        }
        virtual public void upis(StreamWriter sw) 
        {
            sw.Write("\n" + Ime + ", ");
            sw.Write(Prezime + ", ");
            sw.Write(DatumRodjenja + ", ");
            sw.Write(Jmbg + ", ");
            sw.Write(Telefon + ", ");
        }
        virtual public string ispis()
        {
            return Ime + " " + Prezime + ", JMBG: " + Jmbg;
        }
        virtual public void citaj(string linija)
        {
            T[] podaci;
            if (linija != null)
            {
                string[] delovi = linija.Split(',');
                for(int i = 0; i < delovi.Length; i++)
                {
                    delovi[i] = delovi[i].Trim();
                }
                podaci = new T[delovi.Length];
                for (int i = 0; i < delovi.Length; i++)
                {
                    podaci[i] = (T)Convert.ChangeType(delovi[i], typeof(T));
                }
            }
            else throw new Exception("Ne postoje podaci za osobu"); 

            Ime = podaci[0];
            Prezime = podaci[1];
            DatumRodjenja = podaci[2];
            Jmbg = podaci[3];
            Telefon = podaci[4];
        }
    }
}
