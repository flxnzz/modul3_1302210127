using System.Xml.XPath;

namespace modul2_1302210127
{
    public partial class Form1 : Form
    {
        String temp;
        int result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
            temp += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
            temp += "4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
            temp += "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
            temp += "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
            temp += "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
            temp += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
            temp += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
            temp += "9";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
            temp += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text += "+";
            result = int.Parse(temp);
            temp = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int hasil = result + int.Parse(temp);
            label1.Text = hasil.ToString();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
            temp += "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}