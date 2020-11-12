using System;
using System.Collections.Generic;
using Entidad;
using Datos;

namespace Logica
{
    public class EstudianteService
    {
        private EstudianteRepository estudianteRepository;
        public EstudianteService()
        {
            estudianteRepository = new EstudianteRepository();
        }

        public ConsultaEstudianteResponse ConsultarTodos()
        {

            ConsultaEstudianteResponse estudianteResponse;
            try
            {
                List<Estudiante> estudiantes = estudianteRepository.ConsultarTodos();
                if (estudiantes != null)
                {
                    return estudianteResponse = new ConsultaEstudianteResponse(estudiantes);
                }
                else
                {
                    return estudianteResponse = new ConsultaEstudianteResponse("La Persona buscada no se encuentra Registrada");
                }

            }
            catch (Exception e)
            {

                return estudianteResponse = new ConsultaEstudianteResponse("Error de Aplicacion: " + e.Message);
            }
        }


    }
}
public class EstudianteResponse
{
    public Estudiante Estudiante { get; set; }
    public string Message { get; set; }
    public bool EstudianteEncontrado { get; set; }

    public EstudianteResponse(Estudiante estudiante)
    {
        Estudiante = new Estudiante();
        Estudiante = estudiante;
        EstudianteEncontrado = true;
    }
    public EstudianteResponse(string message)
    {
        Message = message;
        EstudianteEncontrado = false;
    }
}
public class ConsultaEstudianteResponse
{
    public List<Estudiante> Estudiantes { get; set; }
    public string Message { get; set; }
    public bool EstudianteEncontrado { get; set; }

    public ConsultaEstudianteResponse(List<Estudiante> estudiantes)
    {
        Estudiantes = new List<Estudiante>();
        Estudiantes = estudiantes;
        EstudianteEncontrado = true;
    }
    public ConsultaEstudianteResponse(string message)
    {
        Message = message;
        EstudianteEncontrado = false;
    }
}
