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

            //Creamos la conexion con la bd
            dbConn = new OleDbConnection();
            dbConn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;"
                                        + @"Data Source = C:\tutorialesDB\tutorialesDB.mdb";

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
            mnuAcciones_AnnadirTema.Enabled = false;
            mnuAcciones_ModificarTema.Enabled = false;
            mnuAcciones_EliminarTema.Enabled = false;

            //Realizamos las consultas para cargar los datos
            Consultas();
        }

        private void PonerImagen()
        {
            if (wasStarted)
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
                    ActivarAccionesTema();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Consulta: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvTema.DataSource = new DataTable();
                dbConn.Close();
            }
        }

        private void Recargar()
        {

            Consultas();
        }

        private void EliminarTema()
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

        private void ActivarAccionesTema()
        {
            //Desabilitamos los botones de acciones con tutorial por defecto
            btnAnnadirTema.Enabled = true;
            btnModificarTema.Enabled = true;
            btnEliminarTema.Enabled = true;

            //Desabilitamos las acciones del menu acciones con tutorial por defecto
            mnuAcciones_AnnadirTema.Enabled = true;
            mnuAcciones_ModificarTema.Enabled = true;
            mnuAcciones_EliminarTema.Enabled = true;
        }

        private void DesactivarAccionesTema()
        {
            //Desabilitamos los botones de acciones con tutorial por defecto
            btnAnnadirTema.Enabled = false;
            btnModificarTema.Enabled = false;
            btnEliminarTema.Enabled = true;

            //Desabilitamos las acciones del menu acciones con tutorial por defecto
            mnuAcciones_AnnadirTema.Enabled = false;
            mnuAcciones_ModificarTema.Enabled = false;
            mnuAcciones_EliminarTema.Enabled = false;
        }

        private DialogResult CrearVentanaAccionesTema(Tema t, Acciones a)
        {
            VentanaAccionesTema vat = new VentanaAccionesTema(t, a);//Creamos la ventana para las acciones con tutoriales
            return vat.ShowDialog();//Devolvemos el boton apretado en la ventana
        }

        private void mnuAyuda_AcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa Actividad 1.1 DI - 2DAM\nHecho por Mario Parrilla Maroto ©2021 ", "Acerca de Trabajo Tutoriales", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAnnadirTema_Click(object sender, EventArgs e)
        {
            if(CrearVentanaAccionesTema(new Tema(int.Parse(dgvTema.SelectedRows[0].Cells["id_tema"].Value.ToString()), dgvTema.SelectedRows[0].Cells["nombre"].Value.ToString(), dgvTema.SelectedRows[0].Cells["imagen"].Value.ToString()), Acciones.ANNDIR)
            == DialogResult.OK) Recargar();
        }

        private void mnuAcciones_AnnadirTema_Click(object sender, EventArgs e)
        {
            if(CrearVentanaAccionesTema(new Tema(int.Parse(dgvTema.SelectedRows[0].Cells["id_tema"].Value.ToString()), dgvTema.SelectedRows[0].Cells["nombre"].Value.ToString(), dgvTema.SelectedRows[0].Cells["imagen"].Value.ToString()), Acciones.ANNDIR)
            == DialogResult.OK) Recargar();
        }

        private void btnModificarTema_Click(object sender, EventArgs e)
        {
            if (CrearVentanaAccionesTema(new Tema(int.Parse(dgvTema.SelectedRows[0].Cells["id_tema"].Value.ToString()), dgvTema.SelectedRows[0].Cells["nombre"].Value.ToString(), dgvTema.SelectedRows[0].Cells["imagen"].Value.ToString()), Acciones.MODIFICAR)
                == DialogResult.OK) Recargar();
        }

        private void mnuAcciones_ModificarTema_Click(object sender, EventArgs e)
        {
            if (CrearVentanaAccionesTema(new Tema(int.Parse(dgvTema.SelectedRows[0].Cells["id_tema"].Value.ToString()), dgvTema.SelectedRows[0].Cells["nombre"].Value.ToString(), dgvTema.SelectedRows[0].Cells["imagen"].Value.ToString()), Acciones.MODIFICAR)
                == DialogResult.OK) Recargar();
        }

        private void btnEliminarTema_Click(object sender, EventArgs e)
        {
            EliminarTema();
        }

        private void mnuAcciones_EliminarTema_Click(object sender, EventArgs e)
        {
            EliminarTema();
        }

        private void dgvTema_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            PonerImagen();
        }

        private void mnuAcciones_SalirVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuAcciones_RecargarTema_Click(object sender, EventArgs e)
        {
            Recargar();
        }
    }
}
