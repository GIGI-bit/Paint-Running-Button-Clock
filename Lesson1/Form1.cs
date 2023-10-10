using System;

namespace Lesson1
{
    public partial class Form1 : Form
    {
        int start_x;
        int start_y;
        int end_x;
        int end_y;
        public Form1()
        {
            InitializeComponent();
        }

        private void mouse_up(object sender, MouseEventArgs e)
        {
            end_x = e.X;
            end_y = e.Y;
            var label = new System.Windows.Forms.Label();
            if (end_x < start_x)
                label.Location = new Point(end_x, end_y);
            else
                label.Location = new Point(start_x, start_y);
            int width = calculateWidth();
            int height = calculateHeight();

            if (height < 10 && width < 10)
            {
                MessageBox.Show("You CANNOT create a rectangle smaller than 10x10.");
                height = 10;
                width = 10;
            }

            label.Width = width;
            label.Height = height;
            label.BackColor = Color.Black;


            label.DoubleClick += (s, Event) =>
            {
                this.Controls.Remove(label);
                label.Dispose();
            };

            var newLabel = new System.Windows.Forms.Label();
            label.MouseDown += (s, Event) =>
            {
                newLabel.AutoSize = true;
                newLabel.Text = $"Sahe: {(label.Width * label.Height).ToString()} Width: {label.Width.ToString()} Height: {label.Height.ToString()}";
                this.Controls.Add(newLabel);
            };
            newLabel.DoubleClick += (send, even) =>
            {
                this.Controls.Remove(newLabel);
                newLabel.Dispose();
            };

            this.Controls.Add(label);
        }

        private void mouse_down(object sender, MouseEventArgs e)
        {
            start_x = e.X;
            start_y = e.Y;
        }

        private int calculateWidth()
        {
            int width = 10;
            if (start_x < end_x)
                width = end_x - start_x;
            else if (start_x > end_x)
                width = start_x - end_x;
            return width;
        }
        private int calculateHeight()
        {
            int height = 10;
            if (start_y < end_y)
                height = end_y - start_y;
            else if (start_y > end_y)
                height = start_y - end_y;
            return height;
        }

    }
}