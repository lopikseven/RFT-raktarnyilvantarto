using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rft_raktarnyilvantarto
{
    class Megrendelesek
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int megrendeloId;
        public int MegrendeloId
        {
            get { return megrendeloId; }
            set { megrendeloId = value; }
        }


        private int termekId;
        public int TermekId
        {
            get { return termekId; }
            set { termekId = value; }
        }

        private int db;
        public int Db
        {
            get { return db; }
            set { db = value; }
        }


        private int varhatoErkezes;
        public int VarhatoErkezes
        {
            get { return varhatoErkezes; }
            set { varhatoErkezes = value; }
        }

        private Megrendelesek()
        {
            Id = 0;
            MegrendeloId = 0;
            TermekId = 0;
            Db = 0;
            VarhatoErkezes = 0;
        }

        public Megrendelesek(int Id, int MegrendeloId, int TermekId, int Db, int VarhatoErkezes):this()
        {
            this.Id = Id;
            this.MegrendeloId = MegrendeloId;
            this.TermekId = TermekId;
            this.Db = Db;
            this.VarhatoErkezes = VarhatoErkezes;
        }
    }
}
