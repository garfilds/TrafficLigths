using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrafficLigths
{
    public partial class TrafficLights : Form
    {
        public Timer timerSwitch = null;
        public Timer timerBlink = null;
        public Timer pedestrianTimerBlink = null;
        public Timer offMode;
        public Timer timerPop = null;
        public int timeCounter = 0;

        public PictureBox lightToBlink = null;
        public Color colorToCheck = Color.Gray;

        public PictureBox pedestrianLightToBlink = null;
        public Color pedestrianColorToCheck = Color.Gray;


        public TrafficLights()
        {
            InitializeComponent();
            InitializeTrafficLights();
            InitializeOffMode();
            InitializeTimerPop();
            InitializeTimerSwitch();
            InitializeTimerBlink();
            InitializePedestrianTimerBlink();
        }


        public void InitializeTrafficLights()
        {
            RedLight.BackColor = Color.Gray;
            YellowLight.BackColor = Color.Gray;
            GreenLight.BackColor = Color.Gray;
            AddSectRigth.BackColor = Color.Gray;
            pedestrianGreen.BackColor = Color.Gray;
            pedestrianRed.BackColor = Color.Gray;
            tramLigth1.BackColor = Color.Gray;
            tramLigth2.BackColor = Color.Gray;
            tramLigth3.BackColor = Color.Gray;
            tramLigth4.BackColor = Color.Gray;

            Form2 form2 = new Form2();
            form2.Show();

        }
        public void InitializeTimerPop() 
        {
            timerPop = new Timer();
            timerPop.Interval = 1000;
            timerPop.Tick += new EventHandler(timerPop_Tick);
            
        }
        public void InitializeTimerSwitch()
        {
            timerSwitch = new Timer();
            timerSwitch.Interval = 1000;
            timerSwitch.Tick += new EventHandler(TimerSwitch_Tick);
        }
        public void InitializeTimerBlink()
        {
            timerBlink = new Timer();
            timerBlink.Interval = 200;
            timerBlink.Tick += new EventHandler(TimerBlink_Tick);
        }
        public void InitializePedestrianTimerBlink()
        {
            pedestrianTimerBlink = new Timer();
            pedestrianTimerBlink.Interval = 200;
            pedestrianTimerBlink.Tick += new EventHandler(pedestrianTimerBlink_Tick);
        }
        public void TimerBlink_Tick(object sender, EventArgs e)
        {
            if (lightToBlink.BackColor == Color.Gray)
            {
                lightToBlink.BackColor = colorToCheck;
            }
            else
            {
                lightToBlink.BackColor = Color.Gray;
            }
        }
        public void pedestrianTimerBlink_Tick(object sender, EventArgs e)
        {
            if (pedestrianLightToBlink.BackColor == Color.Gray)
            {
                pedestrianLightToBlink.BackColor = colorToCheck;
            }
            else
            {
                pedestrianLightToBlink.BackColor = Color.Gray;
            }
        }
        public void StartBlinking(PictureBox light, Color color)
        {
            lightToBlink = light;
            colorToCheck = color;
            timerBlink.Start();
        }
        public void pedestrianStartBlinking(PictureBox light, Color color)
        {
            pedestrianLightToBlink = light;
            pedestrianColorToCheck = color;
            pedestrianTimerBlink.Start();
        }
        public void StopBlinking()
        {
            timerBlink.Stop();

        }
        public void PedestrianStopBlinking()
        {
            pedestrianTimerBlink.Stop();
        }

        public void timerPop_Tick(object sender, EventArgs e) 
        {
            PlaySound("Trafic_lights_sound_SINGLE");
        }

        public void TimerSwitch_Tick(object sender, EventArgs e)
        {
            SwitchLights();
        }


        public void SwitchLights()
        {
            switch (timeCounter)
            {
                case 0:
                    timerPop.Interval = 1000;
                    RedLight.BackColor = Color.Red;
                    tramLigth1.BackColor = Color.Yellow;
                    tramLigth2.BackColor = Color.Yellow;
                    tramLigth3.BackColor = Color.Yellow;
                    tramLigth4.BackColor = Color.Gray;
                    pedestrianRed.BackColor = Color.Red;
                    pedestrianGreen.BackColor = Color.Gray;
                    break;
                case 2:
                    AddSectRigth.BackColor = Color.Green;
                    tramLigth1.BackColor = Color.Gray;
                    tramLigth2.BackColor = Color.Gray;
                    tramLigth3.BackColor = Color.Yellow;
                    tramLigth4.BackColor = Color.Yellow;
                    break;
                case 3:
                    YellowLight.BackColor = Color.Yellow;
                    //RedLight.BackColor = Color.Gray;
                    break;
                case 5:
                    timerPop.Interval = 100;
                    RedLight.BackColor = Color.Gray;
                    YellowLight.BackColor = Color.Gray;
                    GreenLight.BackColor = Color.Green;
                    pedestrianRed.BackColor = Color.Gray;
                    pedestrianGreen.BackColor = Color.Green;
                    break;
                case 6:
                    AddSectRigth.BackColor = Color.Gray;
                    tramLigth1.BackColor = Color.Gray;
                    tramLigth2.BackColor = Color.Yellow;
                    tramLigth3.BackColor = Color.Yellow;
                    tramLigth4.BackColor = Color.Yellow;
                    break;
                case 7:
                    StartBlinking(GreenLight, Color.Green);
                    break;
                case 9:
                    StopBlinking();
                    pedestrianStartBlinking(pedestrianGreen, Color.Green);
                    YellowLight.BackColor = Color.Yellow;
                    GreenLight.BackColor = Color.Gray;
                    break;
                case 11:
                    timerPop.Interval = 1000;
                    PedestrianStopBlinking();
                    YellowLight.BackColor = Color.Gray;
                    RedLight.BackColor = Color.Red;
                    tramLigth1.BackColor = Color.Yellow;
                    tramLigth2.BackColor = Color.Yellow;
                    tramLigth3.BackColor = Color.Yellow;
                    tramLigth4.BackColor = Color.Gray;
                    pedestrianRed.BackColor = Color.Red;
                    pedestrianGreen.BackColor = Color.Gray;
                    timeCounter = -1;
                    break;
            }
            timeCounter++;
        }



        //OFF MODE BROKEN!

        public void InitializeOffMode()
        {
            offMode = new Timer();

            offMode.Tick += new EventHandler(offMode_Tick);
            offMode.Interval = 500;
            offMode.Start();
        }
        public void offMode_Tick(object sender, EventArgs e)
        {
            if (YellowLight.BackColor == Color.Gray)
            {
                YellowLight.BackColor = Color.Yellow;
            }
            else
            {
                YellowLight.BackColor = Color.Gray;
            }
        }
        public void PlaySound(string soundName)
        {
            System.IO.Stream str = (System.IO.Stream)Properties.Resources.ResourceManager.GetObject(soundName);
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        public void Turn_On()
        {
            offMode.Stop();
            timerPop.Start();
            timerSwitch.Start();
            RedLight.BackColor = Color.Gray;
            YellowLight.BackColor = Color.Gray;
            GreenLight.BackColor = Color.Gray;
            AddSectRigth.BackColor = Color.Gray;
            pedestrianGreen.BackColor = Color.Gray;
            pedestrianRed.BackColor = Color.Gray;
            tramLigth1.BackColor = Color.Gray;
            tramLigth2.BackColor = Color.Gray;
            tramLigth3.BackColor = Color.Gray;
            tramLigth4.BackColor = Color.Gray;
        }

        public void Turn_Off()
        {
            offMode.Start();
            timerPop.Stop();
            timerSwitch.Stop();
            RedLight.BackColor = Color.Gray;
            YellowLight.BackColor = Color.Gray;
            GreenLight.BackColor = Color.Gray;
            AddSectRigth.BackColor = Color.Gray;
            pedestrianGreen.BackColor = Color.Gray;
            pedestrianRed.BackColor = Color.Gray;
            tramLigth1.BackColor = Color.Gray;
            tramLigth2.BackColor = Color.Gray;
            tramLigth3.BackColor = Color.Gray;
            tramLigth4.BackColor = Color.Gray;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            offMode.Stop();
            timerPop.Start();
            timerSwitch.Start();
            RedLight.BackColor = Color.Gray;
            YellowLight.BackColor = Color.Gray;
            GreenLight.BackColor = Color.Gray;
            AddSectRigth.BackColor = Color.Gray;
            pedestrianGreen.BackColor = Color.Gray;
            pedestrianRed.BackColor = Color.Gray;
            tramLigth1.BackColor = Color.Gray;
            tramLigth2.BackColor = Color.Gray;
            tramLigth3.BackColor = Color.Gray;
            tramLigth4.BackColor = Color.Gray;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            offMode.Start();
            timerPop.Stop();
            timerSwitch.Stop();
            RedLight.BackColor = Color.Gray;
            YellowLight.BackColor = Color.Gray;
            GreenLight.BackColor = Color.Gray;
            AddSectRigth.BackColor = Color.Gray;
            pedestrianGreen.BackColor = Color.Gray;
            pedestrianRed.BackColor = Color.Gray;
            tramLigth1.BackColor = Color.Gray;
            tramLigth2.BackColor = Color.Gray;
            tramLigth3.BackColor = Color.Gray;
            tramLigth4.BackColor = Color.Gray;
        }
    }
}
