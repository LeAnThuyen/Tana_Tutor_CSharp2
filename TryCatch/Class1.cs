using System;
using System.Collections;

namespace TryCatch
{
    public class Class1
    {

        public Class1()
        {
            Hashtable hash = new Hashtable();
            hash.Add("K", "Kteam");
            hash.Add("H", "HowKteam");
            hash.Add("FE", "Free Education");

            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
        }




    }
}
