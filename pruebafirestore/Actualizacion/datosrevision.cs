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
        }
    }
}
