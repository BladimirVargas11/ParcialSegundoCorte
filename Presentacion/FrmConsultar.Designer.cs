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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelVotaron = new System.Windows.Forms.Label();
            this.LabelNoVotaron = new System.Windows.Forms.Label();
            this.LabelTotalVotaron = new System.Windows.Forms.Label();
            this.BotonVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEstudiante)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            "VOTARON"});
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BotonVer);
            this.groupBox1.Controls.Add(this.LabelTotalVotaron);
            this.groupBox1.Controls.Add(this.LabelNoVotaron);
            this.groupBox1.Controls.Add(this.LabelVotaron);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(418, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 142);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "VOTARON:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "NO VOTARON:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "TOTAL VOTARON:";
            // 
            // LabelVotaron
            // 
            this.LabelVotaron.AutoSize = true;
            this.LabelVotaron.Location = new System.Drawing.Point(152, 33);
            this.LabelVotaron.Name = "LabelVotaron";
            this.LabelVotaron.Size = new System.Drawing.Size(15, 17);
            this.LabelVotaron.TabIndex = 3;
            this.LabelVotaron.Text = "0";
            // 
            // LabelNoVotaron
            // 
            this.LabelNoVotaron.AutoSize = true;
            this.LabelNoVotaron.Location = new System.Drawing.Point(152, 72);
            this.LabelNoVotaron.Name = "LabelNoVotaron";
            this.LabelNoVotaron.Size = new System.Drawing.Size(15, 17);
            this.LabelNoVotaron.TabIndex = 4;
            this.LabelNoVotaron.Text = "0";
            // 
            // LabelTotalVotaron
            // 
            this.LabelTotalVotaron.AutoSize = true;
            this.LabelTotalVotaron.Location = new System.Drawing.Point(152, 111);
            this.LabelTotalVotaron.Name = "LabelTotalVotaron";
            this.LabelTotalVotaron.Size = new System.Drawing.Size(15, 17);
            this.LabelTotalVotaron.TabIndex = 5;
            this.LabelTotalVotaron.Text = "0";
            // 
            // BotonVer
            // 
            this.BotonVer.ForeColor = System.Drawing.Color.Black;
            this.BotonVer.Location = new System.Drawing.Point(183, 99);
            this.BotonVer.Name = "BotonVer";
            this.BotonVer.Size = new System.Drawing.Size(85, 29);
            this.BotonVer.TabIndex = 11;
            this.BotonVer.Text = "VER";
            this.BotonVer.UseVisualStyleBackColor = true;
            this.BotonVer.Click += new System.EventHandler(this.BotonVer_Click);
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(731, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TablaEstudiante);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.ComboBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultar";
            this.Text = "FrmConsultar";
            ((System.ComponentModel.ISupportInitialize)(this.TablaEstudiante)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBuscar;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.DataGridView TablaEstudiante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelTotalVotaron;
        private System.Windows.Forms.Label LabelNoVotaron;
        private System.Windows.Forms.Label LabelVotaron;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BotonVer;
    }
}