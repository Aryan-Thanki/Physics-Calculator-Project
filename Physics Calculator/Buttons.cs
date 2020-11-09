using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physics_Calculator
{
    class Buttons
    {
        public int locationX;
        public int locationY;

        public int Width = 50;
        public int Height = 50;
        public string Text;
        public string Name;
        public string Font = "Segoe UI";
        public int fontSize = 16;
        public int[,,] buttonsLocation = new int[1, 1, 3] { { { 1, 50, 50 } } };

            public Buttons(int aLocationX, int aLocationY, string aText, string aName)
        {
            locationX = aLocationX;
            locationY = aLocationY;
            Text = aText;
            Name = aName;

        }
    }
}
