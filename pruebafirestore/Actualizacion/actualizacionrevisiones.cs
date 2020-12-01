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
using System.Runtime.Remoting.Messaging;
using System.Globalization;

namespace pruebafirestore.Actualizacion
{
    public partial class actualizacionrevisiones : Form
    {

        FirestoreDb database;
        int numero;
        // private object listDGV;
        DataTable directorio = new DataTable();
        public actualizacionrevisiones()
        {
            InitializeComponent();
        }

        private void actualizacionrevisiones_Load(object sender, EventArgs e)
        {
            comboBoxbusqueda.Text = "Nombre";
            string path = AppDomain.CurrentDomain.BaseDirectory + @"facturasebest2-firebase-adminsdk-rvc9d-2a1a79f585.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            database = FirestoreDb.Create("facturasebest2");
            // button1_Click(sender, e);
            GetAllDocuments("Revisiones");
        }


        async void GetAllDocuments(String nameOfCollection)
        {
            directorio.Columns.Add("Orden");
            directorio.Columns.Add("ID");
            directorio.Columns.Add("Nombre");
            directorio.Columns.Add("Numero");
            directorio.Columns.Add("Modelo");
            directorio.Columns.Add("Descripcion");
            directorio.Columns.Add("Accesorios");
            directorio.Columns.Add("Fecha y hora");
            directorio.Columns.Add("Tiempo de espera");
            directorio.Columns.Add("contraseña");
            // directorio.Columns.Add("fechaprueba");
            directorio.Columns["Fecha y hora"].DataType = Type.GetType("System.DateTime");



            Query Clientes = database.Collection(nameOfCollection);
            QuerySnapshot snap = await Clientes.GetSnapshotAsync();
            foreach (DocumentSnapshot docsnap in snap.Documents)
            {
                Clientesclase clientesclase = docsnap.ConvertTo<Clientesclase>();
                if (docsnap.Exists)
                {
                    DateTime oDate = Convert.ToDateTime(clientesclase.Fechayhora);

                    directorio.Rows.Add(docsnap.Id, clientesclase.ID.ToString(), clientesclase.Nombre, clientesclase.Numero, clientesclase.Modelo, clientesclase.Descripcion, clientesclase.Accesorios, clientesclase.Fechayhora, clientesclase.Tiempodeespera, clientesclase.Contraseña);
                    dataGridView1.DataSource = directorio;
                }
            }
            numero = directorio.Rows.Count;
            // MessageBox.Show(numero.ToString());
            numero--;
            directorio.Rows.RemoveAt(numero);

            //DataGridView.Sort(DataGridView.Columns(1), ListSortDirection.Ascending);


            // DataGridView1.Item("Salida", cont).Value = CDate(Format(DateTime.Parse(dt_fechas.Rows(fila).Item(2).ToString()), "dd/MM/yyyy  HH:mm"))

            // dataGridView1.Sort(dataGridView1.Columns["Fecha y hora"], System.ComponentModel.ListSortDirection.Ascending);

            dataGridView1.Sort(dataGridView1.Columns["Fecha y hora"], System.ComponentModel.ListSortDirection.Descending);

            // dataGridView1.Sort(dataGridView1.Columns["Fecha y hora"], ListSortDirection.Descending);

            //dataGridView1.Columns[2].Visible = false;


            dataGridView1.RowHeadersVisible = false;

            dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.White;

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

            dataGridView1.Columns[8].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[8].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[9].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[9].DefaultCellStyle.BackColor = Color.LightBlue;


            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String orden = "";
            String Nombre = "";
            String Numero = "";
            String Modelo = "";
            String Descripcion = "";
            String Fecha = "";
            String id = "";
            String Contras = "";
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                orden = row.Cells["Orden"].Value.ToString();
                Nombre = row.Cells["Nombre"].Value.ToString();
                Numero = row.Cells["Numero"].Value.ToString();
                Modelo = row.Cells["Modelo"].Value.ToString();
                Descripcion = row.Cells["Descripcion"].Value.ToString();
                Fecha = row.Cells["Fecha y hora"].Value.ToString();
                id = row.Cells["ID"].Value.ToString();
                Contras = row.Cells["Contraseña"].Value.ToString();

            }

            datosrevision datos = new datosrevision();
            string firstfour = orden.Substring(0, 2);
            

            datos.tipopedido = firstfour;
            datos.orden = orden;
            datos.txtnombre.Text = Nombre;
            datos.txtnumero.Text = Numero;
            datos.txtmodelo.Text = Modelo;
            datos.txtdescri.Text = Descripcion;

            datos.fechafin = Fecha;
            datos.ID = id;
            datos.Contrasena = Contras;
            datos.Show();
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
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
