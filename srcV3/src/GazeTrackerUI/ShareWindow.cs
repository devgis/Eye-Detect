using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GazeTrackerUI
{
    public class ShareWindow
    {
        public static RandomSpotWindow RandomSpotWindow = new RandomSpotWindow();
    }

    public struct MyPosition
    {
        public MyPosition(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X;
        public double Y;
    }
}
