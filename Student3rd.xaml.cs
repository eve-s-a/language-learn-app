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
    /// Interaction logic for Student3rd.xaml
    /// </summary>
    public partial class Student3rd : Window
    {
        int score1;
        int score2;
        int score3;
        public Student3rd()
        {
            InitializeComponent();
        }

        public Student3rd(int a1Score, int a2Score, int a3Score)
        {
            InitializeComponent();
            score1 = a1Score;
            score2 = a2Score;
            score3 = a3Score;
        }

        private void y6_Click(object sender, RoutedEventArgs e)
        {
            ViewScoringSystem viewScoringSystem = new ViewScoringSystem(score1, score2, score3);
            viewScoringSystem.Show();
            Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Student2nd student2nd = new Student2nd(score1, score2, score3);
            student2nd.Show();
            Close();
        }

        private void n6_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(score1, score2, score3);
            mainWindow.Show();
            Close();
        }
    }
}
