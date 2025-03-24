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

namespace SzinuszGorbe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Sline Curve and the Unit Curve

            //1:koordinata rendszer
            //2:kor
            //3:fekete pont
            //4:sugár
            //5:magasság(piros)
            //6:szinusz gorbe
            //7:körív(nagy)
            //8:köriv(kicsi)
            //9:adattábla(szög+egyebek)
        }   

        private void Canvas_Loaded(object sender, RoutedEventArgs e)
        {
            koordinataRajzol();
        }
        int r = 100;

        void koordinataRajzol()
        {
            Line xTengely= new Line();
            xTengely.Stroke = Brushes.Black;
            xTengely.X1 = 0;
            xTengely.Y1 = Height/2;
            xTengely.X2=Width;
            xTengely.Y2=Height/2;

            canvas.Children.Add(xTengely);
            
            Line yTengely = new Line();
            yTengely.Stroke = Brushes.Black;
            yTengely.X1 = r*1.1;
            yTengely.Y1 = 0;
            yTengely.X2 = r * 1.1;
            yTengely.Y2 = Height;

            canvas.Children.Add(yTengely);
        }
    }
}