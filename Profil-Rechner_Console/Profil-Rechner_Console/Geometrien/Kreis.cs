using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profil_Rechner_Console.Geometrien
{
    class Kreis:Geometrie
    {
        private double zRadius;

        public Kreis() : this(0, 0) { }

        public Kreis(double pRadius):this(pRadius,0) { }

        public Kreis(double pRadius, double pLaenge):base(pLaenge)
        {
            setRadius(pRadius);
        }

        public override double GetFlaecheninhalt()
        {
            throw new NotImplementedException();
        }

        public override double GetFlachenTraegheit()
        {
            throw new NotImplementedException();
        }

        public override double GetVolumen()
        {
            throw new NotImplementedException();
        }

        public double getRadius()
        {
            throw new NotImplementedException();
        }

        public void setRadius(double pRadius)
        {
            throw new NotImplementedException();
        }


    }
}
