namespace Travel_agency {
    partial class Sucursales {
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
            this.listViewSucursales = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxAddres = new System.Windows.Forms.TextBox();
            this.textBoxCellphone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateSucursal = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateSucursal = new System.Windows.Forms.Button();
            this.btnDeleteSucursal = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listViewSucursales
            // 
            this.listViewSucursales.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewSucursales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewSucursales.FullRowSelect = true;
            this.listViewSucursales.Location = new System.Drawing.Point(27, 47);
            this.listViewSucursales.Name = "listViewSucursales";
            this.listViewSucursales.Size = new System.Drawing.Size(660, 276);
            this.listViewSucursales.TabIndex = 0;
            this.listViewSucursales.UseCompatibleStateImageBehavior = false;
            this.listViewSucursales.View = System.Windows.Forms.View.Details;
            this.listViewSucursales.SelectedIndexChanged += new System.EventHandler(this.listViewSucursales_SelectedIndexChanged);
            this.listViewSucursales.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 69;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Address";
            this.columnHeader2.Width = 311;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cellphone";
            this.columnHeader3.Width = 273;
            // 
            // textBoxAddres
            // 
            this.textBoxAddres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxAddres.Location = new System.Drawing.Point(817, 126);
            this.textBoxAddres.Name = "textBoxAddres";
            this.textBoxAddres.Size = new System.Drawing.Size(414, 28);
            this.textBoxAddres.TabIndex = 2;
            // 
            // textBoxCellphone
            // 
            this.textBoxCellphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxCellphone.Location = new System.Drawing.Point(817, 204);
            this.textBoxCellphone.Name = "textBoxCellphone";
            this.textBoxCellphone.Size = new System.Drawing.Size(414, 28);
            this.textBoxCellphone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(814, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(814, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cellphone:";
            // 
            // btnCreateSucursal
            // 
            this.btnCreateSucursal.Location = new System.Drawing.Point(814, 261);
            this.btnCreateSucursal.Name = "btnCreateSucursal";
            this.btnCreateSucursal.Size = new System.Drawing.Size(108, 42);
            this.btnCreateSucursal.TabIndex = 7;
            this.btnCreateSucursal.Text = "Crear";
            this.btnCreateSucursal.UseVisualStyleBackColor = true;
            this.btnCreateSucursal.Click += new System.EventHandler(this.btnCreateSucursal_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxID.Location = new System.Drawing.Point(817, 47);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(414, 28);
            this.textBoxID.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(814, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // btnUpdateSucursal
            // 
            this.btnUpdateSucursal.Location = new System.Drawing.Point(971, 261);
            this.btnUpdateSucursal.Name = "btnUpdateSucursal";
            this.btnUpdateSucursal.Size = new System.Drawing.Size(108, 42);
            this.btnUpdateSucursal.TabIndex = 11;
            this.btnUpdateSucursal.Text = "Actualizar";
            this.btnUpdateSucursal.UseVisualStyleBackColor = true;
            this.btnUpdateSucursal.Click += new System.EventHandler(this.btnUpdateSucursal_Click);
            // 
            // btnDeleteSucursal
            // 
            this.btnDeleteSucursal.Location = new System.Drawing.Point(1123, 261);
            this.btnDeleteSucursal.Name = "btnDeleteSucursal";
            this.btnDeleteSucursal.Size = new System.Drawing.Size(108, 42);
            this.btnDeleteSucursal.TabIndex = 12;
            this.btnDeleteSucursal.Text = "Eliminar (Inactivar)";
            this.btnDeleteSucursal.UseVisualStyleBackColor = true;
            this.btnDeleteSucursal.Click += new System.EventHandler(this.btnDeleteSucursal_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(147, 21);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sucursales activas";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(228, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(158, 21);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.Text = "Sucursales inactivas";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1311, 723);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnDeleteSucursal);
            this.Controls.Add(this.btnUpdateSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.btnCreateSucursal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCellphone);
            this.Controls.Add(this.textBoxAddres);
            this.Controls.Add(this.listViewSucursales);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sucursales";
            this.Text = "Sucursal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.Click_Window);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSucursales;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox textBoxAddres;
        private System.Windows.Forms.TextBox textBoxCellphone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateSucursal;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateSucursal;
        private System.Windows.Forms.Button btnDeleteSucursal;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}