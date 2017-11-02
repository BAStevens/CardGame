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
    /// Interaction logic for Lost.xaml
    /// </summary>
    public partial class Lost : Window
    {
        public Lost()
        {
            InitializeComponent();
        }

        private void LostOkay_Click(object sender, RoutedEventArgs e)
        {
            Playfield playfield = new Playfield();
            playfield.Close();
            this.Close();
        }
    }
}
