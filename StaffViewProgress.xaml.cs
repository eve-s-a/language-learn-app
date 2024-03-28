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
    /// Interaction logic for StaffViewProgress.xaml
    /// </summary>
    public partial class StaffViewProgress : Window
    {
        int score1;
        int score2;
        int score3;
        string studentname;
        public StaffViewProgress()
        {
            InitializeComponent();
        }

        public StaffViewProgress(int a1Score, int a2Score, int a3Score)
        {
            InitializeComponent();
            score1 = a1Score;
            score2 = a2Score;
            score3 = a3Score;
        }

        private void submit1_Click(object sender, RoutedEventArgs e)
        {
            studentname = studentNameBox.Text;
            StaffViewProgressProfile staffViewProgressProfile = new StaffViewProgressProfile(studentname, score1, score2, score3);
            staffViewProgressProfile.Show();
            Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            StaffHome staffHome = new StaffHome(score1, score2, score3);
            staffHome.Show();
            Close();
        }
    }
}
