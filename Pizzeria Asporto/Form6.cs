using Pizzeria_Asporto_Visual_Studio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class nuovoordine : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public nuovoordine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ido = int.Parse(textBox1.Text);
            var data = DateTime.Parse(textBox2.Text);
            var ora = TimeSpan.Parse(textBox3.Text);
            var numpizze = int.Parse(textBox12.Text);
            var imp = double.Parse(textBox5.Text);
            var tot = double.Parse(textBox4.Text);
            var pagato = textBox6.Text;
            var tipo = textBox11.Text;
            var cliente = textBox9.Text;
            var cassiere = textBox10.Text;
            var fattorino = textBox8.Text;
            var consegna = double.Parse(textBox7.Text);

            ORDINI objOrdini = new ORDINI();
            objOrdini.IDOrdine = ido;
            objOrdini.Data = data;
            objOrdini.Ora = ora;
            objOrdini.Numero_pizze_ordinate = numpizze;
            objOrdini.Importo_ordine = imp;
            objOrdini.Totale = tot;
            objOrdini.Pagato = pagato;
            objOrdini.Tipologia_pagamento = tipo;
            objOrdini.CodCliente = cliente;
            objOrdini.IdCassiere = cassiere;
            objOrdini.IdFattorino = fattorino;
            objOrdini.Importo_consegna = consegna;

            db.ORDINI.InsertOnSubmit(objOrdini);
            db.SubmitChanges();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Form7 newpizza = new Form7();
            newpizza.Show();
        }
    }
}
