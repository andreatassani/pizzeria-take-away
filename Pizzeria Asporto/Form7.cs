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
    public partial class Form7 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Form7()
        {
            InitializeComponent();
            this.Width = 450;
            this.Height = 280;



        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var ido = int.Parse(textBox1.Text);
            var data = DateTime.Parse(textBox6.Text);
            var quantità = int.Parse(textBox2.Text);
            var num = int.Parse(textBox4.Text);
            var costo = double.Parse(textBox8.Text);
            var formato = int.Parse(textBox7.Text);
            var impasto = int.Parse(textBox5.Text);
            var codicepizza = int.Parse(textBox3.Text);


            PIZZE_ORDINATE objOrdini = new PIZZE_ORDINATE();
            objOrdini.IDOrdine = ido;
            objOrdini.Data = data;
            objOrdini.Quantita = quantità;
            objOrdini.Numero = num;
            objOrdini.Costo = costo;
            objOrdini.Codice_formato = formato;
            objOrdini.Codice_impasto = impasto;
            objOrdini.Codice_listino_pizza = codicepizza;

            db.PIZZE_ORDINATE.InsertOnSubmit(objOrdini);
            db.SubmitChanges();

            this.Hide();

        }
    }
}
