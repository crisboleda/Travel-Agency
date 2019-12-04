namespace Travel_agency {
    partial class ReservasHotelesAdmin {
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
            this.listViewReservas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCellphoneHotel = new System.Windows.Forms.TextBox();
            this.textBoxCityHotel = new System.Windows.Forms.TextBox();
            this.textBoxAddressHotel = new System.Windows.Forms.TextBox();
            this.textBoxNameHotel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxCellphoneSucursal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxAddressSucursal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxEmailTurista = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCellphoneTurista = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAddressTurista = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLastNameTurista = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNameTurista = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewReservas
            // 
            this.listViewReservas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewReservas.FullRowSelect = true;
            this.listViewReservas.Location = new System.Drawing.Point(13, 13);
            this.listViewReservas.Name = "listViewReservas";
            this.listViewReservas.Size = new System.Drawing.Size(1257, 220);
            this.listViewReservas.TabIndex = 0;
            this.listViewReservas.UseCompatibleStateImageBehavior = false;
            this.listViewReservas.View = System.Windows.Forms.View.Details;
            this.listViewReservas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_Item_Reserva);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Código hotel";
            this.columnHeader2.Width = 236;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Código turista";
            this.columnHeader3.Width = 194;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Código sucursal";
            this.columnHeader4.Width = 199;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Pensión";
            this.columnHeader5.Width = 147;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fecha llegada";
            this.columnHeader6.Width = 176;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Fecha salida";
            this.columnHeader7.Width = 179;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ciudad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre:";
            // 
            // textBoxCellphoneHotel
            // 
            this.textBoxCellphoneHotel.Location = new System.Drawing.Point(89, 559);
            this.textBoxCellphoneHotel.Name = "textBoxCellphoneHotel";
            this.textBoxCellphoneHotel.ReadOnly = true;
            this.textBoxCellphoneHotel.Size = new System.Drawing.Size(254, 22);
            this.textBoxCellphoneHotel.TabIndex = 18;
            // 
            // textBoxCityHotel
            // 
            this.textBoxCityHotel.Location = new System.Drawing.Point(89, 483);
            this.textBoxCityHotel.Name = "textBoxCityHotel";
            this.textBoxCityHotel.ReadOnly = true;
            this.textBoxCityHotel.Size = new System.Drawing.Size(254, 22);
            this.textBoxCityHotel.TabIndex = 17;
            // 
            // textBoxAddressHotel
            // 
            this.textBoxAddressHotel.Location = new System.Drawing.Point(89, 407);
            this.textBoxAddressHotel.Name = "textBoxAddressHotel";
            this.textBoxAddressHotel.ReadOnly = true;
            this.textBoxAddressHotel.Size = new System.Drawing.Size(254, 22);
            this.textBoxAddressHotel.TabIndex = 16;
            // 
            // textBoxNameHotel
            // 
            this.textBoxNameHotel.Location = new System.Drawing.Point(89, 332);
            this.textBoxNameHotel.Name = "textBoxNameHotel";
            this.textBoxNameHotel.ReadOnly = true;
            this.textBoxNameHotel.Size = new System.Drawing.Size(254, 22);
            this.textBoxNameHotel.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(86, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "DATOS HOTEL";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(903, 396);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 17);
            this.label14.TabIndex = 41;
            this.label14.Text = "Celular:";
            // 
            // textBoxCellphoneSucursal
            // 
            this.textBoxCellphoneSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCellphoneSucursal.Location = new System.Drawing.Point(906, 416);
            this.textBoxCellphoneSucursal.Name = "textBoxCellphoneSucursal";
            this.textBoxCellphoneSucursal.ReadOnly = true;
            this.textBoxCellphoneSucursal.Size = new System.Drawing.Size(239, 26);
            this.textBoxCellphoneSucursal.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(903, 322);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 39;
            this.label13.Text = "Dirección:";
            // 
            // textBoxAddressSucursal
            // 
            this.textBoxAddressSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxAddressSucursal.Location = new System.Drawing.Point(906, 342);
            this.textBoxAddressSucursal.Name = "textBoxAddressSucursal";
            this.textBoxAddressSucursal.ReadOnly = true;
            this.textBoxAddressSucursal.Size = new System.Drawing.Size(239, 26);
            this.textBoxAddressSucursal.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(902, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 24);
            this.label12.TabIndex = 37;
            this.label12.Text = "DATOS SUCURSAL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(533, 602);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Email:";
            // 
            // textBoxEmailTurista
            // 
            this.textBoxEmailTurista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxEmailTurista.Location = new System.Drawing.Point(531, 622);
            this.textBoxEmailTurista.Name = "textBoxEmailTurista";
            this.textBoxEmailTurista.ReadOnly = true;
            this.textBoxEmailTurista.Size = new System.Drawing.Size(239, 26);
            this.textBoxEmailTurista.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(533, 521);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Celular:";
            // 
            // textBoxCellphoneTurista
            // 
            this.textBoxCellphoneTurista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCellphoneTurista.Location = new System.Drawing.Point(531, 541);
            this.textBoxCellphoneTurista.Name = "textBoxCellphoneTurista";
            this.textBoxCellphoneTurista.ReadOnly = true;
            this.textBoxCellphoneTurista.Size = new System.Drawing.Size(239, 26);
            this.textBoxCellphoneTurista.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(528, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Dirección:";
            // 
            // textBoxAddressTurista
            // 
            this.textBoxAddressTurista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxAddressTurista.Location = new System.Drawing.Point(531, 473);
            this.textBoxAddressTurista.Name = "textBoxAddressTurista";
            this.textBoxAddressTurista.ReadOnly = true;
            this.textBoxAddressTurista.Size = new System.Drawing.Size(239, 26);
            this.textBoxAddressTurista.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(528, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Apellido:";
            // 
            // textBoxLastNameTurista
            // 
            this.textBoxLastNameTurista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxLastNameTurista.Location = new System.Drawing.Point(531, 396);
            this.textBoxLastNameTurista.Name = "textBoxLastNameTurista";
            this.textBoxLastNameTurista.ReadOnly = true;
            this.textBoxLastNameTurista.Size = new System.Drawing.Size(239, 26);
            this.textBoxLastNameTurista.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(533, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Nombre:";
            // 
            // textBoxNameTurista
            // 
            this.textBoxNameTurista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxNameTurista.Location = new System.Drawing.Point(531, 322);
            this.textBoxNameTurista.Name = "textBoxNameTurista";
            this.textBoxNameTurista.ReadOnly = true;
            this.textBoxNameTurista.Size = new System.Drawing.Size(239, 26);
            this.textBoxNameTurista.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(527, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "DATOS TURISTA";
            // 
            // ReservasHotelesAdmin
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCellphoneHotel);
            this.Controls.Add(this.textBoxCityHotel);
            this.Controls.Add(this.textBoxAddressHotel);
            this.Controls.Add(this.textBoxNameHotel);
            this.Controls.Add(this.listViewReservas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservasHotelesAdmin";
            this.Text = "ReservasHotelesAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.Click_Window);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewReservas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCellphoneHotel;
        private System.Windows.Forms.TextBox textBoxCityHotel;
        private System.Windows.Forms.TextBox textBoxAddressHotel;
        private System.Windows.Forms.TextBox textBoxNameHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxCellphoneSucursal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxAddressSucursal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxEmailTurista;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCellphoneTurista;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAddressTurista;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxLastNameTurista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNameTurista;
        private System.Windows.Forms.Label label6;
    }
}