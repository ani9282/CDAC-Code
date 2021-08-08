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
    /// Interaction logic for WinShapeClassDemo.xaml
    /// </summary>
    public partial class WinShapeClassDemo : Window
    {
        public WinShapeClassDemo()
        {
            InitializeComponent();
        }

        private void myCircle_MouseEnter(object sender, MouseEventArgs e)
        {
            global::System.Windows.Forms.MessageBox.Show("Test");
        }
    }
}
