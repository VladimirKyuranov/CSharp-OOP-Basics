public class Guard
{
    public int Row { get; set; }
    public int Col { get; set; }
    public string Orientation { get; set; }

    public Guard(int row, int col, string orientation)
    {
        Row = row;
        Col = col;
        Orientation = orientation;
    }
}