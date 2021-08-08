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
using Microsoft.Win32;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for WinImageViewer.xaml
    /// </summary>
    public partial class WinImageViewer : Window
    {
        public WinImageViewer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            Nullable<bool> result = dlg.ShowDialog();
            
            // Get the selected file name and display in a ViewBox

            if (result == true)
            {
                // Open document
                string filename = dlg.FileName;                             
                BitmapImage glowIcon = new BitmapImage();                
                glowIcon.BeginInit();
                glowIcon.UriSource = new Uri( filename);
                glowIcon.EndInit();
                img1.Source = glowIcon;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
