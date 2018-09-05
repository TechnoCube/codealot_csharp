using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    interface Codalot
    {
        void setKnight(int id, KnightPosition position);
        void process();
        int calculateEarnedXp();
    }
}
