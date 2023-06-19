namespace Aplicatie
{
    partial class Note_Main
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
            idcatalog = new DataGridViewTextBoxColumn();
            idstudent = new DataGridViewTextBoxColumn();
            iddisciplina = new DataGridViewTextBoxColumn();
            nota = new DataGridViewTextBoxColumn();
            button_adaugare = new Button();
            button_salvare = new Button();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idcatalog, idstudent, iddisciplina, nota });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(556, 246);
            dataGridView1.TabIndex = 0;
            // 
            // idcatalog
            // 
            idcatalog.HeaderText = "ID Catalog";
            idcatalog.MinimumWidth = 6;
            idcatalog.Name = "idcatalog";
            idcatalog.Width = 125;
            // 
            // idstudent
            // 
            idstudent.HeaderText = "ID Student";
            idstudent.MinimumWidth = 6;
            idstudent.Name = "idstudent";
            idstudent.Width = 125;
            // 
            // iddisciplina
            // 
            iddisciplina.HeaderText = "ID Disciplina";
            iddisciplina.MinimumWidth = 6;
            iddisciplina.Name = "iddisciplina";
            iddisciplina.Width = 125;
            // 
            // nota
            // 
            nota.HeaderText = "Nota";
            nota.MinimumWidth = 6;
            nota.Name = "nota";
            nota.Width = 125;
            // 
            // button_adaugare
            // 
            button_adaugare.BackColor = SystemColors.Control;
            button_adaugare.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_adaugare.Location = new Point(92, 289);
            button_adaugare.Name = "button_adaugare";
            button_adaugare.Size = new Size(125, 79);
            button_adaugare.TabIndex = 1;
            button_adaugare.Text = "Adaugare nota";
            button_adaugare.UseVisualStyleBackColor = false;
            button_adaugare.Click += button_adaugare_Click;
            // 
            // button_salvare
            // 
            button_salvare.BackColor = SystemColors.Control;
            button_salvare.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_salvare.Location = new Point(342, 289);
            button_salvare.Name = "button_salvare";
            button_salvare.Size = new Size(125, 79);
            button_salvare.TabIndex = 2;
            button_salvare.Text = "Salvare catalog";
            button_salvare.UseVisualStyleBackColor = false;
            button_salvare.Click += button_salvare_Click;
            // 
            // Note_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(577, 389);
            Controls.Add(button_salvare);
            Controls.Add(button_adaugare);
            Controls.Add(dataGridView1);
            Name = "Note_Main";
            Text = "Note_Main";
            Load += Note_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private DataGridView dataGridView1;
        private Button button_adaugare;
        private Button button_salvare;
        private DataGridViewTextBoxColumn idcatalog;
        private DataGridViewTextBoxColumn idstudent;
        private DataGridViewTextBoxColumn iddisciplina;
        private DataGridViewTextBoxColumn nota;
        private SaveFileDialog saveFileDialog1;
    }
}