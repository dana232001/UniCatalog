namespace Aplicatie
{
    partial class Programe_Main
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
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ID_ciclu = new DataGridViewTextBoxColumn();
            Nume = new DataGridViewTextBoxColumn();
            Id_Program = new DataGridViewTextBoxColumn();
            button_adaugare_program_studii = new Button();
            button_stergere_program_studii = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, ID_ciclu, Nume });
            dataGridView1.Location = new Point(114, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(515, 204);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID_Program";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // ID_ciclu
            // 
            ID_ciclu.HeaderText = "ID_ciclu";
            ID_ciclu.MinimumWidth = 6;
            ID_ciclu.Name = "ID_ciclu";
            ID_ciclu.Width = 125;
            // 
            // Nume
            // 
            Nume.HeaderText = "Nume";
            Nume.MinimumWidth = 6;
            Nume.Name = "Nume";
            Nume.Width = 125;
            // 
            // Id_Program
            // 
            Id_Program.HeaderText = "Id_Program";
            Id_Program.MinimumWidth = 6;
            Id_Program.Name = "Id_Program";
            Id_Program.Width = 125;
            // 
            // button_adaugare_program_studii
            // 
            button_adaugare_program_studii.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_adaugare_program_studii.Location = new Point(151, 299);
            button_adaugare_program_studii.Name = "button_adaugare_program_studii";
            button_adaugare_program_studii.Size = new Size(169, 62);
            button_adaugare_program_studii.TabIndex = 1;
            button_adaugare_program_studii.Text = "Adaugare program";
            button_adaugare_program_studii.UseVisualStyleBackColor = true;
            button_adaugare_program_studii.Click += button_adaugare_program_studii_Click;
            // 
            // button_stergere_program_studii
            // 
            button_stergere_program_studii.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_stergere_program_studii.Location = new Point(434, 299);
            button_stergere_program_studii.Name = "button_stergere_program_studii";
            button_stergere_program_studii.Size = new Size(169, 62);
            button_stergere_program_studii.TabIndex = 3;
            button_stergere_program_studii.Text = "Stergere program";
            button_stergere_program_studii.UseVisualStyleBackColor = true;
            button_stergere_program_studii.Click += button_stergere_program_studii_Click;
            // 
            // Programe_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(766, 408);
            Controls.Add(button_stergere_program_studii);
            Controls.Add(button_adaugare_program_studii);
            Controls.Add(dataGridView1);
            Name = "Programe_Main";
            Text = "Programe_Main";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id_Program;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ID_ciclu;
        private DataGridViewTextBoxColumn Nume;
        private Button button_adaugare_program_studii;
        private Button button_stergere_program_studii;
    }
}