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
            int max;
            for (int i = 2; i <= (max=id/i); i++)
            {
                //int max = id / i;
                //if (i>max)
                //{
                //    return true;
                //}
                if ((double)id / i == max)
                {
                    return false;
                }
            }
            return true;
        }
    }
}