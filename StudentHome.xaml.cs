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
    /// Interaction logic for StudentHome.xaml
    /// </summary>
    public partial class StudentHome : Window
    {
        int score1;
        int score2;
        int score3;
        public StudentHome()
        {
            InitializeComponent();
        }

        public StudentHome(int a1Score, int a2Score, int a3Score)
        {
            InitializeComponent();
            score1 = a1Score;
            score2 = a2Score;
            score3 = a3Score;
        }

        private void y4_Click(object sender, RoutedEventArgs e)
        {
            ActivitySelection activitySelection = new ActivitySelection(score1, score2, score3);
            activitySelection.Show();
            Close();
        }

        private void n4_Click(object sender, RoutedEventArgs e)
        {
            Student2nd student2nd = new Student2nd(score1, score2, score3);
            student2nd.Show();
            Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            LanguageSelection languageSelection = new LanguageSelection(score1, score2, score3);
            languageSelection.Show();
            Close();
        }
    }
}
