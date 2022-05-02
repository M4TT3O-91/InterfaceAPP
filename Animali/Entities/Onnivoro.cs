using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animali.Entities
{
    public class Onnivoro : Animal
    {
        public override string Eat()
        {
            return "L'onnivoro mangia sia carne che vegetali";
        }
    }
}
