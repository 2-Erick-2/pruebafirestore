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

namespace pruebafirestore.Pedidos
{
    public partial class Abonos : Form
    {
        String contar;

        public String cant = "";
        public String cant2 = "";
        public String cant3 = "";
        public String cant4 = "";
        public String cant5 = "";

        public String descri = "";
        public String descri2 = "";
        public String descri3 = "";
        public String descri4 = "";
        public String descri5 = "";

        public String fechayhora = "";

        public String impor = "";
        public String impor2 = "";
        public String impor3 = "";
        public String impor4 = "";
        public String impor5 = "";

        public String Abono = "";
        public String Abono2 = "";
        public String Abono3 = "";
        public String Abono4 = "";
        public String Abono5 = "";



        public String total = "";
        public String Restante = "";
        public Abonos()
        {
            InitializeComponent();
        }

        private void Abonos_Load(object sender, EventArgs e)
        {

            txttotal.Text = total;
            txtrestante.Text = Restante;
            dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.LightYellow;

            dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.LightBlue;




            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            //dataGridView1.Columns[0].Width = 1500;
            dataGridView1.Rows[0].Selected = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtabono.Text != "" && dataGridView1.Rows.Count <= 4)
            {
                if (dataGridView1.Rows.Count == 1)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dataGridView1);
                    //fila.Cells[0].Value = txtcantidad.Text;
                    fila.Cells[0].Value = txtabono.Text;
                    fila.Cells[1].Value = txthorayfecha.Text;
                        
                    //fila.Cells[2].Value = txtimporte.Text;
                    //fila.Cells[3].Value = preciofinal;
                    dataGridView1.Rows.Add(fila);
                    //dataGridView1.Rows.Add("","","     Total: ", precio1);
                    //txttotal.Text = preciofinal;
                    double p1 = Convert.ToDouble(dataGridView1.Rows[1].Cells[0].Value.ToString().Replace("$", ""));

                    double restantedesdemov = Convert.ToDouble(Restante.Replace("$", ""));
                    Double resultado = restantedesdemov - p1;
                    txtrestante.Text = resultado.ToString();

                    txtabono.Text = "";

                   
                }

                /*
                else if (dataGridView1.Rows.Count == 1)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dataGridView1);
                    fila.Cells[0].Value = txtcantidad.Text;
                    fila.Cells[1].Value = txtdescri.Text;
                    fila.Cells[2].Value = txtimporte.Text;
                    fila.Cells[3].Value = preciofinal;
                    dataGridView1.Rows.Add(fila);
                    //dataGridView1.Rows.Add("","","     Total: ", precio1);
                    //txttotal.Text = preciofinal;
                    //Convert.ToDouble
                    double p1 = Convert.ToDouble(dataGridView1.Rows[0].Cells[3].Value.ToString().Replace("$", ""));
                    double p2 = Convert.ToDouble(dataGridView1.Rows[1].Cells[3].Value.ToString().Replace("$", ""));

                    double precio = p1 + p2;
                    txttotal.Text = precio.ToString();
                    txtcantidad.Text = "";
                    txtdescri.Text = "";
                    txtimporte.Text = "";
                }
                else if (dataGridView1.Rows.Count == 2)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dataGridView1);
                    fila.Cells[0].Value = txtcantidad.Text;
                    fila.Cells[1].Value = txtdescri.Text;
                    fila.Cells[2].Value = txtimporte.Text;
                    fila.Cells[3].Value = preciofinal;
                    dataGridView1.Rows.Add(fila);
                    //dataGridView1.Rows.Add("","","     Total: ", precio1);
                    //txttotal.Text = preciofinal;
                    //Convert.ToDouble
                    double p1 = Convert.ToDouble(dataGridView1.Rows[0].Cells[3].Value.ToString().Replace("$", ""));
                    double p2 = Convert.ToDouble(dataGridView1.Rows[1].Cells[3].Value.ToString().Replace("$", ""));
                    double p3 = Convert.ToDouble(dataGridView1.Rows[2].Cells[3].Value.ToString().Replace("$", ""));

                    double precio = p1 + p2 + p3;
                    txttotal.Text = precio.ToString();
                    txtcantidad.Text = "";
                    txtdescri.Text = "";
                    txtimporte.Text = "";
                }
                else if (dataGridView1.Rows.Count == 3)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dataGridView1);
                    fila.Cells[0].Value = txtcantidad.Text;
                    fila.Cells[1].Value = txtdescri.Text;
                    fila.Cells[2].Value = txtimporte.Text;
                    fila.Cells[3].Value = preciofinal;
                    dataGridView1.Rows.Add(fila);
                    //dataGridView1.Rows.Add("","","     Total: ", precio1);
                    //txttotal.Text = preciofinal;
                    //Convert.ToDouble
                    double p1 = Convert.ToDouble(dataGridView1.Rows[0].Cells[3].Value.ToString().Replace("$", ""));
                    double p2 = Convert.ToDouble(dataGridView1.Rows[1].Cells[3].Value.ToString().Replace("$", ""));
                    double p3 = Convert.ToDouble(dataGridView1.Rows[2].Cells[3].Value.ToString().Replace("$", ""));
                    double p4 = Convert.ToDouble(dataGridView1.Rows[3].Cells[3].Value.ToString().Replace("$", ""));

                    double precio = p1 + p2 + p3 + p4;
                    txttotal.Text = precio.ToString();
                    txtcantidad.Text = "";
                    txtdescri.Text = "";
                    txtimporte.Text = "";
                }
                else if (dataGridView1.Rows.Count == 4)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dataGridView1);
                    fila.Cells[0].Value = txtcantidad.Text;
                    fila.Cells[1].Value = txtdescri.Text;
                    fila.Cells[2].Value = txtimporte.Text;
                    fila.Cells[3].Value = preciofinal;
                    dataGridView1.Rows.Add(fila);
                    //dataGridView1.Rows.Add("","","     Total: ", precio1);
                    //txttotal.Text = preciofinal;
                    //Convert.ToDouble
                    double p1 = Convert.ToDouble(dataGridView1.Rows[0].Cells[3].Value.ToString().Replace("$", ""));
                    double p2 = Convert.ToDouble(dataGridView1.Rows[1].Cells[3].Value.ToString().Replace("$", ""));
                    double p3 = Convert.ToDouble(dataGridView1.Rows[2].Cells[3].Value.ToString().Replace("$", ""));
                    double p4 = Convert.ToDouble(dataGridView1.Rows[3].Cells[3].Value.ToString().Replace("$", ""));
                    double p5 = Convert.ToDouble(dataGridView1.Rows[4].Cells[3].Value.ToString().Replace("$", ""));

                    double precio = p1 + p2 + p3 + p4 + p5;
                    txttotal.Text = precio.ToString();
                    txtcantidad.Text = "";
                    txtdescri.Text = "";
                    txtimporte.Text = "";
                }           */





            }
            else
            {
                MessageBox.Show("Te faltan valores por ingresar o llegaste al numero maximo de productos");
            }
        }

        private void txtabono_Leave(object sender, EventArgs e)
        {
            try
            {
                contar = txtabono.Text;
                if (contar.Length == 4)
                {
                    double d = Convert.ToDouble(txtabono.Text, CultureInfo.InvariantCulture);
                    txtabono.Text = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 3)
                {
                    double d = Convert.ToDouble(txtabono.Text, CultureInfo.InvariantCulture);
                    txtabono.Text = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 2)
                {
                    double d = Convert.ToDouble(txtabono.Text, CultureInfo.InvariantCulture);
                    txtabono.Text = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 6)
                {
                    double d = Convert.ToDouble(txtabono.Text, CultureInfo.InvariantCulture);
                    txtabono.Text = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 5)
                {
                    double d = Convert.ToDouble(txtabono.Text, CultureInfo.InvariantCulture);
                    txtabono.Text = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void txtabono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtabono_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void txtrestante_TextChanged(object sender, EventArgs e)
        {
            try
            {


                contar = txtrestante.Text;
                if (contar.Length == 4)
                {
                    double d = Convert.ToDouble(txtrestante.Text, CultureInfo.InvariantCulture);
                    txtrestante.Text = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 3)
                {
                    double d = Convert.ToDouble(txtrestante.Text, CultureInfo.InvariantCulture);
                    txtrestante.Text = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 2)
                {
                    double d = Convert.ToDouble(txtrestante.Text, CultureInfo.InvariantCulture);
                    txtrestante.Text = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 6)
                {
                    double d = Convert.ToDouble(txtrestante.Text, CultureInfo.InvariantCulture);
                    txtrestante.Text = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 5)
                {
                    double d = Convert.ToDouble(txtrestante.Text, CultureInfo.InvariantCulture);
                    txtrestante.Text = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToShortDateString();
            string hora = DateTime.Now.ToShortTimeString();
            txthorayfecha.Text = fecha + " " + hora;
        }
    }
}
