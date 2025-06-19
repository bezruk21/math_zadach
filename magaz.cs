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
        int lip_s = 1;
        int lip_g = 1;
        int pensil_l = 1;
        int brush_f = 1;
        int bronzer_f = 1;
        int high_f = 1;
        int conc_f = 1;
        int powder_f = 1;
        int found_f = 1;
        int wash_g = 1;
        int micel_w = 1;
        int hydr_f = 1;
        int feed_f = 1;
        int spf_f = 1;
        int shamp_h = 1;
        int balm_h  = 1;
        int mask_h = 1;
        int oil_h = 1;  
        int shower_b = 1;
        int depil_b = 1;
        int hand_c = 1;
        int derm_c = 1;
        int toolth_b = 1;
        int toolth_p = 1;
        int mounth_w = 1;
        int deod_b = 1;
        int face_m = 1;
        int body_m = 1;
        int beard_c = 1;
        int razor_f = 1;
        int shav_f = 1;
        int after_g = 1;
        int hair_c = 1;
        int chanel_b = 1;
        int dior_b = 1;
        int ysl_b = 1;
        int lamel_b = 1;
        int nyx_b = 1;


        bool womenparfum = false;
        bool menparfum = false;
        bool tini = false;
        bool tysh = false;
        bool podvod = false;
        bool pensil = false;
        bool gel = false;
        bool lip = false;
        bool gloss = false;
        bool pensillip = false;
        bool brush = false;
        bool bronzer = false;
        bool istrue = true;
        bool high = false;
        bool conc = false;
        bool powder = false;
        bool found = false;
        bool wash = false;
        bool micel = false;
        bool hydr = false;
        bool feed = false;
        bool spf= false;
        bool shamp= false;
        bool balm = false;
        bool mask = false;
        bool oil = false;
        bool shower = false;
        bool depil = false;
        bool hand = false;
        bool derm = false;
        bool toolthb = false;
        bool toolthp = false;
        bool mounth = false;
        bool deod = false;
        bool face = false;
        bool body = false;
        bool beard = false;
        bool razor = false;
        bool shav = false;
        bool after = false;
        bool hair =  false;
        bool chanel = false;
        bool dior = false;
        bool ysl = false;
        bool lamel = false;
        bool nyx = false;
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
            lip = false;
            gloss = false;
            pensillip = false;
            brush=false;
            bronzer = false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            lip = false;
            gloss = false;
            pensillip= false;
            brush = false;
            bronzer = false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
                    button_sale1.Visible = true;

                    pictureBox_parfum1.Image = Image.FromFile(path + "прада мужиків.png");
                    label_name2.Text = "Prada Luna Rossa Ocean";
                    label_voda2.Text = "Парфуми";
                    label_price2.Text = "3483 ₴";
                    button_sale2.Visible = true;

                    pictureBox_parfum3.Image = Image.FromFile(path + "chanel.png");
                    label_name3.Text = "Chanel Bleu de Chanel Eau";
                    label_voda3.Text = "Парфумована вода";
                    label_price3.Text = "4564 ₴";
                    button_sale3.Visible = true;
                }
                else if (menparf == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "versace.png");
                    label_name1.Text = "Versace Pour Homme";
                    label_voda1.Text = "Туалетна вода";
                    label_price1.Text = "2800 ₴";
                    button_sale1.Visible = true;

                    pictureBox_parfum1.Image = Image.FromFile(path + "armani men.png");
                    label_name2.Text = "Giorgio Armani Emporio Armani ";
                    label_voda2.Text = "Парфумована вода";
                    label_price2.Text = "3861 ₴";
                    button_sale2.Visible = true;

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior.png");
                    label_name3.Text = "Dior Homme Cologne 2013";
                    label_voda3.Text = "Парфумована вода";
                    label_price3.Text = "4565 ₴";
                    button_sale3.Visible = true;
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
        private void lip_stick()
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
            if (lip)
            {

                if (lip_s == 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "golden.png");
                    label_name1.Text = "Golden Rose Longstay";
                    label_voda1.Text = "Рідка помада для губ";
                    label_price1.Text = "167 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "kiko lip.png");
                    label_name2.Text = "Kiko Milano Unlimited";
                    label_voda2.Text = "Рідка помада для губ";
                    label_price2.Text = "556 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "esens.png");
                    label_name3.Text = "Essence 8H Matte Liquid Lipstick";
                    label_voda3.Text = "Рідка помада для губ";
                    label_price3.Text = "83 ₴";
                }
                else if (lip_s == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "dior lip.png");
                    label_name1.Text = "Dior Addict Refillable Lipstick";
                    label_voda1.Text = "Помада для губ";
                    label_price1.Text = "1713 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "loreal.png");
                    label_name2.Text = "L'Oreal Paris Color Riche";
                    label_voda2.Text = "Помада для губ";
                    label_price2.Text = "440 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "ysl lip.png");
                    label_name3.Text = "Yves Saint Laurent YSL Loveshine";
                    label_voda3.Text = "Помада для губ";
                    label_price3.Text = "2609 ₴";
                }
            }
        }
        private void lip_gloss()
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
            if (gloss)
            {

                if (lip_g == 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "maybil.png");
                    label_name1.Text = "Maybelline New York Lifter Gloss";
                    label_voda1.Text = "Блиск для губ";
                    label_price1.Text = "420 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "nyxx.png");
                    label_name2.Text = "NYX Professional Makeup ";
                    label_voda2.Text = "Блиск-олія для губ";
                    label_price2.Text = "459 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "rose.png");
                    label_name3.Text = "Essence 8H Matte Liquid Lipstick";
                    label_voda3.Text = "Блиск для губ";
                    label_price3.Text = "83 ₴";
                }
                else if (lip_g == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "dair gloss.png");
                    label_name1.Text = "Dior Addict Lip Maximizer";
                    label_voda1.Text = "Блиск для губ";
                    label_price1.Text = "1377 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "lame.png");
                    label_name2.Text = "Lamel Make Up Dazzle Glow";
                    label_voda2.Text = "Блиск для губ";
                    label_price2.Text = "267 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kikoo.png");
                    label_name3.Text = "Yves Saint Laurent YSL Loveshine";
                    label_voda3.Text = "Пом'якшувальний блиск для губ";
                    label_price3.Text = "582 ₴";
                }
            }
        }
        private void lip_pensil()
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
            if (pensillip)
            {

                if (pensil_l== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "meibel.png");
                    label_name1.Text = "Maybelline New York Color Sensational";
                    label_voda1.Text = "Автоматичний олівець для губ";
                    label_price1.Text = "340 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "evel.png");
                    label_name2.Text = "Eveline Cosmetics Make";
                    label_voda2.Text = "Автоматичний олівець для губ";
                    label_price2.Text = "140 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "esen.png");
                    label_name3.Text = "Essence 8H Matte Comfort Lip Liner";
                    label_voda3.Text = "Автоматичний олівець для губ";
                    label_price3.Text = "77 ₴";
                }
                else if (pensil_l == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "pupa.png");
                    label_name1.Text = "Pupa True lips";
                    label_voda1.Text = "Олівець для губ";
                    label_price1.Text = "387 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "lor.png");
                    label_name2.Text = "L'Oreal Paris Color Riche ";
                    label_voda2.Text = "Олівець для губ";
                    label_price2.Text = "310 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior pensil.png");
                    label_name3.Text = "Dior Crayon Contour Levres";
                    label_voda3.Text = "Олівець для губ";
                    label_price3.Text = "1174 ₴";
                }
            }
        }
        private void brush_face()
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
            if (brush)
            {

                if (brush_f== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "dior brush.png");
                    label_name1.Text = "Dior Backstage Rosy Glow Blusher";
                    label_voda1.Text = "Рум'яна для обличчя";
                    label_price1.Text = "1500 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ees.png");
                    label_name2.Text = "Essence Blush Crush!";
                    label_voda2.Text = "Рум'яна для обличчя";
                    label_price2.Text = "116 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kyle.png");
                    label_name3.Text = "Kylie Cosmetics Pressed Blush Powder";
                    label_voda3.Text = "Рум'яна для обличчя";
                    label_price3.Text = "1081 ₴";
                }
                else if (brush_f == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "mimili.png");
                    label_name1.Text = "Maybelline New York Cheek Heat";
                    label_voda1.Text = "Кремові рум'яна для обличчя";
                    label_price1.Text = "330 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "rhode.png");
                    label_name2.Text = "Rhode Pocket Blush";
                    label_voda2.Text = "Кремові рум'яна для обличчя";
                    label_price2.Text = "1262 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "lam.png");
                    label_name3.Text = "LAMEL Make Up BB Blush";
                    label_voda3.Text = "Кремові рум'яна для обличчя";
                    label_price3.Text = "131 ₴";
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
        private void bronzer_face()
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
            if (bronzer)
            {

                if (bronzer_f== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (bronzer_f == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void hiht_face()
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
            if (high)
            {

                if (high_f== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (high_f == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }

        private void conc_face()
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
            if (conc)
            {

                if (conc_f== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (conc_f == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void powder_face()
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
            if (powder)
            {

                if (powder_f== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (powder_f == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void found_face()
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
            if (found)
            {

                if (found_f== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (found_f == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void wash_gele()
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
            if (wash)
            {

                if (wash_g== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (wash_g == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void micel_water()
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
            if (micel)
            {

                if (micel_w == 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (micel_w == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void hydr_face()
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
            if (hydr)
            {

                if (hydr_f== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (hydr_f == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void feed_face()
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
            if (feed)
            {

                if (feed_f== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (feed_f == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void spf_face()
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
            if (spf)
            {

                if (spf_f== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (spf_f == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void shamp_hair ()
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
            if (shamp)
            {

                if (shamp_h== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (shamp_h == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }

        private void balm_hair()
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
            if (balm)
            {

                if (balm_h== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (balm_h == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void mask_hair()
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
            if (mask)
            {

                if (mask_h== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (mask_h == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void oil_hair()
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
            if (oil)
            {

                if (oil_h== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (oil_h == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void shower_body()
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
            if (shower)
            {

                if (shower_b== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (shower_b == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void depil_body()
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
            if (depil)
            {

                if (depil_b== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (depil_b == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void hand_cosmet()
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
            if (hand)
            {

                if (hand_c== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (hand_c == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void derm_cosmet()
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
            if (derm)
            {

                if (derm_c== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (derm_c == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void tooth_brush()
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
            if (toolthb)
            {

                if (toolth_b== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (toolth_b == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void tooth_paste()
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
            if (toolthp)
            {

                if (toolth_p== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (toolth_p == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void mounth_wash()
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
            if (mounth)
            {

                if (mounth_w== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (mounth_w == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void deod_body()
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
            if (deod)
            {

                if (deod_b== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (deod_b == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void face_men()
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
            if (face)
            {

                if (face_m== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (face_m == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void body_men()
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
            if (body)
            {

                if (body_m== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (body_m == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void beard_care()
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
            if (beard)
            {

                if (beard_c== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (beard_c == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void razor_face()
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
            if (razor)
            {

                if (razor_f== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (razor_f == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void shav_foam()
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
            if (shav)
            {

                if (shav_f== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (shav_f == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void after_gel()
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
            if (after)
            {

                if (after_g== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (after_g == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void hair_care()
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
            if (hair)
            {

                if (hair_c== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (hair_c == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void chanel_brand()
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
            if (chanel)
            {

                if (chanel_b== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (chanel_b == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void dior_brand()
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
            if (dior)
            {

                if (dior_b== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (dior_b == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void ysl_brand()
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
            if (ysl)
            {

                if (ysl_b== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (ysl_b == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void lamel_brand()
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
            if (lamel)
            {

                if (lamel_b== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (lamel_b == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }
        private void nyx_brand()
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
            if (nyx)
            {

                if (nyx_b== 1)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "kiko bronzer.png");
                    label_name1.Text = "Kiko Milano Silky Glow Baked";
                    label_voda1.Text = "Компактна пудра-бронзер";
                    label_price1.Text = "927 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "ysl bronzer.png");
                    label_name2.Text = "Yves Saint Laurent All Hours";
                    label_voda2.Text = "Компактна пудра-бронзер";
                    label_price2.Text = "3200 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "kylie.png");
                    label_name3.Text = "Kylie Cosmetics Pressed";
                    label_voda3.Text = "Компактна пудра-бронзер";
                    label_price3.Text = "1081 ₴";
                }
                else if (nyx_b == 2)
                {
                    pictureBox_parfum2.Image = Image.FromFile(path + "evelin.png");
                    label_name1.Text = "Eveline Cosmetics Wonder Match";
                    label_voda1.Text = "Кремовий бронзер для обличчя";
                    label_price1.Text = "208 ₴";

                    pictureBox_parfum1.Image = Image.FromFile(path + "sheglam.png");
                    label_name2.Text = "Sheglam Sun Sculpt Liquid";
                    label_voda2.Text = "Кремовий бронзер для обличчя";
                    label_price2.Text = "442 ₴";

                    pictureBox_parfum3.Image = Image.FromFile(path + "dior bronz.png");
                    label_name3.Text = "Dior Forever Skin Contour Stick";
                    label_voda3.Text = "Стік для бронзування обличчя";
                    label_price3.Text = "2117 ₴";

                }
            }
        }


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
            else if (lip)
            {
                lip_s--;
                if (lip_s < 1) lip_s = 2;
                lip_stick();
            }
            else if (gloss)
            {
                lip_g--;
                if (lip_g < 1) lip_g = 2;
                lip_gloss();
            }
            else if (pensillip)
            {
                pensil_l--;
                if (pensil_l< 1) pensil_l = 2;
                lip_pensil();
            }
            else if (brush)
            {
                brush_f--;
                if (brush_f< 1) brush_f = 2;
                lip_pensil();
            }
            else if (bronzer)
            {
                bronzer_f--;
                if (bronzer_f < 1) bronzer_f = 2;
                bronzer_face();
            }
            else if (high)
            {
                high_f--;
                if (high_f < 1) high_f = 2;
                hiht_face();
            }
            else if (conc)
            {
                conc_f--;
                if (conc_f < 1) conc_f = 2;
                conc_face();
            }
            else if (powder)
            {
                powder_f--;
                if (powder_f < 1) powder_f = 2;
                powder_face();
            }
            else if (found)
            {
                found_f--;
                if (found_f < 1) found_f = 2;
                found_face();
            }
            else if (wash)
            {
                wash_g--;
                if (wash_g < 1) wash_g = 2;
                wash_gele();
            }
            else if (micel)
            {
               micel_w--;
                if (micel_w < 1) micel_w = 2;
                micel_water();
            }
            else if (hydr)
            {
               hydr_f--;
                if (hydr_f < 1) hydr_f = 2;
                hydr_face();
            }
            else if (feed)
            {
                feed_f--;
                if (feed_f < 1) feed_f = 2;
                feed_face();
            }
            else if (spf)
            {
                spf_f--;
                if (spf_f < 1) spf_f = 2;
                spf_face();
            }
            else if (shamp)
            {
                shamp_h--;
                if (shamp_h < 1) shamp_h = 2;
                shamp_hair();
            }

            else if (balm)
            {
                balm_h--;
                if (balm_h < 1) balm_h = 2;
                balm_hair();
            }
            else if (mask)
            {
                mask_h--;
                if (mask_h < 1) mask_h = 2;
                mask_hair();
            }
            else if (oil)
            {
                oil_h--;
                if (oil_h < 1) oil_h = 2;
                oil_hair();
            }
            else if (shower)
            {
                shower_b--;
                if (shower_b < 1) shower_b = 2;
                shower_body();
            }
            else if (depil)
            {
                depil_b--;
                if (depil_b < 1) depil_b = 2;
                depil_body();
            }
            else if (hand)
            {
               hand_c--;
                if (hand_c < 1) hand_c = 2;
                hand_cosmet();
            }
            else if (derm)
            {
                derm_c--;
                if (derm_c < 1) derm_c = 2;
                derm_cosmet();
            }
            else if (toolthb)
            {
                toolth_b--;
                if (toolth_b < 1) toolth_b = 2;
                tooth_brush();
            }
            else if (toolthp)
            {
                toolth_p--;
                if (toolth_p < 1) toolth_p = 2;
                tooth_paste();
            }
            else if (mounth)
            {
                mounth_w--;
                if (mounth_w < 1) mounth_w = 2;
                mounth_wash();
            }
            else if (deod)
            {
                deod_b--;
                if (deod_b < 1) deod_b = 2;
                deod_body();
            }
            else if (face)
            {
                face_m--;
                if (face_m< 1) face_m = 2;
                face_men();
            }
            else if (body)
            {
                body_m--;
                if (body_m< 1) body_m = 2;
                body_men();
            }
            else if (beard)
            {
                beard_c--;
                if (beard_c< 1) beard_c = 2;
                beard_care();
            }
            else if (razor)
            {
                razor_f--;
                if (razor_f< 1) razor_f = 2;
                razor_face();
            }
            else if (shav)
            {
                shav_f--;
                if (shav_f< 1) shav_f = 2;
                shav_foam();
            }
            else if (after)
            {
                after_g--;
                if (after_g< 1) after_g = 2;
                after_gel();
            }
            else if (hair)
            {
                hair_c--;
                if (hair_c< 1) hair_c = 2;
                hair_care();
            }
             if (chanel)
            {
                chanel_b--;
                if (chanel_b< 1) chanel_b = 2;
                chanel_brand();
            }
            else if (dior)
            {
                dior_b--;
                if (dior_b< 1) dior_b = 2;
                dior_brand();
            }
            else if (ysl)
            {
                ysl_b--;
                if (ysl_b< 1) ysl_b = 2;
                ysl_brand();
            }
            else if (lamel)
            {
                lamel_b--;
                if (lamel_b< 1) lamel_b = 2;
                lamel_brand();
            }
            else if (nyx)
            {
                nyx_b--;
                if (nyx_b< 1) nyx_b = 2;
                nyx_brand();
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
            else if (lip)
            {
                lip_s++;
                if (lip_s > 2) lip_s = 1;
                lip_stick();
            }
            else if (gloss)
            {
                lip_g++;
                if (lip_g > 2) lip_g = 1;
                lip_gloss();
            }
            else if (pensillip)
            {
                pensil_l--;
                if (pensil_l < 1) pensil_l = 2;
                lip_pensil();
            }
            else if (brush)
            {
                brush_f++;
                if (brush_f > 2) brush_f = 1;
                brush_face();
            }
            else if (bronzer)
            {
                bronzer_f++;
                if (bronzer_f > 2) bronzer_f = 1;
                bronzer_face();
            }
            else if (high)
            {
                high_f++;
                if (high_f > 2) high_f = 1;
                hiht_face();
            }
            else if (conc)
            {
                conc_f++;
                if (conc_f > 2) conc_f = 1;
                conc_face();
            }
            else if (powder)
            {
                powder_f++;
                if (powder_f > 2) powder_f = 1;
                powder_face();
            }
            else if (found)
            {
                found_f++;
                if (found_f > 2) found_f = 1;
                found_face();
            }
            else if (wash)
            {
                wash_g++;
                if (wash_g > 2) wash_g = 1;
                wash_gele();
            }
            else if (micel)
            {
                micel_w++;
                if (micel_w > 2) micel_w = 1;
                micel_water();
            }
            else if (hydr)
            {
                hydr_f++;
                if (hydr_f > 2) hydr_f = 1;
                hydr_face();
            }
            else if (feed)
            {
                feed_f++;
                if (feed_f > 2) feed_f = 1;
                feed_face();
            }
            else if (spf)
            {
                spf_f++;
                if (spf_f > 2) spf_f = 1;
                spf_face();
            }
            else if (shamp)
            {
                shamp_h++;
                if (shamp_h > 2) shamp_h = 1;
                shamp_hair();
            }

            else if (balm)
            {
                balm_h++;
                if (balm_h > 2) balm_h = 1;
                balm_hair();
            }
            else if (mask)
            {
                mask_h++;
                if (mask_h > 2) mask_h = 1;
                mask_hair();
            }
            else if (oil)
            {
                oil_h++;
                if (oil_h > 2) oil_h = 1;
                oil_hair();
            }
            else if (shower)
            {
                shower_b++;
                if (shower_b > 2) shower_b =1;
                shower_body();
            }
            else if (depil)
            {
                depil_b++;
                if (depil_b > 2) depil_b = 1;
                depil_body();
            }
            else if (hand)
            {
                hand_c++;
                if (hand_c > 2) hand_c = 2;
                hand_cosmet();
            }
            else if (derm)
            {
                derm_c++;
                if (derm_c > 2) derm_c = 1;
                derm_cosmet();
            }
            else if (toolthb)
            {
                toolth_b++;
                if (toolth_b > 2) toolth_b = 1;
                tooth_brush();
            }
            else if (toolthp)
            {
                toolth_p++;
                if (toolth_p > 2) toolth_p = 1;
                tooth_paste();
            }
            else if (mounth)
            {
                mounth_w++;
                if (mounth_w > 2) mounth_w = 1;
                mounth_wash();
            }
            else if (deod)
            {
                deod_b++;
                if (deod_b > 2) deod_b = 1;
                deod_body();
            }
            else if (face)
            {
                face_m++;
                if (face_m > 2) face_m = 1;
                face_men();
            }
            else if (body)
            {
                body_m++;
                if (body_m > 2) body_m = 1;
                body_men();
            }
            else if (beard)
            {
                beard_c++;
                if (beard_c > 2) beard_c = 1;
                beard_care();
            }
            else if (razor)
            {
                razor_f++;
                if (razor_f > 2) razor_f = 1;
                razor_face();
            }
            else if (shav)
            {
                shav_f++;
                if (shav_f > 2) shav_f = 1;
                shav_foam();
            }
            else if (after)
            {
                after_g++;
                if (after_g > 2) after_g = 1;
                after_gel();
            }
            else if (hair)
            {
                hair_c++;
                if (hair_c > 2) hair_c = 1;
                hair_care();
            }
            if (chanel)
            {
                chanel_b++;
                if (chanel_b > 2) chanel_b = 1;
                chanel_brand();
            }
            else if (dior)
            {
                dior_b++;
                if (dior_b > 2) dior_b = 1;
                dior_brand();
            }
            else if (ysl)
            {
                ysl_b++;
                if (ysl_b > 2) ysl_b = 1;
                ysl_brand();
            }
            else if (lamel)
            {
                lamel_b++;
                if (lamel_b > 2) lamel_b = 1;
                lamel_brand();
            }
            else if (nyx)
            {
                nyx_b++;
                if (nyx_b > 2) nyx_b = 1;
                nyx_brand();
            }
            else
            {
                foto++;
                if (foto > 5) foto = 1;
                istrue = (foto == 1);
                show_foto();
            }
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
            MessageBox.Show("Товар збережено в коризу", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_sale2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Товар збережено в коризу", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_sale3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Товар збережено в коризу", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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



        private void чоловічаПарфумеріяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            womenparfum=false;
            tini=false;
            menparfum = true;
            tysh=false;
            podvod=false;
            pensil=false;
            gel = false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            lip = false;
            gloss=false;
            brush=false;
            pensillip= false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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

        private void попмадаДляГубToolStripMenuItem_Click(object sender, EventArgs e)
        {
            womenparfum=false;
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = true;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            lip_stick();
        }

        private void блискДляГубToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=true;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            lip_gloss();
        }

        private void контурнийОлівецьДляБрівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= true;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            lip_pensil();
        }

        private void руянаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=true;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            brush_face();

        }

        private void бронзерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=true;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            bronzer_face();
        }

        private void хайлайтерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = true;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            hiht_face();
        }

        private void консилерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = true;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            conc_face();
        }

        private void пудраДляОблмччяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = true;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            powder_face();
        }

        private void тональнийКремToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = true;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            found_face();
        }

        private void magaz_FormClosing(object sender, FormClosingEventArgs e)
        {
            exit form = new exit();
            if (form.ShowDialog() == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button_sale_Click(object sender, EventArgs e)
        {
            sale form = new sale();
            form.ShowDialog();
        }

        private void геліДляВмиванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = true;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            wash_gele();
        }

        private void міцелярнаВодаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = true;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            micel_water();

        }

        private void зволоженняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = true;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            hydr_face();
        }

        private void живленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = true;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            feed_face();
        }

        private void захистВідСонцяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = true;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            spf_face();
        }

        private void ofvgeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = true;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            shamp_hair();
        }

        private void бальзамДляВолоссяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = true;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            balm_hair();
        }

        private void маскиДляВолоссяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = true;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            mask_hair();
        }

        private void оліяТаМаслоДляВолоссяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = true;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            oil_hair();
        }

        private void дЛяВаниТаДушуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = true;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            shower_body();

        }

        private void депіляціяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = true;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            depil_body();

        }

        private void косметикаДляРукToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = true;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            hand_cosmet();
        }

        private void дерматокосметикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = true;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            derm_cosmet();
        }

        private void зубнаЩіткаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = true;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            tooth_brush();
        }

        private void пастиЗубнийПорошокІГеліToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = true;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            tooth_paste();
        }

        private void ополіскувачДляПорожниниРотаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = true;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            mounth_wash();
        }

        private void дезодирантиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = true;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            deod_body();
        }

        private void обличчяToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = true;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            face_men();
        }

        private void тілоToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = true;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            body_men();
        }

        private void доглядЗаБородоюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = true;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            beard_care();
        }

        private void бритваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = true;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            razor_face();
        }

        private void пінаДляБриттяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = true;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            shav_foam();
        }

        private void гельПісляГолінняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = true;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            after_gel();
        }

        private void доглядЗаВолоссямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = true;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            hair_care();
        }

        private void chsnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = true;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= false;
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
            chanel_brand();
        }

        private void cristianDiorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = true;
            ysl = false;
            lamel = false;
            nyx= false;
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
            dior_brand();
        }

        private void ySLBeautyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = true;
            lamel = false;
            nyx= false;
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
            ysl_brand();
        }

        private void lAMELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = true;
            nyx= false;
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
            lamel_brand();
        }

        private void nYXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menparfum = false;
            tini= false;
            tysh = false;
            podvod=false;
            pensil=false;
            gel=false;
            lip = false;
            gloss=false;
            pensillip= false;
            brush=false;
            bronzer=false;
            high = false;
            conc = false;
            powder = false;
            found = false;
            wash = false;
            micel = false;
            hydr = false;
            feed = false;
            spf = false;
            shamp = false;
            balm = false;
            mask = false;
            oil = false;
            shower = false;
            depil = false;
            hand = false;
            derm = false;
            toolthb = false;
            toolthp = false;
            mounth = false;
            deod = false;
            face = false;
            body = false;
            beard = false;
            razor = false;
            shav = false;
            after = false;
            hair = false;
            chanel = false;
            dior = false;
            ysl = false;
            lamel = false;
            nyx= true;
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
            nyx_brand();
        }
    }
}
