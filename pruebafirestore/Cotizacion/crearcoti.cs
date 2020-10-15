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


namespace pruebafirestore.Cotizacion
{
    public partial class crearcoti : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        String tipoproducto = "";

        public crearcoti()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \\EBEST-AB78DLU\ebest\Ebest_be.accdb; Persist Security Info=False;";

        }

        private void button1_Click(object sender, EventArgs e)
        {


            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = txtcantidad.Text;
            fila.Cells[1].Value = txtdescri.Text;
            fila.Cells[2].Value = txtimporte.Text;

            dataGridView1.Rows.Add(fila);
            txtcantidad.Text = "";
            txtdescri.Text = "";
            txtimporte.Text = "";

           /* try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                    command.CommandText = "insert into productos (Cantidad,Descripcion,Importe) values ('" + txtcantidad.Text + "','" + txtdescri.Text + "','" + txtimporte.Text + "')";
                    command.ExecuteNonQuery();
                connection.Close();
                //MessageBox.Show("Cliente guardado");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            crearcoti_Load(sender, e);*/
        }

        private void crearcoti_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[2].DefaultCellStyle.Format = "C";
           /* try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT productos.[Cantidad], productos.[Descripcion], productos.[Importe] FROM productos; ";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                string query2 = "SELECT * FROM productos; ";
                command.CommandText = query2;

                OleDbDataAdapter da2 = new OleDbDataAdapter(command);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView2.DataSource = dt2;




                connection.Close();

                dataGridView1.RowHeadersVisible = false;


                dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.White;
                dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.LightYellow;

                dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.White;
                dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.LightBlue;

                dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.White;
                dataGridView1.Columns[2].DefaultCellStyle.BackColor = Color.LightBlue;

           


                dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
                dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }*/
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            //

          /*  if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                DataGridViewRow row2 = this.dataGridView2.Rows[e.RowIndex];

                if (e.ColumnIndex == 0)
                {
                    tipoproducto = "Cantidad";
                    // lbltipoproductop.Text = tipoproducto;

                   label9.Text =     dataGridView1.Rows.Count.ToString();
                    lbltipoproductop.Text = row2.Cells["id"].Value.ToString();
                    txteditable.Text = row.Cells["Cantidad"].Value.ToString();
                }
                else if (e.ColumnIndex == 1)
                {
                    tipoproducto = "Descripcion";
                    lbltipoproductop.Text = tipoproducto;
                    lbltipoproductop.Text = row2.Cells["id"].Value.ToString();

                    txteditable.Text = row.Cells["Descripcion"].Value.ToString();

                }
                else if (e.ColumnIndex == 2)
                {
                    tipoproducto = "Importe";
                    lbltipoproductop.Text = tipoproducto;
                    lbltipoproductop.Text = row2.Cells["id"].Value.ToString();

                    txteditable.Text = row.Cells["Importe"].Value.ToString();

                }*/
                //txtmodelo.Text = row.Cells["modelo"].Value.ToString();


            }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            //dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void txtimporte_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    }

