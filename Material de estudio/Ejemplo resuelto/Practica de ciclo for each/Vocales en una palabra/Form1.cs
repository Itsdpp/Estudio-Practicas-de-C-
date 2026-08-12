namespace Vocales_en_una_palabra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string alm = "aeiou·ÈÌÛ˙AEIOU¡…Õ”⁄";
            foreach (char letra in textBox1.Text)
            {
                string i = letra.ToString();
                if (alm.Contains(i))
                {
                    listBox1.Items.Add(letra);
                }
            }
        }
    }
}
