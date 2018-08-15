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
        public bool obstacle = false;

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

        public string Format()
        {
            return (obstacle ? "O:" : "") + X + ":" + Y + ":" + direction;
        }

        public void Move()
        {
            int nextX = X;
            int nextY = Y;

            if (direction == 'N')
            {
                if (nextY < 9)
                    nextY++;
                else
                    TurnAround();
            }
            else if (direction == 'S')
            {
                if (nextY > 0)
                    nextY--;
                else
                    TurnAround();
            }
            else if (direction == 'E')
            {
                if (nextX < 9)
                    nextX++;
                else
                    TurnAround();
            }
            else if (direction == 'W')
            {
                if (nextX > 0)
                    nextX--;
                else
                    TurnAround();
            }

            X = nextX;
            Y = nextY;

            //if (nextX==0 && nextY == 3)
            //{
            //    obstacle = true;
            //}
            //else
            //{
            //    X = nextX;
            //    Y = nextY;
            //}

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
