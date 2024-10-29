namespace HelloWindows
{
    partial class Form1
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
            label1 = new Label();
            nameBox = new TextBox();
            button1 = new Button();
            label2 = new Label();
            greetingBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(114, 19);
            label1.TabIndex = 0;
            label1.Text = "Enter your name:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            nameBox.Location = new Point(142, 36);
            nameBox.Name = "textBox1";
            nameBox.Size = new Size(237, 23);
            nameBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(169, 83);
            button1.Name = "button1";
            button1.Size = new Size(141, 24);
            button1.TabIndex = 2;
            button1.Text = "Generate Greeting";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(49, 136);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 3;
            label2.Text = "Greeting:";
            // 
            // textBox2
            // 
            greetingBox.Location = new Point(142, 136);
            greetingBox.Name = "greetingBox";
            greetingBox.Size = new Size(377, 23);
            greetingBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 206);
            Controls.Add(greetingBox);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(nameBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameBox;
        private Button button1;
        private Label label2;
        private TextBox greetingBox;
    }
}
