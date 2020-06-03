﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLigths
{
    public partial class TrafficLights : Form
    {
        private Timer timerSwitch;
        
        public TrafficLights()
        {
            InitializeComponent();
            InitializeTrafficLights();
            InitializeTimerSwitch();
        }

        private void InitializeTimerSwitch()
        {
            timerSwitch = new Timer();
            timerSwitch.Interval = 1000;
            timerSwitch.Tick += new EventHandler(TimerSwitch_Tick);
            timerSwitch.Start();
        }

        private void TimerSwitch_Tick(object sender, EventArgs e)
        {
            if (redLigth.BackColor == Color.Gray)
            {
                redLigth.BackColor = Color.Red;
            }
            else 
            {
                redLigth.BackColor = Color.Gray;
            }
        }

        private void InitializeTrafficLights()
        {
            redLigth.BackColor = Color.Gray;
            yellowLigth.BackColor = Color.Gray;
            greenLigth.BackColor = Color.Gray;
        }

       
    }
}
