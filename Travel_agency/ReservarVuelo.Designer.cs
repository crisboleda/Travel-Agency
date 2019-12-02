namespace Travel_agency {
    partial class ReservarVuelo {
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
            this.listViewVuelos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxDestino = new System.Windows.Forms.TextBox();
            this.textBoxOrigen = new System.Windows.Forms.TextBox();
            this.classVuelo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listViewSucursales = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCellphone = new System.Windows.Forms.TextBox();
            this.textBoxAddres = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewVuelos
            // 
            this.listViewVuelos.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewVuelos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader8,
            this.columnHeader10,
            this.columnHeader9});
            this.listViewVuelos.FullRowSelect = true;
            this.listViewVuelos.Location = new System.Drawing.Point(32, 31);
            this.listViewVuelos.Name = "listViewVuelos";
            this.listViewVuelos.Size = new System.Drawing.Size(765, 232);
            this.listViewVuelos.TabIndex = 1;
            this.listViewVuelos.UseCompatibleStateImageBehavior = false;
            this.listViewVuelos.View = System.Windows.Forms.View.Details;
            this.listViewVuelos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 42;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fecha";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hora";
            this.columnHeader3.Width = 108;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Origen";
            this.columnHeader4.Width = 103;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Destino";
            this.columnHeader8.Width = 132;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Asientos (Clase Turista)";
            this.columnHeader10.Width = 160;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Destino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Origen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Fecha:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarTitleForeColor = System.Drawing.Color.YellowGreen;
            this.dateTimePickerDate.Enabled = false;
            this.dateTimePickerDate.Location = new System.Drawing.Point(44, 389);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(313, 22);
            this.dateTimePickerDate.TabIndex = 23;
            this.dateTimePickerDate.Value = new System.DateTime(2019, 12, 20, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID:";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Enabled = false;
            this.textBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxTime.Location = new System.Drawing.Point(44, 475);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(313, 30);
            this.textBoxTime.TabIndex = 21;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxID.Location = new System.Drawing.Point(44, 300);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(313, 28);
            this.textBoxID.TabIndex = 20;
            // 
            // textBoxDestino
            // 
            this.textBoxDestino.Enabled = false;
            this.textBoxDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxDestino.Location = new System.Drawing.Point(404, 386);
            this.textBoxDestino.Name = "textBoxDestino";
            this.textBoxDestino.Size = new System.Drawing.Size(265, 28);
            this.textBoxDestino.TabIndex = 19;
            // 
            // textBoxOrigen
            // 
            this.textBoxOrigen.Enabled = false;
            this.textBoxOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxOrigen.Location = new System.Drawing.Point(404, 300);
            this.textBoxOrigen.Name = "textBoxOrigen";
            this.textBoxOrigen.Size = new System.Drawing.Size(265, 28);
            this.textBoxOrigen.TabIndex = 18;
            // 
            // classVuelo
            // 
            this.classVuelo.FormattingEnabled = true;
            this.classVuelo.Items.AddRange(new object[] {
            "Turista",
            "Primera"});
            this.classVuelo.Location = new System.Drawing.Point(404, 481);
            this.classVuelo.Name = "classVuelo";
            this.classVuelo.Size = new System.Drawing.Size(265, 24);
            this.classVuelo.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Clase:";
            // 
            // listViewSucursales
            // 
            this.listViewSucursales.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewSucursales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewSucursales.FullRowSelect = true;
            this.listViewSucursales.Location = new System.Drawing.Point(820, 31);
            this.listViewSucursales.Name = "listViewSucursales";
            this.listViewSucursales.Size = new System.Drawing.Size(461, 232);
            this.listViewSucursales.TabIndex = 32;
            this.listViewSucursales.UseCompatibleStateImageBehavior = false;
            this.listViewSucursales.View = System.Windows.Forms.View.Details;
            this.listViewSucursales.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Click_Item_Sucursal);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 69;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Address";
            this.columnHeader6.Width = 81;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Cellphone";
            this.columnHeader7.Width = 97;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(817, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "ID:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox1.Location = new System.Drawing.Point(820, 300);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(461, 28);
            this.textBox1.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(817, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Cellphone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(817, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Address:";
            // 
            // textBoxCellphone
            // 
            this.textBoxCellphone.Enabled = false;
            this.textBoxCellphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxCellphone.Location = new System.Drawing.Point(820, 457);
            this.textBoxCellphone.Name = "textBoxCellphone";
            this.textBoxCellphone.Size = new System.Drawing.Size(461, 28);
            this.textBoxCellphone.TabIndex = 34;
            // 
            // textBoxAddres
            // 
            this.textBoxAddres.Enabled = false;
            this.textBoxAddres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxAddres.Location = new System.Drawing.Point(820, 379);
            this.textBoxAddres.Name = "textBoxAddres";
            this.textBoxAddres.Size = new System.Drawing.Size(461, 28);
            this.textBoxAddres.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Location = new System.Drawing.Point(482, 581);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(418, 46);
            this.button1.TabIndex = 39;
            this.button1.Text = "Generar Reserva de vuelo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Vuelos Disponibles";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(817, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 41;
            this.label11.Text = "Sucursales";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Asientos (Primera Clase)";
            this.columnHeader9.Width = 165;
            // 
            // ReservarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 723);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxCellphone);
            this.Controls.Add(this.textBoxAddres);
            this.Controls.Add(this.listViewSucursales);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.classVuelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxDestino);
            this.Controls.Add(this.textBoxOrigen);
            this.Controls.Add(this.listViewVuelos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservarVuelo";
            this.Text = "ReservarVuelo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewVuelos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxDestino;
        private System.Windows.Forms.TextBox textBoxOrigen;
        private System.Windows.Forms.ComboBox classVuelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewSucursales;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCellphone;
        private System.Windows.Forms.TextBox textBoxAddres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}