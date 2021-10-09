
namespace DI_UT1_Actividad1._1
{
    partial class VentanaTema
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaTema));
            this.tutorialesDBDataSet = new DI_UT1_Actividad1._1.tutorialesDBDataSet();
            this.tutorialesDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTemas = new System.Windows.Forms.Label();
            this.mnuTema = new System.Windows.Forms.MenuStrip();
            this.mnuAcciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcciones_AnnadirTema = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcciones_ModificarTema = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcciones_EliminarTema = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAcciones_RecargarTema = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAcciones_SalirVentana = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuda_AcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAnnadirTema = new System.Windows.Forms.Button();
            this.btnModificarTema = new System.Windows.Forms.Button();
            this.btnEliminarTema = new System.Windows.Forms.Button();
            this.picTema = new System.Windows.Forms.PictureBox();
            this.dgvTema = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tutorialesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorialesDBDataSetBindingSource)).BeginInit();
            this.mnuTema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTema)).BeginInit();
            this.SuspendLayout();
            // 
            // tutorialesDBDataSet
            // 
            this.tutorialesDBDataSet.DataSetName = "tutorialesDBDataSet";
            this.tutorialesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tutorialesDBDataSetBindingSource
            // 
            this.tutorialesDBDataSetBindingSource.DataSource = this.tutorialesDBDataSet;
            this.tutorialesDBDataSetBindingSource.Position = 0;
            // 
            // lblTemas
            // 
            this.lblTemas.AutoSize = true;
            this.lblTemas.Location = new System.Drawing.Point(24, 46);
            this.lblTemas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemas.Name = "lblTemas";
            this.lblTemas.Size = new System.Drawing.Size(61, 20);
            this.lblTemas.TabIndex = 13;
            this.lblTemas.Text = "Temas:";
            // 
            // mnuTema
            // 
            this.mnuTema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAcciones,
            this.mnuAyuda});
            this.mnuTema.Location = new System.Drawing.Point(0, 0);
            this.mnuTema.Name = "mnuTema";
            this.mnuTema.Size = new System.Drawing.Size(432, 24);
            this.mnuTema.TabIndex = 15;
            this.mnuTema.Text = "menuStrip1";
            // 
            // mnuAcciones
            // 
            this.mnuAcciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAcciones_AnnadirTema,
            this.mnuAcciones_ModificarTema,
            this.mnuAcciones_EliminarTema,
            this.toolStripSeparator1,
            this.mnuAcciones_RecargarTema,
            this.toolStripSeparator2,
            this.mnuAcciones_SalirVentana});
            this.mnuAcciones.Name = "mnuAcciones";
            this.mnuAcciones.Size = new System.Drawing.Size(67, 20);
            this.mnuAcciones.Text = "&Acciones";
            // 
            // mnuAcciones_AnnadirTema
            // 
            this.mnuAcciones_AnnadirTema.Image = global::DI_UT1_Actividad1._1.Properties.Resources.annadir;
            this.mnuAcciones_AnnadirTema.Name = "mnuAcciones_AnnadirTema";
            this.mnuAcciones_AnnadirTema.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuAcciones_AnnadirTema.Size = new System.Drawing.Size(180, 22);
            this.mnuAcciones_AnnadirTema.Text = "Añadir";
            this.mnuAcciones_AnnadirTema.Click += new System.EventHandler(this.mnuAcciones_AnnadirTema_Click);
            // 
            // mnuAcciones_ModificarTema
            // 
            this.mnuAcciones_ModificarTema.Image = ((System.Drawing.Image)(resources.GetObject("mnuAcciones_ModificarTema.Image")));
            this.mnuAcciones_ModificarTema.Name = "mnuAcciones_ModificarTema";
            this.mnuAcciones_ModificarTema.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mnuAcciones_ModificarTema.Size = new System.Drawing.Size(180, 22);
            this.mnuAcciones_ModificarTema.Text = "Modificar";
            this.mnuAcciones_ModificarTema.Click += new System.EventHandler(this.mnuAcciones_ModificarTema_Click);
            // 
            // mnuAcciones_EliminarTema
            // 
            this.mnuAcciones_EliminarTema.Image = global::DI_UT1_Actividad1._1.Properties.Resources.eliminar;
            this.mnuAcciones_EliminarTema.Name = "mnuAcciones_EliminarTema";
            this.mnuAcciones_EliminarTema.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuAcciones_EliminarTema.Size = new System.Drawing.Size(180, 22);
            this.mnuAcciones_EliminarTema.Text = "Eliminar";
            this.mnuAcciones_EliminarTema.Click += new System.EventHandler(this.mnuAcciones_EliminarTema_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuAcciones_RecargarTema
            // 
            this.mnuAcciones_RecargarTema.Image = global::DI_UT1_Actividad1._1.Properties.Resources.recargar;
            this.mnuAcciones_RecargarTema.Name = "mnuAcciones_RecargarTema";
            this.mnuAcciones_RecargarTema.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuAcciones_RecargarTema.Size = new System.Drawing.Size(180, 22);
            this.mnuAcciones_RecargarTema.Text = "Recargar";
            this.mnuAcciones_RecargarTema.Click += new System.EventHandler(this.mnuAcciones_RecargarTema_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuAcciones_SalirVentana
            // 
            this.mnuAcciones_SalirVentana.Image = global::DI_UT1_Actividad1._1.Properties.Resources.cerrar;
            this.mnuAcciones_SalirVentana.Name = "mnuAcciones_SalirVentana";
            this.mnuAcciones_SalirVentana.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuAcciones_SalirVentana.Size = new System.Drawing.Size(180, 22);
            this.mnuAcciones_SalirVentana.Text = "Salir";
            this.mnuAcciones_SalirVentana.Click += new System.EventHandler(this.mnuAcciones_SalirVentana_Click);
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
            // btnAnnadirTema
            // 
            this.btnAnnadirTema.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnnadirTema.Image = global::DI_UT1_Actividad1._1.Properties.Resources.annadir;
            this.btnAnnadirTema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnadirTema.Location = new System.Drawing.Point(229, 257);
            this.btnAnnadirTema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnnadirTema.Name = "btnAnnadirTema";
            this.btnAnnadirTema.Size = new System.Drawing.Size(173, 35);
            this.btnAnnadirTema.TabIndex = 2;
            this.btnAnnadirTema.Text = "Añadir";
            this.btnAnnadirTema.UseVisualStyleBackColor = false;
            this.btnAnnadirTema.Click += new System.EventHandler(this.btnAnnadirTema_Click);
            // 
            // btnModificarTema
            // 
            this.btnModificarTema.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificarTema.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarTema.Image")));
            this.btnModificarTema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarTema.Location = new System.Drawing.Point(229, 302);
            this.btnModificarTema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarTema.Name = "btnModificarTema";
            this.btnModificarTema.Size = new System.Drawing.Size(173, 35);
            this.btnModificarTema.TabIndex = 3;
            this.btnModificarTema.Text = "Modificar";
            this.btnModificarTema.UseVisualStyleBackColor = false;
            this.btnModificarTema.Click += new System.EventHandler(this.btnModificarTema_Click);
            // 
            // btnEliminarTema
            // 
            this.btnEliminarTema.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarTema.Image = global::DI_UT1_Actividad1._1.Properties.Resources.eliminar;
            this.btnEliminarTema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarTema.Location = new System.Drawing.Point(229, 347);
            this.btnEliminarTema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarTema.Name = "btnEliminarTema";
            this.btnEliminarTema.Size = new System.Drawing.Size(173, 35);
            this.btnEliminarTema.TabIndex = 4;
            this.btnEliminarTema.Text = "Eliminar";
            this.btnEliminarTema.UseVisualStyleBackColor = false;
            this.btnEliminarTema.Click += new System.EventHandler(this.btnEliminarTema_Click);
            // 
            // picTema
            // 
            this.picTema.InitialImage = null;
            this.picTema.Location = new System.Drawing.Point(229, 71);
            this.picTema.Name = "picTema";
            this.picTema.Size = new System.Drawing.Size(173, 169);
            this.picTema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTema.TabIndex = 19;
            this.picTema.TabStop = false;
            // 
            // dgvTema
            // 
            this.dgvTema.AllowUserToAddRows = false;
            this.dgvTema.AllowUserToDeleteRows = false;
            this.dgvTema.AllowUserToResizeRows = false;
            this.dgvTema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTema.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvTema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTema.Location = new System.Drawing.Point(28, 71);
            this.dgvTema.MultiSelect = false;
            this.dgvTema.Name = "dgvTema";
            this.dgvTema.ReadOnly = true;
            this.dgvTema.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTema.Size = new System.Drawing.Size(141, 343);
            this.dgvTema.TabIndex = 20;
            this.dgvTema.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTema_RowEnter);
            // 
            // VentanaTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 438);
            this.Controls.Add(this.dgvTema);
            this.Controls.Add(this.picTema);
            this.Controls.Add(this.btnAnnadirTema);
            this.Controls.Add(this.btnModificarTema);
            this.Controls.Add(this.btnEliminarTema);
            this.Controls.Add(this.mnuTema);
            this.Controls.Add(this.lblTemas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VentanaTema";
            this.Text = "Trabajo Tutoriales - Temas";
            this.Load += new System.EventHandler(this.ventanaTema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tutorialesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorialesDBDataSetBindingSource)).EndInit();
            this.mnuTema.ResumeLayout(false);
            this.mnuTema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tutorialesDBDataSetBindingSource;
        private tutorialesDBDataSet tutorialesDBDataSet;
        private System.Windows.Forms.Label lblTemas;
        private System.Windows.Forms.MenuStrip mnuTema;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones_AnnadirTema;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones_ModificarTema;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones_EliminarTema;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones_SalirVentana;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda_AcercaDe;
        private System.Windows.Forms.Button btnAnnadirTema;
        private System.Windows.Forms.Button btnModificarTema;
        private System.Windows.Forms.Button btnEliminarTema;
        private System.Windows.Forms.PictureBox picTema;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dgvTema;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones_RecargarTema;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}