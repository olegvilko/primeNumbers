using System.Drawing;
using System;

namespace primeNumbers
{
    public static class DefaultSettings
    {
        // PhpMyAdmin  http://192.168.10.226:85

        public static string language = "Ru";
        public static string dataBase = "simple";
        public static string table = "simple";
        public static string tableBackup = "simpleBackup";
        public static string connectionString = "Server=192.168.10.226;Database=simple;Uid=simple;Pwd=mYUXLmSmqxd2F6Iu";
        public static string typeBase = "MySql";
        public static string allotmentLeft = "[ ";
        public static string AllotmentRigth = " ]";
        public static string messageException = "An exception occurred";

        public static int lengthOutput = 10;
        //public string checkSimpleMethod = "maths.CheckSimple";
        public static int threadSleep = 0;
        public static int countTo = 50000000;
        public static int timeOutput=1000;
        public static int getFrom = 0;
        public static int getTo = 1000;
        public static int getColumns = 10;
       
    }
}
