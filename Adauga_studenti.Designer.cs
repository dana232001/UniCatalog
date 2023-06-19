namespace Aplicatie
{
    partial class Adauga_studenti
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            id_student = new TextBox();
            nr_matricol = new TextBox();
            nume_student = new TextBox();
            prenume_student = new TextBox();
            initiala_t = new TextBox();
            cnp = new TextBox();
            Data_inscriere = new TextBox();
            id_ciclu = new TextBox();
            medie = new TextBox();
            buton_ok = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 23);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "ID_Student";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 67);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 1;
            label2.Text = "Numar Matricol";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 118);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 2;
            label3.Text = "Nume Student";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 179);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 3;
            label4.Text = "Prenume Student";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 231);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 4;
            label5.Text = "Initiala tatalui";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 273);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 5;
            label6.Text = "CNP";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 317);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 6;
            label7.Text = "Data inscrierii";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 360);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 7;
            label8.Text = "ID_ciclu";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 410);
            label9.Name = "label9";
            label9.Size = new Size(110, 20);
            label9.TabIndex = 8;
            label9.Text = "Media inscriere";
            // 
            // id_student
            // 
            id_student.Location = new Point(189, 23);
            id_student.Name = "id_student";
            id_student.Size = new Size(125, 27);
            id_student.TabIndex = 9;
            // 
            // nr_matricol
            // 
            nr_matricol.Location = new Point(189, 67);
            nr_matricol.Name = "nr_matricol";
            nr_matricol.Size = new Size(125, 27);
            nr_matricol.TabIndex = 10;
            // 
            // nume_student
            // 
            nume_student.Location = new Point(189, 118);
            nume_student.Name = "nume_student";
            nume_student.Size = new Size(125, 27);
            nume_student.TabIndex = 11;
            // 
            // prenume_student
            // 
            prenume_student.Location = new Point(189, 179);
            prenume_student.Name = "prenume_student";
            prenume_student.Size = new Size(125, 27);
            prenume_student.TabIndex = 12;
            // 
            // initiala_t
            // 
            initiala_t.Location = new Point(189, 231);
            initiala_t.Name = "initiala_t";
            initiala_t.Size = new Size(125, 27);
            initiala_t.TabIndex = 13;
            // 
            // cnp
            // 
            cnp.Location = new Point(189, 273);
            cnp.Name = "cnp";
            cnp.Size = new Size(125, 27);
            cnp.TabIndex = 14;
            // 
            // Data_inscriere
            // 
            Data_inscriere.Location = new Point(189, 317);
            Data_inscriere.Name = "Data_inscriere";
            Data_inscriere.Size = new Size(125, 27);
            Data_inscriere.TabIndex = 15;
            // 
            // id_ciclu
            // 
            id_ciclu.Location = new Point(189, 357);
            id_ciclu.Name = "id_ciclu";
            id_ciclu.Size = new Size(125, 27);
            id_ciclu.TabIndex = 16;
            // 
            // medie
            // 
            medie.Location = new Point(189, 403);
            medie.Name = "medie";
            medie.Size = new Size(125, 27);
            medie.TabIndex = 17;
            // 
            // buton_ok
            // 
            buton_ok.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buton_ok.Location = new Point(425, 230);
            buton_ok.Name = "buton_ok";
            buton_ok.Size = new Size(94, 29);
            buton_ok.TabIndex = 18;
            buton_ok.Text = "Ok";
            buton_ok.UseVisualStyleBackColor = true;
            buton_ok.Click += buton_ok_Click;
            // 
            // Adauga_studenti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(618, 505);
            Controls.Add(buton_ok);
            Controls.Add(medie);
            Controls.Add(id_ciclu);
            Controls.Add(Data_inscriere);
            Controls.Add(cnp);
            Controls.Add(initiala_t);
            Controls.Add(prenume_student);
            Controls.Add(nume_student);
            Controls.Add(nr_matricol);
            Controls.Add(id_student);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Adauga_studenti";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adauga_studenti";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox id_student;
        private TextBox nr_matricol;
        private TextBox nume_student;
        private TextBox prenume_student;
        private TextBox initiala_t;
        private TextBox cnp;
        private TextBox Data_inscriere;
        private TextBox id_ciclu;
        private TextBox medie;
        private Button buton_ok;
    }
}