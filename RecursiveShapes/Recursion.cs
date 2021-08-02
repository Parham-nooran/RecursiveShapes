using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace RecursiveShapes
{
    public class Recursion
    {
        private Grid grid;
        private double scale = 2;
        public double Scale
        {
            get
            {
                return this.scale;
            }
            set
            {
                this.scale = value;
            }
        }

        public Recursion(Grid grid)
        {
            this.grid = grid;
        }
        public Recursion(Grid grid, double scale) : this(grid)
        {
            this.scale = scale;
        }

        public int DrawCircle(double radius, Color color, double left, double top, double right, double down)
        {
            if(radius < this.scale)
            {
                return 0;
            }
            var ellipse = new Ellipse();
            ellipse.Height = ellipse.Width = radius;
            SolidColorBrush solidColorBrush = new SolidColorBrush();
            solidColorBrush.Color = color;
            ellipse.Margin = new Thickness(left, top, right, down);
            ellipse.Fill = solidColorBrush;
            this.grid.Children.Add(ellipse);
            /*
             * var center = new Ellipse();
            center.Height = center.Width = radius / 2;
            SolidColorBrush solidColor = new SolidColorBrush();
            solidColor.Color = Colors.Black;
            center.Margin = new Thickness(left, top, right, down);
            */
            DrawCircle(radius / 2, Colors.Black, left, top, right, down);
            Recurse(radius / 2, left, top, right, down);
            return 0;
        }
        public int Recurse(double radius, double left, double top, double right, double down)
        {
            if (radius < this.scale)
            {
                return 0;
            }
            this.DrawCircle(radius/2, Colors.Red, left + radius * 3/2, top, right, down);
            this.DrawCircle(radius/2, Colors.Aqua, left, top + radius * 3/ 2, right, down);
            this.DrawCircle(radius/2, Colors.Yellow, left, top, right + radius * 3 / 2, down);
            this.DrawCircle(radius/2, Colors.Purple, left, top, right, down + radius * 3 / 2);

            this.DrawCircle(radius/2, Colors.BlueViolet, left + radius * 1.06, top + radius * 1.06, right, down);
            this.DrawCircle(radius/2, Colors.Aquamarine, left + radius * 1.06, top, right, down + radius * 1.06);
            this.DrawCircle(radius/2, Colors.BurlyWood, left, top, right + radius * 1.06, down + radius * 1.06);
            this.DrawCircle(radius/2, Colors.Bisque, left, top + radius * 1.06, right + radius * 1.06, down);

            //RecurseBase(radius/2, radius/2);
            Recurse(radius / 2, 0, 0, 0, 0);
            Recurse(radius / 4, 3 * radius/2, 0, 0, 0);
            Recurse(radius / 4, 0, 3 * radius/2, 0, 0);
            Recurse(radius / 4, 0, 0, 3 * radius/2, 0);
            Recurse(radius / 4, 0, 0, 0, 3 * radius/2);

            Recurse(radius / 4, 1.06 * radius, 0, 0, 1.06 * radius);
            Recurse(radius / 4, 0, 0, 1.06 * radius, 1.06 * radius);
            Recurse(radius / 4, 1.06 * radius, 1.06 * radius, 0, 0);
            Recurse(radius / 4, 0, 1.06 * radius, 1.06 * radius, 0);
            return 0;
        }
        
        
    }
}
