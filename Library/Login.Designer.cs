namespace Library
{
    partial class Login
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
            LoginButton = new Button();
            label1 = new Label();
            AccountTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Location = new Point(259, 246);
            LoginButton.Margin = new Padding(3, 2, 3, 2);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(93, 28);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "登录";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(152, 115);
            label1.Name = "label1";
            label1.Size = new Size(44, 18);
            label1.TabIndex = 1;
            label1.Text = "账号";
            // 
            // AccountTextBox
            // 
            AccountTextBox.Location = new Point(216, 110);
            AccountTextBox.Margin = new Padding(3, 2, 3, 2);
            AccountTextBox.Name = "AccountTextBox";
            AccountTextBox.Size = new Size(219, 25);
            AccountTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(216, 157);
            PasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(219, 25);
            PasswordTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(152, 162);
            label2.Name = "label2";
            label2.Size = new Size(44, 18);
            label2.TabIndex = 3;
            label2.Text = "密码";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("宋体", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(233, 49);
            label3.Name = "label3";
            label3.Size = new Size(154, 23);
            label3.TabIndex = 5;
            label3.Text = "图书管理系统";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 338);
            Controls.Add(label3);
            Controls.Add(PasswordTextBox);
            Controls.Add(label2);
            Controls.Add(AccountTextBox);
            Controls.Add(label1);
            Controls.Add(LoginButton);
            Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "登录";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private Label label1;
        private TextBox AccountTextBox;
        private TextBox PasswordTextBox;
        private Label label2;
        private Label label3;
    }
}