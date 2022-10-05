var puzzle = new Puzzle();
puzzle.Dimension = 3;
var value = puzzle.Scramble();
for (int r = 0; r < value.GetLength(0); r++)
{
    for (int c = 0; c < value.GetLength(0); c++)
    {
        Console.Write(value[r, c] + " ");
    }
    Console.WriteLine();
}
Console.Read();