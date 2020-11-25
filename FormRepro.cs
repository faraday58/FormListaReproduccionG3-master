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
        private int contador;
        private int duracion;
        #endregion
        public FormRepro(Form formPadre)
        {
            this.formPadre = formPadre;

            InitializeComponent();
            musica= new Musica("","","");
            listReproduccion.Items.Add(musica.Cancion);
            canciones = new ArrayList();
            canciones.Add(musica);
            ListaCanciones();
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
            musica = (Musica)canciones[listReproduccion.SelectedIndex];

            lbAlbum.Text = musica.Album;
            lbArtista.Text = musica.Artista;
            lbCancion.Text = musica.Cancion;                              
        }

        private void cargarCancionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listReproduccion.Items.Clear();            
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

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregar formAgregar = new FormAgregar();
            formAgregar.EnviarMusica += FormAgregar_RecibirMusica;
            formAgregar.ShowDialog();
        }

        private void FormAgregar_RecibirMusica(Musica musica)
        {
            listReproduccion.Items.Add(musica.Cancion);
            canciones.Add(musica);
        }

        private void timerCancion_Tick(object sender, EventArgs e)
        {

                       
            if(contador < 100 )
            {
                pbrTiempoTrans.Value = contador;
                contador += 100 / duracion;
                float segundos = contador * duracion / 100;
                lbTiempoTrans.Text = segundos.ToString() + " [s]";                        
                
            }
            else
            {
                contador = 0;
                pbrTiempoTrans.Value = 0;
                timerCancion.Stop();
            }

        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listReproduccion.SelectedIndex  != -1)
            {
                timerCancion.Start();
                musica = (Musica)canciones[listReproduccion.SelectedIndex];
                duracion = musica.Duracion;
                lbTiempoDuracion.Text = duracion.ToString() + "[s]";
                
            }
            
        }

        private void siguienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!timerCancion.Enabled)
            {
                timerCancion.Start();
            }
            if( listReproduccion.SelectedIndex < listReproduccion.Items.Count-1  )
            {
                listReproduccion.SelectedIndex += 1;
                musica = (Musica)canciones[listReproduccion.SelectedIndex];                
                contador = 0;
            }
            else
            {
                listReproduccion.SelectedIndex = 0;
                musica = (Musica)canciones[0];                
                contador = 0;
            }
            lbAlbum.Text = musica.Album;
            lbArtista.Text = musica.Artista;
            lbCancion.Text = musica.Cancion;
            duracion = musica.Duracion;
            lbTiempoDuracion.Text = duracion.ToString() + "[s]";
        }

        private void pausarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerCancion.Stop();
        }

        private void anteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!timerCancion.Enabled)
            {
                timerCancion.Start();
            }
            if (listReproduccion.SelectedIndex > 1)
            {
                listReproduccion.SelectedIndex -= 1;
                musica = (Musica)canciones[listReproduccion.SelectedIndex];
                
            }
            else
            {
                listReproduccion.SelectedIndex = listReproduccion.Items.Count-1;
                musica = (Musica)canciones[listReproduccion.SelectedIndex];
                
            }
            contador = 0;
            lbAlbum.Text = musica.Album;
            lbArtista.Text = musica.Artista;
            lbCancion.Text = musica.Cancion;
            duracion = musica.Duracion;
            lbTiempoDuracion.Text = duracion.ToString() + "[s]";
        }
    }
}
