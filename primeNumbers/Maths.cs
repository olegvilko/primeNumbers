//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace primeNumbers
{
    class Maths
    {
        public bool CheckSimple(int id)
        {
            for (int i = 2; i < id/2+1; i++)
            {
                if ((double)id / i == id / i)
                {
                    return false;
                }
            }
            return true;
        }
    }
}