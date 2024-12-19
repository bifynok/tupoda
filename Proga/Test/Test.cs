using Proga;

namespace Test
{
    class Test
    {
        static int Main()
        {
            if (!Case1()) return 1;
            if (!Case2()) return 1;
            if (!Case3()) return 1;
            if (!Case4()) return 1;
            if (!Case5()) return 1;
            return 0;
        }

        static bool Case1()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Case 1");
            Console.ResetColor();

            char[,] testMap = new char[5, 8] {
            {'.','.','.','.','.','.','.','.'},
            {'.','.','.','.','.','.','.','.'},
            {'.','.','x','x','x','.','.','.'},
            {'.','.','.','.','.','.','.','.'},
            {'.','.','.','.','.','.','.','.'}
        };

            char[,] expectedMap = new char[5, 8]
            {
            {'.','.','.','.','.','.','.','.'},
            {'.','.','.','x','.','.','.','.'},
            {'.','.','.','x','.','.','.','.'},
            {'.','.','.','x','.','.','.','.'},
            {'.','.','.','.','.','.','.','.'}
            };

            int testGen = 1;

            char[,] resultedMap = Life.Game(testMap, testGen);

            for (int row = 0; row < expectedMap.GetLength(0); row++)
            {
                for (int column = 0; column < expectedMap.GetLength(1); column++)
                {
                    if (resultedMap[row, column] != expectedMap[row, column])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Test failed!");
                        Console.ResetColor();
                        return false;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test succseed!");
            Console.ResetColor();
            return true;
        }

        static bool Case2()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Case 2");
            Console.ResetColor();

            char[,] testMap = new char[4, 3] {
            {'.','.','x'},
            {'x','.','.'},
            {'.','.','x'},
            {'.','.','.'}
        };

            char[,] expectedMap = new char[4, 3]
            {
            {'.','.','.'},
            {'.','.','.'},
            {'.','.','.'},
            {'.','.','.'}
            };

            int testGen = 5;

            char[,] resultedMap = Life.Game(testMap, testGen);

            for (int row = 0; row < expectedMap.GetLength(0); row++)
            {
                for (int column = 0; column < expectedMap.GetLength(1); column++)
                {
                    if (resultedMap[row, column] != expectedMap[row, column])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Test failed!");
                        Console.ResetColor();
                        return false;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test succseed!");
            Console.ResetColor();
            return true;
        }

        static bool Case3()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Case 3");
            Console.ResetColor();

            char[,] testMap = new char[6, 6] {
            {'.','.','.','.','.','.'},
            {'.','.','.','.','.','.'},
            {'.','x','.','x','.','x'},
            {'.','.','x','.','.','x'},
            {'.','.','.','x','.','.'},
            {'.','.','.','.','.','.'}
        };

            char[,] expectedMap = new char[6, 6]
            {
            {'.','.','.','.','.','.'},
            {'.','.','.','x','.','.'},
            {'.','.','x','.','x','.'},
            {'.','.','x','.','x','.'},
            {'.','.','.','x','.','.'},
            {'.','.','.','.','.','.'}
            };

            int testGen = 4;

            char[,] resultedMap = Life.Game(testMap, testGen);

            for (int row = 0; row < expectedMap.GetLength(0); row++)
            {
                for (int column = 0; column < expectedMap.GetLength(1); column++)
                {
                    if (resultedMap[row, column] != expectedMap[row, column])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Test failed!");
                        Console.ResetColor();
                        return false;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test succseed!");
            Console.ResetColor();
            return true;
        }

        static bool Case4()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Case 4");
            Console.ResetColor();

            char[,] testMap = new char[5, 8] {
            {'.','.','.','.','.','.','.','.'},
            {'.','.','.','.','.','.','.','.'},
            {'.','.','x','x','.','.','.','.'},
            {'.','.','x','.','.','.','.','.'},
            {'.','.','.','.','.','x','x','x'}
        };

            char[,] expectedMap = new char[5, 8]
            {
            {'.','.','.','.','.','.','x','.'},
            {'.','.','.','.','.','.','.','.'},
            {'.','.','x','x','.','.','.','.'},
            {'.','.','x','x','x','.','x','.'},
            {'.','.','.','.','.','.','x','.'}
            };

            int testGen = 3;

            char[,] resultedMap = Life.Game(testMap, testGen);

            for (int row = 0; row < expectedMap.GetLength(0); row++)
            {
                for (int column = 0; column < expectedMap.GetLength(1); column++)
                {
                    if (resultedMap[row, column] != expectedMap[row, column])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Test failed!");
                        Console.ResetColor();
                        return false;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test succseed!");
            Console.ResetColor();
            return true;
        }

        static bool Case5()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Case 5");
            Console.ResetColor();

            char[,] testMap = new char[8, 9] {
            {'.','.','.','.','x','.','.','.','.'},
            {'.','.','.','.','x','.','.','.','.'},
            {'.','.','.','.','x','.','.','.','.'},
            {'.','.','.','.','x','.','.','.','.'},
            {'.','.','.','.','x','.','.','.','.'},
            {'.','.','.','.','x','.','.','.','.'},
            {'.','.','.','.','x','.','.','.','.'},
            {'.','.','.','.','x','.','.','.','.'}
        };

            char[,] expectedMap = new char[8, 9]
            {
            {'x','.','.','.','.','.','.','.','x'},
            {'x','.','.','.','.','.','.','.','x'},
            {'x','.','.','.','.','.','.','.','x'},
            {'x','.','.','.','.','.','.','.','x'},
            {'x','.','.','.','.','.','.','.','x'},
            {'x','.','.','.','.','.','.','.','x'},
            {'x','.','.','.','.','.','.','.','x'},
            {'x','.','.','.','.','.','.','.','x'}
            };

            int testGen = 4;

            char[,] resultedMap = Life.Game(testMap, testGen);

            for (int row = 0; row < expectedMap.GetLength(0); row++)
            {
                for (int column = 0; column < expectedMap.GetLength(1); column++)
                {
                    if (resultedMap[row, column] != expectedMap[row, column])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Test failed!");
                        Console.ResetColor();
                        return false;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test succseed!");
            Console.ResetColor();
            return true;
        }
    }
}
