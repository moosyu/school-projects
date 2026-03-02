using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace results2dclass {
    internal class _2DList {
        public string Parameter1 { get; set; }
        public int Parameter2 { get; set; }

        public _2DList(string name, int score) {
            Parameter1 = name;
            Parameter2 = score;
        }
    }
}
