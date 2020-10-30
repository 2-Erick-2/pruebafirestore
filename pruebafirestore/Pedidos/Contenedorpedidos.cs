using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebafirestore.Pedidos
{
    public partial class Contenedorpedidos : Form
    {
        public Contenedorpedidos()
        {
            InitializeComponent();
        }

        private void altoButton2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel2(new crearpedido());
        }


        private void AbrirFormEnPanel2(object formhija2)
        {

            if (this.pContainer.Controls.Count > 0)
                this.pContainer.Controls.RemoveAt(0);
            Form fh = formhija2 as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pContainer.Controls.Add(fh);
            this.pContainer.Tag = fh;
            fh.Show();
        }

        private void altoButton3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel2(new busquedapedidos());
        }

        private void altoButton4_Click(object sender, EventArgs e)
        {
        }

        private void altoButton4_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel2(new Movimientospedidos());

        }
    }
}
