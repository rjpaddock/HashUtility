using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            //default is to hash a string
            var hashType = "STRING";
            var itemToHash = args[0];

            //use second parameter as type of thing to hash
            if (args.Length == 2)
            {
                hashType = args[1];
            }
             
            if (hashType == "FILE")
            {
                itemToHash = File.ReadAllText(itemToHash);
            }

            var retVal = HashUtilities.GenerateHash(itemToHash);

            Console.WriteLine(retVal);
        }
    }
}
