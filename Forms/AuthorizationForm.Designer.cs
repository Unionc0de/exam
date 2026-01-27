namespace exam.Forms
{
    partial class AuthorizationForm
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
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            button = new Button();
            label1 = new Label();
            label2 = new Label();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(257, 147);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(273, 23);
            userNameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(257, 233);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(273, 23);
            passwordTextBox.TabIndex = 1;
            // 
            // button
            // 
            button.Location = new Point(341, 331);
            button.Name = "button";
            button.Size = new Size(114, 49);
            button.TabIndex = 2;
            button.Text = "OK";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(257, 119);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 3;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(257, 205);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(192, 0, 0);
            exitBtn.ForeColor = Color.Snow;
            exitBtn.Location = new Point(674, 389);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(114, 49);
            exitBtn.TabIndex = 5;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Name = "AuthorizationForm";
            Text = "AuthorizationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Button button;
        private Label label1;
        private Label label2;
        private Button exitBtn;
    }
}