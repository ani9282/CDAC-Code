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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace WpfDisconArchDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection con;
        SqlDataAdapter adap1, adap2;
        DataSet ds;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            con = new SqlConnection("Server=iet3;User Id=faculty;Password=faculty;Database=PankajDb");
            adap1 = new SqlDataAdapter("Select * from Students", con);
            ds = new DataSet();
            adap1.Fill(ds, "Stud");

            dataGrid.ItemsSource = ds.Tables[0].Rows;

        }
    }
}
