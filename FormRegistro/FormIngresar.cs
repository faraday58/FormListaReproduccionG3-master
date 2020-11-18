using System;
using System.Collections;
using UsuariosEntrada;
using FormListaReproduccionG3;
using System.Windows.Forms;

namespace FormRegistro
{
    //Ejemplo
    public partial class FormIngresar : Form
    {
        ArrayList usuarios;
        bool correcto = false;
        public FormIngresar()
        {
            InitializeComponent();
            usuarios = new ArrayList();

            usuarios.Add(new Usuario("armando", "123"));
            usuarios.Add(new Usuario("jorge", "456"));
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(validaUsuario())
            {
                FormRepro formRepro = new FormRepro(this);
                this.Hide();
                formRepro.Show();
            }
            else
            {
                MessageBox.Show("El usuario o contraseña son incorrectos");
            }



        }

        private void txtbContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        public bool validaUsuario()
        {
            foreach (Usuario usuario in usuarios)//Instanciamos un usuario
                if (txtbUsuario.Text == usuario.NombreUsuario && txtbContraseña.Text == usuario.Password)
                {
                    correcto = true;
                    break;
                }

                else
                {
                    correcto = false;
                }
            return correcto;
        }

        private void txtbContraseña_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                validaUsuario();
            }
        }
    }
}
