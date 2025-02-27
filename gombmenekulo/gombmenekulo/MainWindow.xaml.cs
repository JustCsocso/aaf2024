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
        private List<Button> gombok;

        public MainWindow()
        {
            InitializeComponent();

            gombok= new List<Button> { button1,button2,button3,button4,button5,button6,button7,button8,button9};
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

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            foreach(var button in gombok)
            {
                button.Content = "";
            }
            mivoltelobb= "o";
        }
    }
}