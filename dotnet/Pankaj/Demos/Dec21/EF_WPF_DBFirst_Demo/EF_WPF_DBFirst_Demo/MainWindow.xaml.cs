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
using System.Data.Entity;


namespace EF_WPF_DBFirst_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CGCMREntities dcon = null;
        int prdId = 0;
        public MainWindow()
        {
            InitializeComponent();
            dcon= new CGCMREntities();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
           
           
            Product pobj = dcon.Products.FirstOrDefault(p => p.ProdID ==prdId );
            if(pobj!=null)
            {
                List<Product> prodList = new List<Product>();
                prodList.Add(pobj);
                dataGrid1.ItemsSource = prodList;
            }
           
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Product pobj = new Product();
            pobj.ProdID =Int32.Parse( txtProdId.Text);
            pobj.ProdName = txtProdName.Text;
            pobj.ProdCategory = txtCategory.Text;
            pobj.price = Int32.Parse(txtPrice.Text);
            pobj.qty = Int32.Parse(txtQty.Text);
            //Updating DB
            dcon.Products.Add(pobj);
            dcon.SaveChanges();
            System.Windows.Forms.MessageBox.Show("Record Added");

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var result = from id in dcon.Products
                         select new { id.ProdID, id.ProdName };
        
            //SELECT PRODID,PRODNAME from PRODUCTS  

            comboBox.ItemsSource =result.ToList();
            comboBox.DisplayMemberPath = "ProdName";
            comboBox.SelectedValuePath = "ProdID";
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            prdId = Int32.Parse(comboBox.SelectedValue.ToString());
            btnSearch_Click(sender, e);
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
