using System.Diagnostics;
using System.Windows.Forms;

namespace GradeCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gradesGridView.CellValidating += GradesGridView_CellValidating;
        }

        private void GradesGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.FormattedValue.ToString() != string.Empty)
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out _))
                {
                    e.Cancel = true;
                    gradesGridView.Rows[e.RowIndex].ErrorText = "Please enter a valid integer.";
                    MessageBox.Show("Only integer values are allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    gradesGridView.Rows[e.RowIndex].ErrorText = string.Empty;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> grades = new List<int>();

            foreach (DataGridViewRow row in gradesGridView.Rows)
            {
                if (row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out int grade))
                {
                    grades.Add(grade);
                }
            }

            if (grades.Count > 0)
            {
                double mean = grades.Average();
                textBoxMean.Text = mean.ToString("F2");

                grades.Sort();
                double median;
                int middleIndex = grades.Count / 2;

                if (grades.Count % 2 == 0)
                {
                    median = (grades[middleIndex - 1] + grades[middleIndex]) / 2.0;
                }
                else
                {
                    median = grades[middleIndex];
                }

                textBoxMedian.Text = median.ToString("F2");
            }
            else
            {
                MessageBox.Show("Please enter at least one valid grade.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Trace.WriteLine("The button is working");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
