using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Andre_Butler___13Ho___Assessment
{
    class Missileshoot
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image missileshootImage;//variable for the planet's image

        public Rectangle missileshootRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Missileshoot()
        {
            x = 10;
            y = 10;
            width = 20;
            height = 20;
            //planetImage contains the plane1.png image
            missileshootImage = Properties.Resources.missileshoot;
            missileshootRec = new Rectangle(x, y, width, height);
        }

        public void MoveMissileshoot(string move)
        {
            


            if (move == "space")
            {


                if (missileshootRec.Location.X > 390) // is spaceship within 50 of right side
                {

                    x = 390;
                    // spaceRec.Location = new Point(x, y);
                }
                else
                {
                    x += 5;
                    // spaceRec.Location = new Point(x, y);
                }

            }


        }

        public void DrawMissileshoot(Graphics g)
        {
            missileshootRec = new Rectangle(x, y, width, height);
            g.DrawImage(missileshootImage, missileshootRec);
        }
    }

}
