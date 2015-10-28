using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Major Project
// Programmer:       Robert J. Sutton
// Course:           CSC450, Section 1, Fall 2015
// Date:             16.11.2015
// Description:      This programme is designed to provide a simple, but as true to life as
//                   possible traffic model to answer the question:
//
//                   Does excessive lane changing on multilane motorways cause delays?
//              
//



namespace Project_1
{
    public partial class Form1 : Form
    {
        /************ Constant factors from Mehar et al (2013)****************/
        /***** Used to calculate acceleration as a function of velocity ******/
        const decimal A = 1.915m;                                            //
        const decimal B = -0.0375m;                                          //
        const decimal C = 3.705m;                                            //
        const decimal D = -0.0525m;                                           //
        /*********************************************************************/

        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            decimal t = 0;
            int ID = 0;
            car[] cars = new car[10000];
            while (1 == 1)
            { 
                if (Math.Abs(t / 2 - Math.Floor(t / 2)) < 0.001m)
                {


                }
                //int tt = Convert.ToInt16(Math.Floor(t));
                //if (t - tt < 0.001m && tt % 2 == 0) cars[ID] = createCar(ID, 0);

                ID++;
                t += 0.01m;        // Run in 0.01 second time intervals.
            }


        }

        public decimal aAve(decimal v)
        {
            return A * Convert.ToDecimal(Math.Exp(Convert.ToDouble(B * v)));
        }

        public decimal aMax(decimal v)
        {
            return C + D * v;
        } 



        
    }

    


/*    
public car createCar(int ID, decimal x)
        {
            car ret;
            ret.ID = ID;
            ret.x = x;

            return ret;
        }
   */ 


    class car
    {
        int ID;             // Unique identifier, incremented by 1 for each agent created
        decimal x;          // Position of the car in meters
        decimal v;          // Velocity of the car (meters/second in +x direction)
        decimal a;          // Change in velocity of car (meters/sec/sec)
        int precedingCar;   // The car ahead
        int followingCar;   // The car behind
        bool exists;        // Set to true when agent is created, false when destroyed
        decimal BAC;        // Driver's blood alcohol content (% v/v)
        decimal aggFac;     // Driver's aggression factor
        decimal reactTime;  // Driver's reaction time (seconds)
        decimal vDesired;   // Driver's desired velocity
        decimal headway;    // Distance between the car and the rear of the preceding car (meters)

    }
}
