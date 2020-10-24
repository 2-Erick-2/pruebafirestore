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
using BarcodeLib;
using Google.Cloud.Firestore;
using System.Drawing.Printing;

namespace pruebafirestore.Pedidos
{
    public partial class crearpedido : Form
    {
        FirestoreDb database;

        String contar;

        String pedido = "";
        String preciofinal;
        String tiemporespuesta = "";
        String contra = "";

        Double precio1;
        Double precio2;
        Double precio3;
        Double precio4;
        Double precio5;

        public crearpedido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcantidad.Text != "" && txtdescri.Text != "" && txtimporte.Text != "" && dataGridView1.Rows.Count <= 4)
            {
                if(dataGridView1.Rows.Count == 0)
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
                double p1 = Convert.ToDouble(dataGridView1.Rows[0].Cells[3].Value.ToString().Replace("$", ""));

                txttotal.Text = p1.ToString();
                txtcantidad.Text = "";
                txtdescri.Text = "";
                txtimporte.Text = "";
                }
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
                }





            }
            else
            {
                MessageBox.Show("Te faltan valores por ingresar o llegaste al numero maximo de productos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            if(dataGridView1.Rows.Count == 0)
            {
                txttotal.Text = "";
            }
            
            else  if (dataGridView1.Rows.Count == 1)
            {
               
                double p1 = Convert.ToDouble(dataGridView1.Rows[0].Cells[3].Value.ToString().Replace("$", ""));
                //double p2 = Convert.ToDouble(dataGridView1.Rows[1].Cells[3].Value.ToString().Replace("$", ""));

                double precio = p1;
                txttotal.Text = precio.ToString();
              
            }
            else if (dataGridView1.Rows.Count == 2)
            {
                
                double p1 = Convert.ToDouble(dataGridView1.Rows[0].Cells[3].Value.ToString().Replace("$", ""));
                double p2 = Convert.ToDouble(dataGridView1.Rows[1].Cells[3].Value.ToString().Replace("$", ""));
               // double p3 = Convert.ToDouble(dataGridView1.Rows[2].Cells[3].Value.ToString().Replace("$", ""));

                double precio = p1 + p2;
                txttotal.Text = precio.ToString();
              
            }
            else if (dataGridView1.Rows.Count == 3)
            {
               
                double p1 = Convert.ToDouble(dataGridView1.Rows[0].Cells[3].Value.ToString().Replace("$", ""));
                double p2 = Convert.ToDouble(dataGridView1.Rows[1].Cells[3].Value.ToString().Replace("$", ""));
                double p3 = Convert.ToDouble(dataGridView1.Rows[2].Cells[3].Value.ToString().Replace("$", ""));
               // double p4 = Convert.ToDouble(dataGridView1.Rows[3].Cells[3].Value.ToString().Replace("$", ""));

                double precio = p1 + p2 + p3;
                txttotal.Text = precio.ToString();
              
            }
            else if (dataGridView1.Rows.Count == 4)
            {
               
                double p1 = Convert.ToDouble(dataGridView1.Rows[0].Cells[3].Value.ToString().Replace("$", ""));
                double p2 = Convert.ToDouble(dataGridView1.Rows[1].Cells[3].Value.ToString().Replace("$", ""));
                double p3 = Convert.ToDouble(dataGridView1.Rows[2].Cells[3].Value.ToString().Replace("$", ""));
                double p4 = Convert.ToDouble(dataGridView1.Rows[3].Cells[3].Value.ToString().Replace("$", ""));
               // double p5 = Convert.ToDouble(dataGridView1.Rows[4].Cells[3].Value.ToString().Replace("$", ""));

                double precio = p1 + p2 + p3 + p4;
                txttotal.Text = precio.ToString();
            
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

        private void crearpedido_Load(object sender, EventArgs e)
        {
            combodias.Text = "1 día";
            combohoras.Text = "1 hora";
            string path = AppDomain.CurrentDomain.BaseDirectory + @"facturasebest2-firebase-adminsdk-rvc9d-2a1a79f585.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            database = FirestoreDb.Create("facturasebest2");



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

        private void txtabono_TextChanged(object sender, EventArgs e)
        {
            if(txtabono.Text != "")
            {          
                double p1 = Convert.ToDouble(txttotal.Text);

                double p2 = Convert.ToDouble(txtabono.Text);
                double restante = p1 - p2;

                txtrestante.Text = restante.ToString();
            }
            else if (txtabono.Text == "")
            {
                txtrestante.Text = txttotal.Text;
            }
        }

        private void checkiva_CheckedChanged(object sender, EventArgs e)
        {
            if (checkiva.Checked == true )
            {
                if(txtabono.Text != "")
                {
                    double p1 = Convert.ToDouble(txttotal.Text);
                    double precio = (p1 * .08) + p1;
                    txttotal.Text = precio.ToString();
                    double p2 = Convert.ToDouble(txtabono.Text);
                    double res = precio - p2;

                    txtrestante.Text = res.ToString();
                }
                else
                {
                    double p1 = Convert.ToDouble(txttotal.Text);
                    double precio = (p1 * .08) + p1;
                    txttotal.Text = precio.ToString();
                }
               
                
            }
            else if (checkiva.Checked == false)
            {


                if (dataGridView1.Rows.Count == 0)
                {
                    txttotal.Text = "0";
                }

                else if (dataGridView1.Rows.Count == 1)
                {

                    double p1 = Convert.ToDouble(dataGridView1.Rows[0].Cells[3].Value.ToString().Replace("$", ""));
                    //double p2 = Convert.ToDouble(dataGridView1.Rows[1].Cells[3].Value.ToString().Replace("$", ""));

                    double precio = p1;
                    txttotal.Text = precio.ToString();
                    if (txtabono.Text != "")
                    {
                    double p2 = Convert.ToDouble(txtabono.Text);
                    double res = precio - p2;

                    txtrestante.Text = res.ToString();
                    }
                    

                }
                else if (dataGridView1.Rows.Count == 2)
                {

                    double p1 = Convert.ToDouble(dataGridView1.Rows[0].Cells[3].Value.ToString().Replace("$", ""));
                    double p2 = Convert.ToDouble(dataGridView1.Rows[1].Cells[3].Value.ToString().Replace("$", ""));
                    // double p3 = Convert.ToDouble(dataGridView1.Rows[2].Cells[3].Value.ToString().Replace("$", ""));

                    double precio = p1 + p2;
                    txttotal.Text = precio.ToString();
                    if (txtabono.Text != "")
                    {
                        double abono = Convert.ToDouble(txtabono.Text);
                        double res = precio - abono;

                        txtrestante.Text = res.ToString();
                    }

                }
                else if (dataGridView1.Rows.Count == 3)
                {

                    double p1 = Convert.ToDouble(dataGridView1.Rows[0].Cells[3].Value.ToString().Replace("$", ""));
                    double p2 = Convert.ToDouble(dataGridView1.Rows[1].Cells[3].Value.ToString().Replace("$", ""));
                    double p3 = Convert.ToDouble(dataGridView1.Rows[2].Cells[3].Value.ToString().Replace("$", ""));
                    // double p4 = Convert.ToDouble(dataGridView1.Rows[3].Cells[3].Value.ToString().Replace("$", ""));

                    double precio = p1 + p2 + p3;
                    txttotal.Text = precio.ToString();
                    if (txtabono.Text != "")
                    {
                        double abono = Convert.ToDouble(txtabono.Text);
                        double res = precio - abono;

                        txtrestante.Text = res.ToString();
                    }


                }
                else if (dataGridView1.Rows.Count == 4)
                {
                    double p1 = Convert.ToDouble(dataGridView1.Rows[0].Cells[3].Value.ToString().Replace("$", ""));
                    double p2 = Convert.ToDouble(dataGridView1.Rows[1].Cells[3].Value.ToString().Replace("$", ""));
                    double p3 = Convert.ToDouble(dataGridView1.Rows[2].Cells[3].Value.ToString().Replace("$", ""));
                    double p4 = Convert.ToDouble(dataGridView1.Rows[3].Cells[3].Value.ToString().Replace("$", ""));
                    // double p5 = Convert.ToDouble(dataGridView1.Rows[4].Cells[3].Value.ToString().Replace("$", ""));

                    double precio = p1 + p2 + p3 + p4;
                    txttotal.Text = precio.ToString();
                    if (txtabono.Text != "")
                    {
                        double abono = Convert.ToDouble(txtabono.Text);
                        double res = precio - abono;

                        txtrestante.Text = res.ToString();
                    }
                }
                else if (dataGridView1.Rows.Count == 5)
                {
                    double p1 = Convert.ToDouble(dataGridView1.Rows[0].Cells[3].Value.ToString().Replace("$", ""));
                    double p2 = Convert.ToDouble(dataGridView1.Rows[1].Cells[3].Value.ToString().Replace("$", ""));
                    double p3 = Convert.ToDouble(dataGridView1.Rows[2].Cells[3].Value.ToString().Replace("$", ""));
                    double p4 = Convert.ToDouble(dataGridView1.Rows[3].Cells[3].Value.ToString().Replace("$", ""));
                    double p5 = Convert.ToDouble(dataGridView1.Rows[4].Cells[3].Value.ToString().Replace("$", ""));

                    // double p5 = Convert.ToDouble(dataGridView1.Rows[4].Cells[3].Value.ToString().Replace("$", ""));

                    double precio = p1 + p2 + p3 + p4 + p5;
                    txttotal.Text = precio.ToString();
                    if (txtabono.Text != "")
                    {
                        double abono = Convert.ToDouble(txtabono.Text);
                        double res = precio - abono;

                        txtrestante.Text = res.ToString();
                    }

                }
            }
           
        }

        private void txtabono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkcontra_CheckedChanged(object sender, EventArgs e)
        {

            if (checkcontra.Checked == true)
            {
                txtcontracel.Visible = true;
            }
            else
                txtcontracel.Visible = false;
        }

        private void checknoaplica_CheckedChanged(object sender, EventArgs e)
        {
            if (checknoaplica.Checked == true)
            {
                checkprotctor.Visible = false;
                checkchip.Visible = false;
                checkotros.Visible = false;
                txtotros.Visible = false;
            }
            else if (checknoaplica.Checked == false)
            {
                checkprotctor.Visible = true;
                checkchip.Visible = true;
                checkotros.Visible = true;
                txtotros.Visible = true;
            }
        }

        private void checkotros_CheckedChanged(object sender, EventArgs e)
        {
            if (checkotros.Checked == true)
            {
                checkprotctor.Visible = false;
                checkchip.Visible = false;
            }
            else if (checkotros.Checked == false)
            {
                checkprotctor.Visible = true;
                checkchip.Visible = true;
            }
        }
    }
}
