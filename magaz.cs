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
        int foto = 0;
        int womenparf = 1;
        int menparf = 1;
        int tini_e = 1;
        int tysh_e = 1;
        int podvod_e = 1;
        int pensil_e = 1;
        int gel_eb = 1;
        bool womenparfum = false;
        bool menparfum = false;
        bool tini = false;
        bool tysh = false;
        bool podvod = false;
        bool pensil = false;
        bool gel = false;
        bool istrue = true;
        public magaz()

        {
            InitializeComponent();
            pictureBox_parfum1.Visible = false;
            pictureBox_parfum2.Visible = false;
            pictureBox_parfum3.Visible = false;
            label_name1.Visible = false;
            label_name2.Visible = false;
            label_name3.Visible = false;
            label_voda1.Visible = false;
            label_voda2.Visible = false;
            label_voda3.Visible = false;
            label_price1.Visible = false;
            label_price2.Visible = false;
            label_price3.Visible = false;
            button_sale1.Visible = false;
            button_sale2.Visible = false;
            button_sale3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("А детальніше нема(((((", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            pictureBox2.Visible = true;
            button_detal.Visible = true;

            womenparfum = false;
            menparfum = false;
            tini=false;
            tysh=false;
            podvod = false;
            pensil = false;
            gel = false;
            pictureBox_parfum1.Visible = false;
            pictureBox_parfum2.Visible = false;
            pictureBox_parfum3.Visible = false;
            label_name1.Visible = false;
            label_name2.Visible = false;
            label_name3.Visible = false;
            label_voda1.Visible = false;
            label_voda2.Visible = false;
            label_voda3.Visible = false;
            label_price1.Visible = false;
            label_price2.Visible = false;
            label_price3.Visible = false;
            button_sale1.Visible = false;
            button_sale2.Visible = false;
            button_sale3.Visible = false;
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
            pictureBox_parfum1.Visible = false;
            pictureBox_parfum2.Visible = false;
            pictureBox_parfum3.Visible = false;

            label_name1.Visible = false;
            label_name2.Visible = false;
            label_name3.Visible = false;

            label_voda1.Visible = false;
            label_voda2.Visible = false;
            label_voda3.Visible = false;

            label_price1.Visible = false;
            label_price2.Visible = false;
            label_price3.Visible = false;

            button_sale1.Visible = false;
            button_sale2.Visible = false;
            button_sale3.Visible = false;

            womenparfum = false;
            menparfum = false;
            tini = false;
            tysh = false;
            podvod = false;
            pensil = false;
            gel= false;
        }

        private void magaz_Load_1(object sender, EventArgs e)
        {

        }

        string path = @"C:\Users\Богдана\OneDrive\Робочий стіл\Зображення\Знімки екрана\";
        private void show_foto()
        {
            pictureBox2.Image = Image.FromFile($"{path}{foto} фото на основну.png");

        }
        private void parfum_men()
        {
            pictureBox_parfum1.Visible = true;
            pictureBox_parfum2.Visible = true;
            pictureBox_parfum3.Visible = true;
            label_name1.Visible = true;
            label_name2.Visible = true;
            label_name3.Visible = true;
            label_voda1.Visible = true;
            label_voda2.Visible = true;
            label_voda3.Visible = true;
            label_price1.Visible = true;
            label_price2.Visible = true;
            label_price3.Visible = true;
            button_sale1.Visible = true;
            button_sale2.Visible = true;
            button_sale3.Visible = true;
            if (menparfum)
            {

                if (menparf == 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "ysl man.png");
                    label_name1.Text = "Yves Saint Laurent Y Refillable Spray";
                    label_voda1.Text = "Парфумована вода";
                    label_price1.Text = "5373 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "прада мужиків.png");
                    label_name2.Text = "Prada Luna Rossa Ocean";
                    label_voda2.Text = "Парфуми";
                    label_price2.Text = "3483 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "chanel.png");
                    label_name3.Text = "Chanel Bleu de Chanel Eau";
                    label_voda3.Text = "Парфумована вода";
                    label_price3.Text = "4564 ₴";
                }
                else if (menparf == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "versace.png");
                    label_name1.Text = "Versace Pour Homme";
                    label_voda1.Text = "Туалетна вода";
                    label_price1.Text = "2800 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "armani men.png");
                    label_name2.Text = "Giorgio Armani Emporio Armani ";
                    label_voda2.Text = "Парфумована вода";
                    label_price2.Text = "3861 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior.png");
                    label_name3.Text = "Dior Homme Cologne 2013";
                    label_voda3.Text = "Парфумована вода";
                    label_price3.Text = "4565 ₴";
                }
            }
        }

        private void tini_eyes()
        {
            pictureBox_parfum1.Visible = true;
            pictureBox_parfum2.Visible = true;
            pictureBox_parfum3.Visible = true;
            label_name1.Visible = true;
            label_name2.Visible = true;
            label_name3.Visible = true;
            label_voda1.Visible = true;
            label_voda2.Visible = true;
            label_voda3.Visible = true;
            label_price1.Visible = true;
            label_price2.Visible = true;
            label_price3.Visible = true;
            button_sale1.Visible = true;
            button_sale2.Visible = true;
            button_sale3.Visible = true;
            if (tini)
            {

                if (tini_e == 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "lamel.png");
                    label_name1.Text = "LAMEL Make Up Fusion Palette Eyeshadow";
                    label_voda1.Text = "Палетка тіней для повік";
                    label_price1.Text = "243 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "meibelin.png");
                    label_name2.Text = "Maybelline Nudes of New York Eye Palette";
                    label_voda2.Text = "Палетка тіней для повік";
                    label_price2.Text = "700 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior tini.png");
                    label_name3.Text = "Dior Backstage Eye Palette 2023";
                    label_voda3.Text = "Палетка тіней для повік";
                    label_price3.Text = "3732 ₴";
                }
                else if (tini_e == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "paese.png");
                    label_name1.Text = "Paese";
                    label_voda1.Text = "Палетка тіней для повік";
                    label_price1.Text = "629 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "makup.png");
                    label_name2.Text = "Makeup Revolution Sebile Eyeshadow Palette";
                    label_voda2.Text = "Палетка тіней для повік";
                    label_price2.Text = "590 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "nyx.png");
                    label_name3.Text = "NYX Professional Makeup Ultimate";
                    label_voda3.Text = "Палетка тіней для повік";
                    label_price3.Text = "989 ₴";
                }
            }
        }
        private void tysh_eyes()
        {
            pictureBox_parfum1.Visible = true;
            pictureBox_parfum2.Visible = true;
            pictureBox_parfum3.Visible = true;
            label_name1.Visible = true;
            label_name2.Visible = true;
            label_name3.Visible = true;
            label_voda1.Visible = true;
            label_voda2.Visible = true;
            label_voda3.Visible = true;
            label_price1.Visible = true;
            label_price2.Visible = true;
            label_price3.Visible = true;
            button_sale1.Visible = true;
            button_sale2.Visible = true;
            button_sale3.Visible = true;
            if (tysh)
            {

                if (tysh_e == 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "ysl tysh.png");
                    label_name1.Text = "Yves Saint Laurent Lash Clash";
                    label_voda1.Text = "Туш для вій";
                    label_price1.Text = "2240 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "new york.png");
                    label_name2.Text = "Maybelline New York Lash Sensational";
                    label_voda2.Text = "Туш для вій";
                    label_price2.Text = "423 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "chanek tysh.png");
                    label_name3.Text = "Chanel Inimitable Multi-Dimensional";
                    label_voda3.Text = "Туш для вій";
                    label_price3.Text = "2075 ₴";
                }
                else if (tysh_e == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "panorama.png");
                    label_name1.Text = "L’Oréal Paris Volume Million Lashes Panorama";
                    label_voda1.Text = "Туш для вій";
                    label_price1.Text = "560 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "teleskop.png");
                    label_name2.Text = "L'oreal Paris Telescopic Mascara";
                    label_voda2.Text = "Туш для вій";
                    label_price2.Text = "600 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "eveline.png");
                    label_name3.Text = "Eveline Cosmetics Variete";
                    label_voda3.Text = "Туш для вій";
                    label_price3.Text = "198 ₴";
                }
            }
        }
        private void podvodka_eyes()
        {
            pictureBox_parfum1.Visible = true;
            pictureBox_parfum2.Visible = true;
            pictureBox_parfum3.Visible = true;
            label_name1.Visible = true;
            label_name2.Visible = true;
            label_name3.Visible = true;
            label_voda1.Visible = true;
            label_voda2.Visible = true;
            label_voda3.Visible = true;
            label_price1.Visible = true;
            label_price2.Visible = true;
            label_price3.Visible = true;
            button_sale1.Visible = true;
            button_sale2.Visible = true;
            button_sale3.Visible = true;
            if (podvod)
            {

                if (podvod_e == 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "maybelline.png");
                    label_name1.Text = "Maybelline New York Hyper Easy";
                    label_voda1.Text = "Підводка для очей";
                    label_price1.Text = "353 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "kiko.png");
                    label_name2.Text = "Kiko Milano Super Colour";
                    label_voda2.Text = "Підводка для очей";
                    label_price2.Text = "300 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "golden rose.png");
                    label_name3.Text = "Golden Rose Precision Liner";
                    label_voda3.Text = "Підводка для очей";
                    label_price3.Text = "277 ₴";
                }
                else if (podvod_e == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "nyx pidvodka.png");
                    label_name1.Text = "NYX Professional Makeup";
                    label_voda1.Text = "Підводка для очей";
                    label_price1.Text = "556 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "topface.png");
                    label_name2.Text = "TopFace Instyle Gel Eyeliner";
                    label_voda2.Text = "Підводка для очей";
                    label_price2.Text = "210 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "chanel pidvodka.png");
                    label_name3.Text = "Chanel Le Liner";
                    label_voda3.Text = "Підводка для очей";
                    label_price3.Text = "1703₴";
                }
            }
        }

        private void pensil_eyes()
        {
            pictureBox_parfum1.Visible = true;
            pictureBox_parfum2.Visible = true;
            pictureBox_parfum3.Visible = true;
            label_name1.Visible = true;
            label_name2.Visible = true;
            label_name3.Visible = true;
            label_voda1.Visible = true;
            label_voda2.Visible = true;
            label_voda3.Visible = true;
            label_price1.Visible = true;
            label_price2.Visible = true;
            label_price3.Visible = true;
            button_sale1.Visible = true;
            button_sale2.Visible = true;
            button_sale3.Visible = true;
            if (pensil)
            {

                if (pensil_e == 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "maybel.png");
                    label_name1.Text = "Maybelline New York Brow Ultra";
                    label_voda1.Text = "Автоматичний ультратонкий олівець для брів";
                    label_price1.Text = "320 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "eveline pensil.png");
                    label_name2.Text = "Eveline Cosmetics Micro";
                    label_voda2.Text = "Водостійкий олівець для брів";
                    label_price2.Text = "144 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "nyx pancil.png");
                    label_name3.Text = "NYX Professional Makeup";
                    label_voda3.Text = "Ультратонкий олівець для брів";
                    label_price3.Text = "599 ₴";
                }
                else if (pensil_e == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "lamel pansil.png");
                    label_name1.Text = "LAMEL Make Up Insta";
                    label_voda1.Text = "Олівець для брів зі щіточкою";
                    label_price1.Text = "149 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "chanel pansil.png");
                    label_name2.Text = "Chanel Stylo Sourcils Waterproof";
                    label_voda2.Text = "Водостійкий олівець для брів";
                    label_price2.Text = "2241 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "ln pro.png");
                    label_name3.Text = "LN Pro Micro Brow Pencil";
                    label_voda3.Text = "Олівець для брів";
                    label_price3.Text = "125 ₴";
                }
            }
        }
        private void gel_eyebrow()
        {
            pictureBox_parfum1.Visible = true;
            pictureBox_parfum2.Visible = true;
            pictureBox_parfum3.Visible = true;
            label_name1.Visible = true;
            label_name2.Visible = true;
            label_name3.Visible = true;
            label_voda1.Visible = true;
            label_voda2.Visible = true;
            label_voda3.Visible = true;
            label_price1.Visible = true;
            label_price2.Visible = true;
            label_price3.Visible = true;
            button_sale1.Visible = true;
            button_sale2.Visible = true;
            button_sale3.Visible = true;
            if (gel)
            {

                if (gel_eb == 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "nyx gel.png");
                    label_name1.Text = "NYX Professional Makeup Brow Glue";
                    label_voda1.Text = "Стайлер для брів";
                    label_price1.Text = "420 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "lamell.png");
                    label_name2.Text = "LAMEL Make Up Liquid Brow Soap";
                    label_voda2.Text = "Гель для брів";
                    label_price2.Text = "229 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "may.png");
                    label_name3.Text = "Maybelline New York Superfluff";
                    label_voda3.Text = "Гель-мус для ефекту густих брів";
                    label_price3.Text = "460 ₴";
                }
                else if (gel_eb == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "essens.png");
                    label_name1.Text = "Essence Fix It Like";
                    label_voda1.Text = "гель для брів";
                    label_price1.Text = "256 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "go2be.png");
                    label_name2.Text = "Got2b Glued 4 Brows & Edges";
                    label_voda2.Text = "Гель для брів";
                    label_price2.Text = "276 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "hedonis.png");
                    label_name3.Text = "Hedonic Clear Brow Gel";
                    label_voda3.Text = "Гель для брів";
                    label_price3.Text = "455 ₴";
                }
            }
        }




        private void parfum_women()
        {
            pictureBox_parfum1.Visible = true;
            pictureBox_parfum2.Visible = true;
            pictureBox_parfum3.Visible = true;

            label_name1.Visible = true;
            label_name2.Visible = true;
            label_name3.Visible = true;

            label_voda1.Visible = true;
            label_voda2.Visible = true;
            label_voda3.Visible = true;

            label_price1.Visible = true;
            label_price2.Visible = true;
            label_price3.Visible = true;

            button_sale1.Visible = true;
            button_sale2.Visible = true;
            button_sale3.Visible = true;

            if (womenparfum)
            {
                if (womenparf == 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "туалетна вода діор.png");
                    label_name1.Text = "Dior Miss Dior Blooming Bouquet 2023";
                    label_voda1.Text = "Туалетна вода";
                    label_price1.Text = "2858 грн";

                    pictureBox_parfum1.Image = Image.FromFile(path + "шанель.png");
                    label_name2.Text = "Chanel Gabrielle";
                    label_voda2.Text = "Парфумована вода";
                    label_price2.Text = "3358 грн";

                    pictureBox_parfum3.Image = Image.FromFile(path + "май вей.png");
                    label_name3.Text = "Giorgio Armani My Way";
                    label_voda3.Text = "Парфумована вода";
                    label_price3.Text = "5550 грн";
                }
                else if (womenparf == 2)
                {


                    pictureBox_parfum2.Image = Image.FromFile(path + "прада.png");
                    label_name1.Text = "Prada Paradoxe Virtual Flower";
                    label_voda1.Text = "Парфумована вода";
                    label_price1.Text = "10448 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl.png");
                    label_name2.Text = "Yves Saint Laurent Libre";
                    label_voda2.Text = "Парфумована вода";
                    label_price2.Text = "4887 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "версачі.png");
                    label_name3.Text = "Versace Bright Crystal";
                    label_voda3.Text = "Туалетна вода";
                    label_price3.Text = "1243 ₴";
                }
            }

        }
        bool showParfum = false;


        private void button_left_Click(object sender, EventArgs e)
        {
            if (womenparfum)
            {
                womenparf--;
                if (womenparf < 1) womenparf = 2;
                parfum_women();
            }
            else if (menparfum)
            {
                menparf--;
                if (menparf < 1) menparf = 2;
                parfum_men();
            }
            else if (tini)
            {
                tini_e--;
                if (tini_e < 1) tini_e = 2;
                tini_eyes();
            }
            else if (tysh)
            {
                tysh_e--;
                if (tysh_e < 1) tysh_e = 2;
                tysh_eyes();
            }
            else if (podvod)
            {
                podvod_e--;
                if (podvod_e < 1) podvod_e = 2;
                podvodka_eyes();
            }
            else if (pensil)
            {
                pensil_e--;
                if (pensil_e < 1) pensil_e = 2;
                pensil_eyes();
            }
            else if (gel)
            {
                gel_eb--;
                if (gel_eb < 1) gel_eb = 2;
                gel_eyebrow();
            }
            else
            {
                foto--;
                if (foto < 1) foto = 5;
                istrue = (foto == 1);
                show_foto();
            }
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            if (womenparfum)
            {
                womenparf++;
                if (womenparf > 2) womenparf = 1;
                parfum_women();
            }
            else if (menparfum)
            {
                menparf++;
                if (menparf > 2) menparf = 1;
                parfum_men();
            }
            else if (tini)
            {
                tini_e++;
                if (tini_e > 2) tini_e = 1;
                tini_eyes();
            }
            else if (tysh)
            {
                tysh_e++;
                if (tysh_e > 2) tysh_e = 1;
                tysh_eyes();
            }
            else if (podvod)
            {
                podvod_e++;
                if (podvod_e > 2) podvod_e = 1;
                podvodka_eyes();
            }
            else if (pensil)
            {
                pensil_e++;
                if (pensil_e > 2) pensil_e = 1;
                pensil_eyes();
            }
            else if (gel)
            {
                gel_eb++;
                if (gel_eb > 2) gel_eb = 1;
                gel_eyebrow();
            }
            else
            {
                foto++;
                if (foto > 5) foto = 1;
                istrue = (foto == 1);
                show_foto();
            }
        }

        private void жіночаПарфумеріяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            womenparfum=true;
            menparfum = false;
            tini = false;
            tysh = false;
            podvod = false;
            pensil = false;
            gel = false;
            pictureBox2.Visible = false;
            button_detal.Visible = false;

            pictureBox_parfum1.Visible = true;
            pictureBox_parfum2.Visible = true;
            pictureBox_parfum3.Visible = true;
            label_name1.Visible = true;
            label_name2.Visible = true;
            label_name3.Visible = true;
            label_voda1.Visible = true;
            label_voda2.Visible = true;
            label_voda3.Visible = true;
            label_price1.Visible = true;
            label_price2.Visible = true;
            label_price3.Visible = true;
            button_sale1.Visible = true;
            button_sale2.Visible = true;
            button_sale3.Visible = true;
            parfum_women();
        }

        private void pictureBox_parfum2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_parfum1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_parfum3_Click(object sender, EventArgs e)
        {

        }

        private void label_price2_Click(object sender, EventArgs e)
        {

        }

        private void button_sale1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поки купити неможливо", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_sale2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поки купити неможливо", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_sale3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поки купити неможливо", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void чоловічаПарфумеріяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            womenparfum=false;
            tini=false;
            menparfum = true;
            tysh=false;
            podvod=false;
            pensil=false;
            gel = false;
            pictureBox2.Visible = false;
            button_detal.Visible = false;

            pictureBox_parfum1.Visible = true;
            pictureBox_parfum2.Visible = true;
            pictureBox_parfum3.Visible = true;
            label_name1.Visible = true;
            label_name2.Visible = true;
            label_name3.Visible = true;
            label_voda1.Visible = true;
            label_voda2.Visible = true;
            label_voda3.Visible = true;
            label_price1.Visible = true;
            label_price2.Visible = true;
            label_price3.Visible = true;
            button_sale1.Visible = true;
            button_sale2.Visible = true;
            button_sale3.Visible = true;
            parfum_men();
        }

        private void тушДляВійToolStripMenuItem_Click(object sender, EventArgs e)
        {
            womenparfum=false;
            menparfum = false;
            tini= false;
            tysh = true;
            podvod=false;
            pensil = false;
            gel = false;
            pictureBox2.Visible = false;
            button_detal.Visible = false;

            pictureBox_parfum1.Visible = true;
            pictureBox_parfum2.Visible = true;
            pictureBox_parfum3.Visible = true;
            label_name1.Visible = true;
            label_name2.Visible = true;
            label_name3.Visible = true;
            label_voda1.Visible = true;
            label_voda2.Visible = true;
            label_voda3.Visible = true;
            label_price1.Visible = true;
            label_price2.Visible = true;
            label_price3.Visible = true;
            button_sale1.Visible = true;
            button_sale2.Visible = true;
            button_sale3.Visible = true;
            tysh_eyes();
        }

        private void тініДляПовікToolStripMenuItem_Click(object sender, EventArgs e)
        {
            womenparfum=false;
            menparfum = false;
            tini= true;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            pictureBox2.Visible = false;
            button_detal.Visible = false;

            pictureBox_parfum1.Visible = true;
            pictureBox_parfum2.Visible = true;
            pictureBox_parfum3.Visible = true;
            label_name1.Visible = true;
            label_name2.Visible = true;
            label_name3.Visible = true;
            label_voda1.Visible = true;
            label_voda2.Visible = true;
            label_voda3.Visible = true;
            label_price1.Visible = true;
            label_price2.Visible = true;
            label_price3.Visible = true;
            button_sale1.Visible = true;
            button_sale2.Visible = true;
            button_sale3.Visible = true;
            tini_eyes();
        }

        private void підводкаДляОчейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            womenparfum=false;
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=true;
            pensil=false;
            gel=false; 
            pictureBox2.Visible = false;
            button_detal.Visible = false;

            pictureBox_parfum1.Visible = true;
            pictureBox_parfum2.Visible = true;
            pictureBox_parfum3.Visible = true;
            label_name1.Visible = true;
            label_name2.Visible = true;
            label_name3.Visible = true;
            label_voda1.Visible = true;
            label_voda2.Visible = true;
            label_voda3.Visible = true;
            label_price1.Visible = true;
            label_price2.Visible = true;
            label_price3.Visible = true;
            button_sale1.Visible = true;
            button_sale2.Visible = true;
            button_sale3.Visible = true;
            podvodka_eyes();
        }

        private void олівецьДляБрівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            womenparfum=false;
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=true;
            gel=false;
            pictureBox2.Visible = false;
            button_detal.Visible = false;

            pictureBox_parfum1.Visible = true;
            pictureBox_parfum2.Visible = true;
            pictureBox_parfum3.Visible = true;
            label_name1.Visible = true;
            label_name2.Visible = true;
            label_name3.Visible = true;
            label_voda1.Visible = true;
            label_voda2.Visible = true;
            label_voda3.Visible = true;
            label_price1.Visible = true;
            label_price2.Visible = true;
            label_price3.Visible = true;
            button_sale1.Visible = true;
            button_sale2.Visible = true;
            button_sale3.Visible = true;
            pensil_eyes();
        }

        private void гельДляБрівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            womenparfum=false;
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=true;
            pictureBox2.Visible = false;
            button_detal.Visible = false;

            pictureBox_parfum1.Visible = true;
            pictureBox_parfum2.Visible = true;
            pictureBox_parfum3.Visible = true;
            label_name1.Visible = true;
            label_name2.Visible = true;
            label_name3.Visible = true;
            label_voda1.Visible = true;
            label_voda2.Visible = true;
            label_voda3.Visible = true;
            label_price1.Visible = true;
            label_price2.Visible = true;
            label_price3.Visible = true;
            button_sale1.Visible = true;
            button_sale2.Visible = true;
            button_sale3.Visible = true;
            gel_eyebrow();
        }
    }
}
