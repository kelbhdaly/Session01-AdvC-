using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01
{
    internal struct Point
    {

        #region Properties

        public int X { get; set; }
        public int Y { get; set; }

        #endregion

        #region Constructors

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"({X} , {Y})";
        }
        #endregion
    }
}
