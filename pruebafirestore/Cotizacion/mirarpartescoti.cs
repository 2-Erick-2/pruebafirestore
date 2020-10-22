using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebafirestore.Cotizacion
{
    public partial class mirarpartescoti : Form
    {


        public String cant = "";
        public String cant2 = "";
       public  String cant3 = "";
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

        public mirarpartescoti()
        {
            InitializeComponent();
        }

        public mirarpartescoti(DataGridView dataGridView1)
        {
           // this.dataGridView1 = dataGridView1;

            InitializeComponent();
            dataGridView1.DataSource = dataGridView1.DataSource;


        }

        private void mirarpartescoti_Load(object sender, EventArgs e)
        {
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
    }
}
