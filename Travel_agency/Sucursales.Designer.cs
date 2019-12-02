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
            this.listViewSucursales.HideSelection = false;
            this.listViewSucursales.Location = new System.Drawing.Point(28, 68);
            this.listViewSucursales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewSucursales.Name = "listViewSucursales";
            this.listViewSucursales.Size = new System.Drawing.Size(496, 225);
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
            this.textBoxAddres.Location = new System.Drawing.Point(613, 143);
            this.textBoxAddres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAddres.Name = "textBoxAddres";
            this.textBoxAddres.Size = new System.Drawing.Size(312, 24);
            this.textBoxAddres.TabIndex = 2;
            // 
            // textBoxCellphone
            // 
            this.textBoxCellphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxCellphone.Location = new System.Drawing.Point(613, 207);
            this.textBoxCellphone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCellphone.Name = "textBoxCellphone";
            this.textBoxCellphone.Size = new System.Drawing.Size(312, 24);
            this.textBoxCellphone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cellphone:";
            // 
            // btnCreateSucursal
            // 
            this.btnCreateSucursal.Location = new System.Drawing.Point(610, 259);
            this.btnCreateSucursal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateSucursal.Name = "btnCreateSucursal";
            this.btnCreateSucursal.Size = new System.Drawing.Size(81, 34);
            this.btnCreateSucursal.TabIndex = 7;
            this.btnCreateSucursal.Text = "Crear";
            this.btnCreateSucursal.UseVisualStyleBackColor = true;
            this.btnCreateSucursal.Click += new System.EventHandler(this.btnCreateSucursal_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxID.Location = new System.Drawing.Point(610, 88);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(312, 24);
            this.textBoxID.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // btnUpdateSucursal
            // 
            this.btnUpdateSucursal.Location = new System.Drawing.Point(726, 259);
            this.btnUpdateSucursal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateSucursal.Name = "btnUpdateSucursal";
            this.btnUpdateSucursal.Size = new System.Drawing.Size(81, 34);
            this.btnUpdateSucursal.TabIndex = 11;
            this.btnUpdateSucursal.Text = "Actualizar";
            this.btnUpdateSucursal.UseVisualStyleBackColor = true;
            this.btnUpdateSucursal.Click += new System.EventHandler(this.btnUpdateSucursal_Click);
            // 
            // btnDeleteSucursal
            // 
            this.btnDeleteSucursal.Location = new System.Drawing.Point(841, 259);
            this.btnDeleteSucursal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteSucursal.Name = "btnDeleteSucursal";
            this.btnDeleteSucursal.Size = new System.Drawing.Size(81, 34);
            this.btnDeleteSucursal.TabIndex = 12;
            this.btnDeleteSucursal.Text = "Eliminar";
            this.btnDeleteSucursal.UseVisualStyleBackColor = true;
            this.btnDeleteSucursal.Click += new System.EventHandler(this.btnDeleteSucursal_Click);
            // 
            // Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(983, 587);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}