namespace Travel_agency {
    partial class Hotels {
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
        private void InitializeComponent()
        {
            this.listViewHotels = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCreateHotel = new System.Windows.Forms.Button();
            this.btnUpdateHotel = new System.Windows.Forms.Button();
            this.btnDeleteHotel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewHotels
            // 
            this.listViewHotels.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewHotels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewHotels.FullRowSelect = true;
            this.listViewHotels.HideSelection = false;
            this.listViewHotels.Location = new System.Drawing.Point(11, 81);
            this.listViewHotels.Margin = new System.Windows.Forms.Padding(2);
            this.listViewHotels.Name = "listViewHotels";
            this.listViewHotels.Size = new System.Drawing.Size(582, 269);
            this.listViewHotels.TabIndex = 1;
            this.listViewHotels.UseCompatibleStateImageBehavior = false;
            this.listViewHotels.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 69;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Address";
            this.columnHeader2.Width = 235;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cellphone";
            this.columnHeader3.Width = 273;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxID.Location = new System.Drawing.Point(629, 108);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(312, 24);
            this.textBoxID.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox1.Location = new System.Drawing.Point(629, 180);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 24);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox2.Location = new System.Drawing.Point(629, 253);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(312, 24);
            this.textBox2.TabIndex = 12;
            // 
            // btnCreateHotel
            // 
            this.btnCreateHotel.Location = new System.Drawing.Point(629, 316);
            this.btnCreateHotel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateHotel.Name = "btnCreateHotel";
            this.btnCreateHotel.Size = new System.Drawing.Size(81, 34);
            this.btnCreateHotel.TabIndex = 13;
            this.btnCreateHotel.Text = "Crear";
            this.btnCreateHotel.UseVisualStyleBackColor = true;
            // 
            // btnUpdateHotel
            // 
            this.btnUpdateHotel.Location = new System.Drawing.Point(746, 316);
            this.btnUpdateHotel.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateHotel.Name = "btnUpdateHotel";
            this.btnUpdateHotel.Size = new System.Drawing.Size(81, 34);
            this.btnUpdateHotel.TabIndex = 14;
            this.btnUpdateHotel.Text = "Actualizar";
            this.btnUpdateHotel.UseVisualStyleBackColor = true;
            // 
            // btnDeleteHotel
            // 
            this.btnDeleteHotel.Location = new System.Drawing.Point(860, 316);
            this.btnDeleteHotel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteHotel.Name = "btnDeleteHotel";
            this.btnDeleteHotel.Size = new System.Drawing.Size(81, 34);
            this.btnDeleteHotel.TabIndex = 15;
            this.btnDeleteHotel.Text = "Eliminar";
            this.btnDeleteHotel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(626, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cellphone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "ID:";
            // 
            // Hotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 520);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteHotel);
            this.Controls.Add(this.btnUpdateHotel);
            this.Controls.Add(this.btnCreateHotel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.listViewHotels);
            this.Name = "Hotels";
            this.Text = "Hotels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewHotels;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCreateHotel;
        private System.Windows.Forms.Button btnUpdateHotel;
        private System.Windows.Forms.Button btnDeleteHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}