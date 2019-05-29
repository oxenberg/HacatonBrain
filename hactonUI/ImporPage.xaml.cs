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

namespace hactonUI.Pages
{
    /// <summary>
    /// Interaction logic for ImporPage.xaml
    /// </summary>
    public partial class ImporPage : Page
    {
        public ImporPage()
        {
            InitializeComponent();
        }

        private void importClick(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // Set filter for file extension and default file extension
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text documents (.txt)|*.txt";

            // Display OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox
            if (result == true)
            {
                // Open document
                string filename = dlg.FileName;
                UplodeName.Text = filename;
            }
        }
        private void saveClick(object sender, RoutedEventArgs e)
        {
            string destinationFile = @"C:C:\Users\yael4\OneDrive\Documents\yy.txt";
            if (destinationFile != null)
            {
                // To move a file or folder to a new location:
                System.IO.File.Move(UplodeName.Text, destinationFile);
            }
        }

    }
}
