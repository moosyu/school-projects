using System;

namespace _3dshapes {
    internal class Cube: Shape3D {
        /// <summary>
        /// Creates a cube object with set dimensions
        /// </summary>
        /// <param name="height">Height of the cube</param>
        public Cube(double height) {
            Name = "Cube";
            Height = height;
            Volume = Math.Round(Math.Pow(height, 3), 2);
        }
    }
}
