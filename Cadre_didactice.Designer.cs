namespace Aplicatie
{
    partial class Cadre_didactice
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
            IDCD = new DataGridViewTextBoxColumn();
            NCD = new DataGridViewTextBoxColumn();
            PCD = new DataGridViewTextBoxColumn();
            MA = new DataGridViewTextBoxColumn();
            TL = new DataGridViewTextBoxColumn();
            PT = new DataGridViewTextBoxColumn();
            Buton_Adaugare = new Button();
            Buton_Stergere = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDCD, NCD, PCD, MA, TL, PT });
            dataGridView1.Location = new Point(58, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1284, 348);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IDCD
            // 
            IDCD.HeaderText = "Id Cadru Didactic";
            IDCD.MinimumWidth = 10;
            IDCD.Name = "IDCD";
            IDCD.Width = 200;
            // 
            // NCD
            // 
            NCD.HeaderText = "Nume Cadru Didactic";
            NCD.MinimumWidth = 10;
            NCD.Name = "NCD";
            NCD.Width = 200;
            // 
            // PCD
            // 
            PCD.HeaderText = "Prenume Cadru Didactic";
            PCD.MinimumWidth = 10;
            PCD.Name = "PCD";
            PCD.Width = 200;
            // 
            // MA
            // 
            MA.HeaderText = "Marca Angajat";
            MA.MinimumWidth = 10;
            MA.Name = "MA";
            MA.Width = 200;
            // 
            // TL
            // 
            TL.HeaderText = "Titlu";
            TL.MinimumWidth = 10;
            TL.Name = "TL";
            TL.Width = 200;
            // 
            // PT
            // 
            PT.HeaderText = "Post";
            PT.MinimumWidth = 10;
            PT.Name = "PT";
            PT.Width = 200;
            // 
            // Buton_Adaugare
            // 
            Buton_Adaugare.Location = new Point(199, 468);
            Buton_Adaugare.Name = "Buton_Adaugare";
            Buton_Adaugare.Size = new Size(224, 75);
            Buton_Adaugare.TabIndex = 1;
            Buton_Adaugare.Text = "Adaugare";
            Buton_Adaugare.UseVisualStyleBackColor = true;
            Buton_Adaugare.Click += button1_Click;
            // 
            // Buton_Stergere
            // 
            Buton_Stergere.Location = new Point(997, 468);
            Buton_Stergere.Name = "Buton_Stergere";
            Buton_Stergere.Size = new Size(206, 75);
            Buton_Stergere.TabIndex = 3;
            Buton_Stergere.Text = "Stergere";
            Buton_Stergere.UseVisualStyleBackColor = true;
            Buton_Stergere.Click += Buton_Stergere_Click;
            // 
            // Cadre_didactice
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1382, 612);
            Controls.Add(Buton_Stergere);
            Controls.Add(Buton_Adaugare);
            Controls.Add(dataGridView1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Cadre_didactice";
            Text = "Cadre_didactice";
            Load += Cadre_didactice_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Buton_Adaugare;
        private Button Buton_Stergere;
        private DataGridViewTextBoxColumn IDCD;
        private DataGridViewTextBoxColumn NCD;
        private DataGridViewTextBoxColumn PCD;
        private DataGridViewTextBoxColumn MA;
        private DataGridViewTextBoxColumn TL;
        private DataGridViewTextBoxColumn PT;
    }
}