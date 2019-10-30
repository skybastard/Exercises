using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Demo
{
    public struct Rectangle
    {
        public double Length { get; set; }
        public double Height { get; set; }


        // https://www.youtube.com/watch?v=2lUZ58Zyu3w
        // download .NET Core 3.0 SDK and C# 8.0
        public double Area()
        {
            return Length * Height;
        }
    }
}
