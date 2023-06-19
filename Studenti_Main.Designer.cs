namespace Aplicatie
{
    partial class Studenti_Main
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
            dataGridView1 = new DataGridView();
            ID_Student = new DataGridViewTextBoxColumn();
            NumarMatricol = new DataGridViewTextBoxColumn();
            Nume_Student = new DataGridViewTextBoxColumn();
            Prenume_Student = new DataGridViewTextBoxColumn();
            InitialaTata = new DataGridViewTextBoxColumn();
            CNP = new DataGridViewTextBoxColumn();
            Data_Inscrierii = new DataGridViewTextBoxColumn();
            ID_ciclu = new DataGridViewTextBoxColumn();
            Media_Inscriere = new DataGridViewTextBoxColumn();
            buton_adauga = new Button();
            buton_sterge = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID_Student, NumarMatricol, Nume_Student, Prenume_Student, InitialaTata, CNP, Data_Inscrierii, ID_ciclu, Media_Inscriere });
            dataGridView1.Location = new Point(12, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1178, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID_Student
            // 
            ID_Student.HeaderText = "Id_student";
            ID_Student.MinimumWidth = 6;
            ID_Student.Name = "ID_Student";
            ID_Student.Width = 125;
            // 
            // NumarMatricol
            // 
            NumarMatricol.HeaderText = "NumarMatricol";
            NumarMatricol.MinimumWidth = 6;
            NumarMatricol.Name = "NumarMatricol";
            NumarMatricol.Width = 125;
            // 
            // Nume_Student
            // 
            Nume_Student.HeaderText = "Nume_Student";
            Nume_Student.MinimumWidth = 6;
            Nume_Student.Name = "Nume_Student";
            Nume_Student.Width = 125;
            // 
            // Prenume_Student
            // 
            Prenume_Student.HeaderText = "Prenume_Student";
            Prenume_Student.MinimumWidth = 6;
            Prenume_Student.Name = "Prenume_Student";
            Prenume_Student.Width = 125;
            // 
            // InitialaTata
            // 
            InitialaTata.HeaderText = "InitialaTata";
            InitialaTata.MinimumWidth = 6;
            InitialaTata.Name = "InitialaTata";
            InitialaTata.Width = 125;
            // 
            // CNP
            // 
            CNP.HeaderText = "CNP";
            CNP.MinimumWidth = 6;
            CNP.Name = "CNP";
            CNP.Width = 125;
            // 
            // Data_Inscrierii
            // 
            Data_Inscrierii.HeaderText = "Data_Inscrierii";
            Data_Inscrierii.MinimumWidth = 6;
            Data_Inscrierii.Name = "Data_Inscrierii";
            Data_Inscrierii.Width = 125;
            // 
            // ID_ciclu
            // 
            ID_ciclu.HeaderText = "ID_ciclu";
            ID_ciclu.MinimumWidth = 6;
            ID_ciclu.Name = "ID_ciclu";
            ID_ciclu.Width = 125;
            // 
            // Media_Inscriere
            // 
            Media_Inscriere.HeaderText = "Media_Inscriere";
            Media_Inscriere.MinimumWidth = 6;
            Media_Inscriere.Name = "Media_Inscriere";
            Media_Inscriere.Width = 125;
            // 
            // buton_adauga
            // 
            buton_adauga.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buton_adauga.Location = new Point(380, 240);
            buton_adauga.Name = "buton_adauga";
            buton_adauga.Size = new Size(124, 58);
            buton_adauga.TabIndex = 1;
            buton_adauga.Text = "Adauga Student";
            buton_adauga.UseVisualStyleBackColor = true;
            buton_adauga.Click += button1_Click;
            // 
            // buton_sterge
            // 
            buton_sterge.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buton_sterge.Location = new Point(657, 240);
            buton_sterge.Name = "buton_sterge";
            buton_sterge.Size = new Size(124, 58);
            buton_sterge.TabIndex = 2;
            buton_sterge.Text = "Sterge Student";
            buton_sterge.UseVisualStyleBackColor = true;
            buton_sterge.Click += buton_sterge_Click;
            // 
            // Studenti_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1222, 366);
            Controls.Add(buton_sterge);
            Controls.Add(buton_adauga);
            Controls.Add(dataGridView1);
            Name = "Studenti_Main";
            Text = "Studenti_Main";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID_Student;
        private DataGridViewTextBoxColumn NumarMatricol;
        private DataGridViewTextBoxColumn Nume_Student;
        private DataGridViewTextBoxColumn Prenume_Student;
        private DataGridViewTextBoxColumn InitialaTata;
        private DataGridViewTextBoxColumn CNP;
        private DataGridViewTextBoxColumn Data_Inscrierii;
        private DataGridViewTextBoxColumn ID_ciclu;
        private DataGridViewTextBoxColumn Media_Inscriere;
        private Button buton_adauga;
        private Button buton_sterge;
    }
}