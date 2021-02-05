using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Rectangle
    {
        private decimal width = 1M;
        private decimal height = 1M;

        public Rectangle()
        {
            width = 1M;
            height = 1M;
        }

        public Rectangle (decimal width, decimal height)
        {
            this.width = width;
            this.height = height;
        }

        public decimal GetWidth()
        {
            return this.width;
        }

        public decimal GetHeight()
        {
            return this.height;
        }

        public decimal GetArea()
        {
            return GetWidth() * GetHeight();
        }

        public decimal GetPerimeter()
        {
            return (GetWidth() + GetHeight()) * 2;
        }

        public override string ToString()
        {
            return string.Format("W: {0} H: {1} A: {2} P: {3}", GetWidth(), GetHeight(), GetArea(), GetPerimeter());
        }


    }
}
