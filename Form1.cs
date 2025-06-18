using System;
using System.Windows.Forms;
namespace math_zadach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            zd_1cs form = new zd_1cs();
            form.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            zd_2 form = new zd_2();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zd_3 form = new zd_3();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zd_4cs form = new zd_4cs();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            magaz form = new magaz();
            form.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //exit form = new exit();
            //if (form.ShowDialog() == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }
    }
}