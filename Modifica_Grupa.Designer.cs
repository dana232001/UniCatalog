namespace Aplicatie
{
    partial class Modifica_Grupa
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
            buton_modifica_grupa = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // buton_modifica_grupa
            // 
            buton_modifica_grupa.Location = new Point(138, 160);
            buton_modifica_grupa.Name = "buton_modifica_grupa";
            buton_modifica_grupa.Size = new Size(118, 63);
            buton_modifica_grupa.TabIndex = 0;
            buton_modifica_grupa.Text = "Modifica";
            buton_modifica_grupa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 84);
            label1.Name = "label1";
            label1.Size = new Size(105, 23);
            label1.TabIndex = 1;
            label1.Text = "ID Grupa:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 32);
            textBox1.TabIndex = 2;
            // 
            // Modifica_Grupa
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 288);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(buton_modifica_grupa);
            Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Modifica_Grupa";
            Text = "Modifica_Grupa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buton_modifica_grupa;
        private Label label1;
        private TextBox textBox1;
    }
}