using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace RecursiveShapes
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var app = new Application();
            var root = new Window();
            root.Title = "Check this recursive shape out";
            Grid grid = new Grid();
            root.Width = 700;
            root.Height = 700;
            var radius = 600;

            Recursion recursion = new Recursion(grid, 20);
            root.Content = grid;

            SolidColorBrush goldB = new SolidColorBrush();
            goldB.Color = Colors.Gold;
            SolidColorBrush blackB = new SolidColorBrush();
            blackB.Color = Colors.Black;
            grid.Background = blackB;

            Ellipse ellipse = new Ellipse();
            ellipse.Margin = new Thickness(0, 0, 0, 0);
            ellipse.Width = ellipse.Height = radius;
            ellipse.Fill = goldB;



            grid.Children.Add(ellipse);
            recursion.DrawCircle(radius / 2, Colors.Black, 0, 0, 0, 0);
            recursion.Recurse(radius / 2, 0, 0, 0, 0);
            root.Show();
            app.MainWindow = root;
            app.Run();
        }
        public void Start(double scale, Application app)
        {
            var root = new Window();
            root.Title = "Check this recursive shape out";
            Grid grid = new Grid();
            root.Width = 700;
            root.Height = 700;
            var radius = 600;

            Recursion recursion = new Recursion(grid, scale);
            root.Content = grid;

            SolidColorBrush goldB = new SolidColorBrush();
            goldB.Color = Colors.Gold;
            SolidColorBrush blackB = new SolidColorBrush();
            blackB.Color = Colors.Black;
            grid.Background = blackB;

            Ellipse ellipse = new Ellipse();
            ellipse.Margin = new Thickness(0, 0, 0, 0);
            ellipse.Width = ellipse.Height = radius;
            ellipse.Fill = goldB;



            grid.Children.Add(ellipse);
            app.MainWindow = root;
            root.Show();
            recursion.DrawCircle(radius / 2, Colors.Black, 0, 0, 0, 0);
            recursion.Recurse(radius / 2, 0, 0, 0, 0);
        }
    }
}
