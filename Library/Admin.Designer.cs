namespace Library
{
    partial class Admin
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
            AddReaderButton = new Button();
            label1 = new Label();
            DeleteReaderButton = new Button();
            ModifyReaderButton = new Button();
            ModifyBookButton = new Button();
            DeleteBookButton = new Button();
            label2 = new Label();
            AddBookButton = new Button();
            label3 = new Label();
            ReaderQueryButton = new Button();
            BookQueryButton = new Button();
            NRQueryButton = new Button();
            FineButton = new Button();
            SuspendLayout();
            // 
            // AddReaderButton
            // 
            AddReaderButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddReaderButton.Location = new Point(50, 88);
            AddReaderButton.Name = "AddReaderButton";
            AddReaderButton.Size = new Size(94, 29);
            AddReaderButton.TabIndex = 0;
            AddReaderButton.Text = "添加";
            AddReaderButton.UseVisualStyleBackColor = true;
            AddReaderButton.Click += AddReaderButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("宋体", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(39, 28);
            label1.Name = "label1";
            label1.Size = new Size(128, 28);
            label1.TabIndex = 2;
            label1.Text = "读者管理";
            // 
            // DeleteReaderButton
            // 
            DeleteReaderButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteReaderButton.Location = new Point(452, 88);
            DeleteReaderButton.Name = "DeleteReaderButton";
            DeleteReaderButton.Size = new Size(94, 29);
            DeleteReaderButton.TabIndex = 3;
            DeleteReaderButton.Text = "删除";
            DeleteReaderButton.UseVisualStyleBackColor = true;
            DeleteReaderButton.Click += DeleteReaderButton_Click;
            // 
            // ModifyReaderButton
            // 
            ModifyReaderButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ModifyReaderButton.Location = new Point(242, 88);
            ModifyReaderButton.Name = "ModifyReaderButton";
            ModifyReaderButton.Size = new Size(94, 29);
            ModifyReaderButton.TabIndex = 4;
            ModifyReaderButton.Text = "修改";
            ModifyReaderButton.UseVisualStyleBackColor = true;
            ModifyReaderButton.Click += ModifyReaderButton_Click;
            // 
            // ModifyBookButton
            // 
            ModifyBookButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ModifyBookButton.Location = new Point(346, 218);
            ModifyBookButton.Name = "ModifyBookButton";
            ModifyBookButton.Size = new Size(94, 29);
            ModifyBookButton.TabIndex = 8;
            ModifyBookButton.Text = "修改";
            ModifyBookButton.UseVisualStyleBackColor = true;
            ModifyBookButton.Click += ModifyBookButton_Click;
            // 
            // DeleteBookButton
            // 
            DeleteBookButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBookButton.Location = new Point(641, 218);
            DeleteBookButton.Name = "DeleteBookButton";
            DeleteBookButton.Size = new Size(94, 29);
            DeleteBookButton.TabIndex = 7;
            DeleteBookButton.Text = "删除";
            DeleteBookButton.UseVisualStyleBackColor = true;
            DeleteBookButton.Click += DeleteBookButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("宋体", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(39, 158);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 6;
            label2.Text = "图书管理";
            // 
            // AddBookButton
            // 
            AddBookButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddBookButton.Location = new Point(50, 218);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Size = new Size(94, 29);
            AddBookButton.TabIndex = 5;
            AddBookButton.Text = "添加";
            AddBookButton.UseVisualStyleBackColor = true;
            AddBookButton.Click += AddBookButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("宋体", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(39, 290);
            label3.Name = "label3";
            label3.Size = new Size(128, 28);
            label3.TabIndex = 9;
            label3.Text = "信息查询";
            // 
            // ReaderQueryButton
            // 
            ReaderQueryButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ReaderQueryButton.Location = new Point(50, 351);
            ReaderQueryButton.Name = "ReaderQueryButton";
            ReaderQueryButton.Size = new Size(117, 29);
            ReaderQueryButton.TabIndex = 10;
            ReaderQueryButton.Text = "查询读者信息";
            ReaderQueryButton.UseVisualStyleBackColor = true;
            ReaderQueryButton.Click += ReaderQueryButton_Click;
            // 
            // BookQueryButton
            // 
            BookQueryButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BookQueryButton.Location = new Point(334, 351);
            BookQueryButton.Name = "BookQueryButton";
            BookQueryButton.Size = new Size(117, 29);
            BookQueryButton.TabIndex = 11;
            BookQueryButton.Text = "查询图书信息";
            BookQueryButton.UseVisualStyleBackColor = true;
            BookQueryButton.Click += BookQueryButton_Click;
            // 
            // NRQueryButton
            // 
            NRQueryButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NRQueryButton.Location = new Point(604, 351);
            NRQueryButton.Name = "NRQueryButton";
            NRQueryButton.Size = new Size(131, 29);
            NRQueryButton.TabIndex = 12;
            NRQueryButton.Text = "查询未归还图书";
            NRQueryButton.UseVisualStyleBackColor = true;
            NRQueryButton.Click += NRQueryButton_Click;
            // 
            // FineButton
            // 
            FineButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FineButton.Location = new Point(641, 88);
            FineButton.Name = "FineButton";
            FineButton.Size = new Size(94, 29);
            FineButton.TabIndex = 13;
            FineButton.Text = "收取罚款";
            FineButton.UseVisualStyleBackColor = true;
            FineButton.Click += FineButton_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FineButton);
            Controls.Add(NRQueryButton);
            Controls.Add(BookQueryButton);
            Controls.Add(ReaderQueryButton);
            Controls.Add(label3);
            Controls.Add(ModifyBookButton);
            Controls.Add(DeleteBookButton);
            Controls.Add(label2);
            Controls.Add(AddBookButton);
            Controls.Add(ModifyReaderButton);
            Controls.Add(DeleteReaderButton);
            Controls.Add(label1);
            Controls.Add(AddReaderButton);
            Name = "Admin";
            Text = "管理员";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddReaderButton;
        private Label label1;
        private Button DeleteReaderButton;
        private Button ModifyReaderButton;
        private Button ModifyBookButton;
        private Button DeleteBookButton;
        private Label label2;
        private Button AddBookButton;
        private Label label3;
        private Button ReaderQueryButton;
        private Button BookQueryButton;
        private Button NRQueryButton;
        private Button FineButton;
    }
}