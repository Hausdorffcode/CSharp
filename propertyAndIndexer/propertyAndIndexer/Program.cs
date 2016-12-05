using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertyAndIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            IndexerRecord indexer = new IndexerRecord();
            indexer[0] = "马克吐温";      //索引器set
            indexer[1] = "Crox出版公司";
            indexer[2] = "汤姆索亚历险";

            Console.WriteLine(indexer["Title"]); //索引访问， get
            Console.WriteLine(indexer["Author"]);
            Console.WriteLine(indexer["Publisher"]);

            Console.ReadKey();
        }
    }
}
