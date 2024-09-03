
namespace Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;

            // Aquí podrías agregar lógica para verificar el usuario
            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario.");
            }
            else
            {
                MessageBox.Show("Usuario ingresado: " + usuario);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string contrasena = txtContrasena.Text;

            if (string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, ingrese una contraseña.");
            }
            else
            {
                MessageBox.Show("Contraseña ingresada.");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            // Supongamos que los valores correctos son "admin" y "1234"
            if (usuario == "gestion" && contrasena == "1212")
            {
                //MessageBox.Show("Bienvenido, " + usuario + "!");

                //Crear una instancia del nuevo formulario `Inicio`
                Frm2 inicioForm = new Frm2();

                // Mostrar el formulario `Inicio`
                inicioForm.Show();

                // Ocultar el formulario actual (opcional)
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
