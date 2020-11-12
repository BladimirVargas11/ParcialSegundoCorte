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
            String categoria = MapearCombo();
            var response = estudianteService.ConsultarPorCategoria(categoria);
            if (response.EstudianteEncontrado)
            {

                TablaEstudiante.DataSource = response.Estudiantes;
                

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
            else {
                return "TODOS";
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BotonVer_Click(object sender, EventArgs e)
        {
            Array[] array = (Array[])estudianteService.Datos();

            

        }
    }
}
