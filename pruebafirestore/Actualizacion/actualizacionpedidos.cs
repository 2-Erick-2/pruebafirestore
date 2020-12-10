﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;


namespace pruebafirestore.Actualizacion
{
    public partial class actualizacionpedidos : Form
    {

        FirestoreDb database;
        DataTable directorio = new DataTable();
        int numero;
        public actualizacionpedidos()
        {
            InitializeComponent();
        }

        private void actualizacionpedidos_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"facturasebest2-firebase-adminsdk-rvc9d-2a1a79f585.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            database = FirestoreDb.Create("facturasebest2");
            comboBoxbusqueda.Text = "Nombre";

            GetAllDocuments2("Pedidos");
        }

        async void GetAllDocuments2(String nameOfCollection)
        {
            directorio.Columns.Add("Orden");
            directorio.Columns.Add("ID");
            directorio.Columns.Add("Nombre");
            directorio.Columns.Add("Numero");
            directorio.Columns.Add("Modelo");
            // directorio.Columns.Add("Descripcion");
            // directorio.Columns.Add("Accesorios");
            directorio.Columns.Add("Fecha y hora");
            directorio.Columns.Add("Tiempo de espera");
            directorio.Columns.Add("contraseña");
            directorio.Columns.Add("Cantidad");
            directorio.Columns.Add("Cantidad2");
            directorio.Columns.Add("Cantidad3");
            directorio.Columns.Add("Cantidad4");
            directorio.Columns.Add("Cantidad5");

            directorio.Columns.Add("Descripcion");
            directorio.Columns.Add("Descripcion2");
            directorio.Columns.Add("Descripcion3");
            directorio.Columns.Add("Descripcion4");
            directorio.Columns.Add("Descripcion5");

            directorio.Columns.Add("Importe");
            directorio.Columns.Add("Importe2");
            directorio.Columns.Add("Importe3");
            directorio.Columns.Add("Importe4");
            directorio.Columns.Add("Importe5");
            directorio.Columns.Add("Total");
            directorio.Columns.Add("Abono");
            directorio.Columns.Add("Abono2");
            directorio.Columns.Add("Abono3");
            directorio.Columns.Add("Abono4");
            directorio.Columns.Add("Abono5");

            directorio.Columns.Add("Restante");


            directorio.Columns.Add("Fecha y hora2");
            directorio.Columns.Add("Fecha y hora3");
            directorio.Columns.Add("Fecha y hora4");
            directorio.Columns.Add("Fecha y hora5");

            directorio.Columns["Fecha y hora"].DataType = Type.GetType("System.DateTime");
            Query Clientes = database.Collection(nameOfCollection);
            QuerySnapshot snap = await Clientes.GetSnapshotAsync();
            foreach (DocumentSnapshot docsnap in snap.Documents)
            {
                Clientesclase clientesclase = docsnap.ConvertTo<Clientesclase>();
                if (docsnap.Exists)
                {
                    directorio.Rows.Add(docsnap.Id, clientesclase.ID.ToString(), clientesclase.Nombre, clientesclase.Numero, clientesclase.Modelo, clientesclase.Fechayhora, clientesclase.Tiempodeespera, clientesclase.Contraseña, clientesclase.Cantidad, clientesclase.Cantidad2, clientesclase.Cantidad3, clientesclase.Cantidad4, clientesclase.Cantidad5, clientesclase.Descripcion, clientesclase.Descripcion2, clientesclase.Descripcion3, clientesclase.Descripcion4, clientesclase.Descripcion5, clientesclase.Importe, clientesclase.Importe2, clientesclase.Importe3, clientesclase.Importe4, clientesclase.Importe5, clientesclase.Total, clientesclase.Abono, clientesclase.Abono2, clientesclase.Abono3, clientesclase.Abono4, clientesclase.Abono5, clientesclase.Restante, clientesclase.Fechayhora2, clientesclase.Fechayhora3, clientesclase.Fechayhora4, clientesclase.Fechayhora5);
                    dataGridView1.DataSource = directorio;
                }
            }
            numero = directorio.Rows.Count;
            // MessageBox.Show(numero.ToString());
            numero--;
            directorio.Rows.RemoveAt(numero);
            //DataGridView.Sort(DataGridView.Columns(1), ListSortDirection.Ascending);
            dataGridView1.Sort(dataGridView1.Columns["Fecha y hora"], ListSortDirection.Descending);

            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;
            dataGridView1.Columns[18].Visible = false;
            dataGridView1.Columns[19].Visible = false;
            dataGridView1.Columns[20].Visible = false;
            dataGridView1.Columns[21].Visible = false;
            dataGridView1.Columns[22].Visible = false;
            //TOTAL
            dataGridView1.Columns[23].Visible = false;


            dataGridView1.Columns[24].Visible = false;
            dataGridView1.Columns[25].Visible = false;
            dataGridView1.Columns[26].Visible = false;
            dataGridView1.Columns[27].Visible = false;
            dataGridView1.Columns[28].Visible = false;
            dataGridView1.Columns[29].Visible = false;
            dataGridView1.Columns[30].Visible = false;
            dataGridView1.Columns[31].Visible = false;
            dataGridView1.Columns[32].Visible = false;
            dataGridView1.Columns[33].Visible = false;





            dataGridView1.RowHeadersVisible = false;

            dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.LightYellow;

            dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[2].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[3].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[3].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[4].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[4].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[5].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[5].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[6].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[6].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[7].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[7].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }
        async void GetAllDocuments(String nameOfCollection)
        {
            directorio.Columns.Add("Orden");
            directorio.Columns.Add("ID");
            directorio.Columns.Add("Nombre");
            directorio.Columns.Add("Numero");
            directorio.Columns.Add("Modelo");
            // directorio.Columns.Add("Descripcion");
            // directorio.Columns.Add("Accesorios");
            directorio.Columns.Add("Fecha y hora");
            directorio.Columns.Add("Tiempo de espera");
            directorio.Columns.Add("contraseña");
            directorio.Columns.Add("Cantidad");
            directorio.Columns.Add("Cantidad2");
            directorio.Columns.Add("Cantidad3");
            directorio.Columns.Add("Cantidad4");
            directorio.Columns.Add("Cantidad5");

            directorio.Columns.Add("Descripcion");
            directorio.Columns.Add("Descripcion2");
            directorio.Columns.Add("Descripcion3");
            directorio.Columns.Add("Descripcion4");
            directorio.Columns.Add("Descripcion5");

            directorio.Columns.Add("Importe");
            directorio.Columns.Add("Importe2");
            directorio.Columns.Add("Importe3");
            directorio.Columns.Add("Importe4");
            directorio.Columns.Add("Importe5");
            directorio.Columns.Add("Total");
            directorio.Columns.Add("Abono");
            directorio.Columns.Add("Restante");

            directorio.Columns["Fecha y hora"].DataType = Type.GetType("System.DateTime");


            Query Clientes = database.Collection(nameOfCollection);
            QuerySnapshot snap = await Clientes.GetSnapshotAsync();
            foreach (DocumentSnapshot docsnap in snap.Documents)
            {
                Clientesclase clientesclase = docsnap.ConvertTo<Clientesclase>();
                if (docsnap.Exists)
                {
                    directorio.Rows.Add(docsnap.Id, clientesclase.ID.ToString(), clientesclase.Nombre, clientesclase.Numero, clientesclase.Modelo, clientesclase.Fechayhora, clientesclase.Tiempodeespera, clientesclase.Contraseña, clientesclase.Cantidad, clientesclase.Cantidad2, clientesclase.Cantidad3, clientesclase.Cantidad4, clientesclase.Cantidad5, clientesclase.Descripcion, clientesclase.Descripcion2, clientesclase.Descripcion3, clientesclase.Descripcion4, clientesclase.Descripcion5, clientesclase.Importe, clientesclase.Importe2, clientesclase.Importe3, clientesclase.Importe4, clientesclase.Importe5, clientesclase.Total, clientesclase.Abono, clientesclase.Restante);
                    dataGridView1.DataSource = directorio;
                }

            }
            numero = directorio.Rows.Count;
            // MessageBox.Show(numero.ToString());
            numero--;
            directorio.Rows.RemoveAt(numero);
            //DataGridView.Sort(DataGridView.Columns(1), ListSortDirection.Ascending);
            dataGridView1.Sort(dataGridView1.Columns["Fecha y hora"], ListSortDirection.Descending);

            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;
            dataGridView1.Columns[18].Visible = false;
            dataGridView1.Columns[19].Visible = false;
            dataGridView1.Columns[20].Visible = false;
            dataGridView1.Columns[21].Visible = false;
            dataGridView1.Columns[22].Visible = false;
            dataGridView1.Columns[23].Visible = false;
            dataGridView1.Columns[24].Visible = false;
            dataGridView1.Columns[25].Visible = false;


            dataGridView1.RowHeadersVisible = false;

            dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.LightYellow;

            dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[2].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[3].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[3].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[4].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[4].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[5].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[5].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[6].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[6].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[7].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[7].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String orden = "";
            String Nombre = "";
            String Numero = "";
            String Modelo = "";


            String cant = "";
            String cant2 = "";
            String cant3 = "";
            String cant4 = "";
            String cant5 = "";

            String descri = "";
            String descri2 = "";
            String descri3 = "";
            String descri4 = "";
            String descri5 = "";

            String impor = "";
            String impor2 = "";
            String impor3 = "";
            String impor4 = "";
            String impor5 = "";

            String Abono = "";
            String Abono2 = "";
            String Abono3 = "";
            String Abono4 = "";
            String Abono5 = "";




            String total = "";
            String Restante = "";
            String fechayhora = "";

            String fechayhora2 = "";
            String fechayhora3 = "";
            String fechayhora4 = "";
            String fechayhora5 = "";

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                orden = row.Cells["Orden"].Value.ToString();
                Nombre = row.Cells["Nombre"].Value.ToString();
                Numero = row.Cells["Numero"].Value.ToString();
                Modelo = row.Cells["Modelo"].Value.ToString();

                cant = row.Cells["Cantidad"].Value.ToString();
                cant2 = row.Cells["Cantidad2"].Value.ToString();
                cant3 = row.Cells["Cantidad3"].Value.ToString();
                cant4 = row.Cells["Cantidad4"].Value.ToString();
                cant5 = row.Cells["Cantidad5"].Value.ToString();
                descri = row.Cells["Descripcion"].Value.ToString();
                descri2 = row.Cells["Descripcion2"].Value.ToString();
                descri3 = row.Cells["Descripcion3"].Value.ToString();
                descri4 = row.Cells["Descripcion4"].Value.ToString();
                descri5 = row.Cells["Descripcion5"].Value.ToString();


                fechayhora = row.Cells["Fecha y hora"].Value.ToString();
                fechayhora2 = row.Cells["Fecha y hora2"].Value.ToString();

                fechayhora3 = row.Cells["Fecha y hora3"].Value.ToString();

                fechayhora4 = row.Cells["Fecha y hora4"].Value.ToString();

                fechayhora5 = row.Cells["Fecha y hora5"].Value.ToString();


                impor = row.Cells["Importe"].Value.ToString();
                impor2 = row.Cells["Importe2"].Value.ToString();
                impor3 = row.Cells["Importe3"].Value.ToString();
                impor4 = row.Cells["Importe4"].Value.ToString();
                impor5 = row.Cells["Importe5"].Value.ToString();

                Abono = row.Cells["Abono"].Value.ToString();
                Abono2 = row.Cells["Abono2"].Value.ToString();
                Abono3 = row.Cells["Abono3"].Value.ToString();
                Abono4 = row.Cells["Abono4"].Value.ToString();
                Abono5 = row.Cells["Abono5"].Value.ToString();

                total = row.Cells["Total"].Value.ToString();
                Restante = row.Cells["Restante"].Value.ToString();




            }
            if (Abono != "" && Abono2 == "" && Abono3 == "" && Abono4 == "" && Abono5 == "")
            {
                datosrevision Abonos = new datosrevision();
                /* Abonos.cant = cant;
                 Abonos.descri = descri;
                 Abonos.impor = impor;*/
                Abonos.cant = cant;
                Abonos.cant2 = cant2;
                Abonos.cant3 = cant3;
                Abonos.cant4 = cant4;
                Abonos.cant5 = cant5;

                Abonos.descri = descri;
                Abonos.descri2 = descri2;
                Abonos.descri3 = descri3;
                Abonos.descri4 = descri4;
                Abonos.descri5 = descri5;

                Abonos.impor = impor;
                Abonos.impor2 = impor2;
                Abonos.impor3 = impor3;
                Abonos.impor4 = impor4;
                Abonos.impor5 = impor5;

                Abonos.Abono = Abono;
                Abonos.total = total;
                Abonos.Restante = Restante;
                Abonos.fechayhora = fechayhora;

                Abonos.Nombre = Nombre;

                Abonos.txtnombre.Text = Nombre;
                Abonos.Modelo = Modelo;
                Abonos.orden = orden;
                Abonos.Numero = Numero;
                Abonos.txtnumero.Text = Numero;
                Abonos.txtmodelo.Text = Modelo;
            string firstfour = orden.Substring(0, 2);
                Abonos.tipopedido = firstfour;
                Abonos.Show();
            }


            else if (Abono != "" && Abono2 != "" && Abono3 == "" && Abono4 == "" && Abono5 == "")
            {
                datosrevision Abonos = new datosrevision();
                Abonos.cant = cant;
                Abonos.cant2 = cant2;
                Abonos.cant3 = cant3;
                Abonos.cant4 = cant4;
                Abonos.cant5 = cant5;

                Abonos.descri = descri;
                Abonos.descri2 = descri2;
                Abonos.descri3 = descri3;
                Abonos.descri4 = descri4;
                Abonos.descri5 = descri5;

                //Abonos.txttotal.Text = total;


                Abonos.impor = impor;
                Abonos.impor2 = impor2;
                Abonos.impor3 = impor3;
                Abonos.impor4 = impor4;
                Abonos.impor5 = impor5;
                /* Abonos.cant = cant;
                 Abonos.descri = descri;
                 Abonos.impor = impor;*/
                Abonos.Abono = Abono;
                Abonos.fechayhora = fechayhora;

                Abonos.Abono2 = Abono2;
                Abonos.fechayhora2 = fechayhora2;

                Abonos.total = total;
                Abonos.Restante = Restante;

                Abonos.txtnombre.Text = Nombre;

                Abonos.Nombre = Nombre;
                Abonos.Modelo = Modelo;
                Abonos.orden = orden;

                Abonos.Numero = Numero;
                Abonos.txtnumero.Text = Numero;
                Abonos.txtmodelo.Text = Modelo;
                //String Abonosin = Abono.Replace("$", "");
                //String Abonosin2 = Abono2.Replace("$", "");
                // String Abonosin3 = Abono3.Replace("$", "");
                //String Abonosin4 = Abono4.Replace("$", "");







                Abonos.Show();
            }
            else if (Abono != "" && Abono2 != "" && Abono3 != "" && Abono4 == "" && Abono5 == "")
            {
                datosrevision Abonos = new datosrevision();
                Abonos.cant = cant;
                Abonos.cant2 = cant2;
                Abonos.cant3 = cant3;
                Abonos.cant4 = cant4;
                Abonos.cant5 = cant5;

                Abonos.descri = descri;
                Abonos.descri2 = descri2;
                Abonos.descri3 = descri3;
                Abonos.descri4 = descri4;
                Abonos.descri5 = descri5;

                //Abonos.txttotal.Text = total;


                Abonos.impor = impor;
                Abonos.impor2 = impor2;
                Abonos.impor3 = impor3;
                Abonos.impor4 = impor4;
                Abonos.impor5 = impor5;
                /* Abonos.cant = cant;
                 Abonos.descri = descri;
                 Abonos.impor = impor;*/
                Abonos.Abono = Abono;
                Abonos.fechayhora = fechayhora;
                Abonos.txtnombre.Text = Nombre;

                Abonos.Abono2 = Abono2;
                Abonos.fechayhora2 = fechayhora2;

                Abonos.Abono3 = Abono3;
                Abonos.fechayhora3 = fechayhora3;

                Abonos.total = total;
                Abonos.Restante = Restante;
                Abonos.Numero = Numero;
                Abonos.txtnumero.Text = Numero;
                Abonos.txtmodelo.Text = Modelo;
                Abonos.Nombre = Nombre;
                Abonos.Modelo = Modelo;
                Abonos.orden = orden;

                


                Abonos.Show();
            }
            else if (Abono != "" && Abono2 != "" && Abono3 != "" && Abono4 != "" && Abono5 == "")
            {
                datosrevision Abonos = new datosrevision();
                Abonos.cant = cant;
                Abonos.cant2 = cant2;
                Abonos.cant3 = cant3;
                Abonos.cant4 = cant4;
                Abonos.cant5 = cant5;

                Abonos.descri = descri;
                Abonos.descri2 = descri2;
                Abonos.descri3 = descri3;
                Abonos.descri4 = descri4;
                Abonos.descri5 = descri5;

                Abonos.impor = impor;
                Abonos.impor2 = impor2;
                Abonos.impor3 = impor3;
                Abonos.impor4 = impor4;
                Abonos.impor5 = impor5;


                Abonos.Abono = Abono;
                Abonos.fechayhora = fechayhora;

                Abonos.Abono2 = Abono2;
                Abonos.fechayhora2 = fechayhora2;
                Abonos.txtnombre.Text = Nombre;

                Abonos.Abono3 = Abono3;
                Abonos.fechayhora3 = fechayhora3;

                Abonos.Abono4 = Abono4;
                Abonos.fechayhora4 = fechayhora4;


                Abonos.total = total;
                Abonos.Restante = Restante;
                Abonos.Numero = Numero;
                Abonos.txtnumero.Text = Numero;
                Abonos.txtmodelo.Text = Modelo;
                Abonos.Nombre = Nombre;
                Abonos.Modelo = Modelo;
                Abonos.orden = orden;


                


                Abonos.Show();
            }

            else if (Abono != "" && Abono2 != "" && Abono3 != "" && Abono4 != "" && Abono5 != "")
            {
                datosrevision Abonos = new datosrevision();
                Abonos.cant = cant;
                Abonos.cant2 = cant2;
                Abonos.cant3 = cant3;
                Abonos.cant4 = cant4;
                Abonos.cant5 = cant5;

                Abonos.descri = descri;
                Abonos.descri2 = descri2;
                Abonos.descri3 = descri3;
                Abonos.descri4 = descri4;
                Abonos.descri5 = descri5;

                //Abonos.txttotal.Text = total;


                Abonos.impor = impor;
                Abonos.impor2 = impor2;
                Abonos.impor3 = impor3;
                Abonos.impor4 = impor4;
                Abonos.impor5 = impor5;
                /* Abonos.cant = cant;
                 Abonos.descri = descri;
                 Abonos.impor = impor;*/
                Abonos.Abono = Abono;
                Abonos.fechayhora = fechayhora;

                Abonos.Abono2 = Abono2;
                Abonos.fechayhora2 = fechayhora2;

                Abonos.Abono3 = Abono3;
                Abonos.fechayhora3 = fechayhora3; 
                Abonos.txtnombre.Text = Nombre;

                Abonos.Abono4 = Abono4;
                Abonos.fechayhora4 = fechayhora4;

                Abonos.Abono5 = Abono5;
                Abonos.fechayhora5 = fechayhora5;
                Abonos.Numero = Numero;
                Abonos.txtnumero.Text = Numero;
                Abonos.txtmodelo.Text = Modelo;

                Abonos.total = total;
                Abonos.Restante = Restante;

                Abonos.Nombre = Nombre;
                Abonos.Modelo = Modelo;
                Abonos.orden = orden;

               


                Abonos.Show();
            }



            /* datosrevision datos = new datosrevision();



             //datos.tipopedido = firstfour;
             datos.orden = orden;
             datos.txtnombre.Text = Nombre;
             datos.txtnumero.Text = Numero;
             datos.txtmodelo.Text = Modelo;

             datos.Show();*/
        }

        private void txtbusqueda_TextChanged_1(object sender, EventArgs e)
        {
            if (comboBoxbusqueda.Text == "Orden")
            {
                directorio.DefaultView.RowFilter = $"Orden LIKE '{txtbusqueda.Text}%'";

            }
            else if (comboBoxbusqueda.Text == "Numero")
            {
                directorio.DefaultView.RowFilter = $"Numero LIKE '{txtbusqueda.Text}%'";

            }
            else if (comboBoxbusqueda.Text == "Nombre")
            {
                directorio.DefaultView.RowFilter = $"Nombre LIKE '{txtbusqueda.Text}%'";

            }
            else if (comboBoxbusqueda.Text == "Fecha")
            {
                directorio.DefaultView.RowFilter = $"[Fecha y hora] LIKE '{txtbusqueda.Text}%'";

            }
            else if (comboBoxbusqueda.Text == "Modelo")
            {
                directorio.DefaultView.RowFilter = $"[Modelo] LIKE '{txtbusqueda.Text}%'";

            }
        }
    }
}
