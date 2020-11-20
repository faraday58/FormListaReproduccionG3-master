
namespace FormListaReproduccionG3
{
    public class Musica
    {

        #region atributos
        private string cancion;
        private string artista;
        private string album;
        private int duracion;
        #endregion

        #region Constructor
        public Musica(string cancion, string artista, string album)
        {
            Cancion = cancion;
            Artista = artista;
            Album = album;
        }
        #endregion

        #region Propiedades
        public string Cancion
        {
            get => cancion;
            set
            {
                if( value == "" )
                {
                    cancion = "Clint Eastwood";
                }
                else
                {
                    cancion = value;
                }
                
            }
                
        }    
        public string Artista { get => artista;
            set
            {
                if( value == "")
                {
                    artista = "Gorillaz";
                }
                else
                {
                    artista = value;
                }
                
            }
        }
        public string Album { get => album;
            set
            {
                if(  value == ""  )
                {
                    album = "Gorillaz";
                }
                else
                {
                    album = value;
                }              

            }
                
        }

        public int Duracion { get => duracion; set => duracion = value; }

        #endregion
    }
}
