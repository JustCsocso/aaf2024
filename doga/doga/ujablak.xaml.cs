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

namespace doga
{
    /// <summary>
    /// Interaction logic for ujablak.xaml
    /// </summary>
    public partial class ujablak : Window
    {
        MainWindow szulo;
        public ujablak(MainWindow szulo)
        {
            this.szulo = szulo;
            InitializeComponent();
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int[] szamok = new int[5];

            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i]=rnd.Next(0,100);
                szulo.textBlock2.Text = szamok[i].ToString;
                this.Close();
            }

            
            
        }
    }
}
