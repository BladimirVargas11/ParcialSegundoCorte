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
    public partial class FrmRegistrarCandidato : Form
    {
        private CandidatoService serviceCandidato;
        public FrmRegistrarCandidato()
        {
            InitializeComponent();
            serviceCandidato = new CandidatoService();
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            string mensaje = Guardar();
            MessageBox.Show(mensaje);
            LimpiarTexto();
        }
        private void LimpiarTexto()
        {
            TextNombre.Text = "";
            TextoTarjeton.ResetText();
        }
        private string Guardar()
        {
            if (ValidarTextosVacios())
            {
                Candidato candidato = MapearTextoACandidato();
                string mensaje = serviceCandidato.Guardar(candidato);
                return mensaje;
            }
            else
            {
                return "Los datos suministrados están incompletos";
            }
        }

        private bool ValidarTextosVacios()
        {
            
            foreach (Control x in this.Controls)
            {
                if (x is TextBox && x.Name != "txtPulsacion")
                {
                    if (String.IsNullOrEmpty(((TextBox)x).Text))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private Candidato MapearTextoACandidato()
        {
            Candidato candidato = new Candidato(TextoTarjeton.Value+"", TextNombre.Text, 0);
            return candidato;
        }

    }
}
