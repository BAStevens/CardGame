using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameLibrary
{
    public class SpecialAttack
    {
        public double Chance { get; set; }
        public int DealDamage { get; set; }
        public double IncreaseDamage { get; set; }
        public bool SuccessChance { get; set; }


        public double SAttackFail()
        {
            throw new NotImplementedException();
        }
        public double SAttackSuccess()
        {
            throw new NotImplementedException();
        }
    }   
}