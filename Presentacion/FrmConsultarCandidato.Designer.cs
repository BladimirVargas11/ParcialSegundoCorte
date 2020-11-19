namespace Presentacion
{
    partial class FrmConsultarCandidato
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
            this.TablaCandidato = new System.Windows.Forms.DataGridView();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.ComboBuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelBlanco = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelGanador = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCandidato)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaCandidato
            // 
            this.TablaCandidato.AllowUserToAddRows = false;
            this.TablaCandidato.AllowUserToDeleteRows = false;
            this.TablaCandidato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaCandidato.ColumnHeadersHeight = 30;
            this.TablaCandidato.Location = new System.Drawing.Point(46, 172);
            this.TablaCandidato.Name = "TablaCandidato";
            this.TablaCandidato.ReadOnly = true;
            this.TablaCandidato.Size = new System.Drawing.Size(642, 328);
            this.TablaCandidato.TabIndex = 13;
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.ForeColor = System.Drawing.Color.Black;
            this.BotonBuscar.Location = new System.Drawing.Point(234, 79);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(85, 29);
            this.BotonBuscar.TabIndex = 12;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // ComboBuscar
            // 
            this.ComboBuscar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBuscar.FormattingEnabled = true;
            this.ComboBuscar.Items.AddRange(new object[] {
            "TODOS",
            "MAYOR VOTOS"});
            this.ComboBuscar.Location = new System.Drawing.Point(46, 79);
            this.ComboBuscar.Name = "ComboBuscar";
            this.ComboBuscar.Size = new System.Drawing.Size(157, 29);
            this.ComboBuscar.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Consultar por:";
            // 
            // LabelBlanco
            // 
            this.LabelBlanco.AutoSize = true;
            this.LabelBlanco.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBlanco.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LabelBlanco.Location = new System.Drawing.Point(524, 59);
            this.LabelBlanco.Name = "LabelBlanco";
            this.LabelBlanco.Size = new System.Drawing.Size(19, 21);
            this.LabelBlanco.TabIndex = 31;
            this.LabelBlanco.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(378, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Votaron Blanco:";
            // 
            // LabelGanador
            // 
            this.LabelGanador.AutoSize = true;
            this.LabelGanador.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGanador.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LabelGanador.Location = new System.Drawing.Point(524, 92);
            this.LabelGanador.Name = "LabelGanador";
            this.LabelGanador.Size = new System.Drawing.Size(57, 21);
            this.LabelGanador.TabIndex = 33;
            this.LabelGanador.Text = "NADIE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(427, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ganador:";
            // 
            // FrmConsultarCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(731, 548);
            this.Controls.Add(this.LabelGanador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelBlanco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TablaCandidato);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.ComboBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarCandidato";
            this.Text = "FrmConsultarCandidato";
            ((System.ComponentModel.ISupportInitialize)(this.TablaCandidato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaCandidato;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.ComboBox ComboBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelBlanco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelGanador;
        private System.Windows.Forms.Label label4;
    }
}