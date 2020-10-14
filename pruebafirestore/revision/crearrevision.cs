using pruebafirestore.formularios;
using pruebafirestore.revision;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebafirestore
{
    public partial class crearrevision : Form
    {
        public crearrevision()
        {
            InitializeComponent();
        }

        private void pContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void crearrevision_Load(object sender, EventArgs e)
        {

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

        private void altoButton4_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel2(new revisioncrear1());

            altoButton4.Inactive1 = Color.RoyalBlue;
            altoButton4.Inactive2 = Color.White;

           

            altoButton3.Inactive1 = Color.FromArgb(37, 108, 180);
            altoButton3.Inactive2 = Color.FromArgb(66, 96, 159);

          



        }

        private void altoButton3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel2(new busquedarevision());


            altoButton3.Inactive1 = Color.RoyalBlue;
            altoButton3.Inactive2 = Color.White;



            altoButton4.Inactive1 = Color.FromArgb(37, 108, 180);
            altoButton4.Inactive2 = Color.FromArgb(66, 96, 159);
        }
    }
}
