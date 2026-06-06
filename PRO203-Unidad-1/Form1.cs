namespace PRO203_Unidad_1
{
    public partial class frmVideojuegos : Form
    {
        List<Videojuego> Videojuegos;  // <= Declarando su existencia
        int semilla;
        Videojuego juegoModificar;

        public frmVideojuegos()
        {
            InitializeComponent();
            Videojuegos = new List<Videojuego>();   // <= Inicializando el elemento.
            semilla = 1;
            txtIdentificador.Text = semilla.ToString();
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
                        juego.Identificador = semilla;
                        Videojuegos.Add(juego);
                        semilla++;
                    } 

                    juego.Nombre = txtNombre.Text;
                    juego.Categoria = txtCategoria.Text;
                    juego.HorasJugadas = Convert.ToInt32(txtHorasJugadas.Text);                  

                    ActualizarGrilla();
                    LimpiarCampos();

                }
                else
                {
                    MessageBox.Show(mensajeError);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LimpiarCampos() {
            juegoModificar = null;
            txtIdentificador.Text = semilla.ToString();
            txtNombre.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtHorasJugadas.Text = string.Empty;

        }

        private string ValidarDatos()
        {
            string mensaje = string.Empty;
            int valueExit = 0;

            if (int.TryParse(txtIdentificador.Text, out valueExit) == false)
            {
                mensaje = mensaje + "El identificador no es válido" + Environment.NewLine;
            }
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
            dgvJuegos.DataSource = Videojuegos;
        }

        private void dgvJuegos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) { 
            
                DataGridViewRow fila = dgvJuegos.Rows[e.RowIndex];
                int idSeleccionado = Convert.ToInt32(fila.Cells[0].Value.ToString());
                MessageBox.Show(idSeleccionado.ToString());

                juegoModificar = Videojuegos.Where( x=> x.Identificador == idSeleccionado ).First();
                txtIdentificador.Text = juegoModificar.Identificador.ToString();
                txtNombre.Text = juegoModificar.Nombre.ToString();
                txtCategoria.Text = juegoModificar.Categoria.ToString();
                txtHorasJugadas.Text = juegoModificar.HorasJugadas.ToString();                 
            }
        }
    }
}
