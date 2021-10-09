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
    public partial class VentanaTema : Form
    {
        public VentanaTema()
        {
            InitializeComponent();
        }

        private void ventanaTema_Load(object sender, EventArgs e)
        {
            //Se establece los valores predeterminados del ventanaTema con los valores de Properties
            this.BackColor = Properties.Settings.Default.backgroundColor;
            this.Font = Properties.Settings.Default.defaultFont;
            this.ForeColor = Properties.Settings.Default.defaultFontColor;

            //Desabilitamos los botones de acciones con tema por defecto
            btnAnnadirTema.Enabled = false;
            btnModificarTema.Enabled = false;
            btnEliminarTema.Enabled = false;

            //Establecemos valores predeterminados de la ventana
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //Desabilitamos las acciones del menu acciones con tema por defecto
            mnuAcciones_AnnadirTutorial.Enabled = false;
            mnuAcciones_ModificarTutorial.Enabled = false;
            mnuAcciones_EliminarTutorial.Enabled = false;
        }

        private void mnuAcciones_SalirVentanaPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuAyuda_AcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa Actividad 1.1 DI - 2DAM\nHecho por Mario Parrilla Maroto ©2021 ", "Acerca de Trabajo Tutoriales", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuAcciones_AnnadirTutorial_Click(object sender, EventArgs e)
        {

        }
    }
}
