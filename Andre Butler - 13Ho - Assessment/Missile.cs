using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Andre_Butler___13Ho___Assessment
{
    class Missile
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image missileImage;//variable for the missile's image

        public Rectangle missileRec;//variable for a rectangle to place our image in
        public int score;

        //Create a constructor (initialises the values of the fields)
        public Missile(int spacing)
        {
           //x=5;
            y = spacing;
            width = 50;
            height = 25;
            //planetImage contains the plane1.png image
            missileImage = Properties.Resources.missile;
            missileRec = new Rectangle(x, y, width, height);
        }

        // Methods for the Planet class
        public void DrawMissile(Graphics g)
        {
            
            g.DrawImage(missileImage, missileRec);
        }


        public void MoveMissile()
        {
            y += 5;

            missileRec.Location = new Point(x, y);
        }



    }
}
