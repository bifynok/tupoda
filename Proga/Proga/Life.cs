namespace Proga
{
    class Life
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter path to file .txt, please");
                string filename = Console.ReadLine();

                (char[,] map, int generation) = ParseFile(filename);

                char[,] result = Game(map, generation);

                for (int row = 0; row < result.GetLength(0); row++)
                {
                    for (int column = 0; column < result.GetLength(1); column++)
                    {
                        Console.Write(result[row, column]);
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()); ;
            }
        }

        static (char[,], int) ParseFile(string filename)
        {
            string content = File.ReadAllText(filename);

            int generation = 0;
            int width = 0;
            int height = 0;

            int numbersFound = 0;

            foreach (char c in content)
            {
                if (numbersFound < 3)
                {
                    if (char.IsDigit(c))
                    {
                        numbersFound++;
                        int number = int.Parse(c.ToString());

                        if (numbersFound == 1)
                            generation = number;
                        else if (numbersFound == 2)
                            width = number;
                        else if (numbersFound == 3)
                            height = number;
                    }
                }
                else
                {
                    break;
                }
            }

            char[,] map = new char[width, height];

            int row = 0;
            int column = 0;

            foreach (char c in content)
            {
                if (c == '.' || c == 'x')
                {
                    map[row, column] = c;
                    column++;

                    if (column >= height)
                    {
                        column = 0;
                        row++;
                    }
                    if (row >= width)
                    {
                        break;
                    }
                }
            }


            return (map, generation);
        }

        public static char[,] Game(char[,] map, int generation)
        {
            while (generation > 0)
            {
                char[,] nextStep = CopyMap(map);
                for (int row = 0; row < map.GetLength(0); row++)
                {
                    for (int column = 0; column < map.GetLength(1); column++)
                    {
                        nextStep[row, column] = LifeCheck(map, row, column);
                    }
                }

                map = nextStep;
                generation--;
            }

            return map;
        }

        static char LifeCheck(char[,] map, int row, int column)
        {
            char res;

            bool isAlive = map[row, column] == 'x';

            int top = row - 1 < 0 ? map.GetLength(0) - 1 : row - 1;
            int bottom = row + 1 >= map.GetLength(0) ? 0 : row + 1;
            int left = column - 1 < 0 ? map.GetLength(1) - 1 : column - 1;
            int right = column + 1 >= map.GetLength(1) ? 0 : column + 1;

            int neightbors = 0;

            if (map[top, left] == 'x')
                neightbors++;
            if (map[top, column] == 'x')
                neightbors++;
            if (map[top, right] == 'x')
                neightbors++;
            if (map[row, right] == 'x')
                neightbors++;
            if (map[bottom, right] == 'x')
                neightbors++;
            if (map[bottom, column] == 'x')
                neightbors++;
            if (map[bottom, left] == 'x')
                neightbors++;
            if (map[row, left] == 'x')
                neightbors++;

            if (isAlive)
            {
                res = (neightbors > 1 && neightbors < 4) ? 'x' : '.';
            }
            else
            {
                res = neightbors == 3 ? 'x' : '.';
            }

            return res;
        }

        static char[,] CopyMap(char[,] map)
        {
            char[,] copy = new char[map.GetLength(0), map.GetLength(1)];
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    copy[i, j] = map[i, j];
                }
            }
            return copy;
        }
    }

}