using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace GTCommons
{
    /// <summary>
    /// liyafei add save the data
    /// </summary>
    public class StaticData
    {
        public static bool IsWhitePointEnabled = false;
        public static bool IsBlackCrossEnabled = false;
        public static bool IsWhiteCrossEnabled = false;
        public static MyPosition WhitePointPosition = new MyPosition(0,0);
        public static MyPosition BlackCrossPosition = new MyPosition(0, 0);
        public static MyPosition WhiteCrossPosition = new MyPosition(0, 0);
        static string filePath = Path.Combine(Environment.CurrentDirectory, "positions.txt");
        static string lastMessage = string.Empty;
        static bool WriteFile = true;

        public static string Message
        {
            get
            {
                string message = string.Empty;
                if (IsWhitePointEnabled)
                {
                    message += $" RandomPoint({WhitePointPosition.X.ToString("0.00")},{WhitePointPosition.Y.ToString("0.00")})";
                }
                if (IsBlackCrossEnabled)
                {
                    message += $" Pupil({BlackCrossPosition.X.ToString("0.00")},{BlackCrossPosition.Y.ToString("0.00")})";
                }
                if (IsWhiteCrossEnabled)
                {
                    message += $" Glint({WhiteCrossPosition.X.ToString("0.00")},{WhiteCrossPosition.Y.ToString("0.00")})";
                }
                if (string.IsNullOrEmpty(message.Trim()))
                {
                    message = "Not Found";
                }
                else
                {
                    if (WriteFile&&message != lastMessage)
                    {
                        //写文件
                        File.AppendAllText(filePath, $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] {message}\r\n", Encoding.Default);
                        lastMessage = message;
                    }
                }
                return message;
            }
        }
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
