﻿using System;
using System.Collections.Generic;

using System.Globalization;
using System.Linq;


using System.Windows.Forms;
using OxyPlot;

using OxyPlot.Axes;
using OxyPlot.Series;



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
            //point.Add(new Point("Nha", 10, 25));



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
        private void tinhkhoangcach123()
        {
            a = new int[point.Count, point.Count];
            double kc = 0;
            DateTime time;
            for (int i = 0; i < point.Count; i++)
            {
                int x = layx(i);
                int y = layy(i);
                if (dt_to.Checked == true)
                {
                    if (thoigian[i] != string.Empty)
                    {
                        time = DateTime.Parse(thoigian[i]);
                        if (time > DateTime.Parse(thoigian[0]))
                        {

                            //ddang lam 
                        }
                    }
                }

                for (int j = 0; j < point.Count; j++)
                {
                    kc = (Math.Round((Math.Sqrt((((x - point[j].X) * (x - point[j].X)) + ((y - point[j].Y) * (y - point[j].Y))))), 0));
                    // MessageBox.Show(kc.ToString());
                    a[i, j] = (int)kc;

                }
            }

            for (int i = 0; i < point.Count; i++)
            {
                richTextBox1.Text += "\n";
                //richTextBox1.Text += point[i].tendiem;
                for (int j = 0; j < point.Count; j++)
                {

                    //richTextBox1.Text += point[i].tendiem;
                    richTextBox1.Text += "       " + ChuyenDoi(a[i, j]);

                }
            }

        }
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
                    a[i, j] = (int)kc;

                }
            }

            for (int i = 0; i < point.Count; i++)
            {
                richTextBox1.Text += "\n";
                //richTextBox1.Text += point[i].tendiem;
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
            if (point.Count == 0)
            {
                if (txtđiaiem.Text == "")
                {
                    MessageBox.Show("Nhập địa điểm đến.");
                }
                else
                {
                    if (txtx.Text == "")
                    {
                        MessageBox.Show("Nhập toạ độ X", "Thông báo");
                    }
                    else if (txty.Text == "")
                    {
                        MessageBox.Show("Nhập toạ độ Y", "Thông báo");
                    }
                    else
                    {

                        var seriesVisible = new OxyPlot.Series.LineSeries();
                        point.Add(new Point(txtđiaiem.Text, int.Parse(txtx.Text), int.Parse(txty.Text), dt_to.ToString()));
                        seriesVisible.Points.Add(new DataPoint(int.Parse(txtx.Text), int.Parse(txty.Text)));
                        seriesVisible.MarkerFill = OxyColors.Blue;
                        seriesVisible.MarkerType = MarkerType.Circle;
                        seriesVisible.MarkerSize = 4;
                        seriesVisible.StrokeThickness = 0;
                        ////this.pm.Series.Add(seriesComplete);
                        this.pm.Series.Add(seriesVisible);
                        pm.InvalidatePlot(true);


                        txtđiaiem.Clear();
                        txtx.Clear();
                        txty.Clear();
                    }
                }
            }
            else
            {
                if (txtđiaiem.Text == "")
                    MessageBox.Show("Nhập địa điểm đến.");
                else
                {
                    if (txtx.Text == "")
                    {
                        MessageBox.Show("Nhập toạ độ X", "Thông báo");
                    }
                    else if (txty.Text == "")
                    {
                        MessageBox.Show("Nhập toạ độ Y", "Thông báo");
                    }
                    else
                    {
                        //Random _r = new Random();
                        //int m = _r.Next(0, 500);
                        //int n = _r.Next(0, 500);
                        int x_val = int.Parse(txtx.Text);
                        int y_val = int.Parse(txty.Text);


                        point.Add(new Point(txtđiaiem.Text, x_val, y_val, dt_to.ToString()));
                        txtđiaiem.Clear();

                        for (int j = 0; j < point.Count - 1; j++)
                        {
                            int x = layx(j);
                            int y = layy(j);
                            int x1 = layx(j + 1);
                            int y1 = layy(j + 1);
                            DataPoint[] points = new DataPoint[]
                            {

                            // new DataPoint(layx(0),layy(0)),
                             new DataPoint(x,y),
                             new DataPoint(x1,y1),
                             //new DataPoint(x1,y1),
                             //new DataPoint(layx(0),layy(0)),

                            };



                            var seriesComplete = new OxyPlot.Series.LineSeries();
                            // seriesComplete.MarkerFill=OxyColor.ColorDifference.
                            //seriesComplete.MarkerFill = OxyColor.FromUInt32(OxyColor.);
                            seriesComplete.Points.AddRange(points);



                            var seriesVisible = new OxyPlot.Series.LineSeries();
                            seriesVisible.Points.AddRange(points);

                            seriesVisible.MarkerFill = OxyColors.Blue;
                            //   seriesVisible.Color=OxyColor
                            seriesVisible.MarkerType = MarkerType.Circle;
                            seriesVisible.MarkerSize = 4;
                            seriesVisible.StrokeThickness = 0;
                            this.pm.Series.Add(seriesComplete);
                            this.pm.Series.Add(seriesVisible);
                            pm.InvalidatePlot(true);


                            txtđiaiem.Clear();
                            txtx.Clear();
                            txty.Clear();
                        }

                    }
                }
            }
        }
        int[] visit = new int[100];
        int[] lotrinh = new int[100];
        //double n= ;
        int dem = 0;
        int gia = 0;
        DateTime thg;
        void tim_canh123(int begin)
        {
            int i, j, temp = 0;
            int min;
            i = begin;
            visit[i] = 1;
            lotrinh[0] = i;
            //    thoigian[0] = dt_from.Text;
            while (dem != point.Count)
            {
                min = 1000;
                for (j = 0; j <= point.Count - 1; j++)
                {
                    if (thoigian[i + 1] != string.Empty && dt_to.Checked == true)
                    {
                        thg = DateTime.Parse(thoigian[i + 1]);
                        if (DateTime.Compare(thg, DateTime.Parse(thoigian[i + 1])) < 0)
                        {
                            thg = DateTime.Parse(thoigian[i + 1]);

                            if (a[i, j] < min && a[i, j] > 0 && visit[i] != visit[j])
                            {
                                min = a[i + 1, j];
                                temp = j;
                            }
                        }
                    } else
                    {
                        if (a[i, j] < min && a[i, j] > 0 && visit[i] != visit[j])
                        {
                            min = a[i, j];
                            temp = j;
                        }
                    }
                }

                gia = gia + a[i, temp];
                i = temp;              //chon temp dc chon lam tpho de tiep tuc duyet
                visit[temp] = 1;       //da duyet thanh pho temp
                lotrinh[dem + 1] = temp; //ghi thanh pho temp vao lo trinh
                dem++;
            }



            gia += a[temp, 0];
            lotrinh[dem] = begin;

        }

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
                for (j = 0; j <= point.Count - 1; j++)
                {
                    if (a[i, j] < min && a[i, j] > 0 && visit[i] != visit[j])
                    {
                        min = a[i, j];
                        temp = j;
                    }
                }

                gia = gia + a[i, temp];
                i = temp;              //chon temp dc chon lam tpho de tiep tuc duyet
                visit[temp] = 1;       //da duyet thanh pho temp
                lotrinh[dem + 1] = temp; //ghi thanh pho temp vao lo trinh
                dem++;
            }



            gia += a[temp, 0];
            lotrinh[dem] = begin;

        }

        private void plotView1_MouseDown(object sender, MouseEventArgs e)
        {
            // MouseEvents();
            //    this.Cursor = new Cursor(Cursor.Current.Handle);
            //    int posX = Cursor.Position.X;
            //    int posY = Cursor.Position.Y;
            //    double x = 1;
            //    double y = 1;
            //    var s1 = new OxyPlot.Series.LineSeries();
            //    s1.MouseDown += (s, e1) =>
            //    {
            //        x = (s as LineSeries).InverseTransform(e1.Position).X;
            //        y = (s as LineSeries).InverseTransform(e1.Position).Y;
            //    };
            //    txtx.Text = x.ToString();
            //    txty.Text = y.ToString();
        }

        private void plotView1_Click(object sender, EventArgs e)
        {
            MouseEvents();
            // this.pm.Series.Add(seriesVisible);
            // pm.InvalidatePlot(true);
            //this.Cursor = new Cursor(Cursor.Current.Handle);
            //int posX = Cursor.Position.X;
            //int posY = Cursor.Position.Y;
            //var s1 = new OxyPlot.Series.LineSeries();
            //s1.MouseDown += (s, e1) =>
            //{
            //    posX = (int)(s as LineSeries).InverseTransform(e1.Position).X;
            //    posY = (int)(s as LineSeries).InverseTransform(e1.Position).Y;
            //};
            //txtx.Text = posX.ToString();
            //txty.Text = posY.ToString();
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

            pm.InvalidatePlot(true);
            tinhkhoangcach();
            //  tim_canh123(0);
            tim_canh(0);
            for (int i = 0; i < point.Count; i++)
            {
                if (i == point.Count - 1)
                {
                    rtbLog.Text += lotrinh[i] + "-> 0";
                }
                else
                {
                    rtbLog.Text += lotrinh[i] + "->";
                }
                //rtbLog.Text +=lotrinh[i]+"->";
            }
            // MessageBox.Show(point.Count.ToString());
            MessageBox.Show("Lộ trình cần đi là: " + gia.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void plotView1_MouseMove(object sender, MouseEventArgs e)
        {
            OxyPlot.ScreenPoint screenPoint;
            int x, y;

            x = System.Windows.Forms.Cursor.Position.X;
            y = System.Windows.Forms.Cursor.Position.Y;


            screenPoint = new ScreenPoint(x, y);
            Axis.InverseTransform(screenPoint, Xaxis, Yaxis);

        }
        string[] thoigian;

        //public PlotModel MouseEvents()
        //{

        //    //var s1;
        //    //int x, y;
        //    pm.MouseDown += (s, e) =>
        //    {
        //        // thoigian[0] = dt_from.Text;
        //        string dt;
        //        int x, y;
        //        int i = 0;

        //        var s1 = new OxyPlot.Series.LineSeries();
        //        s1.MarkerType = MarkerType.Circle;
        //        s1.StrokeThickness = 0;

        //        s1.Color = OxyColors.LightBlue;
        //        s1.MarkerFill = OxyColors.Blue;
        //        s1.MarkerSize = 5;


        //        x = (int)Math.Round((Xaxis.InverseTransform(e.Position.X, e.Position.Y, Yaxis).X), 0);
        //        y = (int)Math.Round((Xaxis.InverseTransform(e.Position.X, e.Position.Y, Yaxis).Y), 0);

        //        if (dt_to.Checked == true)
        //        {
        //            dt = dt_to.Value.ToShortTimeString().ToString();
        //            thoigian[i] = dt;
        //        }
        //        else
        //        {
        //            dt = string.Empty;
        //        }

        //        point.Add(new Point(txtđiaiem.Text, x, y, dt));

        //        s1.Points.Add(Xaxis.InverseTransform(e.Position.X, e.Position.Y, Yaxis));
        //        pm.Series.Add(s1);
        //        pm.InvalidatePlot(true);
        //        e.Handled = true;
        //        i++;

        //        //txtx.Text = x.ToString();
        //        //txty.Text = y.ToString();
        //        //  x = (s as LineSeries).InverseTransform(e.Position).X;
        //        //MessageBox.Show(dt_to.Text+" => "+ DateTime.Now.ToShortTimeString().ToString());

        //        MessageBox.Show(e.Position.X.ToString() + " , " + e.Position.Y.ToString() + "=>" + x + " , " + y);

        //        //txtđiaiem.Clear();
        //        //txtx.Clear();
        //        //txty.Clear();

        //    };

        //    return pm;
        //}


        //nhap

        public PlotModel MouseEvents()
        {

            //var s1;
            //int x, y;
            pm.MouseDown += (s, e) =>
            {
                // thoigian[0] = dt_from.Text;
                string dt;
                int x, y;
                int i = 0;

                x = (int)Math.Round((Xaxis.InverseTransform(e.Position.X, e.Position.Y, Yaxis).X), 0);
                y = (int)Math.Round((Xaxis.InverseTransform(e.Position.X, e.Position.Y, Yaxis).Y), 0);

                if (point.Count == 0)
                {
                   
                        

                            var seriesVisible = new OxyPlot.Series.LineSeries();
                            point.Add(new Point(txtđiaiem.Text, x, y,dt_to.ToString()));
                            seriesVisible.Points.Add(new DataPoint(x, y));
                            seriesVisible.MarkerFill = OxyColors.Blue;
                            seriesVisible.MarkerType = MarkerType.Circle;
                            seriesVisible.MarkerSize = 4;
                            seriesVisible.StrokeThickness = 0;
                            ////this.pm.Series.Add(seriesComplete);
                            this.pm.Series.Add(seriesVisible);
                            pm.InvalidatePlot(true);


                            txtđiaiem.Clear();
                            txtx.Clear();
                            txty.Clear();
                       
                }
                else
                {
                    
                            //Random _r = new Random();
                            //int m = _r.Next(0, 500);
                            //int n = _r.Next(0, 500);

                            //int x_val = int.Parse(txtx.Text);
                            //int y_val = int.Parse(txty.Text);


                            point.Add(new Point(txtđiaiem.Text, x, y,dt_to.ToString()));
                            txtđiaiem.Clear();

                    for (int j = 0; j < point.Count - 1; j++)
                    {
                        int xx = layx(j);
                        int yy = layy(j);
                        int x1 = layx(j + 1);
                        int y1 = layy(j + 1);
                        DataPoint[] points = new DataPoint[]
                        {

                            // new DataPoint(layx(0),layy(0)),
                             new DataPoint(xx,yy),
                             new DataPoint(x1,y1),
                            //new DataPoint(x1,y1),
                            //new DataPoint(layx(0),layy(0)),

                        };



                        var seriesComplete = new OxyPlot.Series.LineSeries();
                        // seriesComplete.MarkerFill=OxyColor.ColorDifference.
                        //seriesComplete.MarkerFill = OxyColor.FromUInt32(OxyColor.);
                        seriesComplete.Points.AddRange(points);
                        // seriesComplete.MarkerFill=OxyColor.ColorDifference(OxyColor x,)



                        var seriesVisible = new OxyPlot.Series.LineSeries();
                        seriesVisible.Points.AddRange(points);
                        
                        seriesVisible.MarkerFill = OxyColors.Blue;
                        seriesVisible.LineStyle = LineStyle.Solid;
                        seriesVisible.MarkerType = MarkerType.Circle;
                        seriesVisible.MarkerSize = 4;
                        seriesVisible.StrokeThickness = 0;
                        this.pm.Series.Add(seriesComplete);
                        this.pm.Series.Add(seriesVisible);
                        pm.InvalidatePlot(true);

                        //if (g == 1)
                        //{
                        //    seriesVisible.ItemsSource = null;
                        //    point.Clear();
                        //    plotView1.Refresh();
                        //}

                        txtđiaiem.Clear();
                        txtx.Clear();
                        txty.Clear();
                    }
                }
                MessageBox.Show(e.Position.X.ToString() + " , " + e.Position.Y.ToString() + "=>" + x + " , " + y);

            };
           // point.Clear();
            return pm;
        }

        int g;
        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            gia =1;
            PlotModel pm = new PlotModel();
            List<Point> point = new List<Point>();
            LinearAxis Xaxis = new LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot, Minimum = 0, Maximum = 500 };
            LinearAxis Yaxis = new LinearAxis { Position = AxisPosition.Left, MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot, Minimum = 0, Maximum = 500 };

            pm.Axes.Add(Xaxis);
            pm.Axes.Add(Yaxis);

            plotView1.Model = pm;
            this.plotView1.Model = pm;



            richTextBox1.Clear();
            rtbLog.Clear();
            point.Clear();
           // pm.Series.Clear();


            plotView1.Refresh();

           // loadlai();



        }
        public void loadlai()
        {
            PlotModel pm = new PlotModel();
            List<Point> point = new List<Point>();
            LinearAxis Xaxis = new LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot, Minimum = 0, Maximum = 500 };
            LinearAxis Yaxis = new LinearAxis { Position = AxisPosition.Left, MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot, Minimum = 0, Maximum = 500 };

            pm.Axes.Add(Xaxis);
            pm.Axes.Add(Yaxis);
        }
    }
}
