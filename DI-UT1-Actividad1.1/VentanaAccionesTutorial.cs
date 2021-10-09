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
    public partial class VentanaAccionesTutorial : Form
    {
        private Tutorial t = null;
        private Acciones accion;
        private OleDbConnection dbConn = null;
        private OleDbDataReader dr = null;
        private OleDbCommand command = new OleDbCommand();
        public VentanaAccionesTutorial(Tutorial t, Acciones accion)
        {
            InitializeComponent();
            this.t = t;
            this.accion = accion;
        }

        private void VentanaAccionesTutorial_Load(object sender, EventArgs e)
        {
            //Se establece los valores predeterminados del ventanaTema con los valores de Properties
            this.BackColor = Properties.Settings.Default.backgroundColor;
            this.Font = Properties.Settings.Default.defaultFont;
            this.ForeColor = Properties.Settings.Default.defaultFontColor;

            //Establecemos valores predeterminados de la ventana
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dateFecha.CustomFormat = "dd/MM/yyyy";

            //Creamos la conexion con la bd
            dbConn = new OleDbConnection();
            dbConn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;"
                                        + @"Data Source = C:\tutorialesDB\tutorialesDB.mdb";

            RellenarTemas();

            //Establecemos nombre de la ventana segun la accion
            if (accion == Acciones.ANNDIR)
            {
                this.Text = "Trabajo Tutoriales - Añadir";
                btnAccion.Text = "Añadir";
                mnuAcciones_Accion.Text = "Añadir";
                mnuAcciones_Accion.Image = Image.FromFile(@"C:\Users\Mario\Desktop\2DAM\DI\unidad1\Actividad1.1\DI-UT1-Actividad1.1\DI-UT1-Actividad1.1\Resources\icons\annadir.png");
            }
            else if(accion == Acciones.MODIFICAR)
            {
                this.Text = "Trabajo Tutoriales - Modificar";
                btnAccion.Text = "Modificar";
                mnuAcciones_Accion.Text = "Modificar";
                mnuAcciones_Accion.Image = Image.FromFile(@"C:\Users\Mario\Desktop\2DAM\DI\unidad1\Actividad1.1\DI-UT1-Actividad1.1\DI-UT1-Actividad1.1\Resources\icons\modificar.png");
                RellenarCampos();
                
            }
            else
            {
                this.Text = "Trabajo Tutoriales - Detalles";
                btnAccion.Text = "Volver";
                mnuAcciones_Accion.Text = "Volver";
                mnuAcciones_Accion.Image = Image.FromFile(@"C:\Users\Mario\Desktop\2DAM\DI\unidad1\Actividad1.1\DI-UT1-Actividad1.1\DI-UT1-Actividad1.1\Resources\icons\volver.png");
                RellenarCampos();
                Deshabilitar();
            }

            //Creamos toolTip para titulo y categoria
            ToolTip tltEspacios = new ToolTip();
            tltEspacios.ToolTipIcon = ToolTipIcon.Warning;
            tltEspacios.ToolTipTitle = "¡Cuidado!";
            tltEspacios.Active = true;
            tltEspacios.ShowAlways = true;
            tltEspacios.IsBalloon = true;
            tltEspacios.SetToolTip(txtTitulo,"No uses espacios en blanco ni al principio ni al final o se borrará el texto");
            tltEspacios.SetToolTip(txtCategoria,"No uses espacios en blanco ni al principio ni al final o se borrará el texto");

            //Asignamos la tecla para  mnuAcciones_Accion
            mnuAcciones_Accion.ShortcutKeys = Keys.Control | Keys.D;
        }

        private void Deshabilitar()
        {
            txtTitulo.Enabled = false;
            cmbTema.Enabled = false;
            txtCategoria.Enabled = false;
            dateFecha.Enabled = false;
            txtDescripcion.Enabled = false;
            txtImagen.Enabled = false;
            txtVideo.Enabled = false;
        }

       private void RellenarCampos()
        {
            txtTitulo.Text = t.Titulo;
            for(int i = 0; i < cmbTema.Items.Count; i++) if (((Tema)cmbTema.Items[i]).Id_tema == t.Id_tema) cmbTema.SelectedIndex = i;//Ponemos el tema del objeto
            txtCategoria.Text = t.Categoria;
            dateFecha.Value = DateTime.Parse(t.Fecha);
            txtDescripcion.Text = t.Descripcion;
            txtImagen.Text = t.Imagen;
            txtVideo.Text = t.Video;
        }

        private void RellenarTemas()
        {
            try
            {
                dbConn.Open();//Abrimos conexion
                command.Connection = dbConn;

                //Realizamos consulta de los nombre de temas
                command.CommandText = "select id_tema,nombre from tema";
                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    cmbTema.Items.Add(new Tema(int.Parse(dr["id_tema"].ToString()), dr["nombre"].ToString(),""));
                }

                dr.Close();
                dbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbConn.Close();
            }
        }

        private void RellenarDatosDefault()
        {
            if (txtTitulo.Text.Length > 1 && txtTitulo.Text.StartsWith(" ") && txtTitulo.Text.EndsWith(" ")) txtTitulo.Text = "Sin Titulo";
            else if (txtTitulo.Text.Length < 1) txtTitulo.Text = "Sin Titulo";

            if (txtCategoria.Text.Length > 1 && txtCategoria.Text.StartsWith(" ") && txtCategoria.Text.EndsWith(" ")) txtCategoria.Text = "Sin Categoria";
            else if (txtCategoria.Text.Length < 1) txtCategoria.Text = "Sin Categoria";
        }

        private void Visualizar(Acciones a, String url)
        {
            VentanaVisualizar vv = new VentanaVisualizar(a,url);
            vv.ShowDialog();
        }

        private void Annadir()
        {
            int id_Tema = 0;
            try
            {
                dbConn.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = dbConn;
                command.CommandText = "select id_tema from tema where nombre = '" + cmbTema.Items[cmbTema.SelectedIndex] + "'";
                dr = command.ExecuteReader();

                RellenarDatosDefault();

                while (dr.Read())
                {
                    id_Tema = int.Parse(dr["ID_TEMA"].ToString());
                }

                dr.Close();
                dbConn.Close();

                dbConn.Open();

                command.CommandText = "insert into tutorial(ID_TEMA, TITULO, CATEGORIA, FECHA, DESCRIPCION, IMAGEN, VIDEO) values("+id_Tema+", '" + txtTitulo.Text + "', '" + txtCategoria.Text + "', '" + dateFecha.Value.ToString().Substring(0, 11) + "', '" + txtDescripcion.Text + "', '" + txtImagen.Text + "', '" + txtVideo.Text + "')";
                command.ExecuteNonQuery();
                dbConn.Close();

                //Si todo ha funcionado bien le dicemos que devuelva la respuesta de boton de OK
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: "+ex);
                MessageBox.Show("Ha ocurrido un error: ¡Introduce todos los valores!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbConn.Close();
            }

        }

        private void Modificar()
        {

        }

        private void mnuAyuda_AcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa Actividad 1.1 DI - 2DAM\nHecho por Mario Parrilla Maroto ©2021 ", "Acerca de Trabajo Tutoriales", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuAcciones_SalirVentanaPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (accion == Acciones.ANNDIR) Annadir();
            else if (accion == Acciones.MODIFICAR) Modificar();
            else this.Close();
        }

        private void mnuAcciones_Accion_Click(object sender, EventArgs e)
        {
            if (accion == Acciones.ANNDIR) Annadir();
            else if (accion == Acciones.MODIFICAR) Modificar();
            else this.Close();
        }

        private void btnVisualizarImagen_Click(object sender, EventArgs e)
        {
            Visualizar(Acciones.IMAGEN,txtImagen.Text);
        }

        private void btnVisualizarVideo_Click(object sender, EventArgs e)
        {
            Visualizar(Acciones.VIDEO, txtVideo.Text);
        }
    }
}
