using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace Pizzeria_Asporto_Visual_Studio
{
    public partial class area : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public area()
        {
            InitializeComponent();
            this.Height = 1080;
            this.Width = 1920;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Destra_Click(object sender, EventArgs e)
        {
            if (voce.SelectedIndex == 0)
            {
                var query = from p in db.ORDINI_FORNITORI
                            select p;
                dataGridView1.DataSource = query;
            }

            if (voce.SelectedIndex == 1)
            {
                var query = from p in db.FATTURE
                            select p;
                dataGridView1.DataSource = query;
            }

            else if (voce.SelectedIndex == 2)
            {
                var query = from p in db.DETTAGLI_ORDINI
                            select p;
                dataGridView1.DataSource = query;
            }

            else if (voce.SelectedIndex == 3)
            {
                var query = from p in db.TURNI
                            select p;
                dataGridView1.DataSource = query;
            }

            else if (voce.SelectedIndex == 4)
            {
                var query = from p in db.DIPENDENTI
                            select p;
                dataGridView1.DataSource = query;
            }

            else if (voce.SelectedIndex == 5)
            {
                var query = from p in db.PRODOTTI
                            select p;
                dataGridView1.DataSource = query;
            }

        }

        private void Quadrato_Click(object sender, EventArgs e)
        {
            if (voce.SelectedIndex == 0)
            {
                var query = from p in db.ORDINI_FORNITORI
                            select p;
                dataGridView4.DataSource = query;
            }

            if (voce.SelectedIndex == 1)
            {
                var query = from p in db.FATTURE
                            select p;
                dataGridView4.DataSource = query;
            }

            else if (voce.SelectedIndex == 2)
            {
                var query = from p in db.DETTAGLI_ORDINI
                            select p;
                dataGridView4.DataSource = query;
            }

            else if (voce.SelectedIndex == 3)
            {
                var query = from p in db.TURNI
                            select p;
                dataGridView4.DataSource = query;
            }

            else if (voce.SelectedIndex == 4)
            {
                var query = from p in db.DIPENDENTI
                            select p;
                dataGridView4.DataSource = query;
            }

            else if (voce.SelectedIndex == 5)
            {
                var query = from p in db.PRODOTTI
                            select p;
                dataGridView4.DataSource = query;
            }
        }

        private void Centro_Click(object sender, EventArgs e)
        {
            if (voce.SelectedIndex == 0)
            {
                var query = from p in db.ORDINI_FORNITORI
                            select p;
                dataGridView2.DataSource = query;
            }

            if (voce.SelectedIndex == 1)
            {
                var query = from p in db.FATTURE
                            select p;
                dataGridView2.DataSource = query;
            }

            else if (voce.SelectedIndex == 2)
            {
                var query = from p in db.DETTAGLI_ORDINI
                            select p;
                dataGridView2.DataSource = query;
            }

            else if (voce.SelectedIndex == 3)
            {
                var query = from p in db.TURNI
                            select p;
                dataGridView2.DataSource = query;
            }

            else if (voce.SelectedIndex == 4)
            {
                var query = from p in db.DIPENDENTI
                            select p;
                dataGridView2.DataSource = query;
            }

            else if (voce.SelectedIndex == 5)
            {
                var query = from p in db.PRODOTTI
                            select p;
                dataGridView2.DataSource = query;
            }
        }

        private void Basso_Click(object sender, EventArgs e)
        {
            if (voce.SelectedIndex == 0)
            {
                var query = from p in db.ORDINI_FORNITORI
                            select p;
                dataGridView3.DataSource = query;
            }

            if (voce.SelectedIndex == 1)
            {
                var query = from p in db.FATTURE
                            select p;
                dataGridView3.DataSource = query;
            }

            else if (voce.SelectedIndex == 2)
            {
                var query = from p in db.DETTAGLI_ORDINI
                            select p;
                dataGridView3.DataSource = query;
            }

            else if (voce.SelectedIndex == 3)
            {
                var query = from p in db.TURNI
                            select p;
                dataGridView3.DataSource = query;
            }

            else if (voce.SelectedIndex == 4)
            {
                var query = from p in db.DIPENDENTI
                            select p;
                dataGridView3.DataSource = query;
            }

            else if (voce.SelectedIndex == 5)
            {
                var query = from p in db.PRODOTTI
                            select p;
                dataGridView3.DataSource = query;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
