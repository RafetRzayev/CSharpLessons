namespace WinFormsApp1
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
            timer1 = new System.Windows.Forms.Timer(components);
            btnBall = new Button();
            button2 = new Button();
            pnlStick = new Panel();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // btnBall
            // 
            btnBall.BackColor = Color.FromArgb(192, 0, 0);
            btnBall.FlatAppearance.BorderSize = 0;
            btnBall.FlatStyle = FlatStyle.Flat;
            btnBall.Location = new Point(155, 206);
            btnBall.Name = "btnBall";
            btnBall.Size = new Size(33, 32);
            btnBall.TabIndex = 0;
            btnBall.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Start";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pnlStick
            // 
            pnlStick.BackColor = Color.FromArgb(0, 0, 192);
            pnlStick.Location = new Point(34, 536);
            pnlStick.Name = "pnlStick";
            pnlStick.Size = new Size(213, 30);
            pnlStick.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pnlStick);
            Controls.Add(button2);
            Controls.Add(btnBall);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button btnBall;
        private Button button2;
        private Panel pnlStick;
    }
}
