using System;

namespace Profil_Rechner_GUI
{
    public class ConsistencyException : Exception
    {
        public ConsistencyException() : base() { }
        public ConsistencyException(string text):base(text) { }
    }
}
