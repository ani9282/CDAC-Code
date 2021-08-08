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
using StudentBLProj;
using StudentExceptions;

namespace StudWPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StudentEntity.Student sObj=null;
        StudentBL studBL = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            bool res = false;
            try
            {
                //Accept Student Details
                sObj = new StudentEntity.Student();
                sObj.RollNo = Int32.Parse(txtRollNo.Text);
                sObj.Name = txtName.Text;
                sObj.Phy = Int32.Parse(txtPhy.Text);
                sObj.Chem = Int32.Parse(txtChem.Text);
                sObj.Maths = Int32.Parse(txtMaths.Text);

                //Passing Data to BL
                studBL = new StudentBL();
                res = studBL.AddStudent(sObj);
            }
            catch (InvalidMarksException e1)
            {
                MessageBox.Show(e1.Message);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

            if (res)
            {
                MessageBox.Show("Record Added");
                ResultWindow rw = new ResultWindow(sObj);
                rw.Show();
            }

        }

      
    }
}
