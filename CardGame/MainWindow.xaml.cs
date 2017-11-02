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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CardGameLibrary;

namespace CardGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public GameController GameController { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Fight_Click(object sender, RoutedEventArgs e)
        {
            GameController.NormalAttack();
        }

        void PlayerClassThief_Click(object sender, RoutedEventArgs e)
        {
            GameController.ChoosePlayerClass.
            GameController.StartBattle();
            this.Close();
            Playfield playfield = new Playfield;
            playfield.Show();
        }

        private void PlayerClassMage_Click(object sender, RoutedEventArgs e)
        {
            //GameController.ChoosePlayerClass("T");
            GameController.StartBattle();
            this.Close();
            Playfield playfield = new Playfield;
            playfield.Show();
        }

        private void PlayerClassWarrior_Click(object sender, RoutedEventArgs e)
        {
            //GameController.ChoosePlayerClass("T");
            GameController.StartBattle();
            this.Close();
            Playfield playfield = new Playfield;
            playfield.Show();
        }
    }
}