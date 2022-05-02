using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animali.Entities
{
    public class Carnivoro : Animal
    {
        public override string Eat()
        {
            return "Il carnivoro mangia carne";
        }
    }
}
