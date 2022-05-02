using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animali.Entities
{
    public class Erbivoro : Animal
    {
        public override string Eat()
        {
            return "L'erbivoro mangia erba e vegetali";
        }
    }
}
