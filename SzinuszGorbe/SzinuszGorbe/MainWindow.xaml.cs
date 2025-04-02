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
<<<<<<< HEAD
            origoY = Convert.ToInt32(Height / 2);
            origoX = Convert.ToInt32(r * 1.1);

            koordinataRajzol();
            for(int i = 0; i <= 60; i += 45)
            {
                kor(0);
                sugar(0);
            }
            pirosVonal(50);
            pont(50);

        }
        int r = 100;
=======
            origoX = Convert.ToInt32(r * 1.1);
            origoY = Convert.ToInt32(Height/2);
            koordinataRajzol();
            for (int i = 0; i < 360; i += 90)
            {
                
                kor(i);
                sugar(i);
            }
            
            
        }
        int r = 100; 
        
>>>>>>> 35460401daa8bf442ff30f2da14eff1d226eed5f
        int origoY = 0;
        int origoX = 0;

        void koordinataRajzol()
        {
<<<<<<< HEAD
             

            Line xTengely= new Line();
            xTengely.Stroke = Brushes.Black;
            xTengely.X1 = 0;
            xTengely.Y1 = origoY;
            xTengely.X2=Width;
            xTengely.Y2=origoY;
=======
            Line xTengely = new Line();
            xTengely.Stroke = Brushes.Black;
            xTengely.X1 = 0;
            xTengely.Y1 = origoY;
            xTengely.X2 = Width;
            xTengely.Y2 = origoY;


>>>>>>> 35460401daa8bf442ff30f2da14eff1d226eed5f

            Line yTengely = new Line();
            yTengely.Stroke = Brushes.Black;
<<<<<<< HEAD
            yTengely.X1 =origoX;
=======
            yTengely.X1 = r * 1.1;
>>>>>>> 35460401daa8bf442ff30f2da14eff1d226eed5f
            yTengely.Y1 = 0;
            yTengely.X2 = r * 1.1;
            yTengely.Y2 = Height;


            canvas.Children.Add(xTengely);
            canvas.Children.Add(yTengely);

<<<<<<< HEAD
            for (int i = 0; i < 5; i++) 
            {
                Line vonalka= new Line();
                vonalka.Stroke = Brushes.Black;
                vonalka.X1 = i * 90 + yTengely.X1;
                vonalka.Y1=origoY-5;
                vonalka.X2 = i * 90 + yTengely.X1;
                vonalka.Y2 = origoY+5;

=======
            for (int i = 0; i < 5; i++)
            {
                Line vonalka = new Line();
                vonalka.Stroke = Brushes.Black;
                vonalka.X1 = i * 90 + yTengely.X1;
                vonalka.Y1 = origoY - 5;
                vonalka.X2 = i * 90 + yTengely.X1;
                vonalka.Y2 = origoY + 5;
>>>>>>> 35460401daa8bf442ff30f2da14eff1d226eed5f
                canvas.Children.Add(vonalka);
            }

            for (int i = 0; i < 5; i++)
            {
                Line vonalka = new Line();
                vonalka.Stroke = Brushes.Black;
<<<<<<< HEAD
                vonalka.X1 = yTengely.X1-5;
                vonalka.Y1 = i*90+(xTengely.Y1-180);
                vonalka.X2 = yTengely.X1+5;
                vonalka.Y2 = i * 90+(xTengely.Y2-180);

                canvas.Children.Add(vonalka);
            }
           
        }

        int korX = 0;
        int korY = 0;

        void kor(int x)
        {
            Ellipse kor= new Ellipse();
            kor.Stroke = Brushes.Blue;
            kor.Width = 2 * r;
            kor.Height=2*r;
            kor.Margin = new Thickness(x -r ,origoY -r ,0,0);

            korX = Convert.ToInt32(x - r + origoX);
            korY = Convert.ToInt32(origoY);
            
            canvas.Children.Add(kor);
        }

        void sugar(int x)
        {
            Line sugar = new Line();
            sugar.Stroke = Brushes.Black;
            sugar.StrokeThickness = 5;
            sugar.X1 = korX;
            sugar.Y1 = korY;
            sugar.X2 = x + origoX;
            sugar.Y2 = Math.Sin(x / 180.0 * Math.PI) * r + origoY;

            canvas.Children.Add(sugar);
        }
        void pont(int x)
        {
            Ellipse pont= new Ellipse();
            pont.Stroke = Brushes.Black;
            pont.Height = r * .1;
            pont.Width = r * .1;
            pont.Margin = new Thickness(origoX-pont.Width/2+x,origoY-pont.Height/2,0,0);
            pont.Fill = Brushes.Black;

            canvas.Children.Add(pont);
        }

        void pirosVonal(int x)
        {
            int magassag=(int)(Math.Sin(x/180.0*Math.PI)*r);

            Line vonal=new Line();
            vonal.Stroke = Brushes.Red;
            vonal.StrokeThickness = 3;
            vonal.X1 = x + origoX;
            vonal.Y1 = origoY;
            vonal.X2=x + origoX-magassag;
            vonal.Y2=origoY-magassag*r;

            canvas.Children.Add(vonal);
=======
                vonalka.X1 = yTengely.X1 - 5;
                vonalka.Y1 = i * 90 + (xTengely.Y1 - 180);
                vonalka.X2 = yTengely.X1 + 5;
                vonalka.Y2 = i * 90 + (xTengely.Y1 - 180);
                canvas.Children.Add(vonalka);
            }
>>>>>>> 35460401daa8bf442ff30f2da14eff1d226eed5f
        }
        int korX = 0;
        int korY = 0;
        void kor(int x)
        {
            Ellipse kor = new Ellipse();
            kor.Stroke = Brushes.Blue;
            kor.Height = 2 * r;
            kor.Width = 2 * r;
            kor.Margin = new Thickness(x - r, origoY - r, 0, 0);

            canvas.Children.Add(kor);

            korX = x - r + origoX;
            korY = origoY;
        }

        void sugar(int x) 
        { 
            Line sugar= new Line();
            sugar.Stroke = Brushes.Black;
            sugar.X1 = korX;
            sugar.Y1 = korY;
            sugar.X2 = x+origoX;
            sugar.Y2 = Math.Sin(x/180.0*Math.PI)*r+origoY;
            sugar.StrokeThickness = 5;

            canvas.Children.Add(sugar);
        }

    }
}
  