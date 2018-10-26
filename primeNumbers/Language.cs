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
        }

        public void Ru()
        {
            name.start = "Старт";
            name.stop = "Стоп";
            name.file = "Файл";
            name.settings = "Опции";
            name.help = "Справка";
            name.get = "Вывести";
            name.maxNum = "Последнее число:";
            name.maxSimple = "Найдено простых чисел:";
            name.nameProject = "Простые числа";
            name.language = "Язык";
            name.clearDataBase = "Очистить таблицу";
            name.pathDataBase = "Путь к базе данных";
            name.exit = "Выход";
            name.delay = "Задержка";
            name.apply = "Применить";
            name.countTo = "Считать до";
            name.clearBaseConfirmAction = "Подтвердите действие";
            name.clearBaseCompleteTheProcess = "Очистить таблицу?";
            name.time = "Время";
            name.saveBackup = "Сохранить";
            name.loadBackup = "Загрузить";
            name.methodCheck = "Метод проверки";
            name.methodCheckSimple = "Простая";
            name.methodCheckByTable = "По таблице";
            name.methodSimpleArray = "По массиву";
            name.getFrom = "от";
            name.getTo = "до";
            name.getType = "Тип вывода";
            name.getTypeOneColumn = "Одна колонка, число и его номер простого числа";
            //
            name.logCountTo = "Достигнут предел считать до ";
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
            name.clearDataBase = "Clear table";
            name.pathDataBase = "Path DataBase";
            name.exit = "Exit";
            name.delay = "Delay";
            name.apply = "Apply";
            name.countTo = "Count to";
            name.clearBaseConfirmAction = "Confirm action";
            name.clearBaseCompleteTheProcess = "Clear table?";
            name.time = "Time";
            name.loadBackup = "Load";
            name.saveBackup = "Save";
            name.methodCheck = "Method check";
            name.methodCheckSimple = "Simple";
            name.methodCheckByTable = "By table";
            name.methodSimpleArray = "By array";
            name.getFrom = "from";
            name.getTo = "to";
            name.getType = "Get type";
            name.getTypeOneColumn = "One column, number and count prime number";
            //
            name.logCountTo = "Limit reached count to ";
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
