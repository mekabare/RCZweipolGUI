using System;

namespace Resistor
{

    public class Resistor
    {
        private double resistance;
        private bool isZeroResistance;

        public double Resistance
        {
            get { return resistance; }
            set
            {
                resistance = value;
                isZeroResistance = (value == 0);
            }
        }

        //
        // Summary:
        //      Indicates whether the resistor has zero resistance.
        //
        // Returns:
        //      true if the resistor has zero resistance; otherwise, false.
        //
        // Syntax: object.IsZeroResistance() (object is an instance of the Resistor class)
        //
        public bool IsZeroResistance()
        {
            return isZeroResistance;
        }

        public Resistor() { }
        public Resistor(double r)
        {
            Resistance = r;
        }

        public Resistor(Resistor resistorObj)
        {
            this.resistance = resistorObj.Resistance;
            this.isZeroResistance = resistorObj.isZeroResistance;
        }
    }
 }
