using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Entidad;
namespace Datos
{
    public class EstudianteRepository
    {
        private readonly string FileName = "Estudiantes.txt";

        public void Guardar(Estudiante estudiante)
        {
            FileStream file = new FileStream(FileName, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{estudiante.Identificacion};{estudiante.Nombre};{estudiante.Voto} ");
            writer.Close();
            file.Close();

        }
        public Estudiante Buscar(string identificacion)
        {
            List<Estudiante> personas = ConsultarTodos();
            foreach (var item in personas)
            {
                if (EsEncontrado(item.Identificacion, identificacion))
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
        public List<Estudiante> ConsultarTodos()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {

                Estudiante estudiante = Map(linea);
                estudiantes.Add(estudiante);
            }
            reader.Close();
            file.Close();
            return estudiantes;
        }

        private Estudiante Map(string linea)
        {
            Estudiante estudiante = new Estudiante();
            char delimiter = ';';
            string[] matrizEstudiante = linea.Split(delimiter);
            estudiante.Identificacion = matrizEstudiante[0];
            estudiante.Nombre = matrizEstudiante[1];
            estudiante.Voto = matrizEstudiante[2];
            return estudiante;
        }

        public List<Estudiante> consultarPorCategoria(String categoria)
        {
            categoria = categoria.ToUpper();
            if (categoria.Equals("TODOS"))
            {
                return ConsultarTodos();
            }
            else
            {
                
                return ConsultarVoto(categoria);
            }



        }

        private List<Estudiante> ConsultarVoto(String categoria)
        {
            return ConsultarTodos().Where(p => p.Voto.Equals(categoria)).ToList();
        }

        public void Modificar(Estudiante estudiante)
        {
            List<Estudiante> personas = new List<Estudiante>();
            personas = ConsultarTodos();
            FileStream file = new FileStream(FileName, FileMode.Create);
            file.Close();
            foreach (var item in personas)
            {
                if (EsEncontrado(item.Identificacion, estudiante.Identificacion))
                {
                    
                }
                else
                {
                    Guardar(item);
                }

            }

        }




    }
}
