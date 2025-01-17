namespace NugetsDependencyGraph.CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length is not 2)
            {
                Console.WriteLine("invalid parameters count. expected: directory of obj folder with project.assets.json and framework");
                return;
            }
            Console.WriteLine("generating graph");
            var filename = Path.Join(args[0], "project.assets.json");
            var targetFramework = args[1];//"net8.0-windows7.0";
            GraphGenerator graph = new GraphGenerator(filename);
            var directory = args[0];
            graph.Generate(targetFramework, "", "", "", directory);
        }
    }
}
