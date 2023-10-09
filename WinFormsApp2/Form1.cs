namespace WinFormsApp2
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
      

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            int x = Random.Shared.Next(0, this.Size.Width-label1.Width);
            int y = Random.Shared.Next(0, this.Size.Height-label1.Height);

            label1.Location = new Point(x, y);
        }
    }
}