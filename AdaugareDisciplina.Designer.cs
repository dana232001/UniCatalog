namespace Aplicatie
{
    partial class AdaugareDisciplina
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
            textBox_ID = new TextBox();
            textBox_ND = new TextBox();
            textBox_AD = new TextBox();
            textBox_NRC = new TextBox();
            textBox_IDA = new TextBox();
            ID = new Label();
            ND = new Label();
            AD = new Label();
            NRC = new Label();
            IDA = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(12, 33);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(465, 39);
            textBox_ID.TabIndex = 0;
            // 
            // textBox_ND
            // 
            textBox_ND.Location = new Point(12, 106);
            textBox_ND.Name = "textBox_ND";
            textBox_ND.Size = new Size(465, 39);
            textBox_ND.TabIndex = 1;
            // 
            // textBox_AD
            // 
            textBox_AD.Location = new Point(12, 189);
            textBox_AD.Name = "textBox_AD";
            textBox_AD.Size = new Size(465, 39);
            textBox_AD.TabIndex = 2;
            // 
            // textBox_NRC
            // 
            textBox_NRC.Location = new Point(12, 267);
            textBox_NRC.Name = "textBox_NRC";
            textBox_NRC.Size = new Size(465, 39);
            textBox_NRC.TabIndex = 3;
            // 
            // textBox_IDA
            // 
            textBox_IDA.Location = new Point(12, 341);
            textBox_IDA.Name = "textBox_IDA";
            textBox_IDA.Size = new Size(465, 39);
            textBox_IDA.TabIndex = 4;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(12, -2);
            ID.Name = "ID";
            ID.Size = new Size(139, 32);
            ID.TabIndex = 5;
            ID.Text = "IDDisciplina";
            // 
            // ND
            // 
            ND.AutoSize = true;
            ND.Location = new Point(12, 75);
            ND.Name = "ND";
            ND.Size = new Size(182, 32);
            ND.TabIndex = 6;
            ND.Text = "NumeDisciplina";
            // 
            // AD
            // 
            AD.AutoSize = true;
            AD.Location = new Point(12, 154);
            AD.Name = "AD";
            AD.Size = new Size(205, 32);
            AD.TabIndex = 7;
            AD.Text = "AcronimDisciplina";
            // 
            // NRC
            // 
            NRC.AutoSize = true;
            NRC.Location = new Point(12, 232);
            NRC.Name = "NRC";
            NRC.Size = new Size(123, 32);
            NRC.TabIndex = 8;
            NRC.Text = "NRCredite";
            // 
            // IDA
            // 
            IDA.AutoSize = true;
            IDA.Location = new Point(12, 306);
            IDA.Name = "IDA";
            IDA.Size = new Size(65, 32);
            IDA.TabIndex = 9;
            IDA.Text = "IDAn";
            // 
            // button1
            // 
            button1.Location = new Point(156, 420);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 10;
            button1.Text = "Adauga";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AdaugareDisciplina
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 508);
            Controls.Add(button1);
            Controls.Add(IDA);
            Controls.Add(NRC);
            Controls.Add(AD);
            Controls.Add(ND);
            Controls.Add(ID);
            Controls.Add(textBox_IDA);
            Controls.Add(textBox_NRC);
            Controls.Add(textBox_AD);
            Controls.Add(textBox_ND);
            Controls.Add(textBox_ID);
            Name = "AdaugareDisciplina";
            Text = "AdaugareDisciplina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_ID;
        private TextBox textBox_ND;
        private TextBox textBox_AD;
        private TextBox textBox_NRC;
        private TextBox textBox_IDA;
        private Label ID;
        private Label ND;
        private Label AD;
        private Label NRC;
        private Label IDA;
        private Button button1;
    }
}