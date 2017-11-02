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
using CardGameLibrary;


namespace CardGame
{
    /// <summary>
    /// Interaction logic for Playfield.xaml
    /// </summary>
    /// 
    public partial class Playfield : Window
    {
        public GameController GameController { get; set; }

        public Playfield()
        {
            InitializeComponent();
        }

        public void btnNormalAttack_Click(object sender, RoutedEventArgs e)
        {
            GameController.NormalAttack();
        }

        private void btnSpecialAttack_Click(object sender, RoutedEventArgs e)
        {
            GameController.SpecialAttack();
        }
    }
}