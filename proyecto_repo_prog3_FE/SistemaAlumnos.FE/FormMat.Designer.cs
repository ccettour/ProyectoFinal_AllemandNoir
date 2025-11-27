namespace SistemaAlumnos.FE
{
    partial class FormMat
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
            Eliminar = new Button();
            Editar = new Button();
            Agregar = new Button();
            NombreMateria = new TextBox();
            dgvMaterias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).BeginInit();
            SuspendLayout();
            // 
            // Eliminar
            // 
            Eliminar.BackColor = Color.FromArgb(171, 221, 245);
            Eliminar.Location = new Point(87, 351);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(260, 29);
            Eliminar.TabIndex = 0;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = false;
            Eliminar.Click += Eliminar_Click;
            // 
            // Editar
            // 
            Editar.BackColor = Color.FromArgb(171, 221, 245);
            Editar.Location = new Point(87, 288);
            Editar.Name = "Editar";
            Editar.Size = new Size(260, 29);
            Editar.TabIndex = 1;
            Editar.Text = "Editar";
            Editar.UseVisualStyleBackColor = false;
            Editar.Click += Editar_Click;
            // 
            // Agregar
            // 
            Agregar.BackColor = Color.FromArgb(171, 221, 245);
            Agregar.Location = new Point(87, 225);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(260, 29);
            Agregar.TabIndex = 2;
            Agregar.Text = "Agregar";
            Agregar.UseVisualStyleBackColor = false;
            Agregar.Click += Agregar_Click;
            // 
            // NombreMateria
            // 
            NombreMateria.Location = new Point(87, 127);
            NombreMateria.Name = "NombreMateria";
            NombreMateria.Size = new Size(260, 27);
            NombreMateria.TabIndex = 3;
            // 
            // dgvMaterias
            // 
            dgvMaterias.BackgroundColor = SystemColors.ControlLight;
            dgvMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterias.Location = new Point(441, 67);
            dgvMaterias.Name = "dgvMaterias";
            dgvMaterias.RowHeadersWidth = 51;
            dgvMaterias.Size = new Size(299, 330);
            dgvMaterias.TabIndex = 4;
            dgvMaterias.CellContentClick += dgvMaterias_CellContentClick;
            // 
            // FormMat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.File_sharing_and_storage_made_simple;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(808, 459);
            Controls.Add(dgvMaterias);
            Controls.Add(NombreMateria);
            Controls.Add(Agregar);
            Controls.Add(Editar);
            Controls.Add(Eliminar);
            Name = "FormMat";
            Text = "FormMat";
            Load += FormMat_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Eliminar;
        private Button Editar;
        private Button Agregar;
        private TextBox NombreMateria;
        private DataGridView dgvMaterias;
    }
}