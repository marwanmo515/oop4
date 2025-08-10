using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    internal class Rectangle
    {
        private int width;
        private int height;

        
        public Rectangle()
        {
            width = 0;
            height = 0;
        }

        
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        
        public Rectangle(int line)
        {
            width = line;
            height = line;
        }
        public void Display()
        {
            Console.WriteLine($"Width: {width}, Height: {height}");
        }
    }
}
