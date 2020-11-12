namespace Presentacion
{
    partial class FrmConsultar
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
            ((System.ComponentModel.ISupportInitialize)(this.TablaEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(67, 89);
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
            "VOTARON"});
            this.ComboBuscar.Location = new System.Drawing.Point(215, 89);
            this.ComboBuscar.Name = "ComboBuscar";
            this.ComboBuscar.Size = new System.Drawing.Size(157, 29);
            this.ComboBuscar.TabIndex = 7;
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.ForeColor = System.Drawing.Color.Black;
            this.BotonBuscar.Location = new System.Drawing.Point(410, 87);
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
            this.TablaEstudiante.Size = new System.Drawing.Size(587, 301);
            this.TablaEstudiante.TabIndex = 9;
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(731, 548);
            this.Controls.Add(this.TablaEstudiante);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.ComboBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultar";
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
    }
}