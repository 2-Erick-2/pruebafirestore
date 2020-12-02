﻿using System;
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

        String Accesorios = "";

        Double precio1;
        Double precio2;
        Double precio3;
        Double precio4;
        Double precio5;

        double IVA = 0;
        double totalsiniva = 0;

        public String desdecoti = "" ;


        public  String cant = "";
        public String cant2 = "";
        public String cant3 = "";
        public String cant4 = "";
        public String cant5 = "";

        public String descri = "";
        public String descri2 = "";
        public String descri3 = "";
        public String descri4 = "";
        public String descri5 = "";

        public String impor = "";
        public String impor2 = "";
        public String impor3 = "";
        public String impor4 = "";
        public String impor5 = "";

        public String total = "";

        public String Nombre = "";
        public String Numero = "";
        public String Modelo = "";

        public String Orden = "";

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




            altoButton1.Enabled = true;

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
               /* checkBox2.Visible = true;
                combodias.Visible = true;
                checkBox1.Visible = true;*/
                combohoras.Visible = true;
            }
            else if (checkrespuesta.Checked == false)
            {
               /* checkBox2.Visible = false;
                combodias.Visible = false;
                checkBox1.Visible = false;*/
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
            combohoras.Text = "3 - 4 dias";
            string path = AppDomain.CurrentDomain.BaseDirectory + @"facturasebest2-firebase-adminsdk-rvc9d-2a1a79f585.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            database = FirestoreDb.Create("facturasebest2");

            if (desdecoti == "si")
            {
                altoButton1.Enabled = true;
            }
            else             {
                altoButton1.Enabled = false;
            }

            if (ClaseCompartida.usuarios == "PERLA")
            {
                pdf.Visible = true;
            }

        }

        private void txtimporte_Leave(object sender, EventArgs e)
        {
            try
            {
                double precio = Convert.ToDouble(txtcantidad.Text) * Convert.ToDouble(txtimporte.Text);

                double cantidad = Convert.ToDouble(txtimporte.Text);

                if (cantidad > -1 && cantidad < 100)
                {
                    double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                    txtimporte.Text = d.ToString("$      .00", CultureInfo.InvariantCulture);
                }
                else if (cantidad > 99 && cantidad < 1000)
                {
                    double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                    txtimporte.Text = d.ToString("$    .00", CultureInfo.InvariantCulture);
                }
                else if (cantidad > 999 && cantidad < 9999)
                {
                    double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                    txtimporte.Text = d.ToString("$  .00", CultureInfo.InvariantCulture);
                }
                else if (cantidad > 9999 && cantidad < 99999)
                {
                    double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                    txtimporte.Text = d.ToString("$.00", CultureInfo.InvariantCulture);
                }


                if (precio > -1 && precio < 100)
                {
                    double d = Convert.ToDouble(precio, CultureInfo.InvariantCulture);
                    preciofinal = d.ToString("$      .00", CultureInfo.InvariantCulture);
                }
                else if (precio > 99 && precio < 1000)
                {
                    double d = Convert.ToDouble(precio, CultureInfo.InvariantCulture);
                    preciofinal = d.ToString("$    .00", CultureInfo.InvariantCulture);
                }
                else if (precio > 999 && precio < 9999)
                {
                    double d = Convert.ToDouble(precio, CultureInfo.InvariantCulture);
                    preciofinal = d.ToString("$  .00", CultureInfo.InvariantCulture);
                }
                else if (precio > 9999 && precio < 99999)
                {
                    double d = Convert.ToDouble(precio, CultureInfo.InvariantCulture);
                    preciofinal = d.ToString("$.00", CultureInfo.InvariantCulture);
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
            string firstfour = "";
            try
            {
                firstfour = txtabono.Text.Substring(0, 1);

            }
            catch(Exception)
            {
                //MessageBox.Show("Error: " + EX);
            }

            if (txtabono.Text != "" && firstfour != "$")
            {          

                double p1 = Convert.ToDouble(txttotal.Text);

                double p2 = Convert.ToDouble(txtabono.Text);
                double restante = p1 - p2;

                txtrestante.Text = restante.ToString();
                checkiva.Enabled = true;
            }
            else if (txtabono.Text == "")
            {
                txtrestante.Text = txttotal.Text;
                checkiva.Enabled = false;
            }
        }

        private void checkiva_CheckedChanged(object sender, EventArgs e)
        {
            if (checkiva.Checked == true )
            {
                if(txtabono.Text != "")
                {
                    double p1 = Convert.ToDouble(txttotal.Text);
                    IVA = p1 * .08;
                    txtIVA.Text = IVA.ToString();

                    double precio = (p1 * .08) + p1;

                    txttotal.Text = precio.ToString();
                    totalsiniva = precio - IVA;
                    txttotalsiniva.Text = totalsiniva.ToString();

                    double p2 = Convert.ToDouble(txtabono.Text);
                    double res = precio - p2;

                    txtrestante.Text = res.ToString();
                }
                else
                {
                    double p1 = Convert.ToDouble(txttotal.Text);
                    IVA = p1 * .08;
                    txtIVA.Text = IVA.ToString();
                    double precio = (p1 * .08) + p1;
                    txttotal.Text = precio.ToString();
                    totalsiniva = precio - IVA;
                    txttotalsiniva.Text = totalsiniva.ToString();
                    double p2 = Convert.ToDouble(txtabono.Text);
                    double res = precio - p2;
                    txtrestante.Text = res.ToString();
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
                checkprotctor.Visible = true;
                checkchip.Visible = true;
                checkotros.Visible = true;
                txtotros.Visible = true;   
            }
            else if (checknoaplica.Checked == false)
            {
                checkprotctor.Visible = false;
                checkchip.Visible = false;
                checkotros.Visible = false;
                txtotros.Visible = false;
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

        private  async void altoButton1_Click(object sender, EventArgs e)
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


                contar = txttotal.Text;
                if (contar.Length == 4)
                {
                    double d = Convert.ToDouble(txttotal.Text, CultureInfo.InvariantCulture);
                    txttotal.Text = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 3)
                {
                    double d = Convert.ToDouble(txttotal.Text, CultureInfo.InvariantCulture);
                    txttotal.Text = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 2)
                {
                    double d = Convert.ToDouble(txttotal.Text, CultureInfo.InvariantCulture);
                    txttotal.Text = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 6)
                {
                    double d = Convert.ToDouble(txttotal.Text, CultureInfo.InvariantCulture);
                    txttotal.Text = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 5)
                {
                    double d = Convert.ToDouble(txttotal.Text, CultureInfo.InvariantCulture);
                    txttotal.Text = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }



                contar = txttotalsiniva.Text;
                if (contar.Length == 4)
                {
                    double d = Convert.ToDouble(txttotalsiniva.Text, CultureInfo.InvariantCulture);
                    txttotalsiniva.Text = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 3)
                {
                    double d = Convert.ToDouble(txttotalsiniva.Text, CultureInfo.InvariantCulture);
                    txttotalsiniva.Text = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 2)
                {
                    double d = Convert.ToDouble(txttotalsiniva.Text, CultureInfo.InvariantCulture);
                    txttotalsiniva.Text = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 6)
                {
                    double d = Convert.ToDouble(txttotalsiniva.Text, CultureInfo.InvariantCulture);
                    txttotalsiniva.Text = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 5)
                {
                    double d = Convert.ToDouble(txttotalsiniva.Text, CultureInfo.InvariantCulture);
                    txttotalsiniva.Text = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }

                contar = txtIVA.Text;
                if (contar.Length == 4)
                {
                    double d = Convert.ToDouble(txtIVA.Text, CultureInfo.InvariantCulture);
                    txtIVA.Text = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 3)
                {
                    double d = Convert.ToDouble(txtIVA.Text, CultureInfo.InvariantCulture);
                    txtIVA.Text = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 2)
                {
                    double d = Convert.ToDouble(txtIVA.Text, CultureInfo.InvariantCulture);
                    txtIVA.Text = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 6)
                {
                    double d = Convert.ToDouble(txtIVA.Text, CultureInfo.InvariantCulture);
                    txtIVA.Text = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                }
                else if (contar.Length == 5)
                {
                    double d = Convert.ToDouble(txtIVA.Text, CultureInfo.InvariantCulture);
                    txtIVA.Text = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }



            if (checknoaplica.Checked == false)
            {
                Accesorios = "No aplica";

            }
            else if (checknoaplica.Checked == true && checkprotctor.Checked && checkchip.Checked == true)
            {
                Accesorios = "Protector y Chip";
            }
            else if (checknoaplica.Checked == true && checkprotctor.Checked == true)
            {
                Accesorios = "Protector";
            }
            else if (checknoaplica.Checked == true && checkchip.Checked == true)
            {
                Accesorios = "Chip";
            }
            else if (checknoaplica.Checked == true && checkotros.Checked == true)
            {
                Accesorios = txtotros.Text;

            }



            if (checkrespuesta.Checked == true && checkBox2.Checked == true)
            {
                tiemporespuesta = combodias.Text;
            }
            else if (checkrespuesta.Checked == true)
            {
                tiemporespuesta = combohoras.Text;
            }
            else if (checkrespuesta.Checked == false)
            {
                tiemporespuesta = "No aplica";
            }
            if (checkcontra.Checked == true)
            {
                contra = txtcontracel.Text;
            }
            else if (checkcontra.Checked == false)
            {
                contra = "No aplica";
            }
            sincopia:
            string Name = txtnombre2.Text;
            var rand = new Random();
            pedido = "PEDIDO";
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

            DocumentReference docRef = database.Collection("Pedidos").Document(txtorden.Text);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                MessageBox.Show("Repetido");
                goto sincopia;
            }


            else
            {
                DocumentReference DOC = database.Collection("Pedidos").Document("contador");
                Dictionary<String, Object> data1 = new Dictionary<string, object>()
                {
                 {"ID", FieldValue.Increment(1)}
                 };
                await DOC.SetAsync(data1, SetOptions.MergeAll);

                DocumentReference docRef2 = database.Collection("Pedidos").Document("contador");
                DocumentSnapshot snapsho2 = await docRef2.GetSnapshotAsync();
                if (snapsho2.Exists)
                {
                    Dictionary<string, object> counter = snapsho2.ToDictionary();
                    foreach (var item in counter)
                        lblcontador.Text = string.Format("{1}", item.Key, item.Value);
                }

                if (Orden != "")
                {
                    DocumentReference cityRef = database.Collection("Cotizaciones").Document(Orden);
                    await cityRef.DeleteAsync();

                }
                // int id = (int)Convert.ToInt64(lblcontador.Text);
                BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
                Codigo.IncludeLabel = true;
                pictureBox2.Image = Codigo.Encode(BarcodeLib.TYPE.CODE128, txtorden.Text, Color.Black, Color.White, 230, 60);
                //Create a Bitmap and draw the DataGridView on it.
                Bitmap bitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
                //Resize DataGridView back to original height.
                //dataGridView1.Height = height;
                //Save the Bitmap to folder.
                //bitmap.Save(@"D:\DataGridView.png");

                //BrotherPrintThis();

                printDocument1 = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                printDocument1.PrinterSettings = ps;
                printDocument1.PrintPage += impresion;
                printDocument1.Print();
                //printPreviewDialog1.Document = printDocument1;
                //printDocument1.Print();
                //printDocument1.Print();
                // printPreviewDialog1.Show();
                //Add_Document_with_orden();

                if (pdf.Checked == true)
                {
                    printDocument1 = new PrintDocument();
                    PrinterSettings ps2 = new PrinterSettings();
                    printDocument1.PrinterSettings = ps2;
                    printDocument1.PrinterSettings.PrinterName = "Microsoft Print to PDF";

                    printDocument1.PrintPage += impresion2;
                    printDocument1.Print();
                }


                if (Orden != "")
                {
                    this.Hide();
                }
                button3.Enabled = true;
                button4.Enabled = true;
                altoButton1.Enabled = false;
            }
        }






        public void BrotherPrintThis()
        {
            try
            {
                string path = @"C:\cartaebest3.lbx";
                bpac.Document doc = new bpac.Document();
                doc.Open(path);
                bool test = doc.SetPrinter("Brother QL-800", true);
                string pedido2 = "Tipo pedido: " + pedido;
                string nombre = "Nombre: " + txtnombre.Text;
                string numero = "Numero: " + txtnumero.Text;
                string obser = " ";
                string orden = "Numero orden: " + txtorden.Text;
                string orden2 = txtorden.Text;
                doc.GetObject("pedido").Text = pedido2;
                doc.GetObject("nombre").Text = nombre;
                doc.GetObject("numero").Text = numero;
                doc.GetObject("modelo").Text = "Modelo: " + txtmodelo.Text;
                doc.GetObject("fecha").Text = txthorayfecha.Text;
                doc.GetObject("obser").Text = obser;
                //doc.GetObject("orden").Text = orden;
                doc.GetObject("codigo").Text = orden2;
                //doc.GetObject("tiempo").Text = espera;
                doc.StartPrint("", bpac.PrintOptionConstants.bpoDefault);
                doc.PrintOut(1, bpac.PrintOptionConstants.bpoDefault);
                doc.EndPrint();
                doc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void impresion(object sender, PrintPageEventArgs e)
        {
            Image newImage = Properties.Resources.ebestimprimr4;
            int y = 100;

            // Create rectangle for source image.
            RectangleF srcRect = new RectangleF(100.0F, 100.0F, 150.0F, 150.0F);
            e.Graphics.DrawImage(newImage, 30, 2);

            //e.Graphics.DrawImageUnscaledAndClipped(newImage,new Point(10,10));
            e.Graphics.DrawString("             Pedido", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(5, y));
            e.Graphics.DrawString("                                       id: " + lblcontador.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 40));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            e.Graphics.DrawString("                    GUGE900514C70", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 30));
            e.Graphics.DrawString("     Calle Pedro J. Méndez No.1082-A OTE.", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                  Reynosa Tamaulipas", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                             88500", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                         8999222312", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                         8994349816", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                         8991420006", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                  e-best@live.com.mx", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("      Fecha: " + txthorayfecha.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 25));
            e.Graphics.DrawString("      Nombre: " + txtnombre.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("      Numero: " + txtnumero.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            e.Graphics.DrawString("      Modelo: " + txtmarca.Text + " " + txtmodelo.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            
             if (checkrespuesta.Checked == true)
            {
                e.Graphics.DrawString("      Tiempo de espera: " + combohoras.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            }

            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("    Cant. ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                       Descripción ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y));
            e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y));
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int d = y;
                // MessageBox.Show(d.ToString());
                e.Graphics.DrawString(row.Cells["Cantidad"].Value.ToString() + "         " + row.Cells["Descripcion"].Value.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(25, y += 20));
                e.Graphics.DrawString("                                              " + row.Cells["Importe"].Value.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(25, d += 20));

                // e.Graphics.DrawString(dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString(), new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(5, y +=40));
            }
            String p1 = "";
            String p2 = "";
            String p3 = "";
            String p4 = "";
            String p5 = "";

            String c1 = "";
            String c2 = "";
            String c3 = "";
            String c4 = "";
            String c5 = "";

            String d1 = "";
            String d2 = "";
            String d3 = "";
            String d4 = "";
            String d5 = "";


            String TOTALFINAL = "";


            Double total = 0;

            double iva = 0;

            double ivasin = 0;

            double abono = Convert.ToDouble(txtabono.Text.Replace("$", ""));

            if (dataGridView1.Rows.Count == 1)
            {
                p1 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString().Replace("$", "");
                c1 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                d1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();



                total = Convert.ToDouble(p1);
                ivasin = total * .08;
                iva = total * 1.08;
            }
            else if (dataGridView1.Rows.Count == 2)
            {
                p1 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString().Replace("$", "");
                p2 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString().Replace("$", "");


                c1 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                c2 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();

                d1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                d2 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();


                total = Convert.ToDouble(p1) + Convert.ToDouble(p2);
                ivasin = total * .08;

                iva = total * 1.08;
            }
            else if (dataGridView1.Rows.Count == 3)
            {
                p1 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString().Replace("$", "");
                p2 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString().Replace("$", "");
                p3 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString().Replace("$", "");

                c1 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                c2 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                c3 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();


                d1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                d2 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                d3 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();


                total = Convert.ToDouble(p1) + Convert.ToDouble(p2) + Convert.ToDouble(p3);
                ivasin = total * .08;

                iva = total * 1.08;
            }
            else if (dataGridView1.Rows.Count == 4)
            {
                p1 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString().Replace("$", "");
                p2 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString().Replace("$", "");
                p3 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString().Replace("$", "");
                p4 = dataGridView1.Rows[3].Cells["Importe"].Value.ToString().Replace("$", "");


                c1 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                c2 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                c3 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();
                c4 = dataGridView1.Rows[3].Cells["Cantidad"].Value.ToString();


                d1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                d2 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                d3 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();
                d4 = dataGridView1.Rows[3].Cells["Descripcion"].Value.ToString();

                total = Convert.ToDouble(p1) + Convert.ToDouble(p2) + Convert.ToDouble(p3) + Convert.ToDouble(p4);
                ivasin = total * .08;


                iva = total * 1.08;
            }
            else if (dataGridView1.Rows.Count == 5)
            {
                p1 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString().Replace("$", "");
                p2 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString().Replace("$", "");
                p3 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString().Replace("$", "");
                p4 = dataGridView1.Rows[3].Cells["Importe"].Value.ToString().Replace("$", "");
                p5 = dataGridView1.Rows[4].Cells["Importe"].Value.ToString().Replace("$", "");

                c1 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                c2 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                c3 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();
                c4 = dataGridView1.Rows[3].Cells["Cantidad"].Value.ToString();
                c5 = dataGridView1.Rows[4].Cells["Cantidad"].Value.ToString();


                d1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                d2 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                d3 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();
                d4 = dataGridView1.Rows[3].Cells["Descripcion"].Value.ToString();
                d5 = dataGridView1.Rows[4].Cells["Descripcion"].Value.ToString();

                total = Convert.ToDouble(p1) + Convert.ToDouble(p2) + Convert.ToDouble(p3) + Convert.ToDouble(p4) + Convert.ToDouble(p5);
                ivasin = total * .08;


                iva = total * 1.08;

            }


            String preciototal = "";

            String ivatotal = "";

            String ivasintotal = "";

            String Abono = "";

            String res = "";

            if (total > -1 && total < 100)
            {
                double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                preciototal = d.ToString("$      .00", CultureInfo.InvariantCulture);
            }
            else if (total > 99 && total < 1000)
            {
                double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                preciototal = d.ToString("$    .00", CultureInfo.InvariantCulture);
            }
            else if (total > 999 && total < 10000)
            {
                double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                preciototal = d.ToString("$  .00", CultureInfo.InvariantCulture);
            }
            else if (total > 9999 && total < 100000)
            {
                double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                preciototal = d.ToString("$.00", CultureInfo.InvariantCulture);
            }

            if (iva > -1 && iva < 100)
            {
                double d = Convert.ToDouble(iva.ToString(), CultureInfo.InvariantCulture);
                ivatotal = d.ToString("$      .00", CultureInfo.InvariantCulture);
            }
            else if (iva > 99 && iva < 1000)
            {
                double d = Convert.ToDouble(iva.ToString(), CultureInfo.InvariantCulture);
                ivatotal = d.ToString("$    .00", CultureInfo.InvariantCulture);
            }
            else if (iva > 999 && iva < 10000)
            {
                double d = Convert.ToDouble(iva.ToString(), CultureInfo.InvariantCulture);
                ivatotal = d.ToString("$  .00", CultureInfo.InvariantCulture);
            }
            else if (iva > 9999 && iva < 100000)
            {
                double d = Convert.ToDouble(iva.ToString(), CultureInfo.InvariantCulture);
                ivatotal = d.ToString("$.00", CultureInfo.InvariantCulture);
            }

            if (ivasin > -1 && ivasin < 100)
            {
                double d = Convert.ToDouble(ivasin.ToString(), CultureInfo.InvariantCulture);
                ivasintotal = d.ToString("$      .00", CultureInfo.InvariantCulture);
            }
            else if (ivasin > 99 && ivasin < 1000)
            {
                double d = Convert.ToDouble(ivasin.ToString(), CultureInfo.InvariantCulture);
                ivasintotal = d.ToString("$    .00", CultureInfo.InvariantCulture);
            }
            else if (ivasin > 999 && ivasin < 10000)
            {
                double d = Convert.ToDouble(ivasin.ToString(), CultureInfo.InvariantCulture);
                ivasintotal = d.ToString("$  .00", CultureInfo.InvariantCulture);
            }
            else if (ivasin > 9999 && ivasin < 100000)
            {
                double d = Convert.ToDouble(ivasin.ToString(), CultureInfo.InvariantCulture);
                ivasintotal = d.ToString("$.00", CultureInfo.InvariantCulture);
            }

            if (abono > -1 && abono < 100)
            {
                double d = Convert.ToDouble(abono.ToString(), CultureInfo.InvariantCulture);
                Abono = d.ToString("$      .00", CultureInfo.InvariantCulture);
            }
            else if (abono > 99 && abono < 1000)
            {
                double d = Convert.ToDouble(abono.ToString(), CultureInfo.InvariantCulture);
                Abono = d.ToString("$    .00", CultureInfo.InvariantCulture);
            }
            else if (abono > 999 && abono < 10000)
            {
                double d = Convert.ToDouble(abono.ToString(), CultureInfo.InvariantCulture);
                Abono = d.ToString("$  .00", CultureInfo.InvariantCulture);
            }
            else if (abono > 9999 && abono < 100000)
            {
                double d = Convert.ToDouble(abono.ToString(), CultureInfo.InvariantCulture);
                Abono = d.ToString("$.00", CultureInfo.InvariantCulture);
            }

            if (checkiva.Checked == true)
            {
                double restante = iva - abono;
                

                if (restante > -1 && restante < 100)
                {
                    double d = Convert.ToDouble(restante.ToString(), CultureInfo.InvariantCulture);
                    res = d.ToString("$      .00", CultureInfo.InvariantCulture);
                }
                else if (restante > 99 && restante < 1000)
                {
                    double d = Convert.ToDouble(restante.ToString(), CultureInfo.InvariantCulture);
                    res = d.ToString("$    .00", CultureInfo.InvariantCulture);
                }
                else if (restante > 999 && restante < 10000)
                {
                    double d = Convert.ToDouble(restante.ToString(), CultureInfo.InvariantCulture);
                    res = d.ToString("$  .00", CultureInfo.InvariantCulture);
                }
                else if (restante > 9999 && restante < 100000)
                {
                    double d = Convert.ToDouble(restante.ToString(), CultureInfo.InvariantCulture);
                    res = d.ToString("$.00", CultureInfo.InvariantCulture);
                }

                e.Graphics.DrawString("                                  SubTotal: " + preciototal, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 25));
                e.Graphics.DrawString("                                           IVA: " + ivasintotal, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("                                        Total: " + ivatotal, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("                                      Abono: " + Abono, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y+=20));
                e.Graphics.DrawString("                                  Restante: " + res, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y+=20));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 25));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawImage(pictureBox2.Image, 40, y += 30);
                TOTALFINAL = ivatotal;
            }
            else
            {
                double restante = total - abono;
                

                if (restante > -1 && restante < 100)
                {
                    double d = Convert.ToDouble(restante.ToString(), CultureInfo.InvariantCulture);
                    res = d.ToString("$      .00", CultureInfo.InvariantCulture);
                }
                else if (restante > 99 && restante < 1000)
                {
                    double d = Convert.ToDouble(restante.ToString(), CultureInfo.InvariantCulture);
                    res = d.ToString("$    .00", CultureInfo.InvariantCulture);
                }
                else if (restante > 999 && restante < 10000)
                {
                    double d = Convert.ToDouble(restante.ToString(), CultureInfo.InvariantCulture);
                    res = d.ToString("$  .00", CultureInfo.InvariantCulture);
                }
                else if (restante > 9999 && restante < 100000)
                {
                    double d = Convert.ToDouble(restante.ToString(), CultureInfo.InvariantCulture);
                    res = d.ToString("$.00", CultureInfo.InvariantCulture);
                }

                e.Graphics.DrawString("                                        Total: " + preciototal, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 25));
                e.Graphics.DrawString("                                      Abono: " + Abono, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("                                  Restante: " + res, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 25));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawImage(pictureBox2.Image, 40, y += 30);
                TOTALFINAL = preciototal;
            }
            int id = (int)Convert.ToInt64(lblcontador.Text);
            DocumentReference DOC2 = database.Collection("Pedidos").Document(txtorden.Text);
            Dictionary<String, Object> data2 = new Dictionary<string, object>()
                {
                 {"ID", id},

                {"Orden", txtorden.Text},

                {"Nombre",txtnombre.Text},

                {"Numero",txtnumero.Text},

                {"Modelo",txtmodelo.Text},

                {"Cantidad",c1} ,

                {"Cantidad2",c2} ,

                {"Cantidad3",c3} ,

                {"Cantidad4",c4} ,

                {"Cantidad5",c5} ,

                {"Descripcion",d1},

                {"Descripcion2",d2},

                {"Descripcion3",d3},

                {"Descripcion4",d4},

                {"Descripcion5",d5},

                {"Importe",p1},

                {"Importe2",p2},

                {"Importe3",p3},

                {"Importe4",p4},

                {"Importe5",p5},

                {"Total", TOTALFINAL},

                 {"Abono",Abono},

                {"Restante", res},


                {"Tiempodeespera",tiemporespuesta},

                {"Fechayhora",txthorayfecha.Text},

                {"Contraseña", contra}
                };
            await DOC2.SetAsync(data2, SetOptions.MergeAll);
            MessageBox.Show("guardado");
        }




        private  void impresion2(object sender, PrintPageEventArgs e)
        {
            Image newImage = Properties.Resources.ebestimprimr4;
            int y = 100;

            // Create rectangle for source image.
            RectangleF srcRect = new RectangleF(100.0F, 100.0F, 150.0F, 150.0F);
            e.Graphics.DrawImage(newImage, 30, 2);

            //e.Graphics.DrawImageUnscaledAndClipped(newImage,new Point(10,10));
            e.Graphics.DrawString("             Pedido", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(5, y));
            e.Graphics.DrawString("                                       id: " + lblcontador.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 40));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            e.Graphics.DrawString("                    GUGE900514C70", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 30));
            e.Graphics.DrawString("     Calle Pedro J. Méndez No.1082-A OTE.", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                  Reynosa Tamaulipas", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                             88500", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                         8999222312", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                         8994349816", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                         8991420006", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                  e-best@live.com.mx", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("      Fecha: " + txthorayfecha.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 25));
            e.Graphics.DrawString("      Nombre: " + txtnombre.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("      Numero: " + txtnumero.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            e.Graphics.DrawString("      Modelo: " + txtmarca.Text + " " + txtmodelo.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));


            if (checkrespuesta.Checked == true)
            {
                e.Graphics.DrawString("      Tiempo de espera: " + combohoras.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            }

            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("    Cant. ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                       Descripción ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y));
            e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y));
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int d = y;
                // MessageBox.Show(d.ToString());
                e.Graphics.DrawString(row.Cells["Cantidad"].Value.ToString() + "         " + row.Cells["Descripcion"].Value.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(25, y += 20));
                e.Graphics.DrawString("                                              " + row.Cells["Importe"].Value.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(25, d += 20));

                // e.Graphics.DrawString(dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString(), new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(5, y +=40));
            }
            String p1 = "";
            String p2 = "";
            String p3 = "";
            String p4 = "";
            String p5 = "";

            String c1 = "";
            String c2 = "";
            String c3 = "";
            String c4 = "";
            String c5 = "";

            String d1 = "";
            String d2 = "";
            String d3 = "";
            String d4 = "";
            String d5 = "";


            String TOTALFINAL = "";


            Double total = 0;

            double iva = 0;

            double ivasin = 0;

            double abono = Convert.ToDouble(txtabono.Text.Replace("$", ""));

            if (dataGridView1.Rows.Count == 1)
            {
                p1 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString().Replace("$", "");
                c1 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                d1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();



                total = Convert.ToDouble(p1);
                ivasin = total * .08;
                iva = total * 1.08;
            }
            else if (dataGridView1.Rows.Count == 2)
            {
                p1 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString().Replace("$", "");
                p2 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString().Replace("$", "");


                c1 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                c2 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();

                d1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                d2 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();


                total = Convert.ToDouble(p1) + Convert.ToDouble(p2);
                ivasin = total * .08;

                iva = total * 1.08;
            }
            else if (dataGridView1.Rows.Count == 3)
            {
                p1 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString().Replace("$", "");
                p2 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString().Replace("$", "");
                p3 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString().Replace("$", "");

                c1 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                c2 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                c3 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();


                d1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                d2 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                d3 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();


                total = Convert.ToDouble(p1) + Convert.ToDouble(p2) + Convert.ToDouble(p3);
                ivasin = total * .08;

                iva = total * 1.08;
            }
            else if (dataGridView1.Rows.Count == 4)
            {
                p1 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString().Replace("$", "");
                p2 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString().Replace("$", "");
                p3 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString().Replace("$", "");
                p4 = dataGridView1.Rows[3].Cells["Importe"].Value.ToString().Replace("$", "");


                c1 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                c2 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                c3 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();
                c4 = dataGridView1.Rows[3].Cells["Cantidad"].Value.ToString();


                d1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                d2 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                d3 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();
                d4 = dataGridView1.Rows[3].Cells["Descripcion"].Value.ToString();

                total = Convert.ToDouble(p1) + Convert.ToDouble(p2) + Convert.ToDouble(p3) + Convert.ToDouble(p4);
                ivasin = total * .08;


                iva = total * 1.08;
            }
            else if (dataGridView1.Rows.Count == 5)
            {
                p1 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString().Replace("$", "");
                p2 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString().Replace("$", "");
                p3 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString().Replace("$", "");
                p4 = dataGridView1.Rows[3].Cells["Importe"].Value.ToString().Replace("$", "");
                p5 = dataGridView1.Rows[4].Cells["Importe"].Value.ToString().Replace("$", "");

                c1 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                c2 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                c3 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();
                c4 = dataGridView1.Rows[3].Cells["Cantidad"].Value.ToString();
                c5 = dataGridView1.Rows[4].Cells["Cantidad"].Value.ToString();


                d1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                d2 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                d3 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();
                d4 = dataGridView1.Rows[3].Cells["Descripcion"].Value.ToString();
                d5 = dataGridView1.Rows[4].Cells["Descripcion"].Value.ToString();

                total = Convert.ToDouble(p1) + Convert.ToDouble(p2) + Convert.ToDouble(p3) + Convert.ToDouble(p4) + Convert.ToDouble(p5);
                ivasin = total * .08;


                iva = total * 1.08;

            }


            String preciototal = "";

            String ivatotal = "";

            String ivasintotal = "";

            String Abono = "";

            String res = "";

            if (total > -1 && total < 100)
            {
                double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                preciototal = d.ToString("$      .00", CultureInfo.InvariantCulture);
            }
            else if (total > 99 && total < 1000)
            {
                double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                preciototal = d.ToString("$    .00", CultureInfo.InvariantCulture);
            }
            else if (total > 999 && total < 10000)
            {
                double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                preciototal = d.ToString("$  .00", CultureInfo.InvariantCulture);
            }
            else if (total > 9999 && total < 100000)
            {
                double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                preciototal = d.ToString("$.00", CultureInfo.InvariantCulture);
            }

            if (iva > -1 && iva < 100)
            {
                double d = Convert.ToDouble(iva.ToString(), CultureInfo.InvariantCulture);
                ivatotal = d.ToString("$      .00", CultureInfo.InvariantCulture);
            }
            else if (iva > 99 && iva < 1000)
            {
                double d = Convert.ToDouble(iva.ToString(), CultureInfo.InvariantCulture);
                ivatotal = d.ToString("$    .00", CultureInfo.InvariantCulture);
            }
            else if (iva > 999 && iva < 10000)
            {
                double d = Convert.ToDouble(iva.ToString(), CultureInfo.InvariantCulture);
                ivatotal = d.ToString("$  .00", CultureInfo.InvariantCulture);
            }
            else if (iva > 9999 && iva < 100000)
            {
                double d = Convert.ToDouble(iva.ToString(), CultureInfo.InvariantCulture);
                ivatotal = d.ToString("$.00", CultureInfo.InvariantCulture);
            }

            if (ivasin > -1 && ivasin < 100)
            {
                double d = Convert.ToDouble(ivasin.ToString(), CultureInfo.InvariantCulture);
                ivasintotal = d.ToString("$      .00", CultureInfo.InvariantCulture);
            }
            else if (ivasin > 99 && ivasin < 1000)
            {
                double d = Convert.ToDouble(ivasin.ToString(), CultureInfo.InvariantCulture);
                ivasintotal = d.ToString("$    .00", CultureInfo.InvariantCulture);
            }
            else if (ivasin > 999 && ivasin < 10000)
            {
                double d = Convert.ToDouble(ivasin.ToString(), CultureInfo.InvariantCulture);
                ivasintotal = d.ToString("$  .00", CultureInfo.InvariantCulture);
            }
            else if (ivasin > 9999 && ivasin < 100000)
            {
                double d = Convert.ToDouble(ivasin.ToString(), CultureInfo.InvariantCulture);
                ivasintotal = d.ToString("$.00", CultureInfo.InvariantCulture);
            }

            if (abono > -1 && abono < 100)
            {
                double d = Convert.ToDouble(abono.ToString(), CultureInfo.InvariantCulture);
                Abono = d.ToString("$      .00", CultureInfo.InvariantCulture);
            }
            else if (abono > 99 && abono < 1000)
            {
                double d = Convert.ToDouble(abono.ToString(), CultureInfo.InvariantCulture);
                Abono = d.ToString("$    .00", CultureInfo.InvariantCulture);
            }
            else if (abono > 999 && abono < 10000)
            {
                double d = Convert.ToDouble(abono.ToString(), CultureInfo.InvariantCulture);
                Abono = d.ToString("$  .00", CultureInfo.InvariantCulture);
            }
            else if (abono > 9999 && abono < 100000)
            {
                double d = Convert.ToDouble(abono.ToString(), CultureInfo.InvariantCulture);
                Abono = d.ToString("$.00", CultureInfo.InvariantCulture);
            }

            if (checkiva.Checked == true)
            {
                double restante = iva - abono;


                if (restante > -1 && restante < 100)
                {
                    double d = Convert.ToDouble(restante.ToString(), CultureInfo.InvariantCulture);
                    res = d.ToString("$      .00", CultureInfo.InvariantCulture);
                }
                else if (restante > 99 && restante < 1000)
                {
                    double d = Convert.ToDouble(restante.ToString(), CultureInfo.InvariantCulture);
                    res = d.ToString("$    .00", CultureInfo.InvariantCulture);
                }
                else if (restante > 999 && restante < 10000)
                {
                    double d = Convert.ToDouble(restante.ToString(), CultureInfo.InvariantCulture);
                    res = d.ToString("$  .00", CultureInfo.InvariantCulture);
                }
                else if (restante > 9999 && restante < 100000)
                {
                    double d = Convert.ToDouble(restante.ToString(), CultureInfo.InvariantCulture);
                    res = d.ToString("$.00", CultureInfo.InvariantCulture);
                }

                e.Graphics.DrawString("                                  SubTotal: " + preciototal, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 25));
                e.Graphics.DrawString("                                           IVA: " + ivasintotal, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("                                        Total: " + ivatotal, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("                                      Abono: " + Abono, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("                                  Restante: " + res, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 25));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawImage(pictureBox2.Image, 40, y += 30);
                TOTALFINAL = ivatotal;
            }
            else
            {
                double restante = total - abono;


                if (restante > -1 && restante < 100)
                {
                    double d = Convert.ToDouble(restante.ToString(), CultureInfo.InvariantCulture);
                    res = d.ToString("$      .00", CultureInfo.InvariantCulture);
                }
                else if (restante > 99 && restante < 1000)
                {
                    double d = Convert.ToDouble(restante.ToString(), CultureInfo.InvariantCulture);
                    res = d.ToString("$    .00", CultureInfo.InvariantCulture);
                }
                else if (restante > 999 && restante < 10000)
                {
                    double d = Convert.ToDouble(restante.ToString(), CultureInfo.InvariantCulture);
                    res = d.ToString("$  .00", CultureInfo.InvariantCulture);
                }
                else if (restante > 9999 && restante < 100000)
                {
                    double d = Convert.ToDouble(restante.ToString(), CultureInfo.InvariantCulture);
                    res = d.ToString("$.00", CultureInfo.InvariantCulture);
                }

                e.Graphics.DrawString("                                        Total: " + preciototal, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 25));
                e.Graphics.DrawString("                                      Abono: " + Abono, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("                                  Restante: " + res, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 25));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
                e.Graphics.DrawImage(pictureBox2.Image, 40, y += 30);
                TOTALFINAL = preciototal;
            }

        }



        private async void imprimir(object sender, PrintPageEventArgs e)
        {
            // Image newImage2 = Image.FromFile(@"\\EBEST-AB78DLU\ebest\ebestimprimr4.jpg");
            Image newImage = Properties.Resources.ebestimprimr4;

            printDocument1.PrinterSettings.PrinterName = "TM-T20II";

            // Create rectangle for source image.
            RectangleF srcRect = new RectangleF(100.0F, 100.0F, 150.0F, 150.0F);
            e.Graphics.DrawImage(newImage, 30, 2);

            //e.Graphics.DrawImageUnscaledAndClipped(newImage,new Point(10,10));
            e.Graphics.DrawString("             Pedido", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(5, 100));
            e.Graphics.DrawString("                                       ID: " + lblcontador.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, 140));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 150));
            e.Graphics.DrawString("                    GUGE900514C70", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 180));
            e.Graphics.DrawString("     Calle Pedro J. Méndez No.1082-A OTE.", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 200));
            e.Graphics.DrawString("                  Reynosa Tamaulipas", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 220));
            e.Graphics.DrawString("                             88500", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 240));
            e.Graphics.DrawString("                  e-best@live.com.mx", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 260));
            e.Graphics.DrawString("                         8999222312", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 280));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 300));
            e.Graphics.DrawString("      Fecha: " + txthorayfecha.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 330));
            e.Graphics.DrawString("      Nombre: " + txtnombre.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 350));
            e.Graphics.DrawString("      Modelo: " + txtmarca.Text + " " + txtmodelo.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 370));

            if (checkrespuesta.Checked == true && checkBox2.Checked == true)
            {
                e.Graphics.DrawString("      Tiempo de espera: " + combodias.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 390));

            }
            else if (checkrespuesta.Checked == true)
            {
                e.Graphics.DrawString("      Tiempo de espera: " + combohoras.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 390));

            }

            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 405));

            if (checkiva.Checked == false)
            {
                if (dataGridView1.Rows.Count == 1)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                           Total: " + txttotal.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 500));
                    e.Graphics.DrawString("                                         Abono: " + txtabono.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 520));
                    e.Graphics.DrawString("                                     Restante: " + txtrestante.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 540));


                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 560));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 585));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 605));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 635);

                    int id = (int)Convert.ToInt64(lblcontador.Text);
                    DocumentReference DOC2 = database.Collection("Pedidos").Document(txtorden.Text);

                    Dictionary<String, Object> data2 = new Dictionary<string, object>()
                {
                 {"ID", id},

                {"Orden", txtorden.Text},

                {"Nombre",txtnombre.Text},

                {"Numero",txtnumero.Text},      

                {"Modelo",txtmarca.Text + " "+txtmodelo.Text},

                {"Cantidad",p2} ,

                {"Total",txttotal.Text} ,

                {"Descripcion",p1} ,

                {"Importe",txttotal.Text},

                {"Abono",txtabono.Text},

                {"Restante",txtrestante.Text },

                {"Accesorios",Accesorios},


                {"Tiempodeespera",tiemporespuesta} ,

                {"Fechayhora",txthorayfecha.Text},

                {"Contraseña", contra}


                };
                    await DOC2.SetAsync(data2, SetOptions.MergeAll);
                    MessageBox.Show("guardado");

                }

                if (dataGridView1.Rows.Count == 2)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6);

                    String contar2 = total.ToString();
                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                     
                    e.Graphics.DrawString("                                           Total: " + txttotal.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 520));
                    e.Graphics.DrawString("                                         Abono: " + txtabono.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 540));
                    e.Graphics.DrawString("                                     Restante: " + txtrestante.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 560));


                    //e.Graphics.DrawString("                                            Total: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 520));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 580));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 605));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 625));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 655);




                    String cantidad = "*" + p2 + "*" + "*" + p5 + "*";
                    String descripcion = "*" + p1 + "*" + "*" + p4 + "*";
                    String importe = "*" + p3 + "*" + "*" + p6 + "*";

                    int id = (int)Convert.ToInt64(lblcontador.Text);
                    DocumentReference DOC2 = database.Collection("Pedidos").Document(txtorden.Text);

                    Dictionary<String, Object> data2 = new Dictionary<string, object>()
                {
                 {"ID", id},

                {"Orden", txtorden.Text},

                {"Nombre",txtnombre.Text},

                {"Numero",txtnumero.Text},

                {"Modelo",txtmarca.Text + " "+txtmodelo.Text},

                {"Cantidad",p2} ,

                {"Cantidad2",p5} ,


                {"Descripcion",p1} ,

                {"Descripcion2",p4} ,


                {"Importe",p3},
                {"Importe2",p6},

                {"Total", txttotal.Text},

                 {"Abono",txtabono.Text},

                {"Restante",txtrestante.Text },

                {"Accesorios",Accesorios},

                {"Tiempodeespera",tiemporespuesta} ,

                {"Fechayhora",txthorayfecha.Text},


                {"Contraseña", contra}


                };
                    await DOC2.SetAsync(data2, SetOptions.MergeAll);
                    MessageBox.Show("guardado");

                }

                if (dataGridView1.Rows.Count == 3)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    String p7 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();
                    String p8 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();
                    String p9 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString();

                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    e.Graphics.DrawString("           " + p8, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                            " + p7, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                                                      " + p9, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));




                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    p9 = p9.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6) + Convert.ToDouble(p9);

                    String contar2 = total.ToString();
                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }





                    e.Graphics.DrawString("                                           Total: " + txttotal.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 540));
                    e.Graphics.DrawString("                                         Abono: " + txtabono.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 560));
                    e.Graphics.DrawString("                                     Restante: " + txtrestante.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 580));




                    
                    //e.Graphics.DrawString("                                            Total: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 540));
                    
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 600));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 625));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 645));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 675);





                    String cantidad = "*" + p2 + "*" + "*" + p5 + "*" + "*" + p8 + "*";
                    String descripcion = "*" + p1 + "*" + "*" + p4 + "*" + "*" + p7 + "*";
                    String importe = "*" + p3 + "*" + "*" + p6 + "*" + "*" + p9 + "*";

                    int id = (int)Convert.ToInt64(lblcontador.Text);
                    DocumentReference DOC2 = database.Collection("Pedidos").Document(txtorden.Text);
                    Dictionary<String, Object> data2 = new Dictionary<string, object>()
                {
                 {"ID", id},

                {"Orden", txtorden.Text},

                {"Nombre",txtnombre.Text},

                {"Numero",txtnumero.Text},

                {"Modelo",txtmarca.Text + " "+txtmodelo.Text},


                {"Cantidad",p2} ,

                {"Cantidad2",p5} ,

                {"Cantidad3",p8} ,


                {"Descripcion",p1},

                {"Descripcion2",p4},

                {"Descripcion3",p7},


                {"Importe",p3},

                {"Importe2",p6},

                {"Importe3",p9},

                {"Accesorios",Accesorios},

                {"Total", txttotal.Text},

                 {"Abono",txtabono.Text},

                {"Restante",txtrestante.Text },

                {"Tiempodeespera",tiemporespuesta} ,

                {"Fechayhora",txthorayfecha.Text},

                {"Contraseña", contra}


                };
                    await DOC2.SetAsync(data2, SetOptions.MergeAll);
                    MessageBox.Show("guardado");
                }


                if (dataGridView1.Rows.Count == 4)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    String p7 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();
                    String p8 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();
                    String p9 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString();

                    String p10 = dataGridView1.Rows[3].Cells["Descripcion"].Value.ToString();
                    String p11 = dataGridView1.Rows[3].Cells["Cantidad"].Value.ToString();
                    String p12 = dataGridView1.Rows[3].Cells["Importe"].Value.ToString();


                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    e.Graphics.DrawString("           " + p8, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                            " + p7, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                                                      " + p9, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));

                    e.Graphics.DrawString("           " + p11, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                            " + p10, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                                                      " + p12, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));


                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    p9 = p9.Replace("$", "");
                    p12 = p12.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6) + Convert.ToDouble(p9) + Convert.ToDouble(p12);
                    String contar2 = total.ToString();
                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }





                    e.Graphics.DrawString("                                           Total: " + txttotal.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 560));
                    e.Graphics.DrawString("                                         Abono: " + txtabono.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 580));
                    e.Graphics.DrawString("                                     Restante: " + txtrestante.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 600));



                    //e.Graphics.DrawString("                                            Total: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 560));
                   
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 620));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 645));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 665));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 695);





                    String cantidad = "*" + p2 + "*" + "*" + p5 + "*" + "*" + p8 + "*" + "*" + p11 + "*";
                    String descripcion = "*" + p1 + "*" + "*" + p4 + "*" + "*" + p7 + "*" + "*" + p10 + "*";
                    String importe = "*" + p3 + "*" + "*" + p6 + "*" + "*" + p9 + "*" + "*" + p12 + "*";
                    int id = (int)Convert.ToInt64(lblcontador.Text);
                    DocumentReference DOC2 = database.Collection("Pedidos").Document(txtorden.Text);
                    Dictionary<String, Object> data2 = new Dictionary<string, object>()
                {
                 {"ID", id},

                {"Orden", txtorden.Text},

                {"Nombre",txtnombre.Text},

                {"Numero",txtnumero.Text},

                {"Modelo",txtmarca.Text + " "+txtmodelo.Text},


                {"Cantidad",p2} ,

                {"Cantidad2",p5} ,

                {"Cantidad3",p8} ,

                {"Cantidad4",p11} ,


                {"Descripcion",p1},

                {"Descripcion2",p4},

                {"Descripcion3",p7},

                {"Descripcion4",p10},



                {"Importe",p3},

                {"Importe2",p6},

                {"Importe3",p9},

                {"Importe4",p12},


                {"Total", txttotal.Text},

                {"Abono",txtabono.Text},

                {"Restante",txtrestante.Text },

                {"Accesorios",Accesorios},



                {"Tiempodeespera",tiemporespuesta} ,

                {"Fechayhora",txthorayfecha.Text},

                {"Contraseña", contra}


                };
                    await DOC2.SetAsync(data2, SetOptions.MergeAll);
                    MessageBox.Show("guardado");

                }


                if (dataGridView1.Rows.Count == 5)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    String p7 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();
                    String p8 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();
                    String p9 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString();

                    String p10 = dataGridView1.Rows[3].Cells["Descripcion"].Value.ToString();
                    String p11 = dataGridView1.Rows[3].Cells["Cantidad"].Value.ToString();
                    String p12 = dataGridView1.Rows[3].Cells["Importe"].Value.ToString();

                    String p13 = dataGridView1.Rows[4].Cells["Descripcion"].Value.ToString();
                    String p14 = dataGridView1.Rows[4].Cells["Cantidad"].Value.ToString();
                    String p15 = dataGridView1.Rows[4].Cells["Importe"].Value.ToString();


                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    e.Graphics.DrawString("           " + p8, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                            " + p7, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                                                      " + p9, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));

                    e.Graphics.DrawString("           " + p11, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                            " + p10, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                                                      " + p12, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));

                    e.Graphics.DrawString("           " + p14, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));
                    e.Graphics.DrawString("                            " + p13, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));
                    e.Graphics.DrawString("                                                      " + p15, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));


                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    p9 = p9.Replace("$", "");
                    p12 = p12.Replace("$", "");
                    p15 = p15.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6) + Convert.ToDouble(p9) + Convert.ToDouble(p12) + Convert.ToDouble(p15);
                    String contar2 = total.ToString();
                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);

                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    
                    
                    e.Graphics.DrawString("                                           Total: " + txttotal.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 580));
                    e.Graphics.DrawString("                                         Abono: " + txtabono.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 600));
                    e.Graphics.DrawString("                                     Restante: " + txtrestante.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 620));
                    //e.Graphics.DrawString("                                            Total: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 580));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 640));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 665));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 685));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 715);



                    String cantidad = "*" + p2 + "*" + "*" + p5 + "*" + "*" + p8 + "*" + "*" + p11 + "*" + "*" + p14 + "*";
                    String descripcion = "*" + p1 + "*" + "*" + p4 + "*" + "*" + p7 + "*" + "*" + p10 + "*" + "*" + p13 + "*";
                    String importe = "*" + p3 + "*" + "*" + p6 + "*" + "*" + p9 + "*" + "*" + p12 + "*" + "*" + p15 + "*";


                    int id = (int)Convert.ToInt64(lblcontador.Text);
                    DocumentReference DOC2 = database.Collection("Pedidos").Document(txtorden.Text);
                    Dictionary<String, Object> data2 = new Dictionary<string, object>()
                {
                 {"ID", id},

                {"Orden", txtorden.Text},

                {"Nombre",txtnombre.Text},

                {"Numero",txtnumero.Text},

                {"Modelo",txtmarca.Text + " "+txtmodelo.Text},


                {"Cantidad",p2} ,

                {"Cantidad2",p5} ,

                {"Cantidad3",p8} ,

                {"Cantidad4",p11} ,

                {"Cantidad5",p14} ,


                {"Descripcion",p1},

                {"Descripcion2",p4},

                {"Descripcion3",p7},

                {"Descripcion4",p10},

                {"Descripcion5",p13},



                {"Importe",p3},

                {"Importe2",p6},

                {"Importe3",p9},

                {"Importe4",p12},

                {"Importe5",p15},

                {"Total", txttotal.Text},

                {"Abono",txtabono.Text},

                {"Restante",txtrestante.Text },

                {"Accesorios",Accesorios},


                {"Tiempodeespera",tiemporespuesta} ,

                {"Fechayhora",txthorayfecha.Text},

                {"Contraseña", contra}


                };
                    await DOC2.SetAsync(data2, SetOptions.MergeAll);
                    MessageBox.Show("guardado");
                }
            }
            else if (checkiva.Checked == true)


            {
                if (dataGridView1.Rows.Count == 1)
                {


                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();


                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    //e.Graphics.DrawString("                                     SubTotal: " + p3, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 500));

                    p3 = p3.Replace("$", "");

                    Double total = Convert.ToDouble(p3) * .08;
                    String contar2 = total.ToString();


                    Double total2 = Convert.ToDouble(contar2) + Convert.ToDouble(p3);
                    String contar3 = total2.ToString();
                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(total, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(total, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }



                    if (contar3.Length == 4)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 3)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 2)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 6)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 5)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }




                   
                    e.Graphics.DrawString("                                      Subtotal: " + txttotalsiniva.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 500));
                    e.Graphics.DrawString("                                              IVA: " + txtIVA.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 520));
                    e.Graphics.DrawString("                                         Abono: " + txtabono.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 540));
                    e.Graphics.DrawString("                                     Restante: " + txtrestante.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 560));


                    //e.Graphics.DrawString("                                              IVA: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 520));


                    //e.Graphics.DrawString("                                            Total: " + contar3, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 600));
                    

                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 580));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 605));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 625));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 655);



                    String cantidad = "*" + p2 + "*";
                    String descripcion = "*" + p1 + "*";
                    String importe = "*" + p3 + "*";


                    int id = (int)Convert.ToInt64(lblcontador.Text);
                    DocumentReference DOC2 = database.Collection("Pedidos").Document(txtorden.Text);
                    Dictionary<String, Object> data2 = new Dictionary<string, object>()
                {
                 {"ID", id},

                {"Orden", txtorden.Text},

                {"Nombre",txtnombre.Text},

                {"Numero",txtnumero.Text},

                {"Modelo",txtmarca.Text + " "+txtmodelo.Text},


                {"Cantidad",p2} ,




                {"Descripcion",p1},




                {"Importe",txttotal.Text},

                {"Total",txttotal.Text},

                {"Abono",txtabono.Text},

                {"Restante",txtrestante.Text},

                {"Accesorios",Accesorios},



                {"Tiempodeespera",tiemporespuesta} ,

                {"Fechayhora",txthorayfecha.Text},

                {"Contraseña", contra}


                };
                    await DOC2.SetAsync(data2, SetOptions.MergeAll);
                    MessageBox.Show("guardado");
                }

                if (dataGridView1.Rows.Count == 2)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6);
                    String contar2 = total.ToString();

                    Double total2 = total * .08;
                    String contar3 = total2.ToString();

                    Double total3 = total + total2;
                    String contar4 = total3.ToString();


                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }


                    if (contar3.Length == 4)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 3)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 2)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 6)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 5)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }



                    if (contar4.Length == 4)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 3)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 2)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 6)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 5)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }



                    e.Graphics.DrawString("                                      Subtotal: " + txttotalsiniva.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                                              IVA: " + txtIVA.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                                         Abono: " + txtabono.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 550));
                    e.Graphics.DrawString("                                     Restante: " + txtrestante.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 570));




                    // e.Graphics.DrawString("                                     SubTotal: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 520));
                    //e.Graphics.DrawString("                                              IVA: " + contar3, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 540));
                    //e.Graphics.DrawString("                                            Total: " + contar4, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 560));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 590));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 615));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 635));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 665);





                    int id = (int)Convert.ToInt64(lblcontador.Text);
                    DocumentReference DOC2 = database.Collection("Pedidos").Document(txtorden.Text);
                    Dictionary<String, Object> data2 = new Dictionary<string, object>()
                {
                 {"ID", id},

                {"Orden", txtorden.Text},

                {"Nombre",txtnombre.Text},

                {"Numero",txtnumero.Text},

                {"Modelo",txtmarca.Text + " "+txtmodelo.Text},


                {"Cantidad",p2} ,

                {"Cantidad2",p5} ,




                {"Descripcion",p1},

                {"Descripcion2",p4},


                {"Accesorios",Accesorios},


                {"Importe",p3},

                {"Importe2",p6},


                 {"Total",txttotal.Text},

                {"Abono",txtabono.Text},

                {"Restante",txtrestante.Text},

                {"Tiempodeespera",tiemporespuesta},

                {"Fechayhora",txthorayfecha.Text},

                {"Contraseña", contra}


                };
                    await DOC2.SetAsync(data2, SetOptions.MergeAll);
                    MessageBox.Show("guardado");
                }

                if (dataGridView1.Rows.Count == 3)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    String p7 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();
                    String p8 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();
                    String p9 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString();

                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    e.Graphics.DrawString("           " + p8, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                            " + p7, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                                                      " + p9, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));




                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    p9 = p9.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6) + Convert.ToDouble(p9);
                    String contar2 = total.ToString();


                    Double total2 = total * .08;
                    String contar3 = total2.ToString();

                    Double total3 = total + total2;
                    String contar4 = total3.ToString();




                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }


                    if (contar3.Length == 4)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 3)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 2)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 6)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 5)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }



                    if (contar4.Length == 4)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 3)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 2)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 6)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 5)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }



                    e.Graphics.DrawString("                                      Subtotal: " + txttotalsiniva.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                                              IVA: " + txtIVA.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 550));
                    e.Graphics.DrawString("                                         Abono: " + txtabono.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 570));
                    e.Graphics.DrawString("                                     Restante: " + txtrestante.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 590));


                    //e.Graphics.DrawString("                                     SubTotal: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 540));

                    //e.Graphics.DrawString("                                              IVA: " + contar3, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 560));


                    //e.Graphics.DrawString("                                            Total: " + contar4, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 580));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 610));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 635));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 655));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 685);





                    int id = (int)Convert.ToInt64(lblcontador.Text);
                    DocumentReference DOC2 = database.Collection("Pedidos").Document(txtorden.Text);
                    Dictionary<String, Object> data2 = new Dictionary<string, object>()
                {
                 {"ID", id},

                {"Orden", txtorden.Text},

                {"Nombre",txtnombre.Text},

                {"Numero",txtnumero.Text},

                {"Modelo",txtmarca.Text + " "+txtmodelo.Text},


                {"Cantidad",p2} ,

                {"Cantidad2",p5} ,

                {"Cantidad3",p8} ,




                {"Descripcion",p1},

                {"Descripcion2",p4},

                {"Descripcion3",p7},

                {"Accesorios",Accesorios},

                {"Importe",p3},

                {"Importe2",p6},

                {"Importe3",p9},


                 {"Total",txttotal.Text},

                {"Abono",txtabono.Text},

                {"Restante",txtrestante.Text},

                //{"Total", contar4},

                {"Tiempodeespera",tiemporespuesta} ,

                {"Fechayhora",txthorayfecha.Text},

                {"Contraseña", contra}


                };
                    await DOC2.SetAsync(data2, SetOptions.MergeAll);
                    MessageBox.Show("guardado");






                }


                if (dataGridView1.Rows.Count == 4)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    String p7 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();
                    String p8 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();
                    String p9 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString();

                    String p10 = dataGridView1.Rows[3].Cells["Descripcion"].Value.ToString();
                    String p11 = dataGridView1.Rows[3].Cells["Cantidad"].Value.ToString();
                    String p12 = dataGridView1.Rows[3].Cells["Importe"].Value.ToString();


                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    e.Graphics.DrawString("           " + p8, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                            " + p7, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                                                      " + p9, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));

                    e.Graphics.DrawString("           " + p11, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                            " + p10, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                                                      " + p12, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));


                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    p9 = p9.Replace("$", "");
                    p12 = p12.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6) + Convert.ToDouble(p9) + Convert.ToDouble(p12);
                    String contar2 = total.ToString();


                    Double total2 = total * .08;
                    String contar3 = total2.ToString();

                    Double total3 = total + total2;
                    String contar4 = total3.ToString();




                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }


                    if (contar3.Length == 4)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 3)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 2)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 6)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 5)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }



                    if (contar4.Length == 4)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 3)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 2)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 6)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 5)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }



                    e.Graphics.DrawString("                                      Subtotal: " + txttotalsiniva.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 550));
                    e.Graphics.DrawString("                                              IVA: " + txtIVA.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 570));
                    e.Graphics.DrawString("                                         Abono: " + txtabono.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 590));
                    e.Graphics.DrawString("                                     Restante: " + txtrestante.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 610));



                    //e.Graphics.DrawString("                                     SubTotal: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 560));

                    //e.Graphics.DrawString("                                              IVA: " + contar3, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 580));


                    //e.Graphics.DrawString("                                            Total: " + contar4, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 600));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 630));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 655));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 675));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 705);




                    int id = (int)Convert.ToInt64(lblcontador.Text);
                    DocumentReference DOC2 = database.Collection("Pedidos").Document(txtorden.Text);
                    Dictionary<String, Object> data2 = new Dictionary<string, object>()
                {
                 {"ID", id},

                {"Orden", txtorden.Text},

                {"Nombre",txtnombre.Text},

                {"Numero",txtnumero.Text},

                {"Modelo",txtmarca.Text + " "+txtmodelo.Text},


                {"Cantidad",p2} ,

                {"Cantidad2",p5} ,

                {"Cantidad3",p8} ,

                {"Cantidad4",p11} ,




                {"Descripcion",p1},

                {"Descripcion2",p4},

                {"Descripcion3",p7},

                {"Descripcion4",p10},


                {"Accesorios",Accesorios},




                {"Importe",p3},

                {"Importe2",p6},

                {"Importe3",p9},

                {"Importe4",p12},


                {"Total",txttotal.Text},

                {"Abono",txtabono.Text},

                {"Restante",txtrestante.Text},


                //{"Total", contar4},

                {"Tiempodeespera",tiemporespuesta} ,

                {"Fechayhora",txthorayfecha.Text},

                {"Contraseña", contra}


                };
                    await DOC2.SetAsync(data2, SetOptions.MergeAll);
                    MessageBox.Show("guardado");





                }


                if (dataGridView1.Rows.Count == 5)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    String p7 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();
                    String p8 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();
                    String p9 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString();

                    String p10 = dataGridView1.Rows[3].Cells["Descripcion"].Value.ToString();
                    String p11 = dataGridView1.Rows[3].Cells["Cantidad"].Value.ToString();
                    String p12 = dataGridView1.Rows[3].Cells["Importe"].Value.ToString();

                    String p13 = dataGridView1.Rows[4].Cells["Descripcion"].Value.ToString();
                    String p14 = dataGridView1.Rows[4].Cells["Cantidad"].Value.ToString();
                    String p15 = dataGridView1.Rows[4].Cells["Importe"].Value.ToString();


                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    e.Graphics.DrawString("           " + p8, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                            " + p7, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                                                      " + p9, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));

                    e.Graphics.DrawString("           " + p11, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                            " + p10, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                                                      " + p12, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));

                    e.Graphics.DrawString("           " + p14, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));
                    e.Graphics.DrawString("                            " + p13, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));
                    e.Graphics.DrawString("                                                      " + p15, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));


                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    p9 = p9.Replace("$", "");
                    p12 = p12.Replace("$", "");
                    p15 = p15.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6) + Convert.ToDouble(p9) + Convert.ToDouble(p12) + Convert.ToDouble(p15);
                    String contar2 = total.ToString();

                    Double total2 = total * .08;
                    String contar3 = total2.ToString();

                    Double total3 = total + total2;
                    String contar4 = total3.ToString();


                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }




                    if (contar3.Length == 4)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 3)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 2)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 6)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 5)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }



                    if (contar4.Length == 4)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 3)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 2)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 6)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 5)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }


                    e.Graphics.DrawString("                                      Subtotal: " + txttotalsiniva.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 570));
                    e.Graphics.DrawString("                                              IVA: " + txtIVA.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 590));
                    e.Graphics.DrawString("                                         Abono: " + txtabono.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 610));
                    e.Graphics.DrawString("                                     Restante: " + txtrestante.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 630));
                    //e.Graphics.DrawString("                                     SubTotal: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 580));
                    //e.Graphics.DrawString("                                              IVA: " + contar3, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 600));
                    //e.Graphics.DrawString("                                            Total: " + contar4, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 620));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 650));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 675));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 695));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 725);

                    int id = (int)Convert.ToInt64(lblcontador.Text);
                    DocumentReference DOC2 = database.Collection("Pedidos").Document(txtorden.Text);
                    Dictionary<String, Object> data2 = new Dictionary<string, object>() 
                {
                 {"ID", id},

                {"Orden", txtorden.Text},

                {"Nombre",txtnombre.Text},

                {"Numero",txtnumero.Text},

                {"Modelo",txtmarca.Text + " "+txtmodelo.Text},

                {"Cantidad",p2} ,

                {"Cantidad2",p5} ,

                {"Cantidad3",p8} ,

                {"Cantidad4",p11} ,

                {"Cantidad5",p14} ,

                {"Descripcion",p1},

                {"Descripcion2",p4},

                {"Descripcion3",p7},

                {"Descripcion4",p10},

                {"Descripcion5",p13},

                {"Importe",p3},

                {"Importe2",p6},

                {"Importe3",p9},

                {"Importe4",p12},

                {"Importe5",p15},

                {"Total",txttotal.Text},

                {"Abono",txtabono.Text},

                {"Restante",txtrestante.Text},

                {"Accesorios",Accesorios},

               // {"Total", contar4},

                {"Tiempodeespera",tiemporespuesta},

                {"Fechayhora",txthorayfecha.Text},

                {"Contraseña", contra}

                };
                    await DOC2.SetAsync(data2, SetOptions.MergeAll);
                    MessageBox.Show("guardado");
                }
            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            txtnombre2.Text = txtnombre.Text;
            txtnombre.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtnombre.Text);
            txtnombre.SelectionStart = txtnombre.Text.Length;
        }

        private void txtabono_Leave(object sender, EventArgs e)
        {
            
        }

        private void altoButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToShortDateString();
            string hora = DateTime.Now.ToShortTimeString();
            txthorayfecha.Text = fecha + " " + hora;
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtmodelo_TextChanged(object sender, EventArgs e)
        {
            if (txtmodelo.Text == "")
            {

            }
            else
            {
                string upmodelo = txtmodelo.Text;
                upmodelo = upmodelo.Substring(0, 1).ToUpper() + upmodelo.Substring(1).ToLower();
                txtmodelo.Text = upmodelo;
                txtmodelo.SelectionStart = txtmodelo.Text.Length;
            }
        }

        private void txtrestante_TextChanged(object sender, EventArgs e)
        {
            if (txtabono.Text == "")
            {
                txtrestante.Text = txttotal.Text;
            }
        }



        private void imprimir2(object sender, PrintPageEventArgs e)
        {
            // Image newImage2 = Image.FromFile(@"\\EBEST-AB78DLU\ebest\ebestimprimr4.jpg");
            Image newImage = Properties.Resources.ebestimprimr4;

            printDocument1.PrinterSettings.PrinterName = "TM-T20II";

            // Create rectangle for source image.
            RectangleF srcRect = new RectangleF(100.0F, 100.0F, 150.0F, 150.0F);
            e.Graphics.DrawImage(newImage, 30, 2);

            //e.Graphics.DrawImageUnscaledAndClipped(newImage,new Point(10,10));
            e.Graphics.DrawString("             Pedido", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(5, 100));
            e.Graphics.DrawString("                                       ID: " + lblcontador.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, 140));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 150));
            e.Graphics.DrawString("                    GUGE900514C70", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 180));
            e.Graphics.DrawString("     Calle Pedro J. Méndez No.1082-A OTE.", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 200));
            e.Graphics.DrawString("                  Reynosa Tamaulipas", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 220));
            e.Graphics.DrawString("                             88500", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 240));
            e.Graphics.DrawString("                  e-best@live.com.mx", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 260));
            e.Graphics.DrawString("                         8999222312", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 280));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 300));
            e.Graphics.DrawString("      Fecha: " + txthorayfecha.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 330));
            e.Graphics.DrawString("      Nombre: " + txtnombre.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 350));
            e.Graphics.DrawString("      Modelo: " + txtmarca.Text + " " + txtmodelo.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 370));

            if (checkrespuesta.Checked == true && checkBox2.Checked == true)
            {
                e.Graphics.DrawString("      Tiempo de espera: " + combodias.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 390));

            }
            else if (checkrespuesta.Checked == true)
            {
                e.Graphics.DrawString("      Tiempo de espera: " + combohoras.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 390));

            }

            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 405));

            if (checkiva.Checked == false)
            {
                if (dataGridView1.Rows.Count == 1)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                           Total: " + txttotal.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 500));
                    e.Graphics.DrawString("                                         Abono: " + txtabono.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 520));
                    e.Graphics.DrawString("                                     Restante: " + txtrestante.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 540));


                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 560));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 585));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 605));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 635);

                    

                }

                if (dataGridView1.Rows.Count == 2)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6);

                    String contar2 = total.ToString();
                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }

                    e.Graphics.DrawString("                                           Total: " + txttotal.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 520));
                    e.Graphics.DrawString("                                         Abono: " + txtabono.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 540));
                    e.Graphics.DrawString("                                     Restante: " + txtrestante.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 560));


                    //e.Graphics.DrawString("                                            Total: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 520));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 580));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 605));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 625));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 655);




                    String cantidad = "*" + p2 + "*" + "*" + p5 + "*";
                    String descripcion = "*" + p1 + "*" + "*" + p4 + "*";
                    String importe = "*" + p3 + "*" + "*" + p6 + "*";

                    

                }

                if (dataGridView1.Rows.Count == 3)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    String p7 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();
                    String p8 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();
                    String p9 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString();

                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    e.Graphics.DrawString("           " + p8, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                            " + p7, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                                                      " + p9, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));




                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    p9 = p9.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6) + Convert.ToDouble(p9);

                    String contar2 = total.ToString();
                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }





                    e.Graphics.DrawString("                                           Total: " + txttotal.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 540));
                    e.Graphics.DrawString("                                         Abono: " + txtabono.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 560));
                    e.Graphics.DrawString("                                     Restante: " + txtrestante.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 580));





                    //e.Graphics.DrawString("                                            Total: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 540));

                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 600));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 625));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 645));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 675);





                    String cantidad = "*" + p2 + "*" + "*" + p5 + "*" + "*" + p8 + "*";
                    String descripcion = "*" + p1 + "*" + "*" + p4 + "*" + "*" + p7 + "*";
                    String importe = "*" + p3 + "*" + "*" + p6 + "*" + "*" + p9 + "*";

                    
                }


                if (dataGridView1.Rows.Count == 4)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    String p7 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();
                    String p8 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();
                    String p9 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString();

                    String p10 = dataGridView1.Rows[3].Cells["Descripcion"].Value.ToString();
                    String p11 = dataGridView1.Rows[3].Cells["Cantidad"].Value.ToString();
                    String p12 = dataGridView1.Rows[3].Cells["Importe"].Value.ToString();


                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    e.Graphics.DrawString("           " + p8, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                            " + p7, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                                                      " + p9, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));

                    e.Graphics.DrawString("           " + p11, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                            " + p10, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                                                      " + p12, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));


                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    p9 = p9.Replace("$", "");
                    p12 = p12.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6) + Convert.ToDouble(p9) + Convert.ToDouble(p12);
                    String contar2 = total.ToString();
                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }





                    e.Graphics.DrawString("                                           Total: " + txttotal.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 560));
                    e.Graphics.DrawString("                                         Abono: " + txtabono.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 580));
                    e.Graphics.DrawString("                                     Restante: " + txtrestante.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 600));



                    //e.Graphics.DrawString("                                            Total: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 560));

                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 620));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 645));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 665));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 695);





                    String cantidad = "*" + p2 + "*" + "*" + p5 + "*" + "*" + p8 + "*" + "*" + p11 + "*";
                    String descripcion = "*" + p1 + "*" + "*" + p4 + "*" + "*" + p7 + "*" + "*" + p10 + "*";
                    String importe = "*" + p3 + "*" + "*" + p6 + "*" + "*" + p9 + "*" + "*" + p12 + "*";
                   

                }


                if (dataGridView1.Rows.Count == 5)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    String p7 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();
                    String p8 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();
                    String p9 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString();

                    String p10 = dataGridView1.Rows[3].Cells["Descripcion"].Value.ToString();
                    String p11 = dataGridView1.Rows[3].Cells["Cantidad"].Value.ToString();
                    String p12 = dataGridView1.Rows[3].Cells["Importe"].Value.ToString();

                    String p13 = dataGridView1.Rows[4].Cells["Descripcion"].Value.ToString();
                    String p14 = dataGridView1.Rows[4].Cells["Cantidad"].Value.ToString();
                    String p15 = dataGridView1.Rows[4].Cells["Importe"].Value.ToString();


                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    e.Graphics.DrawString("           " + p8, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                            " + p7, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                                                      " + p9, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));

                    e.Graphics.DrawString("           " + p11, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                            " + p10, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                                                      " + p12, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));

                    e.Graphics.DrawString("           " + p14, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));
                    e.Graphics.DrawString("                            " + p13, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));
                    e.Graphics.DrawString("                                                      " + p15, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));


                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    p9 = p9.Replace("$", "");
                    p12 = p12.Replace("$", "");
                    p15 = p15.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6) + Convert.ToDouble(p9) + Convert.ToDouble(p12) + Convert.ToDouble(p15);
                    String contar2 = total.ToString();
                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);

                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }


                    e.Graphics.DrawString("                                           Total: " + txttotal.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 580));
                    e.Graphics.DrawString("                                         Abono: " + txtabono.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 600));
                    e.Graphics.DrawString("                                     Restante: " + txtrestante.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 620));
                    //e.Graphics.DrawString("                                            Total: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 580));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 640));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 665));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 685));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 715);



                    String cantidad = "*" + p2 + "*" + "*" + p5 + "*" + "*" + p8 + "*" + "*" + p11 + "*" + "*" + p14 + "*";
                    String descripcion = "*" + p1 + "*" + "*" + p4 + "*" + "*" + p7 + "*" + "*" + p10 + "*" + "*" + p13 + "*";
                    String importe = "*" + p3 + "*" + "*" + p6 + "*" + "*" + p9 + "*" + "*" + p12 + "*" + "*" + p15 + "*";


                   
                }
            }
            else if (checkiva.Checked == true)


            {
                if (dataGridView1.Rows.Count == 1)
                {


                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();


                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    //e.Graphics.DrawString("                                     SubTotal: " + p3, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 500));

                    p3 = p3.Replace("$", "");

                    Double total = Convert.ToDouble(p3) * .08;
                    String contar2 = total.ToString();


                    Double total2 = Convert.ToDouble(contar2) + Convert.ToDouble(p3);
                    String contar3 = total2.ToString();
                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(total, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(total, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }



                    if (contar3.Length == 4)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 3)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 2)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 6)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 5)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }





                    e.Graphics.DrawString("                                      Subtotal: " + txttotalsiniva.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 500));
                    e.Graphics.DrawString("                                              IVA: " + txtIVA.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 520));
                    e.Graphics.DrawString("                                         Abono: " + txtabono.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 540));
                    e.Graphics.DrawString("                                     Restante: " + txtrestante.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 560));


                    //e.Graphics.DrawString("                                              IVA: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 520));


                    //e.Graphics.DrawString("                                            Total: " + contar3, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 600));


                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 580));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 605));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 625));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 655);



                    String cantidad = "*" + p2 + "*";
                    String descripcion = "*" + p1 + "*";
                    String importe = "*" + p3 + "*";


                   
                }

                if (dataGridView1.Rows.Count == 2)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6);
                    String contar2 = total.ToString();

                    Double total2 = total * .08;
                    String contar3 = total2.ToString();

                    Double total3 = total + total2;
                    String contar4 = total3.ToString();


                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }


                    if (contar3.Length == 4)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 3)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 2)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 6)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 5)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }



                    if (contar4.Length == 4)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 3)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 2)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 6)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 5)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }



                    e.Graphics.DrawString("                                      Subtotal: " + txttotalsiniva.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                                              IVA: " + txtIVA.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                                         Abono: " + txtabono.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 550));
                    e.Graphics.DrawString("                                     Restante: " + txtrestante.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 570));




                    // e.Graphics.DrawString("                                     SubTotal: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 520));
                    //e.Graphics.DrawString("                                              IVA: " + contar3, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 540));
                    //e.Graphics.DrawString("                                            Total: " + contar4, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 560));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 590));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 615));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 635));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 665);





                  
                }

                if (dataGridView1.Rows.Count == 3)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    String p7 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();
                    String p8 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();
                    String p9 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString();

                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    e.Graphics.DrawString("           " + p8, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                            " + p7, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                                                      " + p9, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));




                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    p9 = p9.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6) + Convert.ToDouble(p9);
                    String contar2 = total.ToString();


                    Double total2 = total * .08;
                    String contar3 = total2.ToString();

                    Double total3 = total + total2;
                    String contar4 = total3.ToString();




                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }


                    if (contar3.Length == 4)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 3)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 2)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 6)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 5)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }



                    if (contar4.Length == 4)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 3)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 2)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 6)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 5)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }



                    e.Graphics.DrawString("                                      Subtotal: " + txttotalsiniva.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                                              IVA: " + txtIVA.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 550));
                    e.Graphics.DrawString("                                         Abono: " + txtabono.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 570));
                    e.Graphics.DrawString("                                     Restante: " + txtrestante.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 590));


                    //e.Graphics.DrawString("                                     SubTotal: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 540));

                    //e.Graphics.DrawString("                                              IVA: " + contar3, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 560));


                    //e.Graphics.DrawString("                                            Total: " + contar4, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 580));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 610));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 635));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 655));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 685);





                   

                }


                if (dataGridView1.Rows.Count == 4)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    String p7 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();
                    String p8 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();
                    String p9 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString();

                    String p10 = dataGridView1.Rows[3].Cells["Descripcion"].Value.ToString();
                    String p11 = dataGridView1.Rows[3].Cells["Cantidad"].Value.ToString();
                    String p12 = dataGridView1.Rows[3].Cells["Importe"].Value.ToString();


                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    e.Graphics.DrawString("           " + p8, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                            " + p7, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                                                      " + p9, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));

                    e.Graphics.DrawString("           " + p11, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                            " + p10, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                                                      " + p12, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));


                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    p9 = p9.Replace("$", "");
                    p12 = p12.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6) + Convert.ToDouble(p9) + Convert.ToDouble(p12);
                    String contar2 = total.ToString();


                    Double total2 = total * .08;
                    String contar3 = total2.ToString();

                    Double total3 = total + total2;
                    String contar4 = total3.ToString();




                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }


                    if (contar3.Length == 4)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 3)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 2)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 6)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 5)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }



                    if (contar4.Length == 4)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 3)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 2)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 6)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 5)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }



                    e.Graphics.DrawString("                                      Subtotal: " + txttotalsiniva.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 550));
                    e.Graphics.DrawString("                                              IVA: " + txtIVA.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 570));
                    e.Graphics.DrawString("                                         Abono: " + txtabono.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 590));
                    e.Graphics.DrawString("                                     Restante: " + txtrestante.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 610));



                    //e.Graphics.DrawString("                                     SubTotal: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 560));

                    //e.Graphics.DrawString("                                              IVA: " + contar3, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 580));


                    //e.Graphics.DrawString("                                            Total: " + contar4, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 600));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 630));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 655));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 675));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 705);




                  

                }


                if (dataGridView1.Rows.Count == 5)
                {
                    String p1 = dataGridView1.Rows[0].Cells["Descripcion"].Value.ToString();
                    String p2 = dataGridView1.Rows[0].Cells["Cantidad"].Value.ToString();
                    String p3 = dataGridView1.Rows[0].Cells["Importe"].Value.ToString();
                    String p4 = dataGridView1.Rows[1].Cells["Descripcion"].Value.ToString();
                    String p5 = dataGridView1.Rows[1].Cells["Cantidad"].Value.ToString();
                    String p6 = dataGridView1.Rows[1].Cells["Importe"].Value.ToString();
                    String p7 = dataGridView1.Rows[2].Cells["Descripcion"].Value.ToString();
                    String p8 = dataGridView1.Rows[2].Cells["Cantidad"].Value.ToString();
                    String p9 = dataGridView1.Rows[2].Cells["Importe"].Value.ToString();

                    String p10 = dataGridView1.Rows[3].Cells["Descripcion"].Value.ToString();
                    String p11 = dataGridView1.Rows[3].Cells["Cantidad"].Value.ToString();
                    String p12 = dataGridView1.Rows[3].Cells["Importe"].Value.ToString();

                    String p13 = dataGridView1.Rows[4].Cells["Descripcion"].Value.ToString();
                    String p14 = dataGridView1.Rows[4].Cells["Cantidad"].Value.ToString();
                    String p15 = dataGridView1.Rows[4].Cells["Importe"].Value.ToString();


                    //String p1 = dataGridView1.Columns
                    e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                    e.Graphics.DrawString("    Cantidad ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                           Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                    e.Graphics.DrawString("           " + p2, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                            " + p1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                    e.Graphics.DrawString("                                                      " + p3, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));

                    e.Graphics.DrawString("           " + p5, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                            " + p4, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                    e.Graphics.DrawString("                                                      " + p6, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                    e.Graphics.DrawString("           " + p8, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                            " + p7, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                    e.Graphics.DrawString("                                                      " + p9, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));

                    e.Graphics.DrawString("           " + p11, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                            " + p10, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                    e.Graphics.DrawString("                                                      " + p12, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));

                    e.Graphics.DrawString("           " + p14, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));
                    e.Graphics.DrawString("                            " + p13, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));
                    e.Graphics.DrawString("                                                      " + p15, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));


                    p3 = p3.Replace("$", "");
                    p6 = p6.Replace("$", "");
                    p9 = p9.Replace("$", "");
                    p12 = p12.Replace("$", "");
                    p15 = p15.Replace("$", "");
                    Double total = Convert.ToDouble(p3) + Convert.ToDouble(p6) + Convert.ToDouble(p9) + Convert.ToDouble(p12) + Convert.ToDouble(p15);
                    String contar2 = total.ToString();

                    Double total2 = total * .08;
                    String contar3 = total2.ToString();

                    Double total3 = total + total2;
                    String contar4 = total3.ToString();


                    if (contar2.Length == 4)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 3)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 2)
                    {
                        double d = Convert.ToDouble(total.ToString(), CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 6)
                    {
                        double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar2.Length == 5)
                    {
                        double d = Convert.ToDouble(txtimporte.Text, CultureInfo.InvariantCulture);
                        contar2 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }




                    if (contar3.Length == 4)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 3)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 2)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 6)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar3.Length == 5)
                    {
                        double d = Convert.ToDouble(total2.ToString(), CultureInfo.InvariantCulture);
                        contar3 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }



                    if (contar4.Length == 4)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 3)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 2)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$    00.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 6)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$0000.00", CultureInfo.InvariantCulture);
                    }
                    else if (contar4.Length == 5)
                    {
                        double d = Convert.ToDouble(total3.ToString(), CultureInfo.InvariantCulture);
                        contar4 = d.ToString("$  000.00", CultureInfo.InvariantCulture);
                    }


                    e.Graphics.DrawString("                                      Subtotal: " + txttotalsiniva.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 570));
                    e.Graphics.DrawString("                                              IVA: " + txtIVA.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 590));
                    e.Graphics.DrawString("                                         Abono: " + txtabono.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 610));
                    e.Graphics.DrawString("                                     Restante: " + txtrestante.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 630));
                    //e.Graphics.DrawString("                                     SubTotal: " + contar2, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 580));
                    //e.Graphics.DrawString("                                              IVA: " + contar3, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 600));
                    //e.Graphics.DrawString("                                            Total: " + contar4, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 620));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 650));
                    e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 675));
                    e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 695));
                    e.Graphics.DrawImage(pictureBox2.Image, 40, 725);

               
                }
            }
        }








        private void txttotal_TextChanged(object sender, EventArgs e)
        {
            if (txtabono.Text == "")
            {
                txtrestante.Text = txttotal.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;

            printDocument1.PrintPage += imprimir2;
            printDocument1.Print();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;

            printDocument1.PrintPage += impresion3;
            printDocument1.Print();
        }



        private void impresion3(object sender, PrintPageEventArgs e)
        {
            //Image newImage3 = Image.FromFile(@"D:\TODO\ebestimprimr4.jpg");
            Image newImage = Properties.Resources.ebestimprimr4;

            int y = 100;
            printDocument1.PrinterSettings.PrinterName = "TM-T20II";

            // Create rectangle for source image.
            RectangleF srcRect = new RectangleF(100.0F, 100.0F, 150.0F, 150.0F);
            e.Graphics.DrawImage(newImage, 30, 2);

            //e.Graphics.DrawImageUnscaledAndClipped(newImage,new Point(10,10));
            e.Graphics.DrawString("             Pedido", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(5, y));
            e.Graphics.DrawString("                                       id: " + lblcontador.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, y += 40));

            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                    GUGE900514C70", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("     Calle Pedro J. Méndez No.1082-A OTE.", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                  Reynosa Tamaulipas", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                             88500", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            //e.Graphics.DrawString("                  e-best@live.com.mx", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                         8999222312", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                         8994349816", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                         8991420006", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                  e-best@live.com.mx", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));


            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("      Fecha: " + txthorayfecha.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("      Nombre: " + txtnombre.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("      Numero: " + txtnumero.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            e.Graphics.DrawString("      Modelo: " + txtmodelo.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            if (checkrespuesta.Checked == true && checkBox2.Checked == true)
            {
                e.Graphics.DrawString("      Tiempo de espera: " + combodias.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            }
            else if (checkrespuesta.Checked == true)
            {
                e.Graphics.DrawString("      Tiempo de espera: " + combohoras.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));

            }
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("               Orden: " + txtorden.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, y += 25));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, y += 20));
            e.Graphics.DrawImage(pictureBox2.Image, 40, y += 20);
        }




    }
}
