using System;

namespace _3dshapes {
    internal class Pyramid: Shape3D {
        /// <summary>
        /// Creates a pyramid object with set dimensions
        /// </summary>
        /// <param name="height">Height of pyramid</param>
        /// <param name="width">Width of pyramid</param>
        /// <param name="depth">Depth of pyramid</param>
        public Pyramid(double height, double width, double depth) {
            Name = "Pyramid";
            Height = height;
            Width = width;
            Depth = depth;
            Volume = Math.Round((Width * Depth * Height) / 3, 2);
        }
    }
}
