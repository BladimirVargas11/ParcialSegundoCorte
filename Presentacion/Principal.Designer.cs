namespace Presentacion
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BotonConsultareEstudiante = new System.Windows.Forms.Button();
            this.BotonRegistrarVotos = new System.Windows.Forms.Button();
            this.BotonRegistrarCandidato = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Label();
            this.PanelMostrar = new System.Windows.Forms.Panel();
            this.BotonConsultarCandidato = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.BotonConsultarCandidato);
            this.panel1.Controls.Add(this.BotonConsultareEstudiante);
            this.panel1.Controls.Add(this.BotonRegistrarVotos);
            this.panel1.Controls.Add(this.BotonRegistrarCandidato);
            this.panel1.Controls.Add(this.menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 548);
            this.panel1.TabIndex = 0;
            // 
            // BotonConsultareEstudiante
            // 
            this.BotonConsultareEstudiante.Location = new System.Drawing.Point(35, 324);
            this.BotonConsultareEstudiante.Name = "BotonConsultareEstudiante";
            this.BotonConsultareEstudiante.Size = new System.Drawing.Size(125, 47);
            this.BotonConsultareEstudiante.TabIndex = 3;
            this.BotonConsultareEstudiante.Text = "Consultar Estudiante";
            this.BotonConsultareEstudiante.UseVisualStyleBackColor = true;
            this.BotonConsultareEstudiante.Click += new System.EventHandler(this.BotonConsultar_Click);
            // 
            // BotonRegistrarVotos
            // 
            this.BotonRegistrarVotos.Location = new System.Drawing.Point(39, 155);
            this.BotonRegistrarVotos.Name = "BotonRegistrarVotos";
            this.BotonRegistrarVotos.Size = new System.Drawing.Size(116, 47);
            this.BotonRegistrarVotos.TabIndex = 2;
            this.BotonRegistrarVotos.Text = "Registrar Votos";
            this.BotonRegistrarVotos.UseVisualStyleBackColor = true;
            this.BotonRegistrarVotos.Click += new System.EventHandler(this.BotonRegistrarVotos_Click);
            // 
            // BotonRegistrarCandidato
            // 
            this.BotonRegistrarCandidato.Location = new System.Drawing.Point(39, 240);
            this.BotonRegistrarCandidato.Name = "BotonRegistrarCandidato";
            this.BotonRegistrarCandidato.Size = new System.Drawing.Size(116, 47);
            this.BotonRegistrarCandidato.TabIndex = 1;
            this.BotonRegistrarCandidato.Text = "Registrar Candidato";
            this.BotonRegistrarCandidato.UseVisualStyleBackColor = true;
            this.BotonRegistrarCandidato.Click += new System.EventHandler(this.BotonRegistrarCandidato_Click);
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu.Location = new System.Drawing.Point(42, 49);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(96, 37);
            this.menu.TabIndex = 1;
            this.menu.Text = "MENÚ";
            // 
            // PanelMostrar
            // 
            this.PanelMostrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMostrar.Location = new System.Drawing.Point(200, 0);
            this.PanelMostrar.Name = "PanelMostrar";
            this.PanelMostrar.Size = new System.Drawing.Size(731, 548);
            this.PanelMostrar.TabIndex = 1;
            // 
            // BotonConsultarCandidato
            // 
            this.BotonConsultarCandidato.Location = new System.Drawing.Point(39, 398);
            this.BotonConsultarCandidato.Name = "BotonConsultarCandidato";
            this.BotonConsultarCandidato.Size = new System.Drawing.Size(116, 47);
            this.BotonConsultarCandidato.TabIndex = 4;
            this.BotonConsultarCandidato.Text = "Consultar Candidatos";
            this.BotonConsultarCandidato.UseVisualStyleBackColor = true;
            this.BotonConsultarCandidato.Click += new System.EventHandler(this.BotonConsultarCandidato_Click);
            // 
            // Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(931, 548);
            this.Controls.Add(this.PanelMostrar);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(947, 587);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VOTACIONES";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BotonConsultareEstudiante;
        private System.Windows.Forms.Button BotonRegistrarVotos;
        private System.Windows.Forms.Button BotonRegistrarCandidato;
        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.Panel PanelMostrar;
        private System.Windows.Forms.Button BotonConsultarCandidato;
    }
}

