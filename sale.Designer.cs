namespace math_zadach
{
    partial class sale
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
            components=new System.ComponentModel.Container();
            label1=new Label();
            listBox1=new ListBox();
            contextMenuStrip1=new ContextMenuStrip(components);
            видалитиToolStripMenuItem=new ToolStripMenuItem();
            button1=new Button();
            textBox1=new TextBox();
            label2=new Label();
            button_zamovl=new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.BackColor=Color.Transparent;
            label1.Font=new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(207, 25);
            label1.Name="label1";
            label1.Size=new Size(172, 60);
            label1.TabIndex=0;
            label1.Text="Кошик";
            // 
            // listBox1
            // 
            listBox1.BackColor=Color.LavenderBlush;
            listBox1.ContextMenuStrip=contextMenuStrip1;
            listBox1.FormattingEnabled=true;
            listBox1.ItemHeight=20;
            listBox1.Location=new Point(12, 88);
            listBox1.Name="listBox1";
            listBox1.Size=new Size(551, 204);
            listBox1.TabIndex=1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize=new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { видалитиToolStripMenuItem });
            contextMenuStrip1.Name="contextMenuStrip1";
            contextMenuStrip1.Size=new Size(145, 28);
            // 
            // видалитиToolStripMenuItem
            // 
            видалитиToolStripMenuItem.Name="видалитиToolStripMenuItem";
            видалитиToolStripMenuItem.Size=new Size(144, 24);
            видалитиToolStripMenuItem.Text="Видалити";
            видалитиToolStripMenuItem.Click+=видалитиToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.BackColor=Color.Pink;
            button1.Location=new Point(12, 417);
            button1.Name="button1";
            button1.Size=new Size(127, 27);
            button1.TabIndex=2;
            button1.Text="Очистити";
            button1.UseVisualStyleBackColor=false;
            button1.Click+=button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location=new Point(371, 329);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(156, 27);
            textBox1.TabIndex=3;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.BackColor=Color.Transparent;
            label2.Font=new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location=new Point(386, 303);
            label2.Name="label2";
            label2.Size=new Size(125, 23);
            label2.TabIndex=4;
            label2.Text="Всього сума ₴";
            // 
            // button_zamovl
            // 
            button_zamovl.BackColor=SystemColors.ActiveCaptionText;
            button_zamovl.Font=new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_zamovl.ForeColor=SystemColors.Control;
            button_zamovl.Location=new Point(336, 362);
            button_zamovl.Name="button_zamovl";
            button_zamovl.Size=new Size(227, 56);
            button_zamovl.TabIndex=5;
            button_zamovl.Text="Оформити замовлення";
            button_zamovl.UseVisualStyleBackColor=false;
            button_zamovl.Click+=button_zamovl_Click;
            // 
            // sale
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            AutoScroll=true;
            BackgroundImage=Properties.Resources._99fa0d0317cea3f28b32fbf55c864c8f1;
            ClientSize=new Size(575, 456);
            Controls.Add(button_zamovl);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name="sale";
            Text="Кошик";
            Load+=sale_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem видалитиToolStripMenuItem;
        private TextBox textBox1;
        private Label label2;
        private Button button_zamovl;
    }
}