namespace math_zadach
{
    partial class zd_3
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
            добутокToolStripMenuItem=new ToolStripMenuItem();
            мінімумСередНепарнихToolStripMenuItem=new ToolStripMenuItem();
            індексиЕлементівУМежах1050ToolStripMenuItem=new ToolStripMenuItem();
            toolStripMenuItem1=new ToolStripMenuItem();
            toolStripMenuItem2=new ToolStripMenuItem();
            очиститиToolStripMenuItem=new ToolStripMenuItem();
            кінецьToolStripMenuItem=new ToolStripMenuItem();
            записатиВМасивToolStripMenuItem=new ToolStripMenuItem();
            label1=new Label();
            textBox_dani=new TextBox();
            listBox1=new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize=new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { добутокToolStripMenuItem, мінімумСередНепарнихToolStripMenuItem, індексиЕлементівУМежах1050ToolStripMenuItem, toolStripMenuItem1, toolStripMenuItem2, очиститиToolStripMenuItem, кінецьToolStripMenuItem, записатиВМасивToolStripMenuItem });
            menuStrip1.Location=new Point(0, 0);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new Size(1010, 28);
            menuStrip1.TabIndex=0;
            menuStrip1.Text="menuStrip1";
            // 
            // добутокToolStripMenuItem
            // 
            добутокToolStripMenuItem.Name="добутокToolStripMenuItem";
            добутокToolStripMenuItem.Size=new Size(200, 24);
            добутокToolStripMenuItem.Text="Сума додатних елементів";
            добутокToolStripMenuItem.Click+=добутокToolStripMenuItem_Click;
            // 
            // мінімумСередНепарнихToolStripMenuItem
            // 
            мінімумСередНепарнихToolStripMenuItem.Name="мінімумСередНепарнихToolStripMenuItem";
            мінімумСередНепарнихToolStripMenuItem.Size=new Size(198, 24);
            мінімумСередНепарнихToolStripMenuItem.Text="Мінімум серед непарних";
            мінімумСередНепарнихToolStripMenuItem.Click+=мінімумСередНепарнихToolStripMenuItem_Click;
            // 
            // індексиЕлементівУМежах1050ToolStripMenuItem
            // 
            індексиЕлементівУМежах1050ToolStripMenuItem.Name="індексиЕлементівУМежах1050ToolStripMenuItem";
            індексиЕлементівУМежах1050ToolStripMenuItem.Size=new Size(254, 24);
            індексиЕлементівУМежах1050ToolStripMenuItem.Text="Індекси елементів у межах 10...50";
            індексиЕлементівУМежах1050ToolStripMenuItem.Click+=індексиЕлементівУМежах1050ToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name="toolStripMenuItem1";
            toolStripMenuItem1.Size=new Size(14, 24);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name="toolStripMenuItem2";
            toolStripMenuItem2.Size=new Size(14, 24);
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
            // записатиВМасивToolStripMenuItem
            // 
            записатиВМасивToolStripMenuItem.Name="записатиВМасивToolStripMenuItem";
            записатиВМасивToolStripMenuItem.Size=new Size(146, 24);
            записатиВМасивToolStripMenuItem.Text="Записати в масив";
            записатиВМасивToolStripMenuItem.Click+=записатиВМасивToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(57, 137);
            label1.Name="label1";
            label1.Size=new Size(227, 20);
            label1.TabIndex=1;
            label1.Text="Введіть елементи через пробіл";
            // 
            // textBox_dani
            // 
            textBox_dani.Location=new Point(57, 175);
            textBox_dani.Name="textBox_dani";
            textBox_dani.Size=new Size(264, 27);
            textBox_dani.TabIndex=2;
            textBox_dani.TextChanged+=textBox_dani_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled=true;
            listBox1.ItemHeight=20;
            listBox1.Location=new Point(367, 52);
            listBox1.Name="listBox1";
            listBox1.Size=new Size(544, 364);
            listBox1.TabIndex=3;
            listBox1.SelectedIndexChanged+=listBox1_SelectedIndexChanged;
            // 
            // zd_3
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1010, 565);
            Controls.Add(listBox1);
            Controls.Add(textBox_dani);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip=menuStrip1;
            Name="zd_3";
            Text="zd_3";
            FormClosing+=zd_3_FormClosing;
            Load+=zd_3_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem добутокToolStripMenuItem;
        private ToolStripMenuItem мінімумСередНепарнихToolStripMenuItem;
        private ToolStripMenuItem індексиЕлементівУМежах1050ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem очиститиToolStripMenuItem;
        private ToolStripMenuItem кінецьToolStripMenuItem;
        private ToolStripMenuItem записатиВМасивToolStripMenuItem;
        private Label label1;
        private TextBox textBox_dani;
        private ListBox listBox1;
    }
}