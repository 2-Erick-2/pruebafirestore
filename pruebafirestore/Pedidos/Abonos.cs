using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing.Printing;
using Google.Cloud.Firestore;


namespace pruebafirestore.Pedidos
{
    public partial class Abonos : Form
    {
        FirestoreDb database;


        String contar;

        public String cant = "";
        public String cant2 = "";
        public String cant3 = "";
        public String cant4 = "";
        public String cant5 = "";

        public String descri = "";
        public String descri2 = "";
        public String descri3 = "";
        public String descri4 = "";
        public String descri5 = "";


        public String impor = "";
        public String impor2 = "";
        public String impor3 = "";
        public String impor4 = "";
        public String impor5 = "";

        public String Abono = "";
        public String Abono2 = "";
        public String Abono3 = "";
        public String Abono4 = "";
        public String Abono5 = "";


        public String fechayhora = "";

        public String fechayhora2 = "";
        public String fechayhora3 = "";
        public String fechayhora4 = "";
        public String fechayhora5 = "";
        //public String Abono5 = "";
        public String total = "";
        public String Restante = "";

        public String Nombre = "";
        public String Modelo = "";
        public String Orden = "";




        public Abonos()
        {
            InitializeComponent();
        }

        private void Abonos_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"facturasebest2-firebase-adminsdk-rvc9d-2a1a79f585.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            database = FirestoreDb.Create("facturasebest2");


            txttotal.Text = total;
            txtrestante.Text = Restante;
            dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.LightYellow;


            dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.LightBlue;




            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            //dataGridView1.Columns[0].Width = 1500;
            dataGridView1.Rows[0].Selected = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtabono.Text != "" && dataGridView1.Rows.Count <= 4)
            {
                if (dataGridView1.Rows.Count == 1)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dataGridView1);
 
                    fila.Cells[0].Value = txtabono.Text;
                    fila.Cells[1].Value = txthorayfecha.Text;
                    Abono2 = txtabono.Text;
                    fechayhora2 = txthorayfecha.Text;

                    dataGridView1.Rows.Add(fila);

                    double p1 = Convert.ToDouble(dataGridView1.Rows[1].Cells[0].Value.ToString().Replace("$", ""));

                    double restantedesdemov = Convert.ToDouble(txtrestante.Text.Replace("$", ""));

                    Double resultado = restantedesdemov - p1;
                    if (resultado == 0)
                    {
                        altoButton1.Text = "Generar Garantia";
                        altoButton1.Enabled = true;
                    }
                    else if(resultado > 0)
                    {
                        altoButton1.Text = "Generar Abono";
                        altoButton1.Enabled = true;

                    }

                    txtrestante.Text = resultado.ToString();

                    double p2 = Convert.ToDouble(dataGridView1.Rows[0].Cells[0].Value.ToString().Replace("$", ""));
                    double p3 = Convert.ToDouble(dataGridView1.Rows[1].Cells[0].Value.ToString().Replace("$", ""));

                    Double suma = p2 + p3;
                    txtabonos.Text = suma.ToString();

                    txtabono.Text = "";
                }
                else if (dataGridView1.Rows.Count == 2)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dataGridView1);
                    //fila.Cells[0].Value = txtcantidad.Text;
                    fila.Cells[0].Value = txtabono.Text;
                    fila.Cells[1].Value = txthorayfecha.Text;
                    Abono3 = txtabono.Text;
                    fechayhora3 = txthorayfecha.Text;

                    dataGridView1.Rows.Add(fila);

                    double p2 = Convert.ToDouble(dataGridView1.Rows[0].Cells[0].Value.ToString().Replace("$", ""));
                    double p3 = Convert.ToDouble(dataGridView1.Rows[1].Cells[0].Value.ToString().Replace("$", ""));
                    double p4 = Convert.ToDouble(dataGridView1.Rows[2].Cells[0].Value.ToString().Replace("$", ""));

                    Double suma = p2 + p3 + p4;
                    Double sumasinp2 = p3 + p4;
                    txtabonos.Text = suma.ToString();

                    double restantedesdemov = Convert.ToDouble(txtrestante.Text.Replace("$", ""));

                    Double resultado = restantedesdemov - p4;
                    if (resultado == 0)
                    {
                        altoButton1.Text = "Generar Garantia";
                        altoButton1.Enabled = true;
                    }
                    else if (resultado > 0)
                    {
                        altoButton1.Text = "Generar Abono";
                        altoButton1.Enabled = true;

                    }

                    txtrestante.Text = resultado.ToString();

                    txtabono.Text = "";
                }

                else if (dataGridView1.Rows.Count == 3)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dataGridView1);
                    //fila.Cells[0].Value = txtcantidad.Text;
                    fila.Cells[0].Value = txtabono.Text;
                    fila.Cells[1].Value = txthorayfecha.Text;
                    Abono4 = txtabono.Text;
                    fechayhora4 = txthorayfecha.Text;

                    dataGridView1.Rows.Add(fila);

                    double p2 = Convert.ToDouble(dataGridView1.Rows[0].Cells[0].Value.ToString().Replace("$", ""));
                    double p3 = Convert.ToDouble(dataGridView1.Rows[1].Cells[0].Value.ToString().Replace("$", ""));
                    double p4 = Convert.ToDouble(dataGridView1.Rows[2].Cells[0].Value.ToString().Replace("$", ""));
                    double p5 = Convert.ToDouble(dataGridView1.Rows[3].Cells[0].Value.ToString().Replace("$", ""));


                    Double suma = p2 + p3 + p4 + p5;
                    Double sumasinp2 = p3 + p4 + p5;

                    txtabonos.Text = suma.ToString();

                    double restantedesdemov = Convert.ToDouble(txtrestante.Text.Replace("$", ""));
                   // MessageBox.Show(restantedesdemov.ToString());

                    Double resultado = restantedesdemov - p5;
                    if (resultado == 0)
                    {
                        altoButton1.Text = "Generar Garantia";
                        altoButton1.Enabled = true;
                    }
                    else if (resultado > 0)
                    {
                        altoButton1.Text = "Generar Abono";
                        altoButton1.Enabled = true;

                    }

                    txtrestante.Text = resultado.ToString();

                    txtabono.Text = "";
                }



                else if (dataGridView1.Rows.Count == 4)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dataGridView1);
                    //fila.Cells[0].Value = txtcantidad.Text;
                    fila.Cells[0].Value = txtabono.Text;
                    fila.Cells[1].Value = txthorayfecha.Text;
                    Abono5 = txtabono.Text;
                    fechayhora5 = txthorayfecha.Text;

                    dataGridView1.Rows.Add(fila);

                    double p2 = Convert.ToDouble(dataGridView1.Rows[0].Cells[0].Value.ToString().Replace("$", ""));
                    double p3 = Convert.ToDouble(dataGridView1.Rows[1].Cells[0].Value.ToString().Replace("$", ""));
                    double p4 = Convert.ToDouble(dataGridView1.Rows[2].Cells[0].Value.ToString().Replace("$", ""));
                    double p5 = Convert.ToDouble(dataGridView1.Rows[3].Cells[0].Value.ToString().Replace("$", ""));
                    double p6 = Convert.ToDouble(dataGridView1.Rows[4].Cells[0].Value.ToString().Replace("$", ""));


                    Double suma = p2 + p3 + p4 + p5 + p6;
                    Double sumasinp2 = p3 + p4 + p5 + p6;
                    txtabonos.Text = suma.ToString();

                    double restantedesdemov = Convert.ToDouble(txtrestante.Text.Replace("$", ""));

                    Double resultado = restantedesdemov - p6;
                    if (resultado == 0)
                    {
                        altoButton1.Text = "Generar Garantia";
                        altoButton1.Enabled = true;
                    }
                    else if (resultado > 0)
                    {
                        altoButton1.Text = "Generar Abono";
                        altoButton1.Enabled = true;

                    }

                    txtrestante.Text = resultado.ToString();

                    txtabono.Text = "";
                }






            }
            else
            {
                MessageBox.Show("Te faltan valores por ingresar o llegaste al numero maximo de productos");
            }
        }

        private void txtabono_Leave(object sender, EventArgs e)
        {
            try
            {
                contar = txtabono.Text;
                if (contar.Length == 4)
                {
                    double d = Convert.ToDouble(txtabono.Text, CultureInfo.InvariantCulture);
                    txtabono.Text = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 3)
                {
                    double d = Convert.ToDouble(txtabono.Text, CultureInfo.InvariantCulture);
                    txtabono.Text = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 2)
                {
                    double d = Convert.ToDouble(txtabono.Text, CultureInfo.InvariantCulture);
                    txtabono.Text = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 6)
                {
                    double d = Convert.ToDouble(txtabono.Text, CultureInfo.InvariantCulture);
                    txtabono.Text = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 5)
                {
                    double d = Convert.ToDouble(txtabono.Text, CultureInfo.InvariantCulture);
                    txtabono.Text = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void txtabono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtabono_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void txtrestante_TextChanged(object sender, EventArgs e)
        {
            try
            {


                contar = txtrestante.Text;
                if (contar.Length == 4)
                {
                    double d = Convert.ToDouble(txtrestante.Text, CultureInfo.InvariantCulture);
                    txtrestante.Text = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 3)
                {
                    double d = Convert.ToDouble(txtrestante.Text, CultureInfo.InvariantCulture);
                    txtrestante.Text = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 2)
                {
                    double d = Convert.ToDouble(txtrestante.Text, CultureInfo.InvariantCulture);
                    txtrestante.Text = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 6)
                {
                    double d = Convert.ToDouble(txtrestante.Text, CultureInfo.InvariantCulture);
                    txtrestante.Text = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 5)
                {
                    double d = Convert.ToDouble(txtrestante.Text, CultureInfo.InvariantCulture);
                    txtrestante.Text = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToShortDateString();
            string hora = DateTime.Now.ToShortTimeString();
            txthorayfecha.Text = fecha + " " + hora;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void altoButton1_Click(object sender, EventArgs e)
        {

            guardarabono();
            printDocument1 = new PrintDocument();

            PrinterSettings ps = new PrinterSettings();

            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += imprimir;
            printDocument1.Print();


        }



        private async void guardarabono()
        {
            WriteBatch batch = database.StartBatch();


            DocumentReference DOC2 = database.Collection("Pedidos").Document(Orden);
            Dictionary<String, Object> data2 = new Dictionary<string, object>()
            {
                 {"Abono2",Abono2},
                 {"Fechayhora2",fechayhora2},

                 {"Abono3",Abono3},
                 {"Fechayhora3",fechayhora3},

                 {"Abono4",Abono4},
                 {"Fechayhora4",fechayhora4},

                 {"Abono5",Abono5},
                 {"Fechayhora5",fechayhora5}
             };
            batch.Set(DOC2,data2, SetOptions.MergeAll);


            DocumentReference sfRef = database.Collection("Pedidos").Document(Orden);
            Dictionary<string, object> updates = new Dictionary<string, object>
            {
                { "Restante", txtrestante.Text}
            };
            batch.Update(sfRef, updates);

            await batch.CommitAsync();



            //await DOC2.SetAsync(data2, SetOptions.MergeAll);
            MessageBox.Show("guardado");
        }





        private void imprimir(object sender, PrintPageEventArgs e)
        {
            //Image newImage3 = Image.FromFile(@"D:\TODO\ebestimprimr4.jpg");
            Image newImage = Properties.Resources.ebestimprimr4;


            //printDocument1.PrinterSettings.PrinterName = "TM-T20II";

            // Create rectangle for source image.
            RectangleF srcRect = new RectangleF(100.0F, 100.0F, 150.0F, 150.0F);
            e.Graphics.DrawImage(newImage, 30, 2);

            //e.Graphics.DrawImageUnscaledAndClipped(newImage,new Point(10,10));
            e.Graphics.DrawString("      Recibo de pago", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(5, 100));
          //  e.Graphics.DrawString("                                       id: " + lblcontador.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, 140));

            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 150));
            e.Graphics.DrawString("                    GUGE900514C70", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 180));
            e.Graphics.DrawString("     Calle Pedro J. Méndez No.1082-A OTE.", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 200));
            e.Graphics.DrawString("                  Reynosa Tamaulipas", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 220));
            e.Graphics.DrawString("                             88500", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 240));
            e.Graphics.DrawString("                  e-best@live.com.mx", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 260));
            e.Graphics.DrawString("                         8999222312", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 280));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 300));
            e.Graphics.DrawString("      Fecha: " + txthorayfecha.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 330));
            e.Graphics.DrawString("      Nombre: " + Nombre, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 350));
            e.Graphics.DrawString("      Modelo: " + Modelo, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 370));
            
            
            e.Graphics.DrawString("      Orden: " + Orden, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 390));

            
           
            
           //e.Graphics.DrawString("      Tiempo de espera: " + combohoras.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 390));

            
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 410));

             e.Graphics.DrawString("                    Abono acreditado ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 435));

            e.Graphics.DrawString("                           " + txtabonos.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 455));

            e.Graphics.DrawString("                    Restante a liquidar ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 475));

            e.Graphics.DrawString("                           " + txtrestante.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 495));


            // e.Graphics.DrawString("               Orden: " + txtorden.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 435));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 510));
            //e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 475));
            //e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 490));
           // e.Graphics.DrawImage(pictureBox2.Image, 40, 520);

        }

        private void txtabonos_TextChanged(object sender, EventArgs e)
        {
            try
            {


                contar = txtabonos.Text;
                if (contar.Length == 4)
                {
                    double d = Convert.ToDouble(txtabonos.Text, CultureInfo.InvariantCulture);
                    txtabonos.Text = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 3)
                {
                    double d = Convert.ToDouble(txtabonos.Text, CultureInfo.InvariantCulture);
                    txtabonos.Text = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 2)
                {
                    double d = Convert.ToDouble(txtabonos.Text, CultureInfo.InvariantCulture);
                    txtabonos.Text = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 6)
                {
                    double d = Convert.ToDouble(txtabonos.Text, CultureInfo.InvariantCulture);
                    txtabonos.Text = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 5)
                {
                    double d = Convert.ToDouble(txtabonos.Text, CultureInfo.InvariantCulture);
                    txtabonos.Text = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
