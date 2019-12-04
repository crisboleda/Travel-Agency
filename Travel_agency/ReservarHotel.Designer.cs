namespace Travel_agency {
    partial class ReservarHotel {
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
            this.listViewHoteles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxIDSucursal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCellphoneSucursal = new System.Windows.Forms.TextBox();
            this.textBoxAddressSucursal = new System.Windows.Forms.TextBox();
            this.listViewSucursales = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIDHotel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCellphoneHotel = new System.Windows.Forms.TextBox();
            this.textBoxAddressHotel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNameHotel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCityHotel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxRooms = new System.Windows.Forms.TextBox();
            this.comboBoxPension = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateLlegada = new System.Windows.Forms.DateTimePicker();
            this.dateSalida = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewHoteles
            // 
            this.listViewHoteles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewHoteles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewHoteles.FullRowSelect = true;
            this.listViewHoteles.HideSelection = false;
            this.listViewHoteles.Location = new System.Drawing.Point(28, 30);
            this.listViewHoteles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewHoteles.Name = "listViewHoteles";
            this.listViewHoteles.Size = new System.Drawing.Size(756, 191);
            this.listViewHoteles.TabIndex = 0;
            this.listViewHoteles.UseCompatibleStateImageBehavior = false;
            this.listViewHoteles.View = System.Windows.Forms.View.Details;
            this.listViewHoteles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_Item_Hotel);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 141;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Address";
            this.columnHeader3.Width = 116;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "City";
            this.columnHeader4.Width = 113;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cellphone";
            this.columnHeader5.Width = 148;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Habitaciones disponibles";
            this.columnHeader6.Width = 184;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(815, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 49;
            this.label11.Text = "Sucursales";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(894, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "ID:";
            // 
            // textBoxIDSucursal
            // 
            this.textBoxIDSucursal.Enabled = false;
            this.textBoxIDSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxIDSucursal.Location = new System.Drawing.Point(896, 260);
            this.textBoxIDSucursal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIDSucursal.Name = "textBoxIDSucursal";
            this.textBoxIDSucursal.ReadOnly = true;
            this.textBoxIDSucursal.Size = new System.Drawing.Size(312, 28);
            this.textBoxIDSucursal.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(894, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "Cellphone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(894, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "Address:";
            // 
            // textBoxCellphoneSucursal
            // 
            this.textBoxCellphoneSucursal.Enabled = false;
            this.textBoxCellphoneSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxCellphoneSucursal.Location = new System.Drawing.Point(896, 417);
            this.textBoxCellphoneSucursal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCellphoneSucursal.Name = "textBoxCellphoneSucursal";
            this.textBoxCellphoneSucursal.ReadOnly = true;
            this.textBoxCellphoneSucursal.Size = new System.Drawing.Size(312, 28);
            this.textBoxCellphoneSucursal.TabIndex = 44;
            // 
            // textBoxAddressSucursal
            // 
            this.textBoxAddressSucursal.Enabled = false;
            this.textBoxAddressSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxAddressSucursal.Location = new System.Drawing.Point(896, 339);
            this.textBoxAddressSucursal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddressSucursal.Name = "textBoxAddressSucursal";
            this.textBoxAddressSucursal.ReadOnly = true;
            this.textBoxAddressSucursal.Size = new System.Drawing.Size(312, 28);
            this.textBoxAddressSucursal.TabIndex = 43;
            // 
            // listViewSucursales
            // 
            this.listViewSucursales.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewSucursales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewSucursales.FullRowSelect = true;
            this.listViewSucursales.HideSelection = false;
            this.listViewSucursales.Location = new System.Drawing.Point(819, 30);
            this.listViewSucursales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewSucursales.Name = "listViewSucursales";
            this.listViewSucursales.Size = new System.Drawing.Size(461, 191);
            this.listViewSucursales.TabIndex = 42;
            this.listViewSucursales.UseCompatibleStateImageBehavior = false;
            this.listViewSucursales.View = System.Windows.Forms.View.Details;
            this.listViewSucursales.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_Item_Sucursales);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            this.columnHeader7.Width = 69;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Address";
            this.columnHeader8.Width = 81;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Cellphone";
            this.columnHeader9.Width = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Hoteles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "ID:";
            // 
            // textBoxIDHotel
            // 
            this.textBoxIDHotel.Enabled = false;
            this.textBoxIDHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxIDHotel.Location = new System.Drawing.Point(34, 260);
            this.textBoxIDHotel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIDHotel.Name = "textBoxIDHotel";
            this.textBoxIDHotel.ReadOnly = true;
            this.textBoxIDHotel.Size = new System.Drawing.Size(315, 28);
            this.textBoxIDHotel.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Cellphone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "Address:";
            // 
            // textBoxCellphoneHotel
            // 
            this.textBoxCellphoneHotel.Enabled = false;
            this.textBoxCellphoneHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxCellphoneHotel.Location = new System.Drawing.Point(440, 338);
            this.textBoxCellphoneHotel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCellphoneHotel.Name = "textBoxCellphoneHotel";
            this.textBoxCellphoneHotel.ReadOnly = true;
            this.textBoxCellphoneHotel.Size = new System.Drawing.Size(315, 28);
            this.textBoxCellphoneHotel.TabIndex = 52;
            // 
            // textBoxAddressHotel
            // 
            this.textBoxAddressHotel.Enabled = false;
            this.textBoxAddressHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxAddressHotel.Location = new System.Drawing.Point(440, 260);
            this.textBoxAddressHotel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddressHotel.Name = "textBoxAddressHotel";
            this.textBoxAddressHotel.ReadOnly = true;
            this.textBoxAddressHotel.Size = new System.Drawing.Size(315, 28);
            this.textBoxAddressHotel.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Name:";
            // 
            // textBoxNameHotel
            // 
            this.textBoxNameHotel.Enabled = false;
            this.textBoxNameHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxNameHotel.Location = new System.Drawing.Point(34, 339);
            this.textBoxNameHotel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNameHotel.Name = "textBoxNameHotel";
            this.textBoxNameHotel.ReadOnly = true;
            this.textBoxNameHotel.Size = new System.Drawing.Size(315, 28);
            this.textBoxNameHotel.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 60;
            this.label6.Text = "City";
            // 
            // textBoxCityHotel
            // 
            this.textBoxCityHotel.Enabled = false;
            this.textBoxCityHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxCityHotel.Location = new System.Drawing.Point(34, 423);
            this.textBoxCityHotel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCityHotel.Name = "textBoxCityHotel";
            this.textBoxCityHotel.ReadOnly = true;
            this.textBoxCityHotel.Size = new System.Drawing.Size(315, 28);
            this.textBoxCityHotel.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 17);
            this.label10.TabIndex = 62;
            this.label10.Text = "Habitaciones Disponibles:";
            // 
            // textBoxRooms
            // 
            this.textBoxRooms.Enabled = false;
            this.textBoxRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxRooms.Location = new System.Drawing.Point(440, 423);
            this.textBoxRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRooms.Name = "textBoxRooms";
            this.textBoxRooms.ReadOnly = true;
            this.textBoxRooms.Size = new System.Drawing.Size(315, 28);
            this.textBoxRooms.TabIndex = 63;
            // 
            // comboBoxPension
            // 
            this.comboBoxPension.FormattingEnabled = true;
            this.comboBoxPension.Items.AddRange(new object[] {
            "Media Pensión",
            "Pensión completa"});
            this.comboBoxPension.Location = new System.Drawing.Point(32, 510);
            this.comboBoxPension.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxPension.Name = "comboBoxPension";
            this.comboBoxPension.Size = new System.Drawing.Size(315, 24);
            this.comboBoxPension.TabIndex = 64;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 491);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 17);
            this.label13.TabIndex = 66;
            this.label13.Text = "Tipo de pensión:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 600);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(621, 46);
            this.button1.TabIndex = 69;
            this.button1.Text = "Reservar hotel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateLlegada
            // 
            this.dateLlegada.Location = new System.Drawing.Point(441, 508);
            this.dateLlegada.Name = "dateLlegada";
            this.dateLlegada.Size = new System.Drawing.Size(314, 22);
            this.dateLlegada.TabIndex = 70;
            // 
            // dateSalida
            // 
            this.dateSalida.Location = new System.Drawing.Point(896, 508);
            this.dateSalida.Name = "dateSalida";
            this.dateSalida.Size = new System.Drawing.Size(314, 22);
            this.dateSalida.TabIndex = 71;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(439, 488);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 17);
            this.label14.TabIndex = 72;
            this.label14.Text = "Fecha llegada:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(893, 488);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 17);
            this.label15.TabIndex = 73;
            this.label15.Text = "Fecha salida:";
            // 
            // ReservarHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 722);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dateSalida);
            this.Controls.Add(this.dateLlegada);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBoxPension);
            this.Controls.Add(this.textBoxRooms);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCityHotel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNameHotel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIDHotel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCellphoneHotel);
            this.Controls.Add(this.textBoxAddressHotel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxIDSucursal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxCellphoneSucursal);
            this.Controls.Add(this.textBoxAddressSucursal);
            this.Controls.Add(this.listViewSucursales);
            this.Controls.Add(this.listViewHoteles);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservarHotel";
            this.Text = "Fecha llegada:";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.Click_Window);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewHoteles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxIDSucursal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCellphoneSucursal;
        private System.Windows.Forms.TextBox textBoxAddressSucursal;
        private System.Windows.Forms.ListView listViewSucursales;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIDHotel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCellphoneHotel;
        private System.Windows.Forms.TextBox textBoxAddressHotel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNameHotel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCityHotel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxRooms;
        private System.Windows.Forms.ComboBox comboBoxPension;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateLlegada;
        private System.Windows.Forms.DateTimePicker dateSalida;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}