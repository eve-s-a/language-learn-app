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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Newproject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int score1;
        int score2;
        int score3;
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(int a1Score, int a2Score, int a3Score)
        {
            InitializeComponent();
            score1 = a1Score;
            score2 = a2Score;
            score3 = a3Score;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StaffHome staffHome = new StaffHome(score1, score2, score3);
            staffHome.Show();
            Close();
        }

        private void y1_Click(object sender, RoutedEventArgs e)
        {
            LanguageSelection languageSelection = new LanguageSelection(score1, score2, score3);
            languageSelection.Show();
            Close();
        }
    }
}
