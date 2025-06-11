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

                if (!double.TryParse(textBox1.Text, out double x) ||
                    !double.TryParse(textBox2.Text, out double y) ||
                    !double.TryParse(textBox3.Text, out double step))
                {
                    MessageBox.Show("Будь ласка, введіть коректні числові значення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (step <= 0)
                {
                    MessageBox.Show("Крок повинен бути більше нуля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (double i = x; i <= y; i += step)
                {
                    double result = Math.Cos(i) - 5;
                    listBox_output.Items.Add($"x = {i:F2}, y = {result:F4}");
                }
            }
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
