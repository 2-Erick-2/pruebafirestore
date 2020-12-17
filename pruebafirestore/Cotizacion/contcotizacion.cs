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
    public partial class contcotizacion : Form
    {
        public contcotizacion()
        {
            InitializeComponent();
        }

        private void altoButton4_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel2(new creardesdecoti());



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
            AbrirFormEnPanel2(new busquedacoti());

            

        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel2(new crearcoti());



            






        }
    }
}
