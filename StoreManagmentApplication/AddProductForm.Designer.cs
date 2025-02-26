namespace StoreManagmentApplication
{
    partial class AddProductForm
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
            lblErrorMessage = new Label();
            btnAdd = new Button();
            lblPassword = new Label();
            txtPrice = new TextBox();
            lblUsername = new Label();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Location = new Point(116, 46);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(0, 20);
            lblErrorMessage.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAdd.Location = new Point(200, 194);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(153, 38);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPassword.Location = new Point(12, 140);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(54, 28);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtPrice.Location = new Point(116, 137);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(237, 34);
            txtPrice.TabIndex = 8;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblUsername.Location = new Point(12, 87);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(64, 28);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtName.Location = new Point(116, 84);
            txtName.Name = "txtName";
            txtName.Size = new Size(237, 34);
            txtName.TabIndex = 6;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 278);
            Controls.Add(lblErrorMessage);
            Controls.Add(btnAdd);
            Controls.Add(lblPassword);
            Controls.Add(txtPrice);
            Controls.Add(lblUsername);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddProductForm";
            Text = "AddProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblErrorMessage;
        private Button btnAdd;
        private Label lblPassword;
        private TextBox txtPrice;
        private Label lblUsername;
        private TextBox txtName;
    }
}