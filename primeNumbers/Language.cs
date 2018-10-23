using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeNumbers
{
    class Language
    {
        public Name name;

        public string en = "En";
        public string ru = "Ru";

        public struct Name
        {
            public string start;
            public string stop;
            public string file;
            public string settings;
            public string help;
            public string get;
            public string maxNum;
            public string maxSimple;
        }

        public Language(string lang)
        {
            switch (lang)
            {
                case "Ru":
                    Ru();
                    break;
                case "En":
                    En();
                    break;
                default:
                    En();
                    break;
            }
        }

        public void Ru()
        {
            name.start = "Старт";
            name.stop = "Стоп";
            name.file = "Файл";
            name.settings = "Опции";
            name.help = "Справка";
            name.get = "Вывести";
            name.maxNum = "Последнее число: ";
            name.maxSimple = "Последнее простое число: ";
        }

        public void En()
        {
            name.start = "Start";
            name.stop = "Stop";
            name.file = "File";
            name.settings = "Settings";
            name.help = "Help";
            name.get = "Get";
            name.maxNum = "Max number: ";
            name.maxSimple = "Max simple: ";
        }
    }
}
