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

            GetAllDocuments("Pedidos");
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                orden = row.Cells["Orden"].Value.ToString();
                Nombre = row.Cells["Nombre"].Value.ToString();
                Numero = row.Cells["Numero"].Value.ToString();
                Modelo = row.Cells["Modelo"].Value.ToString();

            }

            datosrevision datos = new datosrevision();
            string firstfour = orden.Substring(0, 2);


            datos.tipopedido = firstfour;
            datos.orden = orden;
            datos.txtnombre.Text = Nombre;
            datos.txtnumero.Text = Numero;
            datos.txtmodelo.Text = Modelo;

            datos.Show();
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
