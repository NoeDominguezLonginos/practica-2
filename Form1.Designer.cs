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
            HELLO = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // HELLO
            // 
            HELLO.AutoSize = true;
            HELLO.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            HELLO.Location = new Point(78, 110);
            HELLO.Name = "HELLO";
            HELLO.Size = new Size(234, 33);
            HELLO.TabIndex = 0;
            HELLO.Text = "HELLO, MUNDO!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(78, 213);
            label1.Name = "label1";
            label1.Size = new Size(193, 27);
            label1.TabIndex = 1;
            label1.Text = "cual es tu nombre?";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Font = new Font("Viner Hand ITC", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(78, 279);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 46);
            textBox1.TabIndex = 2;
            textBox1.Text = "Noe Dominguez";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(78, 348);
            label2.Name = "label2";
            label2.Size = new Size(241, 27);
            label2.TabIndex = 3;
            label2.Text = "Hello, alguien especial !";
            // 
            // button1
            // 
            button1.Font = new Font("Stencil", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(383, 279);
            button1.Name = "button1";
            button1.Size = new Size(147, 46);
            button1.TabIndex = 4;
            button1.Text = "diga \"Hello\"";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(HELLO);
            Name = "Form1";
            Text = "Hello";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HELLO;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
    }
}