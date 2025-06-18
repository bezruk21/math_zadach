using System;
using System.Windows.Forms;

namespace math_zadach
{
    public partial class zd_4cs : Form
    {
        private int[,] arr;

        public zd_4cs()
        {
            InitializeComponent();
        }

        private void додатиРядкиІСтовбціToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rows = (int)numericUpDown_line.Value;
            int cols = (int)numericUpDown_column.Value;

            if (rows != cols)
            {
                MessageBox.Show("Матриця має бути квадратною для побічної діагоналі.");
                return;
            }

            arr = new int[rows, cols];
            dataGridView1.RowCount = rows;
            dataGridView1.ColumnCount = cols;
            listBox_rezult.Items.Clear();

            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = rnd.Next(0, 20);
                    dataGridView1.Rows[i].Cells[j].Value = arr[i, j];
                }
            }

            listBox_rezult.Items.Add("Матриця заповнена випадковими числами.");
        }

        private void середнєНаПобічнійДіагоналіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (arr == null)
            {
                MessageBox.Show("Спочатку додайте матрицю.");
                return;
            }

            int size = arr.GetLength(0);
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += arr[i, size - 1 - i];
            }

            double avg = (double)sum / size;
            string result = $"Середнє значення на побічній діагоналі: {avg:F2}";
            listBox_rezult.Items.Add(result);
        }

        private void сумаНижчеПобічноїДфагоналіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (arr == null)
            {
                MessageBox.Show("Спочатку додайте матрицю.");
                return;
            }

            int size = arr.GetLength(0);
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i + j > size - 1)
                    {
                        sum += arr[i, j];
                    }
                }
            }

            string result = $"Сума елементів нижче побічної діагоналі: {sum}";
            listBox_rezult.Items.Add(result);
        }

        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            listBox_rezult.Items.Clear();
            
            
            arr = null;
            numericUpDown_line.Value = 0;
            numericUpDown_column.Value = 0;
        }

        private void кінецьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numericUpDown_line_ValueChanged(object sender, EventArgs e) { }
        private void numericUpDown_column_ValueChanged(object sender, EventArgs e) { }
        private void listBox_rezult_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
