using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Testíček
{
    public class Kruhy
    {
        public Point Location { get; set; }
        public int Size { get; set; }
        public Color CircleColor1 { get; set; }
        public Color CircleColor2 { get; set; }
        public Color CircleColor3 { get; set; }
        public Color CircleColor4 { get; set; }
        public Color CircleColor5 { get; set; }


        public Kruhy()
        {
            Location = new Point();
            Size = 150;
            CircleColor1 = Color.Yellow;
            CircleColor2 = Color.Crimson;
            CircleColor3 = Color.Aqua;
            CircleColor4 = Color.Black;
            CircleColor5 = Color.Green;
        }
        public void Draw(Graphics graphics)
        {
            Pen pen = new Pen(CircleColor1, Size / 20);

            graphics.DrawEllipse(pen, Location.X, Location.Y, Size, Size);
            pen.Color = CircleColor2;
            graphics.DrawEllipse(pen, (int)(Location.X - Size * 1.2), Location.Y, Size, Size);
            pen.Color = CircleColor3;
            graphics.DrawEllipse(pen, (int)(Location.X + Size * 1.2), Location.Y, Size, Size);
            pen.Color = CircleColor4;
            graphics.DrawEllipse(pen, (int)(Location.X - Size * 0.6), Location.Y + (int)(Size * 0.6), Size, Size);
            pen.Color = CircleColor5;
            graphics.DrawEllipse(pen, (int)(Location.X + Size * 0.6), Location.Y + (int)(Size * 0.6), Size, Size);
        }


    }
    
}
