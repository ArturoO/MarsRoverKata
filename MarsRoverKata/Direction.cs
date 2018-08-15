using System.Collections.Generic;

namespace MarsRoverKata
{
    public class Direction
    {
        public char Current = 'N';
        private readonly Dictionary<char, char> North = new Dictionary<char, char>() { { 'L', 'W' }, { 'R', 'E' } };
        private readonly Dictionary<char, char> East = new Dictionary<char, char>() { { 'L', 'N' }, { 'R', 'S' } };
        private readonly Dictionary<char, char> South = new Dictionary<char, char>() { { 'L', 'E' }, { 'R', 'W' } };
        private readonly Dictionary<char, char> West = new Dictionary<char, char>() { { 'L', 'S' }, { 'R', 'N' } };

        public void Rotate(char command)
        {
            if (Current == 'N') Current = North[command];
            else if (Current == 'E') Current = East[command];
            else if (Current == 'S') Current = South[command];
            else if (Current == 'W') Current = West[command];
        }

        public void TurnAround()
        {
            Rotate('R');
            Rotate('R');
        }
    }
    
}
