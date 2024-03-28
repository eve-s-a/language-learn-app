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
using System.Windows.Shapes;

namespace Newproject
{
    /// <summary>
    /// Interaction logic for Staff2nd.xaml
    /// </summary>
    public partial class Staff2nd : Window
    {
        int score1;
        int score2;
        int score3;
        public Staff2nd()
        {
            InitializeComponent();
        }

        public Staff2nd(int a1Score, int a2Score, int a3Score)
        {
            InitializeComponent();
            score1 = a1Score;
            score2 = a2Score;
            score3 = a3Score;
        }

        private void y3_Click(object sender, RoutedEventArgs e)
        {
            ViewUsageData viewUsageData = new ViewUsageData(score1, score2, score3);
            viewUsageData.Show();
            Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            StaffHome staffHome = new StaffHome(score1, score2, score3);
            staffHome.Show();
            Close();
        }

        private void n3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(score1, score2, score3);
            mainWindow.Show();
            Close();
        }
    }
}
