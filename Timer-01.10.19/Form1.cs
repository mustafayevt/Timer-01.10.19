using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_01._10._19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Enabled = true;
            timer.Start();
            timer.Tick += Timer_Tick;
            InitializeComponent();
        }
        public bool BakuLocation { get; private set; } = true;
        private void bakuBtn_Click(object sender, EventArgs e)
        {
            if(!BakuLocation)
            {
                BackgroundImage = Image.FromFile("baku.jpg");
                BakuLocation = true;
            }
        }
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            if(!BakuLocation) clock.Text = DateTimeOffset.UtcNow.UtcDateTime.ToString();
            else clock.Text = DateTimeOffset.Now.DateTime.ToString();
        }

        private void LondonBtn_Click(object sender, EventArgs e)
        {
            if (BakuLocation)
            {
                BackgroundImage = Image.FromFile("london.jpg");
                BakuLocation = false;
            }
        }
    }
}
