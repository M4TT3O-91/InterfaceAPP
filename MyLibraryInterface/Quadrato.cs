using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryInterface
{
    public class Quadrato : IPoligono
    {
        private double Lato;
        public Quadrato(double lato)
        {
            Lato = lato;
        }
        public double Perimetro() => Lato * 4;
        public string chiSono()
        {
            return $"Sono un quadrato con il lato di {Lato}";
        }
        
    }
}
