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
    public partial class zd_3 : Form
    {
        private List<double> ch = new List<double>();
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

        }

        private void мінімумСередНепарнихToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void індексиЕлементівУМежах1050ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void кінецьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void записатиВМасивToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox_dani_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); 
            ch.Clear();     

            string input = textBox_dani.Text;
            string[] chas = input.Split(' ');
            int i = 0;

            while (i < chas.Length)
            {
                string part = chas[i];

                if (chas[i] != "")
                {
                    double n;
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

                i++;
            }

            listBox1.Items.Add("Елементи зчитано:");
            for (int j = 0; j < ch.Count; j++)
            {
                listBox1.Items.Add(ch[j].ToString());
            }
        }
    }
}
