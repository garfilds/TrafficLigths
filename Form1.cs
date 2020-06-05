using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrafficLigths
{
    public partial class TrafficLights : Form
    {
        private Timer timerSwitch;
        private Timer offMode;

        public TrafficLights()
        {
            InitializeComponent();
            InitializeTrafficLights();
            InitializeTimerSwitch();
            InitializeOffMode();
        }
        private void InitializeTrafficLights()
        {
            redLigth.BackColor = Color.Gray;
            yellowLigth.BackColor = Color.Gray;
            greenLigth.BackColor = Color.Gray;
        }
        private void InitializeTimerSwitch()
        {
            timerSwitch = new Timer();

            timerSwitch.Tick += new EventHandler(TimerSwitch_Tick);

        }
        
        private void InitializeOffMode()
        {
            offMode = new Timer();

            offMode.Tick += new EventHandler(offMode_Tick);
            offMode.Start();
            offMode.Interval = 500;
        }
        private void offMode_Tick(object sender, EventArgs e)
        {
            if (yellowLigth.BackColor == Color.Gray)
            {
                yellowLigth.BackColor = Color.Yellow;
            }
            else
            {
                yellowLigth.BackColor = Color.Gray;
            }
        }


        private void TimerSwitch_Tick(object sender, EventArgs e)
        {

            /*if (redLigth.BackColor == Color.Gray)
            {
                redLigth.BackColor = Color.Red;
            }
            else 
            {
                redLigth.BackColor = Color.Gray;
            }*/


            if (greenLigth.BackColor == Color.Green)
            {
                timerSwitch.Interval = 2000;
                redLigth.BackColor = Color.Gray;
                yellowLigth.BackColor = Color.Yellow;
                greenLigth.BackColor = Color.Gray;
            }
            else if (yellowLigth.BackColor == Color.Yellow)
            {

                if (redLigth.BackColor == Color.Red)
                {
                    timerSwitch.Interval = 7000;
                    redLigth.BackColor = Color.Gray;
                    yellowLigth.BackColor = Color.Gray;
                    greenLigth.BackColor = Color.Green;
                }
                else
                {
                    timerSwitch.Interval = 7000;
                    redLigth.BackColor = Color.Red;
                    yellowLigth.BackColor = Color.Gray;
                    greenLigth.BackColor = Color.Gray;
                }
            }
            else if (redLigth.BackColor == Color.Red)
            {
                timerSwitch.Interval = 2000;
                redLigth.BackColor = Color.Red;
                yellowLigth.BackColor = Color.Yellow;
                greenLigth.BackColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            offMode.Stop();
            timerSwitch.Start();
            redLigth.BackColor = Color.Red;
            yellowLigth.BackColor = Color.Gray;
            greenLigth.BackColor = Color.Gray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            offMode.Start();
            timerSwitch.Stop();
            redLigth.BackColor = Color.Gray;
            yellowLigth.BackColor = Color.Gray;
            greenLigth.BackColor = Color.Gray;
        }
    }
}
