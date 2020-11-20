using System;
using System.Windows.Forms;

namespace FormListaReproduccionG3
{


    public partial class FormAgregar : Form
    {
        public delegate void DelegadoMusica(Musica musica  );
        public event DelegadoMusica EnviarMusica;
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {             
            EnviarMusica(new Musica(txtbCancion.Text, txtbArtista.Text, txtbAlbum.Text));
        }
    }
}
