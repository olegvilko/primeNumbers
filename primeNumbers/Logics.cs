using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace primeNumbers
{
    public class Logics
    {
        public enum MethodCheck
        {
            CheckSimple,
            CheckSimpleByTable,
            CheckSimpleArray
        }

        public enum CalculationState
        {
            Start,
            Stop
        }

        Sql sql;

        Custom custom;

        int[] arraySimple;

        int arraySimpleMax;

        string[] arrayList;

        public MethodCheck methodCheck;

        public CalculationState calculationState = CalculationState.Start;

        public delegate bool CheckSimpleMethod(int id);
        public CheckSimpleMethod checkSimpleMethod;

        public Logics()
        {
            sql = new Sql();

            custom = new Custom();

            calculationState = CalculationState.Start;
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

        public void AddSimpleToArray(int length)
        {
            arraySimple = new int[length];

            arraySimpleMax = sql.GetMaxSimple();

            if (arraySimpleMax != 0)
            {
                for (int i = 0; i < length; i++)
                {
                    arraySimple[i] = sql.GetNum(i);
                }
            }
            else
            {
                arraySimple[0] = 1;
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
                        arraySimpleMax++;
                        //        Array.Resize(ref arraySimple, ++arraySimpleMax);
                        arraySimple[++arraySimpleMax] = id;
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

        public void GetTypeColumns(ListBox listBox, int from, int to, int columns)
        {
            List<object[]> list = sql.SelectReader("*");

            int listCount = list.Count;
            if (from > listCount) from = listCount;
            if (to > listCount) to = listCount;

            int lineNumbering = 0;

            arrayList = new string[0];
            AddStrToArray(ColumnNumbering());

            for (int j = from; j < to; j += columns)
            {
                string str = null;
                for (int i = j; i < j + columns; i++)
                {
                    if (custom.ColumnVisible(i - j))
                    {
                        if (i > to) break;
                        int id = (int)list[i][(int)Sql.Table.id];
                        int simple = (int)list[i][(int)Sql.Table.simple];

                        string idStr = "";
                        if (custom.IsVisible(id, simple))
                        {
                            idStr = id.ToString();
                        }

                        if (custom.AllotmentString(id, simple)) idStr = AllotmentString(idStr, DefaultSettings.allotmentLeft, DefaultSettings.AllotmentRigth);


                        str += AlignmentString(idStr, DefaultSettings.lengthOutput);
                    }
                }
                str = AlignmentString((lineNumbering++).ToString(), 5) + str;

                AddStrToArray(str);
            }

            arrayList = custom.ProcessingList(arrayList);

            for (int i = 0; i < arrayList.Length; i++)
            {
                if (arrayList[i] != "")
                    listBox.Items.Add(arrayList[i]);
            }
        }

        string ColumnNumbering()
        {
            string str = "";
            for (int i = 0; i < 30; i++)
            {
                str += " 123456789";
            }
            return str;

        }

        void AddStrToArray(string str)
        {
            Array.Resize(ref arrayList, arrayList.Length + 1);
            arrayList[arrayList.Length - 1] = str;
        }

        #region Strings
        public string AlignmentString(string str, int count)
        {
            while (str.Length < count)
            {
                str += " ";
            }
            return str;
        }

        public string AllotmentString(string str, string left, string rigth)
        {
            return left + str + rigth;
        }
        #endregion

        public void FormulaCheck(int from, int to, ListBox listBox)
        {
            int length = sql.GetMaxId();
            if (from > length) from = length;
            if (to > length) to = length;

            List<object[]> list = sql.SelectReader("*");
            custom.FormulaCheck(list, listBox, from, to);
        }

        #region DataBase
        public string MaxId()
        {
            return Convert.ToString(sql.GetMaxId());
        }

        public string MaxSimple()
        {
            return Convert.ToString(sql.GetMaxSimple());
        }

        public void clearDataBase()
        {
            sql.ClearDatabase();
        }

        public void NewConnection()
        {
            sql.NewConnection();
        }

        public void CopyTable(string table, string tableTo)
        {
            sql.CopyTable(DefaultSettings.table, DefaultSettings.tableBackup);
        }
        #endregion

        public void CalculationPrimeNumbers(BackgroundWorker backgroundWorker, int countTo)
        {
            int id = sql.GetMaxId() + 1;
            int simple = sql.GetMaxSimple();
            int counter = id;

            if (methodCheck == MethodCheck.CheckSimpleArray)
            {
                AddSimpleToArray(countTo);
            }

            while (calculationState == CalculationState.Stop)
            {
                if (id > DefaultSettings.countTo)
                {
                    backgroundWorker.ReportProgress(id - 1);
                    break;
                }

                if (checkSimpleMethod(id))
                {
                    sql.InsertSimple((++simple).ToString());
                }
                else
                {
                    sql.InsertSimple("");
                }
                id++;

                if (id - counter >= DefaultSettings.timeOutput)
                {
                    backgroundWorker.ReportProgress(id);
                    counter = id;
                }

                Thread.Sleep(DefaultSettings.threadSleep);
            }
        }

        public void ExitProgramm()
        {
            sql.ConnectionClose();
            Environment.Exit(0);
        }
    }
}