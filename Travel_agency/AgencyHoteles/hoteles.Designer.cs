namespace Travel_agency.Hoteles
{
    partial class hoteles
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.textHotel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textCodigoHotel = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.Label();
            this.textNombreHotel = new System.Windows.Forms.TextBox();
            this.txtNombreHotel = new System.Windows.Forms.Label();
            this.txtReservar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(135, 178);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 21;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(40, 178);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 20;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Lista de Hoteles creados";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(362, 51);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(345, 150);
            this.grilla.TabIndex = 18;
            // 
            // textHotel
            // 
            this.textHotel.Location = new System.Drawing.Point(114, 138);
            this.textHotel.Name = "textHotel";
            this.textHotel.Size = new System.Drawing.Size(164, 20);
            this.textHotel.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ciudad";
            // 
            // textCodigoHotel
            // 
            this.textCodigoHotel.Location = new System.Drawing.Point(114, 103);
            this.textCodigoHotel.Name = "textCodigoHotel";
            this.textCodigoHotel.Size = new System.Drawing.Size(164, 20);
            this.textCodigoHotel.TabIndex = 15;
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(23, 106);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(85, 13);
            this.t.TabIndex = 14;
            this.t.Text = "Codigo del Hotel";
            // 
            // textNombreHotel
            // 
            this.textNombreHotel.Location = new System.Drawing.Point(114, 67);
            this.textNombreHotel.Name = "textNombreHotel";
            this.textNombreHotel.Size = new System.Drawing.Size(164, 20);
            this.textNombreHotel.TabIndex = 13;
            // 
            // txtNombreHotel
            // 
            this.txtNombreHotel.AutoSize = true;
            this.txtNombreHotel.Location = new System.Drawing.Point(23, 70);
            this.txtNombreHotel.Name = "txtNombreHotel";
            this.txtNombreHotel.Size = new System.Drawing.Size(90, 13);
            this.txtNombreHotel.TabIndex = 12;
            this.txtNombreHotel.Text = "Nombre del  hotel";
            // 
            // txtReservar
            // 
            this.txtReservar.AutoSize = true;
            this.txtReservar.Location = new System.Drawing.Point(23, 27);
            this.txtReservar.Name = "txtReservar";
            this.txtReservar.Size = new System.Drawing.Size(72, 17);
            this.txtReservar.TabIndex = 11;
            this.txtReservar.Text = "Crear hoteles";
            this.txtReservar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtReservar.UseCompatibleTextRendering = true;
            // 
            // hoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.textHotel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textCodigoHotel);
            this.Controls.Add(this.t);
            this.Controls.Add(this.textNombreHotel);
            this.Controls.Add(this.txtNombreHotel);
            this.Controls.Add(this.txtReservar);
            this.Name = "hoteles";
            this.Text = "hoteles";
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.TextBox textHotel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCodigoHotel;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.TextBox textNombreHotel;
        private System.Windows.Forms.Label txtNombreHotel;
        private System.Windows.Forms.Label txtReservar;
    }
}