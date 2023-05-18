using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaboratorioNo14
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonBuscarAlbum_Click(object sender, EventArgs e)
        {
            Archivo archivo = new Archivo();
            List<Album> albumes = archivo.Leer();
            if (albumes != null)
            {
                Album albumExiste = albumes.Find(u => u.TituloAlbum == TextBoxBuscar.Text);
                if (albumExiste != null)
                {
                    Response.Write("<script>alert('Album Encontrada.')</script>");
                    LabelAlbum.Text = albumExiste.TituloAlbum;
                    TextBoxTituloAlbum.Text = albumExiste.TituloAlbum;
                    TextBoxNombreArtista.Text = albumExiste.ArtistaAlbum;
                    TextBoxFechaPublicacion.Text = albumExiste.FechaPublicacion;
                    ButtonActualizar.Enabled = true;
                }
                else 
                {
                    Response.Write("<script>alert('Album no existe!')</script>");
                }
            }
        }

        protected void ButtonActualizar_Click(object sender, EventArgs e)
        {
            Archivo archivo = new Archivo();
            List<Album> albumes= new List<Album>();
            albumes = archivo.Leer();
            Album album= albumes.Find(a => a.TituloAlbum== LabelAlbum.Text);
            album.TituloAlbum = TextBoxTituloAlbum.Text;
            album.ArtistaAlbum = TextBoxNombreArtista.Text;
            album.FechaPublicacion = TextBoxFechaPublicacion.Text;
            Response.Write("<script>alert('Album actualizado')</script>");
            archivo.Grabar(albumes);
        }
    }
}