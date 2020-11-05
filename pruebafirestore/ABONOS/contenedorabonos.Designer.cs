namespace pruebafirestore.ABONOS
{
    partial class contenedorabonos
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
            this.label1 = new System.Windows.Forms.Label();
            this.altoButton4 = new AltoControls.AltoButton();
            this.altoButton3 = new AltoControls.AltoButton();
            this.pContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.altoButton4);
            this.panel1.Controls.Add(this.altoButton3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 837);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Garantias";
            // 
            // altoButton4
            // 
            this.altoButton4.Active1 = System.Drawing.Color.RoyalBlue;
            this.altoButton4.Active2 = System.Drawing.Color.RoyalBlue;
            this.altoButton4.BackColor = System.Drawing.Color.Transparent;
            this.altoButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.altoButton4.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoButton4.ForeColor = System.Drawing.Color.Black;
            this.altoButton4.ImeMode = System.Windows.Forms.ImeMode.On;
            this.altoButton4.Inactive1 = System.Drawing.Color.DodgerBlue;
            this.altoButton4.Inactive2 = System.Drawing.Color.DodgerBlue;
            this.altoButton4.Location = new System.Drawing.Point(0, 149);
            this.altoButton4.Name = "altoButton4";
            this.altoButton4.Radius = 10;
            this.altoButton4.Size = new System.Drawing.Size(174, 145);
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
            this.altoButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoButton3.ForeColor = System.Drawing.Color.Black;
            this.altoButton3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.altoButton3.Inactive1 = System.Drawing.Color.DodgerBlue;
            this.altoButton3.Inactive2 = System.Drawing.Color.DodgerBlue;
            this.altoButton3.Location = new System.Drawing.Point(0, 303);
            this.altoButton3.Name = "altoButton3";
            this.altoButton3.Radius = 10;
            this.altoButton3.Size = new System.Drawing.Size(174, 145);
            this.altoButton3.Stroke = false;
            this.altoButton3.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton3.TabIndex = 4;
            this.altoButton3.Text = "Busqueda";
            this.altoButton3.Transparency = false;
            this.altoButton3.Click += new System.EventHandler(this.altoButton3_Click);
            // 
            // pContainer
            // 
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(174, 0);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1154, 837);
            this.pContainer.TabIndex = 5;
            // 
            // contenedorabonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 837);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "contenedorabonos";
            this.Text = "contenedorabonos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private AltoControls.AltoButton altoButton4;
        private AltoControls.AltoButton altoButton3;
        private System.Windows.Forms.Panel pContainer;
    }
}