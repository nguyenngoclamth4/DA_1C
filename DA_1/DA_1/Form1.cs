using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;


namespace DA_1
{
    public partial class Form1 : Form
    {
        PlotModel pm = new PlotModel();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //PlotView pv = new PlotView();
            //plotView1.Dock = DockStyle.Fill;
            this.Controls.Add(plotView1);

            LinearAxis Xaxis = new LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot, Minimum = 0, Maximum = 200 };
            LinearAxis Yaxis = new LinearAxis { Position = AxisPosition.Left, MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot, Minimum = 0, Maximum = 200};
            //PlotModel pm = new PlotModel();

            pm.Axes.Add(Xaxis);
            pm.Axes.Add(Yaxis);

            plotView1.Model = pm;


            this.plotView1.Model = pm; //plot1 is an object of PlotView
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtđiaiem.Text == "")
            {
                MessageBox.Show("Nhập địa điểm đến.");
            }
            else
            {
                int cot = 500;
                int dong = 500;
                //plotView1.Model.Series.Add(getFuntion());
                int[,] scores = new int[cot, dong];
                var series1 = new LineSeries
                {
                    StrokeThickness = 1,
                    MarkerSize = 1,
                };
                Random _r = new Random();
                int m = _r.Next(0, 50);
                int n = _r.Next(0, 50);
                int x_val = n;
                int y_val = m;

                //int x_val1 = n;
                //int y_val1 = scores[0, n];
                //"scores" is an array with my data
                // PlotModel pm = new PlotModel();
                series1.Points.Add(new DataPoint(x_val, y_val));
                //series1.Points.Add(new DataPoint(x_val1, y_val1));
                series1.Color = OxyColors.LightBlue;
                pm.Series.Add(series1);
                //var s1 = new LineSeries();

                series1.Color = OxyColors.LightBlue;
                series1.MarkerFill = OxyColors.Blue;
                series1.MarkerType = OxyPlot.MarkerType.Circle;
                series1.MarkerSize = 5;
                txtđiaiem.Clear();
                //plotView1.Model = pm;
                //this.plotView1.Model = pm;

            }
        }
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            DataPoint point = (DataPoint)values[0];
            List<DataPoint> points = ((IEnumerable<DataPoint>)values[1]).ToList();
            return (points.IndexOf(point) + 1).ToString() + "-  (" + point.X.ToString() + " , " + point.Y.ToString() + ")";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
