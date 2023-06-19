namespace Aplicatie
{
    partial class An_studiu_stergere
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
            id_an = new TextBox();
            button_stergereAN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 136);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "ID_An:";
            // 
            // id_an
            // 
            id_an.Location = new Point(114, 136);
            id_an.Name = "id_an";
            id_an.Size = new Size(125, 27);
            id_an.TabIndex = 1;
            // 
            // button_stergereAN
            // 
            button_stergereAN.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_stergereAN.Location = new Point(104, 191);
            button_stergereAN.Name = "button_stergereAN";
            button_stergereAN.Size = new Size(94, 29);
            button_stergereAN.TabIndex = 2;
            button_stergereAN.Text = "Ok";
            button_stergereAN.UseVisualStyleBackColor = true;
            button_stergereAN.Click += button_stergereAN_Click;
            // 
            // An_studiu_stergere
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(332, 326);
            Controls.Add(button_stergereAN);
            Controls.Add(id_an);
            Controls.Add(label1);
            Name = "An_studiu_stergere";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "An_studiu_stergere";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox id_an;
        private Button button_stergereAN;
    }
}