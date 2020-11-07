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

using Google.Cloud.Firestore;


namespace pruebafirestore.Pedidos
{
    public partial class Añadirdesdecoti : Form
    {
        FirestoreDb database;

        private OleDbConnection connection = new OleDbConnection();
        DataTable directorio = new DataTable();
        int numero;

        String Nombre = "";
        String Numero = "";
        String Modelo = "";

        String Orden = "";



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

        String total = "";

        public Añadirdesdecoti()
        {
            InitializeComponent();
        }

        private void Añadirdesdecoti_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"facturasebest2-firebase-adminsdk-rvc9d-2a1a79f585.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            database = FirestoreDb.Create("facturasebest2");
            comboBoxbusqueda.Text = "Orden";

            GetAllDocuments("Cotizaciones");
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

            Query Clientes = database.Collection(nameOfCollection);
            QuerySnapshot snap = await Clientes.GetSnapshotAsync();
            foreach (DocumentSnapshot docsnap in snap.Documents)
            {
                Clientesclase clientesclase = docsnap.ConvertTo<Clientesclase>();
                if (docsnap.Exists)
                {
                    directorio.Rows.Add(docsnap.Id, clientesclase.ID.ToString(), clientesclase.Nombre, clientesclase.Numero, clientesclase.Modelo, clientesclase.Fechayhora, clientesclase.Tiempodeespera, clientesclase.Contraseña, clientesclase.Cantidad, clientesclase.Cantidad2, clientesclase.Cantidad3, clientesclase.Cantidad4, clientesclase.Cantidad5, clientesclase.Descripcion, clientesclase.Descripcion2, clientesclase.Descripcion3, clientesclase.Descripcion4, clientesclase.Descripcion5, clientesclase.Importe, clientesclase.Importe2, clientesclase.Importe3, clientesclase.Importe4, clientesclase.Importe5, clientesclase.Total);
                    dataGridView1.DataSource = directorio;
                }

            }
            numero = directorio.Rows.Count;
            // MessageBox.Show(numero.ToString());
            numero--;
            directorio.Rows.RemoveAt(numero);
            //DataGridView.Sort(DataGridView.Columns(1), ListSortDirection.Ascending);
            dataGridView1.Sort(dataGridView1.Columns["ID"], ListSortDirection.Ascending);

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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
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

                Orden = row.Cells["Orden"].Value.ToString();

                impor = row.Cells["Importe"].Value.ToString();
                impor2 = row.Cells["Importe2"].Value.ToString();
                impor3 = row.Cells["Importe3"].Value.ToString();
                impor4 = row.Cells["Importe4"].Value.ToString();
                impor5 = row.Cells["Importe5"].Value.ToString();
                total = row.Cells["Total"].Value.ToString();

            }

            if (cant != "" && cant2 == "" && cant3 == "" && cant4 == "" && cant5 == "")
            {
                /*  mirarpartescoti mirar = new mirarpartescoti();
                  mirar.cant = cant;
                  mirar.descri = descri;
                  mirar.impor = impor;
                  mirar.dataGridView1.Columns.Add("Cantidad", "Cantidad");
                  mirar.dataGridView1.Columns.Add("Descripcion", "Descripcion");
                  mirar.dataGridView1.Columns.Add("Importe", "Importe");
                  mirar.dataGridView1.Rows.Insert(0, cant, descri, impor);
                  mirar.Show();*/

                crearpedido pedido = new crearpedido();
                pedido.FormBorderStyle = FormBorderStyle.FixedSingle;
                pedido.cant = cant;
                pedido.descri = descri;
                pedido.impor = impor;
                pedido.txttotal.Text = impor.Replace("$","");

                pedido.txtnombre.Text = Nombre;
                pedido.txtnumero.Text = Numero;
                pedido.txtmodelo.Text = Modelo;

                pedido.desdecoti = "si";

                pedido.Orden = Orden;

                pedido.dataGridView1.Rows.Insert(0, cant, descri,"", impor);

                pedido.Show();




            }
            else if (cant != "" && cant2 != "" && cant3 == "" && cant4 == "" && cant5 == "")
            {
                /*  mirarpartescoti mirar = new mirarpartescoti();
                  mirar.cant = cant;
                  mirar.cant2 = cant2;
                  mirar.descri = descri;
                  mirar.descri2 = descri2;
                  mirar.impor = impor;
                  mirar.impor2 = impor2;

                  mirar.total = total;
                  mirar.dataGridView1.Columns.Add("Cantidad", "Cantidad");
                  mirar.dataGridView1.Columns.Add("Descripcion", "Descripcion");
                  mirar.dataGridView1.Columns.Add("Importe", "Importe");
                  mirar.dataGridView1.Rows.Insert(0, cant, descri, impor);
                  mirar.dataGridView1.Rows.Insert(1, cant2, descri2, impor2);
                  mirar.dataGridView1.Rows.Insert(2, "", " Total", total);

                  mirar.Show();*/
                crearpedido pedido = new crearpedido();
                pedido.FormBorderStyle = FormBorderStyle.FixedSingle;
                pedido.cant = cant;
                pedido.descri = descri;
                pedido.impor = impor;

                pedido.cant2 = cant2;
                pedido.descri2 = descri2;
                pedido.impor2 = impor2;

                pedido.txttotal.Text = total.Replace("$", "");

                pedido.desdecoti = "si";

                pedido.txtnombre.Text = Nombre;
                pedido.txtnumero.Text = Numero;
                pedido.txtmodelo.Text = Modelo;

                pedido.Orden = Orden;



                pedido.dataGridView1.Rows.Insert(0, cant, descri, "", impor);
                pedido.dataGridView1.Rows.Insert(1, cant2, descri2, "", impor2);

                pedido.Show();

            }
            else if (cant != "" && cant2 != "" && cant3 != "" && cant4 == "" && cant5 == "")
            {
                /* mirarpartescoti mirar = new mirarpartescoti();
                 mirar.cant = cant;
                 mirar.cant2 = cant2;
                 mirar.cant3 = cant3;

                 mirar.descri = descri;
                 mirar.descri2 = descri2;
                 mirar.descri3 = descri3;

                 mirar.impor = impor;
                 mirar.impor2 = impor2;
                 mirar.impor3 = impor3;

                 mirar.total = total;
                 mirar.dataGridView1.Columns.Add("Cantidad", "Cantidad");
                 mirar.dataGridView1.Columns.Add("Descripcion", "Descripcion");
                 mirar.dataGridView1.Columns.Add("Importe", "Importe");
                 mirar.dataGridView1.Rows.Insert(0, cant, descri, impor);
                 mirar.dataGridView1.Rows.Insert(1, cant2, descri2, impor2);
                 mirar.dataGridView1.Rows.Insert(2, cant3, descri3, impor3);

                 mirar.dataGridView1.Rows.Insert(3, "", " Total", total);

                 mirar.Show();*/

                crearpedido pedido = new crearpedido();
                pedido.FormBorderStyle = FormBorderStyle.FixedSingle;
                pedido.cant = cant;
                pedido.descri = descri;
                pedido.impor = impor;

                pedido.cant2 = cant2;
                pedido.descri2 = descri2;
                pedido.impor2 = impor2;

                pedido.cant3 = cant3;
                pedido.descri3 = descri3;
                pedido.impor3 = impor3;

                pedido.txttotal.Text = total.Replace("$", "");

                pedido.desdecoti = "si";

                pedido.txtnombre.Text = Nombre;
                pedido.txtnumero.Text = Numero;
                pedido.txtmodelo.Text = Modelo;

                pedido.Orden = Orden;


                pedido.dataGridView1.Rows.Insert(0, cant, descri, "", impor);
                pedido.dataGridView1.Rows.Insert(1, cant2, descri2, "", impor2);
                pedido.dataGridView1.Rows.Insert(2, cant3, descri3, "", impor3);

                pedido.Show();
            }
            else if (cant != "" && cant2 != "" && cant3 != "" && cant4 != "" && cant5 == "")
            {
                /*  mirarpartescoti mirar = new mirarpartescoti();
                  mirar.cant = cant;
                  mirar.cant2 = cant2;
                  mirar.cant3 = cant3;
                  mirar.cant4 = cant4;

                  mirar.descri = descri;
                  mirar.descri2 = descri2;
                  mirar.descri3 = descri3;
                  mirar.descri4 = descri4;

                  mirar.impor = impor;
                  mirar.impor2 = impor2;
                  mirar.impor3 = impor3;
                  mirar.impor4 = impor4;

                  mirar.total = total;
                  mirar.dataGridView1.Columns.Add("Cantidad", "Cantidad");
                  mirar.dataGridView1.Columns.Add("Descripcion", "Descripcion");
                  mirar.dataGridView1.Columns.Add("Importe", "Importe");
                  mirar.dataGridView1.Rows.Insert(0, cant, descri, impor);
                  mirar.dataGridView1.Rows.Insert(1, cant2, descri2, impor2);
                  mirar.dataGridView1.Rows.Insert(2, cant3, descri3, impor3);
                  mirar.dataGridView1.Rows.Insert(3, cant4, descri4, impor4);

                  mirar.dataGridView1.Rows.Insert(4, "", " Total", total);

                  mirar.Show();*/
                crearpedido pedido = new crearpedido();
                pedido.FormBorderStyle = FormBorderStyle.FixedSingle;
                pedido.cant = cant;
                pedido.descri = descri;
                pedido.impor = impor;

                pedido.cant2 = cant2;
                pedido.descri2 = descri2;
                pedido.impor2 = impor2;

                pedido.cant3 = cant3;
                pedido.descri3 = descri3;
                pedido.impor3 = impor3;

                pedido.desdecoti = "si";

                pedido.cant4 = cant4;
                pedido.descri4 = descri4;
                pedido.impor4 = impor4;

                pedido.txttotal.Text = total.Replace("$", ""); ;
                pedido.Orden = Orden;


                pedido.txtnombre.Text = Nombre;
                pedido.txtnumero.Text = Numero;
                pedido.txtmodelo.Text = Modelo;
                pedido.dataGridView1.Rows.Insert(0, cant, descri, "", impor);
                pedido.dataGridView1.Rows.Insert(1, cant2, descri2, "", impor2);
                pedido.dataGridView1.Rows.Insert(2, cant3, descri3, "", impor3);
                pedido.dataGridView1.Rows.Insert(3, cant4, descri4, "", impor4);

                pedido.Show();

            }
            else if (cant != "" && cant2 != "" && cant3 != "" && cant4 != "" && cant5 != "")
            {
                /* mirarpartescoti mirar = new mirarpartescoti();
                 mirar.cant = cant;
                 mirar.cant2 = cant2;
                 mirar.cant3 = cant3;
                 mirar.cant4 = cant4;
                 mirar.cant5 = cant5;

                 mirar.descri = descri;
                 mirar.descri2 = descri2;
                 mirar.descri3 = descri3;
                 mirar.descri4 = descri4;
                 mirar.descri5 = descri5;

                 mirar.impor = impor;
                 mirar.impor2 = impor2;
                 mirar.impor3 = impor3;
                 mirar.impor4 = impor4;
                 mirar.impor5 = impor5;

                 mirar.total = total;
                 mirar.dataGridView1.Columns.Add("Cantidad", "Cantidad");
                 mirar.dataGridView1.Columns.Add("Descripcion", "Descripcion");
                 mirar.dataGridView1.Columns.Add("Importe", "Importe");
                 mirar.dataGridView1.Rows.Insert(0, cant, descri, impor);
                 mirar.dataGridView1.Rows.Insert(1, cant2, descri2, impor2);
                 mirar.dataGridView1.Rows.Insert(2, cant3, descri3, impor3);
                 mirar.dataGridView1.Rows.Insert(3, cant4, descri4, impor4);
                 mirar.dataGridView1.Rows.Insert(5, cant5, descri5, impor5);

                 mirar.dataGridView1.Rows.Insert(4, "", " Total", total);

                 mirar.Show();*/
                crearpedido pedido = new crearpedido();
                pedido.FormBorderStyle = FormBorderStyle.FixedSingle;
                pedido.cant = cant;
                pedido.descri = descri;
                pedido.impor = impor;

                pedido.cant2 = cant2;
                pedido.descri2 = descri2;
                pedido.impor2 = impor2;

                pedido.cant3 = cant3;
                pedido.descri3 = descri3;
                pedido.impor3 = impor3;

                pedido.cant4 = cant4;
                pedido.descri4 = descri4;
                pedido.impor4 = impor4;

                pedido.cant5 = cant5;
                pedido.descri5 = descri5;
                pedido.impor5 = impor5;

                pedido.txttotal.Text = total.Replace("$", "");

                pedido.desdecoti = "si";

                pedido.txtnombre.Text = Nombre;
                pedido.txtnumero.Text = Numero;
                pedido.txtmodelo.Text = Modelo;

                pedido.Orden = Orden;


                pedido.dataGridView1.Rows.Insert(0, cant, descri, "", impor);
                pedido.dataGridView1.Rows.Insert(1, cant2, descri2, "", impor2);
                pedido.dataGridView1.Rows.Insert(2, cant3, descri3, "", impor3);
                pedido.dataGridView1.Rows.Insert(3, cant4, descri4, "", impor4);
                pedido.dataGridView1.Rows.Insert(4, cant5, descri5, "", impor5);

                pedido.Show();
            }
        }
    }
}
