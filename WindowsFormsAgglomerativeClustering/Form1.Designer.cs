
namespace WindowsFormsAgglomerativeClustering
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageCharts = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSetLimits = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownYmax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownXmax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYmin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownXmin = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTimeValue = new System.Windows.Forms.Label();
            this.labelSilhouetteValue = new System.Windows.Forms.Label();
            this.labelSilhouetteLabel = new System.Windows.Forms.Label();
            this.labelTimeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLinkage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonClusterize = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.checkBoxStandardize = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.openFileDialogData = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.tabPageCharts.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXmin)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPageData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageCharts);
            this.tabControl.Controls.Add(this.tabPageData);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.ItemSize = new System.Drawing.Size(50, 20);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(884, 561);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageCharts
            // 
            this.tabPageCharts.Controls.Add(this.panel1);
            this.tabPageCharts.Controls.Add(this.chart1);
            this.tabPageCharts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageCharts.Location = new System.Drawing.Point(4, 24);
            this.tabPageCharts.Name = "tabPageCharts";
            this.tabPageCharts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCharts.Size = new System.Drawing.Size(876, 533);
            this.tabPageCharts.TabIndex = 0;
            this.tabPageCharts.Text = "Charts";
            this.tabPageCharts.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxLinkage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.buttonClusterize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(594, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 527);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSetLimits);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericUpDownYmax);
            this.groupBox2.Controls.Add(this.numericUpDownXmax);
            this.groupBox2.Controls.Add(this.numericUpDownYmin);
            this.groupBox2.Controls.Add(this.numericUpDownXmin);
            this.groupBox2.Location = new System.Drawing.Point(4, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 177);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Limits";
            // 
            // buttonSetLimits
            // 
            this.buttonSetLimits.Location = new System.Drawing.Point(-1, 141);
            this.buttonSetLimits.Name = "buttonSetLimits";
            this.buttonSetLimits.Size = new System.Drawing.Size(262, 30);
            this.buttonSetLimits.TabIndex = 8;
            this.buttonSetLimits.Text = "Set";
            this.buttonSetLimits.UseVisualStyleBackColor = true;
            this.buttonSetLimits.Click += new System.EventHandler(this.buttonSetLimits_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "X";
            // 
            // numericUpDownYmax
            // 
            this.numericUpDownYmax.DecimalPlaces = 3;
            this.numericUpDownYmax.Location = new System.Drawing.Point(163, 95);
            this.numericUpDownYmax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownYmax.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownYmax.Name = "numericUpDownYmax";
            this.numericUpDownYmax.Size = new System.Drawing.Size(100, 29);
            this.numericUpDownYmax.TabIndex = 3;
            // 
            // numericUpDownXmax
            // 
            this.numericUpDownXmax.DecimalPlaces = 3;
            this.numericUpDownXmax.Location = new System.Drawing.Point(163, 60);
            this.numericUpDownXmax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownXmax.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownXmax.Name = "numericUpDownXmax";
            this.numericUpDownXmax.Size = new System.Drawing.Size(100, 29);
            this.numericUpDownXmax.TabIndex = 2;
            // 
            // numericUpDownYmin
            // 
            this.numericUpDownYmin.DecimalPlaces = 3;
            this.numericUpDownYmin.Location = new System.Drawing.Point(61, 95);
            this.numericUpDownYmin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownYmin.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownYmin.Name = "numericUpDownYmin";
            this.numericUpDownYmin.Size = new System.Drawing.Size(100, 29);
            this.numericUpDownYmin.TabIndex = 1;
            // 
            // numericUpDownXmin
            // 
            this.numericUpDownXmin.DecimalPlaces = 3;
            this.numericUpDownXmin.Location = new System.Drawing.Point(61, 60);
            this.numericUpDownXmin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownXmin.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownXmin.Name = "numericUpDownXmin";
            this.numericUpDownXmin.Size = new System.Drawing.Size(100, 29);
            this.numericUpDownXmin.TabIndex = 0;
            this.numericUpDownXmin.ValueChanged += new System.EventHandler(this.numericUpDownXmin_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTimeValue);
            this.groupBox1.Controls.Add(this.labelSilhouetteValue);
            this.groupBox1.Controls.Add(this.labelSilhouetteLabel);
            this.groupBox1.Controls.Add(this.labelTimeLabel);
            this.groupBox1.Location = new System.Drawing.Point(4, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 92);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // labelTimeValue
            // 
            this.labelTimeValue.AutoSize = true;
            this.labelTimeValue.Location = new System.Drawing.Point(95, 25);
            this.labelTimeValue.Name = "labelTimeValue";
            this.labelTimeValue.Size = new System.Drawing.Size(0, 21);
            this.labelTimeValue.TabIndex = 3;
            // 
            // labelSilhouetteValue
            // 
            this.labelSilhouetteValue.AutoSize = true;
            this.labelSilhouetteValue.Location = new System.Drawing.Point(95, 55);
            this.labelSilhouetteValue.Name = "labelSilhouetteValue";
            this.labelSilhouetteValue.Size = new System.Drawing.Size(0, 21);
            this.labelSilhouetteValue.TabIndex = 2;
            // 
            // labelSilhouetteLabel
            // 
            this.labelSilhouetteLabel.AutoSize = true;
            this.labelSilhouetteLabel.Location = new System.Drawing.Point(6, 55);
            this.labelSilhouetteLabel.Name = "labelSilhouetteLabel";
            this.labelSilhouetteLabel.Size = new System.Drawing.Size(83, 21);
            this.labelSilhouetteLabel.TabIndex = 1;
            this.labelSilhouetteLabel.Text = "Silhouette:";
            // 
            // labelTimeLabel
            // 
            this.labelTimeLabel.AutoSize = true;
            this.labelTimeLabel.Location = new System.Drawing.Point(6, 25);
            this.labelTimeLabel.Name = "labelTimeLabel";
            this.labelTimeLabel.Size = new System.Drawing.Size(51, 21);
            this.labelTimeLabel.TabIndex = 0;
            this.labelTimeLabel.Text = "Time: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Linkage:";
            // 
            // comboBoxLinkage
            // 
            this.comboBoxLinkage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxLinkage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxLinkage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLinkage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxLinkage.FormattingEnabled = true;
            this.comboBoxLinkage.Items.AddRange(new object[] {
            "Ward",
            "Single",
            "Average",
            "SimpleAverageLinkage",
            "Complete"});
            this.comboBoxLinkage.Location = new System.Drawing.Point(94, 46);
            this.comboBoxLinkage.Name = "comboBoxLinkage";
            this.comboBoxLinkage.Size = new System.Drawing.Size(179, 29);
            this.comboBoxLinkage.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clusters:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Location = new System.Drawing.Point(94, 4);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(179, 29);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buttonClusterize
            // 
            this.buttonClusterize.Location = new System.Drawing.Point(3, 81);
            this.buttonClusterize.Name = "buttonClusterize";
            this.buttonClusterize.Size = new System.Drawing.Size(271, 30);
            this.buttonClusterize.TabIndex = 0;
            this.buttonClusterize.Text = "Clusterize";
            this.buttonClusterize.UseVisualStyleBackColor = true;
            this.buttonClusterize.Click += new System.EventHandler(this.buttonClusterize_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(7, 7);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(581, 518);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.AxisViewChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ViewEventArgs>(this.chart1_AxisViewChanged);
            // 
            // tabPageData
            // 
            this.tabPageData.Controls.Add(this.checkBoxStandardize);
            this.tabPageData.Controls.Add(this.dataGridView1);
            this.tabPageData.Controls.Add(this.buttonLoad);
            this.tabPageData.Controls.Add(this.buttonBrowse);
            this.tabPageData.Controls.Add(this.textBoxPath);
            this.tabPageData.Controls.Add(this.labelPath);
            this.tabPageData.Location = new System.Drawing.Point(4, 24);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageData.Size = new System.Drawing.Size(876, 533);
            this.tabPageData.TabIndex = 1;
            this.tabPageData.Text = "Data";
            this.tabPageData.UseVisualStyleBackColor = true;
            // 
            // checkBoxStandardize
            // 
            this.checkBoxStandardize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxStandardize.AutoSize = true;
            this.checkBoxStandardize.Location = new System.Drawing.Point(746, 38);
            this.checkBoxStandardize.Name = "checkBoxStandardize";
            this.checkBoxStandardize.Size = new System.Drawing.Size(96, 21);
            this.checkBoxStandardize.TabIndex = 5;
            this.checkBoxStandardize.Text = "Standardize";
            this.checkBoxStandardize.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(8, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(862, 457);
            this.dataGridView1.TabIndex = 4;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoad.Location = new System.Drawing.Point(746, 6);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(122, 26);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(617, 6);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(123, 26);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPath.Location = new System.Drawing.Point(96, 7);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(515, 23);
            this.textBoxPath.TabIndex = 1;
            this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // labelPath
            // 
            this.labelPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(8, 10);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(77, 17);
            this.labelPath.TabIndex = 0;
            this.labelPath.Text = " Path to file:";
            // 
            // openFileDialogData
            // 
            this.openFileDialogData.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Agglomerative Clustering";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageCharts.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXmin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPageData.ResumeLayout(false);
            this.tabPageData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageCharts;
        private System.Windows.Forms.TabPage tabPageData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialogData;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBoxStandardize;
        private System.Windows.Forms.Button buttonClusterize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBoxLinkage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSilhouetteLabel;
        private System.Windows.Forms.Label labelTimeLabel;
        private System.Windows.Forms.Label labelTimeValue;
        private System.Windows.Forms.Label labelSilhouetteValue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownYmax;
        private System.Windows.Forms.NumericUpDown numericUpDownXmax;
        private System.Windows.Forms.NumericUpDown numericUpDownYmin;
        private System.Windows.Forms.NumericUpDown numericUpDownXmin;
        private System.Windows.Forms.Button buttonSetLimits;
    }
}

