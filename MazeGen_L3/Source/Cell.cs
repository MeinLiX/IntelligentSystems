namespace MazeGen_L3.Source;

public struct Cell
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool Wall { get; set; }
    public bool Visited { get; set; }

    public Cell(int x, int y, bool visited = false, bool wall = false)
    {
        X = x;
        Y = y;
        Visited = visited;
        Wall = wall;
    }
}
