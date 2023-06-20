namespace Aplicatie
{
    partial class Adaugare_Cadru_Didactic
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            Buton_OK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 54);
            label1.Name = "label1";
            label1.Size = new Size(120, 19);
            label1.TabIndex = 0;
            label1.Text = "Id Cadru Didactic";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 142);
            label2.Name = "label2";
            label2.Size = new Size(146, 19);
            label2.TabIndex = 1;
            label2.Text = "Nume Cadru Didactic";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 227);
            label3.Name = "label3";
            label3.Size = new Size(165, 19);
            label3.TabIndex = 2;
            label3.Text = "Prenume Cadru Didactic";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 322);
            label4.Name = "label4";
            label4.Size = new Size(104, 19);
            label4.TabIndex = 3;
            label4.Text = "Marca Angajat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 400);
            label5.Name = "label5";
            label5.Size = new Size(38, 19);
            label5.TabIndex = 4;
            label5.Text = "Titlu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 478);
            label6.Name = "label6";
            label6.Size = new Size(37, 19);
            label6.TabIndex = 5;
            label6.Text = "Post";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(23, 164);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(23, 259);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(23, 344);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(211, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(23, 422);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(211, 27);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(23, 512);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(211, 27);
            textBox6.TabIndex = 11;
            // 
            // Buton_OK
            // 
            Buton_OK.Location = new Point(88, 562);
            Buton_OK.Name = "Buton_OK";
            Buton_OK.Size = new Size(68, 27);
            Buton_OK.TabIndex = 12;
            Buton_OK.Text = "OK!";
            Buton_OK.UseVisualStyleBackColor = true;
            Buton_OK.Click += Buton_OK_Click;
            // 
            // Adaugare_Cadru_Didactic
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(260, 601);
            Controls.Add(Buton_OK);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Adaugare_Cadru_Didactic";
            Text = "Adaugare_Cadru_Didactic";
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button Buton_OK;
    }
}