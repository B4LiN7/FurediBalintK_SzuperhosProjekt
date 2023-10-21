using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public abstract class Bosszuallo : Inter
    {
        private double szuperero;
        private bool vanEGyengesege;

        protected Bosszuallo(double szuperero, bool vanEGyengesege)
        {
            this.szuperero = szuperero;
            this.vanEGyengesege = vanEGyengesege;
        }

        public double Szuperero { get => szuperero; set => szuperero = value; }
        public bool VanEGyengesege { get => vanEGyengesege; set => vanEGyengesege = value; }

        public bool LegyoziE(Inter szuperhos)
        {
            /*
            Bosszuallo? bosszuallo = szuperhos as Bosszuallo;
            if (bosszuallo == null) { return false; }
            */

            if (szuperhos is Bosszuallo bosszuallo && bosszuallo.MekkoraAzEreje() < this.szuperero && bosszuallo.VanEGyengesege)
            {
                return true;
            }
            else if (szuperhos is Batman batman && batman.MekkoraAzEreje() * 2 <= this.szuperero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public double MekkoraAzEreje()
        {
            return szuperero;
        }

        public abstract bool MegmentiAVilagot();

        public override string ToString()
        {
            string kimenet = $"Szupererő: {this.szuperero}; ";
            if (this.vanEGyengesege)
            {
                kimenet += "van gyengesége";
            }
            else
            {
                kimenet += "nincs gyengesége";
            }
            return kimenet;
        }
    }
}
