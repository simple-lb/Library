namespace Library
{
    partial class ReaderQuery
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
            AccountTextBox = new TextBox();
            label3 = new Label();
            ReaderInfoButton = new Button();
            NRBookButton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // AccountTextBox
            // 
            AccountTextBox.Location = new Point(135, 27);
            AccountTextBox.Margin = new Padding(3, 2, 3, 2);
            AccountTextBox.Name = "AccountTextBox";
            AccountTextBox.Size = new Size(219, 27);
            AccountTextBox.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(35, 31);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 16;
            label3.Text = "借书证号";
            // 
            // ReaderInfoButton
            // 
            ReaderInfoButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ReaderInfoButton.Location = new Point(457, 27);
            ReaderInfoButton.Name = "ReaderInfoButton";
            ReaderInfoButton.Size = new Size(122, 29);
            ReaderInfoButton.TabIndex = 18;
            ReaderInfoButton.Text = "读者资料查询";
            ReaderInfoButton.UseVisualStyleBackColor = true;
            ReaderInfoButton.Click += ReaderInfoButton_Click;
            // 
            // NRBookButton
            // 
            NRBookButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NRBookButton.Location = new Point(615, 27);
            NRBookButton.Name = "NRBookButton";
            NRBookButton.Size = new Size(129, 29);
            NRBookButton.TabIndex = 19;
            NRBookButton.Text = "未归还图书查询";
            NRBookButton.UseVisualStyleBackColor = true;
            NRBookButton.Click += NRBookButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ImeMode = ImeMode.NoControl;
            dataGridView1.Location = new Point(35, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(709, 307);
            dataGridView1.TabIndex = 20;
            // 
            // ReaderQuery
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(NRBookButton);
            Controls.Add(ReaderInfoButton);
            Controls.Add(AccountTextBox);
            Controls.Add(label3);
            Name = "ReaderQuery";
            Text = "读者信息查询";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AccountTextBox;
        private Label label3;
        private Button ReaderInfoButton;
        private Button NRBookButton;
        private DataGridView dataGridView1;
    }
}