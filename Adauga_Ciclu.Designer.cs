namespace Aplicatie
{
    partial class Adauga_Ciclu
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
            label_id_ciclu = new Label();
            label_nume_ciclu = new Label();
            textBox_id = new TextBox();
            textBox_nume = new TextBox();
            button_ok_ciclu_inv = new Button();
            SuspendLayout();
            // 
            // label_id_ciclu
            // 
            label_id_ciclu.AutoSize = true;
            label_id_ciclu.Location = new Point(19, 165);
            label_id_ciclu.Name = "label_id_ciclu";
            label_id_ciclu.Size = new Size(139, 20);
            label_id_ciclu.TabIndex = 0;
            label_id_ciclu.Text = "Id Ciclu Invatamant:";
            // 
            // label_nume_ciclu
            // 
            label_nume_ciclu.AutoSize = true;
            label_nume_ciclu.Location = new Point(19, 210);
            label_nume_ciclu.Name = "label_nume_ciclu";
            label_nume_ciclu.Size = new Size(166, 20);
            label_nume_ciclu.TabIndex = 1;
            label_nume_ciclu.Text = "Nume Ciclu Invatamant:";
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(164, 165);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(152, 27);
            textBox_id.TabIndex = 2;
            // 
            // textBox_nume
            // 
            textBox_nume.Location = new Point(191, 210);
            textBox_nume.Name = "textBox_nume";
            textBox_nume.Size = new Size(125, 27);
            textBox_nume.TabIndex = 3;
            // 
            // button_ok_ciclu_inv
            // 
            button_ok_ciclu_inv.Location = new Point(120, 289);
            button_ok_ciclu_inv.Name = "button_ok_ciclu_inv";
            button_ok_ciclu_inv.Size = new Size(133, 58);
            button_ok_ciclu_inv.TabIndex = 4;
            button_ok_ciclu_inv.Text = "Ok";
            button_ok_ciclu_inv.UseVisualStyleBackColor = true;
            button_ok_ciclu_inv.Click += button_ok_ciclu_inv_Click;
            // 
            // Adauga_Ciclu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(387, 468);
            Controls.Add(button_ok_ciclu_inv);
            Controls.Add(textBox_nume);
            Controls.Add(textBox_id);
            Controls.Add(label_nume_ciclu);
            Controls.Add(label_id_ciclu);
            Name = "Adauga_Ciclu";
            Text = "Adauga_Ciclu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_id_ciclu;
        private Label label_nume_ciclu;
        private TextBox textBox_id;
        private TextBox textBox_nume;
        private Button button_ok_ciclu_inv;
    }
}