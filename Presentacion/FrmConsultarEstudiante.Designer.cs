namespace Presentacion
{
    partial class FrmConsultarEstudiante
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
            this.ComboBuscar = new System.Windows.Forms.ComboBox();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.TablaEstudiante = new System.Windows.Forms.DataGridView();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.LabelBlanco = new System.Windows.Forms.Label();
            this.LabelNoVotaron = new System.Windows.Forms.Label();
            this.LabelVotaron = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelTotalEstudiantes = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(46, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consultar por:";
            // 
            // ComboBuscar
            // 
            this.ComboBuscar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBuscar.FormattingEnabled = true;
            this.ComboBuscar.Items.AddRange(new object[] {
            "TODOS",
            "NO VOTARON",
            "VOTARON",
            "VOTO EN BLANCO"});
            this.ComboBuscar.Location = new System.Drawing.Point(50, 87);
            this.ComboBuscar.Name = "ComboBuscar";
            this.ComboBuscar.Size = new System.Drawing.Size(157, 29);
            this.ComboBuscar.TabIndex = 7;
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.ForeColor = System.Drawing.Color.Black;
            this.BotonBuscar.Location = new System.Drawing.Point(238, 87);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(85, 29);
            this.BotonBuscar.TabIndex = 8;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // TablaEstudiante
            // 
            this.TablaEstudiante.AllowUserToAddRows = false;
            this.TablaEstudiante.AllowUserToDeleteRows = false;
            this.TablaEstudiante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaEstudiante.ColumnHeadersHeight = 30;
            this.TablaEstudiante.Location = new System.Drawing.Point(50, 180);
            this.TablaEstudiante.Name = "TablaEstudiante";
            this.TablaEstudiante.ReadOnly = true;
            this.TablaEstudiante.Size = new System.Drawing.Size(642, 328);
            this.TablaEstudiante.TabIndex = 9;
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LabelTotal.Location = new System.Drawing.Point(535, 127);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(19, 21);
            this.LabelTotal.TabIndex = 30;
            this.LabelTotal.Text = "0";
            // 
            // LabelBlanco
            // 
            this.LabelBlanco.AutoSize = true;
            this.LabelBlanco.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBlanco.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LabelBlanco.Location = new System.Drawing.Point(535, 95);
            this.LabelBlanco.Name = "LabelBlanco";
            this.LabelBlanco.Size = new System.Drawing.Size(19, 21);
            this.LabelBlanco.TabIndex = 29;
            this.LabelBlanco.Text = "0";
            // 
            // LabelNoVotaron
            // 
            this.LabelNoVotaron.AutoSize = true;
            this.LabelNoVotaron.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNoVotaron.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LabelNoVotaron.Location = new System.Drawing.Point(535, 63);
            this.LabelNoVotaron.Name = "LabelNoVotaron";
            this.LabelNoVotaron.Size = new System.Drawing.Size(19, 21);
            this.LabelNoVotaron.TabIndex = 28;
            this.LabelNoVotaron.Text = "0";
            // 
            // LabelVotaron
            // 
            this.LabelVotaron.AutoSize = true;
            this.LabelVotaron.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVotaron.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LabelVotaron.Location = new System.Drawing.Point(535, 31);
            this.LabelVotaron.Name = "LabelVotaron";
            this.LabelVotaron.Size = new System.Drawing.Size(19, 21);
            this.LabelVotaron.TabIndex = 27;
            this.LabelVotaron.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(403, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "Total Votaron:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(416, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "No Votaron:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(389, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Votaron Blanco:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(442, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Votaron:";
            // 
            // LabelTotalEstudiantes
            // 
            this.LabelTotalEstudiantes.AutoSize = true;
            this.LabelTotalEstudiantes.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalEstudiantes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LabelTotalEstudiantes.Location = new System.Drawing.Point(666, 518);
            this.LabelTotalEstudiantes.Name = "LabelTotalEstudiantes";
            this.LabelTotalEstudiantes.Size = new System.Drawing.Size(19, 21);
            this.LabelTotalEstudiantes.TabIndex = 32;
            this.LabelTotalEstudiantes.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(525, 518);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Total Estudiantes:";
            // 
            // FrmConsultarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(731, 548);
            this.Controls.Add(this.LabelTotalEstudiantes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.LabelBlanco);
            this.Controls.Add(this.LabelNoVotaron);
            this.Controls.Add(this.LabelVotaron);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TablaEstudiante);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.ComboBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarEstudiante";
            this.Text = "FrmConsultar";
            ((System.ComponentModel.ISupportInitialize)(this.TablaEstudiante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBuscar;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.DataGridView TablaEstudiante;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label LabelBlanco;
        private System.Windows.Forms.Label LabelNoVotaron;
        private System.Windows.Forms.Label LabelVotaron;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelTotalEstudiantes;
        private System.Windows.Forms.Label label7;
    }
}