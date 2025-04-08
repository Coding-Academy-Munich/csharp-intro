using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectanges
{
    class Rectangle
    {

        public int Width { get; private set; }
        public int Height { get; private set; }
        public string Color { get; private set; }

        public Rectangle(int width, int height, string color)
        {
            Width = width;
            Height = height;
            Color = color;
        }

        public void ChangeSize(int newWidth, int newHeight)
        {
            Width = newWidth;
            Height = newHeight;
        }

        public void ChangeColor(string newColor)
        {
            Color = newColor;
        }

        public void WriteInfo()
        {
            string info = "Rectangle: " + Width + "x" + Height + ", " + Color;
            Console.WriteLine(info);
        }
    }
}
