using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace rft_raktarnyilvantarto
{
    public partial class Form1 : Form
    {
        static OleDbConnection Connect = new OleDbConnection();

        static List<Termek> Termekek = new List<Termek>();
        static List<Megrendelo> Megrendelok = new List<Megrendelo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AdatbazisBeolvasasa("Database.accdb");

            osszes_radio.Checked = true;
            OsszesTermekMegjelenitese();
        }

        private void AdatbazisBeolvasasa(string path)
        {
            try
            {
                Connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @";User Id=admin;Password=";
                Connect.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba az adatbázis elérése közben! Nem létező útvonal!");
                Application.Exit();
                return; // Hogy ki is lépjen
            }


            //Termékek
            OleDbCommand Command = new OleDbCommand();
            Command.Connection = Connect;
            Command.CommandText = "SELECT Vonalkod, Megnevezes, Tipus, Raktar_db, Minimum_db, Megrendelo FROM Termek";

            OleDbDataReader Reader;
            try
            {
                Reader = Command.ExecuteReader();
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba az adatbázisban! Nem megfelelő táblanév vagy mezőnév itt: Termek");
                Application.Exit();
                return; // Hogy ki is lépjen
            }

            Termek atm = new Termek("1111111111116", "atm");

            try
            {
                while (Reader.Read())
                {
                    atm.Vonalkod = Reader[0].ToString();
                    atm.Nev = Reader[1].ToString();
                    atm.Tipus = Reader[2].ToString();
                    atm.Raktar_db = Convert.ToInt32(Reader[3].ToString());
                    atm.Min_db = Convert.ToInt32(Reader[4].ToString());
                    atm.Megrendelok.Add(Convert.ToInt32(Reader[5].ToString()));

                    Termekek.Add(atm);

                    atm = new Termek();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba az adatbázisban! Nem megfelelő rekord a Termek táblában!");
                Application.Exit();
                return;
            }

            Reader.Close();
            Connect.Close();

            //Megrendelők
            Connect.Open();
            Command = new OleDbCommand();
            Command.Connection = Connect;
            Command.CommandText = "SELECT Id, Ceg_nev, Weblap, Telefon FROM Megrendelo";

            try
            {
                Reader = Command.ExecuteReader();
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba az adatbázisban! Nem megfelelő táblanév vagy mezőnév itt: Megrendelo");
                Application.Exit();
                return;
            }
            Megrendelo atm_ = new Megrendelo();

            try
            {
                while (Reader.Read())
                {
                    atm_.Id = Convert.ToInt32(Reader[0].ToString());
                    atm_.Nev = Reader[1].ToString();
                    atm_.Weblap = Reader[2].ToString();
                    atm_.Telefon = Reader[3].ToString();

                    Megrendelok.Add(atm_);

                    atm_ = new Megrendelo();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba az adatbázisban! Nem megfelelő rekord a Megrendelo táblában!");
            }

            Reader.Close();
            Connect.Close();

        }

        private void OsszesTermekMegjelenitese()
        {
            lb_termekek.Items.Clear();
            foreach (Termek T in Termekek)
            {
                lb_termekek.Items.Add(T.Nev + " - " + T.Tipus);
            }
        }

        private void MegrendelendoTermekekMegjelenitese()
        {
            lb_termekek.Items.Clear();
            foreach (Termek T in Termekek)
            {
                if(T.Raktar_db < T.Min_db) lb_termekek.Items.Add(T.Nev + " - " + T.Tipus);
            }
        }

        private void rendelendo_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (rendelendo_radio.Checked == true)
            {
                MegrendelendoTermekekMegjelenitese();
            }
        }

        private void osszes_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (osszes_radio.Checked == true)
            {
                OsszesTermekMegjelenitese();
            }
        }

        private void jelentes_button_Click(object sender, EventArgs e)
        {
            //Egyszerre hozza létre mind a kettő jelentés file-t

            //Minden termék
            StreamWriter sw = new StreamWriter("OsszesTermek.xls",false,Encoding.Unicode);

            sw.WriteLine("Vonalkód\tNév\tTípus\tMinimum db\tRaktár db\tCég név\tTelefon\tWeblap");
            foreach (Termek T in Termekek)
            {
                sw.Write("{0}\t{1}\t{2}\t{3}\t{4}\t",T.Vonalkod,T.Nev,T.Tipus,T.Min_db,T.Raktar_db);

                if (T.Megrendelok.Count > 0)
                {
                    for (int i = 0; i < T.Megrendelok.Count; i++)
                    {
                        foreach (Megrendelo M in Megrendelok)
                        {
                            if (M.Id == T.Megrendelok[i]) sw.Write("{0}\t{1}\t{2}", M.Nev, M.Telefon, M.Weblap);
                        }
                    }
                }
                else sw.Write("-\t-\t-");
                sw.WriteLine();
            }
            sw.Close();

            sw = new StreamWriter("MegrendelniTermek.xls",false,Encoding.Unicode);
            sw.WriteLine("Vonalkód\tNév\tTípus\tMinimum db\tRaktár db\tCég név\tTelefon\tWeblap");
            foreach (Termek T in Termekek)
            {
                if(T.Raktar_db < T.Min_db)sw.Write("{0}\t{1}\t{2}\t{3}\t{4}\t", T.Vonalkod, T.Nev, T.Tipus, T.Min_db, T.Raktar_db);

                if (T.Megrendelok.Count > 0)
                {
                    for (int i = 0; i < T.Megrendelok.Count; i++)
                    {
                        foreach (Megrendelo M in Megrendelok)
                        {
                            if (M.Id == T.Megrendelok[i]) sw.Write("{0}\t{1}\t{2}", M.Nev, M.Telefon, M.Weblap);
                        }
                    }
                }
                else sw.Write("-\t-\t-");
                sw.WriteLine();
            }
            sw.Close();

            MessageBox.Show("Jelentés file-k létrehozva!");
        }

        private void rendelesek_button_Click(object sender, EventArgs e)
        {
            
           Form2 form2 = new Form2();
           form2.Show();
           this.Hide();
        }

        private void uj_termek_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 UjTermekForm = new Form3();
            UjTermekForm.Show();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            if (Program.MenteniKell)
            {
                Termekek.Add(Program.UjTermek);

                if (osszes_radio.Checked) lb_termekek.Items.Add(Program.UjTermek.Nev + " - " + Program.UjTermek.Tipus);
                else if (rendelendo_radio.Checked && Program.UjTermek.Raktar_db < Program.UjTermek.Min_db) lb_termekek.Items.Add(Program.UjTermek.Nev + " - " + Program.UjTermek.Tipus);

                Program.UjTermek = new Termek();
                Program.MenteniKell = false;
            }
        }

        private void lb_termekek_MouseEnter(object sender, EventArgs e)
        {
            if (Program.MenteniKell)
            {
                Termekek.Add(Program.UjTermek);

                if (osszes_radio.Checked) lb_termekek.Items.Add(Program.UjTermek.Nev + " - " + Program.UjTermek.Tipus);
                else if (rendelendo_radio.Checked && Program.UjTermek.Raktar_db < Program.UjTermek.Min_db) lb_termekek.Items.Add(Program.UjTermek.Nev + " - " + Program.UjTermek.Tipus);

                Program.UjTermek = new Termek();
                Program.MenteniKell = false;
            }
        }
    }
}
