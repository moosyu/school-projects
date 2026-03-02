using System;

namespace _3dshapes {
    internal class Cylinder: Shape3D {
        /// <summary>
        /// Creates a cylinder object with set dimensions
        /// </summary>
        /// <param name="height">Height of cylinder</param>
        /// <param name="width">Width of cylinder</param>
        public Cylinder(double height, double width) {
            Name = "Cylinder";
            Height = height;
            Width = width;
            Volume = Math.Round(Math.PI * Math.Pow(Width / 2, 2) * Height, 2);
        }
    }
}
