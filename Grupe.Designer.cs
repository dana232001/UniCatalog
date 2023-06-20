namespace Aplicatie
{
    partial class Grupe_main
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
            IDG = new DataGridViewTextBoxColumn();
            IDS = new DataGridViewTextBoxColumn();
            NG = new DataGridViewTextBoxColumn();
            IDA = new DataGridViewTextBoxColumn();
            buton_grupe_adaugare = new Button();
            buton_grupe_stergere = new Button();
            AdaugareStudenti = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDG, IDS, NG, IDA });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(528, 216);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IDG
            // 
            IDG.HeaderText = "IdGrupa";
            IDG.MinimumWidth = 6;
            IDG.Name = "IDG";
            IDG.Width = 125;
            // 
            // IDS
            // 
            IDS.HeaderText = "ID Student";
            IDS.Name = "IDS";
            // 
            // NG
            // 
            NG.HeaderText = "NumeGrupa";
            NG.MinimumWidth = 6;
            NG.Name = "NG";
            NG.Width = 125;
            // 
            // IDA
            // 
            IDA.HeaderText = "IdAn";
            IDA.MinimumWidth = 6;
            IDA.Name = "IDA";
            IDA.Width = 125;
            // 
            // buton_grupe_adaugare
            // 
            buton_grupe_adaugare.Location = new Point(60, 234);
            buton_grupe_adaugare.Name = "buton_grupe_adaugare";
            buton_grupe_adaugare.Size = new Size(100, 59);
            buton_grupe_adaugare.TabIndex = 1;
            buton_grupe_adaugare.Text = "Adaugare Grupa";
            buton_grupe_adaugare.UseVisualStyleBackColor = true;
            buton_grupe_adaugare.Click += buton_grupe_adaugare_Click;
            // 
            // buton_grupe_stergere
            // 
            buton_grupe_stergere.Location = new Point(361, 233);
            buton_grupe_stergere.Name = "buton_grupe_stergere";
            buton_grupe_stergere.Size = new Size(93, 60);
            buton_grupe_stergere.TabIndex = 2;
            buton_grupe_stergere.Text = "Stergere Grupa";
            buton_grupe_stergere.UseVisualStyleBackColor = true;
            buton_grupe_stergere.Click += buton_grupe_stergere_Click;
            // 
            // AdaugareStudenti
            // 
            AdaugareStudenti.Location = new Point(215, 233);
            AdaugareStudenti.Name = "AdaugareStudenti";
            AdaugareStudenti.Size = new Size(93, 60);
            AdaugareStudenti.TabIndex = 3;
            AdaugareStudenti.Text = "Adaugare studenti";
            AdaugareStudenti.UseVisualStyleBackColor = true;
            AdaugareStudenti.Click += button1_Click;
            // 
            // Grupe_main
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(529, 325);
            Controls.Add(AdaugareStudenti);
            Controls.Add(buton_grupe_stergere);
            Controls.Add(buton_grupe_adaugare);
            Controls.Add(dataGridView1);
            Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Grupe_main";
            Text = "Grupe";
            Load += Grupe_main_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buton_grupe_adaugare;
        private Button buton_grupe_stergere;
        private DataGridViewTextBoxColumn IDG;
        private DataGridViewTextBoxColumn IDS;
        private DataGridViewTextBoxColumn NG;
        private DataGridViewTextBoxColumn IDA;
        private Button AdaugareStudenti;
    }
}