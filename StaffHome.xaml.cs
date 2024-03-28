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
    /// Interaction logic for StaffHome.xaml
    /// </summary>
    public partial class StaffHome : Window
    {
        int score1;
        int score2;
        int score3;
        public StaffHome()
        {
            InitializeComponent();
        }

        public StaffHome(int a1Score, int a2Score, int a3Score)
        {
            InitializeComponent();
            score1 = a1Score;
            score2 = a2Score;
            score3 = a3Score;
        }

        private void n2_Click(object sender, RoutedEventArgs e)
        {
            Staff2nd staff2nd = new Staff2nd(score1, score2, score3);
            staff2nd.Show();
            Close();
        }

        private void y2_Click(object sender, RoutedEventArgs e)
        {
            StaffViewProgress staffViewProgress = new StaffViewProgress(score1, score2, score3);
            staffViewProgress.Show();
            Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(score1, score2, score3);
            mainWindow.Show();
            Close();
        }
    }
}
