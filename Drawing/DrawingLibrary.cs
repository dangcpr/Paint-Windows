using System;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Drawing
{
    public static class DrawingLibrary
    {
        public static Line drawLine(Brush stroke, double thick, double x1, double y1, double x2, double y2)
        {
            return new Line
            {
                Stroke = stroke,
                StrokeThickness = thick,
                X1 = x1,
                Y1 = y1,
                X2 = x2,
                Y2 = y2
            };
        }
        public static Ellipse drawEllipse(Brush stroke, double thick, double x1, double y1, double x2, double y2)
        {
            return new Ellipse
            {
                Stroke = stroke,
                StrokeThickness = thick,
                Width = Math.Abs(x2 - x1),
                Height = Math.Abs(y2 - y1),
            };
        }

        public static Rectangle drawRectangle(Brush stroke, double thick, double x1, double y1, double x2, double y2)
        {
            return new Rectangle
            {
                Stroke = stroke,
                StrokeThickness = thick,
                Width = Math.Abs(x2 - x1),
                Height = Math.Abs(y2 - y1),
            };
        }
    }
}
