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
    public partial class ordine : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public ordine()
        {
            InitializeComponent();
            this.Height = 600;
            this.Width = 1200;

            var sql0 = from p in db.FORMATI
                       select p;
            formato.DataSource = sql0;

            var sql1 = from p in db.IMPASTI
                       select p;
            impasto.DataSource = sql1;

            var sql2 = from p in db.MODIFICHE
                       select p;
            modifiche.DataSource = sql2;

            var sql3 = from i in db.INGREDIENTI
                       join p in db.PRODOTTI on i.IDIngrediente equals p.ID_Prodotto
                       select new { i.IDIngrediente, p.Descrizione, i.Costo_aggiunta };

            ingredienti.DataSource = sql3;

            var sql4 = from p in db.BEVERAGE
                       select p;
            bevande.DataSource = sql4;

            var sql5 = from p in db.ORDINI_BEVANDE
                       select p;
            ordinebevande.DataSource = sql5;

        }

        private void Ordinebevande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            nuovoordine ordine = new nuovoordine();
            ordine.Show();
        }

        private void Ordine_Load(object sender, EventArgs e)
        {

        }
    }
}
