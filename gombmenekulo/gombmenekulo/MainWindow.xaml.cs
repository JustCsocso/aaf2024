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

namespace gombmenekulo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            Random l = new Random();
            int left=l.Next(0, Convert.ToInt32(Width)-(int)button.Width);
            
            int top=l.Next(0,Convert.ToInt32(Height)-(int)button.Height);

            button.Margin=new Thickness(left,top,0,0);
        }

        string mivoltelobb = "o";


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Button b= (Button)sender;
            if (b.Content == "")
            {
                if (mivoltelobb == "o")
                {
                    b.Foreground=Brushes.Red;
                    b.Content = "x";
                    mivoltelobb = "x";
                }
                else
                {
                    b.Foreground = Brushes.Blue;
                    b.Content = "o";
                    mivoltelobb = "o";
                }
            }
            
            
        }
    }
}