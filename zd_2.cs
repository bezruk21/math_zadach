using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using static System.Windows.Forms.LinkLabel;

namespace math_zadach
{
    public partial class zd_2 : Form
    {
        public zd_2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            listBox_output.Items.Clear();
        }

        private void протаблюватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                listBox_output.Items.Clear();

                if (!double.TryParse(textBox1.Text, out double a) || 
                    !double.TryParse(textBox2.Text, out double b) ||
                    !double.TryParse(textBox3.Text, out double step))
                {
                    MessageBox.Show("Будь ласка, введіть коректні числові значення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    listBox_output.Items.Clear();
                    return;
                }

                if (a > b)
                {
                    MessageBox.Show("Початок діапазону (A) не може бути більшим за кінець (B).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    listBox_output.Items.Clear();
                    return;
                }


                if (step <= 0)
                {
                    MessageBox.Show("Крок повинен бути більше нуля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    listBox_output.Items.Clear();
                    return;
                }
                int negative_ch= 0;
                List<string> lines = new List<string>();


                for (double x = a; x <= b; x += step)
                {
                    double y = Math.Pow(x, 3) - 4 * x;
                    string line = $"X = {x:F2}, Y = {y:F4}";
                    lines.Add(line);
                    if (y < 0)
                        negative_ch++;
                }

                listBox_output.Items.Add($"---");
                listBox_output.Items.Add($"Кількість від’ємних Y(X): {negative_ch}");
                listBox_output.Items.AddRange(lines.ToArray());
                File.WriteAllLines("output.txt", lines);
            }
            MessageBox.Show("Результати збережено у файл output.txt", "Файл збережено", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void кінецьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox_output_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
