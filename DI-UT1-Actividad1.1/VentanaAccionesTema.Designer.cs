
namespace DI_UT1_Actividad1._1
{
    partial class VentanaAccionesTema
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            this.btnVisualizarImagenTema = new System.Windows.Forms.Button();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAccionTema = new System.Windows.Forms.Button();
            this.mnuTema = new System.Windows.Forms.MenuStrip();
            this.mnuAcciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcciones_AccionTema = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAcciones_SalirVentanaTema = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuda_AcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTema.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVisualizarImagenTema
            // 
            this.btnVisualizarImagenTema.Location = new System.Drawing.Point(263, 92);
            this.btnVisualizarImagenTema.Name = "btnVisualizarImagenTema";
            this.btnVisualizarImagenTema.Size = new System.Drawing.Size(86, 28);
            this.btnVisualizarImagenTema.TabIndex = 40;
            this.btnVisualizarImagenTema.Text = "Visualizar";
            this.btnVisualizarImagenTema.UseVisualStyleBackColor = true;
            this.btnVisualizarImagenTema.Click += new System.EventHandler(this.btnVisualizarImagenTema_Click);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(26, 95);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(63, 20);
            this.lblImagen.TabIndex = 39;
            this.lblImagen.Text = "Imagen";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 38;
            this.lblNombre.Text = "Nombre";
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(95, 92);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(162, 26);
            this.txtImagen.TabIndex = 35;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(95, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(162, 26);
            this.txtNombre.TabIndex = 34;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(207, 141);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 28);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAccionTema
            // 
            this.btnAccionTema.Location = new System.Drawing.Point(60, 141);
            this.btnAccionTema.Name = "btnAccionTema";
            this.btnAccionTema.Size = new System.Drawing.Size(107, 28);
            this.btnAccionTema.TabIndex = 36;
            this.btnAccionTema.Text = "[ACCION]";
            this.btnAccionTema.UseVisualStyleBackColor = true;
            this.btnAccionTema.Click += new System.EventHandler(this.btnAccionTema_Click);
            // 
            // mnuTema
            // 
            this.mnuTema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAcciones,
            this.mnuAyuda});
            this.mnuTema.Location = new System.Drawing.Point(0, 0);
            this.mnuTema.Name = "mnuTema";
            this.mnuTema.Size = new System.Drawing.Size(403, 24);
            this.mnuTema.TabIndex = 41;
            this.mnuTema.Text = "menuStrip1";
            // 
            // mnuAcciones
            // 
            this.mnuAcciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAcciones_AccionTema,
            this.toolStripSeparator1,
            this.mnuAcciones_SalirVentanaTema});
            this.mnuAcciones.Name = "mnuAcciones";
            this.mnuAcciones.Size = new System.Drawing.Size(67, 20);
            this.mnuAcciones.Text = "&Acciones";
            // 
            // mnuAcciones_AccionTema
            // 
            this.mnuAcciones_AccionTema.Name = "mnuAcciones_AccionTema";
            this.mnuAcciones_AccionTema.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuAcciones_AccionTema.Size = new System.Drawing.Size(180, 22);
            this.mnuAcciones_AccionTema.Text = "[Accion]";
            this.mnuAcciones_AccionTema.Click += new System.EventHandler(this.mnuAcciones_AccionTema_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuAcciones_SalirVentanaTema
            // 
            this.mnuAcciones_SalirVentanaTema.Image = global::DI_UT1_Actividad1._1.Properties.Resources.cerrar;
            this.mnuAcciones_SalirVentanaTema.Name = "mnuAcciones_SalirVentanaTema";
            this.mnuAcciones_SalirVentanaTema.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuAcciones_SalirVentanaTema.Size = new System.Drawing.Size(180, 22);
            this.mnuAcciones_SalirVentanaTema.Text = "Salir";
            this.mnuAcciones_SalirVentanaTema.Click += new System.EventHandler(this.mnuAcciones_SalirVentanaTema_Click);
            // 
            // mnuAyuda
            // 
            this.mnuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAyuda_AcercaDe});
            this.mnuAyuda.Name = "mnuAyuda";
            this.mnuAyuda.Size = new System.Drawing.Size(53, 20);
            this.mnuAyuda.Text = "A&yuda";
            // 
            // mnuAyuda_AcercaDe
            // 
            this.mnuAyuda_AcercaDe.Image = global::DI_UT1_Actividad1._1.Properties.Resources.acercaDe;
            this.mnuAyuda_AcercaDe.Name = "mnuAyuda_AcercaDe";
            this.mnuAyuda_AcercaDe.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.mnuAyuda_AcercaDe.Size = new System.Drawing.Size(163, 22);
            this.mnuAyuda_AcercaDe.Text = "Acerca de";
            this.mnuAyuda_AcercaDe.Click += new System.EventHandler(this.mnuAyuda_AcercaDe_Click);
            // 
            // VentanaAccionesTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 196);
            this.Controls.Add(this.mnuTema);
            this.Controls.Add(this.btnVisualizarImagenTema);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAccionTema);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VentanaAccionesTema";
            this.Text = "W";
            this.Load += new System.EventHandler(this.VentanaAccionesTema_Load);
            this.mnuTema.ResumeLayout(false);
            this.mnuTema.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVisualizarImagenTema;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAccionTema;
        private System.Windows.Forms.MenuStrip mnuTema;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones_AccionTema;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones_SalirVentanaTema;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda_AcercaDe;
    }
}