using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;


namespace RecursiveShapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string> shapes = new List<string>() {"Nested Circles", "Recursive Cubes"};
            cBShapes.ItemsSource = shapes;
        }


        private void cBShapes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Double numD = 0.0;
            int numI = 0;
            if (cBShapes.SelectedIndex == -1)
            {
                MessageBox.Show("Nothing selected!");
            }
            else
            {
                if ((int.TryParse(tBScale.Text, out numI) || double.TryParse(tBScale.Text, out numD)) && !string.IsNullOrEmpty(tBScale.Text))
                {
                    new Program().Start(Convert.ToDouble(tBScale.Text), Application.Current);
                    
                }
                else
                {
                    MessageBox.Show("Entered scale is incorrect!");
                }
                
            }
        }

        private void tBScale_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
