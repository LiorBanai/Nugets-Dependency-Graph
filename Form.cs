using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.Layout.MDS;
using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceProcess;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Windows.Forms;

namespace ProcessDependency
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "project.assets.json",
                Filter = "project asset files (*.assets.json)|*.assets.json",
                FilterIndex = 1,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            Graph graph = new Graph("graph");
            if (!File.Exists(textBox1.Text))
            {
                return;
            }
            var json = File.ReadAllText(textBox1.Text);

            var jsonObject = JObject.Parse(json);
            var targets = jsonObject["targets"][textBox2.Text] as IDictionary<string, JToken>;
            if (targets == null)
                return;
            foreach (var target in targets)
            {
                var nameVersion = target.Key.ToLower().Replace("/", ": ");
                graph.AddNode(nameVersion);
                var deps = target.Value["dependencies"] as IDictionary<string, JToken>;
                if (deps is null)
                {
                    continue;
                }
                foreach (var dep in deps)
                {
                    var dependent = dep.Key.ToLower() + ": " + (dep.Value as Newtonsoft.Json.Linq.JValue).Value;
                    graph.AddNode(dependent);
                    graph.AddEdge( nameVersion, dependent);
                }
            }
            //bind the graph to the viewer 
            graph.Attr.LayerDirection = LayerDirection.None;
            graph.Attr.OptimizeLabelPositions = true;
            graph.CreateLayoutSettings();
            graph.LayoutAlgorithmSettings = new MdsLayoutSettings();
            viewer.Graph = graph;
            SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Controls.Add(viewer);
            ResumeLayout();

        }
    }
}
