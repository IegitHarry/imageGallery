using System.Linq.Expressions;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int imageId = 1;
        int img1likes = 0;
        int img2likes = 0;
        int img3likes = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void likeClick(object sender, RoutedEventArgs e)
        {
            switch (imageId)
            {
                case 1:
                    img1likes++;
                    likesStrip.Text = "Likes: " + img1likes;
                    break;
                case 2:
                    img2likes++;
                    likesStrip.Text = "Likes: " + img2likes;
                    break;
                case 3:
                    img3likes++;
                    likesStrip.Text = "Likes: " + img3likes;
                    break;
                default:
                    likesStrip.Text = "Likes: " + img1likes;
                    break;
            }
        }

        private void leftNextClick(object sender, RoutedEventArgs e)
        {
            imageId--;
            if (imageId < 1) {
                imageId = 3;
            }
            switch (imageId)
            {
                case 1:
                    img1.Visibility = Visibility.Visible;
                    img2.Visibility = Visibility.Hidden;
                    img3.Visibility = Visibility.Hidden;
                    likesStrip.Text = "Likes: " + img1likes;
                    break;
                case 2:
                    img1.Visibility = Visibility.Hidden;
                    img2.Visibility = Visibility.Visible;
                    img3.Visibility = Visibility.Hidden;
                    likesStrip.Text = "Likes: " + img2likes;
                    break;
                case 3:
                    img1.Visibility = Visibility.Hidden;
                    img2.Visibility = Visibility.Hidden;
                    img3.Visibility = Visibility.Visible;
                    likesStrip.Text = "Likes: " + img3likes;
                    break;
                default:
                    img1.Visibility = Visibility.Visible;
                    img2.Visibility = Visibility.Hidden;
                    img3.Visibility = Visibility.Hidden;
                    likesStrip.Text = "Likes: " + img1likes;
                    break;
            }
        }

        private void rightNextClick(object sender, RoutedEventArgs e)
        {
            imageId++;
            if (imageId > 3)
            {
                imageId = 1;
            }
            switch (imageId)
            {
                case 1:
                    img1.Visibility = Visibility.Visible;
                    img2.Visibility = Visibility.Hidden;
                    img3.Visibility = Visibility.Hidden;
                    likesStrip.Text = "Likes: " + img1likes;
                    break;
                case 2:
                    img1.Visibility = Visibility.Hidden;
                    img2.Visibility = Visibility.Visible;
                    img3.Visibility = Visibility.Hidden;
                    likesStrip.Text = "Likes: " + img2likes;
                    break;
                case 3:
                    img1.Visibility = Visibility.Hidden;
                    img2.Visibility = Visibility.Hidden;
                    img3.Visibility = Visibility.Visible;
                    likesStrip.Text = "Likes: " + img3likes;
                    break;
                default:
                    img1.Visibility = Visibility.Visible;
                    img2.Visibility = Visibility.Hidden;
                    img3.Visibility = Visibility.Hidden;
                    likesStrip.Text = "Likes: " + img1likes;
                    break;
            }
        }

        private void likesCounter(object sender, TextChangedEventArgs e)
        {

        }
    }
}