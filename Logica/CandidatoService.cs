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
