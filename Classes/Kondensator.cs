using System;

/// <summary>
/// contains the properties of a capacitor
/// </summary>
namespace Kondensator
{
    internal class Kondensator
    {
        //private accessor is implicit for all properties
        public string Bauform { get; set; }
        public string MaterialDielektrikum { get; set; }
        public double Capacitance { get; set; }
        public double RelDielektrizKonst { get; set; }

        public Kondensator() {
        
        }
        public Kondensator(double kp, string bf) //Keramik as commonly used material, relatively neutral in terms of dielectric constant
        {
            this.Capacitance = kp;
            this.Bauform = bf;
        }

        public Kondensator(Kondensator koObj) 
        {
            this.Bauform = koObj.Bauform;
            this.Capacitance= koObj.Capacitance;
            this.MaterialDielektrikum = koObj.MaterialDielektrikum;
            this.RelDielektrizKonst= koObj.RelDielektrizKonst;
            
        }

        public void Deconstruct(out string bf, out string mat, out double kp, out double rdk) //deconstructor
        {
            bf = Bauform;
            mat = MaterialDielektrikum;
            kp = Capacitance;
            rdk = RelDielektrizKonst;
        }
    }
}
