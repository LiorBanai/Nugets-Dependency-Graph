﻿namespace NugetDependency
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new System.Windows.Forms.Panel();
            btnOpenGraph = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            txtDependenciesName = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            tbColor = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            textBox4 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnRun = new System.Windows.Forms.Button();
            textBox2 = new System.Windows.Forms.TextBox();
            BtnSelect = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage2 = new System.Windows.Forms.TabPage();
            pnlLoadExisting = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtDependenciesName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbColor);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRun);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(BtnSelect);
            panel1.Controls.Add(textBox1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1184, 213);
            panel1.TabIndex = 0;
            // 
            // btnOpenGraph
            // 
            btnOpenGraph.Location = new System.Drawing.Point(6, 6);
            btnOpenGraph.Name = "btnOpenGraph";
            btnOpenGraph.Size = new System.Drawing.Size(142, 30);
            btnOpenGraph.TabIndex = 14;
            btnOpenGraph.Text = "Open Graph";
            btnOpenGraph.UseVisualStyleBackColor = true;
            btnOpenGraph.Click += btnOpenGraph_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(9, 144);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(129, 20);
            label6.TabIndex = 13;
            label6.Text = "Show Only names:";
            // 
            // txtDependenciesName
            // 
            txtDependenciesName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtDependenciesName.Location = new System.Drawing.Point(247, 139);
            txtDependenciesName.Name = "txtDependenciesName";
            txtDependenciesName.Size = new System.Drawing.Size(848, 27);
            txtDependenciesName.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(9, 177);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(135, 20);
            label5.TabIndex = 11;
            label5.Text = "Color Dependency:";
            // 
            // tbColor
            // 
            tbColor.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbColor.Location = new System.Drawing.Point(247, 172);
            tbColor.Name = "tbColor";
            tbColor.Size = new System.Drawing.Size(848, 27);
            tbColor.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(8, 112);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(159, 20);
            label4.TabIndex = 9;
            label4.Text = "Limit to Single project:";
            // 
            // textBox4
            // 
            textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox4.Location = new System.Drawing.Point(246, 107);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(848, 27);
            textBox4.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(9, 15);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(156, 20);
            label3.TabIndex = 7;
            label3.Text = "project.assets.json file:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(9, 109);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 20);
            label2.TabIndex = 6;
            label2.Text = "example:";
            // 
            // textBox3
            // 
            textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox3.Location = new System.Drawing.Point(171, 74);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(924, 27);
            textBox3.TabIndex = 5;
            textBox3.Text = ".NETFramework,Version=v4.8  Or net8.0-windows7.0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 77);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 20);
            label1.TabIndex = 4;
            label1.Text = "Framework";
            // 
            // btnRun
            // 
            btnRun.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnRun.Location = new System.Drawing.Point(1102, 107);
            btnRun.Name = "btnRun";
            btnRun.Size = new System.Drawing.Size(73, 30);
            btnRun.TabIndex = 3;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox2.Location = new System.Drawing.Point(170, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(924, 27);
            textBox2.TabIndex = 2;
            textBox2.Text = "net8.0-windows7.0";
            // 
            // BtnSelect
            // 
            BtnSelect.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            BtnSelect.Location = new System.Drawing.Point(1102, 10);
            BtnSelect.Name = "BtnSelect";
            BtnSelect.Size = new System.Drawing.Size(73, 30);
            BtnSelect.TabIndex = 1;
            BtnSelect.Text = "...";
            BtnSelect.UseVisualStyleBackColor = true;
            BtnSelect.Click += BtnSelect_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox1.Location = new System.Drawing.Point(171, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(923, 27);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(3, 216);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1184, 262);
            panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1198, 514);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new System.Drawing.Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(1190, 481);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Create New Graph";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pnlLoadExisting);
            tabPage2.Controls.Add(btnOpenGraph);
            tabPage2.Location = new System.Drawing.Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(1190, 481);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Load Existing Graph";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlLoadExisting
            // 
            pnlLoadExisting.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlLoadExisting.Location = new System.Drawing.Point(8, 42);
            pnlLoadExisting.Name = "pnlLoadExisting";
            pnlLoadExisting.Size = new System.Drawing.Size(1174, 436);
            pnlLoadExisting.TabIndex = 15;
            // 
            // Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1198, 514);
            Controls.Add(tabControl1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form";
            Text = "Nuget Dependencies Grpah";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDependenciesName;
        private System.Windows.Forms.Button btnOpenGraph;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlLoadExisting;
    }
}

