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
    public partial class Benvenuto : Form
    {
        public Benvenuto()
        {
            InitializeComponent();
            this.Height = 1080;
            this.Width = 1920;
        }

        private void Accesso_Click(object sender, EventArgs e)
        {
            
            Pizzeria p = new Pizzeria();
            this.Hide();
            p.Show();
            
            

        }

        private void Benvenuto_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form4 login = new Form4();
            login.Show();
        }
    }
}
