﻿using System;
using System.Collections.Generic;

namespace PolymorphismExample
{
    class Polygon
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a Polygon.");
        }
    }
    class Rectangle : Polygon
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle.");
        }
    }
    class Triangle : Polygon
    {
        public new void Draw()
        {
            Console.WriteLine("Drawing a Triangle.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Polygon> polygons = new List<Polygon>();
            polygons.Add(new Polygon());
            polygons.Add(new Rectangle());          //rectangle that has been cast as a polygon
            polygons.Add(new Triangle());           //triangle that has been cast as a polygon

            foreach (Polygon p in polygons)
            {
                p.Draw();
            }

            Triangle triangle1 = new Triangle();
            triangle1.Draw();
        }
    }
}