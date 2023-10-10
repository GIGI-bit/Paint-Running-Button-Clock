using System;
using TimeZoneConverter;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_baku_Click(sender, e);
        }
        System.Windows.Forms.Timer timer = new();
        private void btn_baku_Click(object sender, EventArgs e)
        {
            if(timer.Enabled) { timer.Stop(); }
            this.BackgroundImage = Properties.Resources.lloyd_alozie_wX_9ZhIErpg_unsplash;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void btn_london_Click(object sender, EventArgs e)
        {
            if(timer.Enabled) { timer.Stop(); }
            this.BackgroundImage = Properties.Resources.marcin_nowak_iXqTqC_f6jI_unsplash;
            timer.Interval=1000;
            timer.Tick += (s, ev) =>
            {
                TimeZoneInfo info = TZConvert.GetTimeZoneInfo("GMT Standard Time");
                btn_timer.Text=TimeZoneInfo.ConvertTime(DateTime.Now,TimeZoneInfo.Local,info).ToString("HH:mm:ss");
            };
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            btn_timer.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer_Click(object sender, EventArgs e)
        {
            
        }
    }
}