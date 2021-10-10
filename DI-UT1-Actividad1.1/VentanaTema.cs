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
using System.IO;

namespace DI_UT1_Actividad1._1
{
    public partial class VentanaTema : Form
    {
        private OleDbConnection dbConn = null;
        private OleDbCommand command = new OleDbCommand();
        private bool wasStarted;

        public VentanaTema()
        {
            InitializeComponent();
        }

        private void ventanaTema_Load(object sender, EventArgs e)
        {
            //Establecemos los iconos de la ventana
            RellenarIconos();

            //Creamos la conexion con la bd
            dbConn = new OleDbConnection();
            dbConn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;"
                                        + @"Data Source = C:\tutorialesDB\tutorialesDB.mdb";

            //Se establece los valores predeterminados del ventanaTema con los valores de Properties
            this.BackColor = Properties.Settings.Default.backgroundColor;
            this.Font = Properties.Settings.Default.defaultFont;
            this.ForeColor = Properties.Settings.Default.defaultFontColor;

            //Establecemos valores predeterminados de la ventana
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //Realizamos las consultas para cargar los datos
            Consultas();
        }

        private void PonerImagen()//Cargamos o no la imagen del tema
        {
            if (wasStarted)//Comprobaciones para evitar errores
            {
                if (!dgvTema.SelectedRows[0].Cells["imagen"].Value.ToString().Equals("")) picTema.ImageLocation = dgvTema.SelectedRows[0].Cells["imagen"].Value.ToString();
                else picTema.ImageLocation = "";
            }
        }

        private void Consultas()
        {

            try
            {
                dbConn.Open();//Abrimos conexion
                command.Connection = dbConn;
                wasStarted = false;

                //Realizamos consulta de datos tutoriales
                command.CommandText = "select ID_TEMA, NOMBRE, IMAGEN from TEMA";

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvTema.DataSource = dt;

                dbConn.Close();

                if (dgvTema.SelectedRows.Count == 0)
                {
                    DesactivarAccionesTema();
                }
                else
                {
                    //Desactivamos columnas inecesarias
                    dgvTema.Columns["ID_TEMA"].Visible = false;
                    dgvTema.Columns["IMAGEN"].Visible = false;

                    wasStarted = true;
                    PonerImagen();

                    ComprobarAcciones();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Consulta: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvTema.DataSource = new DataTable();
                dbConn.Close();
            }
        }

        private void RellenarIconos()//Ponemos los iconos de los componentes de la ventana
        {
            //Icono Ventana
            this.Icon = new Icon(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/iconoPrograma.ico");

            //Iconos botones
            btnAnnadirTema.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/annadir.png");
            btnModificarTema.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/modificar.png");
            btnEliminarTema.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/eliminar.png");

            //Iconos menu
            mnuAcciones_AnnadirTema.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/annadir.png");
            mnuAcciones_ModificarTema.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/modificar.png");
            mnuAcciones_EliminarTema.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/eliminar.png");
            mnuAcciones_RecargarTema.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/recargar.png");
            mnuAcciones_SalirVentana.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/salir.png");
            mnuAyuda_AcercaDe.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/acercaDe.png");
        }
        private void ComprobarAcciones()//Comprobamos cuantos elementos hay en la view
        {
            if (dgvTema.SelectedRows.Count == 0)
            {
                DesactivarAccionesTema();
            }
            else
            {
                ActivarAccionesTema();
            }
        }

        private void Recargar()//Recargamos la informacion de los componentes
        {

            Consultas();
        }

        private void EliminarTema()//Eliminamos temas
        {
            try
            {
                if (MessageBox.Show("¿Estas seguro que quieres eliminarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dbConn.Open();
                    OleDbCommand commamd = new OleDbCommand();
                    commamd.Connection = dbConn;
                    commamd.CommandText = "delete from tema where id_tema = " + dgvTema.SelectedRows[0].Cells["id_tema"].Value.ToString();
                    commamd.ExecuteNonQuery();

                    dbConn.Close();
                    Recargar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Eliminar Tema: " + ex);
                MessageBox.Show("Ha ocurrido un error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbConn.Close();
            }
        }

        private void ActivarAccionesTema()//Activamos botones y elementos del menu
        {
            //Desabilitamos los botones de acciones con tutorial por defecto
            btnModificarTema.Enabled = true;
            btnEliminarTema.Enabled = true;

            //Desabilitamos las acciones del menu acciones con tutorial por defecto
            mnuAcciones_ModificarTema.Enabled = true;
            mnuAcciones_EliminarTema.Enabled = true;
        }

        private void DesactivarAccionesTema()//Desactivamos botones y elementos del menu
        {
            //Desabilitamos los botones de acciones con tutorial por defecto
            btnAnnadirTema.Enabled = true;
            btnModificarTema.Enabled = false;
            btnEliminarTema.Enabled = false;

            //Desabilitamos las acciones del menu acciones con tutorial por defecto
            mnuAcciones_AnnadirTema.Enabled = true;
            mnuAcciones_ModificarTema.Enabled = false;
            mnuAcciones_EliminarTema.Enabled = false;
        }

        private DialogResult CrearVentanaAccionesTema(Tema t, Acciones a)
        {
            VentanaAccionesTema vat = new VentanaAccionesTema(t, a);//Creamos la ventana para las acciones con tutoriales
            return vat.ShowDialog();//Devolvemos el boton apretado en la ventana
        }

        private void mnuAyuda_AcercaDe_Click(object sender, EventArgs e)//Mostramos informacion sobre acerca de
        {
            MessageBox.Show("Programa Actividad 1.1 DI - 2DAM\nHecho por Mario Parrilla Maroto ©2021 ", "Acerca de Trabajo Tutoriales", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAnnadirTema_Click(object sender, EventArgs e)//Si se agrega un tema, se recarga la informacion de los componentes
        {
            if (CrearVentanaAccionesTema(null, Acciones.ANNDIR) == DialogResult.OK) Recargar();
        }

        private void mnuAcciones_AnnadirTema_Click(object sender, EventArgs e)//Si se agrega un tema, se recarga la informacion de los componentes
        {
            if(CrearVentanaAccionesTema(null, Acciones.ANNDIR) == DialogResult.OK) Recargar();
        }

        private void btnModificarTema_Click(object sender, EventArgs e)//Si se modifica un tema, se recarga la informacion de los componentes
        {
            if (CrearVentanaAccionesTema(new Tema(int.Parse(dgvTema.SelectedRows[0].Cells["id_tema"].Value.ToString()), dgvTema.SelectedRows[0].Cells["nombre"].Value.ToString(), dgvTema.SelectedRows[0].Cells["imagen"].Value.ToString()), Acciones.MODIFICAR)
                == DialogResult.OK) Recargar();
        }

        private void mnuAcciones_ModificarTema_Click(object sender, EventArgs e)//Si se modifica un tema, se recarga la informacion de los componentes
        {
            if (CrearVentanaAccionesTema(new Tema(int.Parse(dgvTema.SelectedRows[0].Cells["id_tema"].Value.ToString()), dgvTema.SelectedRows[0].Cells["nombre"].Value.ToString(), dgvTema.SelectedRows[0].Cells["imagen"].Value.ToString()), Acciones.MODIFICAR)
                == DialogResult.OK) Recargar();
        }

        private void btnEliminarTema_Click(object sender, EventArgs e)//Si se elimina un tema, se recarga la informacion de los componentes
        {
            EliminarTema();
        }

        private void mnuAcciones_EliminarTema_Click(object sender, EventArgs e)//Si se elimina un tema, se recarga la informacion de los componentes
        {
            EliminarTema();
        }

        private void dgvTema_RowEnter(object sender, DataGridViewCellEventArgs e)//Cuando seleccionamos un elemento de la view, actualizamos la imagen
        {
            PonerImagen();
        }

        private void mnuAcciones_SalirVentana_Click(object sender, EventArgs e)//Cerramos ventana
        {
            this.Close();
        }

        private void mnuAcciones_RecargarTema_Click(object sender, EventArgs e)
        {
            Recargar();
        }
    }
}
