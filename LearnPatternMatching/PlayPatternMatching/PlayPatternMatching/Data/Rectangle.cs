using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayPatternMatching.Data
{
    public struct Rectangle
    {
        public double Length { get; init; }
        public double Width { get; init; }


        //public void Deconstruct(out double surface)
        //{
        //    surface = Length * Height;
        //}
    }
}
