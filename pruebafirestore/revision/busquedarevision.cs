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
using System.Runtime.Remoting.Messaging;
using System.Globalization;

namespace pruebafirestore.revision
{
    public partial class busquedarevision : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        FirestoreDb database;
        int numero;
       // private object listDGV;
        DataTable directorio = new DataTable();


        public busquedarevision()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \\EBEST-AB78DLU\ebest\Ebest_be.accdb; Persist Security Info=False;";

        }

        private void busquedarevision_Load(object sender, EventArgs e)
        {
            int numdias = 0;
            comboBoxbusqueda.Text = "Orden";
            string path = AppDomain.CurrentDomain.BaseDirectory + @"facturasebest2-firebase-adminsdk-rvc9d-2a1a79f585.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            database = FirestoreDb.Create("facturasebest2");
           // button1_Click(sender, e);
           GetAllDocuments("Revisiones");
            //numero = dataGridView1.Rows.Count;
            //dataGridView1.Rows.RemoveAt(numero);


            //directorio.DefaultView.RowFilter = $"timespan";
            //goto 30dias;
        }

        async void GetAllDocuments(String nameOfCollection)
        {
                    directorio.Columns.Add("Orden");
                    directorio.Columns.Add("ID");
                    directorio.Columns.Add("Nombre");
                    directorio.Columns.Add("Numero");
                    directorio.Columns.Add("Modelo");
                    directorio.Columns.Add("Descripción");
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

            dataGridView1.Sort(dataGridView1.Columns["Fecha y hora"], System.ComponentModel.ListSortDirection.Ascending);

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

        private  void txtbusqueda_TextChanged(object sender, EventArgs e)
        {

            if(comboBoxbusqueda.Text == "Orden")
            {
                directorio.DefaultView.RowFilter = $"Orden LIKE '{txtbusqueda.Text}%'";

            }
            else if(comboBoxbusqueda.Text == "Numero")
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
            txtnombre.Text = dataGridView1.Rows.Count.ToString();
           /* if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[3];
                txtnombre.Text = row.Cells["nombre"].Value.ToString();


            }*/
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();

            CollectionReference citiesRef = database.Collection("Revisiones");
            //ref.Collection('usuario').orderBy('nombre').startAt(nombre).endAt(nombre + '\uf8ff')

            Query query = database.Collection("Revisiones").WhereEqualTo("Nombre",txtbusqueda.Text);
            QuerySnapshot snap = await query.GetSnapshotAsync();
            foreach (DocumentSnapshot docsnap in snap.Documents)
            {
                Clientesclase clientesclase = docsnap.ConvertTo<Clientesclase>();
                if (docsnap.Exists)
                {
                    DataTable directorio = new DataTable();

                    directorio.Columns.Add("Contacto");
                    directorio.Columns.Add("Número");
                    directorio.Columns.Add("Númer3o");
                    directorio.Columns.Add("Númewerro");
                    directorio.Columns.Add("Númewerrtyro");
                    directorio.Columns.Add("Númewgfghfgerro");
                    directorio.Columns.Add("Númewe454yerrro");
                    directorio.Columns.Add("Númewerfghfghro");
                    directorio.Columns.Add("Númwerwetywero");
                    directorio.Columns.Add("Númwerfdgjfghjfghjwetywero");




                    directorio.Rows.Add(docsnap.Id, clientesclase.ID.ToString(), clientesclase.Nombre, clientesclase.Numero, clientesclase.Modelo, clientesclase.Descripcion, clientesclase.Accesorios, clientesclase.Fechayhora, clientesclase.Tiempodeespera, clientesclase.Contraseña);
                   dataGridView1.DataSource = directorio;


                }

            }



           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            /*string fecha = "10/10/2009";

            DateTime fecha2 = Convert.ToDateTime(fecha, new CultureInfo("es-ES"));

            //int  fecha3 = fecha2.AddDays(30);

            DateTime fecha3 = fecha2.AddDays(30);


            string resultado = fecha3.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

            MessageBox.Show(resultado);*/


            
                DateTime foo = DateTime.UtcNow;
            long unixTime = ((DateTimeOffset)foo).ToUnixTimeSeconds();
            MessageBox.Show(unixTime.ToString());


            /* int numdias = 0;
             dias:
             DateTime fechainicio = Convert.ToDateTime("10/10/2020");

             DateTime fechafinal = Convert.ToDateTime("28/10/2020");

             TimeSpan tspan = fechafinal - fechainicio;

             numdias = tspan.Days;
             // MessageBox.Show(fechafinal.ToString());
             MessageBox.Show(numdias.ToString());

             if (numdias < 30)
             {
                 MessageBox.Show(fechafinal.ToShortDateString());

                 fechafinal.AddDays(1);
                 goto dias;
             }
             else if (numdias == 18)
             {
                 MessageBox.Show(fechafinal.ToShortDateString());

             }*/
        }
    }
}
