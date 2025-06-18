namespace math_zadach
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1=new Button();
            button2=new Button();
            button3=new Button();
            button4=new Button();
            button5=new Button();
            label1=new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor=Color.Pink;
            button1.Font=new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location=new Point(40, 27);
            button1.Name="button1";
            button1.Size=new Size(169, 74);
            button1.TabIndex=0;
            button1.Text="Завдання 1";
            button1.UseVisualStyleBackColor=false;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.BackColor=Color.Pink;
            button2.Font=new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location=new Point(40, 116);
            button2.Name="button2";
            button2.Size=new Size(169, 74);
            button2.TabIndex=1;
            button2.Text="Завдання 2";
            button2.UseVisualStyleBackColor=false;
            button2.Click+=button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor=Color.Pink;
            button3.Font=new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location=new Point(40, 206);
            button3.Name="button3";
            button3.Size=new Size(169, 74);
            button3.TabIndex=2;
            button3.Text="Завдання 3";
            button3.UseVisualStyleBackColor=false;
            button3.Click+=button3_Click;
            // 
            // button4
            // 
            button4.BackColor=Color.Pink;
            button4.Font=new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location=new Point(40, 300);
            button4.Name="button4";
            button4.Size=new Size(169, 74);
            button4.TabIndex=3;
            button4.Text="Завдання 4";
            button4.UseVisualStyleBackColor=false;
            button4.Click+=button4_Click;
            // 
            // button5
            // 
            button5.BackColor=Color.MistyRose;
            button5.Font=new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location=new Point(248, 94);
            button5.Name="button5";
            button5.Size=new Size(250, 218);
            button5.TabIndex=4;
            button5.Text="Flaire інтернет-магазин косметики";
            button5.UseVisualStyleBackColor=false;
            button5.Click+=button5_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(458, 374);
            label1.Name="label1";
            label1.Size=new Size(72, 20);
            label1.TabIndex=5;
            label1.Text="Безрук Б.";
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.SeaShell;
            ClientSize=new Size(537, 403);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor=SystemColors.ControlText;
            Name="Form1";
            Text="Form1";
            FormClosing+=Form1_FormClosing;
            Load+=Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
    }
}