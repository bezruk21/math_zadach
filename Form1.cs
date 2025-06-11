namespace math_zadach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            zd_1cs form =new zd_1cs();
            form.ShowDialog();
        }
    }
}