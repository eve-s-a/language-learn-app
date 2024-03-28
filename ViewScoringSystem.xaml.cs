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
    /// Interaction logic for ViewScoringSystem.xaml
    /// </summary>
    public partial class ViewScoringSystem : Window
    {
        string currentD = DateTime.Now.ToShortDateString();
        string currentT = DateTime.Now.ToShortTimeString();

        public ViewScoringSystem()
        {
            InitializeComponent();

        }

        int score1;
        int score2;
        int score3;
        public ViewScoringSystem(int a1Score, int a2Score, int a3Score)
        {
            InitializeComponent();
            score1 = a1Score;
            score2 = a2Score;
            score3 = a3Score;
            LabelScore1.Content = score1;
            LabelScore2.Content = score2;
            LabelScore3.Content = score3;
            todaysdate.Content = currentD + " " + currentT;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Student3rd student3rd = new Student3rd(score1, score2, score3);
            student3rd.Show();
            Close();
        }
    }
}
