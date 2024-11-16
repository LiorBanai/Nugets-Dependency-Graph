namespace ProcessDependency
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
            panel1.SuspendLayout();
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
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(742, 205);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 140);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(129, 20);
            label6.TabIndex = 13;
            label6.Text = "Show Only names:";
            // 
            // txtDependenciesName
            // 
            txtDependenciesName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtDependenciesName.Location = new System.Drawing.Point(250, 135);
            txtDependenciesName.Name = "txtDependenciesName";
            txtDependenciesName.Size = new System.Drawing.Size(406, 27);
            txtDependenciesName.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 173);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(135, 20);
            label5.TabIndex = 11;
            label5.Text = "Color Dependency:";
            // 
            // tbColor
            // 
            tbColor.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbColor.Location = new System.Drawing.Point(250, 168);
            tbColor.Name = "tbColor";
            tbColor.Size = new System.Drawing.Size(406, 27);
            tbColor.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(11, 108);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(159, 20);
            label4.TabIndex = 9;
            label4.Text = "Limit to Single project:";
            // 
            // textBox4
            // 
            textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox4.Location = new System.Drawing.Point(249, 103);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(406, 27);
            textBox4.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 11);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(156, 20);
            label3.TabIndex = 7;
            label3.Text = "project.assets.json file:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 75);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 20);
            label2.TabIndex = 6;
            label2.Text = "example:";
            // 
            // textBox3
            // 
            textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox3.Location = new System.Drawing.Point(174, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(482, 27);
            textBox3.TabIndex = 5;
            textBox3.Text = ".NETFramework,Version=v4.8  Or net8.0-windows7.0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 20);
            label1.TabIndex = 4;
            label1.Text = "Framework";
            // 
            // btnRun
            // 
            btnRun.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnRun.Location = new System.Drawing.Point(663, 103);
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
            textBox2.Location = new System.Drawing.Point(173, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(482, 27);
            textBox2.TabIndex = 2;
            textBox2.Text = "net8.0-windows7.0";
            // 
            // BtnSelect
            // 
            BtnSelect.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            BtnSelect.Location = new System.Drawing.Point(663, 6);
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
            textBox1.Location = new System.Drawing.Point(174, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(481, 27);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 205);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(742, 309);
            panel2.TabIndex = 1;
            // 
            // Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(742, 514);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form";
            Text = "Nuget Dependencies Grpah";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}

