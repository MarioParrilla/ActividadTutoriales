using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_UT1_Actividad1._1
{
    public partial class VentanaCarga : Form
    {
        public VentanaCarga()
        {
            InitializeComponent();
        }

        private void VentanaCarga_Load(object sender, EventArgs e)
        {
            //Se establece los valores predeterminados del VentanaInicial con los valores de Properties
            this.BackColor = Properties.Settings.Default.backgroundColor;
            this.Font = Properties.Settings.Default.defaultFont;
            this.ForeColor = Properties.Settings.Default.defaultFontColor;

            //Establecemos valores predeterminados de la ventana
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.Icon = new Icon(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/iconoPrograma.ico");
        }
    }
}
