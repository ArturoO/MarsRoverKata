using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata
{
    public class Coordinates: IEquatable<Coordinates>
    {
        public int X = 0;
        public int Y = 0;

        public Coordinates() { }

        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Coordinates(Coordinates coordinates)
        {
            X = coordinates.X;
            Y = coordinates.Y;
        }

        public bool Equals(Coordinates other)
        {
            return X == other.X && Y == other.Y;
        }
    }
}
