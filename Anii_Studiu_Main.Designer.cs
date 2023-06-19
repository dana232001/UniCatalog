namespace Aplicatie
{
    partial class Anii_Studiu_Main
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
            ID_An = new DataGridViewTextBoxColumn();
            Nume_An = new DataGridViewTextBoxColumn();
            ID_Program = new DataGridViewTextBoxColumn();
            adaugare_an_button = new Button();
            stergere_an_button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID_An, Nume_An, ID_Program });
            dataGridView1.Location = new Point(78, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(429, 176);
            dataGridView1.TabIndex = 0;
            // 
            // ID_An
            // 
            ID_An.HeaderText = "ID_An";
            ID_An.MinimumWidth = 6;
            ID_An.Name = "ID_An";
            ID_An.Width = 125;
            // 
            // Nume_An
            // 
            Nume_An.HeaderText = "Nume_An";
            Nume_An.MinimumWidth = 6;
            Nume_An.Name = "Nume_An";
            Nume_An.Width = 125;
            // 
            // ID_Program
            // 
            ID_Program.HeaderText = "ID_program";
            ID_Program.MinimumWidth = 6;
            ID_Program.Name = "ID_Program";
            ID_Program.Width = 125;
            // 
            // adaugare_an_button
            // 
            adaugare_an_button.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            adaugare_an_button.Location = new Point(107, 278);
            adaugare_an_button.Name = "adaugare_an_button";
            adaugare_an_button.Size = new Size(161, 61);
            adaugare_an_button.TabIndex = 1;
            adaugare_an_button.Text = "Adaugare an de studiu";
            adaugare_an_button.UseVisualStyleBackColor = true;
            adaugare_an_button.Click += adaugare_an_button_Click;
            // 
            // stergere_an_button
            // 
            stergere_an_button.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            stergere_an_button.Location = new Point(326, 278);
            stergere_an_button.Name = "stergere_an_button";
            stergere_an_button.Size = new Size(161, 61);
            stergere_an_button.TabIndex = 2;
            stergere_an_button.Text = "Stergere an de studiu";
            stergere_an_button.UseVisualStyleBackColor = true;
            // 
            // Anii_Studiu_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(603, 384);
            Controls.Add(stergere_an_button);
            Controls.Add(adaugare_an_button);
            Controls.Add(dataGridView1);
            Name = "Anii_Studiu_Main";
            Text = "Anii_Studiu_Main";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID_An;
        private DataGridViewTextBoxColumn Nume_An;
        private DataGridViewTextBoxColumn ID_Program;
        private Button adaugare_an_button;
        private Button stergere_an_button;
    }
}