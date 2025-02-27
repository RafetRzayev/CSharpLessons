namespace MovieFilterApp
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
            cmbGenres = new ComboBox();
            SuspendLayout();
            // 
            // cmbGenres
            // 
            cmbGenres.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenres.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbGenres.FormattingEnabled = true;
            cmbGenres.Location = new Point(623, 12);
            cmbGenres.Name = "cmbGenres";
            cmbGenres.Size = new Size(151, 36);
            cmbGenres.TabIndex = 0;
            cmbGenres.SelectedIndexChanged += cmbGenres_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbGenres);
            Name = "Form1";
            Text = "Form1";
            Resize += Form1_Resize;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbGenres;
    }
}
