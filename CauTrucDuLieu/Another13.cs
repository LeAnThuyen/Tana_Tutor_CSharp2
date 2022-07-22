namespace CauTrucDuLieu
{
    public class Another13
    {

        public int Id { get; set; }
        public string Ten { get; set; }
        public double CanNang { get; set; }
        public Another13()
        {

        }

        public Another13(int id, string ten, double canNang)
        {
            Id = id;
            Ten = ten;
            CanNang = canNang;
        }


        public void PrintToScreen()
        {
            System.Console.WriteLine($"ID La: {Id},Ten La: {Ten},Can Nang La: {CanNang}");
        }
    }
}
