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

        #region Methods
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
        }
        #endregion

        #region Strings
        public string AlignmentString(string str, int count)
        {
            while (str.Length < count)
            {
                str +=" ";
            }
            return str;
        }

        public string AllotmentString(string str, string left, string rigth)
        {
            return left + str + rigth;
        }
        #endregion

        //public int[] GetArrayId(int from, int to)
        //{
        //    int length = sql.GetMaxId();
        //    if()
        //    if (length != 0)
        //    {
        //        arraySimple = new int[length];
        //        for (int i = 0; i < length; i++)
        //        {
        //            arraySimple[i] = sql.GetNum(i);
        //        }
        //    }
        //}
        //public bool FormulaCheck()
        //{
        //    int max = sql.GetMaxId();
        //    for(int i=0;i)

        //}
    }
}