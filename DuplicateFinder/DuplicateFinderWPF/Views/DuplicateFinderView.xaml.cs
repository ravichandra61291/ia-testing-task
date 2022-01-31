using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace DuplicateFinderWPF.Views
{
    /// <summary>
    /// Interaktionslogik für DuplicateFinderView.xaml
    /// </summary>
    public partial class DuplicateFinderView : Window
    {
        public DuplicateFinderView()
        {
            InitializeComponent();
        }

        private void ClossingButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ControlBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
    
}
