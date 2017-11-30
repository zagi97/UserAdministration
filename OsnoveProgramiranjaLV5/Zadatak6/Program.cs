using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak6
{
    class Program
    {

        public struct Knjiga
        {
            public int nSifra;
            public string sNaziv;
            public string sAutor;
            public int nGodina;

            public Knjiga(int s, string n, string a, int g)
            {
                nSifra = s;
                sNaziv = n;
                sAutor = a;
                nGodina = g;

            }
        }
        static void Main(string[] args)
        {
            Knjiga k1 = new Knjiga(1, "Olovka", "HB", 2);
            Knjiga k2 = new Knjiga(1, "Blok", "A3", 5);
            Knjiga k3 = new Knjiga(1, "Marker", "Crno", 15);
            Knjiga k4 = new Knjiga(1, "Gumica", "meka", 2);
            Knjiga k5 = new Knjiga(1, "Papir", "A4", 20);

            List<Knjiga> IKnjige = new List<Zadatak6.Program.Knjiga>();

            IKnjige.Add(k1);
            IKnjige.Add(k2);
            IKnjige.Add(k3);
            IKnjige.Add(k4);
            IKnjige.Add(k5);

            

        }
        public static void IspisiUneseneKnjige(List IKnjige)

    }
}