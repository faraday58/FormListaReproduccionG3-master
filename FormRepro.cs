using System;
using System.Collections;
using System.Windows.Forms;

namespace FormListaReproduccionG3
{
    public partial class FormRepro : Form
    {
        #region Atributos
        private Musica musica;
        private ArrayList canciones;
        Form formPadre;
        #endregion
        public FormRepro(Form formPadre)
        {
            this.formPadre = formPadre;

            InitializeComponent();
            musica= new Musica("","","");
            listReproduccion.Items.Add(musica.Cancion);
            canciones = new ArrayList();
            canciones.Add(musica);
        }
        private void ListaCanciones()
        {
            canciones.Add(new Musica("Hit me","Molotov", " Dance and dense denso"));
            canciones.Add(new Musica("La parte de adelante ","Los Fabulosos Cadillac"," Lo esencial de los Fabulosos Cadillac"));
            canciones.Add(new Musica("Monsters ", "Starset ", "Vessels"));
            canciones.Add(new Musica("Funky town", "Lipps Inc", "Club Classics"));
            canciones.Add(new Musica("Ramito de violetas", "Mi Banda El Mexicano", "Grupo el mexicano"));
        }

        private void listReproduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAlbum.Text = musica.Album;
            lbArtista.Text = musica.Artista;
            lbCancion.Text = musica.Cancion;
            try
            {
                musica = (Musica)canciones[listReproduccion.SelectedIndex];
            }
            catch(ArgumentOutOfRangeException )
            {

            }
            
            

            
        }

        private void cargarCancionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaCanciones();
            foreach (Musica musica in canciones  )
            {
                listReproduccion.Items.Add(musica.Cancion);
            }

        }
        /// <summary>
        /// Evento para cerrar el FormRepro y volver a mostrar al formulario registro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormRepro_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPadre.Show();
        }
    }
}
