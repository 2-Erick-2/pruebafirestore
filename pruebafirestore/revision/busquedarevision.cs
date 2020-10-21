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
            comboBoxbusqueda.Text = "Orden";
            string path = AppDomain.CurrentDomain.BaseDirectory + @"facturasebest2-firebase-adminsdk-rvc9d-2a1a79f585.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            database = FirestoreDb.Create("facturasebest2");
           // button1_Click(sender, e);
           GetAllDocuments("Revisiones");
           //numero = dataGridView1.Rows.Count;
            //dataGridView1.Rows.RemoveAt(numero);
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
           
            //dataGridView1.Columns[2].Visible = false;
            

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



            /*  if (comboBoxbusqueda.Text == "Orden")
              {
                  try
                  {
                      connection.Open();
                      OleDbCommand command = new OleDbCommand();
                      command.Connection = connection;
                      string query = "select * from revisiones Where orden like ('" + txtbusqueda.Text + "%')";
                      command.CommandText = query;
                      OleDbDataAdapter da = new OleDbDataAdapter(command);
                      DataTable dt = new DataTable();
                      da.Fill(dt);
                      dataGridView1.DataSource = dt;
                      connection.Close();
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show("Error " + ex);
                  }

              }

              else if (comboBoxbusqueda.Text == "Numero")
              {
                  try
                  {
                      connection.Open();
                      OleDbCommand command = new OleDbCommand();
                      command.Connection = connection;
                      string query = "select * from revisiones Where numero like ('" + txtbusqueda.Text + "%')";
                      command.CommandText = query;

                      OleDbDataAdapter da = new OleDbDataAdapter(command);
                      DataTable dt = new DataTable();
                      da.Fill(dt);
                      dataGridView1.DataSource = dt;

                      connection.Close();
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show("Error " + ex);
                  }

              }

              else if (comboBoxbusqueda.Text == "Nombre")
              {
                  try
                  {
                      connection.Open();
                      OleDbCommand command = new OleDbCommand();
                      command.Connection = connection;
                      string query = "select * from revisiones Where nombre like ('" + txtbusqueda.Text + "%')";
                      command.CommandText = query;

                      OleDbDataAdapter da = new OleDbDataAdapter(command);
                      DataTable dt = new DataTable();
                      da.Fill(dt);
                      dataGridView1.DataSource = dt;

                      connection.Close();
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show("Error " + ex);
                  }

              }

              if (comboBoxbusqueda.Text == "Fecha")
              {
                  try
                  {
                      connection.Open();
                      OleDbCommand command = new OleDbCommand();
                      command.Connection = connection;
                      string query = "select * from revisiones Where horayfecha like ('" + txtbusqueda.Text + "%')";
                      command.CommandText = query;

                      OleDbDataAdapter da = new OleDbDataAdapter(command);
                      DataTable dt = new DataTable();
                      da.Fill(dt);
                      dataGridView1.DataSource = dt;

                      connection.Close();
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show("Error " + ex);
                  }
              }*/
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



           /* Query Clientes = database.Collection(nameOfCollection);
            QuerySnapshot snap = await Clientes.GetSnapshotAsync();
            foreach (DocumentSnapshot docsnap in snap.Documents)
            {
                Clientesclase clientesclase = docsnap.ConvertTo<Clientesclase>();
                if (docsnap.Exists)
                {

                    // dt = (DataTable)dataGridView1.DataSource;
                    dataGridView1.Rows.Add(docsnap.Id, clientesclase.ID.ToString(), clientesclase.Nombre, clientesclase.Numero, clientesclase.Modelo, clientesclase.Descripcion, clientesclase.Accesorios, clientesclase.Fechayhora, clientesclase.Tiempodeespera, clientesclase.Contraseña);



                }

            }*/


            /*  CollectionReference citiesRef = database.Collection("Revisiones");
              Query query = citiesRef.WhereEqualTo("ID", txtbusqueda.Text);
              QuerySnapshot querySnapshot = await query.GetSnapshotAsync();
              foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
              {
                  Clientesclase clientesclase = documentSnapshot.ConvertTo<Clientesclase>();

                  if (documentSnapshot.Exists)
                  {

                      // dt = (DataTable)dataGridView1.DataSource;
                      dataGridView1.Rows.Add(documentSnapshot.Id, clientesclase.ID.ToString(), clientesclase.Nombre, clientesclase.Numero, clientesclase.Modelo, clientesclase.Descripcion, clientesclase.Accesorios, clientesclase.Fechayhora, clientesclase.Tiempodeespera, clientesclase.Contraseña);

                  }

              }*/
        }
    }
}
