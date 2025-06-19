namespace math_zadach
{
    partial class zd_1cs
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
            label_radius=new Label();
            label_a=new Label();
            label_h=new Label();
            textBox1=new TextBox();
            textBox2=new TextBox();
            textBox3=new TextBox();
            radioButton_area=new RadioButton();
            radioButton_volume=new RadioButton();
            radioButton_perimeter=new RadioButton();
            listBox_output=new ListBox();
            button_count=new Button();
            button2=new Button();
            button_return=new Button();
            listBox_result=new ListBox();
            SuspendLayout();
            // 
            // label_radius
            // 
            label_radius.AutoSize=true;
            label_radius.Font=new Font("Segoe UI", 10.2F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            label_radius.Location=new Point(12, 9);
            label_radius.Name="label_radius";
            label_radius.Size=new Size(63, 23);
            label_radius.TabIndex=0;
            label_radius.Text="Радіус";
            label_radius.Click+=label_radius_Click;
            // 
            // label_a
            // 
            label_a.AutoSize=true;
            label_a.Font=new Font("Segoe UI", 10.2F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            label_a.Location=new Point(12, 62);
            label_a.Name="label_a";
            label_a.Size=new Size(20, 23);
            label_a.TabIndex=1;
            label_a.Text="b";
            // 
            // label_h
            // 
            label_h.AutoSize=true;
            label_h.Font=new Font("Segoe UI", 10.2F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            label_h.Location=new Point(12, 115);
            label_h.Name="label_h";
            label_h.Size=new Size(20, 23);
            label_h.TabIndex=2;
            label_h.Text="h";
            // 
            // textBox1
            // 
            textBox1.BackColor=Color.LightSteelBlue;
            textBox1.Location=new Point(12, 32);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(125, 27);
            textBox1.TabIndex=3;
            // 
            // textBox2
            // 
            textBox2.BackColor=Color.LightSteelBlue;
            textBox2.Location=new Point(12, 85);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(125, 27);
            textBox2.TabIndex=4;
            // 
            // textBox3
            // 
            textBox3.BackColor=Color.LightSteelBlue;
            textBox3.Location=new Point(12, 138);
            textBox3.Name="textBox3";
            textBox3.Size=new Size(125, 27);
            textBox3.TabIndex=5;
            // 
            // radioButton_area
            // 
            radioButton_area.AutoSize=true;
            radioButton_area.BackColor=Color.Transparent;
            radioButton_area.Font=new Font("Segoe UI", 10.2F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            radioButton_area.Location=new Point(166, 32);
            radioButton_area.Name="radioButton_area";
            radioButton_area.Size=new Size(146, 27);
            radioButton_area.TabIndex=6;
            radioButton_area.TabStop=true;
            radioButton_area.Text="Площа круга ";
            radioButton_area.UseVisualStyleBackColor=false;
            radioButton_area.CheckedChanged+=radioButton_area_CheckedChanged;
            // 
            // radioButton_volume
            // 
            radioButton_volume.AutoSize=true;
            radioButton_volume.BackColor=Color.Transparent;
            radioButton_volume.Font=new Font("Segoe UI", 10.2F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            radioButton_volume.Location=new Point(166, 85);
            radioButton_volume.Name="radioButton_volume";
            radioButton_volume.Size=new Size(351, 27);
            radioButton_volume.TabIndex=7;
            radioButton_volume.TabStop=true;
            radioButton_volume.Text="Об'єм прямокутного паралелепіпета";
            radioButton_volume.UseVisualStyleBackColor=false;
            radioButton_volume.CheckedChanged+=radioButton_volume_CheckedChanged;
            // 
            // radioButton_perimeter
            // 
            radioButton_perimeter.AutoSize=true;
            radioButton_perimeter.BackColor=Color.Transparent;
            radioButton_perimeter.Font=new Font("Segoe UI", 10.2F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            radioButton_perimeter.Location=new Point(166, 138);
            radioButton_perimeter.Name="radioButton_perimeter";
            radioButton_perimeter.Size=new Size(250, 27);
            radioButton_perimeter.TabIndex=8;
            radioButton_perimeter.TabStop=true;
            radioButton_perimeter.Text="Периметр прямокутника";
            radioButton_perimeter.UseVisualStyleBackColor=false;
            radioButton_perimeter.CheckedChanged+=radioButton_perimeter_CheckedChanged;
            // 
            // listBox_output
            // 
            listBox_output.BackColor=Color.LightSteelBlue;
            listBox_output.FormattingEnabled=true;
            listBox_output.ItemHeight=20;
            listBox_output.Location=new Point(523, 12);
            listBox_output.Name="listBox_output";
            listBox_output.Size=new Size(193, 304);
            listBox_output.TabIndex=10;
            listBox_output.SelectedIndexChanged+=listBox_output_SelectedIndexChanged;
            // 
            // button_count
            // 
            button_count.BackColor=Color.SkyBlue;
            button_count.Font=new Font("Segoe UI", 10.2F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            button_count.Location=new Point(12, 339);
            button_count.Name="button_count";
            button_count.Size=new Size(139, 29);
            button_count.TabIndex=11;
            button_count.Text="Обчислити";
            button_count.UseVisualStyleBackColor=false;
            button_count.Click+=button_count_Click;
            // 
            // button2
            // 
            button2.BackColor=Color.SkyBlue;
            button2.Font=new Font("Segoe UI", 10.2F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            button2.Location=new Point(310, 339);
            button2.Name="button2";
            button2.Size=new Size(136, 29);
            button2.TabIndex=12;
            button2.Text="Очистити";
            button2.UseVisualStyleBackColor=false;
            button2.Click+=button2_Click;
            // 
            // button_return
            // 
            button_return.BackColor=Color.SkyBlue;
            button_return.Font=new Font("Segoe UI", 10.2F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            button_return.Location=new Point(580, 339);
            button_return.Name="button_return";
            button_return.Size=new Size(158, 29);
            button_return.TabIndex=13;
            button_return.Text="Повернутися";
            button_return.UseVisualStyleBackColor=false;
            button_return.Click+=button_return_Click;
            // 
            // listBox_result
            // 
            listBox_result.BackColor=Color.LightSteelBlue;
            listBox_result.FormattingEnabled=true;
            listBox_result.ItemHeight=20;
            listBox_result.Location=new Point(12, 193);
            listBox_result.Name="listBox_result";
            listBox_result.Size=new Size(485, 124);
            listBox_result.TabIndex=14;
            listBox_result.SelectedIndexChanged+=listBox_result_SelectedIndexChanged;
            // 
            // zd_1cs
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.AliceBlue;
            BackgroundImage=Properties.Resources._7118480c670875ba81a787b34cc99ee5;
            ClientSize=new Size(750, 450);
            Controls.Add(listBox_result);
            Controls.Add(button_return);
            Controls.Add(button2);
            Controls.Add(button_count);
            Controls.Add(listBox_output);
            Controls.Add(radioButton_perimeter);
            Controls.Add(radioButton_volume);
            Controls.Add(radioButton_area);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label_h);
            Controls.Add(label_a);
            Controls.Add(label_radius);
            Name="zd_1cs";
            Text="Завдання 1";
            Load+=zd_1cs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_radius;
        private Label label_a;
        private Label label_h;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private RadioButton radioButton_area;
        private RadioButton radioButton_volume;
        private RadioButton radioButton_perimeter;
        private ListBox listBox_output;
        private Button button_count;
        private Button button2;
        private Button button_return;
        private ListBox listBox_result;
    }
}