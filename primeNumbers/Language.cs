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
            public string nameProject;
            public string language;
            public string clearDataBase;
            public string pathDataBase;
            public string exit;
            public string delay;
            public string applay;
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
            name.maxSimple = "Найдено простых чисел: ";
            name.nameProject = "Простые числа";
            name.language = "Язык";
            name.clearDataBase = "Очистить базу";
            name.pathDataBase = "Путь к базе данных";
            name.exit = "Выход";
            name.delay = "Задержка";
            name.applay = "Применить";
            
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
            name.maxSimple = "Found prime numbers: ";
            name.nameProject = "Prime numbers";
            name.language = "Language";
            name.clearDataBase = "Clear DataBase";
            name.pathDataBase = "Path DataBase";
            name.exit = "Exit";
            name.delay = "Delay";
            name.applay = "Apply";
        }
    }
}
