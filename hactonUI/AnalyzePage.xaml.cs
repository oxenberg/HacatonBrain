using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for AnalyzePage.xaml
    /// </summary>
    public partial class AnalyzePage : Page
    {
        public AnalyzePage()
        {
            InitializeComponent();
        }

        private void AnalyzeClick(object sender, RoutedEventArgs e)
        {
            run_cmd();
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

        private void TimeClick(object sender, RoutedEventArgs e)
        {
        }
        private void CorrClick(object sender, RoutedEventArgs e)
        {
        }
        private void PowerGraphClick(object sender, RoutedEventArgs e)
        {
            
        }
        private void FrequencyClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
