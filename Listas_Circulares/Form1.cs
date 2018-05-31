using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_Circulares
{
    public partial class Form1 : Form
    {
        Estuctura folleto = new Estuctura();

        public Form1()
        {
            InitializeComponent();

            txtRes.ScrollBars = ScrollBars.Both;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ClaseBase fufa;
            fufa = new ClaseBase(txtNombre.Text,Convert.ToInt32(txtTiempo.Text));
            folleto.insertar(fufa,Convert.ToInt32(txtPocision.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
             txtRes.Text = folleto.listar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            folleto.Eliminar(txtNombre.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folleto.EliminarInicio();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtRes.Text = folleto.Ruta(txtNombre.Text,Convert.ToDateTime(txtHoraini.Text),Convert.ToDateTime(txtHorafinal.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClaseBase objeto;
            objeto = new ClaseBase(txtNombre.Text,Convert.ToInt32(txtTiempo.Text));
            folleto.agregar(objeto);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            folleto.EliminarUltimo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtRes.Text= folleto.Buscar(txtNombre.Text).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtHoraini_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
