using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrafficLigths
{
    public partial class TrafficLights : Form
    {
        private Timer timerSwitch;
        private Timer offMode;
        private Timer addSectTimer;

        public TrafficLights()
        {
            InitializeComponent();
            InitializeTrafficLights();
            InitializeTimerSwitch();
            InitializeAddSectTimer();
            InitializeOffMode();
        }

        //Initializing stuff
        private void InitializeTrafficLights()
        {
            redLigth.BackColor = Color.Gray;
            yellowLigth.BackColor = Color.Gray;
            greenLigth.BackColor = Color.Gray;
            addSectRigth.BackColor = Color.Gray;
        }
        private void InitializeTimerSwitch()
        {
            timerSwitch = new Timer();

            timerSwitch.Tick += new EventHandler(TimerSwitch_Tick);

        }
        private void InitializeAddSectTimer()
        {
            addSectTimer = new Timer();

            addSectTimer.Tick += new EventHandler(addSectTimer_Tick);
            addSectTimer.Interval = 4000;
            addSectTimer.Stop();
        }
        private void InitializeOffMode()
        {
            offMode = new Timer();

            offMode.Tick += new EventHandler(offMode_Tick);
            offMode.Interval = 500;
            offMode.Start();
        }

        //Timers
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
        
        
        private void addSectTimer_Tick(object sender, EventArgs e)
        {
            if (redLigth.BackColor == Color.Red) 
            {
                addSectRigth.BackColor = Color.Green;
            }
            else if (greenLigth.BackColor == Color.Green) 
            {
                addSectRigth.BackColor = Color.Gray;
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

        //ON and OFF
        private void button1_Click(object sender, EventArgs e)
        {
            if (yellowLigth.BackColor == Color.Yellow)
            {
                yellowLigth.BackColor = Color.Gray;
                redLigth.BackColor = Color.Red;
            }
            offMode.Stop();
            addSectTimer.Start();
            timerSwitch.Start();
            redLigth.BackColor = Color.Red;
            yellowLigth.BackColor = Color.Gray;
            greenLigth.BackColor = Color.Gray;
            addSectRigth.BackColor = Color.Gray;
            
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            offMode.Start();
            timerSwitch.Stop();
            addSectTimer.Stop();
            redLigth.BackColor = Color.Gray;
            yellowLigth.BackColor = Color.Gray;
            greenLigth.BackColor = Color.Gray;
            addSectRigth.BackColor = Color.Gray;
        }
    }
}
