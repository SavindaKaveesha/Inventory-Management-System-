namespace Inventry_managment
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

        private void pwTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                pwTxt.UseSystemPasswordChar = false;
            }
            else {
                pwTxt.UseSystemPasswordChar=true;
            }
        }
    }
}