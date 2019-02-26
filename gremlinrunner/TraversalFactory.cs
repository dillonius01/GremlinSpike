using Gremlin.Net.Driver;
using Gremlin.Net.Driver.Remote;
using Gremlin.Net.Process.Traversal;
using Gremlin.Net.Structure;

namespace gremlinrunner
{
    public static class TraversalFactory
    {
        private static string neptuneEndpoint => "d4gremlin1.cluster-cpyymjvdibvm.us-east-2.neptune.amazonaws.com";

        public static GraphTraversalSource NewG()
        {
            var graph = new Graph();

            // This uses the default Neptune and Gremlin port, 8182
            return graph.Traversal().WithRemote(new DriverRemoteConnection(new GremlinClient(new GremlinServer(neptuneEndpoint))));
        }

    }
}
