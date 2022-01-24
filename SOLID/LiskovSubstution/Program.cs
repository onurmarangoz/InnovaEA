using System;

namespace LiskovSubstution
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bir base class ile bu class'dan türeyen derived class birbirlerinin yerine kullanılabilmelidir. Derived base'in davranışını değiştirmemelidir.
             */

            var rect = GetRectangle(4);           

            Console.WriteLine(rect.GetArea()); 

        }




        static IAreaCalcutable GetRectangle(int width, int? height = null)
        {
            if (height.HasValue)
            {
                return new Rectangle(width,height.Value);
            }
            else
            {
                return new  Square(width);
            }
        }


       
    }

    public interface IAreaCalcutable
    {
        int GetArea();
    }

    public class Rectangle : IAreaCalcutable
    {

        public Rectangle(int w, int h)
        {
            Width = w;
            Height = h;
        }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }

    }

    public class Square : IAreaCalcutable
    {
        public Square(int length)
        {
            Length = length;
        }
        public int Length { get; set; }

        public int GetArea()
        {
            return Length * Length;
        }


    }

}
