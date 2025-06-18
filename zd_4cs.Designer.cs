namespace math_zadach
{
    partial class zd_4cs
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
            label1=new Label();
            label2=new Label();
            numericUpDown_line=new NumericUpDown();
            numericUpDown_column=new NumericUpDown();
            listBox_rezult=new ListBox();
            menuStrip1=new MenuStrip();
            середнєНаПобічнійДіагоналіToolStripMenuItem=new ToolStripMenuItem();
            сумаНижчеПобічноїДфагоналіToolStripMenuItem=new ToolStripMenuItem();
            очиститиToolStripMenuItem=new ToolStripMenuItem();
            кінецьToolStripMenuItem=new ToolStripMenuItem();
            додатиРядкиІСтовбціToolStripMenuItem=new ToolStripMenuItem();
            dataGridView1=new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_line).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_column).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 10.2F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            label1.Location=new Point(17, 61);
            label1.Name="label1";
            label1.Size=new Size(231, 23);
            label1.TabIndex=0;
            label1.Text="Виберіть кількість рядків";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI", 10.2F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            label2.Location=new Point(17, 153);
            label2.Name="label2";
            label2.Size=new Size(255, 23);
            label2.TabIndex=1;
            label2.Text="Виберіть кількість стовбців";
            // 
            // numericUpDown_line
            // 
            numericUpDown_line.Location=new Point(17, 87);
            numericUpDown_line.Name="numericUpDown_line";
            numericUpDown_line.Size=new Size(150, 27);
            numericUpDown_line.TabIndex=2;
            numericUpDown_line.ValueChanged+=numericUpDown_line_ValueChanged;
            // 
            // numericUpDown_column
            // 
            numericUpDown_column.Location=new Point(17, 179);
            numericUpDown_column.Name="numericUpDown_column";
            numericUpDown_column.Size=new Size(150, 27);
            numericUpDown_column.TabIndex=3;
            numericUpDown_column.ValueChanged+=numericUpDown_column_ValueChanged;
            // 
            // listBox_rezult
            // 
            listBox_rezult.BackColor=Color.SteelBlue;
            listBox_rezult.Font=new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            listBox_rezult.FormattingEnabled=true;
            listBox_rezult.ItemHeight=23;
            listBox_rezult.Location=new Point(299, 61);
            listBox_rezult.Name="listBox_rezult";
            listBox_rezult.Size=new Size(526, 142);
            listBox_rezult.TabIndex=4;
            listBox_rezult.SelectedIndexChanged+=listBox_rezult_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor=Color.LightSteelBlue;
            menuStrip1.ImageScalingSize=new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { середнєНаПобічнійДіагоналіToolStripMenuItem, сумаНижчеПобічноїДфагоналіToolStripMenuItem, очиститиToolStripMenuItem, кінецьToolStripMenuItem, додатиРядкиІСтовбціToolStripMenuItem });
            menuStrip1.Location=new Point(0, 0);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new Size(850, 28);
            menuStrip1.TabIndex=5;
            menuStrip1.Text="menuStrip1";
            // 
            // середнєНаПобічнійДіагоналіToolStripMenuItem
            // 
            середнєНаПобічнійДіагоналіToolStripMenuItem.Name="середнєНаПобічнійДіагоналіToolStripMenuItem";
            середнєНаПобічнійДіагоналіToolStripMenuItem.Size=new Size(235, 24);
            середнєНаПобічнійДіагоналіToolStripMenuItem.Text="Середнє на побічній діагоналі";
            середнєНаПобічнійДіагоналіToolStripMenuItem.Click+=середнєНаПобічнійДіагоналіToolStripMenuItem_Click;
            // 
            // сумаНижчеПобічноїДфагоналіToolStripMenuItem
            // 
            сумаНижчеПобічноїДфагоналіToolStripMenuItem.Name="сумаНижчеПобічноїДфагоналіToolStripMenuItem";
            сумаНижчеПобічноїДфагоналіToolStripMenuItem.Size=new Size(240, 24);
            сумаНижчеПобічноїДфагоналіToolStripMenuItem.Text="Сума нижче побічної діагоналі";
            сумаНижчеПобічноїДфагоналіToolStripMenuItem.Click+=сумаНижчеПобічноїДфагоналіToolStripMenuItem_Click;
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
            // додатиРядкиІСтовбціToolStripMenuItem
            // 
            додатиРядкиІСтовбціToolStripMenuItem.Name="додатиРядкиІСтовбціToolStripMenuItem";
            додатиРядкиІСтовбціToolStripMenuItem.Size=new Size(182, 24);
            додатиРядкиІСтовбціToolStripMenuItem.Text="Додати рядки і стовбці";
            додатиРядкиІСтовбціToolStripMenuItem.Click+=додатиРядкиІСтовбціToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor=Color.LightSteelBlue;
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location=new Point(12, 247);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowHeadersWidth=51;
            dataGridView1.RowTemplate.Height=29;
            dataGridView1.Size=new Size(826, 323);
            dataGridView1.TabIndex=6;
            dataGridView1.CellContentClick+=dataGridView1_CellContentClick;
            // 
            // zd_4cs
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.Azure;
            ClientSize=new Size(850, 597);
            Controls.Add(dataGridView1);
            Controls.Add(listBox_rezult);
            Controls.Add(numericUpDown_column);
            Controls.Add(numericUpDown_line);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip=menuStrip1;
            Name="zd_4cs";
            Text="zd_4cs";
            FormClosing+=zd_4cs_FormClosing;
            Load+=zd_4cs_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_line).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_column).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown_line;
        private NumericUpDown numericUpDown_column;
        private ListBox listBox_rezult;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem середнєНаПобічнійДіагоналіToolStripMenuItem;
        private ToolStripMenuItem сумаНижчеПобічноїДфагоналіToolStripMenuItem;
        private ToolStripMenuItem очиститиToolStripMenuItem;
        private ToolStripMenuItem кінецьToolStripMenuItem;
        private ToolStripMenuItem додатиРядкиІСтовбціToolStripMenuItem;
        private DataGridView dataGridView1;
    }
}