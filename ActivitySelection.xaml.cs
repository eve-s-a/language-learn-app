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
    /// Interaction logic for ActivitySelection.xaml
    /// </summary>
    public partial class ActivitySelection : Window
    {

        int score1;
        int score2;
        int score3;
        public ActivitySelection()
        {
            InitializeComponent();
        }

        public ActivitySelection(int a1Score, int a2Score, int a3Score )
        {
            InitializeComponent();
            score1 = a1Score;
            score2 = a2Score;
            score3 = a3Score;
        }

        private void speaking_Click(object sender, RoutedEventArgs e)
        {
            Activity1 activity1 = new Activity1(score1,score2,score3);
            activity1.Show();
            Close();
        }

        private void memory_Click(object sender, RoutedEventArgs e)
        {
            Activity2 activity2 = new Activity2(score1, score2, score3);
            activity2.Show();
            Close();
        }

        private void speedandaccuracy_Click(object sender, RoutedEventArgs e)
        {
            Activity3 activity3 = new Activity3(score1, score2, score3);
            activity3.Show();
            Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            StudentHome studentHome = new StudentHome(score1, score2, score3);
            studentHome.Show();
            Close();
        }
    }
}
