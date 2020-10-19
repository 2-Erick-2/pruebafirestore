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
using Google.Cloud.Firestore.V1;

namespace pruebafirestore.formularios
{
    public partial class revisioncrear1 : Form
    {
        FirestoreDb database;
        String Accesorios = "";
        String tiemporespuesta = "";
        String pedido = "";
        String contra = "";

        //int id = 0;

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
            //id = id +1;
            if (checkrespuesta.Checked == true && checkBox2.Checked == true)
            {
                tiemporespuesta = combodias.Text;
            }
            else if (checkrespuesta.Checked == true && checkBox1.Checked == true)
            {
                tiemporespuesta = combohoras.Text;
            }

            if (checknoaplica.Checked == true)
            {
                Accesorios = "No aplica";
            }
            else if (checkprotctor.Checked && checkchip.Checked == true)
            {
                Accesorios = "Protector y Chip";
            }
            else if (checkprotctor.Checked == true)
            {
                Accesorios = "Protector";
            }
            else if (checkchip.Checked == true)
            {
                Accesorios = "Accesorios";
            }
            else if (checkotros.Checked == true)
            {
                Accesorios = txtotros.Text;

            }

            if (checkcontra.Checked == true)
            {
                contra = txtcontracel.Text;
            }
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
                DocumentReference DOC = database.Collection("Revisiones").Document("contador");
                Dictionary<String, Object> data1 = new Dictionary<string, object>()
            {
                 {"ID", FieldValue.Increment(1)}




            };
                await DOC.SetAsync(data1, SetOptions.MergeAll);
                /* WriteBatch batch = database.StartBatch();



                 DocumentReference DOC3 = database.Collection("Revisiones").Document("contador");
                 Dictionary<String, Object> data3 = new Dictionary<string, object>()
                 {
                    {"ID", FieldValue.Increment(1)}

                 };
                 batch.Set(DOC3, data3, SetOptions.MergeAll);

                 await batch.CommitAsync();*/


                DocumentReference docRef2 = database.Collection("Revisiones").Document("contador");
                DocumentSnapshot snapsho2 = await docRef2.GetSnapshotAsync();
                if (snapsho2.Exists)
                {
                    Dictionary<string, object> counter = snapsho2.ToDictionary();
                    foreach (var item in counter)
                        lblcontador.Text = string.Format("{1}", item.Key, item.Value);
                }


                int id = (int)Convert.ToInt64(lblcontador.Text);
                DocumentReference DOC2 = database.Collection("Revisiones").Document(txtorden.Text);

                Dictionary<String, Object> data2 = new Dictionary<string, object>()
            {
                 {"ID", id},

                {"Nombre",txtnombre.Text},

                {"Numero",txtnumero.Text},

                {"Modelo",txtmarca.Text + " "+txtmodelo.Text},

                {"Descripcion",txtdescripcion.Text} ,

                {"Accesorios",Accesorios} ,

                {"Tiempo de espera",tiemporespuesta} ,

                {"Fecha y Hora",txthorayfecha.Text},

                {"Contraseña", contra}


            };
                await DOC2.SetAsync(data2, SetOptions.MergeAll);
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

        private void checkrespuesta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkrespuesta.Checked == true)
            {
                checkBox2.Visible = true;
                combodias.Visible = true;
                checkBox1.Visible = true;
                combohoras.Visible = false;
            }
            else if (checkrespuesta.Checked == false)
            {
                checkBox2.Visible = false;
                combodias.Visible = false;
                checkBox1.Visible = false;
                combohoras.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                combodias.Visible = true;
                combohoras.Visible = false;
            }
            else if (checkBox2.Checked == false && checkBox1.Checked == false)
            {
                checkBox2.Checked = true;
                combodias.Visible = true;
                combohoras.Visible = false;
            }
            else
            {
                checkBox2.Checked = false;
                combodias.Visible = false;
                combohoras.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                combodias.Visible = false;
                combohoras.Visible = true;
            }
            else if (checkBox2.Checked == false && checkBox1.Checked == false)
            {

                checkBox2.Checked = true;
                combodias.Visible = true;
                combohoras.Visible = false;
            }
            else
            {
                checkBox1.Checked = false;
                combodias.Visible = true;
                combohoras.Visible = false;
            }
        }

        private void checknoaplica_CheckedChanged(object sender, EventArgs e)
        {
            if (checknoaplica.Checked == true)
            {
                checkprotctor.Visible = false;
                checkchip.Visible = false;
                checkotros.Visible = false;
                txtotros.Visible = false;
            }
            else if (checknoaplica.Checked == false)
            {
                checkprotctor.Visible = true;
                checkchip.Visible = true;
                checkotros.Visible = true;
                txtotros.Visible = true;
            }
        }

        private void checkotros_CheckedChanged(object sender, EventArgs e)
        {
            if (checkotros.Checked == true)
            {
                checkprotctor.Visible = false;
                checkchip.Visible = false;
            }
            else if (checkotros.Checked == false)
            {
                checkprotctor.Visible = true;
                checkchip.Visible = true;
            }
        }

        private void checkcontra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkcontra.Checked == true)
            {
                txtcontracel.Visible = true;
            }
            else if (checkcontra.Checked == false)
            {
                txtcontracel.Visible = false;
            }
        }

        private async void altoButton2_Click(object sender, EventArgs e)
        {
            DocumentReference DOC = database.Collection("Revisiones").Document("contador");

            Dictionary<String, Object> data1 = new Dictionary<string, object>()
            {
                 {"ID", FieldValue.Increment(1)}

              


            };
            await DOC.SetAsync(data1, SetOptions.MergeAll);





           /* WriteBatch batch = database.StartBatch();
           


            DocumentReference DOC3 = database.Collection("Revisiones").Document("contador");
            Dictionary<String, Object> data3 = new Dictionary<string, object>()
            {
               {"ID", FieldValue.Increment(1)}

            };
            batch.Set(DOC3, data3, SetOptions.MergeAll);
       
            await batch.CommitAsync();*/


            DocumentReference docRef = database.Collection("Revisiones").Document("contador");
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                Dictionary<string, object> counter = snapshot.ToDictionary();
                foreach (var item in counter)
                    lblcontador.Text = string.Format("{1}",item.Key, item.Value);
            }



            DocumentReference DOC2 = database.Collection("Revisiones").Document(txtorden.Text);

            Dictionary<String, Object> data2 = new Dictionary<string, object>()
            {
                 {"ID", lblcontador.Text},

                {"Nombre",txtnombre.Text},

                {"Numero",txtnumero.Text},

                {"Modelo",txtmarca.Text + " "+txtmodelo.Text},

                {"Descripcion",txtdescripcion.Text} ,

                {"Accesorios",Accesorios} ,

                {"Tiempo de espera",tiemporespuesta} ,

                {"Fecha y Hora",txthorayfecha.Text},

                {"Contraseña", contra}


            };
            await DOC2.SetAsync(data2, SetOptions.MergeAll);
            MessageBox.Show("guardado");









        }
    }
}
