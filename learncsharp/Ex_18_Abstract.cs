using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncsharp
{

    abstract class Shape
    {
        int x, y;
        public Shape()
        {
        }
        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void application()
        {
            Console.WriteLine("Ms Paint");
        }
        public abstract void draw();
    }

    class Line : Shape
    {
        public Line(int x, int y): base(x,y)
        {
        }
        public override void draw()
        {
            Console.WriteLine("draw a line");
        }
    }
    class Square : Shape
    {
        public override void draw()
        {
            Console.WriteLine("draw a Square");
        }
    }
    internal class Ex_18_Abstract
    {

        public  void Main()
        {
            Line c =new Line(5,6);
            c.draw();
            c.application();
        }
    }
}
