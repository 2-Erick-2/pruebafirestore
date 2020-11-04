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
using pruebafirestore.ABONOS;
using pruebafirestore.Cotizacion;
using pruebafirestore.Pedidos;

namespace pruebafirestore
{
    public partial class Form1 : Form
    {
        FirestoreDb database;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add_Document_with_AutoID();
            Add_Document_with_orden();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"facturasebest2-firebase-adminsdk-rvc9d-2a1a79f585.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
             database = FirestoreDb.Create("facturasebest2");
            
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
        void Add_Document_with_AutoID()
         {
            CollectionReference coll = database.Collection("Clientes");
            Dictionary<String, Object> data1 = new Dictionary<string, object>()
            {
                {"Nombre","tadeoooooo"},

                {"Numero","8992450222"}
            };
            coll.AddAsync(data1);
            MessageBox.Show("guardado"); 
         }


        void Add_Document_with_orden()
        {
            DocumentReference DOC = database.Collection("Clientes").Document("hola");
            Dictionary<String, Object> data1 = new Dictionary<string, object>()
            {
                {"Precio","500"},

                {"Cantidad","2"}
            };
            DOC.SetAsync(data1, SetOptions.MergeAll);
            MessageBox.Show("guardado");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("guardado");

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("guardado2");

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel2(new crearrevision());



            altoButton1.Inactive1 = Color.RoyalBlue;
            altoButton1.Inactive2 = Color.RoyalBlue;

            altoButton2.Inactive1 = Color.DodgerBlue;
            altoButton2.Inactive2 = Color.DodgerBlue;

            altoButton3.Inactive1 = Color.DodgerBlue;
            altoButton3.Inactive2 = Color.DodgerBlue;

            altoButton4.Inactive1 = Color.DodgerBlue;
            altoButton4.Inactive2 = Color.DodgerBlue;


        }

        private void altoButton2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel2(new contcotizacion());

            altoButton2.Inactive1 = Color.RoyalBlue;
            altoButton2.Inactive2 = Color.RoyalBlue;

            altoButton1.Inactive1 = Color.DodgerBlue;
            altoButton1.Inactive2 = Color.DodgerBlue;

            altoButton3.Inactive1 = Color.DodgerBlue;
            altoButton3.Inactive2 = Color.DodgerBlue;

            altoButton4.Inactive1 = Color.DodgerBlue;
            altoButton4.Inactive2 = Color.DodgerBlue;



        }

        private void altoButton3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel2(new Contenedorpedidos());

            altoButton3.Inactive1 = Color.RoyalBlue;
            altoButton3.Inactive2 = Color.RoyalBlue;

            altoButton4.Inactive1 = Color.DodgerBlue;
            altoButton4.Inactive2 = Color.DodgerBlue;

            altoButton1.Inactive1 = Color.DodgerBlue;
            altoButton1.Inactive2 = Color.DodgerBlue;

            altoButton2.Inactive1 = Color.DodgerBlue;
            altoButton2.Inactive2 = Color.DodgerBlue;
        }

        private void altoButton5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel2(new contenedorabonos());
        }
    }
}
