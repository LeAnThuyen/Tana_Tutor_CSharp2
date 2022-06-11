namespace OnTapDocGhiFile
{
    public class Program
    {
        private static string _input;
        static void Main(string[] args)
        {
            NYCServices nYCServices = new NYCServices();
            nYCServices.ShowMenu();
        }
    }
}
