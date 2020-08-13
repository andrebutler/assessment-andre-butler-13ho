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
        Planet planet1 = new Planet(); //create the object, planet1
        // declare space for an array of 7 objects called planet 
        Missile[] missile = new Missile[7];
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                int x = 10 + (i * 75);
               missile[i] = new Missile(x);
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawPlanet method to draw the image planet1 
            planet1.DrawPlanet(g);
            for (int i = 0; i < 7; i++)
            {
                //call the Planet class's drawPlanet method to draw the images
                missile[i].DrawMissile(g);
            }


        }

        private void TmrPlanet_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                planet[i].MovePlanet();

            }
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }
    }
}

