using System;

namespace MineSweeper
{
    class Program
    {
        static int[,] board = new int[20, 20];
        static bool[,] revealed = new bool[20, 20];
        static int mines = 40; // 20x20 alan için rastgele 40 mayın yerleştireceğiz

        static void Main(string[] args)
        {
            InitializeBoard();
            PlaceMines();
            CalculateNumbers();
            PlayGame();
        }

        static void InitializeBoard()
        {
            for (int i = 0; i < 20; i++)
                for (int j = 0; j < 20; j++)
                    revealed[i, j] = false;
        }

        static void PlaceMines()
        {
            Random rand = new Random();
            int placedMines = 0;
            while (placedMines < mines)
            {
                int x = rand.Next(0, 20);
                int y = rand.Next(0, 20);
                if (board[x, y] != -1)
                {
                    board[x, y] = -1; // -1 mayın olan hücreyi temsil ediyor
                    placedMines++;
                }
            }
        }

        static void CalculateNumbers()
        {
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    if (board[x, y] == -1) continue;
                    int mineCount = 0;
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            int nx = x + i, ny = y + j;
                            if (nx >= 0 && ny >= 0 && nx < 20 && ny < 20 && board[nx, ny] == -1)
                                mineCount++;
                        }
                    }
                    board[x, y] = mineCount;
                }
            }
        }

        static void PlayGame()
        {
            bool playing = true;
            while (playing)
            {
                Console.Clear();
                PrintBoard();
                Console.Write("Satır girin (0-19): ");
                int row = int.Parse(Console.ReadLine());
                Console.Write("Sütun girin (0-19): ");
                int col = int.Parse(Console.ReadLine());

                if (row < 0 || row >= 20 || col < 0 || col >= 20)
                {
                    Console.WriteLine("Geçersiz konum! Tekrar deneyin.");
                    continue;
                }

                if (board[row, col] == -1)
                {
                    Console.Clear();
                    PrintBoard(true);
                    Console.WriteLine("Mayına bastınız! Oyun bitti.");
                    playing = false;
                }
                else
                {
                    Reveal(row, col);
                    if (IsWin())
                    {
                        Console.Clear();
                        PrintBoard();
                        Console.WriteLine("Tebrikler! Tüm mayınları buldunuz.");
                        playing = false;
                    }
                }
            }
        }

        static void Reveal(int x, int y)
        {
            if (x < 0 || y < 0 || x >= 20 || y >= 20 || revealed[x, y]) return;
            revealed[x, y] = true;

            if (board[x, y] == 0)
            {
                for (int i = -1; i <= 1; i++)
                    for (int j = -1; j <= 1; j++)
                        Reveal(x + i, y + j);
            }
        }

        static bool IsWin()
        {
            for (int i = 0; i < 20; i++)
                for (int j = 0; j < 20; j++)
                    if (!revealed[i, j] && board[i, j] != -1)
                        return false;
            return true;
        }

        static void PrintBoard(bool showMines = false)
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (showMines && board[i, j] == -1)
                        Console.Write("* ");
                    else if (revealed[i, j])
                        Console.Write(board[i, j] + " ");
                    else
                        Console.Write(". ");
                }
                Console.WriteLine();
            }
        }
    }
}