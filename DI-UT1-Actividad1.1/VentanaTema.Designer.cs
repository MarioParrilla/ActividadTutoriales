
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mnuTema = new System.Windows.Forms.MenuStrip();
            this.mnuAcciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcciones_AnnadirTutorial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcciones_ModificarTutorial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcciones_EliminarTutorial = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAcciones_SalirVentanaPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuda_AcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAnnadirTema = new System.Windows.Forms.Button();
            this.btnModificarTema = new System.Windows.Forms.Button();
            this.btnEliminarTema = new System.Windows.Forms.Button();
            this.picTema = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tutorialesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorialesDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.mnuTema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTema)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.tutorialesDBDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 346);
            this.dataGridView1.TabIndex = 1;
            // 
            // mnuTema
            // 
            this.mnuTema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAcciones,
            this.mnuAyuda});
            this.mnuTema.Location = new System.Drawing.Point(0, 0);
            this.mnuTema.Name = "mnuTema";
            this.mnuTema.Size = new System.Drawing.Size(779, 24);
            this.mnuTema.TabIndex = 15;
            this.mnuTema.Text = "menuStrip1";
            // 
            // mnuAcciones
            // 
            this.mnuAcciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAcciones_AnnadirTutorial,
            this.mnuAcciones_ModificarTutorial,
            this.mnuAcciones_EliminarTutorial,
            this.toolStripSeparator1,
            this.mnuAcciones_SalirVentanaPrincipal});
            this.mnuAcciones.Name = "mnuAcciones";
            this.mnuAcciones.Size = new System.Drawing.Size(67, 20);
            this.mnuAcciones.Text = "&Acciones";
            // 
            // mnuAcciones_AnnadirTutorial
            // 
            this.mnuAcciones_AnnadirTutorial.Image = global::DI_UT1_Actividad1._1.Properties.Resources.annadir;
            this.mnuAcciones_AnnadirTutorial.Name = "mnuAcciones_AnnadirTutorial";
            this.mnuAcciones_AnnadirTutorial.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuAcciones_AnnadirTutorial.Size = new System.Drawing.Size(180, 22);
            this.mnuAcciones_AnnadirTutorial.Text = "Añadir";
            this.mnuAcciones_AnnadirTutorial.Click += new System.EventHandler(this.mnuAcciones_AnnadirTutorial_Click);
            // 
            // mnuAcciones_ModificarTutorial
            // 
            this.mnuAcciones_ModificarTutorial.Image = ((System.Drawing.Image)(resources.GetObject("mnuAcciones_ModificarTutorial.Image")));
            this.mnuAcciones_ModificarTutorial.Name = "mnuAcciones_ModificarTutorial";
            this.mnuAcciones_ModificarTutorial.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mnuAcciones_ModificarTutorial.Size = new System.Drawing.Size(180, 22);
            this.mnuAcciones_ModificarTutorial.Text = "Modificar";
            // 
            // mnuAcciones_EliminarTutorial
            // 
            this.mnuAcciones_EliminarTutorial.Image = global::DI_UT1_Actividad1._1.Properties.Resources.eliminar;
            this.mnuAcciones_EliminarTutorial.Name = "mnuAcciones_EliminarTutorial";
            this.mnuAcciones_EliminarTutorial.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuAcciones_EliminarTutorial.Size = new System.Drawing.Size(180, 22);
            this.mnuAcciones_EliminarTutorial.Text = "Eliminar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuAcciones_SalirVentanaPrincipal
            // 
            this.mnuAcciones_SalirVentanaPrincipal.Image = global::DI_UT1_Actividad1._1.Properties.Resources.cerrar;
            this.mnuAcciones_SalirVentanaPrincipal.Name = "mnuAcciones_SalirVentanaPrincipal";
            this.mnuAcciones_SalirVentanaPrincipal.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuAcciones_SalirVentanaPrincipal.Size = new System.Drawing.Size(180, 22);
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
            // btnAnnadirTema
            // 
            this.btnAnnadirTema.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnnadirTema.Image = global::DI_UT1_Actividad1._1.Properties.Resources.annadir;
            this.btnAnnadirTema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnadirTema.Location = new System.Drawing.Point(534, 280);
            this.btnAnnadirTema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnnadirTema.Name = "btnAnnadirTema";
            this.btnAnnadirTema.Size = new System.Drawing.Size(173, 35);
            this.btnAnnadirTema.TabIndex = 2;
            this.btnAnnadirTema.Text = "Añadir";
            this.btnAnnadirTema.UseVisualStyleBackColor = false;
            // 
            // btnModificarTema
            // 
            this.btnModificarTema.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificarTema.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarTema.Image")));
            this.btnModificarTema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarTema.Location = new System.Drawing.Point(534, 325);
            this.btnModificarTema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarTema.Name = "btnModificarTema";
            this.btnModificarTema.Size = new System.Drawing.Size(173, 35);
            this.btnModificarTema.TabIndex = 3;
            this.btnModificarTema.Text = "Modificar";
            this.btnModificarTema.UseVisualStyleBackColor = false;
            // 
            // btnEliminarTema
            // 
            this.btnEliminarTema.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarTema.Image = global::DI_UT1_Actividad1._1.Properties.Resources.eliminar;
            this.btnEliminarTema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarTema.Location = new System.Drawing.Point(534, 370);
            this.btnEliminarTema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarTema.Name = "btnEliminarTema";
            this.btnEliminarTema.Size = new System.Drawing.Size(173, 35);
            this.btnEliminarTema.TabIndex = 4;
            this.btnEliminarTema.Text = "Eliminar";
            this.btnEliminarTema.UseVisualStyleBackColor = false;
            // 
            // picTema
            // 
            this.picTema.Location = new System.Drawing.Point(534, 71);
            this.picTema.Name = "picTema";
            this.picTema.Size = new System.Drawing.Size(173, 169);
            this.picTema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTema.TabIndex = 19;
            this.picTema.TabStop = false;
            // 
            // VentanaTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 438);
            this.Controls.Add(this.picTema);
            this.Controls.Add(this.btnAnnadirTema);
            this.Controls.Add(this.btnModificarTema);
            this.Controls.Add(this.btnEliminarTema);
            this.Controls.Add(this.mnuTema);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.mnuTema.ResumeLayout(false);
            this.mnuTema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tutorialesDBDataSetBindingSource;
        private tutorialesDBDataSet tutorialesDBDataSet;
        private System.Windows.Forms.Label lblTemas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip mnuTema;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones_AnnadirTutorial;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones_ModificarTutorial;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones_EliminarTutorial;
        private System.Windows.Forms.ToolStripMenuItem mnuAcciones_SalirVentanaPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda_AcercaDe;
        private System.Windows.Forms.Button btnAnnadirTema;
        private System.Windows.Forms.Button btnModificarTema;
        private System.Windows.Forms.Button btnEliminarTema;
        private System.Windows.Forms.PictureBox picTema;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}