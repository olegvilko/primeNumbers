namespace primeNumbers
{
    class Maths
    {
        Sql sql;

        public Maths()
        {
            sql = new Sql();
        }

        public bool CheckSimpleByTable(int id)
        {
            int result;
            for (int i = 2;; i++)
            {
                int simple= sql.GetNum(i);
                if (simple <2) simple = 2;

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
    }
}