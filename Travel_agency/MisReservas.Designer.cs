namespace Travel_agency {
    partial class MisReservas {
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
            this.listViewReservaHoteles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewReservaVuelos = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewReservaHoteles
            // 
            this.listViewReservaHoteles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewReservaHoteles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewReservaHoteles.FullRowSelect = true;
            this.listViewReservaHoteles.HideSelection = false;
            this.listViewReservaHoteles.Location = new System.Drawing.Point(13, 54);
            this.listViewReservaHoteles.Margin = new System.Windows.Forms.Padding(4);
            this.listViewReservaHoteles.Name = "listViewReservaHoteles";
            this.listViewReservaHoteles.Size = new System.Drawing.Size(1285, 256);
            this.listViewReservaHoteles.TabIndex = 1;
            this.listViewReservaHoteles.UseCompatibleStateImageBehavior = false;
            this.listViewReservaHoteles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID reserva";
            this.columnHeader1.Width = 126;
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
            // columnHeader7
            // 
            this.columnHeader7.Text = "Fecha llegada";
            this.columnHeader7.Width = 184;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Fecha salida";
            this.columnHeader8.Width = 175;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tipo pensión";
            this.columnHeader9.Width = 157;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hoteles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(8, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vuelos";
            // 
            // listViewReservaVuelos
            // 
            this.listViewReservaVuelos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.listViewReservaVuelos.Location = new System.Drawing.Point(13, 380);
            this.listViewReservaVuelos.Name = "listViewReservaVuelos";
            this.listViewReservaVuelos.Size = new System.Drawing.Size(1285, 234);
            this.listViewReservaVuelos.TabIndex = 4;
            this.listViewReservaVuelos.UseCompatibleStateImageBehavior = false;
            this.listViewReservaVuelos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID reserva";
            this.columnHeader6.Width = 127;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Date vuelo";
            this.columnHeader10.Width = 143;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Time vuelo";
            this.columnHeader11.Width = 178;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Origen vuelo";
            this.columnHeader12.Width = 174;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Destino vuelo";
            this.columnHeader13.Width = 201;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Clase vuelo";
            this.columnHeader14.Width = 202;
            // 
            // MisReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 723);
            this.Controls.Add(this.listViewReservaVuelos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewReservaHoteles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MisReservas";
            this.Text = "MisReservas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewReservaHoteles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewReservaVuelos;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
    }
}