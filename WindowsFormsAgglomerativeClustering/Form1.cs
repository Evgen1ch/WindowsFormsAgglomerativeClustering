using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AgglomerativeClustering;
using AgglomerativeClustering.DataScaling;
using AgglomerativeClustering.Linkage;
using AgglomerativeClustering.Metrics;

namespace WindowsFormsAgglomerativeClustering
{
    public partial class Form1 : Form
    {

        private AgglomerativeClustering.AgglomerativeClustering _clustering;

        private Stopwatch _stopwatch = new Stopwatch();

        private IMetric _metric = new SilhouetteScore();

        private float[,] _data;

        private string _filename;

        private List<Color> colors = new List<Color>()
        {
            Color.Red,
            Color.DarkBlue,
            Color.Orange,
            Color.CornflowerBlue,
            Color.Yellow,
            Color.Green,
            Color.HotPink,
        };

        private readonly List<ILinkageLanceWilliams> LinkagesLanceWilliams = new List<ILinkageLanceWilliams>() {
            new WardLinkage(),
            new SingleLinkage(),
            new AverageLinkage(), 
            new SimpleAverageLinkage(),
            new CompleteLinkage(),
        };
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.comboBoxLinkage.SelectedIndex = 0;
            this.openFileDialogData.FileName = "";
            numericUpDownXmin.Increment = (decimal) 0.1;
            numericUpDownXmax.Increment = (decimal) 0.1;
            numericUpDownYmin.Increment = (decimal) 0.1;
            numericUpDownYmax.Increment = (decimal) 0.1;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogData.ShowDialog();
            if (result == DialogResult.OK)
            {
                _filename = openFileDialogData.FileName;
                textBoxPath.Text = _filename;
            }

            Console.WriteLine(result);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(_filename))
                MessageBox.Show(@"Enter path to file first");
            try
            {
                _data = DataReader.ReadCsv(_filename);

                //check if standardization required
                if (checkBoxStandardize.Checked)
                    _data = Standardization.Standardize(_data);

                int rows = _data.GetLength(0);
                int cols = _data.GetLength(1);
                
                //create data source
                DataTable table = new DataTable();
                table.Columns.Add(new DataColumn("index", typeof(int)));
                //table initialization
                for (int i = 0; i < cols; i++)
                {
                    var column = new DataColumn($"x{ i + 1 }", typeof(float));
                   table.Columns.Add(column);
                }

                //load data to table
                for (int i = 0; i < rows; i++)
                {
                    object[] row = new object[cols + 1];
                    row[0] = i;
                    for (int j = 0; j < cols; j++)
                    {
                        row[j + 1] = _data[i, j];
                    }
                    
                    table.Rows.Add(row);
                }


                numericUpDown1.Maximum = table.Rows.Count;
                dataGridView1.DataSource = table;
                var fakeLabels = Enumerable.Repeat(0, rows).ToList();
                DrawClusters(fakeLabels);
            }
            catch (Exception ex)
            {
                Console.WriteLine($@"Error when reading data: {ex.Message} in {ex.StackTrace}");
            }

        }

        private async void buttonClusterize_Click(object sender, EventArgs e)
        {
            if (_data == null || _data.GetLength(0) == 0)
            {
                MessageBox.Show(@"Please, load the data first");
                return;
            }

            ILinkageLanceWilliams linkage;
            if(comboBoxLinkage.SelectedIndex >= 0 && comboBoxLinkage.SelectedIndex < 5)
                linkage = LinkagesLanceWilliams[comboBoxLinkage.SelectedIndex];
            else
            {
                MessageBox.Show(@"Something went wrong with linkage");
                return;
            }

            int nClusters = (int)numericUpDown1.Value;
            _stopwatch.Reset();
            _stopwatch.Start();
            _clustering = new AgglomerativeClustering.AgglomerativeClustering(nClusters, linkage);
            List<int> labels = new List<int>(0);
            await Task.Run(() => labels = _clustering.FitPredict(_data));
            _stopwatch.Stop();
            labelTimeValue.Text = _stopwatch.Elapsed.TotalSeconds.ToString(CultureInfo.InvariantCulture) + @"s";
            labelSilhouetteValue.Text = _metric.Calculate(_data, labels.ToArray()).ToString(CultureInfo.InvariantCulture);
            DrawClusters(labels);
        }

        private void DrawClusters(List<int> labels)
        {
            if (_data == null || _data.GetLength(0) == 0)
                return;

            int rows = _data.GetLength(0);
            int cols = _data.GetLength(1);
            if (cols == 2)
            {
                var distinctLabels = labels.Distinct().ToList();
                List<int> labelCounts = new List<int>(distinctLabels.Count);
                for (int i = 0; i < distinctLabels.Count; i++)
                {
                    labelCounts.Add(labels.Count(i1 => i1 == distinctLabels[i]));
                }

                List<List<float[]>> clusters = new List<List<float[]>>(distinctLabels.Count);
                for (int i = 0; i < distinctLabels.Count; i++)
                {
                    var newClusterInfo = new List<float[]>();
                    newClusterInfo.Add(new float[labelCounts[i]]);
                    newClusterInfo.Add(new float[labelCounts[i]]);
                    clusters.Add(newClusterInfo);
                    //For the future
                    labelCounts[i] = 0;
                }
                
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < distinctLabels.Count; j++)
                    {
                        if(labels[i] == distinctLabels[j])
                        {
                            //добавить 
                            clusters[j][0][labelCounts[j]] = _data[i, 0];
                            clusters[j][1][labelCounts[j]] = _data[i, 1];
                            labelCounts[j]++;
                        }
                    }
                }

                chart1.Series.Clear();
                for (int i = 0; i < distinctLabels.Count; i++)
                {
                    Series toAdd = new Series(distinctLabels[i].ToString());
                    toAdd.Points.DataBindXY(clusters[i][0], clusters[i][1]);
                    toAdd.ChartType = SeriesChartType.Point;
                    toAdd.MarkerStyle = MarkerStyle.Circle;
                    toAdd.MarkerSize = 10;
                    chart1.Series.Add(toAdd);
                }

                chart1.ResetAutoValues();
                chart1.Titles.Clear();

                float minxy = Single.MaxValue;
                float maxxy = Single.MinValue;
                foreach (var cluster in clusters)
                {
                    foreach (var coords in cluster)
                    {
                        float min = coords.Min();
                        float max = coords.Max();
                        if (minxy > min)
                        {
                            minxy = min;
                        }

                        if (maxxy < max)
                        {
                            maxxy = max;
                        }
                    }
                }

                var area = chart1.ChartAreas[0];

                float delta = maxxy - minxy;
                area.AxisX.Maximum = area.AxisY.Maximum = maxxy + delta / 100;
                area.AxisY.Minimum = area.AxisX.Minimum = minxy - delta / 100;

                area.AxisX.Title = "x1";
                area.AxisY.Title = "x2";
                area.AxisY.MajorGrid.LineColor = Color.LightGray;
                area.AxisX.MajorGrid.LineColor = Color.LightGray;
                area.AxisX.LabelStyle.Format = area.AxisY.LabelStyle.Format = "{0:0.00}";
            }
            else
            {
                
                List<float[]> rowList = new List<float[]>(rows);
                for (int i = 0; i < rows; i++)
                {
                    float[] line = new float[cols];
                    for (int j = 0; j < cols; j++)
                    {
                        line[j] = _data[i, j];
                    }
                    rowList.Add(line);
                }

                chart1.Series.Clear();
                
                for (int i = 0; i < rowList.Count; i++)
                {
                    Series s = new Series();
                    for (int j = 0; j < cols; j++)
                    {
                        s.Points.AddY(rowList[i][j]);
                    }
                    s.ChartType = SeriesChartType.FastLine;
                    s.BorderWidth = 2;
                    s.Color = colors[labels[i] % colors.Count];

                    chart1.Series.Add(s);
                }

                float miny = float.MaxValue, maxy = float.MinValue;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (_data[i, j] > maxy)
                        {
                            maxy = _data[i, j];
                        }

                        if (_data[i, j] < miny)
                        {
                            miny = _data[i, j];
                        }
                    }
                }
                chart1.ChartAreas[0].AxisY.Minimum = miny - 1f;
                chart1.ChartAreas[0].AxisY.Maximum = maxy + 1f;

                chart1.Legends.Clear();
                chart1.ChartAreas[0].AxisX.Minimum = 1.0f;
                chart1.ChartAreas[0].AxisX.Maximum = cols;
                chart1.ChartAreas[0].AxisX.LabelStyle.Format = chart1.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0.00}";
            }
        }

        private void numericUpDownXmin_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonSetLimits_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Minimum = (double)numericUpDownXmin.Value;
            chart1.ChartAreas[0].AxisX.Maximum = (double)numericUpDownXmax.Value;
            chart1.ChartAreas[0].AxisY.Minimum = (double)numericUpDownYmin.Value;
            chart1.ChartAreas[0].AxisY.Maximum = (double)numericUpDownYmax.Value;
        }

        private void chart1_AxisViewChanged(object sender, ViewEventArgs e)
        {
            numericUpDownXmin.Value = (decimal)chart1.ChartAreas[0].AxisX.Minimum;
            numericUpDownXmax.Value = (decimal)chart1.ChartAreas[0].AxisX.Maximum;
            numericUpDownYmin.Value = (decimal)chart1.ChartAreas[0].AxisY.Minimum;
            numericUpDownYmax.Value = (decimal)chart1.ChartAreas[0].AxisY.Maximum;
        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {
            _filename = ((TextBox) sender).Text;
        }
    }
}
