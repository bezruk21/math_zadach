namespace math_zadach
{
    partial class exit
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
            button_yes=new Button();
            button_no=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(46, 29);
            label1.Name="label1";
            label1.Size=new Size(256, 28);
            label1.TabIndex=0;
            label1.Text="Ви дійсно хочете вийти?";
            label1.Click+=label1_Click;
            // 
            // button_yes
            // 
            button_yes.Font=new Font("Segoe UI", 10.2F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            button_yes.Location=new Point(12, 88);
            button_yes.Name="button_yes";
            button_yes.Size=new Size(143, 49);
            button_yes.TabIndex=1;
            button_yes.Text="Так";
            button_yes.UseVisualStyleBackColor=true;
            button_yes.Click+=button_yes_Click;
            // 
            // button_no
            // 
            button_no.Font=new Font("Segoe UI", 10.2F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            button_no.Location=new Point(190, 88);
            button_no.Name="button_no";
            button_no.Size=new Size(143, 49);
            button_no.TabIndex=2;
            button_no.Text="Ні";
            button_no.UseVisualStyleBackColor=true;
            button_no.Click+=button_no_Click;
            // 
            // exit
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(357, 184);
            Controls.Add(button_no);
            Controls.Add(button_yes);
            Controls.Add(label1);
            Name="exit";
            Text="exit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_yes;
        private Button button_no;
    }
}