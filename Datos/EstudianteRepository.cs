using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Entidad;
namespace Datos
{
    public class EstudianteRepository
    {
        private readonly string FileName = "Estudiante.txt";
        public void Guardar(Estudiante estudiante)
        {
            FileStream file = new FileStream(FileName, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{estudiante.Identificacion};{estudiante.Nombre}; ");
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
            String Voto = "NO";
            string[] matrizEstudiante = linea.Split(delimiter);
            estudiante.Identificacion = matrizEstudiante[0];
            estudiante.Nombre = matrizEstudiante[1];
            if (estudiante.Voto is null)
            {
                estudiante.Voto = Voto;
                estudiante.Voto = matrizEstudiante[3];
            }
            else {
                estudiante.Voto = matrizEstudiante[3];
            }

            return estudiante;
        }

    }
}
