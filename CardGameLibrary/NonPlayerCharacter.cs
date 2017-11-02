using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameLibrary
{
    public class NonPlayerCharacter : Player
    {
        public char EnemyType { get; set; }

        //Putting these as no specfication on how enemy type was generated
        public static void Mouse(string[] args)
        {
            NonPlayerCharacter mouse = new NonPlayerCharacter();
            mouse.CurrentHealth = 50;
            mouse.MaxHealth = 50;
            //mouse.TakeDamage = 15;
        }

        public static void Dog(string[] args)
        {
            NonPlayerCharacter dog = new NonPlayerCharacter();
            dog.CurrentHealth = 100;
            dog.MaxHealth = 100;
            //dog.TakeDamage = 20;
        }

        public static void cat(string[] args)
        {
            NonPlayerCharacter cat = new NonPlayerCharacter();
            cat.CurrentHealth = 90;
            cat.MaxHealth = 90;
            //cat.TakeDamage = 25;
        }

        public NormalAttack TakeDamage { get; set; }
    }
}