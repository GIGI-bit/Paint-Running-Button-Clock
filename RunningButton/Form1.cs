namespace RunningButton
{
    public partial class Form1 : Form
    {
        bool position = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mouse_hover(object sender, EventArgs e)
        {
            if (position == false)
            {
                button1.Location = new Point(button1.Location.X + button1.Width + 10, button1.Location.Y);
                position = true;
            }
            else if (position)
            {
                button1.Location = new Point(button1.Location.X - button1.Width - 10, button1.Location.Y);
                position = false;
            }

        }
    }
}