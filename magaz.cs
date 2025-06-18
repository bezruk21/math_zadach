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
    public partial class magaz : Form

    {
        public magaz()

        {
            InitializeComponent();
            pictureBox_parfum1.Visible = false;
            pictureBox_parfum2.Visible = false;
            pictureBox_parfum3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("А детальніше нема", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            button_detal.Visible = true;

            pictureBox_parfum1.Visible = false;
            pictureBox_parfum2.Visible = false;
            pictureBox_parfum3.Visible = false;
        }

        private void magaz_Load(object sender, EventArgs e)
        {

        }

        private void бровиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void маслоТаОліїДляОбличчяToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void magaz_Load_1(object sender, EventArgs e)
        {

        }
        int foto = 1;
        bool istrue = true;
        string path = @"C:\Users\Богдана\OneDrive\Робочий стіл\Зображення\Знімки екрана\";
        private void show_foto()
        {
            pictureBox2.Image = Image.FromFile($"{path}{foto} фото на основну.png");

        }

        private void button_left_Click(object sender, EventArgs e)
        {
            foto--;
            if (foto < 1) foto = 5;

            istrue = (foto == 1);

            show_foto();
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            foto++;
            if (foto > 5) foto = 1;

            istrue = (foto == 1);

            show_foto();
        }

        private void жіночаПарфумеріяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            button_detal.Visible = false;

            pictureBox_parfum1.Visible = true;
            pictureBox_parfum2.Visible = true;
            pictureBox_parfum3.Visible = true;
        }
    }
}
