namespace practica_2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(73, 120);
            label1.Name = "label1";
            label1.Size = new Size(272, 36);
            label1.TabIndex = 0;
            label1.Text = "Hello, Mundo !!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tempus Sans ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(73, 215);
            label2.Name = "label2";
            label2.Size = new Size(182, 24);
            label2.TabIndex = 1;
            label2.Text = "Cual es tu nombre?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tempus Sans ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(73, 344);
            label3.Name = "label3";
            label3.Size = new Size(225, 24);
            label3.TabIndex = 2;
            label3.Text = "Hello, alguien especial !";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Blue;
            textBox1.Font = new Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(73, 271);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 32);
            textBox1.TabIndex = 3;
            textBox1.Text = "Noe Dominguez";
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Viner Hand ITC", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(404, 271);
            button1.Name = "button1";
            button1.Size = new Size(178, 32);
            button1.TabIndex = 4;
            button1.Text = "Diga \"HELLO\"";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "HELLO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
    }
}