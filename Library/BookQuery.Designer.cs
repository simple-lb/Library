namespace Library
{
    partial class BookQuery
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
            dataGridView1 = new DataGridView();
            BookInfoButton = new Button();
            ISBNTextBox = new TextBox();
            label3 = new Label();
            BnameTextBox = new TextBox();
            label1 = new Label();
            AuthorTextBox = new TextBox();
            label2 = new Label();
            PressTextBox = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ImeMode = ImeMode.NoControl;
            dataGridView1.Location = new Point(46, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(709, 307);
            dataGridView1.TabIndex = 25;
            // 
            // BookInfoButton
            // 
            BookInfoButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BookInfoButton.Location = new Point(700, 67);
            BookInfoButton.Name = "BookInfoButton";
            BookInfoButton.Size = new Size(55, 29);
            BookInfoButton.TabIndex = 23;
            BookInfoButton.Text = "查询";
            BookInfoButton.UseVisualStyleBackColor = true;
            BookInfoButton.Click += BookInfoButton_Click;
            // 
            // ISBNTextBox
            // 
            ISBNTextBox.Location = new Point(132, 26);
            ISBNTextBox.Margin = new Padding(3, 2, 3, 2);
            ISBNTextBox.Name = "ISBNTextBox";
            ISBNTextBox.Size = new Size(219, 27);
            ISBNTextBox.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 30);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 21;
            label3.Text = "ISBN书号";
            // 
            // BnameTextBox
            // 
            BnameTextBox.Location = new Point(446, 26);
            BnameTextBox.Margin = new Padding(3, 2, 3, 2);
            BnameTextBox.Name = "BnameTextBox";
            BnameTextBox.Size = new Size(219, 27);
            BnameTextBox.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(396, 30);
            label1.Name = "label1";
            label1.Size = new Size(44, 18);
            label1.TabIndex = 26;
            label1.Text = "书名";
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(446, 69);
            AuthorTextBox.Margin = new Padding(3, 2, 3, 2);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(219, 27);
            AuthorTextBox.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(396, 73);
            label2.Name = "label2";
            label2.Size = new Size(44, 18);
            label2.TabIndex = 28;
            label2.Text = "作者";
            // 
            // PressTextBox
            // 
            PressTextBox.Location = new Point(132, 69);
            PressTextBox.Margin = new Padding(3, 2, 3, 2);
            PressTextBox.Name = "PressTextBox";
            PressTextBox.Size = new Size(219, 27);
            PressTextBox.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(64, 73);
            label4.Name = "label4";
            label4.Size = new Size(62, 18);
            label4.TabIndex = 30;
            label4.Text = "出版社";
            // 
            // BookQuery
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PressTextBox);
            Controls.Add(label4);
            Controls.Add(AuthorTextBox);
            Controls.Add(label2);
            Controls.Add(BnameTextBox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(BookInfoButton);
            Controls.Add(ISBNTextBox);
            Controls.Add(label3);
            Name = "BookQuery";
            Text = "图书信息查询";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BookInfoButton;
        private TextBox ISBNTextBox;
        private Label label3;
        private TextBox BnameTextBox;
        private Label label1;
        private TextBox AuthorTextBox;
        private Label label2;
        private TextBox PressTextBox;
        private Label label4;
    }
}