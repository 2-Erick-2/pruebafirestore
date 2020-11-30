﻿using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Globalization;

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
            else if (checkrespuesta.Checked == false)
            {
                tiemporespuesta = "No aplica";

            }

            if (checknoaplica.Checked == false)
            {
                Accesorios = "No aplica";

            }
            else if (checknoaplica.Checked == true && checkprotctor.Checked && checkchip.Checked == true)
            {
                Accesorios = "Protector y Chip";
            }
            else if (checknoaplica.Checked == true && checkprotctor.Checked == true)
            {
                Accesorios = "Protector";
            }
            else if (checknoaplica.Checked == true && checkchip.Checked == true)
            {
                Accesorios = "Chip";
            }
            else if (checknoaplica.Checked == true &&    checkotros.Checked == true)
            {
                Accesorios = txtotros.Text;

            }

            if (checkcontra.Checked == true)
            {
                contra = txtcontracel.Text;
            }
            else if (checkcontra.Checked == false)
            {
                contra = "No aplica";
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
            try
            {
                DocumentReference docRef = database.Collection("Revisiones").Document(txtorden.Text);
                DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
                if (snapshot.Exists)
                {
                    MessageBox.Show("Repetido");
                       
                    goto sincopia;
                }
                else
                {
                    DocumentReference DOC = database.Collection("Revisiones").Document ("contador");
                    Dictionary<String, Object> data1 = new Dictionary<string, object>()
                {
                 {"ID", FieldValue.Increment(1)}


                 };
                    await DOC.SetAsync(data1, SetOptions.MergeAll);

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

                {"Orden", txtorden.Text},

                {"Nombre",txtnombre.Text},

                {"Numero",txtnumero.Text},

                {"Modelo",txtmodelo.Text},

                {"Descripcion",txtdescripcion.Text} ,

                {"Accesorios",Accesorios} ,

                {"Tiempodeespera",tiemporespuesta} ,

                {"Fechayhora",txthorayfecha.Text},

                {"Contraseña", contra}
             };
                    await DOC2.SetAsync(data2, SetOptions.MergeAll);
                    MessageBox.Show("guardado");

                    BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
                    Codigo.IncludeLabel = true;
                    pictureBox2.Image = Codigo.Encode(BarcodeLib.TYPE.CODE128, txtorden.Text, Color.Black, Color.White, 200, 60);

                    BrotherPrintThis();

                    printDocument1 = new PrintDocument();
                    PrinterSettings ps = new PrinterSettings();
                    printDocument1.PrinterSettings = ps;
                    printDocument1.PrintPage += imprimir;
                    printDocument1.Print();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            altoButton1.Enabled = false;
            button1.Enabled = true;

        }
        public void BrotherPrintThis()
        {
            try
            {

                string path = @"C:\cartaebest3.lbx";
                bpac.Document doc = new bpac.Document();
                doc.Open(path);
                bool test = doc.SetPrinter("Brother QL-800", true);
                string pedido2 = "Tipo pedido: " + pedido;
                string nombre = "Nombre: " + txtnombre.Text;
                string numero = "Numero: " + txtnumero.Text;
                string obser = "Obs.: " + txtdescripcion.Text;
                string orden = "Numero orden: " + txtorden.Text;
                string orden2 = txtorden.Text;
                doc.GetObject("pedido").Text = pedido2;
                doc.GetObject("nombre").Text = nombre;
                doc.GetObject("numero").Text = numero;
                doc.GetObject("modelo").Text = "Modelo: " + txtmodelo.Text;
                doc.GetObject("fecha").Text = txthorayfecha.Text;
                doc.GetObject("obser").Text = obser;
                doc.GetObject("id").Text = lblcontador.Text;
                doc.GetObject("contraseña").Text = "Clave: " + txtcontracel.Text;

                //doc.GetObject("orden").Text = orden;
                doc.GetObject("codigo").Text = orden2;
                //doc.GetObject("tiempo").Text = espera;
                doc.StartPrint("", bpac.PrintOptionConstants.bpoDefault);
                doc.PrintOut(1, bpac.PrintOptionConstants.bpoDefault);
                doc.EndPrint();
                doc.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void imprimir(object sender, PrintPageEventArgs e )
        {
            //Image newImage3 = Image.FromFile(@"D:\TODO\ebestimprimr4.jpg");
            Image newImage = Properties.Resources.ebestimprimr4;

            int y = 100;
            printDocument1.PrinterSettings.PrinterName = "TM-T20II";

            // Create rectangle for source image.
            RectangleF srcRect = new RectangleF(100.0F, 100.0F, 150.0F, 150.0F);
            e.Graphics.DrawImage(newImage, 30, 2);

            //e.Graphics.DrawImageUnscaledAndClipped(newImage,new Point(10,10));
            e.Graphics.DrawString("   Equipo en  revisión", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(5, y));
            e.Graphics.DrawString("                                       id: " + lblcontador.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y+=40));

            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                    GUGE900514C70", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("     Calle Pedro J. Méndez No.1082-A OTE.", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                  Reynosa Tamaulipas", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                             88500", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            //e.Graphics.DrawString("                  e-best@live.com.mx", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                         8999222312", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                         8994349816", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                         8991420006", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                  e-best@live.com.mx", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));


            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("      Fecha: " + txthorayfecha.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("      Nombre: " + txtnombre.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("      Numero: " + txtnumero.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            e.Graphics.DrawString("      Modelo: " + txtmodelo.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            if (checkrespuesta.Checked == true && checkBox2.Checked == true)
            {
                e.Graphics.DrawString("      Tiempo de espera: " + combodias.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            }
            else if (checkrespuesta.Checked == true && checkBox1.Checked == true)
            {
                e.Graphics.DrawString("      Tiempo de espera: " + combohoras.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            }
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("               Orden: " + txtorden.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 25));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawImage(pictureBox2.Image, 40, y += 20);
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
            txtnombre.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtnombre.Text);
            txtnombre.SelectionStart = txtnombre.Text.Length;

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
                 checkprotctor.Visible = true;
                checkchip.Visible = true;
                checkotros.Visible = true;
                txtotros.Visible = true;
            }
            else if (checknoaplica.Checked == false)
            {
               


checkprotctor.Visible = false;
                checkchip.Visible = false;
                checkotros.Visible = false;
                txtotros.Visible = false;


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

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtdescripcion.Text == "")
            {

            }
            else
            {
                string upmodelo = txtdescripcion.Text;
                upmodelo = upmodelo.Substring(0, 1).ToUpper() + upmodelo.Substring(1).ToLower();
                txtdescripcion.Text = upmodelo;
                txtdescripcion.SelectionStart = txtdescripcion.Text.Length;
            }
        }

        private void checkprotctor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtmodelo_TextChanged(object sender, EventArgs e)
        {
            if (txtmodelo.Text == "")
            {

            }
            else
            {
                string upmodelo = txtmodelo.Text;
                upmodelo = upmodelo.Substring(0, 1).ToUpper() + upmodelo.Substring(1).ToLower();
                txtmodelo.Text = upmodelo;
                txtmodelo.SelectionStart = txtmodelo.Text.Length;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += imprimir;
            printDocument1.Print();
        }
    }
}
