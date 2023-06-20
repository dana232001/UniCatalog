namespace Aplicatie
{
    partial class Stergere
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
            textBox1 = new TextBox();
            Buton_OK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 19);
            label1.TabIndex = 0;
            label1.Text = "Id Cadru Didactic";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(2, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 27);
            textBox1.TabIndex = 1;
            // 
            // Buton_OK
            // 
            Buton_OK.Location = new Point(55, 64);
            Buton_OK.Name = "Buton_OK";
            Buton_OK.Size = new Size(78, 32);
            Buton_OK.TabIndex = 2;
            Buton_OK.Text = "OK!";
            Buton_OK.UseVisualStyleBackColor = true;
            Buton_OK.Click += Buton_OK_Click;
            // 
            // Stergere
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(193, 103);
            Controls.Add(Buton_OK);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Stergere";
            Text = "Stergere";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button Buton_OK;
    }
}