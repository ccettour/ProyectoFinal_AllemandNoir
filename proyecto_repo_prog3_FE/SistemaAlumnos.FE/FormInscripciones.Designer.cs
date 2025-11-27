namespace SistemaAlumnos.FE
{
    partial class FormInscripciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInscripciones));
            lblAlumno = new Label();
            cmbMaterias = new ComboBox();
            btnInscribir = new Button();
            dgvMateriasAlumno = new DataGridView();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMateriasAlumno).BeginInit();
            SuspendLayout();
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlumno.Location = new Point(89, 102);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(119, 42);
            lblAlumno.TabIndex = 0;
            lblAlumno.Text = "Alumno";
            lblAlumno.Click += lblAlumno_Click;
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(89, 174);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(281, 28);
            cmbMaterias.TabIndex = 1;
            cmbMaterias.SelectedIndexChanged += cmbMaterias_SelectedIndexChanged;
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = Color.FromArgb(202, 233, 253);
            btnInscribir.Location = new Point(621, 155);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(94, 29);
            btnInscribir.TabIndex = 2;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = false;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // dgvMateriasAlumno
            // 
            dgvMateriasAlumno.BackgroundColor = Color.FromArgb(213, 240, 253);
            dgvMateriasAlumno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMateriasAlumno.Location = new Point(89, 231);
            dgvMateriasAlumno.Name = "dgvMateriasAlumno";
            dgvMateriasAlumno.RowHeadersWidth = 51;
            dgvMateriasAlumno.Size = new Size(626, 139);
            dgvMateriasAlumno.TabIndex = 3;
            dgvMateriasAlumno.CellContentClick += dgvMateriasAlumno_CellContentClick;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(202, 233, 253);
            btnEditar.Location = new Point(621, 85);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(202, 233, 253);
            btnEliminar.Location = new Point(621, 120);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormInscripciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(dgvMateriasAlumno);
            Controls.Add(btnInscribir);
            Controls.Add(cmbMaterias);
            Controls.Add(lblAlumno);
            Name = "FormInscripciones";
            Text = "FormInscripciones";
            Load += FormInscripciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMateriasAlumno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAlumno;
        private ComboBox cmbMaterias;
        private Button btnInscribir;
        private DataGridView dgvMateriasAlumno;
        private Button btnEditar;
        private Button btnEliminar;
    }
}