using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebafirestore.Cotizacion
{
    public partial class creardesde2 : Form
    {
        public String Nombre = "";
        public String Numero = "";
        public String Modelo = "";



        public creardesde2()
        {
            InitializeComponent();
        }

        private void creardesde2_Load(object sender, EventArgs e)
        {
            txtnombre.Text = Nombre;
            txtnombre2.Text = txtnombre.Text;
            txtnumero.Text = Numero;
            txtmodelo.Text = Modelo;
        }
    }
}
