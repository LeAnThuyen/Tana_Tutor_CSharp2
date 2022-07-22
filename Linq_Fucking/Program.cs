using System.Collections.Generic;

namespace Linq_Fucking
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<string> _fuckinglist = new List<string>();
            _fuckinglist.Add("a");
            _fuckinglist.Add("b");
            _fuckinglist.Add("c");
            _fuckinglist.Add("d");
            _fuckinglist.Add("e");
            _fuckinglist.Add("f");
            _fuckinglist.Add("g");
            //
            int indexer = _fuckinglist.FindIndex(c => c == "a");
            int indexer1 = _fuckinglist.FindIndex(c => c == "d");
            int indexer2 = _fuckinglist.FindIndex(c => c == "e");
            int indexer3 = _fuckinglist.FindIndex(c => c == "f");
            int indexer4 = _fuckinglist.FindIndex(c => c == "h");
            System.Console.WriteLine(indexer.ToString());
            System.Console.WriteLine(indexer1.ToString());
            System.Console.WriteLine(indexer2.ToString());
            System.Console.WriteLine(indexer3.ToString());
            System.Console.WriteLine(indexer4.ToString());

        }
    }
}
