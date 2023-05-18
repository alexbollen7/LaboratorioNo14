using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaboratorioNo14
{
    public class Cancion
    {
        string nombreCancion;
        string artista;
        string tiempoDuracion;

        public string NombreCancion { get => nombreCancion; set => nombreCancion = value; }
        public string Artista { get => artista; set => artista = value; }
        public string TiempoDuracion { get => tiempoDuracion; set => tiempoDuracion = value; }
    }
}