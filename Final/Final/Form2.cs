using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Frm2 : Form
    {
        public Frm2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            Elementos inicioForm = new Elementos();

            // Mostrar el formulario `Inicio`
            inicioForm.Show();

            // Ocultar el formulario actual (opcional)
            this.Hide();
        }

        private void btnOrdenanza_Click(object sender, EventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Stock inicioForm = new Stock();

            // Mostrar el formulario `Inicio`
            inicioForm.Show();

            // Ocultar el formulario actual (opcional)
            this.Hide();
        }
    }
}
