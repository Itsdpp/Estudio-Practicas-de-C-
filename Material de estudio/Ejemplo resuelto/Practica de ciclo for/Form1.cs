namespace Practica_de_numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 50; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                if (i % 2 == 0)
                {
                    item.SubItems.Add("Par");
                }
                else
                {
                    item.SubItems.Add("Impar");
                }
                listView1.Items.Add(item);
            }
        }
    }
}
