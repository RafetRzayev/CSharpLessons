namespace TicTacToe
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
            btnNewGame = new Button();
            lblResultMessage = new Label();
            SuspendLayout();
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(92, 12);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(124, 29);
            btnNewGame.TabIndex = 0;
            btnNewGame.Text = "New game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // lblResultMessage
            // 
            lblResultMessage.AutoSize = true;
            lblResultMessage.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultMessage.ForeColor = Color.LimeGreen;
            lblResultMessage.Location = new Point(56, 311);
            lblResultMessage.Name = "lblResultMessage";
            lblResultMessage.Size = new Size(223, 37);
            lblResultMessage.TabIndex = 1;
            lblResultMessage.Text = "Result message";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 368);
            Controls.Add(lblResultMessage);
            Controls.Add(btnNewGame);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewGame;
        private Label lblResultMessage;
    }
}
