namespace primeNumbers
{
    class Language
    {        
        public Text text;

        public string en = "En";
        public string ru = "Ru";

        public struct Text
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
            public string apply;
            public string logCountTo;
            public string countTo;
            public string clearBaseConfirmAction;
            public string clearBaseCompleteTheProcess;
            public string time;
            public string saveBackup;
            public string loadBackup;
            public string methodCheck;
            public string methodCheckSimple;
            public string methodCheckByTable;
            public string methodSimpleArray;
            public string getTo;
            public string getFrom;
            public string getType;
            public string getTypeOneColumn;
            public string getColumns;
            public string aboutTheProgram;
            public string aboutTheProgramText;
            public string own;
            public string clipBoard;

        }

        public void Ru()
        {
            text.start = "Старт";
            text.stop = "Стоп";
            text.file = "Файл";
            text.settings = "Опции";
            text.help = "Справка";
            text.get = "Вывести";
            text.maxNum = "Последнее число:";
            text.maxSimple = "Найдено простых чисел:";
            text.nameProject = "Простые числа";
            text.language = "Язык";
            text.clearDataBase = "Очистить таблицу";
            text.pathDataBase = "Путь к базе данных";
            text.exit = "Выход";
            text.delay = "Задержка";
            text.apply = "Применить";
            text.countTo = "Считать до";
            text.clearBaseConfirmAction = "Подтвердите действие";
            text.clearBaseCompleteTheProcess = "Очистить таблицу?";
            text.time = "Время";
            text.saveBackup = "Сохранить";
            text.loadBackup = "Загрузить";
            text.methodCheck = "Метод проверки";
            text.methodCheckSimple = "Простая";
            text.methodCheckByTable = "По таблице";
            text.methodSimpleArray = "По массиву";
            text.getFrom = "от";
            text.getTo = "до";
            text.getType = "Тип вывода";
            text.getTypeOneColumn = "Одна колонка, число и его номер простого числа";
            text.getColumns = "колонок:";
            text.logCountTo = "Достигнут предел считать до ";
            text.aboutTheProgram = "О программе";
            text.aboutTheProgramText = "Программное обеспечение для изучения простых чисел. Версия 1.0";
            text.own = "Свой алгоритм";
            text.clipBoard = "Скопировать в буфер";
        }

        public void En()
        {
            text.start = "Start";
            text.stop = "Stop";
            text.file = "File";
            text.settings = "Settings";
            text.help = "Help";
            text.get = "Get";
            text.maxNum = "Max number: ";
            text.maxSimple = "Found prime numbers: ";
            text.nameProject = "Prime numbers";
            text.language = "Language";
            text.clearDataBase = "Clear table";
            text.pathDataBase = "Path DataBase";
            text.exit = "Exit";
            text.delay = "Delay";
            text.apply = "Apply";
            text.countTo = "Count to";
            text.clearBaseConfirmAction = "Confirm action";
            text.clearBaseCompleteTheProcess = "Clear table?";
            text.time = "Time";
            text.loadBackup = "Load";
            text.saveBackup = "Save";
            text.methodCheck = "Method check";
            text.methodCheckSimple = "Simple";
            text.methodCheckByTable = "By table";
            text.methodSimpleArray = "By array";
            text.getFrom = "from";
            text.getTo = "to";
            text.getType = "Get type";
            text.getTypeOneColumn = "One column, number and count prime number";
            text.getColumns = "columns:";
            text.logCountTo = "Limit reached count to ";
            text.aboutTheProgram = "About The Program";
            text.aboutTheProgramText = "Software for learning simple numbers. Version 1.0";
            text.own = "Own algorithm";
            text.clipBoard = "Clip board";
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
    }
}
