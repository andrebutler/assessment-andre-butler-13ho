using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Andre_Butler___13Ho___Assessment
{
    public partial class Form1 : Form
    {
        Graphics g; //declare a graphics object called g
        // declare space for an array of 7 objects called planet 
        Planet planet = new Planet();
        //declare a list missiles from the missile class
        List<Missileshoot> missileshoot = new List<Missileshoot>();
        Random xspeed = new Random();
        Missile[] missile = new Missile[7];
       
        bool left, right, space;
        string move;
        int missileTime = 120;
        int score;

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                int y = 10 + (i * 75);
                missile[i] = new Missile(y);
            }







        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawPlanet method to draw the image planet1 
            planet.DrawPlanet(g);
            for (int i = 0; i < 7; i++)
            {

                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = xspeed.Next(5, 20);
                missile[i].x += rndmspeed;

                //call the Planet class's drawPlanet method to draw the images
                missile[i].DrawMissile(g);

              


            }

            foreach (Missileshoot m in missileshoot)
            {
                m.DrawMissileshoot(g);
            }





        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Space) { space = true;
                Missileshoot missileshoot = new Missileshoot();
                missileshoot.x = planet.x;
                missileshoot.y = planet.y;
                this.missileshoot.Add(missileshoot);
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.Space) { space = false; }

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            missileTime--;
            lblTime.Text = missileTime.ToString();
            if (missileTime == -1)
            {
                tmrTime.Enabled = false;
                System.Threading.Thread.Sleep(5000);
                Close();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrTime.Start();
        }


        private void TmrShip_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";
                planet.MovePlanet(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                planet.MovePlanet(move);
            }
            if (space) // if space key pressed
            {
                move = "space";


            }

           

            foreach (Missileshoot m in missileshoot)
            {
                m.MoveMissileshoot();
            }
        }



        private void TmrPlanet_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {


                missile[i].MoveMissile();
                //if a planet reaches the bottom of the Game Area reposition it at the top

                foreach (Missileshoot m in missileshoot)
                {
                    
                    if (m.missileshootRec.IntersectsWith(missile[i].missileRec))

                    {
                        Close();
                    }
                }
            
                if (missile[i].x >= PnlGame.Width-80)
                {
                    missile[i].x = 30;
                }
            }

            


            PnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }


    }
}



