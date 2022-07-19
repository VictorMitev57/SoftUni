using System;

namespace Heart
{
    class Program
    {
            // The curve's parametric equations.
            private float X(float t)
            {
                double sin_t = Math.Sin(t);
                return (float)(16 * sin_t * sin_t * sin_t);
            }
            private float Y(float t)
            {
                return (float)(
                    13 * Math.Cos(t) -
                    5 * Math.Cos(2 * t) -
                    2 * Math.Cos(3 * t) -
                    Math.Cos(4 * t));
            }
        }

    }
// Draw the curve on a bitmap.
private Bitmap DrawHeart(int width, int height)
{
    Bitmap bm = new Bitmap(width, height);
    using (Graphics gr = Graphics.FromImage(bm))
    {
        gr.SmoothingMode = SmoothingMode.AntiAlias;

        // Generate the points.
        const int num_points = 100;
        List points = new List();
        float dt = (float)(2 * Math.PI / num_points);
        for (float t = 0; t <= 2 * Math.PI; t += dt)
            points.Add(new PointF(X(t), Y(t)));

        // Get the coordinate bounds.
        float wxmin = points[0].X;
        float wxmax = wxmin;
        float wymin = points[0].Y;
        float wymax = wymin;
        foreach (PointF point in points)
        {
            if (wxmin > point.X) wxmin = point.X;
            if (wxmax < point.X) wxmax = point.X;
            if (wymin > point.Y) wymin = point.Y;
            if (wymax < point.Y) wymax = point.Y;
        }

        // Make the world coordinate rectangle.
        RectangleF world_rect = new RectangleF(
            wxmin, wymin, wxmax - wxmin, wymax - wymin);

        // Make the device coordinate rectangle with a margin.
        const int margin = 5;
        Rectangle device_rect = new Rectangle(
            margin, margin,
            picGraph.ClientSize.Width - 2 * margin,
            picGraph.ClientSize.Height - 2 * margin);

        // Map world to device coordinates without distortion.
        // Flip vertically so Y increases downward.
        SetTransformationWithoutDisortion(gr,
            world_rect, device_rect, false, true);

        // Draw the curve.
        gr.FillPolygon(Brushes.Pink, points.ToArray());
        using (Pen pen = new Pen(Color.Red, 0))
        {
            gr.DrawPolygon(pen, points.ToArray());
        }
    }
    return bm;
}
