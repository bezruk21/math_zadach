using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_zadach
{
    public partial class zd_1cs : Form
    {
        public zd_1cs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
            textBox2.Text="";
            textBox3.Text="";
            listBox_result.Items.Clear();
            listBox_output.Items.Clear();
            radioButton_area.Checked = false;
            radioButton_volume.Checked = false;
            radioButton_perimeter.Checked = false;
        }

        private void radioButton_area_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Visible=true;
            label_radius.Text="Радіус";
            textBox2.Visible=false;
            label_a.Text="";
            textBox3.Visible=false;
            label_h.Text="";
            textBox1.Text="";
            textBox2.Text="";
            textBox3.Text="";
        }

        private void button_count_Click(object sender, EventArgs e)
        {
            listBox_result.Items.Clear();
            listBox_output.Items.Clear();


            double result = 0;

            if (radioButton_area.Checked)
            {
                if (double.TryParse(textBox1.Text, out double radius)&&radius>0)
                {

                    result = Math.PI * radius * radius;
                    listBox_result.Items.Add($"Площа круга з радіусом {radius} = {result:F2}");
                    listBox_output.Items.Add("Обрана дія: Площа круга");
                    listBox_output.Items.Add($"Радіус = {radius}");
                    listBox_output.Items.Add(result.ToString("F2"));
                }
                else
                {
                    MessageBox.Show("Введіть правильне число для радіуса.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (radioButton_volume.Checked)
            {

                if (double.TryParse(textBox1.Text, out double a) &&a>0&&
                    double.TryParse(textBox2.Text, out double b) &&b>0&&
                    double.TryParse(textBox3.Text, out double h)&&h>0)
                {
                    result = a * b * h;
                    listBox_result.Items.Add($"Об'єм паралелепіпеда {a}×{b}×{h} = {result:F2}");
                    listBox_output.Items.Add("Обрана дія: Об'єм паралелепіпеда");
                    listBox_output.Items.Add($"Сторона a = {a}");
                    listBox_output.Items.Add($"Сторона b = {b}");
                    listBox_output.Items.Add($"Висота h = {h}");
                    listBox_output.Items.Add(result.ToString("F2"));
                }
                else
                {
                    MessageBox.Show("Введіть правильні числа для a, b і h.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else if (radioButton_perimeter.Checked)
            {

                if (double.TryParse(textBox2.Text, out double a) &&a>0&&
                    double.TryParse(textBox3.Text, out double b)&&b>0)
                {
                    result = 2 * (a + b);
                    listBox_result.Items.Add($"Периметр прямокутника {a}×{b} = {result:F2}");
                    listBox_output.Items.Add("Обрана дія: Периметр прямокутника");
                    listBox_output.Items.Add($"Сторона a = {a}");
                    listBox_output.Items.Add($"Сторона b = {b}");
                    listBox_output.Items.Add(result.ToString("F2"));
                }
                else
                {
                    MessageBox.Show("Введіть правильні числа для сторін a і b.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Оберіть одну з опцій обчислення.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton_volume_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Visible=true;
            textBox3.Visible = true;
            label_radius.Text="a";
            label_a.Text="b";
            label_h.Text="h";
            textBox1.Text="";
            textBox2.Text="";
            textBox3.Text="";
        }

        private void radioButton_perimeter_CheckedChanged(object sender, EventArgs e)
        {
            label_radius.Text="a";
            textBox3.Visible=false;
            label_h.Text="";
            textBox1.Text="";
            textBox2.Text="";
            textBox3.Text="";
        }

        private void label_radius_Click(object sender, EventArgs e)
        {

        }

        private void listBox_output_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_result_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
