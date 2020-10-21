using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Google.Cloud.Firestore;
using System.Drawing.Printing;

namespace pruebafirestore.Cotizacion
{
    public partial class creardesde2 : Form
    {
        FirestoreDb database;

        public String Orden = "";

        public String Nombre = "";
        public String Numero = "";
        public String Modelo = "";

        String contar;

        String pedido = "";
        String preciofinal;
        String tiemporespuesta = "";
        String contra = "";

        public creardesde2()
        {
            InitializeComponent();
        }

        private void creardesde2_Load(object sender, EventArgs e)
        {
            combodias.Text = "1 día";
            combohoras.Text = "1 hora";
            string path = AppDomain.CurrentDomain.BaseDirectory + @"facturasebest2-firebase-adminsdk-rvc9d-2a1a79f585.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            database = FirestoreDb.Create("facturasebest2");
            txtnombre.Text = Nombre;
            txtnombre2.Text = txtnombre.Text;
            txtnumero.Text = Numero;
            txtmodelo.Text = Modelo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcantidad.Text != "" && txtdescri.Text != "" && txtimporte.Text != "" && dataGridView1.Rows.Count <= 4)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dataGridView1);
                fila.Cells[0].Value = txtcantidad.Text;
                fila.Cells[1].Value = txtdescri.Text;
                fila.Cells[2].Value = txtimporte.Text;
                fila.Cells[3].Value = preciofinal;

                dataGridView1.Rows.Add(fila);
                txtcantidad.Text = "";
                txtdescri.Text = "";
                txtimporte.Text = "";
            }
            else
            {
                MessageBox.Show("Te faltan valores por ingresar o llegaste al numero maximo de productos");
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtimporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtimporte_Leave(object sender, EventArgs e)
        {
            try
            {
                Double precio = Convert.ToDouble(txtcantidad.Text) * Convert.ToDouble(txtimporte.Text);
                preciofinal = precio.ToString();
                String contar2 = preciofinal;

                contar = txtimporte.Text;
                if (contar.Length == 4)
                {
                    double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                    txtimporte.Text = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 3)
                {
                    double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                    txtimporte.Text = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 2)
                {
                    double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                    txtimporte.Text = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 6)
                {
                    double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                    txtimporte.Text = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 5)
                {
                    double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                    txtimporte.Text = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }


                if (contar2.Length == 4)
                {
                    double d = Convert.ToDouble(preciofinal, CultureInfo.InvariantCulture);
                    preciofinal = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar2.Length == 3)
                {
                    double d = Convert.ToDouble(preciofinal, CultureInfo.InvariantCulture);
                    preciofinal = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }
                else if (contar2.Length == 2)
                {
                    double d = Convert.ToDouble(preciofinal, CultureInfo.InvariantCulture);
                    preciofinal = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                }
                else if (contar2.Length == 6)
                {
                    double d = Convert.ToDouble(preciofinal, CultureInfo.InvariantCulture);
                    preciofinal = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar2.Length == 5)
                {
                    double d = Convert.ToDouble(preciofinal, CultureInfo.InvariantCulture);
                    preciofinal = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void checkrespuesta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkrespuesta.Checked == true)
            {
                checkBox2.Visible = true;
                combodias.Visible = true;
                checkBox1.Visible = true;
                combohoras.Visible = false;
            }
            else if (checkrespuesta.Checked == false)
            {
                checkBox2.Visible = false;
                combodias.Visible = false;
                checkBox1.Visible = false;
                combohoras.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                combodias.Visible = true;
                combohoras.Visible = false;
            }
            else if (checkBox2.Checked == false && checkBox1.Checked == false)
            {
                checkBox2.Checked = true;
                combodias.Visible = true;
                combohoras.Visible = false;
            }
            else
            {
                checkBox2.Checked = false;
                combodias.Visible = false;
                combohoras.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                combodias.Visible = false;
                combohoras.Visible = true;
            }
            else if (checkBox2.Checked == false && checkBox1.Checked == false)
            {

                checkBox2.Checked = true;
                combodias.Visible = true;
                combohoras.Visible = false;
            }
            else
            {
                checkBox1.Checked = false;
                combodias.Visible = true;
                combohoras.Visible = false;
            }
        }

        private async void altoButton1_Click(object sender, EventArgs e)
        {
            if (checkrespuesta.Checked == true && checkBox2.Checked == true)
            {
                tiemporespuesta = combodias.Text;
            }
            else if (checkrespuesta.Checked == true && checkBox1.Checked == true)
            {
                tiemporespuesta = combohoras.Text;
            }
            else if (checkrespuesta.Checked == false)
            {
                tiemporespuesta = "No aplica";
            }
            sincopia:
            string Name = txtnombre2.Text;
            var rand = new Random();
            pedido = "COTIZACION";
            //checkBoxcotizacion.Checked = false;
            ///checkBoxrevision.Checked = false;

            string firstfour = Name.Substring(0, 2);
            txtorden2.Text = firstfour;

            string iniciodepedidos = pedido.Substring(0, 2);

            //generacion  de numero aleatorio de orden
            var guid = Guid.NewGuid();
            var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 9));
            var random = new Random(seed);

            txtpruibea.Text = seed.ToString();
            txtorden.Text = iniciodepedidos + firstfour + seed.ToString();

            DocumentReference docRef = database.Collection("Cotizaciones").Document(txtorden.Text);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                MessageBox.Show("Repetido");
                goto sincopia;
            }
            else
            {
                //FirestoreDb database;
                DocumentReference cityRef = database.Collection("Revisiones").Document(Orden);
                await cityRef.DeleteAsync();


                DocumentReference DOC = database.Collection("Cotizaciones").Document("contador");
                Dictionary<String, Object> data1 = new Dictionary<string, object>()
                {
                 {"ID", FieldValue.Increment(1)}




                 };
                await DOC.SetAsync(data1, SetOptions.MergeAll);

                DocumentReference docRef2 = database.Collection("Cotizaciones").Document("contador");
                DocumentSnapshot snapsho2 = await docRef2.GetSnapshotAsync();
                if (snapsho2.Exists)
                {
                    Dictionary<string, object> counter = snapsho2.ToDictionary();
                    foreach (var item in counter)
                        lblcontador.Text = string.Format("{1}", item.Key, item.Value);
                }
                // int id = (int)Convert.ToInt64(lblcontador.Text);
                BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
                Codigo.IncludeLabel = true;
                pictureBox2.Image = Codigo.Encode(BarcodeLib.TYPE.CODE128, txtorden.Text, Color.Black, Color.White, 230, 60);

                printDocument1 = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                printDocument1.PrinterSettings = ps;
                printDocument1.PrintPage += imprimir;
                printDocument1.Print();










            }
        }



        private async void imprimir(object sender, PrintPageEventArgs e)
        {

        }



    }
}
