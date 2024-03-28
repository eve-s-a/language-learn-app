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
    /// Interaction logic for ViewUsageDataProfile.xaml
    /// </summary>
    public partial class ViewUsageDataProfile : Window
    {
        string currentD = DateTime.Now.ToShortDateString();
        string currentT = DateTime.Now.ToShortTimeString();
        int score1;
        int score2;
        int score3;
        public ViewUsageDataProfile(string sn, int a1Score, int a2Score, int a3Score)
        {
            InitializeComponent();

            todaysdate.Content = currentD + " " + currentT;
            column1heading.Content = currentD;
            studentNameLabel.Content = sn;
            score1 = a1Score;
            score2 = a2Score;
            score3 = a3Score;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            ViewUsageData viewUsageData = new ViewUsageData(score1, score2, score3);
            viewUsageData.Show();
            Close();
        }
    }
}
