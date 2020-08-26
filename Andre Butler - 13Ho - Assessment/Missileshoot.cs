using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

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



        public void DrawMissileshoot(Graphics g)
        {
                    g.DrawImage(missileshootImage, missileshootRec);
        }


      

    }
}
