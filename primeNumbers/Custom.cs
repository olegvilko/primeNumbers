using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace primeNumbers
{
    public class Custom
    {
        // Какие числа выводить
        public bool IsVisible(int id, int simple)
        {
            //string str = id.ToString();
            //int last = str[str.Length - 1] - '0';
            //if (last == 1 || last == 3 || last == 7 || last == 9)
            if(simple==0)
            {
                return true;
            }
            return false;
        }

        // Какие числа выделять
        public bool AllotmentString(int id, int simple)
        {
            // return false;

            if (simple == 0)
            {
                return true;
            }
            return false;
        }

        // Какие колонки выводить
        public bool ColumnVisible(int column)
        {
            if (column == 1 || column == 3 || column == 4 || column == 5 || column == 7 || column == 9)
            {
                return false;
            }
            return true;
        }

        public string[] ProcessingList(string[] arrayList)
        {
            //for (int i = 1; i < arrayList.Length; i++)
            //{
            //    char ch = arrayList[i][1];
            //    if (arrayList[i][6] != '[' || arrayList[i][16] != '[' || arrayList[i][26] != '[' || arrayList[i][36] != '[')
            //    {
            //        arrayList[i] = "";
            //    }
            //}
            return arrayList;
        }

        public void FormulaCheck(List<object[]> list, ListBox listBox, int from, int to)
        {
            int length = to - from;
            int[] a = new int[length];
            int next = 0;
            for (int i = 0; i < length; i++)
            {
                if (i + 1 < list.Count)
                {
                    int n = (int)list[i+from][(int)Sql.Table.id];
                    int s = (int)list[i+from][(int)Sql.Table.simple];
                    if (s != 0)
                    {
                        a[next] = n;
                        next++;
                       // int s1 = (int)list[i][(int)Sql.Table.simple];
                        //int s2 = (int)list[i + 1][(int)Sql.Table.simple];

                        //  int[] a=;
                       // int k = s2 - s;
                       // listBox.Items.Add(k);
                    }

                    
               //     return s2.ToString();
                    //int simple = (int)list[i][(int)Sql.Table.simple];
                }
            }

            for (int i = 0; i < length-1; i++)
            {
                int k = a[i + 1] - a[i];
                listBox.Items.Add(k);
            }

            //foreach (int element in a)
            //{
            //    listBox.Items.Add(element);
            //}
            //  return "";
        }
    }
}