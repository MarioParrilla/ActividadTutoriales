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
    public partial class VentanaInicial : Form
    {
        private VentanaTema vt = null;
        private OleDbConnection dbConn = null;
        private OleDbDataReader dr = null;
        private OleDbCommand command = new OleDbCommand();
        private bool runFilterTODOS = false;//Con esta variable podremos controlar un error de open al iniciar el programa con los eventos del combobox

        String tema, categoria;
        public VentanaInicial()
        {
            InitializeComponent();
        }

        private void VentanaInicial_Load(object sender, EventArgs e)
        {
            //Establecemos los iconos de la ventana
            RellenarIconos();

            //Realizamos las consultas para cargar los datos
            Consultas();

            //Se establece los valores predeterminados del VentanaInicial con los valores de Properties
            this.BackColor = Properties.Settings.Default.backgroundColor;
            this.Font = Properties.Settings.Default.defaultFont;
            this.ForeColor = Properties.Settings.Default.defaultFontColor;

            //Establecemos valores predeterminados de la ventana
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
              
            //Desactivamos columnas inecesarias
            dgvTutoriales.Columns["ID_TUTORIAL"].Visible = false;
            dgvTutoriales.Columns["ID_TEMA"].Visible = false;
            dgvTutoriales.Columns["DESCRIPCION"].Visible = false;
            dgvTutoriales.Columns["IMAGEN"].Visible = false;
            dgvTutoriales.Columns["VIDEO"].Visible = false;

            ComprobarAcciones();

            runFilterTODOS = true;//Ponemos a funcionar el filtro de TODOS
        }

        private void ComprobarAcciones()//Comprobamos cuantos elementos hay en la view y tambien comprobamos si los select tienen elementos
        {
            if (dgvTutoriales.SelectedRows.Count == 0)//Comprobamos los elementos de la view
            {
                DesactivarAccionesTutorial();

            }
            else
            {
                ActivarAccionesTutorial();
            }

            if(cmbTema.Items.Count < 2)//Comprobamos los elementos del combobox de temas y si segun sus elementos la opcion de añadir se habilitará o no
            {
                btnAnnadirTutorial.Enabled = false;
                mnuAcciones_AnnadirTutorial.Enabled = false;
            }
            else
            {
                btnAnnadirTutorial.Enabled = true;
                mnuAcciones_AnnadirTutorial.Enabled = true;
            }

            if (cmbTema.Items.Count < 2) {//Comprobamos los elementos de los comboboxes y se habilitaran o no
                cmbTema.Enabled = false;
            }
            else cmbTema.Enabled = true;

            if (cmbCategoria.Items.Count < 2)
            {
                cmbCategoria.Enabled = false;
            }
            else cmbCategoria.Enabled = true;
        }

        private void RellenarIconos()//Ponemos los iconos de los componentes de la ventana
        {
            //Icono Ventana
            this.Icon = new Icon(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/iconoPrograma.ico");

            //Iconos botones
            btnAccionesTemas.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/accionesTemas.png");
            btnAnnadirTutorial.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/annadir.png");
            btnModificarTutorial.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/modificar.png");
            btnEliminarTutorial.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/eliminar.png");
            btnDetallesTutorial.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/detalles.png");

            //Iconos menu
            mnuAcciones_AccionesTemas.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/accionesTemas.png");
            mnuAcciones_AnnadirTutorial.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/annadir.png");
            mnuAcciones_ModificarTutorial.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/modificar.png");
            mnuAcciones_EliminarTutorial.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/eliminar.png");
            mnuAcciones_DetallesTutorial.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/detalles.png");
            mnuAcciones_Recargar.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/recargar.png");
            mnuAcciones_SalirVentanaPrincipal.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/salir.png");
            mnuAyuda_AcercaDe.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"/../../Resources/Icons/acercaDe.png");
        }

        private void LimpiarComboboxes()//Limpiamos de elementos los comboboxes
        {
            cmbTema.Items.Clear();
            cmbCategoria.Items.Clear();
        }

        private void Consultas()//Rellenamos los comboboxes con las consultas a la bd
        {

            try
            {
                //Creamos la conexion con la bd
                dbConn = new OleDbConnection();
                dbConn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;"
                                            + @"Data Source = C:\tutorialesDB\tutorialesDB.mdb";

                //Agreagamos la opcion TODOS para los combobox para los filtros
                cmbTema.Items.Add("Todos");
                cmbTema.SelectedIndex = 0;

                cmbCategoria.Items.Add("Todos");
                cmbCategoria.SelectedIndex = 0;

                //Llamamos al filtro del combobox de tutoriales
                FiltroTodosTuto();

                dbConn.Open();//Abrimos conexion
                command.Connection = dbConn;

                //Realizamos consulta de los nombre de temas
                command.CommandText = "select nombre from tema";
                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    cmbTema.Items.Add(dr["nombre"].ToString());
                }

                dr.Close();

                //Realizamos consulta de los nombre de las consulta
                command.CommandText = "select distinct categoria from tutorial";
                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    cmbCategoria.Items.Add(dr["categoria"].ToString());
                }
                dr.Close();
                dbConn.Close();

                //Habilitamos los combobox si se ha agregado elementos desde la bd
                if (cmbTema.Items.Count > 1) cmbTema.Enabled = true;
                if (cmbCategoria.Items.Count > 1) cmbCategoria.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbConn.Close();
            }
        }

        private void FiltroTodosTuto()//Creamos el filtro por defecto, que nos mostrará todos los temas y categorias y rellenamos la view
        {
            try { 
            dbConn.Open();//Abrimos conexion
            command.Connection = dbConn;

            //Realizamos consulta de datos tutoriales
            command.CommandText = "select ID_TUTORIAL, ID_TEMA, TITULO, CATEGORIA, FECHA, DESCRIPCION, IMAGEN, VIDEO from TUTORIAL";

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvTutoriales.DataSource = dt;

            dbConn.Close();

            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvTutoriales.DataSource = new DataTable();
                dbConn.Close();
            }
        }

        private void cmbTema_SelectedIndexChanged(object sender, EventArgs e)//Cuando se cambie el elemento del combobox tema, se filtrará segun el nuevo elemento la view
        {
            tema = cmbTema.Items[cmbTema.SelectedIndex].ToString();

            try
            {
                if (!tema.Equals("Todos") && categoria.Equals("Todos"))//Si es un tema de la bd
                {
                    dbConn.Open();
                    command.Connection = dbConn;
                    command.CommandText = "select t.ID_TUTORIAL, t.ID_TEMA, t.TITULO, t.CATEGORIA, t.FECHA, t.DESCRIPCION, t.IMAGEN, t.VIDEO from TUTORIAL t, TEMA te where t.id_tema=te.ID_TEMA and te.NOMBRE = '" + tema + "'";
                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvTutoriales.DataSource = dt;
                    dbConn.Close();
                }
                else if (!tema.Equals("Todos") && !categoria.Equals("Todos"))
                {
                    dbConn.Open();
                    command.Connection = dbConn;
                    command.CommandText = "select t.ID_TUTORIAL, t.ID_TEMA, t.TITULO, t.CATEGORIA, t.FECHA, t.DESCRIPCION, t.IMAGEN, t.VIDEO from TUTORIAL t, TEMA te where t.id_tema=te.ID_TEMA and te.NOMBRE = '" + tema + "' and t.categoria = '" + categoria + "'";
                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvTutoriales.DataSource = dt;
                    dbConn.Close();
                }
                else if (tema.Equals("Todos") && runFilterTODOS && categoria.Equals("Todos"))//Si es el filtro de TODOS y le esta permitido funcionar al filtro
                {
                    FiltroTodosTuto();
                }
            }
            catch (OleDbException eOleDb)
            {
                Console.WriteLine("Error OledbComboTemas: "+eOleDb);
                dgvTutoriales.DataSource = new DataTable();
                dbConn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error exComboTemas: " + ex);
                MessageBox.Show("Ha ocurrido un error 2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbConn.Close();
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)//Cuando se cambie el elemento del combobox Categoria, se filtrará segun el nuevo elemento la view
        {
            categoria = cmbCategoria.Items[cmbCategoria.SelectedIndex].ToString();


            try
            {
                if (!categoria.Equals("Todos") && tema.Equals("Todos"))//Si es un tema de la bd
                {
                    dbConn.Open();
                    command.Connection = dbConn;
                    command.CommandText = "select t.ID_TUTORIAL, t.ID_TEMA, t.TITULO, t.CATEGORIA, t.FECHA, t.DESCRIPCION, t.IMAGEN, t.VIDEO from TUTORIAL t, TEMA te where t.id_tema=te.ID_TEMA and t.categoria = '" + categoria + "'";
                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvTutoriales.DataSource = dt;
                    dbConn.Close();
                }
                else if (!categoria.Equals("Todos") && !tema.Equals("Todos"))
                {
                    dbConn.Open();
                    command.Connection = dbConn;
                    command.CommandText = "select t.ID_TUTORIAL, t.ID_TEMA, t.TITULO, t.CATEGORIA, t.FECHA, t.DESCRIPCION, t.IMAGEN, t.VIDEO from TUTORIAL t, TEMA te where t.id_tema=te.ID_TEMA and te.NOMBRE = '" + tema + "' and t.categoria = '" + categoria + "'";
                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvTutoriales.DataSource = dt;
                    dbConn.Close();
                }
                else if (categoria.Equals("Todos") && runFilterTODOS && tema.Equals("Todos"))//Si es el filtro de TODOS y le esta permitido funcionar al filtro
                {
                    FiltroTodosTuto();
                }else if (categoria.Equals("Todos") && !tema.Equals("Todos"))//Si es un tema de la bd
                {
                    dbConn.Open();
                    command.Connection = dbConn;
                    command.CommandText = "select t.ID_TUTORIAL, t.ID_TEMA, t.TITULO, t.CATEGORIA, t.FECHA, t.DESCRIPCION, t.IMAGEN, t.VIDEO from TUTORIAL t, TEMA te where t.id_tema=te.ID_TEMA and te.nombre = '" + tema + "'";
                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvTutoriales.DataSource = dt;
                    dbConn.Close();
                }
            }
            catch (OleDbException eOleDb)
            {
                Console.WriteLine("Error OledbComboTemas: " + eOleDb);
                dgvTutoriales.DataSource = new DataTable();
                dbConn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error exComboTemas: " + ex);
                MessageBox.Show("Ha ocurrido un error 2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbConn.Close();
            }
        }
        private void Recargar()//Recargamos toda la informacion de los componentes
        {
            LimpiarComboboxes();
            Consultas();
            ComprobarAcciones();
            FiltroTodosTuto();
            cmbTema.SelectedIndex = 0;
            cmbCategoria.SelectedIndex = 0;
        }

        private void EliminarTutorial()//Eliminamos el tutorial de la bd y comprobamos si esta vacia la view6
        {
            try
            {
                if (MessageBox.Show("¿Estas seguro que quieres eliminarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dbConn.Open();
                    OleDbCommand commamd = new OleDbCommand();
                    commamd.Connection = dbConn;
                    commamd.CommandText = "delete from tutorial where id_tutorial = " + dgvTutoriales.SelectedRows[0].Cells["id_tutorial"].Value.ToString();
                    commamd.ExecuteNonQuery();

                    dbConn.Close();
                    Recargar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Eliminar Tutorial: " + ex);
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbConn.Close();
            }
        }

        private void DesactivarAccionesTutorial()//Desactivamos los botones y los elementos del menu
        {
            //Desabilitamos los botones de acciones con tutorial por defecto
            btnAnnadirTutorial.Enabled = true;
            btnModificarTutorial.Enabled = false;
            btnEliminarTutorial.Enabled = false;
            btnDetallesTutorial.Enabled = false;

            //Desabilitamos las acciones del menu acciones con tutorial por defecto
            mnuAcciones_AnnadirTutorial.Enabled = true;
            mnuAcciones_ModificarTutorial.Enabled = false;
            mnuAcciones_EliminarTutorial.Enabled = false;
            mnuAcciones_DetallesTutorial.Enabled = false;
        }
        private void ActivarAccionesTutorial()//Activamos los botones y los elementos del menu
        {
            //Desabilitamos los botones de acciones con tutorial por defecto
            btnModificarTutorial.Enabled = true;
            btnEliminarTutorial.Enabled = true;
            btnDetallesTutorial.Enabled = true;

            //Desabilitamos las acciones del menu acciones con tutorial por defecto
            mnuAcciones_ModificarTutorial.Enabled = true;
            mnuAcciones_EliminarTutorial.Enabled = true;
            mnuAcciones_DetallesTutorial.Enabled = true;
        }

        private DialogResult CrearVentanaTemas()
        {
            vt = new VentanaTema();//Creamos la ventana para las acciones con Temas
            return vt.ShowDialog();
        }

        private DialogResult CrearVentanaAccionesTutorial(Tutorial t,Acciones a)
        {
            VentanaAccionesTutorial vat = new VentanaAccionesTutorial(t, a);//Creamos la ventana para las acciones con tutoriales
            return vat.ShowDialog();//Devolvemos el boton apretado en la ventana
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuAyuda_Info_Click(object sender, EventArgs e)//Mostramos la informacion sobre el acerca de
        {
            MessageBox.Show("Programa Actividad 1.1 DI - 2DAM\nHecho por Mario Parrilla Maroto ©2021 ", "Acerca de Trabajo Tutoriales",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnAccionesTemas_Click(object sender, EventArgs e)
        {
            if(CrearVentanaTemas()==DialogResult.Cancel) Recargar();//Si se agrega un tema se actualiza la informacion
        }

        private void mnuAcciones_AccionesTemas_Click(object sender, EventArgs e)
        {
            if (CrearVentanaTemas() == DialogResult.Cancel) Recargar();//Si se agrega un tema se actualiza la informacion
        }
        private void dgvTutoriales_RowEnter(object sender, DataGridViewCellEventArgs e)//Cuando se seleccione un elemento se activarán los botones
        {
            ActivarAccionesTutorial();
        }

        private void btnAnnadirTutorial_Click(object sender, EventArgs e)
        {
            if (CrearVentanaAccionesTutorial(null, Acciones.ANNDIR)==DialogResult.OK) Recargar();//Si se agrega un tutorial se actualiza la informacion
        }


        private void mnuAcciones_AnnadirTutorial_Click(object sender, EventArgs e)
        {
            if (CrearVentanaAccionesTutorial(null, Acciones.ANNDIR) == DialogResult.OK) Recargar();//Si se agrega un tutorial se actualiza la informacion
        }


        private void btnModificarTutorial_Click(object sender, EventArgs e)//Si se modificar un tutorial se actualiza la informacion
        {
            if(CrearVentanaAccionesTutorial(new Tutorial(int.Parse(dgvTutoriales.SelectedRows[0].Cells["ID_TUTORIAL"].Value.ToString()), int.Parse(dgvTutoriales.SelectedRows[0].Cells["ID_TEMA"].Value.ToString()), dgvTutoriales.SelectedRows[0].Cells["TITULO"].Value.ToString(), 
                dgvTutoriales.SelectedRows[0].Cells["CATEGORIA"].Value.ToString(), dgvTutoriales.SelectedRows[0].Cells["FECHA"].Value.ToString(), dgvTutoriales.SelectedRows[0].Cells["DESCRIPCION"].Value.ToString(), dgvTutoriales.SelectedRows[0].Cells["IMAGEN"].Value.ToString()
                , dgvTutoriales.SelectedRows[0].Cells["VIDEO"].Value.ToString()), Acciones.MODIFICAR)==DialogResult.OK) Recargar();
        }

        private void mnuAcciones_ModificarTutorial_Click(object sender, EventArgs e)//Si se modificar un tutorial se actualiza la informacion
        {
            if (CrearVentanaAccionesTutorial(new Tutorial(int.Parse(dgvTutoriales.SelectedRows[0].Cells["ID_TUTORIAL"].Value.ToString()), int.Parse(dgvTutoriales.SelectedRows[0].Cells["ID_TEMA"].Value.ToString()), dgvTutoriales.SelectedRows[0].Cells["TITULO"].Value.ToString(),
                dgvTutoriales.SelectedRows[0].Cells["CATEGORIA"].Value.ToString(), dgvTutoriales.SelectedRows[0].Cells["FECHA"].Value.ToString(), dgvTutoriales.SelectedRows[0].Cells["DESCRIPCION"].Value.ToString(), dgvTutoriales.SelectedRows[0].Cells["IMAGEN"].Value.ToString()
                , dgvTutoriales.SelectedRows[0].Cells["VIDEO"].Value.ToString()), Acciones.MODIFICAR) == DialogResult.OK) Recargar();
        }

        private void btnEliminarTutorial_Click(object sender, EventArgs e)//Si se elimina un tutorial se actualiza la informacion
        {
            EliminarTutorial();
        }

        private void mnuAcciones_EliminarTutorial_Click(object sender, EventArgs e)//Si se elimina un tutorial se actualiza la informacion
        {
            EliminarTutorial();
        }

        private void btnDetallesTutorial_Click(object sender, EventArgs e)//Mostramos la informacion del tutorial
        {
            CrearVentanaAccionesTutorial(new Tutorial(int.Parse(dgvTutoriales.SelectedRows[0].Cells["ID_TUTORIAL"].Value.ToString()), int.Parse(dgvTutoriales.SelectedRows[0].Cells["ID_TEMA"].Value.ToString()), dgvTutoriales.SelectedRows[0].Cells["TITULO"].Value.ToString(),
                dgvTutoriales.SelectedRows[0].Cells["CATEGORIA"].Value.ToString(), dgvTutoriales.SelectedRows[0].Cells["FECHA"].Value.ToString(), dgvTutoriales.SelectedRows[0].Cells["DESCRIPCION"].Value.ToString(), dgvTutoriales.SelectedRows[0].Cells["IMAGEN"].Value.ToString()
                , dgvTutoriales.SelectedRows[0].Cells["VIDEO"].Value.ToString()), Acciones.DETALLES);
        }

        private void mnuAcciones_DetallesTutorial_Click(object sender, EventArgs e)//Mostramos la informacion del tutorial
        {
            CrearVentanaAccionesTutorial(new Tutorial(int.Parse(dgvTutoriales.SelectedRows[0].Cells["ID_TUTORIAL"].Value.ToString()), int.Parse(dgvTutoriales.SelectedRows[0].Cells["ID_TEMA"].Value.ToString()), dgvTutoriales.SelectedRows[0].Cells["TITULO"].Value.ToString(),
                dgvTutoriales.SelectedRows[0].Cells["CATEGORIA"].Value.ToString(), dgvTutoriales.SelectedRows[0].Cells["FECHA"].Value.ToString(), dgvTutoriales.SelectedRows[0].Cells["DESCRIPCION"].Value.ToString(), dgvTutoriales.SelectedRows[0].Cells["IMAGEN"].Value.ToString()
                , dgvTutoriales.SelectedRows[0].Cells["VIDEO"].Value.ToString()), Acciones.DETALLES);
        }

        private void mnuAcciones_Recargar_Click(object sender, EventArgs e)//Recargamos la informacion
        {
            Recargar();
        }
    }
}