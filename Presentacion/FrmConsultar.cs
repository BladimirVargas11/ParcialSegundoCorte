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
    public partial class FrmConsultar : Form
    {
        private EstudianteService estudianteService;
        public FrmConsultar()
        {
            InitializeComponent();
            estudianteService = new EstudianteService();
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            var response = estudianteService.ConsultarTodos();
            if (response.EstudianteEncontrado)
            {

                TablaEstudiante.DataSource = response.Estudiantes;

            }
            else
            {
                MessageBox.Show(response.Message, "Informacion Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
