using System;
using System.Collections.Generic;
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
            set { ime = value; }
        }
        public T Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        public T DatumRodjenja
        {
            get { return datumRodjenja; }
            set { datumRodjenja = value; }
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
            set { telefon = value; }
        }
    }
}
