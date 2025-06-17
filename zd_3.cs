using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace math_zadach
{
    public partial class zd_3 : Form
    {
        private List<double> ch = new List<double>();
        private double[] arr;

        public zd_3()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void zd_3_Load(object sender, EventArgs e)
        {

        }

        private void добутокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (ch.Count == 0)
            {
                listBox1.Items.Add("Список пустий.");
                return;
            }

            double product = 1;
            bool dod = false;

            for (int i = 0; i < ch.Count; i++)
            {
                if (ch[i] > 0)
                {
                    product += ch[i];
                    dod = true;
                }
            }

            if (dod)
                listBox1.Items.Add("Сума додатніх елементів: " + product.ToString());
            else
                listBox1.Items.Add("Додатніх елементів немає.");
        }

        private void мінімумСередНепарнихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (ch.Count == 0)
            {
                listBox1.Items.Add("Список пустий.");
                return;
            }

            double min = double.MaxValue;
            bool zn = false;

            for (int i = 0; i < ch.Count; i++)
            {
  
                if (((int)ch[i]) % 2 != 0)
                {
                    if (!zn || ch[i] < min)
                    {
                        min = ch[i];
                        zn = true;
                    }
                }
            }

            if (!zn)
            {
                listBox1.Items.Add("Немає непарних елементів.");
            }
            else
            {
                listBox1.Items.Add("Мінімум серед непарних: " + min.ToString());
            }
        }

        private void індексиЕлементівУМежах1050ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string result = "Індекси елементів у межах 10-50: ";

            bool zn = false;
            for (int i = 0; i < ch.Count; i++)
            {
                if (ch[i] >= 10 && ch[i] <= 50)
                {
                    result += i.ToString() + " ";
                    zn= true;
                }
            }

            if (!zn)
            {
                listBox1.Items.Add("Елементів у межах 10-50 немає.");
            }
            else
            {
                listBox1.Items.Add(result);
            }
        }

        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ch.Clear();
            listBox1.Items.Clear();
            textBox_dani.Clear();
        }

        private void кінецьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void записатиВМасивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (ch.Count == 0)
            {
                listBox1.Items.Add("Список пустий.");
                return;
            }

            arr = ch.ToArray();

            listBox1.Items.Add("Дані записані в масив. Розмір масиву: " + arr.Length);
            listBox1.Items.Add("Масив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                listBox1.Items.Add(arr[i].ToString());
            }
        }

        private void textBox_dani_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ch.Clear();

            string input = textBox_dani.Text;
            string[] chas = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double n;
            for (int i = 0; i < chas.Length; i++)
            {
                if (double.TryParse(chas[i], out n))
                {
                    ch.Add(n);
                }
                else
                {
                    MessageBox.Show("Помилка: '" + chas[i] + "' не є числом.");
                    return;
                }
                
            }

            listBox1.Items.Add("Елементи зчитано:");
            for (int j = 0; j < ch.Count; j++)
            {
                listBox1.Items.Add(ch[j].ToString());
            }
        }
    }
}
