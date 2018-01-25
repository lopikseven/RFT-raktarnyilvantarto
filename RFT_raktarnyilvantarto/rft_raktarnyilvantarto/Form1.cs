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
        static List<Megrendelesek> Megrendelesek = new List<rft_raktarnyilvantarto.Megrendelesek>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AdatbazisBeolvasasa("Database.accdb");

            szerkesztes_button.Enabled = false;

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
            Command.CommandText = "SELECT Id, Vonalkod, Megnevezes, Tipus, Raktar_db, Minimum_db, Megrendelo FROM Termek";

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
                    atm.Id = Convert.ToInt32(Reader[0].ToString());
                    atm.Vonalkod = Reader[1].ToString();
                    atm.Nev = Reader[2].ToString();
                    atm.Tipus = Reader[3].ToString();
                    atm.Raktar_db = Convert.ToInt32(Reader[4].ToString());
                    atm.Min_db = Convert.ToInt32(Reader[5].ToString());
                    atm.Megrendelok.Add(Convert.ToInt32(Reader[6].ToString()));

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
                Application.Exit();
                return;
            }

            Reader.Close();
            Connect.Close();

            //Megrendelések
            Connect.Open();
            Command = new OleDbCommand();
            Command.Connection = Connect;
            Command.CommandText = "SELECT Azon, MegrendeloId, TermekId, Darabszam, VarhatoErkezes FROM Megrendelesek";

            try
            {
                Reader = Command.ExecuteReader();
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba az adatbázisban! Nem megfelelő táblanév vagy mezőnév itt: Megrendelesek");
                Application.Exit();
                return;
            }
            Megrendelesek atm_megrendelesek = new Megrendelesek(0,0,0,0,0);

            try
            {
                while (Reader.Read())
                {
                    atm_megrendelesek.Id = Convert.ToInt32(Reader[0].ToString());
                    atm_megrendelesek.MegrendeloId = Convert.ToInt32(Reader[1].ToString());
                    atm_megrendelesek.TermekId = Convert.ToInt32(Reader[2].ToString());
                    atm_megrendelesek.Db = Convert.ToInt32(Reader[3].ToString());
                    atm_megrendelesek.VarhatoErkezes = Convert.ToInt32(Reader[4].ToString());


                    Megrendelesek.Add(atm_megrendelesek);

                    atm_megrendelesek = new Megrendelesek(0,0,0,0,0);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba az adatbázisban! Nem megfelelő rekord a Megrendelesek táblában!");
                Application.Exit();
                 return;
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
                lb_megnevezes.Text = "-";
                lb_tipus.Text = "-";
                lb_raktaron.Text = "-";
                lb_minimum.Text = "-";
            }
        }

        private void osszes_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (osszes_radio.Checked == true)
            {
                OsszesTermekMegjelenitese();
                lb_megnevezes.Text = "-";
                lb_tipus.Text = "-";
                lb_raktaron.Text = "-";
                lb_minimum.Text = "-";
            }
            szerkesztes_button.Enabled = false;

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
            
           Form5 form5 = new Form5();
           form5.ShowDialog();
           this.Hide();
        }

        private void uj_termek_button_Click(object sender, EventArgs e)
        {
            szerkesztes_button.Enabled = false;
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

        //Ha rákattintunk egy elemre a listából
        private void lb_termekek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_termekek.SelectedIndex != -1)
            {
                Termek atm = new Termek();

                //kikeresni
                lb_megnevezes.Text = Termekek[lb_termekek.SelectedIndex].Nev;
                lb_tipus.Text = Termekek[lb_termekek.SelectedIndex].Tipus;
                lb_raktaron.Text = Termekek[lb_termekek.SelectedIndex].Raktar_db.ToString();
                lb_minimum.Text = Termekek[lb_termekek.SelectedIndex].Min_db.ToString();

                szerkesztes_button.Enabled = true;
            }
            else
            {
                szerkesztes_button.Enabled = false;
                lb_megnevezes.Text = "-";
                lb_tipus.Text = "-";
                lb_raktaron.Text = "-";
                lb_minimum.Text = "-";
            }
        }

        //Elem keresése név és típus alapján
        private Termek TermekFromNevTipus(string nev, string tipus)
        {
            Termek vissza = new Termek();

            foreach (Termek T in Termekek)
            {
                if (T.Nev == nev && T.Tipus == tipus)
                {
                    return T;
                }
            }

            return vissza;
        }

        private void lb_megnevezes_Click(object sender, EventArgs e)
        {

        }

        private void rak_allapot_button_Click(object sender, EventArgs e)
        {

        }
    }
}
