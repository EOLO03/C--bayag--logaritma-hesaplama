namespace Logaritmik_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j;
            j = int.Parse(textBox1.Text);
            listBox1.Items.Clear();
            if (j <= 0)
                return;
            for (i = 1; i <= j; i++)
                listBox1.Items.Add("Log(" + i.ToString() + ")=" + Math.Log10(i).ToString());
        } 
    }
}