using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Physics_Calculator
{
    /// <summary>
    /// Class for Drawing the buttons
    /// </summary>
    class CalcButton
    {
        private int _x;
        private int _y;
        private int _width;
        private int _height;
        private string _text;
        private string _name;

        /// <summary>
        /// Gathers the data for the parameters of each button
        /// </summary>
        /// <param name="x">X-coordinate for the button</param>
        /// <param name="y">y-coordinate for the button</param>
        /// <param name="width">Width of the button</param>
        /// <param name="height">Height of the button</param>
        /// <param name="text">Text for the button</param>
        /// <param name="name">Name of the button</param>
        public CalcButton(int x, int y, int width, int height, string text, string name)
        {
            //Stores the coordinate of x into the class scope variable _x
            _x = x;
            //Stores the coordinate of y into the class scope variable _y
            _y = y;
            //Stores the number for width into the class scope variable _width
            _width = width;
            //Stores the number for height into the class scope variable _height
            _height = height;
            //Stores the value for text into the class scope variable _text
            _text = text;
            //Stores the value for name into the class scope variabel _name
            _name = name;
        }
        /// <summary>
        /// Draws the buttons and writes the text inside it
        /// </summary>
        /// <param name="paper">Turns the form into canvas for drawing</param>
        public void DrawButton(Graphics paper)
        {
            //Brush for writing the text inside the button shape/rectangle
            SolidBrush br = new SolidBrush(Color.Black);
            //Pen for drawing the rectangle buttons
            Pen pen = new Pen(Color.Black, 1);
            //Font for the Buttons and size of the font
            Font f = new Font("Segoe UI", 14);
            //Draws the rectangular buttons using data stored int the class scope variables
            paper.DrawRectangle(pen, _x, _y, _width, _height);
            //Writes the text inside each rectangle button when it is created
            paper.DrawString(_text, f, br, _x+_width/2-14, _y+_height/2-16);
        }
        /// <summary>
        /// Checks to see if the mouse is clicked within two x and two y coordiantes (creating a box)
        /// and returns the value for _text. If nothing is clicked, it returns nothing
        /// </summary>
        /// <param name="Mousex">Upper left x - coordiante</param>
        /// <param name="Mousey">Upper left y - coordinate</param>
        /// <returns></returns>
        public string CheckClick(int Mousex, int Mousey)
        {
            if (Mousex >= _x && Mousex <= _x + _width && Mousey >= _y && Mousey <= _y + _height)
            {
                return _text;
            }
            else
            {
                return "none";
            }
        }
    }
}
