namespace Aplicatie
{
    partial class Adaugare_Anii
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
            textBox_id_an = new TextBox();
            textBox_nume = new TextBox();
            textBox_idprogram = new TextBox();
            buton_ok_adaugare = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 91);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "ID_An:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 142);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Nume An:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 195);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "ID_Program:";
            // 
            // textBox_id_an
            // 
            textBox_id_an.Location = new Point(134, 91);
            textBox_id_an.Name = "textBox_id_an";
            textBox_id_an.Size = new Size(125, 27);
            textBox_id_an.TabIndex = 3;
            // 
            // textBox_nume
            // 
            textBox_nume.Location = new Point(134, 142);
            textBox_nume.Name = "textBox_nume";
            textBox_nume.Size = new Size(125, 27);
            textBox_nume.TabIndex = 4;
            // 
            // textBox_idprogram
            // 
            textBox_idprogram.Location = new Point(134, 195);
            textBox_idprogram.Name = "textBox_idprogram";
            textBox_idprogram.Size = new Size(125, 27);
            textBox_idprogram.TabIndex = 5;
            // 
            // buton_ok_adaugare
            // 
            buton_ok_adaugare.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buton_ok_adaugare.Location = new Point(106, 256);
            buton_ok_adaugare.Name = "buton_ok_adaugare";
            buton_ok_adaugare.Size = new Size(94, 29);
            buton_ok_adaugare.TabIndex = 6;
            buton_ok_adaugare.Text = "Ok";
            buton_ok_adaugare.UseVisualStyleBackColor = true;
            // 
            // Adaugare_Anii
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 343);
            Controls.Add(buton_ok_adaugare);
            Controls.Add(textBox_idprogram);
            Controls.Add(textBox_nume);
            Controls.Add(textBox_id_an);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Adaugare_Anii";
            Text = "Adaugare_Anii";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_id_an;
        private TextBox textBox_nume;
        private TextBox textBox_idprogram;
        private Button buton_ok_adaugare;
    }
}