namespace Aplicatie
{
    partial class Sterge_Grupa
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
            buton_sterge_grupa = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // buton_sterge_grupa
            // 
            buton_sterge_grupa.Location = new Point(33, 65);
            buton_sterge_grupa.Name = "buton_sterge_grupa";
            buton_sterge_grupa.Size = new Size(122, 45);
            buton_sterge_grupa.TabIndex = 0;
            buton_sterge_grupa.Text = "Sterge";
            buton_sterge_grupa.UseVisualStyleBackColor = true;
            buton_sterge_grupa.Click += buton_sterge_grupa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 1;
            label1.Text = "ID Grupa:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 27);
            textBox1.TabIndex = 2;
            // 
            // Sterge_Grupa
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(197, 125);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(buton_sterge_grupa);
            Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Sterge_Grupa";
            Text = "Sterge_Grupa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buton_sterge_grupa;
        private Label label1;
        private TextBox textBox1;
    }
}