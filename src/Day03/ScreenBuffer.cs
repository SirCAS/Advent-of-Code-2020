using System;

namespace Day03
{
    public class ScreenBuffer
    {
        private readonly string[] _data;
        private int Width => _data[0].Length;
        public int Height => _data.Length;

        public ScreenBuffer(string[] data)
        {
            _data = data;
        }

        public bool Get(int x, int y)
        {
            if (y >= Height)
            {
                throw new ArgumentOutOfRangeException(nameof(y), "Invalid height");
            }

            x = x % Width;

            return _data[y][x] == '#';
        }
    }
}