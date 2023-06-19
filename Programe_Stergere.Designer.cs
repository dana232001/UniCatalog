namespace Aplicatie
{
    partial class Programe_Stergere
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
            stergere_program_textbox = new TextBox();
            button_ok_sterge = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 108);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "ID_Program:";
            // 
            // stergere_program_textbox
            // 
            stergere_program_textbox.Location = new Point(146, 108);
            stergere_program_textbox.Name = "stergere_program_textbox";
            stergere_program_textbox.Size = new Size(125, 27);
            stergere_program_textbox.TabIndex = 1;
            // 
            // button_ok_sterge
            // 
            button_ok_sterge.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_ok_sterge.Location = new Point(93, 175);
            button_ok_sterge.Name = "button_ok_sterge";
            button_ok_sterge.Size = new Size(114, 45);
            button_ok_sterge.TabIndex = 2;
            button_ok_sterge.Text = "Ok";
            button_ok_sterge.UseVisualStyleBackColor = true;
            button_ok_sterge.Click += button_ok_sterge_Click;
            // 
            // Programe_Stergere
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(301, 318);
            Controls.Add(button_ok_sterge);
            Controls.Add(stergere_program_textbox);
            Controls.Add(label1);
            Name = "Programe_Stergere";
            Text = "Programe_Stergere";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox stergere_program_textbox;
        private Button button_ok_sterge;
    }
}