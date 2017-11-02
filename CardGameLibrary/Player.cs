using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameLibrary
{
    public class Player
    {
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        //How can PlayerClass be here?
        public string PlayerClass { get; set; }
    }
}