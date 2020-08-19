﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Andre_Butler___13Ho___Assessment
{
    class Planet
    {

        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image planetImage;//variable for the planet's image
        public Rectangle planetRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Planet(int x)
        {
            x = 400;
            y = 10;
            width = 25;
            height = 100;
            //planetImage contains the plane1.png image
            planetImage = Properties.Resources.planet;
            planetRec = new Rectangle(x, y, width, height);
        }


        // Methods for the Planet class
        public void DrawPlanet(Graphics g)
        {
            planetRec = new Rectangle(x, y, width, height);
            g.DrawImage(planetImage, planetRec);
           
        }

        public void MovePlanet1()
        {
            y += 5;

            planetRec.Location = new Point(x, y);
        }

        public void MovePlanet(string move)
        {
            planetRec.Location = new Point(x, y);

            if (move == "right")
            {

                x += 5;
                planetRec.Location = new Point(x, y);
            }

            if (move == "left")
            {

                x -= 5;
                planetRec.Location = new Point(x, y);
            }


        }





    }



}
