
namespace DI_UT1_Actividad1._1
{
    partial class VentanaAccionesTutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaAccionesTutorial));
            this.mnuTema = new System.Windows.Forms.MenuStrip();
            this.mnuAcciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcciones_Accion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAcciones_SalirVentanaPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuda_AcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAccion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.txtVideo = new System.Windows.Forms.TextBox();
            this.cmbTema = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblVideo = new System.Windows.Forms.Label();
            this.btnVisualizarImagen = new System.Windows.Forms.Button();
            this.btnVisualizarVideo = new System.Windows.Forms.Button();
            this.mnuTema.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuTema
            // 
            this.mnuTema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAcciones,
            this.mnuAyuda});
            this.mnuTema.Location = new System.Drawing.Point(0, 0);
            this.mnuTema.Name = "mnuTema";
            this.mnuTema.Size = new System.Drawing.Size(484, 24);
            this.mnuTema.TabIndex = 16;
            this.mnuTema.Text = "menuStrip1";
            // 
            // mnuAcciones
            // 
            this.mnuAcciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAcciones_Accion,
            this.toolStripSeparator1,
            this.mnuAcciones_SalirVentanaPrincipal});
            this.mnuAcciones.Name = "mnuAcciones";
            this.mnuAcciones.Size = new System.Drawing.Size(67, 20);
            this.mnuAcciones.Text = "&Acciones";
            // 
            // mnuAcciones_Accion
            // 
            this.mnuAcciones_Accion.Name = "mnuAcciones_Accion";
            this.mnuAcciones_Accion.Size = new System.Drawing.Size(137, 22);
            this.mnuAcciones_Accion.Text = "[Accion]";
            this.mnuAcciones_Accion.Click += new System.EventHandler(this.mnuAcciones_Accion_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(134, 6);
            // 
            // mnuAcciones_SalirVentanaPrincipal
            // 
            this.mnuAcciones_SalirVentanaPrincipal.Image = global::DI_UT1_Actividad1._1.Properties.Resources.cerrar;
            this.mnuAcciones_SalirVentanaPrincipal.Name = "mnuAcciones_SalirVentanaPrincipal";
            this.mnuAcciones_SalirVentanaPrincipal.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuAcciones_SalirVentanaPrincipal.Size = new System.Drawing.Size(137, 22);
            this.mnuAcciones_SalirVentanaPrincipal.Text = "Salir";
            this.mnuAcciones_SalirVentanaPrincipal.Click += new System.EventHandler(this.mnuAcciones_SalirVentanaPrincipal_Click);
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
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(161, 355);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(107, 28);
            this.btnAccion.TabIndex = 8;
            this.btnAccion.Text = "[ACCION]";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(308, 355);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 28);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(161, 52);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(162, 26);
            this.txtTitulo.TabIndex = 1;
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(161, 278);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(162, 26);
            this.txtImagen.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(161, 188);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(254, 84);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(161, 122);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(162, 26);
            this.txtCategoria.TabIndex = 3;
            // 
            // dateFecha
            // 
            this.dateFecha.CustomFormat = "dd/MM/yyyy";
            this.dateFecha.Location = new System.Drawing.Point(161, 156);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(162, 26);
            this.dateFecha.TabIndex = 4;
            // 
            // txtVideo
            // 
            this.txtVideo.Location = new System.Drawing.Point(161, 310);
            this.txtVideo.Name = "txtVideo";
            this.txtVideo.Size = new System.Drawing.Size(162, 26);
            this.txtVideo.TabIndex = 7;
            // 
            // cmbTema
            // 
            this.cmbTema.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmbTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTema.FormattingEnabled = true;
            this.cmbTema.Location = new System.Drawing.Point(161, 86);
            this.cmbTema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTema.Name = "cmbTema";
            this.cmbTema.Size = new System.Drawing.Size(162, 28);
            this.cmbTema.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(68, 55);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 20);
            this.lblTitulo.TabIndex = 26;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Location = new System.Drawing.Point(66, 89);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(49, 20);
            this.lblTema.TabIndex = 27;
            this.lblTema.Text = "Tema";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(66, 125);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(78, 20);
            this.lblCategoria.TabIndex = 28;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(66, 162);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 29;
            this.lblFecha.Text = "Fecha";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(66, 191);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.lblDescripcion.TabIndex = 30;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(66, 281);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(63, 20);
            this.lblImagen.TabIndex = 31;
            this.lblImagen.Text = "Imagen";
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Location = new System.Drawing.Point(68, 313);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(50, 20);
            this.lblVideo.TabIndex = 32;
            this.lblVideo.Text = "Video";
            // 
            // btnVisualizarImagen
            // 
            this.btnVisualizarImagen.Location = new System.Drawing.Point(329, 278);
            this.btnVisualizarImagen.Name = "btnVisualizarImagen";
            this.btnVisualizarImagen.Size = new System.Drawing.Size(86, 28);
            this.btnVisualizarImagen.TabIndex = 33;
            this.btnVisualizarImagen.Text = "Visualizar";
            this.btnVisualizarImagen.UseVisualStyleBackColor = true;
            // 
            // btnVisualizarVideo
            // 
            this.btnVisualizarVideo.Location = new System.Drawing.Point(329, 309);
            this.btnVisualizarVideo.Name = "btnVisualizarVideo";
            this.btnVisualizarVideo.Size = new System.Drawing.Size(86, 28);
            this.btnVisualizarVideo.TabIndex = 34;
            this.btnVisualizarVideo.Text = "Visualizar";
            this.btnVisualizarVideo.UseVisualStyleBackColor = true;
            // 
            // VentanaAccionesTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 417);
            this.Controls.Add(this.btnVisualizarVideo);
            this.Controls.Add(this.btnVisualizarImagen);
            this.Controls.Add(this.lblVideo);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cmbTema);
            this.Controls.Add(this.txtVideo);
            this.Controls.Add(this.dateFecha);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.mnuTema);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VentanaAccionesTutorial";
            this.Text = "Trabajo Tutoriales - [ACCION]";
            this.Load += new System.EventHandler(this.VentanaAccionesTutorial_Load);
            this.mnuTema.ResumeLayout(false);
            this.mnuTema.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuTema;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones_SalirVentanaPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda_AcercaDe;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.TextBox txtVideo;
        private System.Windows.Forms.ComboBox cmbTema;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.Button btnVisualizarImagen;
        private System.Windows.Forms.Button btnVisualizarVideo;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones_Accion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}