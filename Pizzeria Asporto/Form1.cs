using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Pizzeria_Asporto_Visual_Studio
{
    public partial class Pizzeria : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public Pizzeria()
        {
            InitializeComponent();
            this.Height = 1080;
            this.Width = 1920;
            visualizza.Visible = false;
            tabellalaterale.Visible = false;

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (tendina.SelectedIndex == 0)
            {
                var query = from p in db.ORDINI
                            select p;
                tabellasotto.DataSource = query;
            }

            if (tendina.SelectedIndex == 1)
            {
                var query = from p in db.Consegne
                            select p;
                tabellasotto.DataSource = query;
            }

            else if (tendina.SelectedIndex == 2)
            {
                var query = from p in db.CLIENTI                            
                            select p;
                tabellasotto.DataSource = query;
            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tendina.SelectedIndex == 0)
            {
                visualizza.Visible = true;

            }
            else
            {
                visualizza.Visible = false;
            }

            if (tendina.SelectedIndex >= 0)
            {
                tabellalaterale.Visible = false;

            }
            else
            {
                tabellalaterale.Visible = true;
            }


        }

        private void Bottonepersopra_Click(object sender, EventArgs e)
        {
            if (tendina.SelectedIndex == 0)
            {
                var query = from p in db.ORDINI
                            select p;
                tabellasopra.DataSource = query;
            }

            if (tendina.SelectedIndex == 1)
            {
                var query = from p in db.Consegne
                select p;
                tabellasopra.DataSource = query;
            }

            else if (tendina.SelectedIndex == 2)
            {
                var query = from p in db.CLIENTI
                            select p;
                tabellasopra.DataSource = query;
            }

        }

        private void Pizzeria_Load(object sender, EventArgs e)
        {

        }

        private void Visualizza_Click(object sender, EventArgs e)
        {
            if (tendina.SelectedIndex == 0)
            {
                var query = from p in db.ORDINI
                           select p;
                tabellasopra.DataSource = query;

                var query1 = from p in db.PIZZE_ORDINATE
                            select p;
                tabellasotto.DataSource = query1;

                var query2 = from p in db.Ingredienti_pizze
                             select p;
                tabellalaterale.DataSource = query2;

                ordine o = new ordine();
                o.Show();
            }
        }

        private void Tabellalaterale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tabellasopra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
