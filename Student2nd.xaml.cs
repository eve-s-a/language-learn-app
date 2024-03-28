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
    /// Interaction logic for Student2nd.xaml
    /// </summary>
    public partial class Student2nd : Window
    {
        int score1;
        int score2;
        int score3;
        public Student2nd()
        {
            InitializeComponent();
        }

        public Student2nd(int a1Score, int a2Score, int a3Score)
        {
            InitializeComponent();
            score1 = a1Score;
            score2 = a2Score;
            score3 = a3Score;
        }

        private void n5_Click(object sender, RoutedEventArgs e)
        {
            Student3rd student3rd = new Student3rd(score1, score2, score3);
            student3rd.Show();
            Close();
        }

        private void y5_Click(object sender, RoutedEventArgs e)
        {
            StudentViewProgress studentviewprogress = new StudentViewProgress(score1, score2, score3);
            studentviewprogress.Show();
            Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            ActivitySelection activitySelection = new ActivitySelection(score1, score2, score3);
            activitySelection.Show();
            Close();
        }
    }
}
