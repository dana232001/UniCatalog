namespace Aplicatie
{
    partial class StergereDiscipline
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
            textBox_IDD = new TextBox();
            IDD = new Label();
            Sterge = new Button();
            SuspendLayout();
            // 
            // textBox_IDD
            // 
            textBox_IDD.Location = new Point(27, 51);
            textBox_IDD.Name = "textBox_IDD";
            textBox_IDD.Size = new Size(200, 39);
            textBox_IDD.TabIndex = 0;
            textBox_IDD.TextChanged += textBox1_TextChanged;
            // 
            // IDD
            // 
            IDD.AutoSize = true;
            IDD.Location = new Point(27, 16);
            IDD.Name = "IDD";
            IDD.Size = new Size(139, 32);
            IDD.TabIndex = 1;
            IDD.Text = "IDDisciplina";
            // 
            // Sterge
            // 
            Sterge.Location = new Point(27, 115);
            Sterge.Name = "Sterge";
            Sterge.Size = new Size(150, 46);
            Sterge.TabIndex = 2;
            Sterge.Text = "Sterge";
            Sterge.UseVisualStyleBackColor = true;
            Sterge.Click += Sterge_Click;
            // 
            // StergereDiscipline
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Sterge);
            Controls.Add(IDD);
            Controls.Add(textBox_IDD);
            Name = "StergereDiscipline";
            Text = "StergereDiscipline";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_IDD;
        private Label IDD;
        private Button Sterge;
    }
}