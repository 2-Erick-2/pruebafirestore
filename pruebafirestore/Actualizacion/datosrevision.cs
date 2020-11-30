using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using System.Globalization;


namespace pruebafirestore.Actualizacion
{
    public partial class datosrevision : Form
    {
        FirestoreDb database;

        public String tipopedido = "";

        public String orden = "";

        public String Estado = "";


        public datosrevision()
        {
            InitializeComponent();
        }

        private async  void altoButton1_Click(object sender, EventArgs e)
        {
            if (tipopedido == "RE")
            {
                DocumentReference DOC2 = database.Collection("Revisiones").Document(orden);

                Dictionary<String, Object> data2 = new Dictionary<string, object>()
                    {

                    {"Nombre", txtnombre.Text},

                    {"Numero", txtnumero.Text},

                    {"Modelo", txtmodelo.Text}
                };
                await DOC2.UpdateAsync(data2);
                MessageBox.Show("guardado");
            }

           else  if (tipopedido == "CO")
            {
                DocumentReference DOC2 = database.Collection("Cotizaciones").Document(orden);

                Dictionary<String, Object> data2 = new Dictionary<string, object>()
                    {

                    {"Nombre", txtnombre.Text},

                    {"Numero", txtnumero.Text},

                    {"Estado2", Estado},

                    {"Modelo", txtmodelo.Text}
                };
                await DOC2.UpdateAsync(data2);
                MessageBox.Show("guardado");
            }

            else if (tipopedido == "PE")
            {
                DocumentReference DOC2 = database.Collection("Pedidos").Document(orden);

                Dictionary<String, Object> data2 = new Dictionary<string, object>()
                    {

                    {"Nombre", txtnombre.Text},

                    {"Numero", txtnumero.Text},

                    {"Estado2", Estado},

                    {"Modelo", txtmodelo.Text}
                };
                await DOC2.UpdateAsync(data2);
                MessageBox.Show("guardado");
            }




            this.Hide();
           
        }

        private void datosrevision_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"facturasebest2-firebase-adminsdk-rvc9d-2a1a79f585.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            database = FirestoreDb.Create("facturasebest2");

            if (tipopedido == "CO")
            {
                checksinrefacciones.Visible = true;
                checkperdidatotal.Visible = true;
            }
            else if (tipopedido == "PE")
            {
                checksinrefacciones.Visible = false;
                checkperdidatotal.Visible = false;

                checKLISTO.Visible = true;
                checkpedidorealizado.Visible = true;
            }
            else if (tipopedido == "RE")
            {
                checksinrefacciones.Visible = false;
                checkperdidatotal.Visible = false;
                checKLISTO.Visible = false;
                checkpedidorealizado.Visible = false;
            }
        }

        private void checksinrefacciones_CheckedChanged(object sender, EventArgs e)
        {
            if (checksinrefacciones.Checked == true)
            {
                checkperdidatotal.Checked = false;
                Estado = "Sin refacciones";
            }
        }

        private void checkperdidatotal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkperdidatotal.Checked == true)
            {
                checksinrefacciones.Checked = false;
                Estado = "Perdida total";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkpedidorealizado.Checked == true)
            {
                checKLISTO.Checked = false;
                Estado = "Pedido realizado";

            }
        }

        private void checKLISTO_CheckedChanged(object sender, EventArgs e)
        {
            if (checKLISTO.Checked == true)
            {
                checkpedidorealizado.Checked = false;
                Estado = "Listo";

            }
        }

        private async void altoButton2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Eliminar", "Eliminando",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                // cancel the closure of the form.


                if (tipopedido == "CO")
                {
                    DocumentReference cityRef = database.Collection("Cotizaciones").Document(orden);
                    await cityRef.DeleteAsync();
                }
                else if (tipopedido == "PE")
                {
                    DocumentReference cityRef = database.Collection("Pedidos").Document(orden);
                    await cityRef.DeleteAsync();
                }
                else if (tipopedido == "RE")
                {
                    DocumentReference cityRef = database.Collection("Revisiones").Document(orden);
                    await cityRef.DeleteAsync();
                }
                MessageBox.Show("Eliminado");
            }
        }
    }
}
