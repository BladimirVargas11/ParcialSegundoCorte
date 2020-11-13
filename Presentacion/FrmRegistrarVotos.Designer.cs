namespace Presentacion
{
    partial class FrmRegistrarVotos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TextBuscarId = new System.Windows.Forms.TextBox();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboCandidato = new System.Windows.Forms.ComboBox();
            this.BotonLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextoNombre = new System.Windows.Forms.TextBox();
            this.Votacion = new System.Windows.Forms.GroupBox();
            this.BotonVotar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Votacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(57, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificacion:";
            // 
            // TextBuscarId
            // 
            this.TextBuscarId.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBuscarId.Location = new System.Drawing.Point(201, 25);
            this.TextBuscarId.Name = "TextBuscarId";
            this.TextBuscarId.Size = new System.Drawing.Size(126, 29);
            this.TextBuscarId.TabIndex = 2;
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.ForeColor = System.Drawing.Color.Black;
            this.BotonBuscar.Location = new System.Drawing.Point(425, 22);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(85, 29);
            this.BotonBuscar.TabIndex = 3;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(17, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Candidato a Votar:";
            // 
            // ComboCandidato
            // 
            this.ComboCandidato.Enabled = false;
            this.ComboCandidato.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboCandidato.FormattingEnabled = true;
            this.ComboCandidato.Location = new System.Drawing.Point(201, 45);
            this.ComboCandidato.Name = "ComboCandidato";
            this.ComboCandidato.Size = new System.Drawing.Size(126, 29);
            this.ComboCandidato.TabIndex = 6;
            // 
            // BotonLimpiar
            // 
            this.BotonLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BotonLimpiar.Location = new System.Drawing.Point(425, 95);
            this.BotonLimpiar.Name = "BotonLimpiar";
            this.BotonLimpiar.Size = new System.Drawing.Size(85, 29);
            this.BotonLimpiar.TabIndex = 7;
            this.BotonLimpiar.Text = "Limpiar";
            this.BotonLimpiar.UseVisualStyleBackColor = true;
            this.BotonLimpiar.Click += new System.EventHandler(this.BotonLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BotonLimpiar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextoNombre);
            this.groupBox1.Controls.Add(this.TextBuscarId);
            this.groupBox1.Controls.Add(this.BotonBuscar);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(46, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 163);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(17, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Del Votante:";
            // 
            // TextoNombre
            // 
            this.TextoNombre.Enabled = false;
            this.TextoNombre.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoNombre.Location = new System.Drawing.Point(201, 94);
            this.TextoNombre.Name = "TextoNombre";
            this.TextoNombre.Size = new System.Drawing.Size(218, 29);
            this.TextoNombre.TabIndex = 5;
            // 
            // Votacion
            // 
            this.Votacion.Controls.Add(this.BotonVotar);
            this.Votacion.Controls.Add(this.label3);
            this.Votacion.Controls.Add(this.ComboCandidato);
            this.Votacion.ForeColor = System.Drawing.Color.Gainsboro;
            this.Votacion.Location = new System.Drawing.Point(46, 253);
            this.Votacion.Name = "Votacion";
            this.Votacion.Size = new System.Drawing.Size(584, 144);
            this.Votacion.TabIndex = 9;
            this.Votacion.TabStop = false;
            this.Votacion.Text = "Votar";
            // 
            // BotonVotar
            // 
            this.BotonVotar.Enabled = false;
            this.BotonVotar.ForeColor = System.Drawing.Color.Black;
            this.BotonVotar.Location = new System.Drawing.Point(460, 98);
            this.BotonVotar.Name = "BotonVotar";
            this.BotonVotar.Size = new System.Drawing.Size(85, 29);
            this.BotonVotar.TabIndex = 8;
            this.BotonVotar.Text = "Votar";
            this.BotonVotar.UseVisualStyleBackColor = true;
            this.BotonVotar.Click += new System.EventHandler(this.BotonVotar_Click);
            // 
            // FrmRegistrarVotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(731, 548);
            this.Controls.Add(this.Votacion);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarVotos";
            this.Text = "FrmRegistrarVotos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Votacion.ResumeLayout(false);
            this.Votacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBuscarId;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboCandidato;
        private System.Windows.Forms.Button BotonLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextoNombre;
        private System.Windows.Forms.GroupBox Votacion;
        private System.Windows.Forms.Button BotonVotar;
    }
}