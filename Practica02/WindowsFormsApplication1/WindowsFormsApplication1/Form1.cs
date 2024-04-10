using System;
using System.Windows.Forms;

namespace TuProyecto
{
    public partial class Form1 : Form
    {
        // Declara una instancia de la capa de servicio (SL).
        private SL _sl;

        public Form1()
        {
            InitializeComponent();
            _sl = new SL();
        }

        // Controlador de evento para el botón "Agregar trabajador".
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string apellidos = txtApellidos.Text;
                decimal sueldoBruto = decimal.Parse(txtSueldo.Text);
                string categoria = txtCategoria.Text;

                _sl.AgregarTrabajador(nombre, apellidos, sueldoBruto, categoria);

                ActualizarListaTrabajadores();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce un sueldo válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Controlador de evento para el botón "Recuperar trabajadores".
        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            ActualizarListaTrabajadores();
        }

        // Método para actualizar la lista de trabajadores en el formulario.
        private void ActualizarListaTrabajadores()
        {
            listBoxTrabajadores.Items.Clear();

            var trabajadores = _sl.RecuperarTrabajadores();

            foreach (var trabajador in trabajadores)
            {
                listBoxTrabajadores.Items.Add($"{trabajador.NOMBRE} {trabajador.APELLIDOS} - Salario Bruto: {trabajador.SUELDO_BRUTO}, Categoría: {trabajador.CATEGORIA}");
            }
        }
    }
}

