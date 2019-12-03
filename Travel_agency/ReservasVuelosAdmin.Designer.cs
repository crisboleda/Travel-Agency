namespace Travel_agency {
    partial class ReservasVuelosAdmin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listViewReservasVuelos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxDateVuelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTimeVuelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOrigenVuelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDestinoVuelo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNameTurista = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLastNameTurista = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAddressTurista = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCellphoneTurista = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxEmailTurista = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxAddressSucursal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxCellphoneSucursal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewReservasVuelos
            // 
            this.listViewReservasVuelos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewReservasVuelos.FullRowSelect = true;
            this.listViewReservasVuelos.Location = new System.Drawing.Point(12, 12);
            this.listViewReservasVuelos.Name = "listViewReservasVuelos";
            this.listViewReservasVuelos.Size = new System.Drawing.Size(1287, 191);
            this.listViewReservasVuelos.TabIndex = 0;
            this.listViewReservasVuelos.UseCompatibleStateImageBehavior = false;
            this.listViewReservasVuelos.View = System.Windows.Forms.View.Details;
            this.listViewReservasVuelos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_Item);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Código vuelo";
            this.columnHeader2.Width = 217;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Código turista";
            this.columnHeader3.Width = 213;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Código sucursal";
            this.columnHeader4.Width = 199;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Clase vuelo";
            this.columnHeader5.Width = 222;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Asientos";
            this.columnHeader6.Width = 143;
            // 
            // textBoxDateVuelo
            // 
            this.textBoxDateVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxDateVuelo.Location = new System.Drawing.Point(169, 310);
            this.textBoxDateVuelo.Name = "textBoxDateVuelo";
            this.textBoxDateVuelo.ReadOnly = true;
            this.textBoxDateVuelo.Size = new System.Drawing.Size(239, 26);
            this.textBoxDateVuelo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(170, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "DATOS VUELO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora:";
            // 
            // textBoxTimeVuelo
            // 
            this.textBoxTimeVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxTimeVuelo.Location = new System.Drawing.Point(169, 384);
            this.textBoxTimeVuelo.Name = "textBoxTimeVuelo";
            this.textBoxTimeVuelo.ReadOnly = true;
            this.textBoxTimeVuelo.Size = new System.Drawing.Size(239, 26);
            this.textBoxTimeVuelo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Origen:";
            // 
            // textBoxOrigenVuelo
            // 
            this.textBoxOrigenVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxOrigenVuelo.Location = new System.Drawing.Point(169, 461);
            this.textBoxOrigenVuelo.Name = "textBoxOrigenVuelo";
            this.textBoxOrigenVuelo.ReadOnly = true;
            this.textBoxOrigenVuelo.Size = new System.Drawing.Size(239, 26);
            this.textBoxOrigenVuelo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Destino:";
            // 
            // textBoxDestinoVuelo
            // 
            this.textBoxDestinoVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxDestinoVuelo.Location = new System.Drawing.Point(169, 529);
            this.textBoxDestinoVuelo.Name = "textBoxDestinoVuelo";
            this.textBoxDestinoVuelo.ReadOnly = true;
            this.textBoxDestinoVuelo.Size = new System.Drawing.Size(239, 26);
            this.textBoxDestinoVuelo.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(552, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "DATOS TURISTA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(558, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nombre:";
            // 
            // textBoxNameTurista
            // 
            this.textBoxNameTurista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxNameTurista.Location = new System.Drawing.Point(556, 310);
            this.textBoxNameTurista.Name = "textBoxNameTurista";
            this.textBoxNameTurista.ReadOnly = true;
            this.textBoxNameTurista.Size = new System.Drawing.Size(239, 26);
            this.textBoxNameTurista.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(553, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Apellido:";
            // 
            // textBoxLastNameTurista
            // 
            this.textBoxLastNameTurista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxLastNameTurista.Location = new System.Drawing.Point(556, 384);
            this.textBoxLastNameTurista.Name = "textBoxLastNameTurista";
            this.textBoxLastNameTurista.ReadOnly = true;
            this.textBoxLastNameTurista.Size = new System.Drawing.Size(239, 26);
            this.textBoxLastNameTurista.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(553, 441);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Dirección:";
            // 
            // textBoxAddressTurista
            // 
            this.textBoxAddressTurista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxAddressTurista.Location = new System.Drawing.Point(556, 461);
            this.textBoxAddressTurista.Name = "textBoxAddressTurista";
            this.textBoxAddressTurista.ReadOnly = true;
            this.textBoxAddressTurista.Size = new System.Drawing.Size(239, 26);
            this.textBoxAddressTurista.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(558, 509);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Celular:";
            // 
            // textBoxCellphoneTurista
            // 
            this.textBoxCellphoneTurista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCellphoneTurista.Location = new System.Drawing.Point(556, 529);
            this.textBoxCellphoneTurista.Name = "textBoxCellphoneTurista";
            this.textBoxCellphoneTurista.ReadOnly = true;
            this.textBoxCellphoneTurista.Size = new System.Drawing.Size(239, 26);
            this.textBoxCellphoneTurista.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(558, 590);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Email:";
            // 
            // textBoxEmailTurista
            // 
            this.textBoxEmailTurista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxEmailTurista.Location = new System.Drawing.Point(556, 610);
            this.textBoxEmailTurista.Name = "textBoxEmailTurista";
            this.textBoxEmailTurista.ReadOnly = true;
            this.textBoxEmailTurista.Size = new System.Drawing.Size(239, 26);
            this.textBoxEmailTurista.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(927, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 24);
            this.label12.TabIndex = 21;
            this.label12.Text = "DATOS SUCURSAL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(928, 290);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Dirección:";
            // 
            // textBoxAddressSucursal
            // 
            this.textBoxAddressSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxAddressSucursal.Location = new System.Drawing.Point(931, 310);
            this.textBoxAddressSucursal.Name = "textBoxAddressSucursal";
            this.textBoxAddressSucursal.ReadOnly = true;
            this.textBoxAddressSucursal.Size = new System.Drawing.Size(239, 26);
            this.textBoxAddressSucursal.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(928, 364);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "Celular:";
            // 
            // textBoxCellphoneSucursal
            // 
            this.textBoxCellphoneSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCellphoneSucursal.Location = new System.Drawing.Point(931, 384);
            this.textBoxCellphoneSucursal.Name = "textBoxCellphoneSucursal";
            this.textBoxCellphoneSucursal.ReadOnly = true;
            this.textBoxCellphoneSucursal.Size = new System.Drawing.Size(239, 26);
            this.textBoxCellphoneSucursal.TabIndex = 24;
            // 
            // ReservasVuelosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 723);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxCellphoneSucursal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxAddressSucursal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxEmailTurista);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxCellphoneTurista);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxAddressTurista);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxLastNameTurista);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNameTurista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDestinoVuelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOrigenVuelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTimeVuelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDateVuelo);
            this.Controls.Add(this.listViewReservasVuelos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservasVuelosAdmin";
            this.Text = "ReservasVuelosAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.Click_Window);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewReservasVuelos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox textBoxDateVuelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTimeVuelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOrigenVuelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDestinoVuelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNameTurista;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxLastNameTurista;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAddressTurista;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCellphoneTurista;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxEmailTurista;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxAddressSucursal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxCellphoneSucursal;
    }
}