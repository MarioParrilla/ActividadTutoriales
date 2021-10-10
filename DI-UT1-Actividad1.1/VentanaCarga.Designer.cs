
namespace DI_UT1_Actividad1._1
{
    partial class VentanaCarga
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
            this.timerCarga = new System.Windows.Forms.Timer(this.components);
            this.pbCarga = new System.Windows.Forms.ProgressBar();
            this.lblNombreActividad = new System.Windows.Forms.Label();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerCarga
            // 
            this.timerCarga.Enabled = true;
            this.timerCarga.Tick += new System.EventHandler(this.timerCarga_Tick);
            // 
            // pbCarga
            // 
            this.pbCarga.Location = new System.Drawing.Point(40, 90);
            this.pbCarga.Maximum = 101;
            this.pbCarga.Name = "pbCarga";
            this.pbCarga.Size = new System.Drawing.Size(252, 27);
            this.pbCarga.TabIndex = 0;
            // 
            // lblNombreActividad
            // 
            this.lblNombreActividad.AutoSize = true;
            this.lblNombreActividad.Location = new System.Drawing.Point(36, 42);
            this.lblNombreActividad.Name = "lblNombreActividad";
            this.lblNombreActividad.Size = new System.Drawing.Size(256, 20);
            this.lblNombreActividad.TabIndex = 1;
            this.lblNombreActividad.Text = "Actividad 1.1 - Mario Parrilla Maroto";
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.Location = new System.Drawing.Point(257, 120);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(32, 20);
            this.lblProgreso.TabIndex = 2;
            this.lblProgreso.Text = "0%";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(45, 120);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(158, 20);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Iniciando Programa...";
            // 
            // VentanaCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 167);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblProgreso);
            this.Controls.Add(this.lblNombreActividad);
            this.Controls.Add(this.pbCarga);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VentanaCarga";
            this.Text = "Trabajo Tutoriales - Cargando";
            this.Load += new System.EventHandler(this.VentanaCarga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerCarga;
        private System.Windows.Forms.ProgressBar pbCarga;
        private System.Windows.Forms.Label lblNombreActividad;
        private System.Windows.Forms.Label lblProgreso;
        private System.Windows.Forms.Label lblInfo;
    }
}