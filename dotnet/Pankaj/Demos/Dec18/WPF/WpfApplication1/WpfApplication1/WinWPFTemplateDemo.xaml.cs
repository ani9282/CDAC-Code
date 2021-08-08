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
    /// Interaction logic for WinWPFTemplateDemo.xaml
    /// </summary>
    public partial class WinWPFTemplateDemo : Window
    {
        public WinWPFTemplateDemo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Test");
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
