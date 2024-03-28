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
    /// Interaction logic for Activity2.xaml
    /// </summary>
    public partial class Activity2 : Window
    {
        int count = 0;
        int score1;
        int score2 = 0;
        int score3;
        BitmapImage[] imageArray = new BitmapImage[10];
        public Activity2()
        {
            InitializeComponent();
        }

        public Activity2(int a1Score, int a2Score, int a3Score)
        {
            InitializeComponent();
            score1 = a1Score;
            score2 = a2Score;
            score3 = a3Score;
        }
        private void OK2_Click(object sender, RoutedEventArgs e)
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
                mineralwaterimage.Source = imageArray[0];
                {
                    Lscorec.Opacity = 0;
                    OK2.Opacity = 0;
                    submit3.Opacity = 100;
                    Lscorei.Opacity = 0;
                    yay.Opacity = 0;
                }
            }
            if (count == 1)
            {
                mineralwaterimage.Source = imageArray[1];
                {
                    Lscorec.Opacity = 0;
                    OK2.Opacity = 0;
                    submit3.Opacity = 100;
                    Lscorei.Opacity = 0;
                    yay.Opacity = 0;
                }
            }
            if (count == 2)
            {
                mineralwaterimage.Source = imageArray[2];
                {
                    Lscorec.Opacity = 0;
                    OK2.Opacity = 0;
                    submit3.Opacity = 100;
                    Lscorei.Opacity = 0;
                    yay.Opacity = 0;
                }
            }
            if (count == 3)
            {
                mineralwaterimage.Source = imageArray[3];
                {
                    Lscorec.Opacity = 0;
                    OK2.Opacity = 0;
                    submit3.Opacity = 100;
                    Lscorei.Opacity = 0;
                    yay.Opacity = 0;
                }
            }
            if (count == 4)
            {
                mineralwaterimage.Source = imageArray[4];
                {
                    Lscorec.Opacity = 0;
                    OK2.Opacity = 0;
                    submit3.Opacity = 100;
                    Lscorei.Opacity = 0;
                    yay.Opacity = 0;
                }
            }
            if (count == 5)
            {
                mineralwaterimage.Source = imageArray[5];
                {
                    Lscorec.Opacity = 0;
                    OK2.Opacity = 0;
                    submit3.Opacity = 100;
                    Lscorei.Opacity = 0;
                    yay.Opacity = 0;
                }
            }
            if (count == 6)
            {
                mineralwaterimage.Source = imageArray[6];
                {
                    Lscorec.Opacity = 0;
                    OK2.Opacity = 0;
                    submit3.Opacity = 100;
                    Lscorei.Opacity = 0;
                    yay.Opacity = 0;
                }
            }
            if (count == 7)
            {
                mineralwaterimage.Source = imageArray[7];
                {
                    Lscorec.Opacity = 0;
                    OK2.Opacity = 0;
                    submit3.Opacity = 100;
                    Lscorei.Opacity = 0;
                    yay.Opacity = 0;
                }
            }
            if (count == 8)
            {
                mineralwaterimage.Source = imageArray[8];
                {
                    Lscorec.Opacity = 0;
                    OK2.Opacity = 0;
                    submit3.Opacity = 100;
                    Lscorei.Opacity = 0;
                    yay.Opacity = 0;
                }
            }
            if (count == 9)
            {
                mineralwaterimage.Source = imageArray[9];
                {
                    Lscorec.Opacity = 0;
                    OK2.Opacity = 0;
                    submit3.Opacity = 100;
                    Lscorei.Opacity = 0;
                    yay.Opacity = 0;
                }
            }
        }
        private void submit3_Click(object sender, RoutedEventArgs e)
        {
            if (count == 0)
            {
                if (TB_Answer.Text.ToUpper() == "MINERAL WATER")
                {
                    score2++;
                    Console.WriteLine(score2);
                    Lscorec.Opacity = 100;
                    OK2.Opacity = 100;
                    submit3.Opacity = 0;
                    yay.Opacity = 100;
                }

                else
                {
                    Lscorei.Opacity = 100;
                    OK2.Opacity = 100;
                    submit3.Opacity = 0;
                }
            }

            if (count == 1)
            {
                if (TB_Answer.Text.ToUpper() == "BLACK COFFEE")
                {
                    score2++;
                    Console.WriteLine(score2);
                    Lscorec.Opacity = 100;
                    OK2.Opacity = 100;
                    submit3.Opacity = 0;
                    yay.Opacity = 100;
                }

                else
                {
                    Lscorei.Opacity = 100;
                    OK2.Opacity = 100;
                    submit3.Opacity = 0;
                }
            }

            if (count == 2)
            {
                if (TB_Answer.Text.ToUpper() == "TEA WITH LEMON")
                {
                    score2++;
                    Console.WriteLine(score2);
                    Lscorec.Opacity = 100;
                    OK2.Opacity = 100;
                    submit3.Opacity = 0;
                    yay.Opacity = 100;
                }

                else
                {
                    Lscorei.Opacity = 100;
                    OK2.Opacity = 100;
                    submit3.Opacity = 0;
                }
            }

            if (count == 3)
            {
                if (TB_Answer.Text.ToUpper() == "SUGAR")
                {
                    score2++;
                    Console.WriteLine(score2);
                    Lscorec.Opacity = 100;
                    OK2.Opacity = 100;
                    submit3.Opacity = 0;
                    yay.Opacity = 100;
                }

                else
                {
                    Lscorei.Opacity = 100;
                    OK2.Opacity = 100;
                    submit3.Opacity = 0;
                }
            }

            if (count == 4)
            {
                if (TB_Answer.Text.ToUpper() == "MILK")
                {
                    score2++;
                    Console.WriteLine(score2);
                    Lscorec.Opacity = 100;
                    OK2.Opacity = 100;
                    submit3.Opacity = 0;
                    yay.Opacity = 100;
                }

                else
                {
                    Lscorei.Opacity = 100;
                    OK2.Opacity = 100;
                    submit3.Opacity = 0;
                }
            }

            if (count == 5)
            {
                if (TB_Answer.Text.ToUpper() == "SALT")
                {
                    score2++;
                    Console.WriteLine(score2);
                    Lscorec.Opacity = 100;
                    OK2.Opacity = 100;
                    submit3.Opacity = 0;
                    yay.Opacity = 100;
                }

                else
                {
                    Lscorei.Opacity = 100;
                    OK2.Opacity = 100;
                    submit3.Opacity = 0;
                }
            }

            if (count == 6)
            {
                if (TB_Answer.Text.ToUpper() == "PEPPER")
                {
                    score2++;
                    Console.WriteLine(score2);
                    Lscorec.Opacity = 100;
                    OK2.Opacity = 100;
                    submit3.Opacity = 0;
                    yay.Opacity = 100;
                }

                else
                {
                    Lscorei.Opacity = 100;
                    OK2.Opacity = 100;
                    submit3.Opacity = 0;
                }
            }

            if (count == 7)
            {
                if (TB_Answer.Text.ToUpper() == "A TABLE FOR TWO PLEASE")
                {
                    score2++;
                    Console.WriteLine(score2);
                    Lscorec.Opacity = 100;
                    OK2.Opacity = 100;
                    submit3.Opacity = 0;
                    yay.Opacity = 100;
                }

                else
                {
                    Lscorei.Opacity = 100;
                    OK2.Opacity = 100;
                    submit3.Opacity = 0;
                }
            }

            if (count == 8)
            {
                if (TB_Answer.Text.ToUpper() == "HERE IS THE MENU")
                {
                    score2++;
                    Console.WriteLine(score2);
                    Lscorec.Opacity = 100;
                    OK2.Opacity = 100;
                    submit3.Opacity = 0;
                    yay.Opacity = 100;
                }

                else
                {
                    Lscorei.Opacity = 100;
                    OK2.Opacity = 100;
                    submit3.Opacity = 0;
                }
            }

            if (count == 9)
            {
                if (TB_Answer.Text.ToUpper() == "DO YOU WANT TO ORDER?")
                {
                    score2++;
                    Console.WriteLine(score2);
                    Lscorec.Opacity = 100;
                    OK2.Opacity = 0;
                    submit3.Opacity = 0;
                    yay.Opacity = 100;
                }

                else
                {
                    Lscorei.Opacity = 100;
                    OK2.Opacity = 0;
                    submit3.Opacity = 0;
                }
            }
            count++;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            ActivitySelection asel = new ActivitySelection(score1, score2, score3);
            asel.Show();
            Close();
        }
    }
}

