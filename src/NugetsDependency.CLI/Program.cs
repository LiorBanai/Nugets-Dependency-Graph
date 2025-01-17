namespace NugetsDependencyGraph.CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("generating graph");
            if (args.Length is not 2)
            {
                Console.WriteLine("invalid parameters count. expected: filename and framework");
                return;
            }
            var filename =args[0];
            var targetFramework = args[1];//"net8.0-windows7.0";
            GraphGenerator graph = new GraphGenerator(filename);
            graph.Generate(targetFramework,"","","",Environment.CurrentDirectory);
        }
    }
}
