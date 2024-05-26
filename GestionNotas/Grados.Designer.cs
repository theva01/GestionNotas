namespace GestionNotas
{
    partial class Grados
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
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            btnConsultar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            txNombre = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            btnRegistrar = new Button();
            label7 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(227, -1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(596, 495);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 15);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(584, 473);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(txNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(12, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 350);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(19, 66);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(166, 47);
            btnConsultar.TabIndex = 15;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(19, 296);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(166, 44);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(19, 245);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(166, 45);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // txNombre
            // 
            txNombre.Location = new Point(19, 144);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(166, 23);
            txNombre.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 126);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 5;
            label3.Text = "Nombre Grado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(19, 192);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(166, 47);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 19);
            label7.Name = "label7";
            label7.Size = new Size(123, 15);
            label7.TabIndex = 0;
            label7.Text = "Estudiantes por Grado";
            // 
            // Grados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 499);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Grados";
            Text = "Grados";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btnConsultar;
        private Button btnEliminar;
        private Button btnActualizar;
        private TextBox txNombre;
        private Label label3;
        private TextBox textBox1;
        private Button btnRegistrar;
        private Label label7;
    }
}