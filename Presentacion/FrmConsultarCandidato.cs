using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace Presentacion
{
    public partial class FrmConsultarCandidato : Form
    {
        private CandidatoService candidatoService;
        private EstudianteService estudianteService;
        public FrmConsultarCandidato()
        {
            InitializeComponent();
            candidatoService = new CandidatoService();
            estudianteService = new EstudianteService();
            


        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        public void Consultar()
        {
            String categoria = MapearCombo();
            var response = candidatoService.ConsultarPorCategoria(categoria);
            if (response.CandidatoEncontrado)
            {

                TablaCandidato.DataSource = response.Candidatos;
                int blanco = estudianteService.ContarVoto("BLANCO");
                LabelBlanco.Text = blanco.ToString();
                var candidatoResponse = candidatoService.ConsultarGanador();
                if (candidatoResponse.CandidatoEncontrado)
                {
                    LabelGanador.Text = candidatoResponse.Candidato.Nombre;
                }

                
                


            }
            else
            {
                MessageBox.Show(response.Message, "Informacion Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        public string MapearCombo()
        {
            if (ComboBuscar.Text.Equals("MAYOR VOTOS"))
            {
                return "VOTOS";
            }
            else
            {
                return "TODOS";
            }
        }


    }
}
