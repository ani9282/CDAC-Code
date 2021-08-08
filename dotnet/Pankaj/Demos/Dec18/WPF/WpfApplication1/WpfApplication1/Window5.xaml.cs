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
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        string[] Arr = { "Alok", "Rajat","Riya","Aliya","Raman" };
        public Window5()
        {
            InitializeComponent();
            combo1.ItemsSource = Arr;
        }

        private void combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textBlock1.Text = combo1.SelectedItem.ToString();
        }
    }
}
