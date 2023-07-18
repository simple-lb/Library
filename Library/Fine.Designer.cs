namespace Library
{
    partial class Fine
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
            ISBNTextBox = new TextBox();
            label4 = new Label();
            AccountTextBox = new TextBox();
            label3 = new Label();
            FineButton = new Button();
            SuspendLayout();
            // 
            // ISBNTextBox
            // 
            ISBNTextBox.Location = new Point(335, 217);
            ISBNTextBox.Margin = new Padding(3, 2, 3, 2);
            ISBNTextBox.Name = "ISBNTextBox";
            ISBNTextBox.Size = new Size(219, 27);
            ISBNTextBox.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(240, 221);
            label4.Name = "label4";
            label4.Size = new Size(80, 18);
            label4.TabIndex = 38;
            label4.Text = "ISBN书号";
            // 
            // AccountTextBox
            // 
            AccountTextBox.Location = new Point(335, 132);
            AccountTextBox.Margin = new Padding(3, 2, 3, 2);
            AccountTextBox.Name = "AccountTextBox";
            AccountTextBox.Size = new Size(219, 27);
            AccountTextBox.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(240, 136);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 36;
            label3.Text = "借书证号";
            // 
            // FineButton
            // 
            FineButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FineButton.Location = new Point(355, 328);
            FineButton.Name = "FineButton";
            FineButton.Size = new Size(79, 26);
            FineButton.TabIndex = 40;
            FineButton.Text = "收取";
            FineButton.UseVisualStyleBackColor = true;
            FineButton.Click += FineButton_Click;
            // 
            // Fine
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FineButton);
            Controls.Add(ISBNTextBox);
            Controls.Add(label4);
            Controls.Add(AccountTextBox);
            Controls.Add(label3);
            Name = "Fine";
            Text = "罚款收取";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ISBNTextBox;
        private Label label4;
        private TextBox AccountTextBox;
        private Label label3;
        private Button FineButton;
    }
}