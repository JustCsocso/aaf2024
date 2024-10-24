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

namespace gyakorlas1024
{
    /// <summary>
    /// Interaction logic for ablak2.xaml
    /// </summary>
    public partial class ablak2 : Window
    {
        MainWindow szulo1;
        public ablak2(MainWindow szulo1)

        {
            this.szulo1 = szulo1;
            
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string szoveg = textBox.Text;
            szulo1.textBlock.Text =szoveg ;
            this.Close();
        }
    }
}
