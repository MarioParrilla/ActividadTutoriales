using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DI_UT1_Actividad1._1
{
    public partial class VentanaAccionesTema : Form
    {
        private Tema t = null;
        private Acciones a;
        private OleDbConnection dbConn = null;
        private OleDbDataReader dr = null;
        private OleDbCommand command = new OleDbCommand();

        public VentanaAccionesTema(Tema t, Acciones a)
        {
            InitializeComponent();
            this.a = a;
            this.t = t;
        }

        private void VentanaAccionesTema_Load(object sender, EventArgs e)
        {
            //Se establece los valores predeterminados del ventanaTema con los valores de Properties
            this.BackColor = Properties.Settings.Default.backgroundColor;
            this.Font = Properties.Settings.Default.defaultFont;
            this.ForeColor = Properties.Settings.Default.defaultFontColor;

            //Establecemos valores predeterminados de la ventana
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //Creamos la conexion con la bd
            dbConn = new OleDbConnection();
            dbConn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;"
                                        + @"Data Source = C:\tutorialesDB\tutorialesDB.mdb";

            //Establecemos nombre de la ventana segun la accion
            if (a == Acciones.ANNDIR)
            {
                this.Text = "Trabajo Tutoriales - Añadir";
                btnAccionTema.Text = "Añadir";
                mnuAcciones_AccionTema.Text = "Añadir";
                mnuAcciones_AccionTema.Image = Image.FromFile(@"C:\Users\Mario\Desktop\2DAM\DI\unidad1\Actividad1.1\DI-UT1-Actividad1.1\DI-UT1-Actividad1.1\Resources\icons\annadir.png");
            }
            else if (a == Acciones.MODIFICAR)
            {
                this.Text = "Trabajo Tutoriales - Modificar";
                btnAccionTema.Text = "Modificar";
                mnuAcciones_AccionTema.Text = "Modificar";
                mnuAcciones_AccionTema.Image = Image.FromFile(@"C:\Users\Mario\Desktop\2DAM\DI\unidad1\Actividad1.1\DI-UT1-Actividad1.1\DI-UT1-Actividad1.1\Resources\icons\modificar.png");
                RellenarCampos();
            }
        }

        private void Visualizar(Acciones a, String url)
        {
            VentanaVisualizar vv = new VentanaVisualizar(a, url);
            vv.Show();
        }

        private void Annadir()
        {
            try
            {
                dbConn.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = dbConn;

                command.CommandText = "insert into tema(NOMBRE, IMAGEN) values('" + txtNombre.Text + "', '" + txtImagen.Text + "')";
                command.ExecuteNonQuery();
                dbConn.Close();

                //Si todo ha funcionado bien le dicemos que devuelva la respuesta de boton de OK
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                MessageBox.Show("Ha ocurrido un error: ¡Introduce todos los valores! "+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbConn.Close();
            }

        }

        private void Modificar()
        {
            try
            {
                dbConn.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = dbConn;

                command.CommandText = "update tema set nombre = '" + txtNombre.Text + "', imagen = '"
                    + txtImagen.Text + "' where id_tema = " + t.Id_tema;
                command.ExecuteNonQuery();
                dbConn.Close();

                //Si todo ha funcionado bien le dicemos que devuelva la respuesta de boton de OK
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                MessageBox.Show("Ha ocurrido un error: ¡Introduce todos los valores!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbConn.Close();
            }
        }

        private void RellenarCampos()
        {
            txtNombre.Text = t.Nombre;
            txtImagen.Text = t.Imagen;
        }

        private void mnuAyuda_AcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa Actividad 1.1 DI - 2DAM\nHecho por Mario Parrilla Maroto ©2021 ", "Acerca de Trabajo Tutoriales", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuAcciones_SalirTema_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccionTema_Click(object sender, EventArgs e)
        {
            if (a == Acciones.ANNDIR) Annadir();
            else if (a == Acciones.MODIFICAR) Modificar();
            else this.Close();
        }

        private void mnuAcciones_AccionTema_Click(object sender, EventArgs e)
        {
            if (a == Acciones.ANNDIR) Annadir();
            else if (a == Acciones.MODIFICAR) Modificar();
            else this.Close();
        }

        private void btnVisualizarImagenTema_Click(object sender, EventArgs e)
        {
            Visualizar(Acciones.IMAGEN, txtImagen.Text);
        }
    }
}
