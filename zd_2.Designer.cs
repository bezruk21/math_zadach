namespace math_zadach
{
    partial class zd_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1=new MenuStrip();
            протаблюватиToolStripMenuItem=new ToolStripMenuItem();
            очиститиToolStripMenuItem=new ToolStripMenuItem();
            кінецьToolStripMenuItem=new ToolStripMenuItem();
            label_x=new Label();
            label2=new Label();
            label_krok=new Label();
            textBox1=new TextBox();
            textBox2=new TextBox();
            textBox3=new TextBox();
            listBox_output=new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor=Color.LightSteelBlue;
            menuStrip1.ImageScalingSize=new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { протаблюватиToolStripMenuItem, очиститиToolStripMenuItem, кінецьToolStripMenuItem });
            menuStrip1.Location=new Point(0, 0);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new Size(479, 28);
            menuStrip1.TabIndex=0;
            menuStrip1.Text="menuStrip1";
            menuStrip1.ItemClicked+=menuStrip1_ItemClicked;
            // 
            // протаблюватиToolStripMenuItem
            // 
            протаблюватиToolStripMenuItem.Name="протаблюватиToolStripMenuItem";
            протаблюватиToolStripMenuItem.Size=new Size(126, 24);
            протаблюватиToolStripMenuItem.Text="Протаблювати";
            протаблюватиToolStripMenuItem.Click+=протаблюватиToolStripMenuItem_Click;
            // 
            // очиститиToolStripMenuItem
            // 
            очиститиToolStripMenuItem.Name="очиститиToolStripMenuItem";
            очиститиToolStripMenuItem.Size=new Size(88, 24);
            очиститиToolStripMenuItem.Text="Очистити";
            очиститиToolStripMenuItem.Click+=очиститиToolStripMenuItem_Click;
            // 
            // кінецьToolStripMenuItem
            // 
            кінецьToolStripMenuItem.Name="кінецьToolStripMenuItem";
            кінецьToolStripMenuItem.Size=new Size(70, 24);
            кінецьToolStripMenuItem.Text="Кінець";
            кінецьToolStripMenuItem.Click+=кінецьToolStripMenuItem_Click;
            // 
            // label_x
            // 
            label_x.AutoSize=true;
            label_x.Font=new Font("Segoe UI", 10.2F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            label_x.Location=new Point(40, 66);
            label_x.Name="label_x";
            label_x.Size=new Size(21, 23);
            label_x.TabIndex=1;
            label_x.Text="X";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI", 10.2F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            label2.Location=new Point(40, 141);
            label2.Name="label2";
            label2.Size=new Size(20, 23);
            label2.TabIndex=2;
            label2.Text="Y";
            label2.Click+=label2_Click;
            // 
            // label_krok
            // 
            label_krok.AutoSize=true;
            label_krok.Font=new Font("Segoe UI", 10.2F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            label_krok.Location=new Point(40, 221);
            label_krok.Name="label_krok";
            label_krok.Size=new Size(50, 23);
            label_krok.TabIndex=3;
            label_krok.Text="Крок";
            // 
            // textBox1
            // 
            textBox1.BackColor=Color.LightSteelBlue;
            textBox1.Location=new Point(40, 89);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(125, 27);
            textBox1.TabIndex=4;
            textBox1.TextChanged+=textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor=Color.LightSteelBlue;
            textBox2.Location=new Point(40, 164);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(125, 27);
            textBox2.TabIndex=5;
            // 
            // textBox3
            // 
            textBox3.BackColor=Color.LightSteelBlue;
            textBox3.Location=new Point(40, 244);
            textBox3.Name="textBox3";
            textBox3.Size=new Size(125, 27);
            textBox3.TabIndex=6;
            // 
            // listBox_output
            // 
            listBox_output.BackColor=Color.SteelBlue;
            listBox_output.FormattingEnabled=true;
            listBox_output.ItemHeight=20;
            listBox_output.Location=new Point(201, 66);
            listBox_output.Name="listBox_output";
            listBox_output.Size=new Size(215, 284);
            listBox_output.TabIndex=7;
            listBox_output.SelectedIndexChanged+=listBox_output_SelectedIndexChanged;
            // 
            // zd_2
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.Azure;
            BackgroundImage=Properties.Resources._7118480c670875ba81a787b34cc99ee51;
            ClientSize=new Size(479, 399);
            Controls.Add(listBox_output);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label_krok);
            Controls.Add(label2);
            Controls.Add(label_x);
            Controls.Add(menuStrip1);
            MainMenuStrip=menuStrip1;
            Name="zd_2";
            Text="Завдання 2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem протаблюватиToolStripMenuItem;
        private ToolStripMenuItem очиститиToolStripMenuItem;
        private ToolStripMenuItem кінецьToolStripMenuItem;
        private Label label_x;
        private Label label2;
        private Label label_krok;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ListBox listBox_output;
    }
}