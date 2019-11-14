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

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtđiaiem.Text == "")
                MessageBox.Show("Nhập địa điểm đến.");
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
                point.Add(new Point(txtđiaiem.Text, x_val, y_val));
                series1.Points.Add(new DataPoint(x_val, y_val));
                series1.Color = OxyColors.LightBlue;
                series1.LabelFormatString = txtđiaiem.Text;
                series1.Tag = 1;
                pm.Series.Add(series1);
                series1.Color = OxyColors.LightBlue;
                series1.MarkerFill = OxyColors.Blue;
                series1.MarkerType = OxyPlot.MarkerType.Circle;
                series1.MarkerSize = 5;

                pm.InvalidatePlot(true);
                //taomatran(5);
                //richTextBox1.SelectedText = Environment.NewLine + x_val + y_val;

                txtđiaiem.Clear();
                // taomang2chieu(x_val,y_val);

            }
        }
        private int layx()
        {
          
            int x = 0;
          
            
                x = point[i].X;
               

            
            return x;
        }
        private int layy()
        {

            int y = 0;

            for (int i = 0; i < point.Count; i++)
            {
                y = point[i].Y;


            }
            return y;
        }
        private double tinhkhoangcach()
        {
            double kc=0;
            for (int i = 0; i < point.Count; i++)
            {
                int x = layx();
                int y = layy();

                //for (int j = i + 1; j < point.Count; j++)
                //{
                kc = Math.Round((Math.Sqrt((((x - point[i].X) * (x - point[i].X)) + ((y - point[i].Y) * (y - point[i].Y))))), 0);
                //}
            }
            return kc;
        }
        //int n = point.Count;
        public void taomang2chieu(int x,int y)
        {
            

            for (i = 1; i <= point.Count; i++)
            {
                for (j = 1; j <= point.Count; j++)
                    if (c[i, j] >= 32000)
                        richTextBox1.Text += " " + "oo";
                    else
                        richTextBox1.Text += "  " + tinhkhoangcach();

                richTextBox1.Text += "\n";
            }
        }
        static int n, i, j, k, m, dau, cuoi;
        int[,] c = new int[50, 50];
        static int oo = 32000;
        private void GetRandomData()
        {
            Random ran = new Random();
            n = ran.Next(5, 10);
            for (i = 1; i <= 5; i++)
                for (j = i; j <= 5; j++)
                {
                    c[i, j] = ran.Next(1000);
                    if ((i != j) && (c[i, j] == 0)) //khong co duong di thi la vo cung

                    { c[i, j] = oo; }
                    //chu y:oo ta khai bao va khoi tao la ten bien nen muon viet ra oo thi phai cho vao trong xau

                    if (i == j)  //neu tren duong cheo chinh thi trong so la o
                    { c[i, j] = 0; }
                    //gán cho bên đối xứng
                    c[j, i] = c[i, j];
                }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            
        }

        private void taomatran(int n)
        {
            int[,] a = new int[20, 20];
            Random rd = new Random();
            int r = rd.Next(-9, 9);
            richTextBox1.Text = "\n";
           
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                {
                    a[i, j] = r;
                    a[i, i] = 1;
                }

            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                {
                    richTextBox1.Text += "" + a[i, j].ToString();
                    
                }
            
        }

        //void LoadDuLieuLenListView()
        //{

        //    //if (this.td != null)
        //    //{
        //        lvDanhSachDiem.Clear();
        //        for (int i = 0; i < 5; i++) this.lvDanhSachDiem.Columns.Add((i + 1).ToString());
        //        for (int i = 0; i < 5; i++)
        //        {
        //            ListViewItem lvit = new ListViewItem(ChuyenDoi(td.duLieu[i, 0]));
        //            for (int j = 1; j < 5; j++) lvit.SubItems.Add(new ListViewItem.ListViewSubItem().Text = ChuyenDoi(td.duLieu[i, j]));
        //            lvDanhSachDiem.Items.Add(lvit);
        //        }

        //        //440
        //        int witdh = (440 / this.lvDanhSachDiem.Columns.Count) - 1;
        //        for (int i = 0; i < this.lvDanhSachDiem.Columns.Count; i++) this.lvDanhSachDiem.Columns[i].Width = witdh;
        //    //}
        //}

        string ChuyenDoi(int so)
        {
            if (so == -1) return "∞";
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

        private void btntinh_Click(object sender, EventArgs e)
        {
            double kq = tinhkhoangcach();
            MessageBox.Show(kq.ToString());
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            plotView1.Model.InvalidatePlot(true);
            plotView1.Model.Series.Clear();
        }
    }
}
