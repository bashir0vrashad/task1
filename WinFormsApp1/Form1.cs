using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowTime(string timeZoneId)
        {
            TimeZoneInfo zona = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
            DateTime time = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, zona);
            label1.Text = time.ToString("HH:mm:ss");

        }



        private void button1_Click(object sender, EventArgs e)
        {
            ShowTime("Azerbaijan Standard Time");
            button1.Text = "";
            button1.BackgroundImage = Resources._360_F_231148604_0hQFi09fYKlV0J7jnBVCIFR8sTCOI3J9;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "";
            button2.BackgroundImage = Resources._360_F_257755130_JgTlcqTFxabsIKgIYLAhOFEFYmNgwyJ6;
            ShowTime("GMT Standard Time");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}