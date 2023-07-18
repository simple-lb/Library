namespace Library
{
    partial class Book
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
            DaysTextBox = new TextBox();
            label2 = new Label();
            ISBNTextBox = new TextBox();
            label1 = new Label();
            BookButton = new Button();
            SuspendLayout();
            // 
            // DaysTextBox
            // 
            DaysTextBox.Location = new Point(326, 216);
            DaysTextBox.Margin = new Padding(3, 2, 3, 2);
            DaysTextBox.Name = "DaysTextBox";
            DaysTextBox.Size = new Size(219, 27);
            DaysTextBox.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(226, 220);
            label2.Name = "label2";
            label2.Size = new Size(80, 18);
            label2.TabIndex = 29;
            label2.Text = "借阅天数";
            // 
            // ISBNTextBox
            // 
            ISBNTextBox.Location = new Point(326, 134);
            ISBNTextBox.Margin = new Padding(3, 2, 3, 2);
            ISBNTextBox.Name = "ISBNTextBox";
            ISBNTextBox.Size = new Size(219, 27);
            ISBNTextBox.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(226, 138);
            label1.Name = "label1";
            label1.Size = new Size(80, 18);
            label1.TabIndex = 27;
            label1.Text = "ISBN书号";
            // 
            // BookButton
            // 
            BookButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BookButton.Location = new Point(352, 299);
            BookButton.Name = "BookButton";
            BookButton.Size = new Size(91, 29);
            BookButton.TabIndex = 31;
            BookButton.UseVisualStyleBackColor = true;
            // 
            // Book
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BookButton);
            Controls.Add(DaysTextBox);
            Controls.Add(label2);
            Controls.Add(ISBNTextBox);
            Controls.Add(label1);
            Name = "Book";
            Text = "Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DaysTextBox;
        private Label label2;
        private TextBox ISBNTextBox;
        private Label label1;
        private Button BookButton;
    }
}