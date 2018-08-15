using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata
{
    public class Coordinates
    {
        public char direction = 'N';
        public int X = 0;
        public int Y = 0;
        
        readonly Dictionary<char, char> North = new Dictionary<char, char>() { { 'L', 'W' }, { 'R', 'E' } };
        readonly Dictionary<char, char> East = new Dictionary<char, char>() { { 'L', 'N' }, { 'R', 'S' } };
        readonly Dictionary<char, char> South = new Dictionary<char, char>() { { 'L', 'E' }, { 'R', 'W' } };
        readonly Dictionary<char, char> West = new Dictionary<char, char>() { { 'L', 'S' }, { 'R', 'N' } };

        public void Execute(char command)
        {
            switch(command)
            {
                case 'R':
                case 'L':
                    Rotate(command);
                    break;
                case 'M':
                    Move();
                    break;
            }
        }

        public void Move()
        {
            if (direction == 'N')
            {
                if (Y < 9)
                    Y++;
                else
                    TurnAround();
            }
            else if (direction == 'S')
            {
                if (Y > 0)
                    Y--;
                else
                    TurnAround();
            }
            else if (direction == 'E')
            {
                if (X < 9)
                    X++;
                else
                    TurnAround();
            }
            else if (direction == 'W')
            {
                if (X > 0)
                    X--;
                else
                    TurnAround();
            }
        }

        public string Format()
        {
            return X + ":" + Y + ":" + direction;
        }

        public void Rotate(char command)
        {
            if (direction == 'N') direction = North[command];
            else if (direction == 'E') direction = East[command];
            else if (direction == 'S') direction = South[command];
            else if (direction == 'W') direction = West[command];
        }

        public void TurnAround()
        {
            Rotate('R');
            Rotate('R');
        }

    }
}
