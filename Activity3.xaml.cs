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
    /// Interaction logic for Activity3.xaml
    /// </summary>
    public partial class Activity3 : Window
    {
        int count = 0;
        int score1;
        int score2;
        int score3 = 0;
        BitmapImage[] imageArray = new BitmapImage[10];

        public Activity3()
        {
            InitializeComponent();
        }

        public Activity3(int a1Score, int a2Score, int a3Score)
        {
            InitializeComponent();
            score1 = a1Score;
            score2 = a2Score;
            score3 = a3Score;
        }

        private void bo1_Click(object sender, RoutedEventArgs e)
        {
            if(count == 0)
            {
                Lscorec.Opacity = 100;
                OK1.Opacity = 100;
                yay.Opacity = 100;
                score3++;
            }

            if (count == 1)
            {
                Lscorei.Opacity = 100;
                OK1.Opacity = 100;
            }

            if (count == 2)
            {
                Lscorei.Opacity = 100;
                OK1.Opacity = 100;
            }

            if (count == 3)
            {
                Lscorei.Opacity = 100;
                OK1.Opacity = 100;
            }

            if (count == 4)
            {
                Lscorei.Opacity = 100;
                OK1.Opacity = 100;
            }

            if (count == 5)
            {
                Lscorec.Opacity = 100;
                OK1.Opacity = 100;
                yay.Opacity = 100;
                score3++;
            }

            if (count == 6)
            {
                Lscorei.Opacity = 100;
                OK1.Opacity = 100;
            }

            if (count == 7)
            {
                Lscorei.Opacity = 100;
                OK1.Opacity = 100;
            }

            if (count == 8)
            {
                Lscorei.Opacity = 100;
                OK1.Opacity = 100;
            }

            if (count == 9)
            {
                Lscorei.Opacity = 100;
                OK1.Opacity = 0;
            }
            count++;
        }

        private void bo2_Click(object sender, RoutedEventArgs e)
        {
            if(count == 0)
            {
                Lscorei.Opacity = 100;
                OK1.Opacity = 100;
            }

            if (count == 1)
            {
                Lscorei.Opacity = 100;
                OK1.Opacity = 100;
            }

            if (count == 2)
            {
                Console.WriteLine(score3);
                Lscorec.Opacity = 100;
                OK1.Opacity = 100;
                yay.Opacity = 100;
                score3++;
            }

            if (count == 3)
            {
                Lscorei.Opacity = 100;
                OK1.Opacity = 100;
            }

            if (count == 4)
            {
                Lscorei.Opacity = 100;
                OK1.Opacity = 100;
            }

            if (count == 5)
            {
                Lscorei.Opacity = 100;
                OK1.Opacity = 100;
            }

            if (count == 6)
            {
                Lscorei.Opacity = 100;
                OK1.Opacity = 100;
            }

            if (count == 7)
            {
                Console.WriteLine(score3);
                Lscorec.Opacity = 100;
                OK1.Opacity = 100;
                yay.Opacity = 100;
                score3++;
            }

            if (count == 8)
            {
                Console.WriteLine(score3);
                Lscorec.Opacity = 100;
                OK1.Opacity = 100;
                yay.Opacity = 100;
                score3++;
            }

            if (count == 9)
            {
                Console.WriteLine(score3);
                Lscorec.Opacity = 100;
                OK1.Opacity = 0;
                yay.Opacity = 100;
                score3++;
            }
            count++;
        }

        private void bo3_Click(object sender, RoutedEventArgs e)
        {
            if(count == 0)
            {
                Lscorei.Opacity = 100;
                OK1.Opacity = 100;
            }

            if (count == 1)
            {
                Console.WriteLine(score3);
                Lscorec.Opacity = 100;
                OK1.Opacity = 100;
                yay.Opacity = 100;
                score3++;
            }

            if (count == 2)
            {
                Console.WriteLine(score3);
                Lscorec.Opacity = 100;
                OK1.Opacity = 100;
                yay.Opacity = 100;
                score3++;
            }

            if (count == 3)
            {
                Console.WriteLine(score3);
                Lscorec.Opacity = 100;
                OK1.Opacity = 100;
                yay.Opacity = 100;
                score3++;
            }

            if (count == 4)
            {
                Console.WriteLine(score3);
                Lscorec.Opacity = 100;
                OK1.Opacity = 100;
                yay.Opacity = 100;
                score3++;
            }

            if (count == 5)
            {
                Lscorei.Opacity = 100;
                OK1.Opacity = 100;
            }

            if (count == 6)
            {
                Console.WriteLine(score3);
                Lscorec.Opacity = 100;
                OK1.Opacity = 100;
                yay.Opacity = 100;
                score3++;
            }

            if (count == 7)
            {
                Lscorei.Opacity = 100;
                OK1.Opacity = 100;
            }

            if (count == 8)
            {
                Lscorei.Opacity = 100;
                OK1.Opacity = 100;
            }

            if (count == 9)
            {
                Lscorei.Opacity = 100;
                OK1.Opacity = 0;
            }
            count++;
        }

        private void OK1_Click(object sender, RoutedEventArgs e)
        {
            imageArray[0] = new BitmapImage(new Uri("/Newproject;component/NewFolder1/mineralwater.jpg", UriKind.Relative));
            imageArray[1] = new BitmapImage(new Uri("/Newproject;component/NewFolder1/ablackcoffee.jpg", UriKind.Relative));
            imageArray[2] = new BitmapImage(new Uri("/Newproject;component/NewFolder1/teawithlemon.jpg", UriKind.Relative));
            imageArray[3] = new BitmapImage(new Uri("/Newproject;component/NewFolder1/sugar.jpg", UriKind.Relative));
            imageArray[4] = new BitmapImage(new Uri("/Newproject;component/NewFolder1/milk.jpg", UriKind.Relative));
            imageArray[5] = new BitmapImage(new Uri("/Newproject;component/NewFolder1/salt.jpg", UriKind.Relative));
            imageArray[6] = new BitmapImage(new Uri("/Newproject;component/NewFolder1/pepper.jpg", UriKind.Relative));
            imageArray[7] = new BitmapImage(new Uri("/Newproject;component/NewFolder1/atablefortwoplease.jpg", UriKind.Relative));
            imageArray[8] = new BitmapImage(new Uri("/Newproject;component/NewFolder1/hereisthemenu.jpg", UriKind.Relative));
            imageArray[9] = new BitmapImage(new Uri("/Newproject;component/NewFolder1/doyouwanttoorder.jpg", UriKind.Relative));

            if (count == 0)
            {
                word3.Content = "do you want to order?";
                Lscorec.Opacity = 0;
                Lscorei.Opacity = 0;
                OK1.Opacity = 0;
                yay.Opacity = 0;
                bi1.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/hereisthemenu.jpg", UriKind.Relative));
                bi2.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/atablefortwoplease.jpg", UriKind.Relative));
                bi3.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/doyouwanttoorder.jpg", UriKind.Relative));
            }

            if (count == 1)
            {
                word3.Content = "a black coffee";
                Lscorec.Opacity = 0;
                Lscorei.Opacity = 0;
                OK1.Opacity = 0;
                yay.Opacity = 0;
                bi1.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/pepper.jpg", UriKind.Relative));
                bi2.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/mineralwater.jpg", UriKind.Relative));
                bi3.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/ablackcoffee.jpg", UriKind.Relative));
            }

            if (count == 2)
            {
                word3.Content = "here is the menu";
                Lscorec.Opacity = 0;
                Lscorei.Opacity = 0;
                OK1.Opacity = 0;
                yay.Opacity = 0;
                bi1.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/atablefortwoplease.jpg", UriKind.Relative));
                bi2.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/hereisthemenu.jpg", UriKind.Relative));
                bi3.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/teawithlemon.jpg", UriKind.Relative));
            }

            if (count == 3)
            {
                word3.Content = "tea with lemon";
                Lscorec.Opacity = 0;
                Lscorei.Opacity = 0;
                OK1.Opacity = 0;
                yay.Opacity = 0;
                bi1.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/ablackcoffee.jpg", UriKind.Relative));
                bi2.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/sugar.jpg", UriKind.Relative));
                bi3.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/teawithlemon.jpg", UriKind.Relative));
            }

            if (count == 4)
            {
                word3.Content = "a table for two please";
                Lscorec.Opacity = 0;
                Lscorei.Opacity = 0;
                OK1.Opacity = 0;
                yay.Opacity = 0;
                bi1.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/salt.jpg", UriKind.Relative));
                bi2.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/doyouwanttoorder.jpg", UriKind.Relative));
                bi3.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/atablefortwoplease.jpg", UriKind.Relative));
            }

            if (count == 5)
            {
                word3.Content = "sugar";
                Lscorec.Opacity = 0;
                Lscorei.Opacity = 0;
                OK1.Opacity = 0;
                yay.Opacity = 0;
                bi1.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/sugar.jpg", UriKind.Relative));
                bi2.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/salt.jpg", UriKind.Relative));
                bi3.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/ablackcoffee.jpg", UriKind.Relative));
            }

            if (count == 6)
            {
                word3.Content = "pepper";
                Lscorec.Opacity = 0;
                Lscorei.Opacity = 0;
                OK1.Opacity = 0;
                yay.Opacity = 0;
                bi1.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/hereisthemenu.jpg", UriKind.Relative));
                bi2.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/mineralwater.jpg", UriKind.Relative));
                bi3.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/pepper.jpg", UriKind.Relative));
            }

            if (count == 7)
            {
                word3.Content = "milk";
                Lscorec.Opacity = 0;
                Lscorei.Opacity = 0;
                OK1.Opacity = 0;
                yay.Opacity = 0;
                bi1.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/sugar.jpg", UriKind.Relative));
                bi2.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/milk.jpg", UriKind.Relative));
                bi3.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/atablefortwoplease.jpg", UriKind.Relative));
            }

            if (count == 8)
            {
                word3.Content = "salt";
                Lscorec.Opacity = 0;
                Lscorei.Opacity = 0;
                OK1.Opacity = 0;
                yay.Opacity = 0;
                bi1.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/doyouwanttoorder.jpg", UriKind.Relative));
                bi2.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/salt.jpg", UriKind.Relative));
                bi3.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/mineralwater.jpg", UriKind.Relative));
            }
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            Countdown(60, TimeSpan.FromSeconds(1), Cursor => Timer.Text = Cursor.ToString());
        }
        void Countdown(int count, TimeSpan interval, Action<int> ts)
        {
            var dt = new System.Windows.Threading.DispatcherTimer();
            dt.Interval = interval;
            dt.Tick += (_, a) =>
            {
                if (count-- == 0)
                {
                    dt.Stop();
                    Student2nd student2nd = new Student2nd();
                    student2nd.Show();
                    Close();

                }

                else
                { ts(count); }
            };
            ts(count);
            dt.Start();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            ActivitySelection asel = new ActivitySelection(score1, score2, score3);
            asel.Show();
            Close();
        }
    }
}
