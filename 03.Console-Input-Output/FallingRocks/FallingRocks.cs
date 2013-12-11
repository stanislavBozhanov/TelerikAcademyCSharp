using System;
using System.Collections.Generic;
using System.Threading;


namespace FallingRocks
{
    class FallingRockInfo
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Str { get; set; }
        public ConsoleColor Color { get; set; }
    }

    class ScreenInfo
    {
        private static string[] strings = new string[] { "<->", ".", "*", ":(", "o.0", ":P" };
        private static string Person = "<O>";

        private Random random;

        public int PersonX { get; set; }
        public List<FallingRockInfo> Rocks { get; private set; }
        public int Points { get; set; }

        public ScreenInfo()
        {
            this.random = new Random();
            this.Rocks = new List<FallingRockInfo>();
            this.PersonX = (Console.BufferWidth - Person.Length) / 2;
        }

        public void Init()
        {
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
            Console.CursorVisible = false;
        }

        public void Erase()
        {
            Console.SetCursorPosition(0, Console.BufferHeight - 1);
            Console.Write(new string(' ', Console.BufferWidth - 1));
        }

        public void Draw()
        {
            foreach (var rock in this.Rocks)
            {
                Console.SetCursorPosition(rock.X, rock.Y);
                Console.ForegroundColor = rock.Color;
                Console.Write(rock.Str);
            }
            Console.SetCursorPosition(this.PersonX, Console.BufferHeight - 1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("<O>");

            Console.Title = "Points: " + this.Points;
        }

        public bool ReadInput()
        {
            bool moved = false;
            while (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    this.PersonX = Math.Max(0, this.PersonX - 1);
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    this.PersonX = Math.Min(Console.BufferWidth - Person.Length - 1, this.PersonX + 1);
                }
                moved = true;
            }
            return moved;
        }

        public void AddRandomRock()
        {
            string str = strings[random.Next(strings.Length)];
            var rock = new FallingRockInfo()
            {
                X = random.Next(Console.BufferWidth - str.Length),
                Y = 0,
                Str = str,
                Color = ConsoleColor.Cyan
            };
            this.Rocks.Add(rock);
        }

        public void MoveDown()
        {
            foreach (var rock in this.Rocks.ToArray())
            {
                rock.Y++;
                if (rock.Y >= Console.BufferHeight)
                {
                    this.Rocks.Remove(rock);
                }
            }
        }

        public bool CheckCollision()
        {
            foreach (var rock in this.Rocks)
            {
                if (rock.Y == Console.BufferHeight - 1 &&
                    rock.X > this.PersonX - rock.Str.Length &&
                    rock.X < this.PersonX + Person.Length)
                {
                    return true;
                }
            }
            return false;
        }

        internal void DrawGameOver()
        {
            Console.WriteLine("Game over! Points: " + this.Points);
        }
    }

    class FallingRocks
    {
        static void Main()
        {
            ScreenInfo playScreen = new ScreenInfo();
            playScreen.Init();
            while (true)
            {
                Console.Clear();

                playScreen.MoveDown();
                playScreen.AddRandomRock();

                for (int i = 0; i < 10; ++i)
                {
                    if (playScreen.ReadInput())
                    {
                        playScreen.Erase();
                    }
                    if (playScreen.CheckCollision())
                    {
                        playScreen.DrawGameOver();
                        return;
                    }

                    playScreen.Draw();
                    Thread.Sleep(10);
                }
                playScreen.Points++;
            }
        }
    }
}