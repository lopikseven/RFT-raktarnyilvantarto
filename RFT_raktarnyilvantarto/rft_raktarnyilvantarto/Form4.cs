using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rft_raktarnyilvantarto
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_termek_felvesz_Click(object sender, EventArgs e)
        {
            //Megrendelőket még nem lehet hozzá választani!!!
            try
            {
                if (tb_vonalkod.Text.Length == 13 && tb_megnevezes.Text.Length > 0 && Convert.ToInt32(tb_raktaron.Text) >= 0 && Convert.ToInt32(tb_minimum.Text) >= 0)
                {
                    Program.UjTermek = new Termek();
                    try
                    {
                        Program.UjTermek.Vonalkod = tb_vonalkod.Text;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hibás vonalkód!");
                        this.Close();
                        Program.MainForm1.Show();
                        return;
                    }
                    Program.UjTermek.Nev = tb_megnevezes.Text;
                    Program.UjTermek.Tipus = tb_tipus.Text;
                    Program.UjTermek.Raktar_db = Convert.ToInt32(tb_raktaron.Text);
                    Program.UjTermek.Min_db = Convert.ToInt32(tb_minimum.Text);
                    MessageBox.Show("Új termék sikeresen felvéve!");
                    Program.MenteniKell = true;

                    this.Close();
                    Program.MainForm1.Show();
                    return;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Nem sikerült a terméket felvenni!");
                this.Close();
                Program.MainForm1.Show();
                return;
            }
            MessageBox.Show("Nem sikerült a terméket felvenni!");
            this.Close();
            Program.MainForm1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
