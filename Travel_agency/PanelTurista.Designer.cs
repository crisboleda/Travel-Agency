namespace Travel_agency {
    partial class PanelTurista {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHoteles = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemVuelos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemMisReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemPerfil,
            this.MenuItemHoteles,
            this.MenuItemVuelos,
            this.MenuItemMisReservas,
            this.MenuItemCerrar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 8, 0, 8);
            this.menuStrip1.Size = new System.Drawing.Size(1311, 50);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Click_Item_Menu);
            // 
            // MenuItemPerfil
            // 
            this.MenuItemPerfil.Checked = true;
            this.MenuItemPerfil.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuItemPerfil.Enabled = false;
            this.MenuItemPerfil.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MenuItemPerfil.Name = "MenuItemPerfil";
            this.MenuItemPerfil.ShowShortcutKeys = false;
            this.MenuItemPerfil.Size = new System.Drawing.Size(75, 34);
            this.MenuItemPerfil.Text = "Perfil";
            // 
            // MenuItemHoteles
            // 
            this.MenuItemHoteles.Name = "MenuItemHoteles";
            this.MenuItemHoteles.Size = new System.Drawing.Size(169, 34);
            this.MenuItemHoteles.Text = "Reservar Hotel";
            // 
            // MenuItemVuelos
            // 
            this.MenuItemVuelos.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MenuItemVuelos.Name = "MenuItemVuelos";
            this.MenuItemVuelos.Size = new System.Drawing.Size(171, 34);
            this.MenuItemVuelos.Text = "Reservar Vuelo";
            // 
            // MenuItemCerrar
            // 
            this.MenuItemCerrar.Name = "MenuItemCerrar";
            this.MenuItemCerrar.Size = new System.Drawing.Size(154, 34);
            this.MenuItemCerrar.Text = "Cerrar sesión";
            // 
            // MenuItemMisReservas
            // 
            this.MenuItemMisReservas.Name = "MenuItemMisReservas";
            this.MenuItemMisReservas.Size = new System.Drawing.Size(147, 34);
            this.MenuItemMisReservas.Text = "Mis reservas";
            // 
            // PanelTurista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 723);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PanelTurista";
            this.Text = "PanelTurista";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Close_Forms);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPerfil;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHoteles;
        private System.Windows.Forms.ToolStripMenuItem MenuItemVuelos;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCerrar;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMisReservas;
    }
}