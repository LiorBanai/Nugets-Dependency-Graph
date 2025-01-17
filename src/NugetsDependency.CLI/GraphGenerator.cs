using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.Layout.MDS;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetsDependencyGraph.CLI
{
    internal class GraphGenerator
    {
        public string FileName { get; set; }

        public GraphGenerator(string fileName)
        {
            FileName = fileName;
        }

        public void Generate(string targetFrameworks, string showOnlyDependenciesWithName, string limitToSingleProject, string colorSpecificDependency, string outputFolder)
        {
            if (!File.Exists(FileName))
            {
                Console.WriteLine("File does not exist");
                return;
            }
            Graph graph = new Graph("graph");
            var json = File.ReadAllText(FileName);
            var jsonObject = JObject.Parse(json);
            var targets = jsonObject["targets"][targetFrameworks] as IDictionary<string, JToken>;
            if (targets == null)
            {
                Console.WriteLine("Target does not exists");
                return;
            }
            foreach (var target in targets)
            {
                var nameVersion = target.Key.ToLower().Replace("/", ": ");
                if (!string.IsNullOrEmpty(showOnlyDependenciesWithName) && !nameVersion.Contains(showOnlyDependenciesWithName,
                        StringComparison.InvariantCultureIgnoreCase))
                {
                    continue;
                }
                Node node = null;
                if (string.IsNullOrEmpty(limitToSingleProject))
                {
                    node = graph.AddNode(nameVersion);
                }
                else if (nameVersion.StartsWith(limitToSingleProject.ToLower()))
                {
                    node = graph.AddNode(nameVersion);
                    node.Label.FontColor = Microsoft.Msagl.Drawing.Color.Green;
                    node.Label.FontSize += 10;
                }

                if (!string.IsNullOrEmpty(colorSpecificDependency) && nameVersion.StartsWith(colorSpecificDependency.ToLower()) && node is not null)
                {
                    node.Label.FontColor = Microsoft.Msagl.Drawing.Color.DarkRed;
                    node.Label.FontSize += 5;
                }
                var deps = target.Value["dependencies"] as IDictionary<string, JToken>;
                if (deps is null || node is null)
                {
                    continue;
                }
                foreach (var dep in deps)
                {
                    var dependent = dep.Key.ToLower() + ": " + (dep.Value as Newtonsoft.Json.Linq.JValue).Value;
                    if (!string.IsNullOrEmpty(showOnlyDependenciesWithName) && !dependent.Contains(showOnlyDependenciesWithName, StringComparison.InvariantCultureIgnoreCase))
                    {
                        continue;
                    }
                    graph.AddNode(dependent);
                    var edge = graph.AddEdge(nameVersion, dependent);
                    edge.Attr.ArrowheadLength = 10;
                }
            }
            //bind the graph to the viewer 
            graph.Attr.LayerDirection = LayerDirection.None;
            graph.Attr.OptimizeLabelPositions = true;
            graph.CreateLayoutSettings();
            graph.LayoutAlgorithmSettings = new MdsLayoutSettings();
            string outputFileName = Path.Join(outputFolder, "NugetDependencyGraphOutput");
            graph.Write(outputFileName);
        }
    }
}
