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
        private EstudianteService serviceEstudiante;
        public FrmRegistrarVotos()
        {
            InitializeComponent();
            serviceCandidato = new CandidatoService();
            serviceEstudiante = new EstudianteService();
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (TextoVacio())
            {
                ConsultarEstudiante();
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

        private void ConsultarEstudiante()
        {
            Estudiante estudiante = new Estudiante();
            serviceEstudiante = new EstudianteService();

            EstudianteResponse estudianteResponse = serviceEstudiante.BuscarPorId(TextBuscarId.Text);

            if (estudianteResponse.EstudianteEncontrado == true)
            {

                estudiante = estudianteResponse.Estudiante;
                if (estudiante.Voto.Equals("SI"))
                {
                    MessageBox.Show("El Estudiante Ya ha votado...");

                }
                else {

                    BotonVotar.Enabled = true;
                    ComboCandidato.Enabled = true;
                    TextoNombre.Text = estudiante.Nombre;
                    PintarComboTarjetones();
                }



            }
            else
            {
                MessageBox.Show(estudianteResponse.Message);
            }

        }

        private void PintarComboTarjetones() {

            serviceCandidato = new CandidatoService();
            var response = serviceCandidato.ConsultarTodos();
            List<Candidato> candidatos = response.Candidatos;

            foreach (var item in candidatos) 
            {
                ComboCandidato.Items.Add(item.Tarjeton);
            
            }


        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            
        }

        private void BotonVotar_Click(object sender, EventArgs e)
        {

        }
    }
}
