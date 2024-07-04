namespace Presentacion
{
    partial class FrmAsignarEstudianteGrado
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
            this.dtgGrado = new System.Windows.Forms.DataGridView();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.txtNumeroId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarEstudiante = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarGrado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDgrado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgEstudiante = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgConsultaEstudianteAsignadoGrado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaEstudianteAsignadoGrado)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgGrado
            // 
            this.dtgGrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGrado.Location = new System.Drawing.Point(305, 186);
            this.dtgGrado.Name = "dtgGrado";
            this.dtgGrado.Size = new System.Drawing.Size(557, 72);
            this.dtgGrado.TabIndex = 0;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(33, 273);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(863, 62);
            this.btnAsignar.TabIndex = 1;
            this.btnAsignar.Text = "btnAsignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            // 
            // txtNumeroId
            // 
            this.txtNumeroId.Location = new System.Drawing.Point(33, 43);
            this.txtNumeroId.Name = "txtNumeroId";
            this.txtNumeroId.Size = new System.Drawing.Size(248, 20);
            this.txtNumeroId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Introdusca el numero ID del Estudiante";
            // 
            // btnBuscarEstudiante
            // 
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(33, 84);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(248, 46);
            this.btnBuscarEstudiante.TabIndex = 4;
            this.btnBuscarEstudiante.Text = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Grado";
            // 
            // btnBuscarGrado
            // 
            this.btnBuscarGrado.Location = new System.Drawing.Point(33, 212);
            this.btnBuscarGrado.Name = "btnBuscarGrado";
            this.btnBuscarGrado.Size = new System.Drawing.Size(248, 46);
            this.btnBuscarGrado.TabIndex = 6;
            this.btnBuscarGrado.Text = "btnBuscarGrado";
            this.btnBuscarGrado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Introdusca el numero ID del Grado";
            // 
            // txtIDgrado
            // 
            this.txtIDgrado.Location = new System.Drawing.Point(33, 186);
            this.txtIDgrado.Name = "txtIDgrado";
            this.txtIDgrado.Size = new System.Drawing.Size(248, 20);
            this.txtIDgrado.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Estudiante";
            // 
            // dtgEstudiante
            // 
            this.dtgEstudiante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEstudiante.Location = new System.Drawing.Point(305, 43);
            this.dtgEstudiante.Name = "dtgEstudiante";
            this.dtgEstudiante.Size = new System.Drawing.Size(557, 87);
            this.dtgEstudiante.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Consulta del Estudiante Asignado al Grado";
            // 
            // dtgConsultaEstudianteAsignadoGrado
            // 
            this.dtgConsultaEstudianteAsignadoGrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultaEstudianteAsignadoGrado.Location = new System.Drawing.Point(45, 375);
            this.dtgConsultaEstudianteAsignadoGrado.Name = "dtgConsultaEstudianteAsignadoGrado";
            this.dtgConsultaEstudianteAsignadoGrado.Size = new System.Drawing.Size(833, 72);
            this.dtgConsultaEstudianteAsignadoGrado.TabIndex = 11;
            // 
            // FrmAsignarEstudianteGrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 477);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgConsultaEstudianteAsignadoGrado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgEstudiante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDgrado);
            this.Controls.Add(this.btnBuscarGrado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarEstudiante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroId);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.dtgGrado);
            this.Name = "FrmAsignarEstudianteGrado";
            this.Text = "FrmAsignarEstudianteGrado";
            this.Load += new System.EventHandler(this.FrmAsignarEstudianteGrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaEstudianteAsignadoGrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgGrado;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.TextBox txtNumeroId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarEstudiante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarGrado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDgrado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgEstudiante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgConsultaEstudianteAsignadoGrado;
    }
}