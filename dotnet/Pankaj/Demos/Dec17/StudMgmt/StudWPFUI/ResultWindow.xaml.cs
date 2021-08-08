using StudentEntity;
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

namespace StudWPFUI
{
    /// <summary>
    /// Interaction logic for ResultWindow.xaml
    /// </summary>
    public partial class ResultWindow : Window
    {
        public ResultWindow()
        {
            InitializeComponent();
        }
        public ResultWindow(Student myStud)
        {
            InitializeComponent();
            lblRollNo.Content = myStud.RollNo.ToString();
            lblName.Content = myStud.Name.ToString();
            lblTot.Content = myStud.Tot.ToString();
            lblAvg.Content = myStud.Perc.ToString();
        }
    }
}
