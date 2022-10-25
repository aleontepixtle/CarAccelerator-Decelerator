// Author: Andres Leon T
// Date: 07/23/22
// Program: Car Class
// Purpose: this file creates a new Car object, one button increases speed using the
// Accelerate Method in the car class and changes the form color as it accelerates
// The other button decreases the speed Method in the car class and and changes
// the form color as it brakes. When speed reaches 0 the brake button is hidden
// and the form color returns to default.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Carr_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // New car object is created
        Car newCar = new Car();

        // accerlate button event handler
        private void accelerateButton_Click(object sender, EventArgs e)
        {
            // back color changed to green
            BackColor = Color.Green;

            // car speed is increased
            newCar.Accelerate();

            // speed label displays current speed
            speedLabel.Text = newCar.Speed.ToString() + " mph";

            // brake button returns visible when speed is more than 0
            if (newCar.Speed > 0)
            {
                brakeButton.Visible = true;
            }
        }

        // brake button event handler
        private void brakeButton_Click(object sender, EventArgs e)
        {
            // back color changed to red
            BackColor = Color.Red;
            // car speed is decreased
            newCar.Brake();
            // speed label displays current speed
            speedLabel.Text = newCar.Speed.ToString() + " mph";

            // brake button hidden when speed is 0 and backcolor returns to default
            if (newCar.Speed == 0)
            {
                brakeButton.Visible = false;
                BackColor = DefaultBackColor;
            }
            
        }


        // exit button event handler
        private void exitButton_Click(object sender, EventArgs e)
        {
            // closes form
            this.Close();
        }

        // form load event
        private void Form1_Load(object sender, EventArgs e)
        {
            // hides brae button on load to prevent deceleration at 0
            brakeButton.Visible = false;
        }
    }
}
