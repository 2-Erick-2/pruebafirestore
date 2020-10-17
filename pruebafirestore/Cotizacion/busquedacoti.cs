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
    public partial class busquedacoti : Form
    {
        FirestoreDb database;

        private OleDbConnection connection = new OleDbConnection();

        public busquedacoti()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \\EBEST-AB78DLU\ebest\Ebest3_be.accdb; Persist Security Info=False;";

        }

        private void busquedacoti_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"facturasebest2-firebase-adminsdk-rvc9d-2a1a79f585.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            database = FirestoreDb.Create("facturasebest2");
            comboBoxbusqueda.Text = "Orden";

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT cotizaciones.[id],cotizaciones.[orden], cotizaciones.[tipopedido], cotizaciones.[nombre], cotizaciones.[numero], cotizaciones.[horayfecha], cotizaciones.[modelo], cotizaciones.[espera], cotizaciones.[Cantidad], cotizaciones.[Descripcion], cotizaciones.[Importe],cotizaciones.[Total]FROM cotizaciones ";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                connection.Close();

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

                dataGridView1.Columns[10].HeaderCell.Style.BackColor = Color.White;
                dataGridView1.Columns[10].DefaultCellStyle.BackColor = Color.LightBlue;

                dataGridView1.Columns[11].HeaderCell.Style.BackColor = Color.White;
                dataGridView1.Columns[11].DefaultCellStyle.BackColor = Color.LightBlue;

                dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
                dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetAllDocuments("Clientes");
        }
        async void GetAllDocuments(String nameOfCollection)
        {
            Query Clientes = database.Collection(nameOfCollection);
            QuerySnapshot snap = await Clientes.GetSnapshotAsync();
            foreach(DocumentSnapshot docsnap in snap.Documents)
            {
                Clientesclase clientesclase = docsnap.ConvertTo<Clientesclase>();
                if (docsnap.Exists)
                {
                    dataGridView1.Rows.Add(docsnap.Id, clientesclase.Calle, clientesclase.Cantidad, clientesclase.Ciudad);
                }

            }
        }
    }
}
