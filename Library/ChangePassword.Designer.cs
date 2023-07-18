namespace Library
{
    partial class ChangePassword
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
            NewTextBox = new TextBox();
            label4 = new Label();
            OldTextBox = new TextBox();
            label3 = new Label();
            ChangeButton = new Button();
            SuspendLayout();
            // 
            // NewTextBox
            // 
            NewTextBox.Location = new Point(311, 213);
            NewTextBox.Margin = new Padding(3, 2, 3, 2);
            NewTextBox.Name = "NewTextBox";
            NewTextBox.Size = new Size(219, 27);
            NewTextBox.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(234, 217);
            label4.Name = "label4";
            label4.Size = new Size(62, 18);
            label4.TabIndex = 34;
            label4.Text = "新密码";
            // 
            // OldTextBox
            // 
            OldTextBox.Location = new Point(311, 128);
            OldTextBox.Margin = new Padding(3, 2, 3, 2);
            OldTextBox.Name = "OldTextBox";
            OldTextBox.Size = new Size(219, 27);
            OldTextBox.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(234, 132);
            label3.Name = "label3";
            label3.Size = new Size(62, 18);
            label3.TabIndex = 32;
            label3.Text = "原密码";
            // 
            // ChangeButton
            // 
            ChangeButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeButton.Location = new Point(323, 314);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(94, 29);
            ChangeButton.TabIndex = 36;
            ChangeButton.Text = "修改";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ChangeButton);
            Controls.Add(NewTextBox);
            Controls.Add(label4);
            Controls.Add(OldTextBox);
            Controls.Add(label3);
            Name = "ChangePassword";
            Text = "修改密码";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NewTextBox;
        private Label label4;
        private TextBox OldTextBox;
        private Label label3;
        private Button ChangeButton;
    }
}