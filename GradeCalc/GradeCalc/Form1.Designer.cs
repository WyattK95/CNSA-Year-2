namespace GradeCalc
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
            gradesGridView = new DataGridView();
            Grades = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBoxMean = new TextBox();
            textBoxMedian = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)gradesGridView).BeginInit();
            SuspendLayout();
            // 
            // gradesGridView
            // 
            gradesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gradesGridView.Columns.AddRange(new DataGridViewColumn[] { Grades });
            gradesGridView.Location = new Point(36, 22);
            gradesGridView.Name = "gradesGridView";
            gradesGridView.Size = new Size(165, 500);
            gradesGridView.TabIndex = 0;
            // 
            // Grades
            // 
            Grades.HeaderText = "Grades";
            Grades.Name = "Grades";
            // 
            // button1
            // 
            button1.Location = new Point(258, 41);
            button1.Name = "button1";
            button1.Size = new Size(125, 36);
            button1.TabIndex = 1;
            button1.Text = "CALCULATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxMean
            // 
            textBoxMean.Location = new Point(351, 156);
            textBoxMean.Name = "textBoxMean";
            textBoxMean.Size = new Size(126, 23);
            textBoxMean.TabIndex = 2;
            // 
            // textBoxMedian
            // 
            textBoxMedian.Location = new Point(351, 196);
            textBoxMedian.Name = "textBoxMedian";
            textBoxMedian.Size = new Size(126, 23);
            textBoxMedian.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 159);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 4;
            label1.Text = "Mean";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 199);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 5;
            label2.Text = "Median";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 558);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxMedian);
            Controls.Add(textBoxMean);
            Controls.Add(button1);
            Controls.Add(gradesGridView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gradesGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gradesGridView;
        private Button button1;
        private TextBox textBoxMean;
        private TextBox textBoxMedian;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn Grades;
    }
}
