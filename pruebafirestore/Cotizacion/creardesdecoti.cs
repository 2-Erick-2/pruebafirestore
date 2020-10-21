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


namespace pruebafirestore.Cotizacion
{
    public partial class creardesdecoti : Form
    {
        FirestoreDb database;

        private OleDbConnection connection = new OleDbConnection();
        DataTable directorio = new DataTable();
        int numero;

        String Orden = "";
        String ID = "";
        String Nombre = "";
        String Numero = "";
        String Modelo = "";
        String Descripcion = "";
        String Accesorios = "";
        String Fechayhora = "";
        String Tiempodeespera = "";
        String Contraseña = "";


        public creardesdecoti()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \\EBEST-AB78DLU\ebest\Ebest_be.accdb; Persist Security Info=False;";

        }

        private void creardesdecoti_Load(object sender, EventArgs e)
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + @"facturasebest2-firebase-adminsdk-rvc9d-2a1a79f585.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            database = FirestoreDb.Create("facturasebest2");
            comboBoxbusqueda.Text = "Orden";

            GetAllDocuments("Revisiones");
            //comboBoxbusqueda.Text = "Orden";

            

            
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


            Query Clientes = database.Collection(nameOfCollection);
            QuerySnapshot snap = await Clientes.GetSnapshotAsync();
            foreach (DocumentSnapshot docsnap in snap.Documents)
            {
                Clientesclase clientesclase = docsnap.ConvertTo<Clientesclase>();
                if (docsnap.Exists)
                {






                    directorio.Rows.Add(docsnap.Id, clientesclase.ID.ToString(), clientesclase.Nombre, clientesclase.Numero, clientesclase.Modelo, clientesclase.Descripcion, clientesclase.Accesorios, clientesclase.Fechayhora, clientesclase.Tiempodeespera, clientesclase.Contraseña);
                    dataGridView1.DataSource = directorio;
                }

            }
            numero = directorio.Rows.Count;
            // MessageBox.Show(numero.ToString());
            numero--;
            directorio.Rows.RemoveAt(numero);

            //DataGridView.Sort(DataGridView.Columns(1), ListSortDirection.Ascending);
            dataGridView1.Sort(dataGridView1.Columns["ID"], ListSortDirection.Ascending);

            dataGridView1.Columns[2].Visible = false;


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
            creardesde2 crear = new creardesde2();
            crear.Nombre = Nombre;
            crear.Numero = Numero;
            crear.Modelo = Modelo;
            crear.Show();
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

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                Orden = row.Cells["Orden"].Value.ToString();
                ID= row.Cells["ID"].Value.ToString();
                Nombre = row.Cells["Nombre"].Value.ToString();
                Numero = row.Cells["Numero"].Value.ToString();
                Modelo = row.Cells["Modelo"].Value.ToString();
                Descripcion = row.Cells["Descripcion"].Value.ToString();
                Accesorios = row.Cells["Accesorios"].Value.ToString();
                Fechayhora = row.Cells["Fecha y hora"].Value.ToString();
                Tiempodeespera = row.Cells["Tiempo de espera"].Value.ToString();
                Contraseña = row.Cells["Contraseña"].Value.ToString();
            }

            //MessageBox.Show(Orden + ID + Nombre + numero + Modelo + Descripcion + Accesorios + Fechayhora + Tiempodeespera + Contraseña);
        }
    }
}
