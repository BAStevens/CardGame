using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameLibrary
{
    //Cant inherit from attack. class missing
    public class NormalAttack
    {
        public int DealNDamage { get; set; }

        public int TakeDamage()
        {
            throw new NotImplementedException();
        }
    }
}