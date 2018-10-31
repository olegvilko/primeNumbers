using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Text;

namespace primeNumbers
{
    public class Logics
    {
        Sql sql;
        Custom custom;
        int[] simple;
        int simpleMax;
        public MethodCheck methodCheck;
        public CalculationState calculationState = CalculationState.Start;
        public delegate bool CheckSimpleMethod(int id);
        public CheckSimpleMethod checkSimpleMethod;

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
            for (var i = 2; ; i++)
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
            var max = 0;
            for (var i = 2; i <= (max = id / i); i++)
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
            simple = new int[length];
            simpleMax = sql.GetMaxSimple();
            if (simpleMax != 0)
            {
                List<object[]> list = sql.SelectReader("Simple");
                for (var i = 0; i < length; i++)
                    simple[i] = Convert.ToInt32(list[i][(int)Sql.Table.simple]);
            }
            else
            {
                simple[0] = 1;
            }
        }

        public bool CheckSimpleArray(int id)
        {
            for (var i = 0; ; i++)
            {
                var s = simple[i];
                if (s < 2) s = 2;
                var result = id / s;
                if (s > result)
                {
                    if (id > 2)
                    {
                        simpleMax++;
                        simple[++simpleMax] = id;
                    }
                    return true;
                }
                if ((double)id / s == result)
                {
                    return false;
                }
            }
        }
        #endregion

        public void GetTypeColumns(ListBox listBox, int from, int to, int columns)
        {
            List<object[]> list = sql.SelectReader("*");
            var listCount = list.Count;
            if (from > listCount) from = listCount;
            if (to > listCount) to = listCount;
            var lineNumbering = 0;
            string[] numbers = new string[0];
            numbers = AddStrToArray(numbers, ColumnNumbering());
            for (var j = from; j < to; j += columns)
            {
                string str = null;
                for (var i = j; i < j + columns; i++)
                {
                    if (custom.ColumnVisible(i - j))
                    {
                        if (i > to) break;
                        int id = (int)list[i][(int)Sql.Table.id];
                        var s = (int)list[i][(int)Sql.Table.simple];
                        string idStr = "";
                        if (custom.IsVisible(id, s))
                        {
                            idStr = id.ToString();
                        }
                        if (custom.AllotmentString(id, s)) idStr = AllotmentString(idStr, DefaultSettings.allotmentLeft, DefaultSettings.AllotmentRigth);
                        str += AlignmentString(idStr, DefaultSettings.lengthOutput);
                    }
                }
                str = AlignmentString((lineNumbering++).ToString(), 5) + str;
                numbers = AddStrToArray(numbers, str);
            }
            numbers = custom.ProcessingList(numbers);
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != "")
                    listBox.Items.Add(numbers[i]);
            }
        }

        string ColumnNumbering()
        {
            var str = new StringBuilder();
            for (var i = 0; i < 30; i++)
            {
                str.Append(" 123456789");
            }
            return str.ToString();
        }

        string[] AddStrToArray(string[] numbers, string str)
        {
            Array.Resize(ref numbers, numbers.Length + 1);
            numbers[numbers.Length - 1] = str;
            return numbers;
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

        public void OwnAlgorithm(int from, int to, ListBox listBox)
        {
            int length = sql.GetMaxId();
            if (from > length) from = length;
            if (to > length) to = length;
            List<object[]> list = sql.SelectReader("*");
            custom.ownAlgorithm(list, listBox, from, to);
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
            sql.CopyTable(table, tableTo);
        }

        public void CreateTables()
        {
            sql.CreateTable(DefaultSettings.table);
            sql.CreateTable(DefaultSettings.tableBackup);
        }
        #endregion

        public void CalculationPrimeNumbers(BackgroundWorker backgroundWorker, int countTo)
        {
            var id = sql.GetMaxId() + 1;
            var s = sql.GetMaxSimple();
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
                    sql.InsertSimple((++s).ToString());
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
            calculationState = CalculationState.Start;
            sql.ConnectionClose();
            Environment.Exit(0);
        }
    }
}