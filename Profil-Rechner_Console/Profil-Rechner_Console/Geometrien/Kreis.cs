﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profil_Rechner_Console.Geometrien
{
    class Kreis:Geometrie
    {
        protected double zRadius;

        public Kreis():base()
        {
            zRadius = 0;
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


    }
}