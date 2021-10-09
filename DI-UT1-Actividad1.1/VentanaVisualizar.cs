using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_UT1_Actividad1._1
{
    public partial class VentanaVisualizar : Form
    {
        Acciones a;
        String url;
        public VentanaVisualizar(Acciones a, String url)
        {
            InitializeComponent();
            this.a = a;
            this.url = url;
        }

        private void VentanaVisualizar_Load(object sender, EventArgs e)
        {
            //Se establece los valores predeterminados del ventanaTema con los valores de Properties
            this.BackColor = Properties.Settings.Default.backgroundColor;
            this.Font = Properties.Settings.Default.defaultFont;
            this.ForeColor = Properties.Settings.Default.defaultFontColor;

            //Establecemos valores predeterminados de la ventana
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            picImagenUrl.Visible = false;
            wbYoutube.Visible = false;

            if (a == Acciones.IMAGEN)
            {
                picImagenUrl.ImageLocation = url;
                picImagenUrl.Visible = true;
            }else if (a == Acciones.VIDEO)
            {
                String codigoYoutbe = url.Substring(url.IndexOf("=")+1, (url.IndexOf("&") - url.IndexOf("="))-1); //https://www.youtube.com/watch?v=vbs6_xcrT5s&ab_channel=YUCAAN
                Console.WriteLine(codigoYoutbe);
                wbYoutube.DocumentText = "<html><head>" +
                    "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                    "</head><body>" +
                    "<iframe width=\"100%\" height=\"100%\"" +
                    " src=\"https://www.youtube.com/embed/" + codigoYoutbe + "?autoplay=1" +
                    " frameborder=\"0\" allow=\"accelerometer; autoplay; " +
                    "encrypted-media; gyroscope; picture-in-picture\" " +
                    "allowfullscreen></iframe>" +
                    "</body></html>";
                wbYoutube.Visible = true;
            }
        }

        private void mnuAyuda_AcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa Actividad 1.1 DI - 2DAM\nHecho por Mario Parrilla Maroto ©2021 ", "Acerca de Trabajo Tutoriales", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
