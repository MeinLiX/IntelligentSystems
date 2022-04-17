namespace MazeGen_L3.Source;

class Maze
{
    public readonly int Width;
    public readonly int Height;
    public readonly Cell[,] Cells;
    public Stack<Cell> Path = new();
    public List<Cell> Solve = new();
    public List<Cell> Visited = new();
    public List<Cell> Neighbours = new();
    public Cell Start;
    public Cell Finish;

    public Maze(int width, int height)
    {
        Width = width;
        Height = height;
        Start = new Cell(1, 1, true, true);
        Finish = new Cell(Width - 3, Height - 3, true, true);
        Cells = new Cell[width, height];
        for (var i = 0; i < width; i++)
            for (var j = 0; j < height; j++)
                if (i % 2 != 0 && j % 2 != 0 && i < Width - 1 && j < Height - 1)
                    Cells[i, j] = new Cell(i, j);
                else
                    Cells[i, j] = new Cell(i, j, wall: true);
        Path.Push(Start);
        Cells[Start.X, Start.Y] = Start;
    }

    public void Build()
    {
        Cells[Start.X, Start.Y] = Start;
        while (Path.Count != 0)
        {
            Neighbours.Clear();
            SetNeighbours(Path.Peek(), 2);
            if (Neighbours.Count != 0)
            {
                Cell nextCell = GetRandomNeighbour();
                SetTroop(Path.Peek(), nextCell);
                Path.Push(nextCell);
            }
            else Path.Pop();
        }
    }
    public void BuildSolve()
    {
        bool flagFinish = false;
        Solve.Clear();
        Visited.Clear();
        Path.Clear();
        Path.Push(Start);
        foreach (Cell c in Cells)
            Cells[c.X, c.Y].Visited = Cells[c.X, c.Y].Wall;
        while (Path.Count != 0)
        {
            if (Path.Peek().X == Finish.X && Path.Peek().Y == Finish.Y)
                flagFinish = true;

            if (!flagFinish)
            {
                Neighbours.Clear();
                SetNeighbours(Path.Peek());
                if (Neighbours.Count != 0)
                {
                    Cell nextCell = GetRandomNeighbour();
                    Cells[nextCell.X, nextCell.Y].Visited = true;
                    Path.Push(nextCell);
                    Visited.Add(Path.Peek());
                }
                else Path.Pop();
            }
            else
            {
                Solve.Add(Path.Peek());
                Path.Pop();
            }
        }
    }

    private void SetNeighbours(Cell localcell, int distance = 1)
    {
        Cell[] possibleNeighbours = new[]
        {
                new Cell(localcell.X,            localcell.Y - distance),
                new Cell(localcell.X + distance, localcell.Y),
                new Cell(localcell.X,            localcell.Y + distance),
                new Cell(localcell.X - distance, localcell.Y)
            };
        for (int i = 0; i < 4; i++)
        {
            Cell neighbour = possibleNeighbours[i];
            if (neighbour.X > 0 && neighbour.X < Width && neighbour.Y > 0 && neighbour.Y < Height)
                if (!Cells[neighbour.X, neighbour.Y].Wall && !Cells[neighbour.X, neighbour.Y].Visited)
                    Neighbours.Add(neighbour);
        }
    }

    private Cell GetRandomNeighbour() => Neighbours[new Random().Next(Neighbours.Count)];

    private void SetTroop(Cell first, Cell second)
    {
        int xDiff = second.X - first.X;
        int yDiff = second.Y - first.Y;
        int addX = (xDiff != 0) ? xDiff / Math.Abs(xDiff) : 0;
        int addY = (yDiff != 0) ? yDiff / Math.Abs(yDiff) : 0;

        Cells[first.X + addX, first.Y + addY].Wall = false;
        Cells[first.X + addX, first.Y + addY].Visited = true;
        second.Visited = true;
        Cells[second.X, second.Y] = second;
    }
}
