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
    /// Interaction logic for Activity1.xaml
    /// </summary>
    public partial class Activity1 : Window
    {
        int count = 0;
        int score1 = 0;
        int score2;
        int score3;
        BitmapImage[] imageArray = new BitmapImage[10];
        bool isFinished = false;
        public Activity1()
        {
            InitializeComponent();
        }


        public Activity1(int a1Score, int a2Score, int a3Score)
        {
            InitializeComponent();
            score1 = a1Score;
            score2 = a2Score;
            score3 = a3Score;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
      //      StudentViewProgress studentViewProgress = new StudentViewProgress(score1, score2, score3);
       //     ActivitySelection activitySelection = new ActivitySelection();
       //     activitySelection.Show();
        //    Close();
        }

        private void bo1_Click(object sender, RoutedEventArgs e)
        {
            if (count == 0)
            {
                Lscorec.Opacity = 100;
                OK1.Opacity = 100;
                yay.Opacity = 100;
                score1++;
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
                score1++;
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
            if (count == 0)
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
                Console.WriteLine(score1);
                Lscorec.Opacity = 100;
                OK1.Opacity = 100;
                yay.Opacity = 100;
                score1++;
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
                Console.WriteLine(score1);
                Lscorec.Opacity = 100;
                OK1.Opacity = 100;
                yay.Opacity = 100;
                score1++;
            }

            if (count == 8)
            {
                Console.WriteLine(score1);
                Lscorec.Opacity = 100;
                OK1.Opacity = 100;
                yay.Opacity = 100;
                score1++;
            }

            if (count == 9)
            {
                Console.WriteLine(score1);
                Lscorec.Opacity = 100;
                OK1.Opacity = 0;
                yay.Opacity = 100;
                score1++;
            }
            count++;
        }

        private void bo3_Click(object sender, RoutedEventArgs e)
        {
            if (count == 0)
            {
                Lscorei.Opacity = 100;
                OK1.Opacity = 100;
            }

            if (count == 1)
            {
                Console.WriteLine(score1);
                Lscorec.Opacity = 100;
                OK1.Opacity = 100;
                yay.Opacity = 100;
                score1++;
            }

            if (count == 2)
            {
                Console.WriteLine(score1);
                Lscorec.Opacity = 100;
                OK1.Opacity = 100;
                yay.Opacity = 100;
                score1++;
            }

            if (count == 3)
            {
                Console.WriteLine(score1);
                Lscorec.Opacity = 100;
                OK1.Opacity = 100;
                yay.Opacity = 100;
                score1++;
            }

            if (count == 4)
            {
                Console.WriteLine(score1);
                Lscorec.Opacity = 100;
                OK1.Opacity = 100;
                yay.Opacity = 100;
                score1++;
            }

            if (count == 5)
            {
                Lscorei.Opacity = 100;
                OK1.Opacity = 100;
            }

            if (count == 6)
            {
                Console.WriteLine(score1);
                Lscorec.Opacity = 100;
                OK1.Opacity = 100;
                yay.Opacity = 100;
                score1++;
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
                imagemix.Source = imageArray[9];
                Lscorec.Opacity = 0;
                Lscorei.Opacity = 0;
                OK1.Opacity = 0;
                yay.Opacity = 0;
                bi1.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/hereisthemenutext.png", UriKind.Relative));
                bi2.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/atablefortwopleasetext.png", UriKind.Relative));
                bi3.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/doyouwanttoordertext.png", UriKind.Relative));
            }

            else if (count == 1)
            {
                imagemix.Source = imageArray[1];
                Lscorec.Opacity = 0;
                Lscorei.Opacity = 0;
                OK1.Opacity = 0;
                yay.Opacity = 0;
                bi1.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/peppertext.png", UriKind.Relative));
                bi2.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/mineralwatertext.png", UriKind.Relative));
                bi3.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/ablackcoffeetext.png", UriKind.Relative));
            }

            else if (count == 2)
            {
                imagemix.Source = imageArray[8];
                Lscorec.Opacity = 0;
                Lscorei.Opacity = 0;
                OK1.Opacity = 0;
                yay.Opacity = 0;
                bi1.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/atablefortwopleasetext.png", UriKind.Relative));
                bi2.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/hereisthemenutext.png", UriKind.Relative));
                bi3.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/teawithlemontext.png", UriKind.Relative));
            }

            else if (count == 3)
            {
                imagemix.Source = imageArray[2];
                Lscorec.Opacity = 0;
                Lscorei.Opacity = 0;
                OK1.Opacity = 0;
                yay.Opacity = 0;
                bi1.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/ablackcoffeetext.png", UriKind.Relative));
                bi2.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/sugartext.png", UriKind.Relative));
                bi3.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/teawithlemontext.png", UriKind.Relative));
            }

            else if (count == 4)
            {
                imagemix.Source = imageArray[7];
                Lscorec.Opacity = 0;
                Lscorei.Opacity = 0;
                OK1.Opacity = 0;
                yay.Opacity = 0;
                bi1.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/salttext.png", UriKind.Relative));
                bi2.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/doyouwanttoordertext.png", UriKind.Relative));
                bi3.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/atablefortwopleasetext.png", UriKind.Relative));
            }

            else if (count == 5)
            {
                imagemix.Source = imageArray[3];
                Lscorec.Opacity = 0;
                Lscorei.Opacity = 0;
                OK1.Opacity = 0;
                yay.Opacity = 0;
                bi1.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/sugartext.png", UriKind.Relative));
                bi2.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/salttext.png", UriKind.Relative));
                bi3.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/ablackcoffeetext.png", UriKind.Relative));
            }

            else if (count == 6)
            {
                imagemix.Source = imageArray[6];
                Lscorec.Opacity = 0;
                Lscorei.Opacity = 0;
                OK1.Opacity = 0;
                yay.Opacity = 0;
                bi1.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/hereisthemenutext.png", UriKind.Relative));
                bi2.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/mineralwatertext.png", UriKind.Relative));
                bi3.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/peppertext.png", UriKind.Relative));
            }

            else if (count == 7)
            {
                imagemix.Source = imageArray[4];
                Lscorec.Opacity = 0;
                Lscorei.Opacity = 0;
                OK1.Opacity = 0;
                yay.Opacity = 0;
                bi1.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/sugartext.png", UriKind.Relative));
                bi2.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/milktext.png", UriKind.Relative));
                bi3.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/atablefortwopleasetext.png", UriKind.Relative));
            }

            else if (count == 8)
            {
                imagemix.Source = imageArray[5];
                Lscorec.Opacity = 0;
                Lscorei.Opacity = 0;
                OK1.Opacity = 0;
                yay.Opacity = 0;
                bi1.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/doyouwanttoordertext.png", UriKind.Relative));
                bi2.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/salttext.png", UriKind.Relative));
                bi3.Source = new BitmapImage(new Uri("/Newproject;component/NewFolder1/mineralwatertext.png", UriKind.Relative));
                isFinished = true;
            }
            else if(isFinished == true)
            {
                ActivitySelection asel = new ActivitySelection(score1, score2, score3);
                asel.Show();
                Close();
            }
        }
    }
}
