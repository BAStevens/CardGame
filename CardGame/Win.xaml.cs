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

namespace CardGame
{
    /// <summary>
    /// Interaction logic for Lose.xaml
    /// </summary>
    public partial class Lose : Window
    {
        private void WinOkay_Click(object sender, RoutedEventArgs e)
        {
            Playfield playfield = new Playfield();
            playfield.Close();
            this.Close();
        }

        private void WinOkay_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
