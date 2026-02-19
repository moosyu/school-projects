namespace _3dshapes {
    /// <summary>
    /// A generic 3D shape class. Cannot be instantiated.
    /// All 3D shapes inherit these five properties.
    /// </summary>
    internal class Shape3D {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume { get; set; }
    }
}
