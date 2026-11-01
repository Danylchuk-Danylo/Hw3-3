namespace Hw3_3
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
            components = new System.ComponentModel.Container();
            btnStart = new Button();
            txtGuess = new Button();
            lblTimer = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(61, 169);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(150, 46);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(546, 169);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(150, 46);
            txtGuess.TabIndex = 1;
            txtGuess.Text = "Guess";
            txtGuess.UseVisualStyleBackColor = true;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Location = new Point(320, 290);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(70, 32);
            lblTimer.TabIndex = 2;
            lblTimer.Text = "Lable";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(279, 176);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 66);
            label1.Name = "label1";
            label1.Size = new Size(219, 32);
            label1.TabIndex = 4;
            label1.Text = "Guess The Number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(lblTimer);
            Controls.Add(txtGuess);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button txtGuess;
        private Label lblTimer;
        private System.Windows.Forms.Timer gameTimer;
        private TextBox textBox1;
        private Label label1;
    }
}
