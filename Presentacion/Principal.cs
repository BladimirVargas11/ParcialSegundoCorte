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
    public partial class Principal : Form
    {
        private EstudianteService estudianteService;
        public Principal()
        {
            InitializeComponent();
            estudianteService = new EstudianteService();
            
        }
        
        private void BotonRegistrarVotos_Click(object sender, EventArgs e)
        {
            AbrirContenido(new FrmRegistrarVotos());
        }
        public void AbrirContenido(object ventana)
        {

            if (PanelMostrar.Controls.Count > 0) PanelMostrar.Controls.RemoveAt(0);
            ValidarEntrada();
            Form contenido = ventana as Form;
            contenido.TopLevel = false;
            contenido.Dock = DockStyle.Fill;
            this.PanelMostrar.Controls.Add(contenido);
            this.PanelMostrar.Tag = contenido;
            contenido.Show();
        }
        public void ValidarEntrada()
        {
            var response = estudianteService.ConsultarPorCategoria("TODOS");
            if (response.Estudiantes.Count() == 0)
            {
                MessageBox.Show("El archivo Estudiante está Vacio.");
                Application.Exit();
            }
        }

        private void BotonConsultar_Click(object sender, EventArgs e)
        {
            AbrirContenido(new FrmConsultarEstudiante());
        }

        private void BotonRegistrarCandidato_Click(object sender, EventArgs e)
        {
            AbrirContenido(new FrmRegistrarCandidato());
        }

        private void BotonConsultarCandidato_Click(object sender, EventArgs e)
        {
            AbrirContenido(new FrmConsultarCandidato());
        }
    }
}
