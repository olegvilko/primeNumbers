namespace primeNumbers
{
    public class DefaultSettings
    {
        public string language = "Ru";
        public string dataBase = "simple";
        // public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\helgi\source\repos\primeNumbers\primeNumbers\Database1.mdf;Integrated Security=True";
        // Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;
        public string connectionString = "Server=192.168.10.226;Database=simple;Uid=simple;Pwd=mYUXLmSmqxd2F6Iu";
        public string typeBase = "MySql";
        public int threadSleep = 0;
        public int countTo = 1000;
    }
}
