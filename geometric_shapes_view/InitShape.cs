﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace geometric_shapes_view
{
    class InitShape
    {
    
        public static Point create2DPoint()
        {
            Random rnd = new Random();
            double x = rnd.NextDouble()*350;
            double y = rnd.NextDouble()*350;
            Point2D p = new Point2D();
            
            return p.Init(x, y);
        }

        public static void createRndTriangle()
        {

        }

        public static void createRndRectangel()
        {

        }

        public static void createRectangel()
        {

        }
        
    }
}