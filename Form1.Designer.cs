namespace poo_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            PASSWORD = new Label();
            label2 = new Label();
            USERNAME = new Label();
            Sign_in = new Button();
            Text1 = new Label();
            userbox = new TextBox();
            passbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.unitbv;
            pictureBox1.Location = new Point(17, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 225);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // PASSWORD
            // 
            PASSWORD.AutoSize = true;
            PASSWORD.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PASSWORD.Location = new Point(274, 203);
            PASSWORD.Name = "PASSWORD";
            PASSWORD.Size = new Size(104, 20);
            PASSWORD.TabIndex = 1;
            PASSWORD.Text = "PASSWORD:";
            PASSWORD.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(485, 237);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // USERNAME
            // 
            USERNAME.AutoSize = true;
            USERNAME.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            USERNAME.Location = new Point(274, 142);
            USERNAME.Name = "USERNAME";
            USERNAME.Size = new Size(103, 20);
            USERNAME.TabIndex = 3;
            USERNAME.Text = "USERNAME:";
            USERNAME.Click += label1_Click_1;
            // 
            // Sign_in
            // 
            Sign_in.BackColor = SystemColors.MenuHighlight;
            Sign_in.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Sign_in.Location = new Point(347, 288);
            Sign_in.Name = "Sign_in";
            Sign_in.Size = new Size(291, 30);
            Sign_in.TabIndex = 4;
            Sign_in.Text = "Sign in";
            Sign_in.UseVisualStyleBackColor = false;
            Sign_in.Click += Sign_in_Click;
            // 
            // Text1
            // 
            Text1.AutoSize = true;
            Text1.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Text1.Location = new Point(373, 44);
            Text1.Name = "Text1";
            Text1.Size = new Size(223, 20);
            Text1.TabIndex = 5;
            Text1.Text = "Sign in to your account";
            // 
            // userbox
            // 
            userbox.Location = new Point(418, 135);
            userbox.Name = "userbox";
            userbox.Size = new Size(273, 27);
            userbox.TabIndex = 6;
            // 
            // passbox
            // 
            passbox.Location = new Point(418, 196);
            passbox.Name = "passbox";
            passbox.Size = new Size(273, 27);
            passbox.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(776, 381);
            Controls.Add(passbox);
            Controls.Add(userbox);
            Controls.Add(Text1);
            Controls.Add(Sign_in);
            Controls.Add(USERNAME);
            Controls.Add(label2);
            Controls.Add(PASSWORD);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "POO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label PASSWORD;
        private Label label2;
        private Label USERNAME;
        private Button Sign_in;
        private Label Text1;
        private TextBox userbox;
        private TextBox passbox;
    }
}