using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;


namespace pruebafirestore.ABONOS
{
    public partial class garantiadesderevision : Form
    {

        FirestoreDb database;


        string fecha;
        public String Orden = "";

        public String Nombre = "";
        public String Numero = "";
        public String Modelo = "";
        public String Descripcion = "";
        String pedido = "";



        DateTime fechasalida;
        DateTime fechasalida2;
        String fechadesalida = "";

        public garantiadesderevision()
        {
            InitializeComponent();
        }

        private void txtimporte_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtimporte_Leave(object sender, EventArgs e)
        {
           
        }

        private void garantiadesderevision_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"facturasebest2-firebase-adminsdk-rvc9d-2a1a79f585.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            database = FirestoreDb.Create("facturasebest2");
            txtnombre.Text = Nombre;
            txtnombre2.Text = txtnombre.Text;
            txtnumero.Text = Numero;
            txtmodelo.Text = Modelo;
            txtdescripcion.Text = Descripcion;

        }

        private async void altoButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // double precio = Convert.ToDouble(txtcantidad.Text) * Convert.ToDouble(txtimporte.Text);

                double cantidad = Convert.ToDouble(txtimporte.Text);

                if (cantidad > -1 && cantidad < 100)
                {
                    double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                    txtimporte.Text = d.ToString("$      .00", CultureInfo.InvariantCulture);
                }
                else if (cantidad > 99 && cantidad < 1000)
                {
                    double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                    txtimporte.Text = d.ToString("$    .00", CultureInfo.InvariantCulture);
                }
                else if (cantidad > 999 && cantidad < 10000)
                {
                    double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                    txtimporte.Text = d.ToString("$  .00", CultureInfo.InvariantCulture);
                }
                else if (cantidad > 9999 && cantidad < 100000)
                {
                    double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                    txtimporte.Text = d.ToString("$.00", CultureInfo.InvariantCulture);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

            fechasalida = Convert.ToDateTime(fecha);
            fechasalida2 = fechasalida.AddDays(30);
            fechadesalida = fechasalida2.ToShortDateString().ToString();


            sincopia:
            string Name = txtnombre2.Text;
            var rand = new Random();
            pedido = "GARANTIA";
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

            DocumentReference docRef = database.Collection("Garantias").Document(txtorden.Text);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                MessageBox.Show("Repetido");
                goto sincopia;
            }

            else
            {
                DocumentReference cityRef = database.Collection("Revisiones").Document(Orden);
                await cityRef.DeleteAsync();

                DocumentReference DOC = database.Collection("Garantias").Document("contador");
                Dictionary<String, Object> data1 = new Dictionary<string, object>()
                {
                     {"ID", FieldValue.Increment(1)}
                 };
                await DOC.SetAsync(data1, SetOptions.MergeAll);

                DocumentReference docRef2 = database.Collection("Garantias").Document("contador");
                DocumentSnapshot snapsho2 = await docRef2.GetSnapshotAsync();
                if (snapsho2.Exists)
                {
                    Dictionary<string, object> counter = snapsho2.ToDictionary();
                    foreach (var item in counter)
                        lblcontador.Text = string.Format("{1}", item.Key, item.Value);
                }
                // int id = (int)Convert.ToInt64(lblcontador.Text);
                BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
                Codigo.IncludeLabel = true;
                pictureBox2.Image = Codigo.Encode(BarcodeLib.TYPE.CODE128, txtorden.Text, Color.Black, Color.White, 230, 60);

                //Create a Bitmap and draw the DataGridView on it.
               // Bitmap bitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
                //dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

                //Resize DataGridView back to original height.
                //dataGridView1.Height = height;

                //Save the Bitmap to folder.
                //bitmap.Save(@"D:\DataGridView.png");

                //BrotherPrintThis();


                printDocument1 = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                printDocument1.PrinterSettings = ps;
                printDocument1.PrintPage += impresion;
                printDocument1.Print();
                altoButton1.Enabled = false;
                //MessageBox.Show("Finalizado");
                //printPreviewDialog1.Document = printDocument1;
                printDocument1.Print();
                //printDocument1.Print();
                //Add_Document_with_orden();
                altoButton1.Enabled = false;

                button1.Enabled = true;
                this.Close();

            }





        }





        private async void impresion(object sender, PrintPageEventArgs e)
        {
            Image newImage = Properties.Resources.ebestimprimr4;
            int y = 100;

            // Create rectangle for source image.
            RectangleF srcRect = new RectangleF(100.0F, 100.0F, 150.0F, 150.0F);
            e.Graphics.DrawImage(newImage, 30, 2);

            //e.Graphics.DrawImageUnscaledAndClipped(newImage,new Point(10,10));
            e.Graphics.DrawString("           Garantía", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(5, y));
            e.Graphics.DrawString("                                       id: " + lblcontador.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 40));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            e.Graphics.DrawString("                    GUGE900514C70", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 30));
            e.Graphics.DrawString("     Calle Pedro J. Méndez No.1082-A OTE.", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                  Reynosa Tamaulipas", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                             88500", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                         8999222312", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                         8994349816", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                         8991420006", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                  e-best@live.com.mx", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("      Fecha: " + txthorayfecha.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 25));
            e.Graphics.DrawString("      Nombre: " + txtnombre.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("      Numero: " + txtnumero.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            e.Graphics.DrawString("      Modelo: " + txtmarca.Text + " " + txtmodelo.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            

            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
           // e.Graphics.DrawString("    Cant. ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                          Descripción ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y+=20));
            //e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y));
            e.Graphics.DrawString("     "+txtdescripcion.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y+=20));
          //  e.Graphics.DrawString("                          Total ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y + 20));

            //e.Graphics.DrawString("                         " + txtimporte.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y + 20));

            String COSTOFINAL = "";
            Double importe = Convert.ToDouble(txtimporte.Text.Replace("$", ""));

            if (checkiva.Checked == true)
            {
                Double iva = importe * .08;
                String costoiva = iva.ToString();

                if (iva > -1 && iva < 100)
                {
                    double d = Convert.ToDouble(iva, CultureInfo.InvariantCulture);
                    costoiva = d.ToString("$      .00", CultureInfo.InvariantCulture);
                }
                else if (iva > 99 && iva < 1000)
                {
                    double d = Convert.ToDouble(iva, CultureInfo.InvariantCulture);
                    costoiva = d.ToString("$    .00", CultureInfo.InvariantCulture);
                }
                else if (iva > 999 && iva < 10000)
                {
                    double d = Convert.ToDouble(iva, CultureInfo.InvariantCulture);
                    costoiva = d.ToString("$  .00", CultureInfo.InvariantCulture);
                }
                else if (iva > 9999 && iva < 100000)
                {
                    double d = Convert.ToDouble(iva, CultureInfo.InvariantCulture);
                    costoiva = d.ToString("$.00", CultureInfo.InvariantCulture);
                }

                Double costototal = importe + iva;
                 COSTOFINAL = costototal.ToString();

                if (costototal > -1 && costototal < 100)
                {
                    double d = Convert.ToDouble(costototal, CultureInfo.InvariantCulture);
                    COSTOFINAL = d.ToString("$      .00", CultureInfo.InvariantCulture);
                }
                else if (costototal > 99 && costototal < 1000)
                {
                    double d = Convert.ToDouble(costototal, CultureInfo.InvariantCulture);
                    COSTOFINAL = d.ToString("$    .00", CultureInfo.InvariantCulture);
                }
                else if (costototal > 999 && costototal < 10000)
                {
                    double d = Convert.ToDouble(costototal, CultureInfo.InvariantCulture);
                    COSTOFINAL = d.ToString("$  .00", CultureInfo.InvariantCulture);
                }
                else if (costototal > 9999 && costototal < 100000)
                {
                    double d = Convert.ToDouble(costototal, CultureInfo.InvariantCulture);
                    COSTOFINAL = d.ToString("$.00", CultureInfo.InvariantCulture);
                }


                e.Graphics.DrawString("                           SubTotal: " + txtimporte.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 25));

                e.Graphics.DrawString("                                    IVA: " + costoiva, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));

                e.Graphics.DrawString("                                  Total: " + COSTOFINAL, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));
                
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

                e.Graphics.DrawString("           30 días de garantía por defecto de fábrica", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("                  a partir de la fecha de compra.", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

                e.Graphics.DrawString("             ¿Qué es lo que no cubre garantía?", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       La presente garantía no es aplicable: a cualquier", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       daño causado por accidente, mal uso, contacto por ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       liquido, incendio, o cualquier otra causa externa.", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       A cualquier daño derivado de los servicios ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       (de reparación,actualización o mejoras) realizadas ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       por un tercero que no sea un representante", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       de E-BEST. ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));


                //e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 25));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawImage(pictureBox2.Image, 40, y += 30);
                //TOTALFINAL = ivatotal;
            }
            else if (checkiva.Checked == false)
            {

                e.Graphics.DrawString("                                 Total: " + txtimporte.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 25));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));


                e.Graphics.DrawString("           30 días de garantía por defecto de fábrica", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("                  a partir de la fecha de compra.", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

                e.Graphics.DrawString("             ¿Qué es lo que no cubre garantía?", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       La presente garantía no es aplicable: a cualquier", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       daño causado por accidente, mal uso, contacto por ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       liquido, incendio, o cualquier otra causa externa.", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       A cualquier daño derivado de los servicios ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       (de reparación,actualización o mejoras) realizadas ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       por un tercero que no sea un representante", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       de E-BEST. ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));




                // e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 25));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawImage(pictureBox2.Image, 40, y += 30);
                //TOTALFINAL = preciototal;
                COSTOFINAL = txtimporte.Text;

            }
            int id = (int)Convert.ToInt64(lblcontador.Text);
            DocumentReference DOC2 = database.Collection("Garantias").Document(txtorden.Text);
            Dictionary<String, Object> data2 = new Dictionary<string, object>()
                {
                 {"ID", id},

                {"Orden", txtorden.Text},

                {"Nombre",txtnombre.Text},

                {"Numero",txtnumero.Text},

                {"Modelo",txtmodelo.Text},

               

                {"Descripcion",txtdescripcion.Text},

                
                {"Total", COSTOFINAL},


                {"Fechayhora",txthorayfecha.Text},

                {"Fechasalida", fechadesalida},

                };
            await DOC2.SetAsync(data2, SetOptions.MergeAll);
            MessageBox.Show("guardado");
        }






        private void impresion2(object sender, PrintPageEventArgs e)
        {
            Image newImage = Properties.Resources.ebestimprimr4;
            int y = 100;

            // Create rectangle for source image.
            RectangleF srcRect = new RectangleF(100.0F, 100.0F, 150.0F, 150.0F);
            e.Graphics.DrawImage(newImage, 30, 2);

            //e.Graphics.DrawImageUnscaledAndClipped(newImage,new Point(10,10));
            e.Graphics.DrawString("           Garantía", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(5, y));
            e.Graphics.DrawString("                                       id: " + lblcontador.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 40));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            e.Graphics.DrawString("                    GUGE900514C70", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 30));
            e.Graphics.DrawString("     Calle Pedro J. Méndez No.1082-A OTE.", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                  Reynosa Tamaulipas", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                             88500", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                         8999222312", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                         8994349816", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                         8991420006", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                  e-best@live.com.mx", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("      Fecha: " + txthorayfecha.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 25));
            e.Graphics.DrawString("      Nombre: " + txtnombre.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("      Numero: " + txtnumero.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            e.Graphics.DrawString("      Modelo: " + txtmarca.Text + " " + txtmodelo.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));



            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            // e.Graphics.DrawString("    Cant. ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                          Descripción ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));
            //e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y));
            e.Graphics.DrawString("     " + txtdescripcion.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));
            //  e.Graphics.DrawString("                          Total ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y + 20));

            //e.Graphics.DrawString("                         " + txtimporte.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y + 20));

            String COSTOFINAL = "";
            Double importe = Convert.ToDouble(txtimporte.Text.Replace("$", ""));

            if (checkiva.Checked == true)
            {
                Double iva = importe * .08;
                String costoiva = iva.ToString();

                if (iva > -1 && iva < 100)
                {
                    double d = Convert.ToDouble(iva, CultureInfo.InvariantCulture);
                    costoiva = d.ToString("$      .00", CultureInfo.InvariantCulture);
                }
                else if (iva > 99 && iva < 1000)
                {
                    double d = Convert.ToDouble(iva, CultureInfo.InvariantCulture);
                    costoiva = d.ToString("$    .00", CultureInfo.InvariantCulture);
                }
                else if (iva > 999 && iva < 10000)
                {
                    double d = Convert.ToDouble(iva, CultureInfo.InvariantCulture);
                    costoiva = d.ToString("$  .00", CultureInfo.InvariantCulture);
                }
                else if (iva > 9999 && iva < 100000)
                {
                    double d = Convert.ToDouble(iva, CultureInfo.InvariantCulture);
                    costoiva = d.ToString("$.00", CultureInfo.InvariantCulture);
                }

                Double costototal = importe + iva;
                COSTOFINAL = costototal.ToString();

                if (costototal > -1 && costototal < 100)
                {
                    double d = Convert.ToDouble(costototal, CultureInfo.InvariantCulture);
                    COSTOFINAL = d.ToString("$      .00", CultureInfo.InvariantCulture);
                }
                else if (costototal > 99 && costototal < 1000)
                {
                    double d = Convert.ToDouble(costototal, CultureInfo.InvariantCulture);
                    COSTOFINAL = d.ToString("$    .00", CultureInfo.InvariantCulture);
                }
                else if (costototal > 999 && costototal < 10000)
                {
                    double d = Convert.ToDouble(costototal, CultureInfo.InvariantCulture);
                    COSTOFINAL = d.ToString("$  .00", CultureInfo.InvariantCulture);
                }
                else if (costototal > 9999 && costototal < 100000)
                {
                    double d = Convert.ToDouble(costototal, CultureInfo.InvariantCulture);
                    COSTOFINAL = d.ToString("$.00", CultureInfo.InvariantCulture);
                }


                e.Graphics.DrawString("                           SubTotal: " + txtimporte.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 25));

                e.Graphics.DrawString("                                    IVA: " + costoiva, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));

                e.Graphics.DrawString("                                  Total: " + COSTOFINAL, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));

                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

                e.Graphics.DrawString("           30 días de garantía por defecto de fábrica", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("                  a partir de la fecha de compra.", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

                e.Graphics.DrawString("             ¿Qué es lo que no cubre garantía?", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       La presente garantía no es aplicable: a cualquier", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       daño causado por accidente, mal uso, contacto por ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       liquido, incendio, o cualquier otra causa externa.", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       A cualquier daño derivado de los servicios ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       (de reparación,actualización o mejoras) realizadas ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       por un tercero que no sea un representante", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       de E-BEST. ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));


                //e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 25));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawImage(pictureBox2.Image, 40, y += 30);
                //TOTALFINAL = ivatotal;
            }
            else if (checkiva.Checked == false)
            {

                e.Graphics.DrawString("                                 Total: " + txtimporte.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 25));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));


                e.Graphics.DrawString("           30 días de garantía por defecto de fábrica", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("                  a partir de la fecha de compra.", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

                e.Graphics.DrawString("             ¿Qué es lo que no cubre garantía?", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       La presente garantía no es aplicable: a cualquier", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       daño causado por accidente, mal uso, contacto por ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       liquido, incendio, o cualquier otra causa externa.", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       A cualquier daño derivado de los servicios ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       (de reparación,actualización o mejoras) realizadas ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       por un tercero que no sea un representante", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("       de E-BEST. ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));




                // e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 25));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawImage(pictureBox2.Image, 40, y += 30);
                //TOTALFINAL = preciototal;
                COSTOFINAL = txtimporte.Text;

            }
           
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            fecha = DateTime.Now.ToShortDateString();
            string hora = DateTime.Now.ToShortTimeString();

            txthorayfecha.Text = fecha + " " + hora;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += impresion2;
            printDocument1.Print();
        }
    }
}
