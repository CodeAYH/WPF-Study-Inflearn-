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

namespace ch7_Image
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string ImageSource;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void img_MouseEnter(object sender, MouseEventArgs e)
        {
            ImageSource = img.Source.ToString();
            img.Source = new BitmapImage(new Uri("https://cdn0.iconfinder.com/data/icons/artificial-intelligence-49/64/robot_settings_smart_future_tech-256.png"));
        }

        private void img_MouseLeave(object sender, MouseEventArgs e)
        {
            img.Source = new BitmapImage(new Uri(ImageSource));
        }
    }
}