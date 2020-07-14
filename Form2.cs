using System;
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
    public partial class Form2 : Form
    {
        bool offMode = true;
       
        TrafficLights mainForm;
        public Form2(TrafficLights f)
        {
            InitializeComponent();
            mainForm = f;
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }

            base.OnFormClosing(e);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (offMode)
            {
                mainForm.Turn_On();
                label2.Text = "Traffic ligths are on";
                label2.ForeColor = Color.Green;
                button1.BackColor = Color.Red;
                button1.Text = "Turn off";
                offMode = false;
            }
            else 
            {
                mainForm.Turn_Off();
                label2.Text = "Traffic ligths are off";
                label2.ForeColor = Color.Red;
                button1.BackColor = Color.Green;
                button1.Text = "Turn on";
                offMode = true;
            }
        }

        
    }
}
