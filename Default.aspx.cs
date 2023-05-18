using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaboratorioNo14
{
    public partial class _Default : Page
    {
        static List<Cancion> canciones = new List<Cancion>();
        static List<Album> albumes = new List<Album>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAgregarCancion_Click(object sender, EventArgs e)
        {
            Cancion cancionNueva = new Cancion();
            cancionNueva.NombreCancion = TextBoxNombreCancion.Text;
            cancionNueva.Artista = TextBoxNombreArtista.Text;
            cancionNueva.TiempoDuracion =TextBoxTiempoDuracion.Text;

            canciones.Add(cancionNueva);
        }

        protected void ButtonAgregarAlbum_Click(object sender, EventArgs e)
        {
            Archivo archivo = new Archivo();
            List<Album> albumes = archivo.Leer();

            if (albumes == null)
            {
                albumes = new List<Album>();
            }
            Album newAlbum = new Album();

            newAlbum.TituloAlbum = TextBoxTituloAlbum.Text;
            newAlbum.ArtistaAlbum = TextBoxNombreArtista.Text;
            newAlbum.Canciones = canciones;
            newAlbum.FechaPublicacion = TextBoxFechaPublicacion.Text;

            albumes.Add(newAlbum);

            archivo.Grabar(albumes);
        }
    }
}