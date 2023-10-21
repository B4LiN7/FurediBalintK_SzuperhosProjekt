using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Batman : IMilliardos, Inter
    {
        private double lelemenyesseg;

        public Batman()
        {
            this.lelemenyesseg = 100;
        }

        public double MekkoraAzEreje()
        {
            return lelemenyesseg * 2;
        }

        public void KutyutKeszit()
        {
            lelemenyesseg += 50;
        }

        public bool LegyoziE(Inter szuperhos)
        {
            if (szuperhos.MekkoraAzEreje() < this.lelemenyesseg)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"Batman: leleményesség: {this.lelemenyesseg}";
        }
    }
}
