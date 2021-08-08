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
    /// Interaction logic for DoubleClickWindow.xaml
    /// </summary>
    public partial class DoubleClickWindow : Window
    {
     
        public DoubleClickWindow()
        {
            InitializeComponent();
        }


     
        
       
        public string MyText
        {
            get { return (string)GetValue(MyTextProperty); }
            set { SetValue(MyTextProperty, value); }
           
        }

        public static readonly DependencyProperty MyTextProperty =
            DependencyProperty.Register("MyText", typeof(string),
              typeof(DoubleClickWindow), new UIPropertyMetadata("This Is Some Text Of Mine"));

        private void MyBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                MyBlock.Visibility = Visibility.Collapsed;
                MyBox.Visibility = Visibility.Visible;
            }
        }

        private void MyBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            MyBox.Visibility = Visibility.Collapsed;
            MyBlock.Visibility = Visibility.Visible;
        }
    }
}
