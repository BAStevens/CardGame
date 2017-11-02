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


        public NormalAttack TakeDamage { get; set; }
    }
}