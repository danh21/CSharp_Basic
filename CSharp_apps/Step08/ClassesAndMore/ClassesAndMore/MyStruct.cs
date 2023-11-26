using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ClassesAndMore
{

    public struct MyPointStruct
    {
        int _x;
        int _y;

        public MyPointStruct(int anX, int aY)
        {
            _x = anX;
            _y = aY;
        }

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public Point asPoint()
        {
            return new Point(_x, _y);
        }
    }
}
