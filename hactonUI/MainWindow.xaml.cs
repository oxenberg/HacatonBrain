using System;
using System.Diagnostics;
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

namespace hactonUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
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
                ImportFileName.Text = filename;
            }
        }

        private void GridSplitter_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
        private void run_cmd()
        {

            string fileName = @"C:\Users\user\source\repos\PythonApplication1\PythonApplication1\PythonApplication1.py";

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"C:\Users\user\source\repos\PythonApplication1\PythonApplication1\env\Scripts\python.exe", fileName)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            Console.WriteLine(output);

            Console.ReadLine();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            run_cmd();
        }
    }
}
    
