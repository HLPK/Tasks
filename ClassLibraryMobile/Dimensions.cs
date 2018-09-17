using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse {
    public class Dimensions {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        private int numDimentions;

        public Dimensions(int x) {
            X = x;
            numDimentions = 1;
        }

        public Dimensions(int x, int y) {
            X = x;
            Y = y;
            numDimentions = 2;
        }

        public Dimensions(int x, int y, int z) {
            X = x;
            Y = y;
            Z = z;
            numDimentions = 3;
        }

        public override string ToString()
        {
            return X.ToString()+(numDimentions>1?"x"+Y.ToString():"")+(numDimentions > 2 ? "x" + Z.ToString() : "");
        }
    }
}
