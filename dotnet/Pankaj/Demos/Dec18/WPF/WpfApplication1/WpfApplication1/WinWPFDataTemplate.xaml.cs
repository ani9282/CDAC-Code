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
    /// Interaction logic for WinWPFDataTemplate.xaml
    /// </summary>
    public partial class WinWPFDataTemplate : Window
    {
        List<Person> myPers;
        public WinWPFDataTemplate()
        {
            InitializeComponent();
            myPers = new List<Person>();
            myPers.Add(new Person() { Name = "Alok" });
            myPers.Add(new Person() { Name = "Raman" });
            myPers.Add(new Person() { Name = "Sumeet" });
            myPers.Add(new Person() { Name = "Riya" });
            this.DataContext = myPers;
        }
    }
}
