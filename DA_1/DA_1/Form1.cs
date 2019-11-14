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
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;


namespace DA_1
{
    public partial class Form1 : Form
    {
        PlotModel pm = new PlotModel();
        List<Point> point = new List<Point>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // this.Controls.Add(plotView1);
            LinearAxis Xaxis = new LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot, Minimum = 0, Maximum = 200 };
            LinearAxis Yaxis = new LinearAxis { Position = AxisPosition.Left, MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot, Minimum = 0, Maximum = 200};
 
            pm.Axes.Add(Xaxis);
            pm.Axes.Add(Yaxis);

            plotView1.Model = pm;
            this.plotView1.Model = pm; 
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtđiaiem.Text == "")
            {
                MessageBox.Show("Nhập địa điểm đến.");
            }
            else
            {
               
                var series1 = new OxyPlot.Series.LineSeries
                {
                    StrokeThickness = 1,
                    MarkerSize = 1,
                };
                Random _r = new Random();
                int m = _r.Next(0, 50);
                int n = _r.Next(0, 50);
                int x_val = n;
                int y_val = m;
                point.Add(new Point(txtđiaiem.Text, x_val,y_val));
                series1.Points.Add(new DataPoint(x_val, y_val));
                series1.Color = OxyColors.LightBlue;
                series1.LabelFormatString = txtđiaiem.Text;  
                series1.Tag = 1;
                pm.Series.Add(series1);
                series1.Color = OxyColors.LightBlue;
                series1.MarkerFill = OxyColors.Blue;
                series1.MarkerType = OxyPlot.MarkerType.Circle;
                series1.MarkerSize = 5;
                txtđiaiem.Clear();
                pm.InvalidatePlot(true);
            }
        }
        private int tinhkhoangcach()
        {
            int kc = 0;
            for (int i= 0; i < point.Count; i++)
            {
                for(int j = i+1; j <point.Count; j++)
                {
                    kc = ((point[j].X - point[i].X) * (point[j].X - point[i].X)) + ((point[j].Y - point[i].Y) * (point[j].Y - point[i].Y));
                }
            }
            return kc;
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

        private void btntinh_Click(object sender, EventArgs e)
        {
            int kq = tinhkhoangcach();
            MessageBox.Show(kq.ToString());
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            plotView1.Model.InvalidatePlot(true);
            plotView1.Model.Series.Clear();
        }
    }
}
