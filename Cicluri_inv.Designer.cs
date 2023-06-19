namespace Aplicatie
{
    partial class Cicluri_main
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
            button_cicluri_adaugare = new Button();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Nume = new DataGridViewTextBoxColumn();
            Id_Ciclu = new DataGridViewTextBoxColumn();
            IdCiclu = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_cicluri_adaugare
            // 
            button_cicluri_adaugare.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_cicluri_adaugare.Location = new Point(145, 281);
            button_cicluri_adaugare.Name = "button_cicluri_adaugare";
            button_cicluri_adaugare.Size = new Size(214, 75);
            button_cicluri_adaugare.TabIndex = 0;
            button_cicluri_adaugare.Text = "Adauga un ciclu de invatamant";
            button_cicluri_adaugare.UseVisualStyleBackColor = true;
            button_cicluri_adaugare.Click += button_cicluri_adaugare_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Nume });
            dataGridView1.Location = new Point(12, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(501, 209);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "IdCiclu";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Nume
            // 
            Nume.HeaderText = "Nume";
            Nume.MinimumWidth = 6;
            Nume.Name = "Nume";
            Nume.Width = 125;
            // 
            // Id_Ciclu
            // 
            Id_Ciclu.HeaderText = "Id_Ciclu";
            Id_Ciclu.MinimumWidth = 6;
            Id_Ciclu.Name = "Id_Ciclu";
            Id_Ciclu.Width = 125;
            // 
            // IdCiclu
            // 
            IdCiclu.HeaderText = "IdCiclu";
            IdCiclu.MinimumWidth = 6;
            IdCiclu.Name = "IdCiclu";
            IdCiclu.Width = 125;
            // 
            // Cicluri_main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(537, 431);
            Controls.Add(dataGridView1);
            Controls.Add(button_cicluri_adaugare);
            Name = "Cicluri_main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cicluri invatamant";
            Load += Cicluri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private void Cicluri_main_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button_cicluri_adaugare;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Nume;
        private DataGridViewTextBoxColumn Id_Ciclu;
        private DataGridViewTextBoxColumn IdCiclu;
    }
}