using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameLibrary
{
    public class PlayerCharacter : Player
    {
        public char PName { get; set; }
            //What is PName supposed to do?

        public NormalAttack NormalAttack { get; set; }
        public SpecialAttack SpecialAttack { get; set; }


        //Putting these as no specfication on how to select class was given
        public static void MageSelect(string[] args)
        {
            PlayerCharacter pMage = new PlayerCharacter();
            pMage.CurrentHealth = 50;
            pMage.MaxHealth = 50;
            pMage.PlayerClass = "Mage";
        }

        public static void WarriorSelect(string[] args)
        {
            PlayerCharacter pWarrior = new PlayerCharacter();
            pWarrior.CurrentHealth = 50;
            pWarrior.MaxHealth = 50;
            pWarrior.PlayerClass = "Warrior";
        }

        public static void ThiefSelect(string[] args)
        {
            PlayerCharacter pThief = new PlayerCharacter();
            pThief.CurrentHealth = 50;
            pThief.MaxHealth = 50;
            pThief.PlayerClass = "Thief";
        }

    }
}