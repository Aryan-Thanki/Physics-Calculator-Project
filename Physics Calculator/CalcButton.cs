using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Physics_Calculator
{
    class CalcButton
    {
        private int _x;
        private int _y;
        private int _width;
        private int _height;
        private string _text;
        private string _name;

        public CalcButton(int x, int y, int width, int height, string text, string name)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
            _text = text;
            _name = name;

        }

        public void DrawButton(Graphics paper)
        {
            SolidBrush br = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black, 1);
            Font f = new Font("Segoe UI", 12);
            paper.DrawRectangle(pen, _x, _y, _width, _height);
            paper.DrawString(_text, f, br, _x+_width/2-12, _y+_height/2-12);
        }

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
