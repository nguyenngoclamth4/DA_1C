﻿using System;
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
        LinearAxis Xaxis = new LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot, Minimum = 0, Maximum = 500 };
        LinearAxis Yaxis = new LinearAxis { Position = AxisPosition.Left, MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot, Minimum = 0, Maximum = 500 };
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // this.Controls.Add(plotView1);
            point.Add(new Point("Nha", 10, 25));

            pm.Axes.Add(Xaxis);
            pm.Axes.Add(Yaxis);

            plotView1.Model = pm;
            this.plotView1.Model = pm;
        }

        public string[] Lines { get; set; }

        public void ViewMyTextBoxContents()
        {
            // Create a string array and store the contents of the Lines property.
            string[] tempArray = txtđiaiem.Lines;

            // Loop through the array and send the contents of the array to debug window.
            for (int counter = 0; counter < tempArray.Length; counter++)
            {
                System.Diagnostics.Debug.WriteLine(tempArray[counter]);
            }
        }
        private int layx(int i)
        {
            int x = point[i].X;
            return x;
        }
        private int layy(int i)
        {


            int y = point[i].Y;
            return y;
        }
        int[,] a;
        private void tinhkhoangcach()
        {
            a = new int[point.Count, point.Count];
            double kc = 0;
            for (int i = 0; i < point.Count; i++)
            {
                int x = layx(i);
                int y = layy(i);
                for (int j = 0; j < point.Count; j++)
                {
                    kc = (Math.Round((Math.Sqrt((((x - point[j].X) * (x - point[j].X)) + ((y - point[j].Y) * (y - point[j].Y))))), 0));
                   // MessageBox.Show(kc.ToString());
                    a[i, j] =(int)kc;

                }
            }

            for (int i = 0; i < point.Count; i++)
            {
                richTextBox1.Text += "\n";
                richTextBox1.Text += point[i].tendiem;
                for (int j = 0; j < point.Count; j++)
                {

                    //richTextBox1.Text += point[i].tendiem;
                    richTextBox1.Text += "       " + ChuyenDoi(a[i, j]);

                }
            }
               
        }

        private void CopyArrayToListView(ListView lvw, double[,] data)
        {
            int max_row = data.GetUpperBound(0);
            int max_col = data.GetUpperBound(1);
            for (int row = 0; row <= max_row; row++)
            {
                ListViewItem new_item = lvw.Items.Add(data[row, 0].ToString());
                for (int col = 1; col <= max_col; col++)
                {
                    new_item.SubItems.Add(data[row, col].ToString());
                }
            }
        }
        

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            if (txtđiaiem.Text == "")
                MessageBox.Show("Nhập địa điểm đến.");
            else
            {
                Random _r = new Random();
                int m = _r.Next(0, 500);
                int n = _r.Next(0, 500);
                int x_val = n;
                int y_val = m;
                
               
                point.Add(new Point(txtđiaiem.Text, x_val, y_val));
                txtđiaiem.Clear();
              
                for (int j = 0; j < point.Count - 1; j++)
                {
                    int x = layx(j);
                    int y = layy(j);
                    int x1 = layx(j + 1);
                    int y1 = layy(j + 1);
                    DataPoint[] points = new DataPoint[]
                    {
                
                         new DataPoint(layx(0),layy(0)),
                         new DataPoint(x,y),
                         new DataPoint(x1,y1),
                         new DataPoint(x1,y1),
                         new DataPoint(layx(0),layy(0)),

                    };


                    
                    var seriesComplete = new OxyPlot.Series.LineSeries();

                        seriesComplete.Points.AddRange(points);
                   


                    var seriesVisible = new OxyPlot.Series.LineSeries();
                        seriesVisible.Points.AddRange(points);
                   
                    seriesVisible.MarkerFill = OxyColors.Blue;
                        seriesVisible.MarkerType = MarkerType.Circle;
                        seriesVisible.MarkerSize = 4;
                        seriesVisible.StrokeThickness = 0;
                        this.pm.Series.Add(seriesComplete);
                        this.pm.Series.Add(seriesVisible);
                        pm.InvalidatePlot(true);


                        txtđiaiem.Clear();
                    }
               
            }
        }
        int[] visit = new int[100];
        int[] lotrinh = new int[100];
        //double n= ;
        int dem = 0;
        int gia = 0;
        // xử lý
        void tim_canh(int begin)
        {
            int i, j, temp = 0;
            int min;
            i = begin;
            visit[i] = 1;
            lotrinh[0] = i;
            while (dem != point.Count)
            {
                min = 1000;
                for (j = 0; j <= point.Count-1; j++)
                {
                    if (a[i, j] < min && a[i, j] > 0 && visit[i]!= visit[j])
                    {
                        min = a[i, j];
                        temp = j;
                    }
                }

                gia = gia + a[i,temp];
                i = temp;              //chon temp dc chon lam tpho de tiep tuc duyet
                visit[temp] = 1;       //da duyet thanh pho temp
                lotrinh[dem + 1] = temp; //ghi thanh pho temp vao lo trinh
                dem++;
            }

            gia += a[temp,1];
            lotrinh[dem] =begin;

        }

        private void plotView1_MouseDown(object sender, MouseEventArgs e)
        {
            var model = new PlotModel { Title = "Test Mouse Events" };
            var s1 = new LineSeries();
            model.Series.Add(s1);
            double x;
            s1.MouseDown += (s, ex) =>
            {
                txtđiaiem.Text = ((s as LineSeries).InverseTransform(ex.Position).X).ToString();
            };
        }

        private void plotView1_MouseClick(object sender, MouseEventArgs e)
        {
            var model = new PlotModel { Title = "Test Mouse Events" };
            var s1 = new LineSeries();
            model.Series.Add(s1);
            double x;
            s1.MouseDown += (s, ex) =>
            {
                txtđiaiem.Text = ((s as LineSeries).InverseTransform(ex.Position).X).ToString();
            };
            
        }

        private void plotView1_Click(object sender, EventArgs e)
        {
            //var series1 = new OxyPlot.Series.LineSeries
            //{
            //    StrokeThickness = 1,
            //    MarkerSize = 1,
            //};
            //Random _r = new Random();
            //int m = _r.Next(0, 500);
            //int n = _r.Next(0, 500);
            //int x_val = n;
            //int y_val = m;
            //point.Add(new Point(txtđiaiem.Text, x_val, y_val));
            //series1.Points.Add(new DataPoint(x_val, y_val));
            //series1.Color = OxyColors.LightBlue;
            //series1.LabelFormatString = txtđiaiem.Text;
            //series1.Tag = 1;
            //pm.Series.Add(series1);
            //series1.Color = OxyColors.LightBlue;
            //series1.MarkerFill = OxyColors.Blue;
            //series1.MarkerType = OxyPlot.MarkerType.Circle;
            //series1.MarkerSize = 5;
         
            //pm.InvalidatePlot(true);
            ////taomatran(5);
            ////richTextBox1.SelectedText = Environment.NewLine + x_val + y_val;

            //txtđiaiem.Clear();
            //// taomang2chieu(x_val,y_val);
        }

        private void btntinhtoan_Click(object sender, EventArgs e)
        {
        
            tinhkhoangcach();
            tim_canh(1);
            for (int i = 0; i < point.Count; i++)
            {
                rtbLog.Text +=lotrinh[i]+"->";
            }
            MessageBox.Show(gia.ToString());
            //printf("\n");
            //printf("\n Tong quang duong: %d", gia);
            //printf("\n\n An phim bat ki de thoat!");
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {

        }
        string ChuyenDoi(double so)
        {
            if (so == 0) return "∞";
            return so.ToString();
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
