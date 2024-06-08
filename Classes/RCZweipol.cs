using System.IO;
using System.Xml.Linq;


namespace RCZweipol
{
    using Kondensator;
    internal class RCZweipol
    {
        // fields
        double resistance;
        Kondensator ko;

        public double Resistance { get => resistance; set => resistance = value; }
        public Kondensator Capacitor { get => ko; set => ko = value; } //internal accessor for encapsulation? 

        public RCZweipol()
        {
            this.Capacitor = new Kondensator(); // Initialize Capacitor to avoid null reference
        }
        public RCZweipol(double r, double c, string bf)
        {
            this.Capacitor = new Kondensator(c, bf); // Initialize Capacitor with parameters
            this.Resistance = r;
        }

    }
}
   
