using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DI_UT1_Actividad1._1
{
    partial class VentanaInicial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbTema = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblTema = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTutoriales = new System.Windows.Forms.Label();
            this.gpbBotonesTutoriales = new System.Windows.Forms.GroupBox();
            this.btnDetallesTutorial = new System.Windows.Forms.Button();
            this.btnAnnadirTutorial = new System.Windows.Forms.Button();
            this.btnModificarTutorial = new System.Windows.Forms.Button();
            this.btnEliminarTutorial = new System.Windows.Forms.Button();
            this.mnuInicio = new System.Windows.Forms.MenuStrip();
            this.mnuAcciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcciones_AnnadirTutorial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcciones_ModificarTutorial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcciones_EliminarTutorial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcciones_DetallesTutorial = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAcciones_Recargar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcciones_AccionesTemas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAcciones_SalirVentanaPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuda_AcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvTutoriales = new System.Windows.Forms.DataGridView();
            this.btnAccionesTemas = new System.Windows.Forms.Button();
            this.gpbBotonesTutoriales.SuspendLayout();
            this.mnuInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutoriales)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTema
            // 
            this.cmbTema.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmbTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTema.FormattingEnabled = true;
            this.cmbTema.Location = new System.Drawing.Point(573, 66);
            this.cmbTema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTema.Name = "cmbTema";
            this.cmbTema.Size = new System.Drawing.Size(180, 28);
            this.cmbTema.TabIndex = 2;
            this.cmbTema.SelectedIndexChanged += new System.EventHandler(this.cmbTema_SelectedIndexChanged);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(573, 147);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(180, 28);
            this.cmbCategoria.TabIndex = 4;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Location = new System.Drawing.Point(509, 69);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(57, 20);
            this.lblTema.TabIndex = 10;
            this.lblTema.Text = "Temas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Categorias";
            // 
            // lblTutoriales
            // 
            this.lblTutoriales.AutoSize = true;
            this.lblTutoriales.Location = new System.Drawing.Point(21, 41);
            this.lblTutoriales.Name = "lblTutoriales";
            this.lblTutoriales.Size = new System.Drawing.Size(82, 20);
            this.lblTutoriales.TabIndex = 12;
            this.lblTutoriales.Text = "Tutoriales:";
            // 
            // gpbBotonesTutoriales
            // 
            this.gpbBotonesTutoriales.Controls.Add(this.btnDetallesTutorial);
            this.gpbBotonesTutoriales.Controls.Add(this.btnAnnadirTutorial);
            this.gpbBotonesTutoriales.Controls.Add(this.btnModificarTutorial);
            this.gpbBotonesTutoriales.Controls.Add(this.btnEliminarTutorial);
            this.gpbBotonesTutoriales.Location = new System.Drawing.Point(486, 197);
            this.gpbBotonesTutoriales.Name = "gpbBotonesTutoriales";
            this.gpbBotonesTutoriales.Size = new System.Drawing.Size(267, 215);
            this.gpbBotonesTutoriales.TabIndex = 13;
            this.gpbBotonesTutoriales.TabStop = false;
            this.gpbBotonesTutoriales.Text = "Tutoriales";
            // 
            // btnDetallesTutorial
            // 
            this.btnDetallesTutorial.BackColor = System.Drawing.SystemColors.Control;
            this.btnDetallesTutorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetallesTutorial.Location = new System.Drawing.Point(87, 162);
            this.btnDetallesTutorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDetallesTutorial.Name = "btnDetallesTutorial";
            this.btnDetallesTutorial.Size = new System.Drawing.Size(173, 35);
            this.btnDetallesTutorial.TabIndex = 8;
            this.btnDetallesTutorial.Text = "Detalles";
            this.btnDetallesTutorial.UseVisualStyleBackColor = false;
            this.btnDetallesTutorial.Click += new System.EventHandler(this.btnDetallesTutorial_Click);
            // 
            // btnAnnadirTutorial
            // 
            this.btnAnnadirTutorial.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnnadirTutorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnadirTutorial.Location = new System.Drawing.Point(87, 27);
            this.btnAnnadirTutorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnnadirTutorial.Name = "btnAnnadirTutorial";
            this.btnAnnadirTutorial.Size = new System.Drawing.Size(173, 35);
            this.btnAnnadirTutorial.TabIndex = 5;
            this.btnAnnadirTutorial.Text = "Añadir";
            this.btnAnnadirTutorial.UseVisualStyleBackColor = false;
            this.btnAnnadirTutorial.Click += new System.EventHandler(this.btnAnnadirTutorial_Click);
            // 
            // btnModificarTutorial
            // 
            this.btnModificarTutorial.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificarTutorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarTutorial.Location = new System.Drawing.Point(87, 72);
            this.btnModificarTutorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarTutorial.Name = "btnModificarTutorial";
            this.btnModificarTutorial.Size = new System.Drawing.Size(173, 35);
            this.btnModificarTutorial.TabIndex = 6;
            this.btnModificarTutorial.Text = "Modificar";
            this.btnModificarTutorial.UseVisualStyleBackColor = false;
            this.btnModificarTutorial.Click += new System.EventHandler(this.btnModificarTutorial_Click);
            // 
            // btnEliminarTutorial
            // 
            this.btnEliminarTutorial.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarTutorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarTutorial.Location = new System.Drawing.Point(87, 117);
            this.btnEliminarTutorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarTutorial.Name = "btnEliminarTutorial";
            this.btnEliminarTutorial.Size = new System.Drawing.Size(173, 35);
            this.btnEliminarTutorial.TabIndex = 7;
            this.btnEliminarTutorial.Text = "Eliminar";
            this.btnEliminarTutorial.UseVisualStyleBackColor = false;
            this.btnEliminarTutorial.Click += new System.EventHandler(this.btnEliminarTutorial_Click);
            // 
            // mnuInicio
            // 
            this.mnuInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAcciones,
            this.mnuAyuda});
            this.mnuInicio.Location = new System.Drawing.Point(0, 0);
            this.mnuInicio.Name = "mnuInicio";
            this.mnuInicio.Size = new System.Drawing.Size(779, 24);
            this.mnuInicio.TabIndex = 14;
            this.mnuInicio.Text = "menuStrip1";
            // 
            // mnuAcciones
            // 
            this.mnuAcciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAcciones_AnnadirTutorial,
            this.mnuAcciones_ModificarTutorial,
            this.mnuAcciones_EliminarTutorial,
            this.mnuAcciones_DetallesTutorial,
            this.toolStripSeparator1,
            this.mnuAcciones_Recargar,
            this.mnuAcciones_AccionesTemas,
            this.toolStripSeparator2,
            this.mnuAcciones_SalirVentanaPrincipal});
            this.mnuAcciones.Name = "mnuAcciones";
            this.mnuAcciones.Size = new System.Drawing.Size(67, 20);
            this.mnuAcciones.Text = "&Acciones";
            // 
            // mnuAcciones_AnnadirTutorial
            // 
            this.mnuAcciones_AnnadirTutorial.Name = "mnuAcciones_AnnadirTutorial";
            this.mnuAcciones_AnnadirTutorial.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuAcciones_AnnadirTutorial.Size = new System.Drawing.Size(198, 22);
            this.mnuAcciones_AnnadirTutorial.Text = "Añadir";
            this.mnuAcciones_AnnadirTutorial.Click += new System.EventHandler(this.mnuAcciones_AnnadirTutorial_Click);
            // 
            // mnuAcciones_ModificarTutorial
            // 
            this.mnuAcciones_ModificarTutorial.Name = "mnuAcciones_ModificarTutorial";
            this.mnuAcciones_ModificarTutorial.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mnuAcciones_ModificarTutorial.Size = new System.Drawing.Size(198, 22);
            this.mnuAcciones_ModificarTutorial.Text = "Modificar";
            this.mnuAcciones_ModificarTutorial.Click += new System.EventHandler(this.mnuAcciones_ModificarTutorial_Click);
            // 
            // mnuAcciones_EliminarTutorial
            // 
            this.mnuAcciones_EliminarTutorial.Name = "mnuAcciones_EliminarTutorial";
            this.mnuAcciones_EliminarTutorial.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuAcciones_EliminarTutorial.Size = new System.Drawing.Size(198, 22);
            this.mnuAcciones_EliminarTutorial.Text = "Eliminar";
            this.mnuAcciones_EliminarTutorial.Click += new System.EventHandler(this.mnuAcciones_EliminarTutorial_Click);
            // 
            // mnuAcciones_DetallesTutorial
            // 
            this.mnuAcciones_DetallesTutorial.Name = "mnuAcciones_DetallesTutorial";
            this.mnuAcciones_DetallesTutorial.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuAcciones_DetallesTutorial.Size = new System.Drawing.Size(198, 22);
            this.mnuAcciones_DetallesTutorial.Text = "Detalles";
            this.mnuAcciones_DetallesTutorial.Click += new System.EventHandler(this.mnuAcciones_DetallesTutorial_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(195, 6);
            // 
            // mnuAcciones_Recargar
            // 
            this.mnuAcciones_Recargar.Name = "mnuAcciones_Recargar";
            this.mnuAcciones_Recargar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuAcciones_Recargar.Size = new System.Drawing.Size(198, 22);
            this.mnuAcciones_Recargar.Text = "Recargar";
            this.mnuAcciones_Recargar.Click += new System.EventHandler(this.mnuAcciones_Recargar_Click);
            // 
            // mnuAcciones_AccionesTemas
            // 
            this.mnuAcciones_AccionesTemas.Name = "mnuAcciones_AccionesTemas";
            this.mnuAcciones_AccionesTemas.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.mnuAcciones_AccionesTemas.Size = new System.Drawing.Size(198, 22);
            this.mnuAcciones_AccionesTemas.Text = "Acciones Temas";
            this.mnuAcciones_AccionesTemas.Click += new System.EventHandler(this.mnuAcciones_AccionesTemas_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(195, 6);
            // 
            // mnuAcciones_SalirVentanaPrincipal
            // 
            this.mnuAcciones_SalirVentanaPrincipal.Name = "mnuAcciones_SalirVentanaPrincipal";
            this.mnuAcciones_SalirVentanaPrincipal.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuAcciones_SalirVentanaPrincipal.Size = new System.Drawing.Size(198, 22);
            this.mnuAcciones_SalirVentanaPrincipal.Text = "Salir";
            this.mnuAcciones_SalirVentanaPrincipal.Click += new System.EventHandler(this.mnuSalir_Click);
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
            this.mnuAyuda_AcercaDe.Name = "mnuAyuda_AcercaDe";
            this.mnuAyuda_AcercaDe.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.mnuAyuda_AcercaDe.Size = new System.Drawing.Size(163, 22);
            this.mnuAyuda_AcercaDe.Text = "Acerca de";
            this.mnuAyuda_AcercaDe.Click += new System.EventHandler(this.mnuAyuda_Info_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvTutoriales
            // 
            this.dgvTutoriales.AllowUserToAddRows = false;
            this.dgvTutoriales.AllowUserToDeleteRows = false;
            this.dgvTutoriales.AllowUserToResizeRows = false;
            this.dgvTutoriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTutoriales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvTutoriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTutoriales.Location = new System.Drawing.Point(25, 69);
            this.dgvTutoriales.MultiSelect = false;
            this.dgvTutoriales.Name = "dgvTutoriales";
            this.dgvTutoriales.ReadOnly = true;
            this.dgvTutoriales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTutoriales.Size = new System.Drawing.Size(414, 343);
            this.dgvTutoriales.TabIndex = 1;
            // 
            // btnAccionesTemas
            // 
            this.btnAccionesTemas.BackColor = System.Drawing.SystemColors.Control;
            this.btnAccionesTemas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccionesTemas.Location = new System.Drawing.Point(573, 102);
            this.btnAccionesTemas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccionesTemas.Name = "btnAccionesTemas";
            this.btnAccionesTemas.Size = new System.Drawing.Size(180, 35);
            this.btnAccionesTemas.TabIndex = 3;
            this.btnAccionesTemas.Text = "Acciones Temas";
            this.btnAccionesTemas.UseVisualStyleBackColor = false;
            this.btnAccionesTemas.Click += new System.EventHandler(this.btnAccionesTemas_Click);
            // 
            // VentanaInicial
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(779, 438);
            this.Controls.Add(this.dgvTutoriales);
            this.Controls.Add(this.btnAccionesTemas);
            this.Controls.Add(this.gpbBotonesTutoriales);
            this.Controls.Add(this.lblTutoriales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbTema);
            this.Controls.Add(this.mnuInicio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuInicio;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VentanaInicial";
            this.Text = "Trabajo Tutoriales";
            this.Load += new System.EventHandler(this.VentanaInicial_Load);
            this.gpbBotonesTutoriales.ResumeLayout(false);
            this.mnuInicio.ResumeLayout(false);
            this.mnuInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutoriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTema;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnAnnadirTutorial;
        private System.Windows.Forms.Button btnModificarTutorial;
        private System.Windows.Forms.Button btnEliminarTutorial;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTutoriales;
        private System.Windows.Forms.GroupBox gpbBotonesTutoriales;
        private System.Windows.Forms.Button btnDetallesTutorial;
        private System.Windows.Forms.MenuStrip mnuInicio;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones_AnnadirTutorial;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones_ModificarTutorial;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones_EliminarTutorial;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones_DetallesTutorial;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda_AcercaDe;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones_SalirVentanaPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones_AccionesTemas;
        private System.Windows.Forms.Button btnAccionesTemas;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dgvTutoriales;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones_Recargar;
    }
}

