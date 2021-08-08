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
//For SqlServer Database
using System.Data.SqlClient;
using System.Data;
using System.Windows;


namespace WpfADOConArchDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection con;       
        SqlCommand cmd;
        SqlDataReader sdr;
        public MainWindow()
        {
            InitializeComponent();

            // con = new SqlConnection("server=iet3;UserId=faculty;Password=faculty;Database=PankajDb");
            string conString = "Server=Iet3;User Id=faculty;Password=faculty;database=Pankajdb";
            con = new SqlConnection();
            con.ConnectionString = conString;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            //Setting Command Object
            cmd = new SqlCommand();
            cmd.CommandText = "Select * from Students";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            //Passing Data to DataReader via command Object
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);

            //Binding Data to Grid
            dataGrid1.DataContext = dt;
            con.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            con.Open();

            SqlParameter p1, p2, p3;

            p1 = new SqlParameter("@rollNo",txtRollNo.Text);

            p2 = new SqlParameter("@name", txtName.Text);

            p3 = new SqlParameter("@addr", txtAddr.Text);
            //Setting Command Object

            cmd = new SqlCommand();
            cmd.CommandText = "Insert into Students values(@rollNo,@name,@addr)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            //Adding Param to Command
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);

            int res=cmd.ExecuteNonQuery();

            MessageBox.Show(res + " Record Added");
            con.Close();

        }
    }
}
