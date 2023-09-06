using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_04
{
    class ToaDo
    {
        private string _ten;

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }

        private float _x;

        public float X
        {
            get { return _x; }
            set { _x = value; }
        }
        private float _y;

        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public ToaDo(string ten,float x,float y)
        {
            this.Ten = ten;
            this.X = x;
            this.Y = y;
        }



    }
}
