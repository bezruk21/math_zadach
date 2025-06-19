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
    public partial class sale : Form
    {
        public sale()
        {
            InitializeComponent();
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void sale_Load(object sender, EventArgs e)
        {
            int sum = 0;
            string[] lines = File.ReadAllLines("cart.txt");
            foreach (string line in lines)
            {
                if (line!="")
                    listBox1.Items.Add(line);
            }
            foreach (string line in lines)
            {
                if (line != "")
                {
                    string[] item = line.Split(',');
                    string[] price = item[2].Split(' ');
                    sum += int.Parse(price[0]);
                }
            }
            textBox1.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("cart.txt");
            writer.WriteLine();
            writer.Close();
            textBox1.Text = string.Empty;
            listBox1.Items.Clear();
        }

        private void button_zamovl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("А далі нема:)", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
