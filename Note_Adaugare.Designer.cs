namespace Aplicatie
{
    partial class Note_Adaugare
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
            textBox_catalog = new TextBox();
            textBox_student = new TextBox();
            textBox_disciplina = new TextBox();
            textBox_nota = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button_adaugare = new Button();
            SuspendLayout();
            // 
            // textBox_catalog
            // 
            textBox_catalog.Location = new Point(109, 31);
            textBox_catalog.Name = "textBox_catalog";
            textBox_catalog.Size = new Size(125, 27);
            textBox_catalog.TabIndex = 0;
            // 
            // textBox_student
            // 
            textBox_student.Location = new Point(109, 84);
            textBox_student.Name = "textBox_student";
            textBox_student.Size = new Size(125, 27);
            textBox_student.TabIndex = 1;
            // 
            // textBox_disciplina
            // 
            textBox_disciplina.Location = new Point(109, 137);
            textBox_disciplina.Name = "textBox_disciplina";
            textBox_disciplina.Size = new Size(125, 27);
            textBox_disciplina.TabIndex = 2;
            // 
            // textBox_nota
            // 
            textBox_nota.Location = new Point(109, 190);
            textBox_nota.Name = "textBox_nota";
            textBox_nota.Size = new Size(125, 27);
            textBox_nota.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 8);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 4;
            label1.Text = "ID Catalog";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 61);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 5;
            label2.Text = "ID Student";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 114);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 6;
            label3.Text = "ID Disciplina";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 167);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 7;
            label4.Text = "Nota";
            // 
            // button_adaugare
            // 
            button_adaugare.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_adaugare.Location = new Point(109, 227);
            button_adaugare.Name = "button_adaugare";
            button_adaugare.Size = new Size(125, 57);
            button_adaugare.TabIndex = 8;
            button_adaugare.Text = "Adaugare nota";
            button_adaugare.UseVisualStyleBackColor = true;
            button_adaugare.Click += button_adaugare_Click;
            // 
            // Note_Adaugare
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(336, 296);
            Controls.Add(button_adaugare);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_nota);
            Controls.Add(textBox_disciplina);
            Controls.Add(textBox_student);
            Controls.Add(textBox_catalog);
            Name = "Note_Adaugare";
            Text = "Note_Adaugare";
            Load += Note_Adaugare_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_catalog;
        private TextBox textBox_student;
        private TextBox textBox_disciplina;
        private TextBox textBox_nota;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button_adaugare;
    }
}