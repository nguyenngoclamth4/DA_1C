using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_1
{
    public class Point
    {
        public string tendiem { set; get; }
        public int X { set; get; }        // tên
        public int Y { set; get; }       // giá
        public string thoigian { set; get; }
        public Point(string tendiem1, int x, int y,string thoigian1)
        {
            tendiem = tendiem1; X = x; Y = y; thoigian = thoigian1;
        }
        //public Point(int x,int y)
        //{
        //    X = x;Y = y;
        //}
    }
}
