using System;

namespace _3dshapes {
    internal class RectangularPrism: Shape3D {
        /// <summary>
        /// Creates a rectangular prism object with set dimensions
        /// </summary>
        /// <param name="height">Height of the rectangular prism</param>
        /// <param name="width">Width of the rectangular prism</param>
        /// <param name="depth">Depth of the rectangular prism</param>
        public RectangularPrism(double height, double width, double depth) {
            Name = "Rectangular Prism";
            Height = height;
            Width = width;
            Depth = depth;
            Volume = Math.Round(Height * Width * Depth, 2);
        }
    }
}
