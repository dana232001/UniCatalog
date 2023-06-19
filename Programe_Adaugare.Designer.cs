namespace Aplicatie
{
    partial class Programe_Adaugare
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
            id_program = new TextBox();
            id_ciclu = new TextBox();
            nume_program = new TextBox();
            button_salvare_adg_program = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 103);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "ID_Program:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 156);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 1;
            label2.Text = "Nume Program:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 202);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "ID_Ciclu:";
            // 
            // id_program
            // 
            id_program.Location = new Point(145, 103);
            id_program.Name = "id_program";
            id_program.Size = new Size(125, 27);
            id_program.TabIndex = 3;
            // 
            // id_ciclu
            // 
            id_ciclu.Location = new Point(145, 195);
            id_ciclu.Name = "id_ciclu";
            id_ciclu.Size = new Size(125, 27);
            id_ciclu.TabIndex = 4;
            // 
            // nume_program
            // 
            nume_program.Location = new Point(145, 153);
            nume_program.Name = "nume_program";
            nume_program.Size = new Size(125, 27);
            nume_program.TabIndex = 5;
            // 
            // button_salvare_adg_program
            // 
            button_salvare_adg_program.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_salvare_adg_program.Location = new Point(111, 276);
            button_salvare_adg_program.Name = "button_salvare_adg_program";
            button_salvare_adg_program.Size = new Size(94, 29);
            button_salvare_adg_program.TabIndex = 6;
            button_salvare_adg_program.Text = "Ok";
            button_salvare_adg_program.UseVisualStyleBackColor = true;
            button_salvare_adg_program.Click += button_salvare_adg_program_Click;
            // 
            // Programe_Adaugare
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(325, 418);
            Controls.Add(button_salvare_adg_program);
            Controls.Add(nume_program);
            Controls.Add(id_ciclu);
            Controls.Add(id_program);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Programe_Adaugare";
            Text = "Programe_Adaugare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox id_program;
        private TextBox id_ciclu;
        private TextBox nume_program;
        private Button button_salvare_adg_program;
    }
}