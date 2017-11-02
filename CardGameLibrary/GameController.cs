using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameLibrary
{
    public class GameController
    {
        public NonPlayerCharacter Enemy { get; set; }
        public PlayerCharacter Player { get; set; }
        public char ChoosePlayerClass { get; set; }
            //Why is ChoosePlayerClass a Char? Shouldn't it be a string?
        public char GameWinner { get; set; }

        public void NormalAttack()
        {
            NormalAttack normalAttack = new NormalAttack();
        }

        public void SpecialAttack()
        {
            SpecialAttack specialAttack = new SpecialAttack();
        }

        public void StartBattle()
        {
            throw new NotImplementedException();
            //Playfield playfield = new Playfield();
            //this.Close();
            //playfield.Show();
        }
    }
}