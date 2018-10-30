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
        // Какие числа выводить.
        public bool IsVisible(int id, int simple)
        {
            try
            {
                //string str = id.ToString();
                //int last = str[str.Length - 1] - '0';
                //if (last == 1 || last == 3 || last == 7 || last == 9)
                if (simple != 0)
                {
                    return true;
                }               
            }
            catch
            {
                MessageBox.Show(DefaultSettings.messageExceptionIsVisible);
            }
            return false;
        }

        // Какие числа выделять.
        public bool AllotmentString(int id, int simple)
        {
            // return false;
            try
            {
                if (simple != 0)
                {
                    return true;
                }
            }
            catch
            {
                MessageBox.Show(DefaultSettings.messageExceptionAllotmentString);
            }
            return false;
        }

        // Какие колонки выводить.
        public bool ColumnVisible(int column)
        {
            try
            {
                if (column == 1 || column == 3 || column == 4 || column == 5 || column == 7 || column == 9)
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show(DefaultSettings.messageExceptionColumnVisible);
            }
            return true;
        }

        public string[] ProcessingList(string[] arrayList)
        {
            try
            {
                //for (int i = 1; i < arrayList.Length; i++)
                //{
                //    char ch = arrayList[i][1];
                //    if (arrayList[i][6] != '[' || arrayList[i][16] != '[' || arrayList[i][26] != '[' || arrayList[i][36] != '[')
                //    {
                //        arrayList[i] = "";
                //    }
                //}
            }
            catch
            {
                MessageBox.Show(DefaultSettings.messageExceptionProcessingList);
            }
            return arrayList;
        }

        public void ownAlgorithm(List<object[]> list, ListBox listBox, int from, int to)
        {
            try
            {
                int length = to - from;
                int[] a = new int[length];
                int next = 0;
                for (var i = 0; i < length; i++)
                {
                    if (i + 1 < list.Count)
                    {
                        int n = (int)list[i + from][(int)Sql.Table.id];
                        int s = (int)list[i + from][(int)Sql.Table.simple];
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

                for (var i = 0; i < length - 1; i++)
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
            catch
            {
                MessageBox.Show(DefaultSettings.messageExceptionOwnAlgorithm);
            }
        }
    }
}