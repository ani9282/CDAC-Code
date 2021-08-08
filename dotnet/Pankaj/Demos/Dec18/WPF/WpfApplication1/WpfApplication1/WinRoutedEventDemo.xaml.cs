using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for WinRoutedEventDemo.xaml
    /// </summary>
    public partial class WinRoutedEventDemo : Window
    {
        public WinRoutedEventDemo()
        {
            InitializeComponent();
        }
        private void CommonClickHandler(object sender, RoutedEventArgs e)
        {
            FrameworkElement feSource = e.Source as FrameworkElement;
            switch (feSource.Name)
            {
                case "YesButton":
                    System.Windows.Forms.MessageBox.Show("YesButton");
                    break;
                case "NoButton":
                    System.Windows.Forms.MessageBox.Show("NoButton");
                    break;
                case "CancelButton":
                    System.Windows.Forms.MessageBox.Show("CancelButton");
                    break;
            }
            e.Handled = true;
        }
    }
}
