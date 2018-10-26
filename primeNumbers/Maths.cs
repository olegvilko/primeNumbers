using System;

namespace primeNumbers
{
    class Maths
    {
        public enum MethodCheck
        {
            CheckSimple,
            CheckSimpleByTable,
            CheckSimpleArray
        }

        Sql sql;

        int[] arraySimple;

        public Maths()
        {
            sql = new Sql();
        }

        public bool CheckSimpleByTable(int id)
        {
            int result;
            for (int i = 2; ; i++)
            {
                int simple = sql.GetNum(i);
                if (simple < 2) simple = 2;

                result = id / simple;

                if (simple > result)
                {
                    return true;
                }

                if ((double)id / simple == result)
                {
                    return false;
                }
            }
        }

        public bool CheckSimple(int id)
        {
            int max;
            for (int i = 2; i <= (max = id / i); i++)
            {
                if ((double)id / i == max)
                {
                    return false;
                }
            }
            return true;
        }

        public void AddSimpleToArray()
        {
            int length = sql.GetMaxSimple();
            if (length != 0) {
                arraySimple = new int[length];
                for (int i = 0; i < length; i++)
                {
                    arraySimple[i] = sql.GetNum(i);
                }
            }
            else
            {
                arraySimple = new int[1] { 2 };
            }
        }

        public bool CheckSimpleArray(int id)
        {
            for (int i = 0; ; i++)
            {
                int simple = arraySimple[i];
                if (simple < 2) simple = 2;

                int result = id / simple;

                if (simple > result)
                {
                    if (id > 2)
                    {
                        Array.Resize(ref arraySimple, arraySimple.Length + 1);
                        arraySimple[arraySimple.Length-1] = id;
                    }
                    return true;
                }

                if ((double)id / simple == result)
                {
                    return false;
                }
            }
            //i<arraySimple.Length
            //    Array.Resize(ref arraySimple, arraySimple.Length + 1);
            //    arraySimple[arraySimple.Length - 1] = id;

            //return true;
        }
    }
}