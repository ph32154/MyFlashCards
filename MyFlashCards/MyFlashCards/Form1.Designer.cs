namespace MyFlashCards
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.btnWrong = new System.Windows.Forms.Button();
            this.lblScoreTxt = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnShowAnswer = new System.Windows.Forms.Button();
            this.lblEnd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(211, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(127, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title here";
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(26, 116);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(92, 13);
            this.lblLeft.TabIndex = 1;
            this.lblLeft.Text = "left hand contents";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(298, 114);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(103, 13);
            this.lblRight.TabIndex = 2;
            this.lblRight.Text = "Right hand contents";
            // 
            // btnCorrect
            // 
            this.btnCorrect.Location = new System.Drawing.Point(21, 293);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(122, 38);
            this.btnCorrect.TabIndex = 3;
            this.btnCorrect.Text = "Got it right";
            this.btnCorrect.UseVisualStyleBackColor = true;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // btnWrong
            // 
            this.btnWrong.Location = new System.Drawing.Point(149, 293);
            this.btnWrong.Name = "btnWrong";
            this.btnWrong.Size = new System.Drawing.Size(122, 38);
            this.btnWrong.TabIndex = 4;
            this.btnWrong.Text = "Got it wrong";
            this.btnWrong.UseVisualStyleBackColor = true;
            this.btnWrong.Click += new System.EventHandler(this.btnWrong_Click);
            // 
            // lblScoreTxt
            // 
            this.lblScoreTxt.AutoSize = true;
            this.lblScoreTxt.Location = new System.Drawing.Point(427, 298);
            this.lblScoreTxt.Name = "lblScoreTxt";
            this.lblScoreTxt.Size = new System.Drawing.Size(61, 13);
            this.lblScoreTxt.TabIndex = 5;
            this.lblScoreTxt.Text = "Your score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(505, 298);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(33, 13);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "blank";
            // 
            // btnShowAnswer
            // 
            this.btnShowAnswer.Location = new System.Drawing.Point(21, 247);
            this.btnShowAnswer.Name = "btnShowAnswer";
            this.btnShowAnswer.Size = new System.Drawing.Size(121, 35);
            this.btnShowAnswer.TabIndex = 8;
            this.btnShowAnswer.Text = "Show Answer";
            this.btnShowAnswer.UseVisualStyleBackColor = true;
            this.btnShowAnswer.Click += new System.EventHandler(this.btnShowAnswer_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(41, 151);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(110, 13);
            this.lblEnd.TabIndex = 9;
            this.lblEnd.Text = "Reached the end text";
            this.lblEnd.Visible = false;
            this.lblEnd.Click += new System.EventHandler(this.lblEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 355);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.btnShowAnswer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblScoreTxt);
            this.Controls.Add(this.btnWrong);
            this.Controls.Add(this.btnCorrect);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Flash Card Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.Button btnWrong;
        private System.Windows.Forms.Label lblScoreTxt;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnShowAnswer;
        private System.Windows.Forms.Label lblEnd;
    }
}

