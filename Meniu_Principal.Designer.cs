namespace Aplicatie
{
    partial class Meniu_Principal
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
            Cicluri_inv_buton = new Button();
            _studii_buton = new Button();
            Anii_studiu_buton = new Button();
            Discipline_buton = new Button();
            Studenti_buton = new Button();
            Grupe_buton = new Button();
            Cadre_buton = new Button();
            Note_buton = new Button();
            SuspendLayout();
            // 
            // Cicluri_inv_buton
            // 
            Cicluri_inv_buton.BackColor = Color.White;
            Cicluri_inv_buton.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Cicluri_inv_buton.Location = new Point(48, 120);
            Cicluri_inv_buton.Name = "Cicluri_inv_buton";
            Cicluri_inv_buton.Size = new Size(141, 49);
            Cicluri_inv_buton.TabIndex = 0;
            Cicluri_inv_buton.Text = "Cicluri de invatamant";
            Cicluri_inv_buton.UseVisualStyleBackColor = false;
            Cicluri_inv_buton.Click += Cicluri_inv_buton_Click;
            // 
            // _studii_buton
            // 
            _studii_buton.BackColor = Color.White;
            _studii_buton.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            _studii_buton.Location = new Point(227, 120);
            _studii_buton.Name = "_studii_buton";
            _studii_buton.Size = new Size(141, 49);
            _studii_buton.TabIndex = 1;
            _studii_buton.Text = "Programe de studii";
            _studii_buton.UseVisualStyleBackColor = false;
            _studii_buton.Click += _studii_buton_Click;
            // 
            // Anii_studiu_buton
            // 
            Anii_studiu_buton.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Anii_studiu_buton.Location = new Point(401, 120);
            Anii_studiu_buton.Name = "Anii_studiu_buton";
            Anii_studiu_buton.Size = new Size(141, 45);
            Anii_studiu_buton.TabIndex = 2;
            Anii_studiu_buton.Text = "Anii de studiu";
            Anii_studiu_buton.UseVisualStyleBackColor = true;
            Anii_studiu_buton.Click += Anii_studiu_buton_Click;
            // 
            // Discipline_buton
            // 
            Discipline_buton.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Discipline_buton.Location = new Point(585, 120);
            Discipline_buton.Name = "Discipline_buton";
            Discipline_buton.Size = new Size(141, 45);
            Discipline_buton.TabIndex = 3;
            Discipline_buton.Text = "Discipline";
            Discipline_buton.UseVisualStyleBackColor = true;
            // 
            // Studenti_buton
            // 
            Studenti_buton.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Studenti_buton.Location = new Point(48, 214);
            Studenti_buton.Name = "Studenti_buton";
            Studenti_buton.Size = new Size(141, 45);
            Studenti_buton.TabIndex = 4;
            Studenti_buton.Text = "Studenti";
            Studenti_buton.UseVisualStyleBackColor = true;
            // 
            // Grupe_buton
            // 
            Grupe_buton.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Grupe_buton.Location = new Point(227, 214);
            Grupe_buton.Name = "Grupe_buton";
            Grupe_buton.Size = new Size(141, 45);
            Grupe_buton.TabIndex = 5;
            Grupe_buton.Text = "Grupe";
            Grupe_buton.UseVisualStyleBackColor = true;
            // 
            // Cadre_buton
            // 
            Cadre_buton.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Cadre_buton.Location = new Point(401, 214);
            Cadre_buton.Name = "Cadre_buton";
            Cadre_buton.Size = new Size(141, 45);
            Cadre_buton.TabIndex = 6;
            Cadre_buton.Text = " Cadre didactice";
            Cadre_buton.UseVisualStyleBackColor = true;
            // 
            // Note_buton
            // 
            Note_buton.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Note_buton.Location = new Point(585, 214);
            Note_buton.Name = "Note_buton";
            Note_buton.Size = new Size(141, 45);
            Note_buton.TabIndex = 7;
            Note_buton.Text = "Note";
            Note_buton.UseVisualStyleBackColor = true;
            Note_buton.Click += Note_buton_Click;
            // 
            // Meniu_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(800, 450);
            Controls.Add(Note_buton);
            Controls.Add(Cadre_buton);
            Controls.Add(Grupe_buton);
            Controls.Add(Studenti_buton);
            Controls.Add(Discipline_buton);
            Controls.Add(Anii_studiu_buton);
            Controls.Add(_studii_buton);
            Controls.Add(Cicluri_inv_buton);
            Name = "Meniu_Principal";
            Text = "Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button Cicluri_inv_buton;
        private Button _studii_buton;
        private Button Anii_studiu_buton;
        private Button Discipline_buton;
        private Button Studenti_buton;
        private Button Grupe_buton;
        private Button Cadre_buton;
        private Button Note_buton;
    }
}