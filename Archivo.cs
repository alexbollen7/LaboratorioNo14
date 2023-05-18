using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace LaboratorioNo14
{
    public class Archivo
    {
        public void Grabar(List<Album> albumes)
        {
            string json = JsonConvert.SerializeObject(albumes);
            string archivo = System.Web.HttpContext.Current.Server.MapPath("Biblioteca.json");
            System.IO.File.WriteAllText(archivo, json);
        }


        public List<Album> Leer()
        {
            List<Album> lista = new List<Album>();
            string archivo = System.Web.HttpContext.Current.Server.MapPath("Biblioteca.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            if (json == "{}")
            {

                lista = null;
            }
            else
            {
                lista = JsonConvert.DeserializeObject<List<Album>>(json);
            }
            return lista;
        }
    }
}