namespace pruebafirestore.Cotizacion
{
    partial class creardesde2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(creardesde2));
            this.checkiva = new System.Windows.Forms.CheckBox();
            this.checkrespuesta = new System.Windows.Forms.CheckBox();
            this.checkexistencia = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.combohoras = new System.Windows.Forms.ComboBox();
            this.combodias = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdescri = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtorden = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.altoButton1 = new AltoControls.AltoButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtnombre2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblcontador = new System.Windows.Forms.Label();
            this.txtrepetidos = new System.Windows.Forms.TextBox();
            this.txtpruibea = new System.Windows.Forms.TextBox();
            this.txtorden2 = new System.Windows.Forms.TextBox();
            this.txthorayfecha = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checksinrefac = new System.Windows.Forms.CheckBox();
            this.checkperdidatotal = new System.Windows.Forms.CheckBox();
            this.pdf = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // checkiva
            // 
            this.checkiva.AutoSize = true;
            this.checkiva.BackColor = System.Drawing.Color.White;
            this.checkiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkiva.Location = new System.Drawing.Point(67, 590);
            this.checkiva.Name = "checkiva";
            this.checkiva.Size = new System.Drawing.Size(68, 33);
            this.checkiva.TabIndex = 149;
            this.checkiva.Text = "IVA";
            this.checkiva.UseVisualStyleBackColor = false;
            this.checkiva.CheckedChanged += new System.EventHandler(this.checkiva_CheckedChanged);
            // 
            // checkrespuesta
            // 
            this.checkrespuesta.AutoSize = true;
            this.checkrespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkrespuesta.Location = new System.Drawing.Point(67, 638);
            this.checkrespuesta.Name = "checkrespuesta";
            this.checkrespuesta.Size = new System.Drawing.Size(262, 33);
            this.checkrespuesta.TabIndex = 148;
            this.checkrespuesta.Text = "Tiempo de respuesta";
            this.checkrespuesta.UseVisualStyleBackColor = true;
            this.checkrespuesta.CheckedChanged += new System.EventHandler(this.checkrespuesta_CheckedChanged);
            // 
            // checkexistencia
            // 
            this.checkexistencia.AutoSize = true;
            this.checkexistencia.BackColor = System.Drawing.Color.White;
            this.checkexistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkexistencia.Location = new System.Drawing.Point(581, 638);
            this.checkexistencia.Name = "checkexistencia";
            this.checkexistencia.Size = new System.Drawing.Size(141, 33);
            this.checkexistencia.TabIndex = 147;
            this.checkexistencia.Text = "Existencia";
            this.checkexistencia.UseVisualStyleBackColor = false;
            this.checkexistencia.Visible = false;
            this.checkexistencia.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.White;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(352, 636);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 33);
            this.checkBox2.TabIndex = 146;
            this.checkBox2.Text = "Dias";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.Visible = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // combohoras
            // 
            this.combohoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.combohoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combohoras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combohoras.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combohoras.ForeColor = System.Drawing.Color.White;
            this.combohoras.FormattingEnabled = true;
            this.combohoras.Items.AddRange(new object[] {
            "1 hora",
            "2 horas",
            "3 horas",
            "4 horas",
            "5 horas",
            "6 horas",
            "7 horas",
            "9 horas",
            "10 horas",
            "11 horas",
            "12 horas"});
            this.combohoras.Location = new System.Drawing.Point(23, 807);
            this.combohoras.Name = "combohoras";
            this.combohoras.Size = new System.Drawing.Size(121, 39);
            this.combohoras.TabIndex = 145;
            this.combohoras.Visible = false;
            // 
            // combodias
            // 
            this.combodias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.combodias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combodias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combodias.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combodias.ForeColor = System.Drawing.Color.White;
            this.combodias.FormattingEnabled = true;
            this.combodias.Items.AddRange(new object[] {
            "3-4 dias",
            "7-15 dias"});
            this.combodias.Location = new System.Drawing.Point(438, 636);
            this.combodias.Name = "combodias";
            this.combodias.Size = new System.Drawing.Size(121, 37);
            this.combodias.TabIndex = 144;
            this.combodias.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Descripcion,
            this.PU,
            this.Importe});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(73, 385);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.Size = new System.Drawing.Size(698, 165);
            this.dataGridView1.TabIndex = 142;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cantidad.HeaderText = "      Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Descripcion
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle3;
            this.Descripcion.HeaderText = " Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // PU
            // 
            this.PU.HeaderText = "             PU";
            this.PU.Name = "PU";
            this.PU.ReadOnly = true;
            // 
            // Importe
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "C0";
            dataGridViewCellStyle4.NullValue = null;
            this.Importe.DefaultCellStyle = dataGridViewCellStyle4;
            this.Importe.HeaderText = "         Importe";
            this.Importe.Name = "Importe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(547, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 29);
            this.label8.TabIndex = 140;
            this.label8.Text = "Importe";
            // 
            // txtimporte
            // 
            this.txtimporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimporte.Location = new System.Drawing.Point(538, 335);
            this.txtimporte.MaxLength = 5;
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(104, 31);
            this.txtimporte.TabIndex = 139;
            this.txtimporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtimporte_KeyPress);
            this.txtimporte.Leave += new System.EventHandler(this.txtimporte_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(282, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 29);
            this.label7.TabIndex = 138;
            this.label7.Text = "Descripcion";
            // 
            // txtdescri
            // 
            this.txtdescri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescri.Location = new System.Drawing.Point(176, 335);
            this.txtdescri.MaxLength = 12;
            this.txtdescri.Name = "txtdescri";
            this.txtdescri.Size = new System.Drawing.Size(365, 31);
            this.txtdescri.TabIndex = 137;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 29);
            this.label6.TabIndex = 136;
            this.label6.Text = "Cantidad";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(72, 335);
            this.txtcantidad.MaxLength = 1;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(104, 31);
            this.txtcantidad.TabIndex = 135;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // txtorden
            // 
            this.txtorden.AutoSize = true;
            this.txtorden.BackColor = System.Drawing.Color.White;
            this.txtorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtorden.Location = new System.Drawing.Point(479, 734);
            this.txtorden.Name = "txtorden";
            this.txtorden.Size = new System.Drawing.Size(173, 29);
            this.txtorden.TabIndex = 154;
            this.txtorden.Text = "****************";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(214, 734);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(208, 29);
            this.label11.TabIndex = 153;
            this.label11.Text = "Número de Orden";
            // 
            // altoButton1
            // 
            this.altoButton1.Active1 = System.Drawing.Color.RoyalBlue;
            this.altoButton1.Active2 = System.Drawing.Color.RoyalBlue;
            this.altoButton1.BackColor = System.Drawing.Color.Transparent;
            this.altoButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.altoButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton1.Enabled = false;
            this.altoButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoButton1.ForeColor = System.Drawing.Color.Black;
            this.altoButton1.Inactive1 = System.Drawing.Color.DodgerBlue;
            this.altoButton1.Inactive2 = System.Drawing.Color.DodgerBlue;
            this.altoButton1.Location = new System.Drawing.Point(219, 777);
            this.altoButton1.Name = "altoButton1";
            this.altoButton1.Radius = 10;
            this.altoButton1.Size = new System.Drawing.Size(397, 52);
            this.altoButton1.Stroke = false;
            this.altoButton1.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton1.TabIndex = 152;
            this.altoButton1.Text = "Guardar cotización";
            this.altoButton1.Transparency = false;
            this.altoButton1.Click += new System.EventHandler(this.altoButton1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(648, 757);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 72);
            this.pictureBox2.TabIndex = 155;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::pruebafirestore.Properties.Resources.minus;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(731, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 31);
            this.button2.TabIndex = 143;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::pruebafirestore.Properties.Resources.anadir;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(676, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 31);
            this.button1.TabIndex = 141;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnombre2
            // 
            this.txtnombre2.BackColor = System.Drawing.Color.White;
            this.txtnombre2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre2.Enabled = false;
            this.txtnombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre2.Location = new System.Drawing.Point(12, 52);
            this.txtnombre2.Multiline = true;
            this.txtnombre2.Name = "txtnombre2";
            this.txtnombre2.Size = new System.Drawing.Size(18, 10);
            this.txtnombre2.TabIndex = 161;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(357, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 29);
            this.label9.TabIndex = 160;
            this.label9.Text = "Datos del cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 159;
            this.label2.Text = "Número";
            // 
            // txtnumero
            // 
            this.txtnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(247, 147);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(524, 35);
            this.txtnumero.TabIndex = 158;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 157;
            this.label1.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(247, 68);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(524, 35);
            this.txtnombre.TabIndex = 156;
            // 
            // lblcontador
            // 
            this.lblcontador.AutoSize = true;
            this.lblcontador.Location = new System.Drawing.Point(20, 13);
            this.lblcontador.Name = "lblcontador";
            this.lblcontador.Size = new System.Drawing.Size(41, 13);
            this.lblcontador.TabIndex = 166;
            this.lblcontador.Text = "label10";
            this.lblcontador.Visible = false;
            // 
            // txtrepetidos
            // 
            this.txtrepetidos.Location = new System.Drawing.Point(12, 679);
            this.txtrepetidos.Name = "txtrepetidos";
            this.txtrepetidos.Size = new System.Drawing.Size(49, 20);
            this.txtrepetidos.TabIndex = 165;
            this.txtrepetidos.Visible = false;
            // 
            // txtpruibea
            // 
            this.txtpruibea.Location = new System.Drawing.Point(12, 636);
            this.txtpruibea.Name = "txtpruibea";
            this.txtpruibea.Size = new System.Drawing.Size(49, 20);
            this.txtpruibea.TabIndex = 164;
            this.txtpruibea.Visible = false;
            // 
            // txtorden2
            // 
            this.txtorden2.Location = new System.Drawing.Point(12, 590);
            this.txtorden2.Name = "txtorden2";
            this.txtorden2.Size = new System.Drawing.Size(49, 20);
            this.txtorden2.TabIndex = 163;
            this.txtorden2.Visible = false;
            // 
            // txthorayfecha
            // 
            this.txthorayfecha.AutoSize = true;
            this.txthorayfecha.Location = new System.Drawing.Point(84, 13);
            this.txthorayfecha.Name = "txthorayfecha";
            this.txthorayfecha.Size = new System.Drawing.Size(41, 13);
            this.txthorayfecha.TabIndex = 162;
            this.txthorayfecha.Text = "label10";
            this.txthorayfecha.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 168;
            this.label5.Text = "Modelo";
            // 
            // txtmodelo
            // 
            this.txtmodelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodelo.Location = new System.Drawing.Point(251, 235);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(520, 31);
            this.txtmodelo.TabIndex = 167;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.imprimir);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checksinrefac
            // 
            this.checksinrefac.AutoSize = true;
            this.checksinrefac.BackColor = System.Drawing.Color.White;
            this.checksinrefac.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checksinrefac.Location = new System.Drawing.Point(247, 590);
            this.checksinrefac.Name = "checksinrefac";
            this.checksinrefac.Size = new System.Drawing.Size(197, 33);
            this.checksinrefac.TabIndex = 169;
            this.checksinrefac.Text = "Sin refacciones";
            this.checksinrefac.UseVisualStyleBackColor = false;
            this.checksinrefac.CheckedChanged += new System.EventHandler(this.checksinrefac_CheckedChanged);
            // 
            // checkperdidatotal
            // 
            this.checkperdidatotal.AutoSize = true;
            this.checkperdidatotal.BackColor = System.Drawing.Color.White;
            this.checkperdidatotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkperdidatotal.Location = new System.Drawing.Point(474, 590);
            this.checkperdidatotal.Name = "checkperdidatotal";
            this.checkperdidatotal.Size = new System.Drawing.Size(168, 33);
            this.checkperdidatotal.TabIndex = 170;
            this.checkperdidatotal.Text = "Perdida total";
            this.checkperdidatotal.UseVisualStyleBackColor = false;
            this.checkperdidatotal.CheckedChanged += new System.EventHandler(this.checkperdidatotal_CheckedChanged);
            // 
            // pdf
            // 
            this.pdf.AutoSize = true;
            this.pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdf.Location = new System.Drawing.Point(67, 679);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(173, 33);
            this.pdf.TabIndex = 171;
            this.pdf.Text = "Guardar PDF";
            this.pdf.UseVisualStyleBackColor = true;
            // 
            // creardesde2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 845);
            this.Controls.Add(this.pdf);
            this.Controls.Add(this.checkperdidatotal);
            this.Controls.Add(this.checksinrefac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.lblcontador);
            this.Controls.Add(this.txtrepetidos);
            this.Controls.Add(this.txtpruibea);
            this.Controls.Add(this.txtorden2);
            this.Controls.Add(this.txthorayfecha);
            this.Controls.Add(this.txtnombre2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtorden);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.altoButton1);
            this.Controls.Add(this.checkiva);
            this.Controls.Add(this.checkrespuesta);
            this.Controls.Add(this.checkexistencia);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.combohoras);
            this.Controls.Add(this.combodias);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtimporte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdescri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "creardesde2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "creardesde2";
            this.Load += new System.EventHandler(this.creardesde2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkiva;
        private System.Windows.Forms.CheckBox checkrespuesta;
        private System.Windows.Forms.CheckBox checkexistencia;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox combohoras;
        private System.Windows.Forms.ComboBox combodias;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdescri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label txtorden;
        private System.Windows.Forms.Label label11;
        private AltoControls.AltoButton altoButton1;
        private System.Windows.Forms.TextBox txtnombre2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblcontador;
        private System.Windows.Forms.TextBox txtrepetidos;
        private System.Windows.Forms.TextBox txtpruibea;
        private System.Windows.Forms.TextBox txtorden2;
        private System.Windows.Forms.Label txthorayfecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checksinrefac;
        private System.Windows.Forms.CheckBox checkperdidatotal;
        private System.Windows.Forms.CheckBox pdf;
    }
}