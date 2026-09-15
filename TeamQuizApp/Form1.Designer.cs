namespace TeamQuizApp
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
            answerButton1 = new Button();
            AnswerButton2 = new Button();
            answerButton3 = new Button();
            answerbButton4 = new Button();
            logListBox = new ListBox();
            questionLabel = new Label();
            SuspendLayout();
            // 
            // answerButton1
            // 
            answerButton1.Location = new Point(68, 273);
            answerButton1.Name = "answerButton1";
            answerButton1.Size = new Size(94, 29);
            answerButton1.TabIndex = 0;
            answerButton1.Text = "button1";
            answerButton1.UseVisualStyleBackColor = true;
            answerButton1.Click += answerButton1_Click;
            // 
            // AnswerButton2
            // 
            AnswerButton2.Location = new Point(219, 285);
            AnswerButton2.Name = "AnswerButton2";
            AnswerButton2.Size = new Size(94, 29);
            AnswerButton2.TabIndex = 1;
            AnswerButton2.Text = "button2";
            AnswerButton2.UseVisualStyleBackColor = true;
            AnswerButton2.Click += AnswerButton2_Click;
            // 
            // answerButton3
            // 
            answerButton3.Location = new Point(406, 269);
            answerButton3.Name = "answerButton3";
            answerButton3.Size = new Size(94, 29);
            answerButton3.TabIndex = 2;
            answerButton3.Text = "button3";
            answerButton3.UseVisualStyleBackColor = true;
            answerButton3.Click += answerButton3_Click;
            // 
            // answerbButton4
            // 
            answerbButton4.Location = new Point(588, 290);
            answerbButton4.Name = "answerbButton4";
            answerbButton4.Size = new Size(94, 29);
            answerbButton4.TabIndex = 3;
            answerbButton4.Text = "button4";
            answerbButton4.UseVisualStyleBackColor = true;
            answerbButton4.Click += answerbButton4_Click;
            // 
            // logListBox
            // 
            logListBox.FormattingEnabled = true;
            logListBox.Location = new Point(576, 45);
            logListBox.Name = "logListBox";
            logListBox.Size = new Size(150, 104);
            logListBox.TabIndex = 4;
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new Point(287, 78);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(50, 20);
            questionLabel.TabIndex = 5;
            questionLabel.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(questionLabel);
            Controls.Add(logListBox);
            Controls.Add(answerbButton4);
            Controls.Add(answerButton3);
            Controls.Add(AnswerButton2);
            Controls.Add(answerButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button answerButton1;
        private Button AnswerButton2;
        private Button answerButton3;
        private Button answerbButton4;
        private ListBox logListBox;
        private Label questionLabel;
    }
}
