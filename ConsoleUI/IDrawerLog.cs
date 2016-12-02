using System;
using System.Drawing;

namespace DrawablesUI
{
    public class IDrawerLog : IDrawer
    {
        public void SelectPen(Color color, int width = 1)
        {

        }

        public void DrawPoint(PointF point)
        {
            Console.WriteLine("Точка(" + point.X + ", " + point.Y + ")");
        }

        public void DrawLine(PointF start, PointF end)
        {
            Console.WriteLine("(Точка(" + start.X + ", " + start.Y + "), Точка(" + end.X + ", " + end.Y + "))");
        }

        public void DrawEllipseArc(PointF center, SizeF size, float startAngle = 0, float endAngle = 360, float rotate = 0)
        {
            Console.WriteLine("(Точка(" + center.X + ", " + center.Y + "), радиус=" + size + ")");
        }
    }
}