namespace pruebafirestore
{
    partial class crearrevision
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.altoButton4 = new AltoControls.AltoButton();
            this.altoButton3 = new AltoControls.AltoButton();
            this.pContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.altoButton4);
            this.panel1.Controls.Add(this.altoButton3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 874);
            this.panel1.TabIndex = 3;
            // 
            // altoButton4
            // 
            this.altoButton4.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.altoButton4.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.altoButton4.BackColor = System.Drawing.Color.Transparent;
            this.altoButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.altoButton4.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton4.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoButton4.ForeColor = System.Drawing.Color.Black;
            this.altoButton4.ImeMode = System.Windows.Forms.ImeMode.On;
            this.altoButton4.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(108)))), ((int)(((byte)(180)))));
            this.altoButton4.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(159)))));
            this.altoButton4.Location = new System.Drawing.Point(0, 109);
            this.altoButton4.Name = "altoButton4";
            this.altoButton4.Radius = 10;
            this.altoButton4.Size = new System.Drawing.Size(172, 101);
            this.altoButton4.Stroke = false;
            this.altoButton4.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton4.TabIndex = 3;
            this.altoButton4.Text = "Crear";
            this.altoButton4.Transparency = false;
            this.altoButton4.Click += new System.EventHandler(this.altoButton4_Click);
            // 
            // altoButton3
            // 
            this.altoButton3.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.altoButton3.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.altoButton3.BackColor = System.Drawing.Color.Transparent;
            this.altoButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.altoButton3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoButton3.ForeColor = System.Drawing.Color.Black;
            this.altoButton3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.altoButton3.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(108)))), ((int)(((byte)(180)))));
            this.altoButton3.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(159)))));
            this.altoButton3.Location = new System.Drawing.Point(0, 241);
            this.altoButton3.Name = "altoButton3";
            this.altoButton3.Radius = 10;
            this.altoButton3.Size = new System.Drawing.Size(172, 101);
            this.altoButton3.Stroke = false;
            this.altoButton3.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton3.TabIndex = 4;
            this.altoButton3.Text = "Busqueda";
            this.altoButton3.Transparency = false;
            // 
            // pContainer
            // 
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(174, 0);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1168, 874);
            this.pContainer.TabIndex = 4;
            this.pContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pContenedor_Paint);
            // 
            // crearrevision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1342, 874);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "crearrevision";
            this.Text = "crearrevision";
            this.Load += new System.EventHandler(this.crearrevision_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pContainer;
        private AltoControls.AltoButton altoButton4;
        private AltoControls.AltoButton altoButton3;
    }
}