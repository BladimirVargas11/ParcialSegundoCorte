using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        
        private void BotonRegistrarVotos_Click(object sender, EventArgs e)
        {
            AbrirContenido(new FrmRegistrarVotos());
        }
        public void AbrirContenido(object ventana)
        {
            if (PanelMostrar.Controls.Count > 0) PanelMostrar.Controls.RemoveAt(0);

            Form contenido = ventana as Form;
            contenido.TopLevel = false;
            contenido.Dock = DockStyle.Fill;
            this.PanelMostrar.Controls.Add(contenido);
            this.PanelMostrar.Tag = contenido;
            contenido.Show();
        }

        private void BotonConsultar_Click(object sender, EventArgs e)
        {
            AbrirContenido(new FrmConsultar());
        }

        private void BotonRegistrarCandidato_Click(object sender, EventArgs e)
        {
            AbrirContenido(new FrmRegistrarCandidato());
        }
    }
}
