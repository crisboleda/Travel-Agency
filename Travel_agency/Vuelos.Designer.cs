namespace Travel_agency {
    partial class Vuelos {
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
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxOrigen = new System.Windows.Forms.TextBox();
            this.textBoxDestino = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.plazasTurista = new System.Windows.Forms.NumericUpDown();
            this.listBoxFormatTime = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.plazasTotales = new System.Windows.Forms.NumericUpDown();
            this.btnCreateVuelo = new System.Windows.Forms.Button();
            this.btnUpdateVuelo = new System.Windows.Forms.Button();
            this.btnDeleteVuelo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.plazasTurista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plazasTotales)).BeginInit();
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
            this.columnHeader5});
            this.listViewVuelos.FullRowSelect = true;
            this.listViewVuelos.Location = new System.Drawing.Point(31, 45);
            this.listViewVuelos.Name = "listViewVuelos";
            this.listViewVuelos.Size = new System.Drawing.Size(1254, 253);
            this.listViewVuelos.TabIndex = 0;
            this.listViewVuelos.UseCompatibleStateImageBehavior = false;
            this.listViewVuelos.View = System.Windows.Forms.View.Details;
            this.listViewVuelos.SelectedIndexChanged += new System.EventHandler(this.listViewVuelos_SelectedIndexChanged);
            this.listViewVuelos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 56;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fecha";
            this.columnHeader2.Width = 293;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hora";
            this.columnHeader3.Width = 162;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Origen";
            this.columnHeader4.Width = 167;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Destino";
            this.columnHeader8.Width = 131;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Plazas clase turista";
            this.columnHeader10.Width = 146;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Plazas en total";
            this.columnHeader5.Width = 234;
            // 
            // textBoxOrigen
            // 
            this.textBoxOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxOrigen.Location = new System.Drawing.Point(567, 376);
            this.textBoxOrigen.Name = "textBoxOrigen";
            this.textBoxOrigen.Size = new System.Drawing.Size(265, 28);
            this.textBoxOrigen.TabIndex = 2;
            // 
            // textBoxDestino
            // 
            this.textBoxDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxDestino.Location = new System.Drawing.Point(567, 459);
            this.textBoxDestino.Name = "textBoxDestino";
            this.textBoxDestino.Size = new System.Drawing.Size(265, 28);
            this.textBoxDestino.TabIndex = 3;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxID.Location = new System.Drawing.Point(154, 376);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(313, 28);
            this.textBoxID.TabIndex = 4;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxTime.Location = new System.Drawing.Point(154, 551);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(259, 30);
            this.textBoxTime.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarTitleForeColor = System.Drawing.Color.YellowGreen;
            this.dateTimePickerDate.Location = new System.Drawing.Point(154, 465);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(313, 22);
            this.dateTimePickerDate.TabIndex = 8;
            this.dateTimePickerDate.Value = new System.DateTime(2019, 12, 20, 0, 0, 0, 0);
            // 
            // plazasTurista
            // 
            this.plazasTurista.Location = new System.Drawing.Point(567, 551);
            this.plazasTurista.Name = "plazasTurista";
            this.plazasTurista.Size = new System.Drawing.Size(131, 22);
            this.plazasTurista.TabIndex = 9;
            // 
            // listBoxFormatTime
            // 
            this.listBoxFormatTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBoxFormatTime.FormattingEnabled = true;
            this.listBoxFormatTime.ItemHeight = 20;
            this.listBoxFormatTime.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.listBoxFormatTime.Location = new System.Drawing.Point(419, 553);
            this.listBoxFormatTime.Name = "listBoxFormatTime";
            this.listBoxFormatTime.Size = new System.Drawing.Size(68, 24);
            this.listBoxFormatTime.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Origen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Destino:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 531);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Plazas clase turista:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(720, 531);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Plazas totales:";
            // 
            // plazasTotales
            // 
            this.plazasTotales.Location = new System.Drawing.Point(723, 551);
            this.plazasTotales.Name = "plazasTotales";
            this.plazasTotales.Size = new System.Drawing.Size(109, 22);
            this.plazasTotales.TabIndex = 17;
            // 
            // btnCreateVuelo
            // 
            this.btnCreateVuelo.Location = new System.Drawing.Point(975, 368);
            this.btnCreateVuelo.Name = "btnCreateVuelo";
            this.btnCreateVuelo.Size = new System.Drawing.Size(229, 48);
            this.btnCreateVuelo.TabIndex = 18;
            this.btnCreateVuelo.Text = "Crear";
            this.btnCreateVuelo.UseVisualStyleBackColor = true;
            this.btnCreateVuelo.Click += new System.EventHandler(this.btnCreateVuelo_Click);
            // 
            // btnUpdateVuelo
            // 
            this.btnUpdateVuelo.Location = new System.Drawing.Point(975, 465);
            this.btnUpdateVuelo.Name = "btnUpdateVuelo";
            this.btnUpdateVuelo.Size = new System.Drawing.Size(229, 48);
            this.btnUpdateVuelo.TabIndex = 19;
            this.btnUpdateVuelo.Text = "Actualizar";
            this.btnUpdateVuelo.UseVisualStyleBackColor = true;
            this.btnUpdateVuelo.Click += new System.EventHandler(this.btnUpdateVuelo_Click);
            // 
            // btnDeleteVuelo
            // 
            this.btnDeleteVuelo.Location = new System.Drawing.Point(975, 565);
            this.btnDeleteVuelo.Name = "btnDeleteVuelo";
            this.btnDeleteVuelo.Size = new System.Drawing.Size(229, 50);
            this.btnDeleteVuelo.TabIndex = 20;
            this.btnDeleteVuelo.Text = "Eliminar (Inactivar)";
            this.btnDeleteVuelo.UseVisualStyleBackColor = true;
            this.btnDeleteVuelo.Click += new System.EventHandler(this.btnDeleteVuelo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1311, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(31, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(120, 21);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Vuelos activos";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(172, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(131, 21);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.Text = "Vuelos inactivos";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Vuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 723);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnDeleteVuelo);
            this.Controls.Add(this.btnUpdateVuelo);
            this.Controls.Add(this.btnCreateVuelo);
            this.Controls.Add(this.plazasTotales);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxFormatTime);
            this.Controls.Add(this.plazasTurista);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxDestino);
            this.Controls.Add(this.textBoxOrigen);
            this.Controls.Add(this.listViewVuelos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Vuelos";
            this.Text = "Vuelos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.Click_Window);
            ((System.ComponentModel.ISupportInitialize)(this.plazasTurista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plazasTotales)).EndInit();
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
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox textBoxOrigen;
        private System.Windows.Forms.TextBox textBoxDestino;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.NumericUpDown plazasTurista;
        private System.Windows.Forms.ListBox listBoxFormatTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown plazasTotales;
        private System.Windows.Forms.Button btnCreateVuelo;
        private System.Windows.Forms.Button btnUpdateVuelo;
        private System.Windows.Forms.Button btnDeleteVuelo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}