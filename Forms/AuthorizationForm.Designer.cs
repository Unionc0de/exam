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
            regBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            exitBtn = new Button();
            authBtn = new Button();
            guestBtn = new Button();
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
            // regBtn
            // 
            regBtn.Location = new Point(257, 324);
            regBtn.Name = "regBtn";
            regBtn.Size = new Size(114, 49);
            regBtn.TabIndex = 2;
            regBtn.Text = "Sign up";
            regBtn.UseVisualStyleBackColor = true;
            regBtn.Click += button_Click;
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
            // authBtn
            // 
            authBtn.Location = new Point(416, 324);
            authBtn.Name = "authBtn";
            authBtn.Size = new Size(114, 49);
            authBtn.TabIndex = 6;
            authBtn.Text = "Log in";
            authBtn.UseVisualStyleBackColor = true;
            authBtn.Click += authBtn_Click;
            // 
            // guestBtn
            // 
            guestBtn.BackColor = SystemColors.Control;
            guestBtn.Location = new Point(257, 262);
            guestBtn.Name = "guestBtn";
            guestBtn.Size = new Size(273, 23);
            guestBtn.TabIndex = 7;
            guestBtn.Text = "Continue like guest";
            guestBtn.UseVisualStyleBackColor = false;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(guestBtn);
            Controls.Add(authBtn);
            Controls.Add(exitBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(regBtn);
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
        private Button regBtn;
        private Label label1;
        private Label label2;
        private Button exitBtn;
        private Button authBtn;
        private Button guestBtn;
    }
}