using System;

namespace Entidad
{
    public class Estudiante
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Voto { get; set; }

        public Estudiante(string identificacion, string nombre, string voto)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Voto = voto;
        }
        public Estudiante()
        {

        }
    }
}
