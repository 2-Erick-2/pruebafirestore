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

namespace pruebafirestore
{
    public partial class Busquedatodo : Form
    {
        FirestoreDb database;
        int numero;
        // private object listDGV;
        DataTable directorio = new DataTable();
        public Busquedatodo()
        {
            InitializeComponent();
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

        private void Busquedatodo_Load(object sender, EventArgs e)
        {
           // int numdias = 0;
            comboBoxbusqueda.Text = "Nombre";
            string path = AppDomain.CurrentDomain.BaseDirectory + @"facturasebest2-firebase-adminsdk-rvc9d-2a1a79f585.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            database = FirestoreDb.Create("facturasebest2");
            // button1_Click(sender, e);
            GetAllDocuments("Revisiones");
            GetAllDocuments2("Cotizaciones");
            GetAllDocuments3("Pedidos");

           




        }

        async void GetAllDocuments(String nameOfCollection)
        {
            directorio.Columns.Add("Orden");
            directorio.Columns.Add("ID");
            directorio.Columns.Add("Nombre");
            directorio.Columns.Add("Numero");
            directorio.Columns.Add("Modelo");
            directorio.Columns.Add("Descripción");
            directorio.Columns.Add("contraseña");

            directorio.Columns.Add("Accesorios");


            directorio.Columns.Add("Tiempo de espera");
            directorio.Columns.Add("Fecha y hora");






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

                    directorio.Rows.Add(docsnap.Id, clientesclase.ID.ToString(), clientesclase.Nombre, clientesclase.Numero, clientesclase.Modelo, clientesclase.Descripcion, clientesclase.Contraseña, clientesclase.Accesorios, clientesclase.Tiempodeespera, clientesclase.Fechayhora);
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

        async void GetAllDocuments2(String nameOfCollection)
        {
           /* directorio.Columns.Add("Orden");
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
            directorio.Columns["Fecha y hora"].DataType = Type.GetType("System.DateTime");*/



            Query Clientes = database.Collection(nameOfCollection);
            QuerySnapshot snap = await Clientes.GetSnapshotAsync();
            foreach (DocumentSnapshot docsnap in snap.Documents)
            {
                Clientesclase clientesclase = docsnap.ConvertTo<Clientesclase>();
                if (docsnap.Exists)
                {
                    //DateTime oDate = Convert.ToDateTime(clientesclase.Fechayhora);

                    directorio.Rows.Add(docsnap.Id, clientesclase.ID.ToString(), clientesclase.Nombre, clientesclase.Numero, clientesclase.Modelo, clientesclase.Descripcion, clientesclase.Contraseña, clientesclase.Accesorios, clientesclase.Tiempodeespera, clientesclase.Fechayhora);
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


        async void GetAllDocuments3(String nameOfCollection)
        {
            /* directorio.Columns.Add("Orden");
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
             directorio.Columns["Fecha y hora"].DataType = Type.GetType("System.DateTime");*/



            Query Clientes = database.Collection(nameOfCollection);
            QuerySnapshot snap = await Clientes.GetSnapshotAsync();
            foreach (DocumentSnapshot docsnap in snap.Documents)
            {
                Clientesclase clientesclase = docsnap.ConvertTo<Clientesclase>();
                if (docsnap.Exists)
                {
                    DateTime oDate = Convert.ToDateTime(clientesclase.Fechayhora);

                    directorio.Rows.Add(docsnap.Id, clientesclase.ID.ToString(), clientesclase.Nombre, clientesclase.Numero, clientesclase.Modelo, clientesclase.Descripcion, clientesclase.Contraseña, clientesclase.Accesorios, clientesclase.Tiempodeespera, clientesclase.Fechayhora);
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




    }
}
