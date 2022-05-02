using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryInterface
{
    public class Rettangolo : IPoligono
    {
        private double LatoMag;
        private double LatoMin;

        public Rettangolo(double latoMag, double lonMin)
        {
            LatoMag = latoMag;
            LatoMin = lonMin;
        }

        public double Perimetro() => LatoMag * 2 + LatoMin * 2;

    }
}
