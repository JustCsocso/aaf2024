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

namespace doga
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
            ujablak a=new ujablak();
            a.Show();
            /*Random rnd = new Random();
            int[] szamok = new int[5];

            for (int i = 0; i < szamok.Length.; i++)
            {
                int num = rnd.Next(1, 1000);
                intArr[i] = num;
                Console.WriteLine(num);

            }
            */

        }
    }
}