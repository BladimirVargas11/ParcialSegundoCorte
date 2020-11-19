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
            PintarComboTarjetones();
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
                if (estudiante.Voto.Trim().Equals("SI") || estudiante.Voto.Trim().Equals("BLANCO"))
                {
                    MessageBox.Show("El Estudiante Ya ha votado...");

                }
                else {
                    TextBuscarId.Enabled = false;
                    BotonVotar.Enabled = true;
                    ComboCandidato.Enabled = true;
                    TextoNombreEstudiante.Text = estudiante.Nombre;
                    
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
            LimpiarTexto();
        }

        private void BotonVotar_Click(object sender, EventArgs e)
        {
            if (ComboCandidato.SelectedIndex == 0)
            {
                
                MessageBox.Show(VotarEnBlanco());
            }
            else {

                MessageBox.Show(Votar());
            }
            
        }

        private string Votar()
        {
            
            bool voto = serviceEstudiante.Modificar(TextBuscarId.Text,"SI");
            if (voto) {
                Candidato candidato = new Candidato(ComboCandidato.Text, TextoCandidato.Text, 1);
                String messageModificar = serviceCandidato.Modificar(candidato);
                LimpiarTexto();
                return messageModificar;
            }
            else {
                return "El estudiante no se ha encontrado, O el archivo ha sido eliminado... intente nuevamente.";
            }
        }

        private string VotarEnBlanco()
        {
            
            bool voto = serviceEstudiante.Modificar(TextBuscarId.Text, "BLANCO");
            if (voto)
            {
                LimpiarTexto();
                return "El estudiante ha votado en blanco correctamente...";
            }
            else
            {
                return "El estudiante no se ha encontrado, O el archivo ha sido eliminado... intente nuevamente.";
            }
        }

        private void ComboCandidato_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = ComboCandidato.SelectedIndex;
            if (indice == 0) {
                TextoCandidato.Text = ComboCandidato.Items[indice].ToString();
            }
            else {
                indice = indice - 1;
                var response = serviceCandidato.ConsultarPorCategoria("TODOS");
                Candidato candidato = response.Candidatos[indice];
                TextoCandidato.Text = candidato.Nombre;
            }

        }

        private void LimpiarTexto()
        {
            TextoNombreEstudiante.Text = "";
            TextBuscarId.Text = "";
            TextoCandidato.Text = "";
            ComboCandidato.Text = "BLANCO";
            BotonVotar.Enabled = false;
            ComboCandidato.Enabled = false;
            TextBuscarId.Enabled = true;
        }
    }
}
