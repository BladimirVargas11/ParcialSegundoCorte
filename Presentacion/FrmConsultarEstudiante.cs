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
    public partial class FrmConsultarEstudiante : Form
    {
        private EstudianteService estudianteService;
        public FrmConsultarEstudiante()
        {
            InitializeComponent();
            estudianteService = new EstudianteService();
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            Consultar();

        }
        public void Consultar() {
            String categoria = MapearCombo();
            var response = estudianteService.ConsultarPorCategoria(categoria);
            if (response.EstudianteEncontrado)
            {

                TablaEstudiante.DataSource = response.Estudiantes;
                MostrarDatos();

            }
            else
            {
                MessageBox.Show(response.Message, "Informacion Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public string MapearCombo() {
            if (ComboBuscar.Text.Equals("VOTARON"))
            {
                return "SI";
            }
            else if (ComboBuscar.Text.Equals("NO VOTARON"))
            {
                return "NO";
            }
            else if (ComboBuscar.Text.Equals("VOTO EN BLANCO")) 
            {
                return "BLANCO";
            }
            else
            {
                return "TODOS";
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }



        public void MostrarDatos()
        {


            int blanco = estudianteService.ContarVoto("BLANCO");
            int noVotaron = estudianteService.ContarVoto("NO");
            int votaron = estudianteService.ContarVoto("SI");
            int total = blanco + noVotaron + votaron;
            LabelBlanco.Text = blanco.ToString();
            LabelNoVotaron.Text = noVotaron.ToString();
            LabelVotaron.Text = votaron.ToString();
            LabelTotal.Text = total.ToString();


        }
    }
}
