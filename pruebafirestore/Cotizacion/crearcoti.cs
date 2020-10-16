using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.SqlServer.Server;
using System.Globalization;
using BarcodeLib;


namespace pruebafirestore.Cotizacion
{
    public partial class crearcoti : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        String tipoproducto = "";

        String contar;

        String pedido = "";
        String preciofinal;



        public crearcoti()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \\EBEST-AB78DLU\ebest\Ebest_be.accdb; Persist Security Info=False;";

        }

        private void button1_Click(object sender, EventArgs e)
        {

           

            
            if (txtcantidad.Text != "" && txtdescri.Text != "" && txtimporte.Text != "" && dataGridView1.Rows.Count <=4)
            {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = txtcantidad.Text;
            fila.Cells[1].Value = txtdescri.Text;
            fila.Cells[2].Value = txtimporte.Text;
            fila.Cells[3].Value = preciofinal;


                dataGridView1.Rows.Add(fila);
            txtcantidad.Text = "";
            txtdescri.Text = "";
            txtimporte.Text = "";
            }
            else
            {
                MessageBox.Show("Te faltan valores por ingresar o llegaste al numero maximo de productos");
            }
           /* try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                    command.CommandText = "insert into productos (Cantidad,Descripcion,Importe) values ('" + txtcantidad.Text + "','" + txtdescri.Text + "','" + txtimporte.Text + "')";
                    command.ExecuteNonQuery();
                connection.Close();
                //MessageBox.Show("Cliente guardado");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            crearcoti_Load(sender, e);*/
        }

        private void crearcoti_Load(object sender, EventArgs e)
        {
            combodias.Text = "1 día";
            combohoras.Text = "1 hora";
            ///dataGridView1.Columns[2].DefaultCellStyle.Format = "C";
           /* try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT productos.[Cantidad], productos.[Descripcion], productos.[Importe] FROM productos; ";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                string query2 = "SELECT * FROM productos; ";
                command.CommandText = query2;

                OleDbDataAdapter da2 = new OleDbDataAdapter(command);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView2.DataSource = dt2;




                connection.Close();

                dataGridView1.RowHeadersVisible = false;


                dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.White;
                dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.LightYellow;

                dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.White;
                dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.LightBlue;

                dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.White;
                dataGridView1.Columns[2].DefaultCellStyle.BackColor = Color.LightBlue;

           


                dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
                dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }*/
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            //

          /*  if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                DataGridViewRow row2 = this.dataGridView2.Rows[e.RowIndex];

                if (e.ColumnIndex == 0)
                {
                    tipoproducto = "Cantidad";
                    // lbltipoproductop.Text = tipoproducto;

                   label9.Text =     dataGridView1.Rows.Count.ToString();
                    lbltipoproductop.Text = row2.Cells["id"].Value.ToString();
                    txteditable.Text = row.Cells["Cantidad"].Value.ToString();
                }
                else if (e.ColumnIndex == 1)
                {
                    tipoproducto = "Descripcion";
                    lbltipoproductop.Text = tipoproducto;
                    lbltipoproductop.Text = row2.Cells["id"].Value.ToString();

                    txteditable.Text = row.Cells["Descripcion"].Value.ToString();

                }
                else if (e.ColumnIndex == 2)
                {
                    tipoproducto = "Importe";
                    lbltipoproductop.Text = tipoproducto;
                    lbltipoproductop.Text = row2.Cells["id"].Value.ToString();

                    txteditable.Text = row.Cells["Importe"].Value.ToString();

                }*/
                //txtmodelo.Text = row.Cells["modelo"].Value.ToString();


            }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            //dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void txtimporte_TextChanged(object sender, EventArgs e)
        {
            
            //txtimporte.Text = Format.Native.ToString("G");
        }

        private void txtimporte_Leave(object sender, EventArgs e)
        {    
            try
            {
                Double precio = Convert.ToDouble(txtcantidad.Text) * Convert.ToDouble(txtimporte.Text);
                preciofinal = precio.ToString();
                String contar2 = preciofinal;

                contar = txtimporte.Text;
                if (contar.Length == 4)
                {
                    double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                    txtimporte.Text = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 3)
                {
                    double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                    txtimporte.Text = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 2)
                {
                    double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                    txtimporte.Text = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 6)
                {
                    double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                    txtimporte.Text = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 5)
                {
                    double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                    txtimporte.Text = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }


                if (contar2.Length == 4)
                {
                    double d = Convert.ToDouble(preciofinal, CultureInfo.InvariantCulture);
                    preciofinal = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar2.Length == 3)
                {
                    double d = Convert.ToDouble(preciofinal, CultureInfo.InvariantCulture);
                    preciofinal = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }
                else if (contar2.Length == 2)
                {
                    double d = Convert.ToDouble(preciofinal, CultureInfo.InvariantCulture);
                    preciofinal = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                }
                else if (contar2.Length == 6)
                {
                    double d = Convert.ToDouble(preciofinal, CultureInfo.InvariantCulture);
                    preciofinal = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar2.Length == 5)
                {
                    double d = Convert.ToDouble(preciofinal, CultureInfo.InvariantCulture);
                    preciofinal = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            sincopia:
            string Name = txtnombre2.Text;
            var rand = new Random();
            pedido = "COtizacion";
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
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from revisiones Where orden like ('" + txtorden.Text + "')";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtrepetidos.Text = Convert.ToString(reader["orden"]);


                    reader.Close();

                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }



            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel = true;
            pictureBox2.Image = Codigo.Encode(BarcodeLib.TYPE.CODE128, txtorden.Text, Color.Black, Color.White, 230, 60);


            printPreviewDialog1.Document = printDocument1;
            //printDocument1.Print();
           // printDocument1.Print();
            printPreviewDialog1.Show();


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image newImage = Image.FromFile(@"\\EBEST-AB78DLU\ebest\ebestimprimr4.jpg");


            printDocument1.PrinterSettings.PrinterName = "TM-T20II";

            // Create rectangle for source image.
            RectangleF srcRect = new RectangleF(100.0F, 100.0F, 150.0F, 150.0F);
            e.Graphics.DrawImage(newImage, 30, 2);

            //e.Graphics.DrawImageUnscaledAndClipped(newImage,new Point(10,10));
            e.Graphics.DrawString("  Equipo en  cotización", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(5, 100));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 150));
            e.Graphics.DrawString("                    GUGE900514C70", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 180));
            e.Graphics.DrawString("     Calle Pedro J. Méndez No.1082-A OTE.", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 200));
            e.Graphics.DrawString("                  Reynosa Tamaulipas", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 220));
            e.Graphics.DrawString("                             88500", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 240));
            e.Graphics.DrawString("                  e-best@live.com.mx", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 260));
            e.Graphics.DrawString("                         8999222312", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 280));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 300));
            e.Graphics.DrawString("      Fecha: " + label10.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 330));
            e.Graphics.DrawString("      Nombre: " + txtnombre.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 350));
            e.Graphics.DrawString("      Modelo: " + txtmarca.Text+" "+txtmodelo.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 370));

            if (checkrespuesta.Checked == true && checkBox2.Checked == true)
            {
                e.Graphics.DrawString("      Tiempo de espera: " + combodias.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 390));

            }
            else if (checkrespuesta.Checked == true && checkBox1.Checked == true)
            {
                e.Graphics.DrawString("      Tiempo de espera: " + combohoras.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 390));

            }

            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 405));



            if (checkiva.Checked == false)
            {

                if (dataGridView1.Rows.Count == 1)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                            Total: " + p3, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 500));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 520));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 545));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 565));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 595);
                }

                if (dataGridView1.Rows.Count == 2)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6);

                    String contar2 = total.ToString();
                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }







                    e.Graphics.DrawString("                                            Total: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 520));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 540));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 565));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 585));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 615);



                }

                if (dataGridView1.Rows.Count == 3)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    String p7 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();
                    String p8 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();
                    String p9 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString();

                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    e.Graphics.DrawString("           " + p8, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                            " + p7, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                                                      " + p9, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));




                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    p9 = p9.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6) + Convert.ToDouble(p9);

                    String contar2 = total.ToString();
                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }







                    e.Graphics.DrawString("                                            Total: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 540));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 560));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 585));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 605));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 635);



                }


                if (dataGridView1.Rows.Count == 4)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    String p7 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();
                    String p8 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();
                    String p9 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString();

                    String p10 = dataGridView1.Rows[3].Cells["Descripcion"].Value.ToString();
                    String p11 = dataGridView1.Rows[3].Cells["Cantidad"].Value.ToString();
                    String p12 = dataGridView1.Rows[3].Cells["Importe"].Value.ToString();


                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    e.Graphics.DrawString("           " + p8, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                            " + p7, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                                                      " + p9, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));

                    e.Graphics.DrawString("           " + p11, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                            " + p10, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                                                      " + p12, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));


                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    p9 = p9.Replace("$", "");
                    p12 = p12.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6) + Convert.ToDouble(p9) + Convert.ToDouble(p12);
                    String contar2 = total.ToString();
                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }







                    e.Graphics.DrawString("                                            Total: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 560));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 580));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 605));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 625));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 655);



                }


                if (dataGridView1.Rows.Count == 5)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    String p7 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();
                    String p8 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();
                    String p9 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString();

                    String p10 = dataGridView1.Rows[3].Cells["Descripcion"].Value.ToString();
                    String p11 = dataGridView1.Rows[3].Cells["Cantidad"].Value.ToString();
                    String p12 = dataGridView1.Rows[3].Cells["Importe"].Value.ToString();

                    String p13 = dataGridView1.Rows[4].Cells["Descripcion"].Value.ToString();
                    String p14 = dataGridView1.Rows[4].Cells["Cantidad"].Value.ToString();
                    String p15 = dataGridView1.Rows[4].Cells["Importe"].Value.ToString();


                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    e.Graphics.DrawString("           " + p8, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                            " + p7, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                                                      " + p9, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));

                    e.Graphics.DrawString("           " + p11, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                            " + p10, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                                                      " + p12, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));

                    e.Graphics.DrawString("           " + p14, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));
                    e.Graphics.DrawString("                            " + p13, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));
                    e.Graphics.DrawString("                                                      " + p15, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));


                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    p9 = p9.Replace("$", "");
                    p12 = p12.Replace("$", "");
                    p15 = p15.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6) + Convert.ToDouble(p9) + Convert.ToDouble(p12) + Convert.ToDouble(p15);
                    String contar2 = total.ToString();
                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }







                    e.Graphics.DrawString("                                            Total: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 580));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 600));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 625));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 645));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 675);



                }


            }
            else if (checkiva.Checked == true)


            {
                if (dataGridView1.Rows.Count == 1)
                {


                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();


                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                     SubTotal: " + p3, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 500));

                    p3 = p3.Replace("$", "");

                    Double total = Convert.ToDouble(p3) * .08;
                    String contar2 = total.ToString();


                    Double total2 = Convert.ToDouble(contar2) + Convert.ToDouble(p3);
                    String contar3 = total2.ToString();
                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(total, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(total, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }



                    if (contar3.Length == 4)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 3)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 2)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 6)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 5)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }




                    e.Graphics.DrawString("                                              IVA: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 520));



                    e.Graphics.DrawString("                                            Total: " + contar3, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 540));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 560));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 585));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 605));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 635);
                }

                if (dataGridView1.Rows.Count == 2)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6);
                    String contar2 = total.ToString();

                    Double total2 = total * .08;
                    String contar3 = total2.ToString();

                    Double total3 = total + total2;
                    String contar4 = total3.ToString();


                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }


                    if (contar3.Length == 4)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 3)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 2)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 6)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 5)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }



                    if (contar4.Length == 4)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 3)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 2)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 6)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 5)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }




                    e.Graphics.DrawString("                                     SubTotal: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 520));
                    e.Graphics.DrawString("                                              IVA: " + contar3, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 540));



                    e.Graphics.DrawString("                                            Total: " + contar4, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 560));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 580));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 605));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 625));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 655);



                }

                if (dataGridView1.Rows.Count == 3)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    String p7 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();
                    String p8 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();
                    String p9 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString();

                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    e.Graphics.DrawString("           " + p8, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                            " + p7, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                                                      " + p9, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));




                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    p9 = p9.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6) + Convert.ToDouble(p9);
                    String contar2 = total.ToString();


                    Double total2 = total * .08;
                    String contar3 = total2.ToString();

                    Double total3 = total + total2;
                    String contar4 = total3.ToString();




                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }


                    if (contar3.Length == 4)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 3)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 2)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 6)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 5)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }



                    if (contar4.Length == 4)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 3)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 2)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 6)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 5)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }






                    e.Graphics.DrawString("                                     SubTotal: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 540));

                    e.Graphics.DrawString("                                              IVA: " + contar3, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 560));


                    e.Graphics.DrawString("                                            Total: " + contar4, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 580));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 600));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 625));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 645));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 675);



                }


                if (dataGridView1.Rows.Count == 4)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    String p7 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();
                    String p8 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();
                    String p9 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString();

                    String p10 = dataGridView1.Rows[3].Cells["Descripcion"].Value.ToString();
                    String p11 = dataGridView1.Rows[3].Cells["Cantidad"].Value.ToString();
                    String p12 = dataGridView1.Rows[3].Cells["Importe"].Value.ToString();


                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    e.Graphics.DrawString("           " + p8, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                            " + p7, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                                                      " + p9, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));

                    e.Graphics.DrawString("           " + p11, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                            " + p10, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                                                      " + p12, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));


                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    p9 = p9.Replace("$", "");
                    p12 = p12.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6) + Convert.ToDouble(p9) + Convert.ToDouble(p12);
                    String contar2 = total.ToString();


                    Double total2 = total * .08;
                    String contar3 = total2.ToString();

                    Double total3 = total + total2;
                    String contar4 = total3.ToString();




                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }


                    if (contar3.Length == 4)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 3)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 2)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 6)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 5)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }



                    if (contar4.Length == 4)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 3)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 2)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 6)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 5)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }





                    e.Graphics.DrawString("                                     SubTotal: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 560));

                    e.Graphics.DrawString("                                              IVA: " + contar3, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 580));


                    e.Graphics.DrawString("                                            Total: " + contar4, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 600));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 620));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 645));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 665));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 695);



                }


                if (dataGridView1.Rows.Count == 5)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    String p7 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();
                    String p8 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();
                    String p9 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString();

                    String p10 = dataGridView1.Rows[3].Cells["Descripcion"].Value.ToString();
                    String p11 = dataGridView1.Rows[3].Cells["Cantidad"].Value.ToString();
                    String p12 = dataGridView1.Rows[3].Cells["Importe"].Value.ToString();

                    String p13 = dataGridView1.Rows[4].Cells["Descripcion"].Value.ToString();
                    String p14 = dataGridView1.Rows[4].Cells["Cantidad"].Value.ToString();
                    String p15 = dataGridView1.Rows[4].Cells["Importe"].Value.ToString();


                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    e.Graphics.DrawString("           " + p8, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                            " + p7, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                                                      " + p9, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));

                    e.Graphics.DrawString("           " + p11, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                            " + p10, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                                                      " + p12, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));

                    e.Graphics.DrawString("           " + p14, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));
                    e.Graphics.DrawString("                            " + p13, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));
                    e.Graphics.DrawString("                                                      " + p15, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));


                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    p9 = p9.Replace("$", "");
                    p12 = p12.Replace("$", "");
                    p15 = p15.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6) + Convert.ToDouble(p9) + Convert.ToDouble(p12) + Convert.ToDouble(p15);
                    String contar2 = total.ToString();

                    Double total2 = total * .08;
                    String contar3 = total2.ToString();

                    Double total3 = total + total2;
                    String contar4 = total3.ToString();


                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }




                    if (contar3.Length == 4)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 3)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 2)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 6)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 5)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }



                    if (contar4.Length == 4)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 3)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 2)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 6)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 5)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }



                    e.Graphics.DrawString("                                     SubTotal: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 580));

                    e.Graphics.DrawString("                                              IVA: " + contar3, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 600));


                    e.Graphics.DrawString("                                            Total: " + contar4, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 620));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 640));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 665));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 685));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 715);



                }
            }




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToShortDateString();
            string hora = DateTime.Now.ToShortTimeString();
            label10.Text = fecha + " " + hora;
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

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void checkrespuesta_CheckedChanged(object sender, EventArgs e)
        {
            if(checkrespuesta.Checked == true)
            {
                checkBox2.Visible = true;
                combodias.Visible = true;
                checkBox1.Visible = true;
                combohoras.Visible = true;
            }
            else if (checkrespuesta.Checked == false)
            {
                checkBox2.Visible = false;
                combodias.Visible = false;
                checkBox1.Visible = false;
                combohoras.Visible = false;
            }
        }

        private void checkdias_CheckedChanged(object sender, EventArgs e)
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

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            txtnombre2.Text = txtnombre.Text;
        }
    }
    }

