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
using System.Windows;

using System.IO;//For File Handling

namespace FileIODemoinWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FileStream fs = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            StreamReader sr = null;
            try
            {
                string fileName = txtFileName.Text;
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                //Loading Data in RichTextBox
                rtbTextData.AppendText(sr.ReadToEnd());
            }
            catch (FileNotFoundException fe)
            {
                MessageBox.Show(fe.Message);

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);

            }
            finally
            {

                sr.Close();
                fs.Close();
            }

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = null;
            try
            {
                string fileName = txtFileName.Text;
                fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                //Saving Data from RichTextBox
                sw.WriteLine(rtbTextData.Text);
               
            }
            catch (FileNotFoundException fe)
            {
                MessageBox.Show(fe.Message);

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);

            }
            finally
            {

                sw.Close();
                fs.Close();
            }
        }
    }
}
