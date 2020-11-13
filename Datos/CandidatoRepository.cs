using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Entidad;

namespace Datos
{

    public class CandidatoRepository
    {
        private readonly string FileName = "Candidatos.txt";
        public void Guardar(Candidato candidato)
        {
            FileStream file = new FileStream(FileName, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{candidato.Tarjeton};{candidato.Nombre};{candidato.Votos}");
            writer.Close();
            file.Close();
        }
        public Candidato Buscar(string tarjeton)
        {
            List<Candidato> candidatos = ConsultarTodos();
            foreach (var item in candidatos)
            {
                if (EsEncontrado(item.Tarjeton, tarjeton))
                {
                    return item;
                }
            }
            return null;
        }
        private bool EsEncontrado(string identificacioRegistrada, string identificacionBuscada)
        {
            return identificacioRegistrada == identificacionBuscada;
        }
        public List<Candidato> ConsultarTodos()
        {
            List<Candidato> candidatos = new List<Candidato>();
            FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {

                Candidato candidato = Map(linea);
                candidatos.Add(candidato);
            }
            reader.Close();
            file.Close();
            return candidatos;
        }
        private Candidato Map(string linea)
        {
            Candidato candidato = new Candidato();
            char delimiter = ';';
            string[] matrizPersona = linea.Split(delimiter);
            candidato.Tarjeton = matrizPersona[0];
            candidato.Nombre = matrizPersona[1];
            candidato.Votos = int.Parse(matrizPersona[2]);

            return candidato;
        }

        public void Modificar(Candidato candidato)
        {
            List<Candidato> candidatos = new List<Candidato>();
            candidatos = ConsultarTodos();
            FileStream file = new FileStream(FileName, FileMode.Create);
            file.Close();
            foreach (var item in candidatos)
            {
                if (EsEncontrado(item.Tarjeton, candidato.Tarjeton))
                {
                    Guardar(candidato);
                }
                else
                {
                    Guardar(item);
                }

            }


        }
    }
}
