using System;
using System.Globalization;

namespace Rascunho
{
    class Rectangle
    {
        public double Width;
        public double Height;

        public double Area()
        {
            return Width * Height;
        }

        public double Peremeter()
        {
            return 2*(Width + Height);
        }

        public double Diagonal => Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
        
    }
}
