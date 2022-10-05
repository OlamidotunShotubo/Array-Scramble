class Puzzle
{
    internal int Dimension { get; set; }
    internal int[,] Scramble()
    {
        Random rand = new Random();
        var check = new int[Dimension * Dimension];
        int[,] input = new int[Dimension, Dimension];
        int indx = 0;
        for (int r = 0; r < input.GetLength(0); r++)
        {
            for (int c = 0; c < input.GetLength(1); c++)
            {
                var value = 0;
                while (check.Contains(value))
                {
                    value = rand.Next(1, 10);
                }

                check[indx++] = value;
                input[r, c] = value;

            }
        }
        return input;
    }
}