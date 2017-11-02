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


        public NormalAttack NormalAttack { get; set; }
        public SpecialAttack SpecialAttack { get; set; }
    }
}