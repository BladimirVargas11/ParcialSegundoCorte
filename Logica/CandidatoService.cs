using System;
using System.Collections.Generic;
using Entidad;
using Datos;

namespace Logica
{
    public class CandidatoService
    {
        private CandidatoRepository candidatoRepository;
        public CandidatoService()
        {
            candidatoRepository = new CandidatoRepository();
        }

        public string Guardar(Candidato candidato)
        {
            try
            {

                if (candidatoRepository.Buscar(candidato.Tarjeton) == null)
                {
                    candidatoRepository.Guardar(candidato);
                    return $"se han guardado Satisfactoriamente los datos de: {candidato.Nombre}";
                }
                else
                {
                    return $"El tarjeton: {candidato.Tarjeton} ya se encuentra registrado";
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicacion: {e.Message}";
            }
        }

        public CandidatoResponse BuscarPorTarjeton(string tarjeton)
        {
            CandidatoResponse candidatoResponse;
            try
            {
                Candidato candidato = candidatoRepository.Buscar(tarjeton);
                if (candidato != null)
                {
                    return candidatoResponse = new CandidatoResponse(candidato);
                }
                else
                {
                    return candidatoResponse = new CandidatoResponse("La Persona buscada no se encuentra Registrada");
                }

            }
            catch (Exception e)
            {

                return candidatoResponse = new CandidatoResponse("Error de Aplicacion: " + e.Message);
            }

        }

        public ConsultaCandidatoResponse ConsultarTodos()
        {

            ConsultaCandidatoResponse candidatoResponse;
            try
            {
                List<Candidato> candidatos = candidatoRepository.ConsultarTodos();
                if (candidatos != null)
                {
                    return candidatoResponse = new ConsultaCandidatoResponse(candidatos);
                }
                else
                {
                    return candidatoResponse = new ConsultaCandidatoResponse("La Persona buscada no se encuentra Registrada");
                }

            }
            catch (Exception e)
            {

                return candidatoResponse = new ConsultaCandidatoResponse("Error de Aplicacion: " + e.Message);
            }
        }

        public string Modificar(Candidato candidato)
        {
            try
            {
                if (candidatoRepository.Buscar(candidato.Tarjeton) != null )
                {
                    candidatoRepository.Modificar(candidato);
                    return ($"Usted Ha votado por: {candidato.Nombre}, con el tarjetón: {candidato.Tarjeton}  ");
                }
                else
                {
                    return ($"Lo sentimos, no se ha encontrado el candidato con el tarjetón: {candidato.Tarjeton}");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicacion: {e.Message}";
            }

        }

        public ConsultaCandidatoResponse ConsultarPorCategoria(string categoria)
        {

            try
            {
                List<Candidato> candidatos = candidatoRepository.consultarPorCategoria(categoria);
                if (candidatos != null)
                {

                    return new ConsultaCandidatoResponse(candidatos);
                }
                else
                {
                    return new ConsultaCandidatoResponse("No existe aún ninguna persona en este grupo");
                }

            }
            catch (Exception e)
            {

                return new ConsultaCandidatoResponse("Error de Aplicacion: " + e.Message);
            }
        }
        
        public CandidatoResponse ConsultarGanador()
        {

            try
            {
                List<Candidato> candidatos = candidatoRepository.ConsultarTodos();
                if (candidatos != null)
                {
                    Candidato candidato = candidatoRepository.ConsultaGanador();
                    return new CandidatoResponse(candidato);
                }
                else
                {
                    return new CandidatoResponse("No existe aún ningun candidato ganador");
                }

            }
            catch (Exception e)
            {

                return new CandidatoResponse("Error de Aplicacion: " + e.Message);
            }
        }


    }

    public class CandidatoResponse
    {
        public Candidato Candidato { get; set; }
        public string Message { get; set; }
        public bool CandidatoEncontrado { get; set; }

        public CandidatoResponse(Candidato candidato)
        {
            Candidato = new Candidato();
            Candidato = candidato;
            CandidatoEncontrado = true;
        }
        public CandidatoResponse(string message)
        {
            Message = message;
            CandidatoEncontrado = false;
        }
    }
    public class ConsultaCandidatoResponse
    {
        public List<Candidato> Candidatos { get; set; }
        public string Message { get; set; }
        public bool CandidatoEncontrado { get; set; }

        public ConsultaCandidatoResponse(List<Candidato> candidatos)
        {
            Candidatos = new List<Candidato>();
            Candidatos = candidatos;
            CandidatoEncontrado = true;
        }
        public ConsultaCandidatoResponse(string message)
        {
            Message = message;
            CandidatoEncontrado = false;
        }

    }
}
