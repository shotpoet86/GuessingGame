//Programmer: Austin Parker
//Date: May 20,2020
//Purpose: Creates a guessing game where users can input any number
//of guesses and colors change based on user input.


namespace GuessingGame
{
    partial class GuessingGame
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";


            this.label1 = new System.Windows.Forms.Label();
            this.lblGuessCount = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGuessNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            
            // label1
            
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Guess Count:";
            
            // lblGuessCount
            
            this.lblGuessCount.AutoSize = true;
            this.lblGuessCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessCount.Location = new System.Drawing.Point(116, 56);
            this.lblGuessCount.Name = "lblGuessCount";
            this.lblGuessCount.Size = new System.Drawing.Size(14, 13);
            this.lblGuessCount.TabIndex = 1;
            this.lblGuessCount.Text = "0";
            
            // btnGuess
            
            this.btnGuess.Location = new System.Drawing.Point(15, 88);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            
            // btnReset
            
            this.btnReset.Location = new System.Drawing.Point(119, 88);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            
            // label2
            
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Number:";
            
            // txtGuessNumber
            
            this.txtGuessNumber.Location = new System.Drawing.Point(119, 26);
            this.txtGuessNumber.Name = "txtGuessNumber";
            this.txtGuessNumber.Size = new System.Drawing.Size(100, 20);
            this.txtGuessNumber.TabIndex = 5;
            
            // Form1
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 145);
            this.Controls.Add(this.txtGuessNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblGuessCount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Guess Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGuessCount;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuessNumber;
    }
}






