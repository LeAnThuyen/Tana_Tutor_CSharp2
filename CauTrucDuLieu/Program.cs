namespace CauTrucDuLieu
{
    public class Program
    {

        //public static void LoadDing()
        //{

        //    Hashtable hash = new Hashtable();
        //    hash.Add("T", "Thuyen");
        //    hash.Add("T", "TienTi");

        //    var x = hash["K"];
        //    hash.ContainsKey("T");
        //    System.Console.WriteLine(x);
        //}
        static void Main(string[] args)
        {
            // LoadDing();

            AnotherServices anotherServices = new AnotherServices();
            anotherServices.ThamChieu();
        }
    }
}
