using pro203_repaso1.Business;
using PRO203_Unidad_1.Support;

namespace PRO203_Unidad_1
{
    public partial class frmVideojuegos : Form
    {      
        Videojuego juegoModificar;
        VideoJuegoBusiness juegoBusiness;


        public frmVideojuegos()
        {
            InitializeComponent();
            juegoBusiness = new VideoJuegoBusiness();
            ActualizarGrilla();
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensajeError = ValidarDatos();
                if (mensajeError == string.Empty)
                {

                    Videojuego juego;

                    if (juegoModificar != null)
                    {
                        juego = juegoModificar;
                    }
                    else {
                        juego = new Videojuego();
                    } 

                    juego.Nombre = txtNombre.Text;
                    juego.Categoria = txtCategoria.Text;
                    juego.HorasJugadas = Convert.ToInt32(txtHorasJugadas.Text);

                    if (juegoModificar == null)
                    {
                        juegoBusiness.Crear(juego);
                    }
                    else {
                        juegoBusiness.Modificar(juego);
                    }

                    ActualizarGrilla();
                    LimpiarCampos();
                    MessageBox.Show("Operación Correcta", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(mensajeError, "Faltan campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LimpiarCampos() {
            juegoModificar = null;          
            txtNombre.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtHorasJugadas.Text = string.Empty;
            btnGuardar.Text = "Crear";

        }

        private string ValidarDatos()
        {
            string mensaje = string.Empty;
            int valueExit = 0;


            if (!int.TryParse(txtHorasJugadas.Text, out valueExit))
            {
                mensaje = mensaje + "Las Horas jugadas no son válidas" + Environment.NewLine;
            }
            if (txtNombre.Text == string.Empty)
            {
                mensaje = mensaje + "El Nombre no puede estar en blanco" + Environment.NewLine;
            }
            if (txtCategoria.Text == string.Empty)
            {
                mensaje = mensaje + "La Categoría no puede estar en blanco" + Environment.NewLine;
            }

            return mensaje;

        }

        private void ActualizarGrilla()
        {
            dgvJuegos.DataSource = null;
            dgvJuegos.DataSource = juegoBusiness.ObtenerTodos();
        }

        private void dgvJuegos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) { 
            
                DataGridViewRow fila = dgvJuegos.Rows[e.RowIndex];
                int idSeleccionado = Convert.ToInt32(fila.Cells[0].Value.ToString());
                juegoModificar = juegoBusiness.ObtenerPorId(idSeleccionado);
                txtIdentificador.Text = juegoModificar.Identificador.ToString();
                txtNombre.Text = juegoModificar.Nombre.ToString();
                txtCategoria.Text = juegoModificar.Categoria.ToString();
                txtHorasJugadas.Text = juegoModificar.HorasJugadas.ToString();
                btnGuardar.Text = "Actualizar";
            }
        }
    }
}
