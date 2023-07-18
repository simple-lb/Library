namespace Library
{
    partial class Reader
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
            ChangePasswordButton = new Button();
            ModifyButton = new Button();
            label3 = new Label();
            BorrowButton = new Button();
            ReturnButton = new Button();
            label2 = new Label();
            SearchBookButton = new Button();
            SuspendLayout();
            // 
            // ChangePasswordButton
            // 
            ChangePasswordButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ChangePasswordButton.Location = new Point(334, 347);
            ChangePasswordButton.Name = "ChangePasswordButton";
            ChangePasswordButton.Size = new Size(117, 29);
            ChangePasswordButton.TabIndex = 23;
            ChangePasswordButton.Text = "修改密码";
            ChangePasswordButton.UseVisualStyleBackColor = true;
            ChangePasswordButton.Click += ChangePasswordButton_Click;
            // 
            // ModifyButton
            // 
            ModifyButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ModifyButton.Location = new Point(63, 347);
            ModifyButton.Name = "ModifyButton";
            ModifyButton.Size = new Size(117, 29);
            ModifyButton.TabIndex = 22;
            ModifyButton.Text = "修改个人信息";
            ModifyButton.UseVisualStyleBackColor = true;
            ModifyButton.Click += ModifyButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("宋体", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(40, 262);
            label3.Name = "label3";
            label3.Size = new Size(128, 28);
            label3.TabIndex = 21;
            label3.Text = "信息修改";
            // 
            // BorrowButton
            // 
            BorrowButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BorrowButton.Location = new Point(345, 140);
            BorrowButton.Name = "BorrowButton";
            BorrowButton.Size = new Size(94, 29);
            BorrowButton.TabIndex = 20;
            BorrowButton.Text = "借书";
            BorrowButton.UseVisualStyleBackColor = true;
            BorrowButton.Click += BorrowButton_Click;
            // 
            // ReturnButton
            // 
            ReturnButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnButton.Location = new Point(628, 140);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(94, 29);
            ReturnButton.TabIndex = 19;
            ReturnButton.Text = "还书";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("宋体", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(40, 44);
            label2.Name = "label2";
            label2.Size = new Size(215, 28);
            label2.TabIndex = 18;
            label2.Text = "图书借阅和归还";
            // 
            // SearchBookButton
            // 
            SearchBookButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBookButton.Location = new Point(63, 140);
            SearchBookButton.Name = "SearchBookButton";
            SearchBookButton.Size = new Size(94, 29);
            SearchBookButton.TabIndex = 17;
            SearchBookButton.Text = "搜索图书";
            SearchBookButton.UseVisualStyleBackColor = true;
            SearchBookButton.Click += SearchBookButton_Click;
            // 
            // Reader
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ChangePasswordButton);
            Controls.Add(ModifyButton);
            Controls.Add(label3);
            Controls.Add(BorrowButton);
            Controls.Add(ReturnButton);
            Controls.Add(label2);
            Controls.Add(SearchBookButton);
            Name = "Reader";
            Text = "读者";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ChangePasswordButton;
        private Button ModifyButton;
        private Label label3;
        private Button BorrowButton;
        private Button ReturnButton;
        private Label label2;
        private Button SearchBookButton;
    }
}