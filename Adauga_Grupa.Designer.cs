namespace Aplicatie
{
    partial class Adauga_Grupa
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
            IDgrupa = new Label();
            Nume_grupa_adaugare = new Label();
            IdAn_grupa_adaugare = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buton_OK = new Button();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // IDgrupa
            // 
            IDgrupa.AutoSize = true;
            IDgrupa.Location = new Point(12, 9);
            IDgrupa.Name = "IDgrupa";
            IDgrupa.Size = new Size(83, 20);
            IDgrupa.TabIndex = 0;
            IDgrupa.Text = "ID Grupa:";
            // 
            // Nume_grupa_adaugare
            // 
            Nume_grupa_adaugare.AutoSize = true;
            Nume_grupa_adaugare.Location = new Point(12, 62);
            Nume_grupa_adaugare.Name = "Nume_grupa_adaugare";
            Nume_grupa_adaugare.Size = new Size(109, 20);
            Nume_grupa_adaugare.TabIndex = 1;
            Nume_grupa_adaugare.Text = "Nume Grupa:";
            // 
            // IdAn_grupa_adaugare
            // 
            IdAn_grupa_adaugare.AutoSize = true;
            IdAn_grupa_adaugare.Location = new Point(12, 124);
            IdAn_grupa_adaugare.Name = "IdAn_grupa_adaugare";
            IdAn_grupa_adaugare.Size = new Size(109, 20);
            IdAn_grupa_adaugare.TabIndex = 2;
            IdAn_grupa_adaugare.Text = "ID An Grupa:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 27);
            textBox2.TabIndex = 5;
            // 
            // buton_OK
            // 
            buton_OK.Location = new Point(68, 190);
            buton_OK.Name = "buton_OK";
            buton_OK.Size = new Size(78, 39);
            buton_OK.TabIndex = 6;
            buton_OK.Text = "OK";
            buton_OK.UseVisualStyleBackColor = true;
            buton_OK.Click += buton_OK_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(13, 147);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(203, 27);
            textBox3.TabIndex = 7;
            // 
            // Adauga_Grupa
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(228, 236);
            Controls.Add(textBox3);
            Controls.Add(buton_OK);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(IdAn_grupa_adaugare);
            Controls.Add(Nume_grupa_adaugare);
            Controls.Add(IDgrupa);
            Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Adauga_Grupa";
            Text = "Adauga_Grupa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IDgrupa;
        private Label Nume_grupa_adaugare;
        private Label IdAn_grupa_adaugare;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buton_OK;
        private TextBox textBox3;
    }
}