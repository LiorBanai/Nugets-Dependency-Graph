﻿using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.Layout.MDS;
using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceProcess;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

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

            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            Graph graph = new Graph("graph");
            var json = File.ReadAllText("c:\\0\\project.assets.json");
            var jsonObject = JObject.Parse(json);
            var targets = jsonObject["targets"][".NETFramework,Version=v4.8"] as IDictionary<string, JToken>;
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
                    graph.AddEdge(dependent, nameVersion);
                }
            }

            //foreach (ServiceController serviceController in ServiceController.GetServices())
            //{
            //    var service = $"{serviceController.DisplayName} ({serviceController.ServiceName})";
            //    graph.AddNode(service);
            //    foreach (var dependentService in serviceController.DependentServices)
            //    {
            //        string dependent = $"{dependentService.DisplayName} ({dependentService.ServiceName})";
            //        graph.AddNode(dependent);
            //        graph.AddEdge(dependent, service);
            //    }
            //}
            //bind the graph to the viewer 
            graph.Attr.LayerDirection = LayerDirection.None;
            graph.Attr.OptimizeLabelPositions = true;
            graph.CreateLayoutSettings();
            graph.LayoutAlgorithmSettings = new MdsLayoutSettings();
            viewer.Graph = graph;
            SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            Controls.Add(viewer);
            ResumeLayout();

        }
    }
}
