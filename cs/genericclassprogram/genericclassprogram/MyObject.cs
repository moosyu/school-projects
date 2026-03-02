using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericclassprogram {
    /// <summary>
    /// A generic class to represent how classes and objects are defined
    /// </summary>
    internal class MyObject {
        public int Parameter1 { get; set; }
        public string Parameter2 { get; set; }
        public bool Parameter3 { get; set; }
        /// <summary>
        /// A generic constructor method. Creates an instance of (object) of the class MyObject.
        /// </summary>
        /// <param name="p1">A random number</param>
        /// <param name="p2">A string</param>
        /// <param name="p3">A boolean, true by default</param>
        public MyObject(int p1, string p2) {
            Parameter1 = p1;
            Parameter2 = p2;
            Parameter3 = true;
        }
    }
}
