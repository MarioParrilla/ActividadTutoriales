
namespace DI_UT1_Actividad1._1
{
    partial class VentanaVisualizar
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
            this.picImagenUrl = new System.Windows.Forms.PictureBox();
            this.wbYoutube = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenUrl)).BeginInit();
            this.SuspendLayout();
            // 
            // picImagenUrl
            // 
            this.picImagenUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImagenUrl.InitialImage = null;
            this.picImagenUrl.Location = new System.Drawing.Point(0, 0);
            this.picImagenUrl.Name = "picImagenUrl";
            this.picImagenUrl.Size = new System.Drawing.Size(575, 387);
            this.picImagenUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagenUrl.TabIndex = 0;
            this.picImagenUrl.TabStop = false;
            // 
            // wbYoutube
            // 
            this.wbYoutube.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbYoutube.Location = new System.Drawing.Point(0, 0);
            this.wbYoutube.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbYoutube.Name = "wbYoutube";
            this.wbYoutube.Size = new System.Drawing.Size(575, 387);
            this.wbYoutube.TabIndex = 1;
            // 
            // VentanaVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 387);
            this.Controls.Add(this.wbYoutube);
            this.Controls.Add(this.picImagenUrl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VentanaVisualizar";
            this.Text = "Trabajo Tutoriales - Visualizar";
            this.Load += new System.EventHandler(this.VentanaVisualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagenUrl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picImagenUrl;
        private System.Windows.Forms.WebBrowser wbYoutube;
    }
}