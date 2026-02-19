using System;

namespace _3dshapes {
    internal class Sphere: Shape3D {
        /// <summary>
        /// Creates a sphere object with set dimensions
        /// </summary>
        /// <param name="height">Height of sphere</param>
        public Sphere(double height) {
            Name = "Sphere";
            Height = height;
            Volume = Math.Round(4d/3d * Math.PI * Math.Pow(Height, 3), 2);
        }
    }
}
