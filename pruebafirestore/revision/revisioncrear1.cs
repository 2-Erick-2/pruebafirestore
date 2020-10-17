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


namespace pruebafirestore.formularios
{
    public partial class revisioncrear1 : Form
    {
        FirestoreDb database;
        String Accesorios = "";
        String tiemporespuesta = "";
        String pedido = "";

        public revisioncrear1()
        {
            InitializeComponent();
        }

        private void processingControl1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToShortDateString();
            string hora = DateTime.Now.ToShortTimeString();



            txthorayfecha.Text = fecha + "  " + hora;
        }



         async void Add_Document_with_orden()
        {


            DocumentReference docRef = database.Collection("Revisiones").Document(txtorden.Text);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                MessageBox.Show("Repetido");
            }
            else
            {

            DocumentReference DOC = database.Collection("Revisiones").Document(txtorden.Text);
            Dictionary<String, Object> data1 = new Dictionary<string, object>()
            {
                {"Nombre",txtnombre.Text},

                {"Numero",txtnumero.Text},

                {"Modelo",txtmarca.Text + " "+txtmodelo.Text},

                {"Descripcion",txtdescripcion.Text} ,

                {"Accesorios",Accesorios} ,

                {"Tiempo de espera",tiemporespuesta} ,

                {"Fecha y Hora",txthorayfecha.Text} 

            };
                await DOC.SetAsync(data1, SetOptions.MergeAll);
            MessageBox.Show("guardado");


            }











           
        }

        private async void altoButton1_Click(object sender, EventArgs e)
        {
            sincopia:
            string Name = txtnombre2.Text;
            var rand = new Random();
            pedido = "REVISION";
            //checkBoxcotizacion.Checked = false;
            ///checkBoxrevision.Checked = false;

            string firstfour = Name.Substring(0, 2);
            txtorden2.Text = firstfour;

            string iniciodepedidos = pedido.Substring(0, 2);

            //generacion  de numero aleatorio de orden
            var guid = Guid.NewGuid();
            var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 9));
            var random = new Random(seed);

            txtpruibea.Text = seed.ToString();
            txtorden.Text = iniciodepedidos + firstfour + seed.ToString();


            DocumentReference docRef = database.Collection("Revisiones").Document(txtorden.Text);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                MessageBox.Show("Repetido");
                goto sincopia;
            }
            else
            {
                DocumentReference DOC = database.Collection("Revisiones").Document(txtorden.Text);
                Dictionary<String, Object> data1 = new Dictionary<string, object>()
            {
                {"Nombre",txtnombre.Text},

                {"Numero",txtnumero.Text}, 

                {"Modelo",txtmarca.Text + " "+txtmodelo.Text},

                {"Descripcion",txtdescripcion.Text} ,

                {"Accesorios",Accesorios} ,

                {"Tiempo de espera",tiemporespuesta} ,

                {"Fecha y Hora",txthorayfecha.Text}

            };
                await DOC.SetAsync(data1, SetOptions.MergeAll);
                MessageBox.Show("guardado");
            }



           // Add_Document_with_orden();
        }

        private void revisioncrear1_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"facturasebest2-firebase-adminsdk-rvc9d-2a1a79f585.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            database = FirestoreDb.Create("facturasebest2");
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            txtnombre2.Text = txtnombre.Text;

        }
    }
}
