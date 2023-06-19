namespace Aplicatie
{
    partial class Discipline
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
            ID = new DataGridViewTextBoxColumn();
            ND = new DataGridViewTextBoxColumn();
            AD = new DataGridViewTextBoxColumn();
            NRC = new DataGridViewTextBoxColumn();
            IDA = new DataGridViewTextBoxColumn();
            Adauga = new Button();
            Sterge = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, ND, AD, NRC, IDA });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1084, 300);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "IDDisciplina";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.Width = 200;
            // 
            // ND
            // 
            ND.HeaderText = "NumeDisciplina";
            ND.MinimumWidth = 10;
            ND.Name = "ND";
            ND.Width = 200;
            // 
            // AD
            // 
            AD.HeaderText = "AcronimDisciplina";
            AD.MinimumWidth = 10;
            AD.Name = "AD";
            AD.Width = 200;
            // 
            // NRC
            // 
            NRC.HeaderText = "NrCredite";
            NRC.MinimumWidth = 10;
            NRC.Name = "NRC";
            NRC.Width = 200;
            // 
            // IDA
            // 
            IDA.HeaderText = "IDan";
            IDA.MinimumWidth = 10;
            IDA.Name = "IDA";
            IDA.Width = 200;
            // 
            // Adauga
            // 
            Adauga.Location = new Point(303, 347);
            Adauga.Name = "Adauga";
            Adauga.Size = new Size(150, 46);
            Adauga.TabIndex = 1;
            Adauga.Text = "Adauga";
            Adauga.UseVisualStyleBackColor = true;
            Adauga.Click += button1_Click;
            // 
            // Sterge
            // 
            Sterge.Location = new Point(593, 347);
            Sterge.Name = "Sterge";
            Sterge.Size = new Size(150, 46);
            Sterge.TabIndex = 2;
            Sterge.Text = "Sterge";
            Sterge.UseVisualStyleBackColor = true;
            Sterge.Click += Sterge_Click;
            // 
            // Discipline
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 450);
            Controls.Add(Sterge);
            Controls.Add(Adauga);
            Controls.Add(dataGridView1);
            Name = "Discipline";
            Text = "Discipline";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ND;
        private DataGridViewTextBoxColumn AD;
        private DataGridViewTextBoxColumn NRC;
        private DataGridViewTextBoxColumn IDA;
        private Button Adauga;
        private Button Sterge;
    }
}