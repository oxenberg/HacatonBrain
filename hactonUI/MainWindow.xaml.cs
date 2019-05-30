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
using hactonUI.Pages;

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


        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ImportButton(object sender, RoutedEventArgs e)
        {
            Frame.Content = new ImporPage();
        }

        private void GridSplitter_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {

        }

        private void SettingsButton(object sender, RoutedEventArgs e)
        {

        }
        

        private void AnalyzeButton(object sender, RoutedEventArgs e)
        {
            Frame.Content = new AnalyzePage();
        }

        private void ExportButton(object sender, RoutedEventArgs e)
        {
        }
        private void myFrame_ContentRendered(object sender, EventArgs e)
        {
            Frame.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;
        }
    }
}
    
