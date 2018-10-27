using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace primeNumbers
{
    class Custom
    {
        Sql sql;

        public Custom()
        {
            sql = new Sql();
        }

        public bool IsVisible(int id, int simple)
        {
            if (simple == 0) return false;
            return true;
        }

        public bool AllotmentString(int id, int simple)
        {
            // return false;

            if (simple != 0)
            {
                return true;
            }
            return false;
        }

        public bool ColumnVisible(int column)
        {
            if (column == 1 || column == 3 || column == 4 || column == 5 || column == 7 || column == 9)
            {
                return false;
            }
            return true;
        }

        public void FormulaCheck(int from, int to, ListBox listBox)
        {
            for (int i = from; i < to; i++)
            {
                if (sql.CheckSimple(i) && sql.CheckSimple(i+10))
                {        
                    listBox.Items.Add(i + "  " + (i+10));
                }
            }
        }
    }
}