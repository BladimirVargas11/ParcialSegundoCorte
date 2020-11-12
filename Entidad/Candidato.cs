using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class Candidato
    {
        public string Tarjeton { get; set; }
        public string Nombre { get; set; }
        public int Votos { get; set; }

        public Candidato(string tarjeton, string nombre, int votos)
        {
            Tarjeton = tarjeton;
            Nombre = nombre;
            Votos = votos;
        }
        public Candidato()
        {

        }
    }
}
