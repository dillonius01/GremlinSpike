using Gremlin.Net.Driver;
using Gremlin.Net.Driver.Messages;
using Gremlin.Net.Driver.Remote;
using Gremlin.Net.Process.Traversal;
using Gremlin.Net.Structure;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace gremlinrunner
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoWork();
            }
            catch (Exception e)
            {
                Console.WriteLine("Encountered an exception while running the program");
                Console.WriteLine("{0}", e);
            }
        }

        private static void DoWork()
        {
            var indexer = new Indexer();

            indexer.IndexMessage();
        }
    }
}
