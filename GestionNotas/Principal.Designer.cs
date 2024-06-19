namespace GestionNotas
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnReportes = new Button();
            btnGrados = new Button();
            btnAsignaturas = new Button();
            btnNotas = new Button();
            btnDocentes = new Button();
            btnEstudiantes = new Button();
            panelLogo = new Panel();
            pcbLogo = new PictureBox();
            label1 = new Label();
            panelPrincipal = new Panel();
            label2 = new Label();
            button7 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(53, 10, 6);
            panelMenu.Controls.Add(btnReportes);
            panelMenu.Controls.Add(btnGrados);
            panelMenu.Controls.Add(btnAsignaturas);
            panelMenu.Controls.Add(btnNotas);
            panelMenu.Controls.Add(btnDocentes);
            panelMenu.Controls.Add(btnEstudiantes);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(190, 627);
            panelMenu.TabIndex = 0;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 9.75F);
            btnReportes.ForeColor = Color.PapayaWhip;
            btnReportes.Image = Properties.Resources.Pie_Chart_Report;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(0, 410);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(190, 50);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnGrados
            // 
            btnGrados.Dock = DockStyle.Top;
            btnGrados.FlatAppearance.BorderSize = 0;
            btnGrados.FlatStyle = FlatStyle.Flat;
            btnGrados.Font = new Font("Segoe UI", 9.75F);
            btnGrados.ForeColor = Color.PapayaWhip;
            btnGrados.Image = Properties.Resources.Room;
            btnGrados.ImageAlign = ContentAlignment.MiddleLeft;
            btnGrados.Location = new Point(0, 360);
            btnGrados.Name = "btnGrados";
            btnGrados.Size = new Size(190, 50);
            btnGrados.TabIndex = 6;
            btnGrados.Text = "Grados";
            btnGrados.UseVisualStyleBackColor = true;
            btnGrados.Click += btnGrados_Click;
            // 
            // btnAsignaturas
            // 
            btnAsignaturas.Dock = DockStyle.Top;
            btnAsignaturas.FlatAppearance.BorderSize = 0;
            btnAsignaturas.FlatStyle = FlatStyle.Flat;
            btnAsignaturas.Font = new Font("Segoe UI", 9.75F);
            btnAsignaturas.ForeColor = Color.PapayaWhip;
            btnAsignaturas.Image = Properties.Resources.Math_Folder;
            btnAsignaturas.ImageAlign = ContentAlignment.MiddleLeft;
            btnAsignaturas.Location = new Point(0, 310);
            btnAsignaturas.Name = "btnAsignaturas";
            btnAsignaturas.Size = new Size(190, 50);
            btnAsignaturas.TabIndex = 5;
            btnAsignaturas.Text = "Asignaturas";
            btnAsignaturas.UseVisualStyleBackColor = true;
            // 
            // btnNotas
            // 
            btnNotas.Dock = DockStyle.Top;
            btnNotas.FlatAppearance.BorderSize = 0;
            btnNotas.FlatStyle = FlatStyle.Flat;
            btnNotas.Font = new Font("Segoe UI", 9.75F);
            btnNotas.ForeColor = Color.PapayaWhip;
            btnNotas.Image = Properties.Resources.Task;
            btnNotas.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotas.Location = new Point(0, 260);
            btnNotas.Name = "btnNotas";
            btnNotas.Size = new Size(190, 50);
            btnNotas.TabIndex = 4;
            btnNotas.Text = "Notas";
            btnNotas.UseVisualStyleBackColor = true;
            // 
            // btnDocentes
            // 
            btnDocentes.Dock = DockStyle.Top;
            btnDocentes.FlatAppearance.BorderSize = 0;
            btnDocentes.FlatStyle = FlatStyle.Flat;
            btnDocentes.Font = new Font("Segoe UI", 9.75F);
            btnDocentes.ForeColor = Color.PapayaWhip;
            btnDocentes.Image = Properties.Resources.Teacher;
            btnDocentes.ImageAlign = ContentAlignment.MiddleLeft;
            btnDocentes.Location = new Point(0, 210);
            btnDocentes.Name = "btnDocentes";
            btnDocentes.Size = new Size(190, 50);
            btnDocentes.TabIndex = 3;
            btnDocentes.Text = "Doncentes";
            btnDocentes.UseVisualStyleBackColor = true;
            // 
            // btnEstudiantes
            // 
            btnEstudiantes.Dock = DockStyle.Top;
            btnEstudiantes.FlatAppearance.BorderSize = 0;
            btnEstudiantes.FlatStyle = FlatStyle.Flat;
            btnEstudiantes.Font = new Font("Segoe UI", 9.75F);
            btnEstudiantes.ForeColor = Color.PapayaWhip;
            btnEstudiantes.Image = Properties.Resources.student;
            btnEstudiantes.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstudiantes.Location = new Point(0, 160);
            btnEstudiantes.Name = "btnEstudiantes";
            btnEstudiantes.Size = new Size(190, 50);
            btnEstudiantes.TabIndex = 2;
            btnEstudiantes.Text = "Estudiantes";
            btnEstudiantes.UseVisualStyleBackColor = true;
            btnEstudiantes.Click += btnEstudiantes_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pcbLogo);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(190, 160);
            panelLogo.TabIndex = 0;
            // 
            // pcbLogo
            // 
            pcbLogo.BackColor = Color.FromArgb(53, 10, 6);
            pcbLogo.Image = Properties.Resources.Graduation_Cap;
            pcbLogo.Location = new Point(6, 12);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(181, 133);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 0;
            pcbLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(53, 10, 6);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PapayaWhip;
            label1.Location = new Point(0, 136);
            label1.Name = "label1";
            label1.Size = new Size(192, 21);
            label1.TabIndex = 1;
            label1.Text = "__________________________";
            label1.Click += label1_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.PapayaWhip;
            panelPrincipal.Controls.Add(label2);
            panelPrincipal.Controls.Add(button7);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(190, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(910, 627);
            panelPrincipal.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(353, 337);
            label2.Name = "label2";
            label2.Size = new Size(263, 65);
            label2.TabIndex = 0;
            label2.Text = "Bienvenido";
            // 
            // button7
            // 
            button7.BackColor = Color.PapayaWhip;
            button7.Image = Properties.Resources.Graduation_Scroll;
            button7.Location = new Point(386, 199);
            button7.Name = "button7";
            button7.Size = new Size(200, 174);
            button7.TabIndex = 1;
            button7.UseVisualStyleBackColor = false;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(1100, 627);
            Controls.Add(panelPrincipal);
            Controls.Add(panelMenu);
            ForeColor = SystemColors.ActiveBorder;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de Notas";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Panel panelPrincipal;
        private PictureBox pcbLogo;
        private Label label1;
        private Button btnEstudiantes;
        private Button btnReportes;
        private Button btnGrados;
        private Button btnAsignaturas;
        private Button btnNotas;
        private Button btnDocentes;
        private Button button7;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
