using Gremlin.Net.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace gremlinrunner
{
    public class Indexer
    {
        public void IndexMessage()
        {
            Console.WriteLine("We are running in the clouds!");

            var emailVertices = GetEmails();
            Console.WriteLine($"before we ran anything, email count is: {emailVertices.Count}");

            var newEmails = TraversalFactory.NewG().AddV("email").ToList();

            var newEmailVertices = GetEmails();
            Console.WriteLine($"after we inserted, email count is: {newEmailVertices.Count}");
        }
        private IList<Vertex> GetEmails()
        {
            return TraversalFactory.NewG().V().HasLabel("email").ToList();
        }
    }
}
