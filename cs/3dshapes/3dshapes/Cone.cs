using System;

namespace _3dshapes {
    internal class Cone: Shape3D {
        /// <summary>
        /// Creates a sphere object with set dimensions
        /// </summary>
        /// <param name="height">Height of cone</param>
        /// <param name="width">Width of cone's base</param>
        public Cone(double height, double width) {
            Name = "Cone";
            Height = height;
            Width = width;
            Volume = Math.Round(Math.PI * (Width / 2) * Height, 2);
        }
    }
}
