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
        VentanaInicial vi = null;
        public VentanaCarga()
        {
            InitializeComponent();
            vi = new VentanaInicial();
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

        private void timerCarga_Tick(object sender, EventArgs e)//Funcionalidad
        {
            pbCarga.Increment(1);
            lblProgreso.Text = pbCarga.Value.ToString()+"%";

            //Segun el porcentaje se actualizará el lblInfo
            if (pbCarga.Value == 30) lblInfo.Text = "Cargando Recursos...";
            else if (pbCarga.Value == 50) lblInfo.Text = "Cargando Datos...";
            else if (pbCarga.Value == 70) lblInfo.Text = "Cargando Temas...";
            else if (pbCarga.Value == 85) lblInfo.Text = "Cargando Tutoriales...";
            else if (pbCarga.Value == 95) lblInfo.Text = "Iniciando...";

            if (pbCarga.Value == pbCarga.Maximum)//En cuanto llegue al maximo, paramos el timer, ocultamos esta ventana y iniciamos la ventana inicial
            {
                timerCarga.Stop();
                this.Hide();
                if (vi.ShowDialog() == DialogResult.Cancel) this.Close();//Cuando se cierre la ventana inicial, cerraremos esta que esta oculta
            }
        }
    }
}
