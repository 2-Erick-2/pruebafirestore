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
       // public String Orden = "";
        public String Numero = "";






        public String tipopedido = "";

        public String orden = "";

        public String Estado = "";

        public String fechafin = "";
        public String ID = "";

        public String Contrasena = "";
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

                    {"Descripcion", txtdescri.Text},

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
                checkclienteno.Visible = true;
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

                label5.Enabled = true;
                txtdescri.Enabled = true;
                altoButton3.Visible = true;
            }



            if (tipopedido == "CO" || tipopedido == "PE")
            {
                if (cant != "" && cant2 == "" && cant3 == "" && cant4 == "" && cant5 == "")
                {
                    dataGridView2.Columns.Add("Cantidad", "Cantidad");
                    dataGridView2.Columns.Add("Descripcion", "Descripcion");
                    dataGridView2.Columns.Add("Importe", "Importe");


                    double importe1 = Convert.ToDouble(impor.Replace("$", ""));
                    String IMPORTE1 = "";

                    if (importe1 > -1 && importe1 < 100)
                    {
                        double d = Convert.ToDouble(importe1.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE1 = d.ToString("$      .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe1 > 99 && importe1 < 1000)
                    {
                        double d = Convert.ToDouble(importe1.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE1 = d.ToString("$    .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe1 > 999 && importe1 < 10000)
                    {
                        double d = Convert.ToDouble(importe1.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE1 = d.ToString("$  .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe1 > 9999 && importe1 < 100000)
                    {
                        double d = Convert.ToDouble(importe1.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE1 = d.ToString("$.00", CultureInfo.InvariantCulture);
                    }


                    dataGridView2.Rows.Insert(0, cant, descri, IMPORTE1);
                }
                else if (cant != "" && cant2 != "" && cant3 == "" && cant4 == "" && cant5 == "")
                {
                    dataGridView2.Columns.Add("Cantidad", "Cantidad");
                    dataGridView2.Columns.Add("Descripcion", "Descripcion");
                    dataGridView2.Columns.Add("Importe", "Importe");


                    double importe1 = Convert.ToDouble(impor.Replace("$", ""));
                    String IMPORTE1 = "";

                    double importe2 = Convert.ToDouble(impor2.Replace("$", ""));
                    String IMPORTE2 = "";


                    if (importe1 > -1 && importe1 < 100)
                    {
                        double d = Convert.ToDouble(importe1.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE1 = d.ToString("$      .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe1 > 99 && importe1 < 1000)
                    {
                        double d = Convert.ToDouble(importe1.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE1 = d.ToString("$    .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe1 > 999 && importe1 < 10000)
                    {
                        double d = Convert.ToDouble(importe1.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE1 = d.ToString("$  .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe1 > 9999 && importe1 < 100000)
                    {
                        double d = Convert.ToDouble(importe1.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE1 = d.ToString("$.00", CultureInfo.InvariantCulture);
                    }


                    if (importe2 > -1 && importe2 < 100)
                    {
                        double d = Convert.ToDouble(importe2.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE2 = d.ToString("$      .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe2 > 99 && importe2 < 1000)
                    {
                        double d = Convert.ToDouble(importe2.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE2 = d.ToString("$    .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe2 > 999 && importe2 < 10000)
                    {
                        double d = Convert.ToDouble(importe2.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE2 = d.ToString("$  .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe2 > 9999 && importe2 < 100000)
                    {
                        double d = Convert.ToDouble(importe2.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE2 = d.ToString("$.00", CultureInfo.InvariantCulture);
                    }




                    dataGridView2.Rows.Insert(0, cant, descri, IMPORTE1);
                    dataGridView2.Rows.Insert(1, cant2, descri2, IMPORTE2);
                }
                else if (cant != "" && cant2 != "" && cant3 != "" && cant4 == "" && cant5 == "")
                {
                    dataGridView2.Columns.Add("Cantidad", "Cantidad");
                    dataGridView2.Columns.Add("Descripcion", "Descripcion");
                    dataGridView2.Columns.Add("Importe", "Importe");


                    double importe1 = Convert.ToDouble(impor.Replace("$", ""));
                    String IMPORTE1 = "";

                    double importe2 = Convert.ToDouble(impor2.Replace("$", ""));
                    String IMPORTE2 = "";

                    double importe3 = Convert.ToDouble(impor2.Replace("$", ""));
                    String IMPORTE3 = "";


                    if (importe1 > -1 && importe1 < 100)
                    {
                        double d = Convert.ToDouble(importe1.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE1 = d.ToString("$      .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe1 > 99 && importe1 < 1000)
                    {
                        double d = Convert.ToDouble(importe1.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE1 = d.ToString("$    .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe1 > 999 && importe1 < 10000)
                    {
                        double d = Convert.ToDouble(importe1.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE1 = d.ToString("$  .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe1 > 9999 && importe1 < 100000)
                    {
                        double d = Convert.ToDouble(importe1.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE1 = d.ToString("$.00", CultureInfo.InvariantCulture);
                    }


                    if (importe2 > -1 && importe2 < 100)
                    {
                        double d = Convert.ToDouble(importe2.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE2 = d.ToString("$      .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe2 > 99 && importe2 < 1000)
                    {
                        double d = Convert.ToDouble(importe2.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE2 = d.ToString("$    .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe2 > 999 && importe2 < 10000)
                    {
                        double d = Convert.ToDouble(importe2.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE2 = d.ToString("$  .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe2 > 9999 && importe2 < 100000)
                    {
                        double d = Convert.ToDouble(importe2.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE2 = d.ToString("$.00", CultureInfo.InvariantCulture);
                    }


                    if (importe3 > -1 && importe3 < 100)
                    {
                        double d = Convert.ToDouble(importe3.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE3 = d.ToString("$      .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe3 > 99 && importe3 < 1000)
                    {
                        double d = Convert.ToDouble(importe3.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE3 = d.ToString("$    .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe3 > 999 && importe3 < 10000)
                    {
                        double d = Convert.ToDouble(importe3.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE3 = d.ToString("$  .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe3 > 9999 && importe3 < 100000)
                    {
                        double d = Convert.ToDouble(importe3.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE3 = d.ToString("$.00", CultureInfo.InvariantCulture);
                    }



                    dataGridView2.Rows.Insert(0, cant, descri, IMPORTE1);
                    dataGridView2.Rows.Insert(1, cant2, descri2, IMPORTE2);
                    dataGridView2.Rows.Insert(2, cant3, descri3, IMPORTE3);

                }
                else if (cant != "" && cant2 != "" && cant3 != "" && cant4 != "" && cant5 == "")
                {
                    dataGridView2.Columns.Add("Cantidad", "Cantidad");
                    dataGridView2.Columns.Add("Descripcion", "Descripcion");
                    dataGridView2.Columns.Add("Importe", "Importe");


                    double importe1 = Convert.ToDouble(impor.Replace("$", ""));
                    String IMPORTE1 = "";

                    double importe2 = Convert.ToDouble(impor2.Replace("$", ""));
                    String IMPORTE2 = "";

                    double importe3 = Convert.ToDouble(impor2.Replace("$", ""));
                    String IMPORTE3 = "";

                    double importe4 = Convert.ToDouble(impor2.Replace("$", ""));
                    String IMPORTE4 = "";


                    if (importe1 > -1 && importe1 < 100)
                    {
                        double d = Convert.ToDouble(importe1.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE1 = d.ToString("$      .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe1 > 99 && importe1 < 1000)
                    {
                        double d = Convert.ToDouble(importe1.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE1 = d.ToString("$    .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe1 > 999 && importe1 < 10000)
                    {
                        double d = Convert.ToDouble(importe1.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE1 = d.ToString("$  .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe1 > 9999 && importe1 < 100000)
                    {
                        double d = Convert.ToDouble(importe1.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE1 = d.ToString("$.00", CultureInfo.InvariantCulture);
                    }


                    if (importe2 > -1 && importe2 < 100)
                    {
                        double d = Convert.ToDouble(importe2.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE2 = d.ToString("$      .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe2 > 99 && importe2 < 1000)
                    {
                        double d = Convert.ToDouble(importe2.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE2 = d.ToString("$    .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe2 > 999 && importe2 < 10000)
                    {
                        double d = Convert.ToDouble(importe2.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE2 = d.ToString("$  .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe2 > 9999 && importe2 < 100000)
                    {
                        double d = Convert.ToDouble(importe2.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE2 = d.ToString("$.00", CultureInfo.InvariantCulture);
                    }


                    if (importe3 > -1 && importe3 < 100)
                    {
                        double d = Convert.ToDouble(importe3.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE3 = d.ToString("$      .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe3 > 99 && importe3 < 1000)
                    {
                        double d = Convert.ToDouble(importe3.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE3 = d.ToString("$    .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe3 > 999 && importe3 < 10000)
                    {
                        double d = Convert.ToDouble(importe3.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE3 = d.ToString("$  .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe3 > 9999 && importe3 < 100000)
                    {
                        double d = Convert.ToDouble(importe3.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE3 = d.ToString("$.00", CultureInfo.InvariantCulture);
                    }


                    if (importe4 > -1 && importe4 < 100)
                    {
                        double d = Convert.ToDouble(importe4.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE4 = d.ToString("$      .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe4 > 99 && importe4 < 1000)
                    {
                        double d = Convert.ToDouble(importe4.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE4 = d.ToString("$    .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe4 > 999 && importe4 < 10000)
                    {
                        double d = Convert.ToDouble(importe4.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE4 = d.ToString("$  .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe4 > 9999 && importe4 < 100000)
                    {
                        double d = Convert.ToDouble(importe4.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE4 = d.ToString("$.00", CultureInfo.InvariantCulture);
                    }





                    dataGridView2.Rows.Insert(0, cant, descri, IMPORTE1);
                    dataGridView2.Rows.Insert(1, cant2, descri2, IMPORTE2);
                    dataGridView2.Rows.Insert(2, cant3, descri3, IMPORTE3);
                    dataGridView2.Rows.Insert(3, cant4, descri4, IMPORTE4);

                }
                else if (cant != "" && cant2 != "" && cant3 != "" && cant4 != "" && cant5 != "")
                {
                    dataGridView2.Columns.Add("Cantidad", "Cantidad");
                    dataGridView2.Columns.Add("Descripcion", "Descripcion");
                    dataGridView2.Columns.Add("Importe", "Importe");


                    double importe1 = Convert.ToDouble(impor.Replace("$", ""));
                    String IMPORTE1 = "";

                    double importe2 = Convert.ToDouble(impor2.Replace("$", ""));
                    String IMPORTE2 = "";

                    double importe3 = Convert.ToDouble(impor2.Replace("$", ""));
                    String IMPORTE3 = "";

                    double importe4 = Convert.ToDouble(impor2.Replace("$", ""));
                    String IMPORTE4 = "";

                    double importe5 = Convert.ToDouble(impor2.Replace("$", ""));
                    String IMPORTE5 = "";


                    if (importe1 > -1 && importe1 < 100)
                    {
                        double d = Convert.ToDouble(importe1.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE1 = d.ToString("$      .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe1 > 99 && importe1 < 1000)
                    {
                        double d = Convert.ToDouble(importe1.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE1 = d.ToString("$    .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe1 > 999 && importe1 < 10000)
                    {
                        double d = Convert.ToDouble(importe1.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE1 = d.ToString("$  .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe1 > 9999 && importe1 < 100000)
                    {
                        double d = Convert.ToDouble(importe1.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE1 = d.ToString("$.00", CultureInfo.InvariantCulture);
                    }


                    if (importe2 > -1 && importe2 < 100)
                    {
                        double d = Convert.ToDouble(importe2.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE2 = d.ToString("$      .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe2 > 99 && importe2 < 1000)
                    {
                        double d = Convert.ToDouble(importe2.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE2 = d.ToString("$    .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe2 > 999 && importe2 < 10000)
                    {
                        double d = Convert.ToDouble(importe2.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE2 = d.ToString("$  .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe2 > 9999 && importe2 < 100000)
                    {
                        double d = Convert.ToDouble(importe2.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE2 = d.ToString("$.00", CultureInfo.InvariantCulture);
                    }

                    if (importe3 > -1 && importe3 < 100)
                    {
                        double d = Convert.ToDouble(importe3.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE3 = d.ToString("$      .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe3 > 99 && importe3 < 1000)
                    {
                        double d = Convert.ToDouble(importe3.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE3 = d.ToString("$    .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe3 > 999 && importe3 < 10000)
                    {
                        double d = Convert.ToDouble(importe3.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE3 = d.ToString("$  .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe3 > 9999 && importe3 < 100000)
                    {
                        double d = Convert.ToDouble(importe3.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE3 = d.ToString("$.00", CultureInfo.InvariantCulture);
                    }


                    if (importe4 > -1 && importe4 < 100)
                    {
                        double d = Convert.ToDouble(importe4.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE4 = d.ToString("$      .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe4 > 99 && importe4 < 1000)
                    {
                        double d = Convert.ToDouble(importe4.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE4 = d.ToString("$    .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe4 > 999 && importe4 < 10000)
                    {
                        double d = Convert.ToDouble(importe4.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE4 = d.ToString("$  .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe4 > 9999 && importe4 < 100000)
                    {
                        double d = Convert.ToDouble(importe4.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE4 = d.ToString("$.00", CultureInfo.InvariantCulture);
                    }


                    if (importe5 > -1 && importe5 < 100)
                    {
                        double d = Convert.ToDouble(importe5.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE5 = d.ToString("$      .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe5 > 99 && importe5 < 1000)
                    {
                        double d = Convert.ToDouble(importe5.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE5 = d.ToString("$    .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe5 > 999 && importe5 < 10000)
                    {
                        double d = Convert.ToDouble(importe5.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE5 = d.ToString("$  .00", CultureInfo.InvariantCulture);
                    }
                    else if (importe5 > 9999 && importe5 < 100000)
                    {
                        double d = Convert.ToDouble(importe5.ToString(), CultureInfo.InvariantCulture);
                        IMPORTE5 = d.ToString("$.00", CultureInfo.InvariantCulture);
                    }



                    dataGridView2.Rows.Insert(0, cant, descri, IMPORTE1);
                    dataGridView2.Rows.Insert(1, cant2, descri2, IMPORTE2);
                    dataGridView2.Rows.Insert(2, cant3, descri3, IMPORTE3);
                    dataGridView2.Rows.Insert(3, cant4, descri4, IMPORTE4);
                    dataGridView2.Rows.Insert(4, cant5, descri5, IMPORTE5);
                }


                //txttotal.Text = total;
                

                dataGridView2.Columns[0].HeaderCell.Style.BackColor = Color.White;
                dataGridView2.Columns[0].DefaultCellStyle.BackColor = Color.LightYellow;

                dataGridView2.Columns[1].HeaderCell.Style.BackColor = Color.White;
                dataGridView2.Columns[1].DefaultCellStyle.BackColor = Color.LightBlue;

                dataGridView2.Columns[2].HeaderCell.Style.BackColor = Color.White;
                dataGridView2.Columns[2].DefaultCellStyle.BackColor = Color.LightBlue;

                dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
                dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;



                //dataGridView1.Columns[0].Width = 1500;
                dataGridView2.Rows[0].Selected = false;
            }






        }

        private void checksinrefacciones_CheckedChanged(object sender, EventArgs e)
        {
            if (checksinrefacciones.Checked == true)
            {
                checkperdidatotal.Checked = false;
                checkclienteno.Checked = false;
                Estado = "Sin refacciones";
            }
        }

        private void checkperdidatotal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkperdidatotal.Checked == true)
            {
                checksinrefacciones.Checked = false;
                checkclienteno.Checked = false;
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

        private void checkclienteno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkclienteno.Checked == true)
            {
                checkperdidatotal.Checked = false;
                checksinrefacciones.Checked = false;
                Estado = "Cliente no quiere reparar";
            }
        }

        private void altoButton3_Click(object sender, EventArgs e)
        {
            BrotherPrintThis();
        }

        public void BrotherPrintThis()
        {
            try
            {

                string path = @"C:\cartaebest3.lbx";
                bpac.Document doc = new bpac.Document();
                doc.Open(path);
                bool test = doc.SetPrinter("Brother QL-800", true);
                string pedido2 = "Tipo pedido: Revision";
                string nombre = "Nombre: " + txtnombre.Text;
                string numero = "Numero: " + txtnumero.Text;
                string obser = "Obs.: " + txtdescri.Text;
               // string orden = "Numero orden: " + orden;
                string orden2 = orden;
                doc.GetObject("pedido").Text = pedido2;
                doc.GetObject("nombre").Text = nombre;
                doc.GetObject("numero").Text = numero;
                doc.GetObject("modelo").Text = "Modelo: " + txtmodelo.Text;

                doc.GetObject("fecha").Text = fechafin;

                doc.GetObject("obser").Text = obser;
                doc.GetObject("contraseña").Text = "Clave: "+ Contrasena;

                doc.GetObject("id").Text = ID;
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
