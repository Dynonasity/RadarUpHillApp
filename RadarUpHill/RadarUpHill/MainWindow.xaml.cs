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

namespace RadarUpHill
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

        private void StartPolling(object sender, RoutedEventArgs e)
        {
            Debug.Print("Start");
            PollingText.Content = "Polling True";
        }

        private void StopPolling(object sender, RoutedEventArgs e)
        {
            Debug.Print("Stop");
            PollingText.Content = "Polling False";
        }
    }
}
