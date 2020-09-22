using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria_Asporto_Visual_Studio
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.Height = 200;
            this.Width = 400;
        }

        private void ACCEDI_Click(object sender, EventArgs e)
        {
            var utente = utentebox.Text;
            var password = passbox.Text;

            if((utente == "titolare") && (password == "titolare"))
            {
                area area = new area();
                area.Show();
                this.Hide();
            }

            else
            {
                riprova.Visible = true;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            riprova.Visible = false;
        }
    }
}
