using System;

namespace ParallelRCZweipol
{
    using RCZweipol;
    class Parallel : RCZweipol
    {

        private double f;

        // properties
        public double Frequency
        {
            get { return f; }
            set
            {
                if (value <=0) { throw new ArgumentException("Frequency must be greater 0!"); }
                f = value;
            }
        }

        public Parallel():base() { }
        public Parallel(double R, double C, string Bf, double F) : base(R, C, Bf)
        {

            this.Frequency = F; 
        }

        public double GetKreisFrequenz()
        {
            return 2 * Math.PI * f;
        }
        public double GetZBetrag()
        {
            double omega = GetKreisFrequenz();
            double resistance = this.Resistance;
            double capacitance = this.Capacitor.Capacitance;
            double Z_real = GetZReal();
            double Z_imag = GetZImag();

            // Magnitude of the impedance in a parallel RC circuit
            return Math.Sqrt(Math.Pow(Z_real, 2) + Math.Pow(Z_imag, 2));
        }
        public double GetZImag()
        {
            double omega = GetKreisFrequenz();
            double capacitance = this.Capacitor.Capacitance;

            // Imaginary part of the impedance in a parallel RC circuit
            return -1 / (omega * capacitance);

        }
        public double GetZReal()
        {
            double resistance = this.Resistance;
            double omega = GetKreisFrequenz();
            double capacitance = this.Capacitor.Capacitance;

            // Real part of the impedance in a parallel RC circuit
            return resistance / (1 + Math.Pow(omega * resistance * capacitance, 2));
        }

    }
    ;
}
   
