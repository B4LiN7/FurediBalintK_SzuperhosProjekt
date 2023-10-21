using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public interface Inter
    {
        bool LegyoziE(Inter szuperhos);
        double MekkoraAzEreje();
    }
    public interface IMilliardos
    {
        void KutyutKeszit();
    }
}
