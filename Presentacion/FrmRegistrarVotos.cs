using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class FrmRegistrarVotos : Form
    {
        private CandidatoService serviceCandidato;
        public FrmRegistrarVotos()
        {
            InitializeComponent();
            serviceCandidato = new CandidatoService();
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (TextoVacio())
            {
                //ConsultarCandidato();
            }
            else
            {
                MessageBox.Show("Introdusca una identificacion a buscar");
            }
        }
        private bool TextoVacio()
        {

            if (String.IsNullOrEmpty(((TextBox)TextBuscarId).Text))
            {

                return false;

            }
            else
            {

                return true;

            }

        }

        private void ConsultarVotante()
        {
            Candidato candidato = new Candidato();
            serviceCandidato = new CandidatoService();

            CandidatoResponse candidatoResponse = serviceCandidato.BuscarPorTarjeton(TextBuscarId.Text);

            if (candidatoResponse.CandidatoEncontrado == true)
            {
                candidato = candidatoResponse.Candidato;
                BotonVotar.Enabled = false;
                ComboCandidato.Enabled = false;
                

            }
            else
            {
                MessageBox.Show(candidatoResponse.Message);
            }

        }
    }
}
