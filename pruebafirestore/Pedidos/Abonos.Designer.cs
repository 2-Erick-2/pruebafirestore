﻿namespace pruebafirestore.Pedidos
{
    partial class Abonos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abonos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtabono = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtrestante = new System.Windows.Forms.TextBox();
            this.altoButton1 = new AltoControls.AltoButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txthorayfecha = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txtabonos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre2 = new System.Windows.Forms.TextBox();
            this.txtpruibea = new System.Windows.Forms.TextBox();
            this.txtorden = new System.Windows.Forms.TextBox();
            this.lblcontador = new System.Windows.Forms.Label();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.checkiva = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(23, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(415, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtabono
            // 
            this.txtabono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtabono.Location = new System.Drawing.Point(96, 119);
            this.txtabono.Name = "txtabono";
            this.txtabono.Size = new System.Drawing.Size(168, 29);
            this.txtabono.TabIndex = 1;
            this.txtabono.TextChanged += new System.EventHandler(this.txtabono_TextChanged);
            this.txtabono.Layout += new System.Windows.Forms.LayoutEventHandler(this.txtabono_Layout);
            this.txtabono.Leave += new System.EventHandler(this.txtabono_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::pruebafirestore.Properties.Resources.minus;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(314, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 31);
            this.button2.TabIndex = 40;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::pruebafirestore.Properties.Resources.anadir;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(270, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 31);
            this.button1.TabIndex = 39;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Abono";
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.White;
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttotal.Enabled = false;
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(268, 38);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(170, 28);
            this.txttotal.TabIndex = 42;
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Total de compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Restante a pagar";
            // 
            // txtrestante
            // 
            this.txtrestante.BackColor = System.Drawing.Color.White;
            this.txtrestante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrestante.Enabled = false;
            this.txtrestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrestante.Location = new System.Drawing.Point(247, 510);
            this.txtrestante.Name = "txtrestante";
            this.txtrestante.Size = new System.Drawing.Size(113, 28);
            this.txtrestante.TabIndex = 44;
            this.txtrestante.TextChanged += new System.EventHandler(this.txtrestante_TextChanged);
            // 
            // altoButton1
            // 
            this.altoButton1.Active1 = System.Drawing.Color.RoyalBlue;
            this.altoButton1.Active2 = System.Drawing.Color.RoyalBlue;
            this.altoButton1.BackColor = System.Drawing.Color.Transparent;
            this.altoButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.altoButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton1.Enabled = false;
            this.altoButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoButton1.ForeColor = System.Drawing.Color.White;
            this.altoButton1.Inactive1 = System.Drawing.Color.DodgerBlue;
            this.altoButton1.Inactive2 = System.Drawing.Color.DodgerBlue;
            this.altoButton1.Location = new System.Drawing.Point(89, 560);
            this.altoButton1.Name = "altoButton1";
            this.altoButton1.Radius = 10;
            this.altoButton1.Size = new System.Drawing.Size(271, 52);
            this.altoButton1.Stroke = false;
            this.altoButton1.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton1.TabIndex = 154;
            this.altoButton1.Text = "Generar Abono";
            this.altoButton1.Transparency = false;
            this.altoButton1.Click += new System.EventHandler(this.altoButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txthorayfecha
            // 
            this.txthorayfecha.AutoSize = true;
            this.txthorayfecha.Location = new System.Drawing.Point(12, 9);
            this.txthorayfecha.Name = "txthorayfecha";
            this.txthorayfecha.Size = new System.Drawing.Size(35, 13);
            this.txthorayfecha.TabIndex = 155;
            this.txthorayfecha.Text = "label4";
            this.txthorayfecha.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.imprimir);
            // 
            // txtabonos
            // 
            this.txtabonos.BackColor = System.Drawing.Color.White;
            this.txtabonos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtabonos.Enabled = false;
            this.txtabonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtabonos.Location = new System.Drawing.Point(247, 476);
            this.txtabonos.Name = "txtabonos";
            this.txtabonos.Size = new System.Drawing.Size(113, 28);
            this.txtabonos.TabIndex = 156;
            this.txtabonos.TextChanged += new System.EventHandler(this.txtabonos_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 157;
            this.label4.Text = "Total abonado";
            // 
            // txtnombre2
            // 
            this.txtnombre2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre2.Enabled = false;
            this.txtnombre2.Location = new System.Drawing.Point(89, 1);
            this.txtnombre2.Name = "txtnombre2";
            this.txtnombre2.Size = new System.Drawing.Size(100, 20);
            this.txtnombre2.TabIndex = 158;
            // 
            // txtpruibea
            // 
            this.txtpruibea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpruibea.Location = new System.Drawing.Point(195, 1);
            this.txtpruibea.Name = "txtpruibea";
            this.txtpruibea.Size = new System.Drawing.Size(100, 20);
            this.txtpruibea.TabIndex = 159;
            this.txtpruibea.Visible = false;
            // 
            // txtorden
            // 
            this.txtorden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtorden.Location = new System.Drawing.Point(116, 618);
            this.txtorden.Name = "txtorden";
            this.txtorden.Size = new System.Drawing.Size(100, 20);
            this.txtorden.TabIndex = 160;
            this.txtorden.Visible = false;
            // 
            // lblcontador
            // 
            this.lblcontador.AutoSize = true;
            this.lblcontador.Location = new System.Drawing.Point(13, 560);
            this.lblcontador.Name = "lblcontador";
            this.lblcontador.Size = new System.Drawing.Size(35, 13);
            this.lblcontador.TabIndex = 161;
            this.lblcontador.Text = "label5";
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.imprimir2);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 49);
            this.pictureBox2.TabIndex = 162;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Location = new System.Drawing.Point(444, 165);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(437, 289);
            this.dataGridView2.TabIndex = 163;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(636, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 33);
            this.label5.TabIndex = 164;
            this.label5.Text = "Partes";
            // 
            // checkiva
            // 
            this.checkiva.AutoSize = true;
            this.checkiva.BackColor = System.Drawing.Color.White;
            this.checkiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkiva.Location = new System.Drawing.Point(483, 579);
            this.checkiva.Name = "checkiva";
            this.checkiva.Size = new System.Drawing.Size(68, 33);
            this.checkiva.TabIndex = 165;
            this.checkiva.Text = "IVA";
            this.checkiva.UseVisualStyleBackColor = false;
            this.checkiva.Visible = false;
            // 
            // Abonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(891, 634);
            this.Controls.Add(this.checkiva);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblcontador);
            this.Controls.Add(this.txtorden);
            this.Controls.Add(this.txtpruibea);
            this.Controls.Add(this.txtnombre2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtabonos);
            this.Controls.Add(this.txthorayfecha);
            this.Controls.Add(this.altoButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtrestante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtabono);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Abonos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "23";
            this.Load += new System.EventHandler(this.Abonos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtabono;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtrestante;
        private AltoControls.AltoButton altoButton1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txthorayfecha;
        private System.Drawing.Printing.PrintDocument printDocument1;
        public System.Windows.Forms.TextBox txtabonos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpruibea;
        private System.Windows.Forms.TextBox txtorden;
        public System.Windows.Forms.TextBox txtnombre2;
        private System.Windows.Forms.Label lblcontador;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkiva;
    }
}