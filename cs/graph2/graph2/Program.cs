using System.Text;

const int PADDING = 4;
HashSet<(int X, int Y)> coords = [];

using (StreamReader sr = new StreamReader("simple_graph_1.txt")) {
    string? line = sr.ReadLine();
    while (line != null) {
        string[] splitTest = line.Split();
        coords.Add((int.Parse(splitTest[0]), int.Parse(splitTest[1])));
        line = sr.ReadLine();
    }
}

string graph = buildGraph();

Console.WriteLine(graph);

using (StreamWriter sw = new("test.txt")) {
    sw.WriteLine(graph);
}

string buildGraph() {
    if (coords.Count < 1) {
        return "Coordinates empty!";
    }

    // faster lookups
    StringBuilder? sb = new();


    int maxX = 0;
    int maxY = 0;
    int minY = 0;
    foreach ((int X, int Y) point in coords) {
        maxX = Math.Max(maxX, point.X);
        maxY = Math.Max(maxY, point.Y);
        minY = Math.Min(minY, point.Y);
    }

    // find center, conversion to int truncates the value
    int centerY = (maxY + minY) / 2;

    // i tracks the height. inclusive because first spot is used up by graphing.
    for (int i = maxY; i >= minY; i--) {
        int label = i - centerY;
        // j tracks the width
        for (int j = 0; j <= maxX + 1; j++) {
            if (j == 0) {
                sb.Append($"{label,PADDING} {(label == 0 ? " +" : " |")}");
            } else {
                if (coords.Contains((j - 1, i))) {
                    sb.Append('x');
                } else if (label == 0) {
                    sb.Append('-');
                } else {
                    sb.Append(' ');
                }
            }
        }
        sb.AppendLine();
    }
    return sb.ToString();
}