using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rft_raktarnyilvantarto
{
    class Megrendelo
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nev;
        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        private string weblap;
        public string Weblap
        {
            get { return weblap; }
            set { weblap = value; }
        }

        private string telefon;
        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }


        //Konstruktorok megírása!
        public Megrendelo()
        {
            Id = 0;
            Nev = "";
            Weblap = "";
            Telefon = "";
        }

        public Megrendelo(int Id, string Nev, string Weblap, string Telefon) : this()
        {
            this.Id = Id;
            this.Nev = Nev;
            this.Weblap = Weblap;
            this.Telefon = Telefon;
        }
    }
}
